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
    public partial class FrmIncomeStatistics : Form
    {
        public FrmIncomeStatistics()
        {
            InitializeComponent();
        }

        SqlCon cn = new SqlCon();

        private void FrmIncomeStatistics_Load(object sender, EventArgs e)
        {
            //Kasadaki toplam para

            SqlCommand Command = new SqlCommand("Select Sum (PaymentAmount)from Safe", cn.connect());
            SqlDataReader Read = Command.ExecuteReader();
            while(Read.Read())
            {
                LabelMoney.Text = Read[0].ToString() + " TL";

            }
            cn.connect().Close();

            //tekrarsız ayları listeleme

            SqlCommand Command2 = new SqlCommand("Select distinct(PaymentMonth)from Safe", cn.connect());
            SqlDataReader Read2 = Command2.ExecuteReader();
            while(Read2.Read())
            {
                CmbMonth.Items.Add(Read2[0].ToString());
            }


            cn.connect().Close();
            

        }

        private void CmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand Command = new SqlCommand("Select sum(PaymentAmount)From Safe where PaymentMonth=@p1", cn.connect());
            Command.Parameters.AddWithValue("@p1", CmbMonth.Text);
            SqlDataReader Read = Command.ExecuteReader();
            while(Read.Read())
            {
                LabelMonthlyIncome.Text = Read[0].ToString();

            }
            cn.connect().Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
