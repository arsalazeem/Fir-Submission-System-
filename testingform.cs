using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projecttest
{
    public partial class testingform : Form
    {
        public testingform()
        {
            InitializeComponent();
        }

        private void testingform_Load(object sender, EventArgs e)
        {
            token.Text = "Please Remember this ID:"+" "+reportcontent.uniqueid;
            dataGridView1.DataSource = reportcontent.userinfo;
        }

        private void homescreen_Click(object sender, EventArgs e)
        {
            this.Close();
          //  mainform displaymainform = new mainform();
          //  displaymainform.Show();

        }
    }
}
