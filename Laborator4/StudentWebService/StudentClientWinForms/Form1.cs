using System;
using System.Windows.Forms;

namespace StudentClientWinForms
{
    public partial class Form1 : Form
    {
        StudentReference.StudentService service =
            new StudentReference.StudentService();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);

            string mesaj = service.AdaugaStudent(
                id,
                txtNume.Text,
                txtPrenume.Text,
                txtSpecializare.Text
            );

            MessageBox.Show(mesaj);
        }

        private void btnAfisare_Click(object sender, EventArgs e)
        {
            listBoxStudenti.Items.Clear();

            StudentReference.Student[] studenti = service.AfisareStudenti();

            foreach (StudentReference.Student student in studenti)
            {
                listBoxStudenti.Items.Add(
                    "ID: " + student.ID +
                    " | Nume: " + student.Nume +
                    " | Prenume: " + student.Prenume +
                    " | Specializare: " + student.Specializare
                );
            }
        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);

            string rezultat = service.CautaStudentDupaID(id);

            MessageBox.Show(rezultat);
        }
    }
}