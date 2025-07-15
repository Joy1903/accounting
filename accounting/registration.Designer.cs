namespace accounting
{
    partial class registration
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
            this.label2 = new System.Windows.Forms.Label();
            this.reg = new System.Windows.Forms.Button();
            this.full_name = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.reg);
            this.panel1.Controls.Add(this.full_name);
            this.panel1.Controls.Add(this.Password);
            this.panel1.Controls.Add(this.Login);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 450);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Historic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 41);
            this.label2.TabIndex = 6;
            this.label2.Text = "Registrate form";
            // 
            // reg
            // 
            this.reg.AutoSize = true;
            this.reg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reg.Font = new System.Drawing.Font("Segoe UI Historic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg.Location = new System.Drawing.Point(153, 315);
            this.reg.Name = "reg";
            this.reg.Size = new System.Drawing.Size(108, 35);
            this.reg.TabIndex = 5;
            this.reg.Text = "Registrate";
            this.reg.UseVisualStyleBackColor = true;
            this.reg.Click += new System.EventHandler(this.reg_Click);
            // 
            // full_name
            // 
            this.full_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.full_name.Location = new System.Drawing.Point(123, 162);
            this.full_name.Name = "full_name";
            this.full_name.Size = new System.Drawing.Size(176, 27);
            this.full_name.TabIndex = 4;
            this.full_name.Text = "Full Name";
            this.full_name.Enter += new System.EventHandler(this.full_name_Enter);
            this.full_name.Leave += new System.EventHandler(this.full_name_Leave);
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password.Location = new System.Drawing.Point(123, 258);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(176, 27);
            this.Password.TabIndex = 3;
            this.Password.Text = "Password";
            this.Password.UseSystemPasswordChar = true;
            this.Password.Enter += new System.EventHandler(this.Password_Enter);
            this.Password.Leave += new System.EventHandler(this.Password_Leave);
            // 
            // Login
            // 
            this.Login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login.Location = new System.Drawing.Point(123, 212);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(176, 27);
            this.Login.TabIndex = 2;
            this.Login.Text = "Login";
            this.Login.TextChanged += new System.EventHandler(this.Login_TextChanged);
            this.Login.Enter += new System.EventHandler(this.Login_Enter);
            this.Login.Leave += new System.EventHandler(this.Login_Leave);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MediumPurple;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("MV Boli", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(423, 78);
            this.label1.TabIndex = 1;
            this.label1.Text = "Helloo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 450);
            this.Controls.Add(this.panel1);
            this.Name = "registration";
            this.Text = "registration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.registration_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox full_name;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button reg;
        private System.Windows.Forms.Label label2;
    }
}