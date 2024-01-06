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
    public partial class FrmExpenseUpdate : Form
    {
        public FrmExpenseUpdate()
        {
            InitializeComponent();
        }
        public string Electric, Water, NaturalGass,Internet, Food, Staff, Other,ID ;
        SqlCon cn = new SqlCon();
        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand Command = new SqlCommand("update Expense set Electric=@p1,Water=@p2,NaturalGass=@p3,Internet=@p4,Food=@p5,Staff=@p6,Other=@p7 where ExpenseId=@p8", cn.connect());
                Command.Parameters.AddWithValue("@p8", TextExpenseID.Text);
                Command.Parameters.AddWithValue("@p1", TextElectric.Text);
                Command.Parameters.AddWithValue("@p2", TextWater.Text);
                Command.Parameters.AddWithValue("@p3", TextNaturalGass.Text);
                Command.Parameters.AddWithValue("@p4", TextInternet.Text);
                Command.Parameters.AddWithValue("@p5", TextFood.Text);
                Command.Parameters.AddWithValue("@p6", TextStaff.Text);
                Command.Parameters.AddWithValue("@p7", TextOther.Text);


                Command.ExecuteNonQuery();
                cn.connect().Close();
                MessageBox.Show("Update Successful");
            }

            catch
            {
                MessageBox.Show("Failed! Try again.");
            }

        }

        private void FrmExpenseUpdate_Load(object sender, EventArgs e)
        {
            TextExpenseID.Text = ID;
            TextElectric.Text = Electric;
            TextWater.Text = Water;
            TextNaturalGass.Text = NaturalGass;
            TextInternet.Text = Internet;
            TextFood.Text = Food;
            TextStaff.Text = Staff;
            TextOther.Text = Other;
        }
    }
}
