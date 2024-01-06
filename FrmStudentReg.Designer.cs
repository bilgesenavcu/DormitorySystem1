
namespace DormitorySystem1
{
    partial class FrmStudentReg
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStudentReg));
            this.label1 = new System.Windows.Forms.Label();
            this.TextStudentName = new System.Windows.Forms.TextBox();
            this.TextStudentSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MaskedTC = new System.Windows.Forms.MaskedTextBox();
            this.MaskedStudentPhone = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MaskedBirth = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ComboDepartment = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TextMail = new System.Windows.Forms.TextBox();
            this.ComboRoomNum = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TextParentNameSurname = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.MaskedParentPhone = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.RichAddress = new System.Windows.Forms.RichTextBox();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(56, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Name:";
            // 
            // TextStudentName
            // 
            this.TextStudentName.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextStudentName.Location = new System.Drawing.Point(193, 22);
            this.TextStudentName.Name = "TextStudentName";
            this.TextStudentName.Size = new System.Drawing.Size(218, 30);
            this.TextStudentName.TabIndex = 1;
            // 
            // TextStudentSurname
            // 
            this.TextStudentSurname.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextStudentSurname.Location = new System.Drawing.Point(193, 58);
            this.TextStudentSurname.Name = "TextStudentSurname";
            this.TextStudentSurname.Size = new System.Drawing.Size(218, 30);
            this.TextStudentSurname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(31, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Student Surname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(144, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "TC :";
            // 
            // MaskedTC
            // 
            this.MaskedTC.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaskedTC.Location = new System.Drawing.Point(193, 94);
            this.MaskedTC.Mask = "00000000000";
            this.MaskedTC.Name = "MaskedTC";
            this.MaskedTC.Size = new System.Drawing.Size(218, 30);
            this.MaskedTC.TabIndex = 5;
            this.MaskedTC.ValidatingType = typeof(int);
            // 
            // MaskedStudentPhone
            // 
            this.MaskedStudentPhone.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaskedStudentPhone.Location = new System.Drawing.Point(193, 130);
            this.MaskedStudentPhone.Mask = "(999) 000-0000";
            this.MaskedStudentPhone.Name = "MaskedStudentPhone";
            this.MaskedStudentPhone.Size = new System.Drawing.Size(218, 30);
            this.MaskedStudentPhone.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(44, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Phone Number :";
            // 
            // MaskedBirth
            // 
            this.MaskedBirth.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaskedBirth.Location = new System.Drawing.Point(193, 166);
            this.MaskedBirth.Mask = "00/00/0000";
            this.MaskedBirth.Name = "MaskedBirth";
            this.MaskedBirth.Size = new System.Drawing.Size(218, 30);
            this.MaskedBirth.TabIndex = 9;
            this.MaskedBirth.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(62, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Date Of Birth :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(71, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Department :";
            // 
            // ComboDepartment
            // 
            this.ComboDepartment.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComboDepartment.FormattingEnabled = true;
            this.ComboDepartment.Location = new System.Drawing.Point(193, 202);
            this.ComboDepartment.Name = "ComboDepartment";
            this.ComboDepartment.Size = new System.Drawing.Size(218, 32);
            this.ComboDepartment.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(131, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "Mail :";
            // 
            // TextMail
            // 
            this.TextMail.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextMail.Location = new System.Drawing.Point(193, 240);
            this.TextMail.Name = "TextMail";
            this.TextMail.Size = new System.Drawing.Size(218, 30);
            this.TextMail.TabIndex = 13;
            // 
            // ComboRoomNum
            // 
            this.ComboRoomNum.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComboRoomNum.FormattingEnabled = true;
            this.ComboRoomNum.Location = new System.Drawing.Point(193, 276);
            this.ComboRoomNum.Name = "ComboRoomNum";
            this.ComboRoomNum.Size = new System.Drawing.Size(218, 32);
            this.ComboRoomNum.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(43, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = " Room Number :";
            // 
            // TextParentNameSurname
            // 
            this.TextParentNameSurname.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextParentNameSurname.Location = new System.Drawing.Point(193, 314);
            this.TextParentNameSurname.Name = "TextParentNameSurname";
            this.TextParentNameSurname.Size = new System.Drawing.Size(218, 30);
            this.TextParentNameSurname.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(-2, 323);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(198, 21);
            this.label9.TabIndex = 16;
            this.label9.Text = "Parent Name Surname:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // MaskedParentPhone
            // 
            this.MaskedParentPhone.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaskedParentPhone.Location = new System.Drawing.Point(193, 350);
            this.MaskedParentPhone.Mask = "(999) 000-0000";
            this.MaskedParentPhone.Name = "MaskedParentPhone";
            this.MaskedParentPhone.Size = new System.Drawing.Size(218, 30);
            this.MaskedParentPhone.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(-2, 359);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(200, 21);
            this.label10.TabIndex = 18;
            this.label10.Text = "Parent Phone Number :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(112, 395);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 21);
            this.label11.TabIndex = 20;
            this.label11.Text = "Address :";
            // 
            // RichAddress
            // 
            this.RichAddress.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RichAddress.Location = new System.Drawing.Point(193, 386);
            this.RichAddress.Name = "RichAddress";
            this.RichAddress.Size = new System.Drawing.Size(218, 171);
            this.RichAddress.TabIndex = 21;
            this.RichAddress.Text = "";
            // 
            // ButtonSave
            // 
            this.ButtonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ButtonSave.Location = new System.Drawing.Point(56, 491);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(109, 39);
            this.ButtonSave.TabIndex = 22;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = false;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 1.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(112, 410);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(7, 3);
            this.label12.TabIndex = 23;
            this.label12.Text = "label12";
            // 
            // FrmStudentReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(423, 569);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.RichAddress);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.MaskedParentPhone);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TextParentNameSurname);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ComboRoomNum);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TextMail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ComboDepartment);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MaskedBirth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MaskedStudentPhone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MaskedTC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextStudentSurname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextStudentName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmStudentReg";
            this.Text = "Student Registration";
            this.Load += new System.EventHandler(this.FrmStudentReg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextStudentName;
        private System.Windows.Forms.TextBox TextStudentSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox MaskedTC;
        private System.Windows.Forms.MaskedTextBox MaskedStudentPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox MaskedBirth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ComboDepartment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TextMail;
        private System.Windows.Forms.ComboBox ComboRoomNum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TextParentNameSurname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox MaskedParentPhone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox RichAddress;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Label label12;
    }
}

