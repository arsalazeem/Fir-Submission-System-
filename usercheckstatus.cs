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
    public partial class usercheckstatus : Form
    {
        DataTable checktable = new DataTable();
        myfunctions getfunctions = new myfunctions();
        public usercheckstatus()
        {
            InitializeComponent();
        }

        private void tokencheckbtn_Click(object sender, EventArgs e)
        {
            string thisuniqueid = tokenid.Text;
         string query="select * from fir_records where uniqueid=" + "'" + thisuniqueid + "'";
            getfunctions.readDatathroughAdapter(query, checktable);
            if (checktable.Rows.Count < 1)
            {
                MessageBox.Show("There is an invalid ID Please Enter correct ID","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
              //  labelstatusnew.Text = 
                    string temp=checktable.Rows[0][11].ToString();
                labelstatusnew.Text = temp.ToUpper();
            }

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            //mainform displaymainform = new mainform();
            this.Close();
           // displaymainform.Show();
        }

        private void usercheckstatus_Load(object sender, EventArgs e)
        {
            //
        }
    }
}
