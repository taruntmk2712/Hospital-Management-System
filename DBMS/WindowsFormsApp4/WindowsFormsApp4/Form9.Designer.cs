﻿namespace WindowsFormsApp4
{
    partial class Form9
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.p_id = new System.Windows.Forms.TextBox();
            this.p_name = new System.Windows.Forms.TextBox();
            this.p_phone = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.p_address = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.p_dob = new System.Windows.Forms.TextBox();
            this.p_gender = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "UPDATE PATIENT DETAILS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter patient id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 420);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "address";
            // 
            // p_id
            // 
            this.p_id.Location = new System.Drawing.Point(267, 152);
            this.p_id.Name = "p_id";
            this.p_id.Size = new System.Drawing.Size(322, 28);
            this.p_id.TabIndex = 5;
            // 
            // p_name
            // 
            this.p_name.Location = new System.Drawing.Point(272, 240);
            this.p_name.Name = "p_name";
            this.p_name.Size = new System.Drawing.Size(319, 28);
            this.p_name.TabIndex = 6;
            // 
            // p_phone
            // 
            this.p_phone.Location = new System.Drawing.Point(268, 327);
            this.p_phone.Name = "p_phone";
            this.p_phone.Size = new System.Drawing.Size(321, 28);
            this.p_phone.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(342, 626);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 47);
            this.button1.TabIndex = 10;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 503);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "gender";
            // 
            // p_address
            // 
            this.p_address.Location = new System.Drawing.Point(270, 401);
            this.p_address.Name = "p_address";
            this.p_address.Size = new System.Drawing.Size(321, 68);
            this.p_address.TabIndex = 12;
            this.p_address.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 42);
            this.button2.TabIndex = 13;
            this.button2.Text = "Main Menu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 580);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "DOB";
            // 
            // p_dob
            // 
            this.p_dob.Location = new System.Drawing.Point(268, 576);
            this.p_dob.Name = "p_dob";
            this.p_dob.Size = new System.Drawing.Size(323, 28);
            this.p_dob.TabIndex = 15;
            // 
            // p_gender
            // 
            this.p_gender.FormattingEnabled = true;
            this.p_gender.Items.AddRange(new object[] {
            "MALE",
            "FEMALE",
            "OTHERS"});
            this.p_gender.Location = new System.Drawing.Point(267, 503);
            this.p_gender.Name = "p_gender";
            this.p_gender.Size = new System.Drawing.Size(121, 30);
            this.p_gender.TabIndex = 16;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 696);
            this.Controls.Add(this.p_gender);
            this.Controls.Add(this.p_dob);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.p_address);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.p_phone);
            this.Controls.Add(this.p_name);
            this.Controls.Add(this.p_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.Name = "Form9";
            this.Text = "Update Patient Details";
            this.Load += new System.EventHandler(this.Form9_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox p_id;
        private System.Windows.Forms.TextBox p_name;
        private System.Windows.Forms.TextBox p_phone;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox p_address;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox p_dob;
        private System.Windows.Forms.ComboBox p_gender;
    }
}