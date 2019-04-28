namespace StudentForm
{
    partial class AddStudentForm
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
            this.addStudentHeader = new System.Windows.Forms.Label();
            this.editStudentHeader = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.studentNameInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.studentStreetInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.studentCityInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.studentZipCodeInput = new System.Windows.Forms.TextBox();
            this.studentBirthDate = new System.Windows.Forms.MonthCalendar();
            this.label5 = new System.Windows.Forms.Label();
            this.studentClassList = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.saveStudentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addStudentHeader
            // 
            this.addStudentHeader.AutoSize = true;
            this.addStudentHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStudentHeader.Location = new System.Drawing.Point(13, 13);
            this.addStudentHeader.Name = "addStudentHeader";
            this.addStudentHeader.Size = new System.Drawing.Size(430, 37);
            this.addStudentHeader.TabIndex = 0;
            this.addStudentHeader.Text = "Formularz dodawania ucznia";
            // 
            // editStudentHeader
            // 
            this.editStudentHeader.AutoSize = true;
            this.editStudentHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editStudentHeader.Location = new System.Drawing.Point(13, 13);
            this.editStudentHeader.Name = "editStudentHeader";
            this.editStudentHeader.Size = new System.Drawing.Size(354, 37);
            this.editStudentHeader.TabIndex = 1;
            this.editStudentHeader.Text = "Formularz edycji ucznia";
            this.editStudentHeader.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Imie i nazwisko";
            // 
            // studentNameInput
            // 
            this.studentNameInput.Location = new System.Drawing.Point(23, 81);
            this.studentNameInput.Name = "studentNameInput";
            this.studentNameInput.Size = new System.Drawing.Size(196, 20);
            this.studentNameInput.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ulica";
            // 
            // studentStreetInput
            // 
            this.studentStreetInput.Location = new System.Drawing.Point(23, 138);
            this.studentStreetInput.Name = "studentStreetInput";
            this.studentStreetInput.Size = new System.Drawing.Size(196, 20);
            this.studentStreetInput.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Miejscowosc";
            // 
            // studentCityInput
            // 
            this.studentCityInput.Location = new System.Drawing.Point(23, 194);
            this.studentCityInput.Name = "studentCityInput";
            this.studentCityInput.Size = new System.Drawing.Size(196, 20);
            this.studentCityInput.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kod pocztowy";
            // 
            // studentZipCodeInput
            // 
            this.studentZipCodeInput.Location = new System.Drawing.Point(23, 253);
            this.studentZipCodeInput.Name = "studentZipCodeInput";
            this.studentZipCodeInput.Size = new System.Drawing.Size(196, 20);
            this.studentZipCodeInput.TabIndex = 9;
            // 
            // studentBirthDate
            // 
            this.studentBirthDate.Location = new System.Drawing.Point(23, 317);
            this.studentBirthDate.Name = "studentBirthDate";
            this.studentBirthDate.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Data urodzenia";
            // 
            // studentClassList
            // 
            this.studentClassList.FormattingEnabled = true;
            this.studentClassList.Location = new System.Drawing.Point(262, 81);
            this.studentClassList.Name = "studentClassList";
            this.studentClassList.Size = new System.Drawing.Size(209, 277);
            this.studentClassList.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(262, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Klasa do ktorej nalezy uczen";
            // 
            // saveStudentButton
            // 
            this.saveStudentButton.BackColor = System.Drawing.Color.DarkOrange;
            this.saveStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveStudentButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.saveStudentButton.Location = new System.Drawing.Point(265, 399);
            this.saveStudentButton.Name = "saveStudentButton";
            this.saveStudentButton.Size = new System.Drawing.Size(206, 45);
            this.saveStudentButton.TabIndex = 14;
            this.saveStudentButton.Text = "ZAPISZ";
            this.saveStudentButton.UseVisualStyleBackColor = false;
            this.saveStudentButton.Click += new System.EventHandler(this.SaveStudentButton_Click);
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 535);
            this.Controls.Add(this.saveStudentButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.studentClassList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.studentBirthDate);
            this.Controls.Add(this.studentZipCodeInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.studentCityInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.studentStreetInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.studentNameInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.editStudentHeader);
            this.Controls.Add(this.addStudentHeader);
            this.Name = "AddStudentForm";
            this.Text = "Formularz ucznia";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddStudentForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addStudentHeader;
        private System.Windows.Forms.Label editStudentHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox studentNameInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox studentStreetInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox studentCityInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox studentZipCodeInput;
        private System.Windows.Forms.MonthCalendar studentBirthDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox studentClassList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button saveStudentButton;
    }
}