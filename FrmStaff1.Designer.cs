
namespace DormitorySystem1
{
    partial class FrmStaff1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStaff1));
            this.TextStaffId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextStaffName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextStaffDepartment = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnStaffDelete = new System.Windows.Forms.Button();
            this.BtnStaffUpdate = new System.Windows.Forms.Button();
            this.BtnStaffSave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TextStaffId
            // 
            this.TextStaffId.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextStaffId.Location = new System.Drawing.Point(185, 25);
            this.TextStaffId.Name = "TextStaffId";
            this.TextStaffId.Size = new System.Drawing.Size(218, 30);
            this.TextStaffId.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(105, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Staff Id:";
            // 
            // TextStaffName
            // 
            this.TextStaffName.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextStaffName.Location = new System.Drawing.Point(185, 82);
            this.TextStaffName.Name = "TextStaffName";
            this.TextStaffName.Size = new System.Drawing.Size(218, 30);
            this.TextStaffName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(74, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Staff Name:";
            // 
            // TextStaffDepartment
            // 
            this.TextStaffDepartment.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextStaffDepartment.Location = new System.Drawing.Point(185, 139);
            this.TextStaffDepartment.Name = "TextStaffDepartment";
            this.TextStaffDepartment.Size = new System.Drawing.Size(218, 30);
            this.TextStaffDepartment.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(26, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Staff Department:";
            // 
            // BtnStaffDelete
            // 
            this.BtnStaffDelete.Location = new System.Drawing.Point(180, 185);
            this.BtnStaffDelete.Name = "BtnStaffDelete";
            this.BtnStaffDelete.Size = new System.Drawing.Size(110, 43);
            this.BtnStaffDelete.TabIndex = 9;
            this.BtnStaffDelete.Text = "Delete";
            this.BtnStaffDelete.UseVisualStyleBackColor = true;
            this.BtnStaffDelete.Click += new System.EventHandler(this.BtnStaffDelete_Click);
            // 
            // BtnStaffUpdate
            // 
            this.BtnStaffUpdate.Location = new System.Drawing.Point(302, 185);
            this.BtnStaffUpdate.Name = "BtnStaffUpdate";
            this.BtnStaffUpdate.Size = new System.Drawing.Size(110, 43);
            this.BtnStaffUpdate.TabIndex = 10;
            this.BtnStaffUpdate.Text = "Update";
            this.BtnStaffUpdate.UseVisualStyleBackColor = true;
            this.BtnStaffUpdate.Click += new System.EventHandler(this.BtnStaffUpdate_Click);
            // 
            // BtnStaffSave
            // 
            this.BtnStaffSave.Location = new System.Drawing.Point(43, 185);
            this.BtnStaffSave.Name = "BtnStaffSave";
            this.BtnStaffSave.Size = new System.Drawing.Size(120, 43);
            this.BtnStaffSave.TabIndex = 12;
            this.BtnStaffSave.Text = "Save";
            this.BtnStaffSave.UseVisualStyleBackColor = true;
            this.BtnStaffSave.Click += new System.EventHandler(this.BtnStaffSave_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 250);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(453, 200);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // FrmStaff1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(451, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnStaffSave);
            this.Controls.Add(this.BtnStaffUpdate);
            this.Controls.Add(this.BtnStaffDelete);
            this.Controls.Add(this.TextStaffDepartment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextStaffName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextStaffId);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmStaff1";
            this.Text = "Edit Staff";
            this.Load += new System.EventHandler(this.FrmStaff1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextStaffId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextStaffName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextStaffDepartment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnStaffDelete;
        private System.Windows.Forms.Button BtnStaffUpdate;
        private System.Windows.Forms.Button BtnStaffSave;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}