using System;
using System.Web.Services;

namespace MathWebService
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    public class MathService : WebService
    {
        [WebMethod]
        public double Adunare(double a, double b)
        {
            return a + b;
        }

        [WebMethod]
        public double Scadere(double a, double b)
        {
            return a - b;
        }

        [WebMethod]
        public double Inmultire(double a, double b)
        {
            return a * b;
        }

        [WebMethod]
        public string Impartire(double a, double b)
        {
            if (b == 0)
            {
                return "Eroare: impartirea la zero nu este permisa.";
            }

            return (a / b).ToString();
        }
    }
}