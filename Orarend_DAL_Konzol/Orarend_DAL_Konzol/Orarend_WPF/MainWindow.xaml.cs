using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Orarend_DAL_Konzol;


namespace Orarend_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public cnOrarendek orarendek;
        public cnLogin login;
        SqlConnection sqlconn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Training\timetable_exam\Orarend_DAL_Konzol\Orarend_DAL_Konzol\Orarend_DAL_Konzol\Orarend_DB.mdf;Integrated Security=True;Connect Timeout=30");


        public MainWindow()
        {

            InitializeComponent();
            orarendek = new cnOrarendek();
            login = new cnLogin();



        }

        private void MiMentes_Click(object sender, RoutedEventArgs e)
        {
            orarendek.SaveChanges();
        }

        private void MiKilepes_Click(object sender, RoutedEventArgs e)
        {
            var err = MessageBox.Show("Menteni akarod az adatokat kilépés előtt?", "Kérdés", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);
            switch (err)
            {
                case MessageBoxResult.OK:
                    orarendek.SaveChanges();
                    Application.Current.Shutdown();

                    break;

                case MessageBoxResult.No:
                    Application.Current.Shutdown();
                    break;
                case MessageBoxResult.Cancel:
                    break;
            }
        }

        private void MiHetiOrarend_Click(object sender, RoutedEventArgs e)
        {
            dgAdatracs.Visibility = Visibility.Visible;
        }

        private void MiHazifeladatok_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MiTantargyak_Click(object sender, RoutedEventArgs e)
        {
            frmAdatfelvitel adatfelvitel = new frmAdatfelvitel();
            adatfelvitel.ShowDialog();
            MainWindow main = new MainWindow();
            main.Visibility = Visibility.Hidden;
        }

        private void MiExportXml_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void MiImportXml_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MiNevjegy_Click(object sender, RoutedEventArgs e)
        {
            Nevjegy nevjegy = new Nevjegy();
            nevjegy.ShowDialog();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {   
            frmLogin login = new frmLogin();
            login.ShowDialog();
            
            MainWindow main = new MainWindow();
            main.Visibility = Visibility.Hidden;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            dgAdatracs.Visibility = Visibility.Visible;
            var lekerdez = new List<Tantargyak>();
            foreach (var x in orarendek.enTantargyak)
            {
                lekerdez.Add(new Tantargyak()
                {
                    Tantargy = x.Tantargy_neve,
                   



                });

            }
            dgAdatracs.ItemsSource = lekerdez;
        }
    }
}
