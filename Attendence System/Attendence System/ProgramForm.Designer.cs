namespace Attendence_System
{
    partial class ProgramForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.departmentcomboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IDtext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.facultyCombobox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ProgramDurationtext = new System.Windows.Forms.TextBox();
            this.programNameText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ADDbutton = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.DeleteButtton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.departmentcomboBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.IDtext);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.facultyCombobox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ProgramDurationtext);
            this.panel1.Controls.Add(this.programNameText);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(124, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 364);
            this.panel1.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 24);
            this.label6.TabIndex = 29;
            this.label6.Text = "Department";
            // 
            // departmentcomboBox
            // 
            this.departmentcomboBox.FormattingEnabled = true;
            this.departmentcomboBox.Location = new System.Drawing.Point(177, 90);
            this.departmentcomboBox.Name = "departmentcomboBox";
            this.departmentcomboBox.Size = new System.Drawing.Size(147, 21);
            this.departmentcomboBox.TabIndex = 30;
            this.departmentcomboBox.SelectedIndexChanged += new System.EventHandler(this.departmentcomboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "ID";
            // 
            // IDtext
            // 
            this.IDtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDtext.Location = new System.Drawing.Point(177, 168);
            this.IDtext.Name = "IDtext";
            this.IDtext.ReadOnly = true;
            this.IDtext.Size = new System.Drawing.Size(144, 29);
            this.IDtext.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "Faculty";
            // 
            // facultyCombobox
            // 
            this.facultyCombobox.FormattingEnabled = true;
            this.facultyCombobox.Location = new System.Drawing.Point(177, 37);
            this.facultyCombobox.Name = "facultyCombobox";
            this.facultyCombobox.Size = new System.Drawing.Size(147, 21);
            this.facultyCombobox.TabIndex = 24;
            this.facultyCombobox.SelectedIndexChanged += new System.EventHandler(this.facultyCombobox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 24);
            this.label4.TabIndex = 25;
            this.label4.Text = "Program";
            // 
            // ProgramDurationtext
            // 
            this.ProgramDurationtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgramDurationtext.Location = new System.Drawing.Point(213, 265);
            this.ProgramDurationtext.Name = "ProgramDurationtext";
            this.ProgramDurationtext.Size = new System.Drawing.Size(111, 29);
            this.ProgramDurationtext.TabIndex = 28;
            // 
            // programNameText
            // 
            this.programNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programNameText.Location = new System.Drawing.Point(180, 212);
            this.programNameText.Name = "programNameText";
            this.programNameText.Size = new System.Drawing.Size(144, 29);
            this.programNameText.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 24);
            this.label5.TabIndex = 27;
            this.label5.Text = "Duration Semesters";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label9.Location = new System.Drawing.Point(676, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 21);
            this.label9.TabIndex = 52;
            this.label9.Text = "Programs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Copperplate Gothic Bold", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(335, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 53);
            this.label3.TabIndex = 51;
            this.label3.Text = "Program";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(649, 106);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(217, 364);
            this.listBox1.TabIndex = 45;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
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
            // back
            // 
            this.back.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.back.Image = global::Attendence_System.Properties.Resources.back161;
            this.back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.back.Location = new System.Drawing.Point(754, 513);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(112, 45);
            this.back.TabIndex = 50;
            this.back.Text = "<< Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
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
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.ClearButton);
            this.panel2.Controls.Add(this.ADDbutton);
            this.panel2.Controls.Add(this.UpdateButton);
            this.panel2.Controls.Add(this.DeleteButtton);
            this.panel2.Location = new System.Drawing.Point(45, 476);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(640, 121);
            this.panel2.TabIndex = 63;
            // 
            // ProgramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 579);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.back);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Name = "ProgramForm";
            this.Text = "ProgramForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ProgramForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ADDbutton;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button DeleteButtton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IDtext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox facultyCombobox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ProgramDurationtext;
        private System.Windows.Forms.TextBox programNameText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox departmentcomboBox;
        private System.Windows.Forms.Panel panel2;
    }
}