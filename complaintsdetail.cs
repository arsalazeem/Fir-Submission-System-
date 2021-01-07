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
    public partial class complaintsdetail : Form
    {
        public static string vname, vfathername, vcnic, vmobile, vhomedistrict, vpolicestation;
        DataTable userinfo = new DataTable();
        reportcontent displayreportcontent = new reportcontent();
        public complaintsdetail()
        {
            InitializeComponent();
        }
        public void userinfostruct()
        {
            userinfo.Columns.Add("name");
            userinfo.Columns.Add("fathername");
            userinfo.Columns.Add("cnic");
            userinfo.Columns.Add("mobile");
            userinfo.Columns.Add("homedistrict");
            userinfo.Columns.Add("policestations");
            userinfo.Columns.Add("Dateofincident");
            userinfo.Columns.Add("timeofincident");
            userinfo.Columns.Add("placeofincident");
            userinfo.Columns.Add("messegecontent");
        }
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
           if(name.Text==string.Empty || fathername.Text==string.Empty || cnic.Text == string.Empty || comboBox2.SelectedIndex==-1 ||comboBox1.SelectedIndex==-1)
            {
                MessageBox.Show("Please Fill all Neccesary Field","Warning");
            }
           else
            {

                /* userinfostruct();
                 userinfo.Rows.Add(name.Text, fathername.Text, cnic.Text, mobile.Text,comboBox1.SelectedItem.ToString(),comboBox2.SelectedItem.ToString());
                 dataGridView1.DataSource = userinfo;*/
                vname = name.Text;
                vfathername = fathername.Text;
                vcnic = cnic.Text;
                vmobile = mobile.Text;
                vhomedistrict = comboBox1.SelectedItem.ToString();
                vpolicestation = comboBox2.SelectedItem.ToString();
                this.Hide();
                displayreportcontent.Show();


            }
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
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                fillwithlahore();
            }
            if (comboBox1.SelectedIndex == 1)
            {

                fillwithsargodha();
            }

            if (comboBox1.SelectedIndex == 2)
            {
                fillwithislamabad();
            }
            else
            {
              //donothing
            }
        }
    }
}
