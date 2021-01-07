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
    public partial class reportedfirs : Form
 
    {
        public static string currentid;
        public static DataTable messegecontenttable = new DataTable();
        myfunctions getfunctions = new myfunctions();
        DataTable firtable = new DataTable();
        public reportedfirs()
        {
            InitializeComponent();
        }
        public void filldistricts()
        {
            comboBox1.Items.Add("Lahore");
            comboBox1.Items.Add("Sargodha");
            comboBox1.Items.Add("Islamabad");


        }
        private void complaintsdetail_Load(object sender, EventArgs e)
        {
            filldistricts();
        }
        private void fillwithlahore()
        {

            comboBox2.Items.Clear();
            comboBox2.Items.Add("Qurban Lines");
            comboBox2.Items.Add("Garhi Shahu");
            comboBox2.Items.Add("Naulakha Circle");

        }
        public void fillwithsargodha()
        {

            comboBox2.Items.Clear();
            comboBox2.Items.Add("Police Station Saddar");
            comboBox2.Items.Add("College Station Wapda town");
            comboBox2.Items.Add("Police Station Bhera");

        }
        public void fillwithislamabad()
        {

            comboBox2.Items.Clear();
            comboBox2.Items.Add("Blue Area station");
            comboBox2.Items.Add("I9 Police station");
            comboBox2.Items.Add("Karachi Company Police station");

        }
        private void reportedfirs_Load(object sender, EventArgs e)
        {
            filldistricts();
           
           

            /*getfunctions.readDatathroughAdapter("select * from fir_records", firtable);
            if(firtable.Rows.Count>0)
            {
                firlabelcount.Text = "Current number of Outstanding FIRs are" + " " + firtable.Rows.Count.ToString();
                firgrid.DataSource = firtable;
            }
            else
            {
                firlabelcount.Text = "There are no FIRs to review";
            }
            */

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            firtable.Rows.Clear();
            if (comboBox1.SelectedIndex == 0)
            {
                comboBox2.Text = string.Empty;
                fillwithlahore();
            }
            if (comboBox1.SelectedIndex == 1)
            {
                comboBox2.Text = string.Empty;
                fillwithsargodha();
            }

            if (comboBox1.SelectedIndex == 2)
            {
                comboBox2.Text = string.Empty;
                fillwithislamabad();
            }
            else
            {
                //dothis  
            }
           // comboBox1.Visible = fals
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            firtable.Rows.Clear();
            string policestation = comboBox2.Text;
            dataGridView1.DataSource = firtable;
            string query = "select * from fir_records where status='pending' AND policestations=" + "'" + policestation + "'";
            getfunctions.readDatathroughAdapter(query, firtable);
            string k = firtable.Rows.Count.ToString();
            firlabelcount.Text = "Numbers of ouststanding FIRs in" + " " + policestation + " " + "are" + " " + k;
          
         
        }

        private void readbtn_Click(object sender, EventArgs e)
        {
            string thispolicestation = comboBox2.Text;
            string thisid = uniqueidbox.Text;
            currentid = thisid;
            getfunctions.createConn();
            string query = "select * from fir_records where uniqueid=" + "'" + thisid + "'AND policestations="+ "'" + thispolicestation + "'";
            getfunctions.readDatathroughAdapter(query, messegecontenttable);
           
            readform displayreadform = new readform();
            displayreadform.Show();
            
        }

        private void returnhome_Click(object sender, EventArgs e)
        {
            
            //mainform displaymainform = new mainform();
            this.Close();
            //displaymainform.Show();
        }
    }
}
