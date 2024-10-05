namespace Student_Info
{
    partial class Form_Student_info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Student_info));
            this.StudentNUMBER = new System.Windows.Forms.Label();
            this.label_LASTNAME = new System.Windows.Forms.Label();
            this.label_FIRSTNAME = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.listBox_StudentID = new System.Windows.Forms.ListBox();
            this.listBox_LASTNAME = new System.Windows.Forms.ListBox();
            this.listBox_FIRSTNAME = new System.Windows.Forms.ListBox();
            this.button_SUBMIT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StudentNUMBER
            // 
            this.StudentNUMBER.AutoSize = true;
            this.StudentNUMBER.BackColor = System.Drawing.Color.Transparent;
            this.StudentNUMBER.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentNUMBER.Location = new System.Drawing.Point(14, 33);
            this.StudentNUMBER.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.StudentNUMBER.Name = "StudentNUMBER";
            this.StudentNUMBER.Size = new System.Drawing.Size(124, 19);
            this.StudentNUMBER.TabIndex = 0;
            this.StudentNUMBER.Text = "Student number*";
            // 
            // label_LASTNAME
            // 
            this.label_LASTNAME.AutoSize = true;
            this.label_LASTNAME.BackColor = System.Drawing.Color.Transparent;
            this.label_LASTNAME.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_LASTNAME.Location = new System.Drawing.Point(209, 33);
            this.label_LASTNAME.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_LASTNAME.Name = "label_LASTNAME";
            this.label_LASTNAME.Size = new System.Drawing.Size(86, 19);
            this.label_LASTNAME.TabIndex = 1;
            this.label_LASTNAME.Text = "Last name*";
            // 
            // label_FIRSTNAME
            // 
            this.label_FIRSTNAME.AutoSize = true;
            this.label_FIRSTNAME.BackColor = System.Drawing.Color.Transparent;
            this.label_FIRSTNAME.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FIRSTNAME.Location = new System.Drawing.Point(424, 33);
            this.label_FIRSTNAME.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_FIRSTNAME.Name = "label_FIRSTNAME";
            this.label_FIRSTNAME.Size = new System.Drawing.Size(88, 19);
            this.label_FIRSTNAME.TabIndex = 2;
            this.label_FIRSTNAME.Text = "First name*";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 56);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 25);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(213, 56);
            this.textBox2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(196, 25);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(428, 56);
            this.textBox3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(136, 25);
            this.textBox3.TabIndex = 5;
            // 
            // listBox_StudentID
            // 
            this.listBox_StudentID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox_StudentID.FormattingEnabled = true;
            this.listBox_StudentID.ItemHeight = 18;
            this.listBox_StudentID.Location = new System.Drawing.Point(18, 183);
            this.listBox_StudentID.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.listBox_StudentID.Name = "listBox_StudentID";
            this.listBox_StudentID.Size = new System.Drawing.Size(156, 200);
            this.listBox_StudentID.TabIndex = 6;
            // 
            // listBox_LASTNAME
            // 
            this.listBox_LASTNAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox_LASTNAME.ForeColor = System.Drawing.Color.Black;
            this.listBox_LASTNAME.FormattingEnabled = true;
            this.listBox_LASTNAME.ItemHeight = 18;
            this.listBox_LASTNAME.Location = new System.Drawing.Point(203, 183);
            this.listBox_LASTNAME.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.listBox_LASTNAME.Name = "listBox_LASTNAME";
            this.listBox_LASTNAME.Size = new System.Drawing.Size(147, 200);
            this.listBox_LASTNAME.TabIndex = 7;
            // 
            // listBox_FIRSTNAME
            // 
            this.listBox_FIRSTNAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox_FIRSTNAME.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.listBox_FIRSTNAME.FormattingEnabled = true;
            this.listBox_FIRSTNAME.ItemHeight = 18;
            this.listBox_FIRSTNAME.Location = new System.Drawing.Point(408, 183);
            this.listBox_FIRSTNAME.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.listBox_FIRSTNAME.Name = "listBox_FIRSTNAME";
            this.listBox_FIRSTNAME.Size = new System.Drawing.Size(156, 200);
            this.listBox_FIRSTNAME.TabIndex = 8;
            // 
            // button_SUBMIT
            // 
            this.button_SUBMIT.Location = new System.Drawing.Point(474, 89);
            this.button_SUBMIT.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button_SUBMIT.Name = "button_SUBMIT";
            this.button_SUBMIT.Size = new System.Drawing.Size(90, 34);
            this.button_SUBMIT.TabIndex = 9;
            this.button_SUBMIT.Text = "Submit";
            this.button_SUBMIT.UseVisualStyleBackColor = true;
            this.button_SUBMIT.Click += new System.EventHandler(this.button_SUBMIT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(15, 162);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Student ID List";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(209, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "First Name List";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(414, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Last Name List";
            // 
            // Form_Student_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 405);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_SUBMIT);
            this.Controls.Add(this.listBox_FIRSTNAME);
            this.Controls.Add(this.listBox_LASTNAME);
            this.Controls.Add(this.listBox_StudentID);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_FIRSTNAME);
            this.Controls.Add(this.label_LASTNAME);
            this.Controls.Add(this.StudentNUMBER);
            this.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form_Student_info";
            this.Text = "Student Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StudentNUMBER;
        private System.Windows.Forms.Label label_LASTNAME;
        private System.Windows.Forms.Label label_FIRSTNAME;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ListBox listBox_StudentID;
        private System.Windows.Forms.ListBox listBox_LASTNAME;
        private System.Windows.Forms.ListBox listBox_FIRSTNAME;
        private System.Windows.Forms.Button button_SUBMIT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

