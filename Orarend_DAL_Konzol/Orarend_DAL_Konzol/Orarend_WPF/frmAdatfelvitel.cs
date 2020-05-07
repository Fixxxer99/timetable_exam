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
    public partial class frmAdatfelvitel : Form

    {
        cnOrarendek orarendek = new cnOrarendek();
        public frmAdatfelvitel()
        {
            InitializeComponent();
        }

        //Adatbáziskapcsolat létrehozása
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Training\timetable_exam\Orarend_DAL_Konzol\Orarend_DAL_Konzol\Orarend_DAL_Konzol\Orarend_DB.mdf;Integrated Security=True;Connect Timeout=30");

        private void frmAdatfelvitel_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

       
        //Adatbáziselem mentése
        private void tbMent_Click(object sender, EventArgs e)
        {

        }
        //Adatbáziselem módosítás
        private void tbModosit_Click(object sender, EventArgs e)
        {

        }
        //Adatbáziselem törlése
        private void tbTorles_Click(object sender, EventArgs e)
        {

        }
        //Adatbáziselem lekérdezése
        private void tbLekerdez_Click(object sender, EventArgs e)
        {

        }
        //Kilépés
        private void tbKilep_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
