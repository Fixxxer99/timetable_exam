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
    public partial class frmLogin: Form

            
    {
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

        }

        //Kilépésgomb
        private void btKilepgomb_Click(object sender, EventArgs e)
        {
            Application.Exit();


        }


        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txUsername;
        }
    }
}
