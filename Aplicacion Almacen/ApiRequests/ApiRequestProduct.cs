using Aplicacion_Almacen.StoreHouseRequests;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;

namespace Aplicacion_Almacen.APIRequests
{
    public class ApiRequestProduct
    {
        private readonly string baseUrl;

        public ApiRequestProduct(string baseUrl)
        {
            this.baseUrl = baseUrl;
        }

        public List<ProductInterface> GetProducts()
        {
            try
            {
                RestClient client = new RestClient(baseUrl);
                RestRequest request = new RestRequest("/api/v1/productos", Method.Get);
                request.AddHeader("Accept", "application/json");
                RestResponse response = client.Execute(request);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    // Intenta deserializar la respuesta
                    List<ProductInterface> products = JsonConvert.DeserializeObject<List<ProductInterface>>(response.Content);
                    return products;
                }
                else
                {
                    // Maneja el caso en que la solicitud no fue exitosa
                    Console.WriteLine("Error al obtener productos: " + response.StatusCode);
                    return null; // O lanza una excepción si prefieres
                }
            }
            catch (Exception ex)
            {
                // Maneja otras excepciones aquí
                Console.WriteLine("Error en la solicitud: " + ex.Message);
                return null; // O lanza una excepción si prefieres
            }
        }



        public bool DeleteProduct(int productId)
        {
            try
            {
                RestClient client = new RestClient(baseUrl);
                RestRequest request = new RestRequest($"/api/v1/productos/{productId}", Method.Delete);
                request.AddHeader("Accept", "application/json");

                RestResponse response = client.Execute(request);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public bool AddProduct(ProductInterface product)
        {
            try
            {
                RestClient client = new RestClient(baseUrl);
                RestRequest request = new RestRequest("/api/v1/productos", Method.Post);
                request.AddHeader("Accept", "application/json");
                request.AddHeader("Content-Type", "application/json");
                request.AddJsonBody(product);

                RestResponse response = client.Execute(request);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool UpdateProduct(ProductInterface product)
        {
            try
            {
                RestClient client = new RestClient(baseUrl);
                RestRequest request = new RestRequest($"/api/v1/productos/{product.IDProduct}", Method.Put);
                request.AddHeader("Accept", "application/json");
                request.AddHeader("Content-Type", "application/json");
                request.AddJsonBody(product);

                RestResponse response = client.Execute(request);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


    }
}
