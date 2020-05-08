using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Orarend_DAL_Konzol;

namespace Orarend_WPF
{
    public partial class frmLogin: Form

    {
        frmLogin login = new frmLogin();
        MainWindow ablak = new MainWindow();

        public frmLogin()
        {
            InitializeComponent();
            setTooltip();
        }
        private void setTooltip() {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(this.txUsername, "Add meg a felhasználónevet");
            tip.SetToolTip(this.txtPassword, "Add meg a jelszót");


        }


        //Belépést adatbázisadatból csinálja

        private void btBelepes_Click(object sender, EventArgs e) {
            SqlConnection conn = new SqlConnection(@"Data source=(LocalDB)\MSSQLLocalDB;attachdbfilename=D:\Training\timetable_exam\Orarend_DAL_Konzol\Orarend_DAL_Konzol\Orarend_DAL_Konzol\Login.mdf;integrated security=True;connect timeout=30");
            string query = "SELECT * FROM enLoginok WHERE Username='" + txUsername.Text.Trim() + "'and Password ='" + txtPassword.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                this.Hide();




            }
            else
            {
                MessageBox.Show("Rossz felhasználónevet/jelszót adott meg", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        //Kilépésgomb
        private void btKilepgomb_Click(object sender, EventArgs e)
        {
            Application.Exit();


        }


        private void frmLogin_Load(object sender, EventArgs e)
        {
            login.ShowDialog();
            ablak.Visibility = System.Windows.Visibility.Hidden;
            this.ActiveControl = txUsername;
        }
    }
}
