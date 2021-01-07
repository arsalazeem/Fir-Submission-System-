using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace projecttest
{
    public partial class readform : Form
    {
        public static DataTable reportcontenttable = new DataTable();
        public readform()
        {
            InitializeComponent();
        }

        private void readform_Load(object sender, EventArgs e)
        {
            
            richTextBox1.Text = reportedfirs.messegecontenttable.Rows[0][9].ToString();
        }

        private void acceptbtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to want to sumbit this report", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                string thisid = reportedfirs.currentid;
                SqlCommand acceptedcommand = new SqlCommand("UPDATE fir_records SET status= 'accepted' where uniqueid=" + "'" + thisid + "'");
                myfunctions displayfunction = new myfunctions();
                displayfunction.executeQuery(acceptedcommand);
                reportedfirs displayreportedfirs = new reportedfirs();
                this.Close();
                displayreportedfirs.Show();

                
            }
            else
            {
                //stayhere
            }
         
        }

        private void rejectbtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to Reject this report", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                string thisid = reportedfirs.currentid;
                SqlCommand acceptedcommand = new SqlCommand("UPDATE fir_records SET status= 'rejected' where uniqueid=" + "'" + thisid + "'");
                myfunctions displayfunction = new myfunctions();
                displayfunction.executeQuery(acceptedcommand);
                reportedfirs displayreportedfirs = new reportedfirs();
                this.Close();
                displayreportedfirs.Show();


            }
            else
            {
                //stayhere
            }
        }
    }
}
