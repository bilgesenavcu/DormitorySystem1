
namespace DormitorySystem1
{
    partial class FrmPayments
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPayments));
            this.TextStudentId = new System.Windows.Forms.TextBox();
            this.TextRemainDebt = new System.Windows.Forms.TextBox();
            this.TextPaidDebt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonPayment = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TextSurname = new System.Windows.Forms.TextBox();
            this.TextMonthPaid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TextStudentId
            // 
            this.TextStudentId.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextStudentId.Location = new System.Drawing.Point(142, 16);
            this.TextStudentId.Name = "TextStudentId";
            this.TextStudentId.Size = new System.Drawing.Size(250, 30);
            this.TextStudentId.TabIndex = 1;
            // 
            // TextRemainDebt
            // 
            this.TextRemainDebt.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextRemainDebt.Location = new System.Drawing.Point(142, 160);
            this.TextRemainDebt.Name = "TextRemainDebt";
            this.TextRemainDebt.Size = new System.Drawing.Size(250, 30);
            this.TextRemainDebt.TabIndex = 3;
            // 
            // TextPaidDebt
            // 
            this.TextPaidDebt.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextPaidDebt.Location = new System.Drawing.Point(142, 124);
            this.TextPaidDebt.Name = "TextPaidDebt";
            this.TextPaidDebt.Size = new System.Drawing.Size(250, 30);
            this.TextPaidDebt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(15, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Remain Debt:";
            // 
            // ButtonPayment
            // 
            this.ButtonPayment.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonPayment.Location = new System.Drawing.Point(196, 232);
            this.ButtonPayment.Name = "ButtonPayment";
            this.ButtonPayment.Size = new System.Drawing.Size(162, 34);
            this.ButtonPayment.TabIndex = 6;
            this.ButtonPayment.Text = "Get Paid";
            this.ButtonPayment.UseVisualStyleBackColor = true;
            this.ButtonPayment.Click += new System.EventHandler(this.ButtonPayment_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(424, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(585, 153);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(33, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Student ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(43, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Paid Debt:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(68, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = " Name:";
            // 
            // TextName
            // 
            this.TextName.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextName.Location = new System.Drawing.Point(142, 52);
            this.TextName.Name = "TextName";
            this.TextName.Size = new System.Drawing.Size(250, 30);
            this.TextName.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(47, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "Surname:";
            // 
            // TextSurname
            // 
            this.TextSurname.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextSurname.Location = new System.Drawing.Point(142, 88);
            this.TextSurname.Name = "TextSurname";
            this.TextSurname.Size = new System.Drawing.Size(250, 30);
            this.TextSurname.TabIndex = 12;
            // 
            // TextMonthPaid
            // 
            this.TextMonthPaid.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextMonthPaid.Location = new System.Drawing.Point(142, 196);
            this.TextMonthPaid.Name = "TextMonthPaid";
            this.TextMonthPaid.Size = new System.Drawing.Size(250, 30);
            this.TextMonthPaid.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(26, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 21);
            this.label6.TabIndex = 15;
            this.label6.Text = "Month Paid:";
            // 
            // FrmPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1229, 307);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TextMonthPaid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TextSurname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ButtonPayment);
            this.Controls.Add(this.TextPaidDebt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextRemainDebt);
            this.Controls.Add(this.TextStudentId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPayments";
            this.Text = "Payments";
            this.Load += new System.EventHandler(this.FrmPayments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TextStudentId;
        private System.Windows.Forms.TextBox TextRemainDebt;
        private System.Windows.Forms.TextBox TextPaidDebt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ButtonPayment;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextSurname;
        private System.Windows.Forms.TextBox TextMonthPaid;
        private System.Windows.Forms.Label label6;
    }
}