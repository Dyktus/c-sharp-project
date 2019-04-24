namespace MainWindow
{
    partial class MainWindow
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
            this.studentsButton = new System.Windows.Forms.Button();
            this.subjectsButton = new System.Windows.Forms.Button();
            this.marksButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // studentsButton
            // 
            this.studentsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.studentsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.studentsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.studentsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentsButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.studentsButton.Location = new System.Drawing.Point(108, 23);
            this.studentsButton.Name = "studentsButton";
            this.studentsButton.Size = new System.Drawing.Size(147, 65);
            this.studentsButton.TabIndex = 0;
            this.studentsButton.Text = "UCZNIOWIE";
            this.studentsButton.UseVisualStyleBackColor = false;
            this.studentsButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // subjectsButton
            // 
            this.subjectsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.subjectsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectsButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.subjectsButton.Location = new System.Drawing.Point(108, 103);
            this.subjectsButton.Name = "subjectsButton";
            this.subjectsButton.Size = new System.Drawing.Size(147, 67);
            this.subjectsButton.TabIndex = 1;
            this.subjectsButton.Text = "PRZEDMIOTY";
            this.subjectsButton.UseVisualStyleBackColor = false;
            // 
            // marksButton
            // 
            this.marksButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.marksButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marksButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.marksButton.Location = new System.Drawing.Point(108, 194);
            this.marksButton.Name = "marksButton";
            this.marksButton.Size = new System.Drawing.Size(147, 67);
            this.marksButton.TabIndex = 2;
            this.marksButton.Text = "OCENY";
            this.marksButton.UseVisualStyleBackColor = false;
            this.marksButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(356, 308);
            this.Controls.Add(this.marksButton);
            this.Controls.Add(this.subjectsButton);
            this.Controls.Add(this.studentsButton);
            this.Name = "MainWindow";
            this.Text = "Dziennik Ucznia - Okno glowne";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button studentsButton;
        private System.Windows.Forms.Button subjectsButton;
        private System.Windows.Forms.Button marksButton;
    }
}

