namespace WindowsFormsApp4
{
    partial class Form8
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.d_id = new System.Windows.Forms.TextBox();
            this.d_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.d_phone = new System.Windows.Forms.TextBox();
            this.d_sal = new System.Windows.Forms.TextBox();
            this.d_add = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dEPARTMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new WindowsFormsApp4.DataSet1();
            this.dEPARTMENTTableAdapter = new WindowsFormsApp4.DataSet1TableAdapters.DEPARTMENTTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.d_dfrom = new System.Windows.Forms.TextBox();
            this.d_dto = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.d_gender = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dEPARTMENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(428, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADD DOCTOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "doctor_id:";
            // 
            // d_id
            // 
            this.d_id.Location = new System.Drawing.Point(388, 110);
            this.d_id.Name = "d_id";
            this.d_id.Size = new System.Drawing.Size(241, 28);
            this.d_id.TabIndex = 2;
            // 
            // d_name
            // 
            this.d_name.Location = new System.Drawing.Point(387, 170);
            this.d_name.Name = "d_name";
            this.d_name.Size = new System.Drawing.Size(242, 28);
            this.d_name.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 174);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(123, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Doctor  name";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "doctor phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "doctor gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(170, 421);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "doctor add";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(158, 506);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 24);
            this.label7.TabIndex = 8;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // d_phone
            // 
            this.d_phone.Location = new System.Drawing.Point(382, 256);
            this.d_phone.Name = "d_phone";
            this.d_phone.Size = new System.Drawing.Size(247, 28);
            this.d_phone.TabIndex = 9;
            // 
            // d_sal
            // 
            this.d_sal.Location = new System.Drawing.Point(388, 506);
            this.d_sal.Name = "d_sal";
            this.d_sal.Size = new System.Drawing.Size(247, 28);
            this.d_sal.TabIndex = 12;
            // 
            // d_add
            // 
            this.d_add.Location = new System.Drawing.Point(388, 418);
            this.d_add.Name = "d_add";
            this.d_add.Size = new System.Drawing.Size(247, 67);
            this.d_add.TabIndex = 13;
            this.d_add.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(170, 510);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 24);
            this.label9.TabIndex = 15;
            this.label9.Text = "salary";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(387, 649);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 45);
            this.button1.TabIndex = 16;
            this.button1.Text = "submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 41);
            this.button2.TabIndex = 17;
            this.button2.Text = "Main Menu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dEPARTMENTBindingSource
            // 
            this.dEPARTMENTBindingSource.DataMember = "DEPARTMENT";
            this.dEPARTMENTBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dEPARTMENTTableAdapter
            // 
            this.dEPARTMENTTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(168, 556);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 24);
            this.label8.TabIndex = 22;
            this.label8.Text = "Doc avail from";
            // 
            // d_dfrom
            // 
            this.d_dfrom.Location = new System.Drawing.Point(388, 556);
            this.d_dfrom.Name = "d_dfrom";
            this.d_dfrom.Size = new System.Drawing.Size(247, 28);
            this.d_dfrom.TabIndex = 23;
            this.d_dfrom.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // d_dto
            // 
            this.d_dto.Location = new System.Drawing.Point(387, 606);
            this.d_dto.Name = "d_dto";
            this.d_dto.Size = new System.Drawing.Size(247, 28);
            this.d_dto.TabIndex = 24;
            this.d_dto.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(170, 606);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 24);
            this.label11.TabIndex = 25;
            this.label11.Text = "Doc avail to";
            // 
            // d_gender
            // 
            this.d_gender.FormattingEnabled = true;
            this.d_gender.Items.AddRange(new object[] {
            "MALE",
            "FEMALE",
            "OTHERS"});
            this.d_gender.Location = new System.Drawing.Point(382, 335);
            this.d_gender.Name = "d_gender";
            this.d_gender.Size = new System.Drawing.Size(121, 30);
            this.d_gender.TabIndex = 26;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 696);
            this.Controls.Add(this.d_gender);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.d_dto);
            this.Controls.Add(this.d_dfrom);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.d_add);
            this.Controls.Add(this.d_sal);
            this.Controls.Add(this.d_phone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.d_name);
            this.Controls.Add(this.d_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.Name = "Form8";
            this.Text = "Add Doctor";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.TextChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dEPARTMENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox d_id;
        private System.Windows.Forms.TextBox d_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox d_phone;
        private System.Windows.Forms.TextBox d_sal;
        private System.Windows.Forms.RichTextBox d_add;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource dEPARTMENTBindingSource;
        private DataSet1TableAdapters.DEPARTMENTTableAdapter dEPARTMENTTableAdapter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox d_dfrom;
        private System.Windows.Forms.TextBox d_dto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox d_gender;
    }
}