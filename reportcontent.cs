using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.Sql;
using System.Data.SqlClient;




namespace projecttest
{
    public partial class reportcontent : Form
    {
        public static string uniqueid;
       public static DataTable userinfo = new DataTable();
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
            userinfo.Columns.Add("uniqueid");
        }
      
         //   string path = path.GetRandomFileName();
        //    path = path.Replace(".", ""); 
          
       
        public reportcontent()
        {
            InitializeComponent();
        }
        private string generaterandomstring()
        {
            string path = Path.GetRandomFileName();
            path = path.Replace(".", "");
            return path;
          //  MessageBox.Show(path.ToUpper());
        }
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to want to sumbit this report", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.OK)
            {

                if (time.Text == string.Empty || placeofincident.Text == string.Empty || messegecontent.Text == string.Empty)
                {
                    MessageBox.Show("Please fill all fields");
                }
                else
                {
                    if (messegecontent.Text.Length > 10)
                    {
                        userinfostruct();
                        uniqueid = generaterandomstring();
                        userinfo.Rows.Add(complaintsdetail.vname, complaintsdetail.vfathername, complaintsdetail.vcnic, complaintsdetail.vmobile, complaintsdetail.vhomedistrict, complaintsdetail.vpolicestation, dateofincidentpicker.Value.ToShortDateString(), time.Text, placeofincident.Text, messegecontent.Text, uniqueid);
                        testingform display = new testingform();


                        SqlCommand insertcommand = new SqlCommand("insert into fir_records(name,fathername,cnic,mobile,homedistrict,policestations,dateofincident,timeofincident,placeofincident,messegecontent,uniqueid) values (@cname,@cfathername,@ccnic,@cmobile,@chomedistrict,@cpolicestations,@cdateofincident,@ctimeofincident,@cplaceofincident,@cmessegecontent,@cuniqueid)");
                        insertcommand.Parameters.AddWithValue("@cname", complaintsdetail.vname);
                        insertcommand.Parameters.AddWithValue("@cfathername", complaintsdetail.vfathername);
                        insertcommand.Parameters.AddWithValue("@ccnic", complaintsdetail.vcnic);
                        insertcommand.Parameters.AddWithValue("@cmobile", complaintsdetail.vmobile);
                        insertcommand.Parameters.AddWithValue("@chomedistrict", complaintsdetail.vhomedistrict);
                        insertcommand.Parameters.AddWithValue("@cpolicestations", complaintsdetail.vpolicestation);
                        insertcommand.Parameters.AddWithValue("@cdateofincident", dateofincidentpicker.Value.ToShortDateString());
                        insertcommand.Parameters.AddWithValue("@ctimeofincident", time.Text);
                        insertcommand.Parameters.AddWithValue("@cplaceofincident", placeofincident.Text);
                        insertcommand.Parameters.AddWithValue("@cmessegecontent", messegecontent.Text);
                        insertcommand.Parameters.AddWithValue("@cuniqueid", uniqueid);
                        myfunctions object1 = new myfunctions();
                        object1.executeQuery(insertcommand);
                        this.Hide();
                        display.Show();
                    }
                    else
                    {
                        MessageBox.Show("Report content lenght Should be More than 10 Characters");
                    }
                }
            }
        }
    }
}
