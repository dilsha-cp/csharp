namespace RegistrationForm
{
    partial class Form1
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
            txtfname = new TextBox();
            txtphone = new TextBox();
            txtEmail = new TextBox();
            txtlname = new TextBox();
            txtUsername = new TextBox();
            dtpdob = new DateTimePicker();
            cmbGender = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            button1 = new Button();
            button2 = new Button();
            txtPassword = new TextBox();
            label5 = new Label();
            txtcountry = new TextBox();
            SuspendLayout();
            // 
            // txtfname
            // 
            txtfname.Location = new Point(157, 77);
            txtfname.Name = "txtfname";
            txtfname.Size = new Size(160, 27);
            txtfname.TabIndex = 0;
            // 
            // txtphone
            // 
            txtphone.Location = new Point(487, 283);
            txtphone.Name = "txtphone";
            txtphone.Size = new Size(205, 27);
            txtphone.TabIndex = 1;
            txtphone.TextChanged += textBox2_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(487, 179);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(205, 27);
            txtEmail.TabIndex = 2;
            // 
            // txtlname
            // 
            txtlname.Location = new Point(487, 77);
            txtlname.Name = "txtlname";
            txtlname.Size = new Size(205, 27);
            txtlname.TabIndex = 3;
            txtlname.TextChanged += textBox4_TextChanged;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(904, 179);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(250, 27);
            txtUsername.TabIndex = 4;
            // 
            // dtpdob
            // 
            dtpdob.Location = new Point(904, 70);
            dtpdob.Name = "dtpdob";
            dtpdob.Size = new Size(250, 27);
            dtpdob.TabIndex = 7;
            // 
            // cmbGender
            // 
            cmbGender.AutoCompleteCustomSource.AddRange(new string[] { "Male", "Female", "Others" });
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female", "Others" });
            cmbGender.Location = new Point(147, 179);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(170, 28);
            cmbGender.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 77);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 9;
            label1.Text = "FirstName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(374, 84);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 10;
            label2.Text = "LastName";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(389, 187);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 11;
            label3.Text = "Email";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(399, 290);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 12;
            label4.Text = "Phone";
            label4.Click += label4_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(781, 179);
            label7.Name = "label7";
            label7.Size = new Size(73, 20);
            label7.TabIndex = 15;
            label7.Text = "username";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(36, 290);
            label8.Name = "label8";
            label8.Size = new Size(70, 20);
            label8.TabIndex = 16;
            label8.Text = "Password";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(36, 187);
            label9.Name = "label9";
            label9.Size = new Size(57, 20);
            label9.TabIndex = 17;
            label9.Text = "Gender";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(781, 80);
            label10.Name = "label10";
            label10.Size = new Size(40, 20);
            label10.TabIndex = 18;
            label10.Text = "DOB";
            label10.Click += label10_Click;
            // 
            // button1
            // 
            button1.Location = new Point(299, 450);
            button1.Name = "button1";
            button1.Size = new Size(126, 51);
            button1.TabIndex = 19;
            button1.Text = "Registration";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(636, 450);
            button2.Name = "button2";
            button2.Size = new Size(158, 51);
            button2.TabIndex = 20;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(147, 280);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(170, 27);
            txtPassword.TabIndex = 21;
            txtPassword.TextChanged += textBox7_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(781, 298);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 22;
            label5.Text = "Country";
            label5.Click += label5_Click_1;
            // 
            // txtcountry
            // 
            txtcountry.Location = new Point(904, 290);
            txtcountry.Name = "txtcountry";
            txtcountry.Size = new Size(250, 27);
            txtcountry.TabIndex = 23;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1196, 535);
            Controls.Add(txtcountry);
            Controls.Add(label5);
            Controls.Add(txtPassword);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbGender);
            Controls.Add(dtpdob);
            Controls.Add(txtUsername);
            Controls.Add(txtlname);
            Controls.Add(txtEmail);
            Controls.Add(txtphone);
            Controls.Add(txtfname);
            Name = "Form1";
            Text = "RegistrationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtfname;
        private TextBox txtphone;
        private TextBox txtEmail;
        private TextBox txtlname;
        private TextBox txtUsername;
        private DateTimePicker dtpdob;
        private ComboBox cmbGender;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button button1;
        private Button button2;
        private TextBox txtPassword;
        private Label label5;
        private TextBox txtcountry;
    }
}
