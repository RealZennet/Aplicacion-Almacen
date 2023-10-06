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
                    List<ProductInterface> products = JsonConvert.DeserializeObject<List<ProductInterface>>(response.Content);
                    return products;
                }
                else
                {
                    Console.WriteLine("Error al obtener productos: " + response.StatusCode);
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en la solicitud: " + ex.Message);
                return null;
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

        public ProductInterface GetProductById(int productId)
        {
            try
            {
                RestClient client = new RestClient(baseUrl);
                RestRequest request = new RestRequest($"/api/v1/productos/{productId}", Method.Get);
                request.AddHeader("Accept", "application/json");

                RestResponse response = client.Execute(request);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    ProductInterface product = JsonConvert.DeserializeObject<ProductInterface>(response.Content);
                    return product;
                }
                else
                {
                    throw new Exception("Error al obtener el producto por ID: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la solicitud: " + ex.Message);
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
