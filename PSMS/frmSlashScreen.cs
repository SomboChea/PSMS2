using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSMS
{
    public partial class frmSlashScreen : MetroForm
    {
        public frmSlashScreen()
        {
            InitializeComponent();
        }
        Timer tmr;
        private void frmSlashScreen_Load(object sender, EventArgs e)
        {
            tmr = new Timer();

            //set time interval 3 sec

            tmr.Interval = 5000;

            //starts the timer

            tmr.Start();

            tmr.Tick += tmr_Tick;
        }
        void tmr_Tick(object sender, EventArgs e)
        {

            //after 3 sec stop the timer

            tmr.Stop();

            //display mainform

            frmLogin login = new frmLogin();
            login.Show();
            //hide this form

            this.Hide();

        }
        private void metroProgressSpinner1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin login = new frmLogin();
            login.ShowDialog();
        }
    }
}
