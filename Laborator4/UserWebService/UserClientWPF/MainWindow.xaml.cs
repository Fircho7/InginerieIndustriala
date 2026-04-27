using System.Windows;

namespace UserClientWPF
{
    public partial class MainWindow : Window
    {
        UserReference.UserService service = new UserReference.UserService();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Inregistrare_Click(object sender, RoutedEventArgs e)
        {
            string email = EmailTextBox.Text;
            string parola = PasswordBox.Password;

            string mesaj = service.InregistrareUtilizator(email, parola);

            MesajTextBlock.Text = mesaj;
            MessageBox.Show(mesaj);
        }

        private void Autentificare_Click(object sender, RoutedEventArgs e)
        {
            string email = EmailTextBox.Text;
            string parola = PasswordBox.Password;

            string mesaj = service.AutentificareUtilizator(email, parola);

            MesajTextBlock.Text = mesaj;
            MessageBox.Show(mesaj);
        }
    }
}