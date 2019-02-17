namespace Attendence_System
{
    partial class FacultyForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.facultyIDLabel = new System.Windows.Forms.Label();
            this.facultyIDtext = new System.Windows.Forms.TextBox();
            this.Facultynamelabel = new System.Windows.Forms.Label();
            this.FacultyNameText = new System.Windows.Forms.TextBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.back = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ADDbutton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButtton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.facultyIDLabel);
            this.panel1.Controls.Add(this.facultyIDtext);
            this.panel1.Controls.Add(this.Facultynamelabel);
            this.panel1.Controls.Add(this.FacultyNameText);
            this.panel1.Location = new System.Drawing.Point(139, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 364);
            this.panel1.TabIndex = 0;
            // 
            // facultyIDLabel
            // 
            this.facultyIDLabel.AutoSize = true;
            this.facultyIDLabel.BackColor = System.Drawing.Color.Transparent;
            this.facultyIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facultyIDLabel.Location = new System.Drawing.Point(31, 75);
            this.facultyIDLabel.Name = "facultyIDLabel";
            this.facultyIDLabel.Size = new System.Drawing.Size(29, 24);
            this.facultyIDLabel.TabIndex = 21;
            this.facultyIDLabel.Text = "ID";
            // 
            // facultyIDtext
            // 
            this.facultyIDtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facultyIDtext.Location = new System.Drawing.Point(177, 75);
            this.facultyIDtext.Name = "facultyIDtext";
            this.facultyIDtext.ReadOnly = true;
            this.facultyIDtext.Size = new System.Drawing.Size(144, 29);
            this.facultyIDtext.TabIndex = 22;
            // 
            // Facultynamelabel
            // 
            this.Facultynamelabel.AutoSize = true;
            this.Facultynamelabel.BackColor = System.Drawing.Color.Transparent;
            this.Facultynamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Facultynamelabel.Location = new System.Drawing.Point(31, 146);
            this.Facultynamelabel.Name = "Facultynamelabel";
            this.Facultynamelabel.Size = new System.Drawing.Size(138, 24);
            this.Facultynamelabel.TabIndex = 25;
            this.Facultynamelabel.Text = "Faculty Name";
            // 
            // FacultyNameText
            // 
            this.FacultyNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacultyNameText.Location = new System.Drawing.Point(177, 146);
            this.FacultyNameText.Name = "FacultyNameText";
            this.FacultyNameText.Size = new System.Drawing.Size(207, 29);
            this.FacultyNameText.TabIndex = 26;
            // 
            // listBox
            // 
            this.listBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.ForeColor = System.Drawing.SystemColors.Info;
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 24;
            this.listBox.Location = new System.Drawing.Point(664, 122);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(217, 364);
            this.listBox.TabIndex = 1;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.back.Image = global::Attendence_System.Properties.Resources.back161;
            this.back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.back.Location = new System.Drawing.Point(769, 529);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(112, 45);
            this.back.TabIndex = 20;
            this.back.Text = "<< Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label9.Location = new System.Drawing.Point(691, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 21);
            this.label9.TabIndex = 34;
            this.label9.Text = "faculty Names";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Copperplate Gothic Bold", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(333, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 53);
            this.label3.TabIndex = 33;
            this.label3.Text = "Faculty";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ClearButton);
            this.panel2.Controls.Add(this.ADDbutton);
            this.panel2.Controls.Add(this.UpdateButton);
            this.panel2.Controls.Add(this.DeleteButtton);
            this.panel2.Location = new System.Drawing.Point(64, 492);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(640, 121);
            this.panel2.TabIndex = 64;
            // 
            // ClearButton
            // 
            this.ClearButton.Image = global::Attendence_System.Properties.Resources.application_delete;
            this.ClearButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClearButton.Location = new System.Drawing.Point(495, 27);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(124, 45);
            this.ClearButton.TabIndex = 49;
            this.ClearButton.Text = "CLEAR";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click_1);
            // 
            // ADDbutton
            // 
            this.ADDbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ADDbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADDbutton.Image = global::Attendence_System.Properties.Resources.table_add;
            this.ADDbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ADDbutton.Location = new System.Drawing.Point(27, 27);
            this.ADDbutton.Name = "ADDbutton";
            this.ADDbutton.Size = new System.Drawing.Size(147, 45);
            this.ADDbutton.TabIndex = 46;
            this.ADDbutton.Text = "ADD";
            this.ADDbutton.UseVisualStyleBackColor = true;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.Image = global::Attendence_System.Properties.Resources.pencil_go;
            this.UpdateButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateButton.Location = new System.Drawing.Point(187, 27);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(135, 45);
            this.UpdateButton.TabIndex = 47;
            this.UpdateButton.Text = " UPDATE";
            this.UpdateButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButtton
            // 
            this.DeleteButtton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButtton.Image = global::Attendence_System.Properties.Resources.building_delete;
            this.DeleteButtton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteButtton.Location = new System.Drawing.Point(346, 27);
            this.DeleteButtton.Name = "DeleteButtton";
            this.DeleteButtton.Size = new System.Drawing.Size(125, 45);
            this.DeleteButtton.TabIndex = 48;
            this.DeleteButtton.Text = "   DELETE";
            this.DeleteButtton.UseVisualStyleBackColor = true;
            // 
            // FacultyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(928, 586);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.back);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.panel1);
            this.Name = "FacultyForm";
            this.Text = "FacultyForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FacultyForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label facultyIDLabel;
        private System.Windows.Forms.TextBox facultyIDtext;
        private System.Windows.Forms.Label Facultynamelabel;
        private System.Windows.Forms.TextBox FacultyNameText;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ADDbutton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButtton;
    }
}