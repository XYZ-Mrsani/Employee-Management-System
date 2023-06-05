using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EmpManagement
{
    public partial class EditEmp : Form
    {
        public EditEmp()
        {
            InitializeComponent();
        }
        //SqlConnection Con = new SqlConnection(@"Server=tcp:kryptonsani.database.windows.net,1433;Initial Catalog=MyEmployeeDb;Persist Security Info=False;User ID=adminsani;Password=Sani@2002;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C#_Projects\EmpManagement\MyEmployeeDb1.mdf;Integrated Security=True;Connect Timeout=30");
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }
        private void populate()
        {
            Con.Open();
            string query = "select * from EmployeeTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            EmpDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void EmpDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EmpIdTb.Text = EmpDGV.SelectedRows[0].Cells[0].Value.ToString();
            EmpNameTb.Text = EmpDGV.SelectedRows[0].Cells[1].Value.ToString();
            EmpAddTb.Text = EmpDGV.SelectedRows[0].Cells[2].Value.ToString();
            EmpEduCb.Text = EmpDGV.SelectedRows[0].Cells[6].Value.ToString();
            EmpPosCb.Text = EmpDGV.SelectedRows[0].Cells[3].Value.ToString();
            EmpPhoneTb.Text = EmpDGV.SelectedRows[0].Cells[5].Value.ToString();
            EmpGenCb.Text = EmpDGV.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void EditEmp_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (EmpIdTb.Text == "" || EmpNameTb.Text == "" || EmpPhoneTb.Text == "" || EmpAddTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update EmployeeTbl set Empname='" + EmpNameTb.Text + "',empadd='" + EmpAddTb.Text + "',emppos='" + EmpPosCb.SelectedItem.ToString() + "',empdob='" + EmpDob.Value.Date + "',empphone='" + EmpPhoneTb.Text + "',empedu='" + EmpEduCb.SelectedItem.ToString() + "',empgen='" + EmpGenCb.SelectedItem.ToString() + "' where Empid='" + EmpIdTb.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Updated Successfully");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void EmpGenCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void EmpEduCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void EmpDob_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void EmpPosCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EmpPhoneTb_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void EmpAddTb_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void EmpNameTb_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void EmpIdTb_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
