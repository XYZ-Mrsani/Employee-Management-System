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
    public partial class ViewEmployee : Form
    {
        public ViewEmployee()
        {
            InitializeComponent();
        }
        //SqlConnection Con = new SqlConnection(@"Server=tcp:kryptonsani.database.windows.net,1433;Initial Catalog=MyEmployeeDb;Persist Security Info=False;User ID=adminsani;Password=Sani@2002;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C#_Projects\EmpManagement\MyEmployeeDb1.mdf;Integrated Security=True;Connect Timeout=30");
        private void fetchempdata()
        {
            Con.Open();
            string query = "select * from EmployeeTbl where EmpId='" + EmpidTb.Text + "'";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                Empidlbl.Text = dr["Empid"].ToString();
                empnamelbl.Text = dr["Empname"].ToString();
                empaddlbl.Text = dr["Empadd"].ToString();
                empposlbl.Text = dr["Emppos"].ToString();
                empphonelbl.Text = dr["Empphone"].ToString();
                empedulbl.Text = dr["Empedu"].ToString();
                Empgenlbl.Text = dr["Empgen"].ToString();
                empdoblbl.Text = dr["empdob"].ToString();
                Empidlbl.Visible = true;
                empnamelbl.Visible = true;
                empaddlbl.Visible = true;
                empposlbl.Visible = true;
                empphonelbl.Visible = true;
                empedulbl.Visible = true;
                Empgenlbl.Visible = true;
                empdoblbl.Visible = true;

            }
            Con.Close();
        }
        private void ViewEmployee_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            fetchempdata();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if(printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("=======EMPLOYEE DETAILS=======", new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Green, new Point(180));
            
            e.Graphics.DrawString("Employee ID: " + Empidlbl.Text , new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Blue, new Point(10,100));
           
            e.Graphics.DrawString("Employee Name: " + empnamelbl.Text, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Blue, new Point(10, 140));
            
            e.Graphics.DrawString("Employee Address: " + empaddlbl.Text , new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Blue, new Point(10, 180));
            
            e.Graphics.DrawString("Employee Gender: " + Empgenlbl.Text, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Blue, new Point(10, 220));
            
            e.Graphics.DrawString("Employee Position: " + empposlbl.Text , new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Blue, new Point(10, 260));
            
            e.Graphics.DrawString("Employee DOB: " + empdoblbl.Text, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Blue, new Point(10, 300));
            
            e.Graphics.DrawString("Employee Phone: " + empphonelbl.Text , new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Blue, new Point(10, 340));
           
            e.Graphics.DrawString("Employee Education: " + empedulbl.Text, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Blue, new Point(10, 380));

            

            e.Graphics.DrawString("==========================", new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Green, new Point(200,420));
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EmpidTb_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
