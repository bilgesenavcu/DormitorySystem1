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
    public partial class FrmExpense : Form
    {
        public FrmExpense()
        {
            InitializeComponent();
        }

        SqlCon cn = new SqlCon();
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand Command = new SqlCommand("insert into Expense(Electric,Water,NaturalGass,Internet,Food,Staff,Other) Values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", cn.connect());
                Command.Parameters.AddWithValue("@p1", TextElectric.Text);
                Command.Parameters.AddWithValue("@p2", TextWater.Text);
                Command.Parameters.AddWithValue("@p3", TextNaturalGass.Text);
                Command.Parameters.AddWithValue("@p4", TextInternet.Text);
                Command.Parameters.AddWithValue("@p5", TextFood.Text);
                Command.Parameters.AddWithValue("@p6", TextStaff.Text);
                Command.Parameters.AddWithValue("@p7", TextOther.Text);
                Command.ExecuteNonQuery();
                cn.connect().Close();
                MessageBox.Show("Record Added");
            }

            catch
            {
                MessageBox.Show("Failed!Try Again.");
            }
        }

        private void FrmExpense_Load(object sender, EventArgs e)
        {

        }
    }
}
