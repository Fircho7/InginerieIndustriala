using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Services;

namespace StudentWebService
{
    public class Student
    {
        public int ID { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Specializare { get; set; }
    }

    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    public class StudentService : WebService
    {
        private static List<Student> studenti = new List<Student>();

        [WebMethod]
        public string AdaugaStudent(int id, string nume, string prenume, string specializare)
        {
            Student existent = studenti.FirstOrDefault(s => s.ID == id);

            if (existent != null)
                return "Studentul există deja";

            Student student = new Student
            {
                ID = id,
                Nume = nume,
                Prenume = prenume,
                Specializare = specializare
            };

            studenti.Add(student);

            return "Student adăugat cu succes";
        }

        [WebMethod]
        public Student[] AfisareStudenti()
        {
            return studenti.ToArray();
        }

        [WebMethod]
        public string CautaStudentDupaID(int id)
        {
            Student student = studenti.FirstOrDefault(s => s.ID == id);

            if (student == null)
                return "Studentul nu a fost găsit";

            return "ID: " + student.ID +
                   ", Nume: " + student.Nume +
                   ", Prenume: " + student.Prenume +
                   ", Specializare: " + student.Specializare;
        }
    }
}