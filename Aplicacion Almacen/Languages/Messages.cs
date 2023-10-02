using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_Almacen.Languages
{
    public static class Messages
    {
        public static string ProductFound => LanguageManager.GetString("ProductFound");
        public static string ProductNotFound => LanguageManager.GetString("ProductNotFound");
        public static string Error => LanguageManager.GetString("Error");
        public static string ErrorSyntax => LanguageManager.GetString("ErrorSyntax");
        public static string CompleteAllBoxAndStatus => LanguageManager.GetString("CompleteAllBoxAndStatus");
        public static string Successful => LanguageManager.GetString("Successful");
        public static string SelectAnIndex => LanguageManager.GetString("SelectAnIndex");
    }

}
