using System;
using System.Collections.Generic;
using System.Text;

namespace Factorizacion
{
   public class Operaciones
    {
        public string MostrarFuncion4(string a, string b, string c, string d, string e)
        {
            return a + "*X^4" + " + " + b + "*X^3" + " + " + c + "*X^2" + " + " + d + "*X" + " + " + e;
        }

        public string MostrarFuncion3(string a, string b, string c, string d)
        {
            return a + "*X^3" + " + " + b + "*X^2" + " + " + c + "*X" + " + " + d;
        }

        public string MostrarFuncion2(string a, string b, string c)
        {
            return a + "*X^2" + " + " + b + "*X" + " + " + c ;
        }
    }
}
