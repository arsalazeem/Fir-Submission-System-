using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace projecttest
{
    public partial class mainform : Form
    {
        myfunctions functions = new myfunctions();
           //register
        public void startapp()
        {
            Application.Run(new Form1());
        }
        public mainform()
        {
            Thread t = new Thread(new ThreadStart(startapp));
            t.Start();
            Thread.Sleep(10);         
            InitializeComponent();
            t.Abort();
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {
            complaintsdetail displaycomplaintsdetail = new complaintsdetail();
            this.Hide();
            displaycomplaintsdetail.Show();
        }

        private void regiserfirbtn_Click(object sender, EventArgs e)
        {
            complaintsdetail displaycomplaintsdetail = new complaintsdetail();
            displaycomplaintsdetail.Show();
        }

        private void policeloginbtn_Click(object sender, EventArgs e)
        {
            reportedfirs displayreportedfirs = new reportedfirs();
            displayreportedfirs.Show();
        }

        private void chechstatusbtn_Click(object sender, EventArgs e)
        {
            usercheckstatus displayusercheckstatus = new usercheckstatus();
            displayusercheckstatus.Show();
        }
    }
}
