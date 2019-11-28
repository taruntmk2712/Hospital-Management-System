namespace WindowsFormsApp4
{
    partial class Form4
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
            this.label6 = new System.Windows.Forms.Label();
            this.p_name = new System.Windows.Forms.TextBox();
            this.p_phone = new System.Windows.Forms.TextBox();
            this.p_add = new System.Windows.Forms.TextBox();
            this.p_id = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.p_dob = new System.Windows.Forms.TextBox();
            this.p_gender = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(418, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Patient";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gender:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(165, 406);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(165, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Patient id:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // p_name
            // 
            this.p_name.Location = new System.Drawing.Point(367, 179);
            this.p_name.Name = "p_name";
            this.p_name.Size = new System.Drawing.Size(252, 28);
            this.p_name.TabIndex = 6;
            // 
            // p_phone
            // 
            this.p_phone.Location = new System.Drawing.Point(367, 249);
            this.p_phone.Name = "p_phone";
            this.p_phone.Size = new System.Drawing.Size(252, 28);
            this.p_phone.TabIndex = 7;
            // 
            // p_add
            // 
            this.p_add.Location = new System.Drawing.Point(367, 403);
            this.p_add.Multiline = true;
            this.p_add.Name = "p_add";
            this.p_add.Size = new System.Drawing.Size(252, 89);
            this.p_add.TabIndex = 8;
            // 
            // p_id
            // 
            this.p_id.Location = new System.Drawing.Point(367, 125);
            this.p_id.Name = "p_id";
            this.p_id.Size = new System.Drawing.Size(262, 28);
            this.p_id.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 32);
            this.button1.TabIndex = 10;
            this.button1.Text = "Main Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(331, 624);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 43);
            this.button2.TabIndex = 11;
            this.button2.Text = "Submit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(171, 537);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "DOB";
            // 
            // p_dob
            // 
            this.p_dob.Location = new System.Drawing.Point(367, 533);
            this.p_dob.Name = "p_dob";
            this.p_dob.Size = new System.Drawing.Size(252, 28);
            this.p_dob.TabIndex = 14;
            // 
            // p_gender
            // 
            this.p_gender.FormattingEnabled = true;
            this.p_gender.Items.AddRange(new object[] {
            "MALE",
            "FEMALE",
            "OTHERS"});
            this.p_gender.Location = new System.Drawing.Point(367, 317);
            this.p_gender.Name = "p_gender";
            this.p_gender.Size = new System.Drawing.Size(121, 30);
            this.p_gender.TabIndex = 15;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 696);
            this.Controls.Add(this.p_gender);
            this.Controls.Add(this.p_dob);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.p_id);
            this.Controls.Add(this.p_add);
            this.Controls.Add(this.p_phone);
            this.Controls.Add(this.p_name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.Name = "Form4";
            this.Text = "Add Patient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox p_name;
        private System.Windows.Forms.TextBox p_phone;
        private System.Windows.Forms.TextBox p_add;
        private System.Windows.Forms.TextBox p_id;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox p_dob;
        private System.Windows.Forms.ComboBox p_gender;
    }
}