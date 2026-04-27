using System;
using System.Windows.Forms;

namespace FilmClientWinForms
{
    public partial class Form1 : Form
    {
        FilmReference.FilmService service = new FilmReference.FilmService();

        private FilmReference.Film[] filmeCurente;

        public Form1()
        {
            InitializeComponent();
        }

        private void AfiseazaLista(FilmReference.Film[] filme)
        {
            filmeCurente = filme;
            listBoxFilme.Items.Clear();

            foreach (FilmReference.Film film in filme)
            {
                listBoxFilme.Items.Add(
                    "ID: " + film.Id +
                    " | Titlu: " + film.Titlu +
                    " | Gen: " + film.Gen +
                    " | An: " + film.An +
                    " | Rating: " + film.Rating
                );
            }
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtAn.Text, out int an))
            {
                MessageBox.Show("Introdu un an valid.");
                return;
            }

            if (!double.TryParse(txtRating.Text, out double rating))
            {
                MessageBox.Show("Introdu un rating valid.");
                return;
            }

            string mesaj = service.AdaugaFilm(
                txtTitlu.Text,
                txtGen.Text,
                an,
                rating
            );

            MessageBox.Show(mesaj);
            AfiseazaLista(service.AfiseazaFilme());
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("Introdu un ID valid.");
                return;
            }

            if (!int.TryParse(txtAn.Text, out int an))
            {
                MessageBox.Show("Introdu un an valid.");
                return;
            }

            if (!double.TryParse(txtRating.Text, out double rating))
            {
                MessageBox.Show("Introdu un rating valid.");
                return;
            }

            string mesaj = service.ModificaFilm(
                id,
                txtTitlu.Text,
                txtGen.Text,
                an,
                rating
            );

            MessageBox.Show(mesaj);
            AfiseazaLista(service.AfiseazaFilme());
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("Introdu un ID valid.");
                return;
            }

            string mesaj = service.StergeFilm(id);

            MessageBox.Show(mesaj);
            AfiseazaLista(service.AfiseazaFilme());
            GolesteCampurile();
        }

        private void btnAfiseaza_Click(object sender, EventArgs e)
        {
            AfiseazaLista(service.AfiseazaFilme());
        }

        private void btnFiltreaza_Click(object sender, EventArgs e)
        {
            AfiseazaLista(service.FiltreazaDupaGen(txtGen.Text));
        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            AfiseazaLista(service.CautaDupaTitlu(txtTitlu.Text));
        }

        private void listBoxFilme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFilme.SelectedIndex < 0 || filmeCurente == null)
                return;

            FilmReference.Film film = filmeCurente[listBoxFilme.SelectedIndex];

            txtId.Text = film.Id.ToString();
            txtTitlu.Text = film.Titlu;
            txtGen.Text = film.Gen;
            txtAn.Text = film.An.ToString();
            txtRating.Text = film.Rating.ToString();
        }

        private void btnGoleste_Click(object sender, EventArgs e)
        {
            GolesteCampurile();
        }

        private void GolesteCampurile()
        {
            txtId.Clear();
            txtTitlu.Clear();
            txtGen.Clear();
            txtAn.Clear();
            txtRating.Clear();

            listBoxFilme.ClearSelected();
        }
    }
}