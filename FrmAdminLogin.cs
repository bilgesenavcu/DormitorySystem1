using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DormitorySystem1
{
    public partial class FrmAdminLogin : Form
    {
        public FrmAdminLogin()
        {
            InitializeComponent();
        }
        SqlCon cn = new SqlCon();
        private void BtnLogin_Click(object sender, EventArgs e)
        {

            SqlCommand Command = new SqlCommand("Select * From Admin where AdminName=@p1 and AdminPassword=@p2",cn.connect());
            Command.Parameters.AddWithValue("@p1", TextUsername.Text);
            Command.Parameters.AddWithValue("@p2", TextPassword.Text);
            SqlDataReader read = Command.ExecuteReader();
            if (read.Read())
            {
                FrmMainForm Fr = new FrmMainForm();
                Fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorret Username or Password !");
                TextUsername.Clear();
                TextPassword.Clear();
                TextUsername.Focus();
            }
            cn.connect().Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmAdminLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
