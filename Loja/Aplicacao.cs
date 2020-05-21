using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Loja
{
    public class Aplicacao
    {
        public static string ConnectionString() 
        {
            return ConfigurationManager.ConnectionStrings["stringConnect"].ConnectionString;
        }
    }
}
