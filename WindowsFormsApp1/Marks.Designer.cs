namespace DzienniczekUcznia
{
    partial class Marks
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
            this.studentName = new System.Windows.Forms.Label();
            this.saveMarkButton = new System.Windows.Forms.Button();
            this.markInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.markTypeInput = new System.Windows.Forms.TextBox();
            this.marksList = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mark = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.markType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.marksContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.usunOceneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edytujOceneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marksContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentName
            // 
            this.studentName.AutoSize = true;
            this.studentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentName.Location = new System.Drawing.Point(22, 13);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(86, 31);
            this.studentName.TabIndex = 0;
            this.studentName.Text = "label1";
            // 
            // saveMarkButton
            // 
            this.saveMarkButton.BackColor = System.Drawing.Color.DarkOrange;
            this.saveMarkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveMarkButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.saveMarkButton.Location = new System.Drawing.Point(269, 435);
            this.saveMarkButton.Name = "saveMarkButton";
            this.saveMarkButton.Size = new System.Drawing.Size(206, 45);
            this.saveMarkButton.TabIndex = 16;
            this.saveMarkButton.Text = "DODAJ OCENE";
            this.saveMarkButton.UseVisualStyleBackColor = false;
            this.saveMarkButton.Click += new System.EventHandler(this.saveMarkButton_Click);
            // 
            // markInput
            // 
            this.markInput.Location = new System.Drawing.Point(28, 435);
            this.markInput.Name = "markInput";
            this.markInput.Size = new System.Drawing.Size(127, 20);
            this.markInput.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 416);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ocena";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 462);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Typ oceny";
            // 
            // markTypeInput
            // 
            this.markTypeInput.Location = new System.Drawing.Point(28, 478);
            this.markTypeInput.Name = "markTypeInput";
            this.markTypeInput.Size = new System.Drawing.Size(127, 20);
            this.markTypeInput.TabIndex = 20;
            // 
            // marksList
            // 
            this.marksList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.markType,
            this.mark});
            this.marksList.Location = new System.Drawing.Point(28, 61);
            this.marksList.Name = "marksList";
            this.marksList.Size = new System.Drawing.Size(447, 352);
            this.marksList.TabIndex = 21;
            this.marksList.UseCompatibleStateImageBehavior = false;
            this.marksList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.marksList_MouseClick);
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 100;
            // 
            // mark
            // 
            this.mark.DisplayIndex = 1;
            this.mark.Text = "Ocena";
            this.mark.Width = 100;
            // 
            // markType
            // 
            this.markType.DisplayIndex = 2;
            this.markType.Text = "Typ oceny";
            this.markType.Width = 240;
            // 
            // marksContextMenu
            // 
            this.marksContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usunOceneToolStripMenuItem,
            this.edytujOceneToolStripMenuItem});
            this.marksContextMenu.Name = "marksContextMenu";
            this.marksContextMenu.Size = new System.Drawing.Size(181, 70);
            // 
            // usunOceneToolStripMenuItem
            // 
            this.usunOceneToolStripMenuItem.Name = "usunOceneToolStripMenuItem";
            this.usunOceneToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usunOceneToolStripMenuItem.Text = "Usun ocene";
            this.usunOceneToolStripMenuItem.Click += new System.EventHandler(this.usunOceneToolStripMenuItem_Click);
            // 
            // edytujOceneToolStripMenuItem
            // 
            this.edytujOceneToolStripMenuItem.Name = "edytujOceneToolStripMenuItem";
            this.edytujOceneToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.edytujOceneToolStripMenuItem.Text = "Edytuj ocene";
            this.edytujOceneToolStripMenuItem.Click += new System.EventHandler(this.edytujOceneToolStripMenuItem_Click);
            // 
            // Marks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 523);
            this.Controls.Add(this.marksList);
            this.Controls.Add(this.markTypeInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.markInput);
            this.Controls.Add(this.saveMarkButton);
            this.Controls.Add(this.studentName);
            this.Name = "Marks";
            this.Text = "Dzienniczek Ucznia - OCeny";
            this.marksContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label studentName;
        private System.Windows.Forms.Button saveMarkButton;
        private System.Windows.Forms.TextBox markInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox markTypeInput;
        private System.Windows.Forms.ListView marksList;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader mark;
        private System.Windows.Forms.ColumnHeader markType;
        private System.Windows.Forms.ContextMenuStrip marksContextMenu;
        private System.Windows.Forms.ToolStripMenuItem usunOceneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edytujOceneToolStripMenuItem;
    }
}