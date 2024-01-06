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
    public partial class FrmExpenseList : Form
    {
        public FrmExpenseList()
        {
            InitializeComponent();
        }

        SqlCon cn = new SqlCon();
        private void FrmExpenseList_Load(object sender, EventArgs e)
        {
            try
            {

                SqlDataAdapter adapter = new SqlDataAdapter();
                DataSet dataset = new DataSet();



                adapter.SelectCommand = new SqlCommand("SELECT ExpenseId, Electric ,Water,NaturalGass,Internet,Food,Staff,Other FROM Expense ORDER BY ExpenseId", cn.connect());
                adapter.Fill(dataset);
                dataGridView1.DataSource = dataset.Tables[0];
                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                // DataGridView sütunları tam genişlik
                DataGridViewColumn[] columnsArray = new DataGridViewColumn[dataGridView1.Columns.Count];
                dataGridView1.Columns.CopyTo(columnsArray, 0);
                Array.ForEach(columnsArray, column => column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Fail: " + ex.Message);
            }
            finally
            {
                cn.connect().Close();
            }
        }

        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int choose;
            FrmExpenseUpdate Fru = new FrmExpenseUpdate();
            choose = dataGridView1.SelectedCells[0].RowIndex;
            Fru.ID = dataGridView1.Rows[choose].Cells[0].Value.ToString();
            Fru.Electric = dataGridView1.Rows[choose].Cells[1].Value.ToString();
            Fru.Water = dataGridView1.Rows[choose].Cells[2].Value.ToString();
            Fru.NaturalGass = dataGridView1.Rows[choose].Cells[3].Value.ToString();
            Fru.Internet = dataGridView1.Rows[choose].Cells[4].Value.ToString();
            Fru.Food = dataGridView1.Rows[choose].Cells[5].Value.ToString();
            Fru.Staff = dataGridView1.Rows[choose].Cells[6].Value.ToString();
            Fru.Other = dataGridView1.Rows[choose].Cells[7].Value.ToString();
            Fru.Show();
        }
    }
}
