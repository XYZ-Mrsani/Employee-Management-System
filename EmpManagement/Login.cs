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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            if(UidTb.Text == "" || PassTb.Text == "")
            {
                MessageBox.Show("Enter the user name and password,'Remember Before You are logging Select the Role'");
            }
            else
            {
                if(RoleCb.SelectedIndex > -1)
                {
                    if (RoleCb.SelectedItem.ToString() == "Admin")
                    {
                        if(UidTb.Text == "Admin" && PassTb.Text == "Admin123")
                        {
                           
                            this.Hide();
                            Home home = new Home();
                            home.Show();
                        }
                        else
                        {
                            MessageBox.Show("if you are the Admin, Enter the Correct Password or User name");
                        }
                    }
                    else
                    {
                        if(UidTb.Text =="Em1" && PassTb.Text =="1111")
                        {
                            this.Hide();
                            EditEmp editrmp = new EditEmp();
                            editrmp.Show();
                        }
                        else
                        {
                            MessageBox.Show("Wrong Employee name or password");
                        }
                    }
                    
                }
                else
                {
                    MessageBox.Show("Select a Role");
                }
            }
        }                                                                                                             

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UidTb.Text = "";
            PassTb.Text = "";
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void PassTb_OnValueChanged(object sender, EventArgs e)
        {
            PassTb.isPassword = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RoleCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UidTb_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
