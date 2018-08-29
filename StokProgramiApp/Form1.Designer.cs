namespace StokProgramiApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Usernam = new System.Windows.Forms.Label();
            this.Passwor = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.Login = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Login)).BeginInit();
            this.SuspendLayout();
            // 
            // Usernam
            // 
            this.Usernam.AutoSize = true;
            this.Usernam.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usernam.Location = new System.Drawing.Point(352, 148);
            this.Usernam.Name = "Usernam";
            this.Usernam.Size = new System.Drawing.Size(144, 33);
            this.Usernam.TabIndex = 0;
            this.Usernam.Text = "Username :";
            this.Usernam.Click += new System.EventHandler(this.label1_Click);
            // 
            // Passwor
            // 
            this.Passwor.AutoSize = true;
            this.Passwor.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwor.Location = new System.Drawing.Point(352, 186);
            this.Passwor.Name = "Passwor";
            this.Passwor.Size = new System.Drawing.Size(141, 33);
            this.Passwor.TabIndex = 1;
            this.Passwor.Text = "Password  :";
            this.Passwor.Click += new System.EventHandler(this.Passwor_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(565, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(516, 198);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(159, 20);
            this.Password.TabIndex = 4;
            this.Password.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(516, 159);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // colorDialog2
            // 
            this.colorDialog2.Color = System.Drawing.Color.DarkRed;
            // 
            // Login
            // 
            this.Login.ErrorImage = null;
            this.Login.Image = ((System.Drawing.Image)(resources.GetObject("Login.Image")));
            this.Login.InitialImage = null;
            this.Login.Location = new System.Drawing.Point(42, 40);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(313, 313);
            this.Login.TabIndex = 6;
            this.Login.TabStop = false;
            this.Login.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(24, 397);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(397, 282);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 46);
            this.button2.TabIndex = 8;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(728, 397);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Passwor);
            this.Controls.Add(this.Usernam);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Usernam;
        private System.Windows.Forms.Label Passwor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.PictureBox Login;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
    }
}

