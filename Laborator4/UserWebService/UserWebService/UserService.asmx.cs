using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Services;

namespace UserWebService
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    public class UserService : WebService
    {
        private string FilePath
        {
            get
            {
                return HttpContext.Current.Server.MapPath("~/App_Data/users.txt");
            }
        }

        [WebMethod]
        public bool ValidareEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        [WebMethod]
        public bool ValidareParola(string parola)
        {
            if (string.IsNullOrWhiteSpace(parola))
                return false;

            bool areMinim8Caractere = parola.Length >= 8;
            bool contineLitera = parola.Any(char.IsLetter);
            bool contineCifra = parola.Any(char.IsDigit);

            return areMinim8Caractere && contineLitera && contineCifra;
        }

        [WebMethod]
        public string InregistrareUtilizator(string email, string parola)
        {
            if (!ValidareEmail(email) || !ValidareParola(parola))
                return "Date invalide";

            Directory.CreateDirectory(Path.GetDirectoryName(FilePath));

            if (File.Exists(FilePath))
            {
                string[] utilizatori = File.ReadAllLines(FilePath);

                foreach (string utilizator in utilizatori)
                {
                    string[] date = utilizator.Split(';');

                    if (date.Length >= 2 && date[0] == email)
                        return "Utilizatorul există deja";
                }
            }

            File.AppendAllText(FilePath, email + ";" + parola + Environment.NewLine);

            return "Utilizator înregistrat cu succes";
        }

        [WebMethod]
        public string AutentificareUtilizator(string email, string parola)
        {
            if (!File.Exists(FilePath))
                return "Date de autentificare invalide";

            string[] utilizatori = File.ReadAllLines(FilePath);

            foreach (string utilizator in utilizatori)
            {
                string[] date = utilizator.Split(';');

                if (date.Length >= 2 && date[0] == email && date[1] == parola)
                    return "Autentificare reușită";
            }

            return "Date de autentificare invalide";
        }
    }
}