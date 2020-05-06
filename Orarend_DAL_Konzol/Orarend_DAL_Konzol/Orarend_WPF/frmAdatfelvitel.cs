using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tothj\source\repos\Nyilvantartas_Program\Nyilvantartas_Program\DB\Nyilvantartas.mdf;Integrated Security=True;Connect Timeout=30");

    }
}
