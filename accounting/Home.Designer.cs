namespace accounting
{
    partial class Home
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.add_transaction = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.user_login = new System.Windows.Forms.LinkLabel();
            this.sort_by_date = new System.Windows.Forms.Button();
            this.sort_by_user = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.category = new System.Windows.Forms.ComboBox();
            this.add_category = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // add_transaction
            // 
            this.add_transaction.AutoSize = true;
            this.add_transaction.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_transaction.Location = new System.Drawing.Point(397, 121);
            this.add_transaction.Name = "add_transaction";
            this.add_transaction.Size = new System.Drawing.Size(161, 41);
            this.add_transaction.TabIndex = 0;
            this.add_transaction.Text = "Add transaction";
            this.add_transaction.UseVisualStyleBackColor = true;
            this.add_transaction.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Accouting";
            // 
            // user_login
            // 
            this.user_login.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.user_login.AutoSize = true;
            this.user_login.BackColor = System.Drawing.Color.CornflowerBlue;
            this.user_login.Font = new System.Drawing.Font("Nirmala UI Semilight", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_login.LinkColor = System.Drawing.Color.White;
            this.user_login.Location = new System.Drawing.Point(21, 77);
            this.user_login.Name = "user_login";
            this.user_login.Size = new System.Drawing.Size(89, 38);
            this.user_login.TabIndex = 2;
            this.user_login.TabStop = true;
            this.user_login.Text = "Name";
            this.user_login.VisitedLinkColor = System.Drawing.Color.Gray;
            this.user_login.Click += new System.EventHandler(this.user_login_Click);
            // 
            // sort_by_date
            // 
            this.sort_by_date.AutoSize = true;
            this.sort_by_date.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sort_by_date.Location = new System.Drawing.Point(12, 124);
            this.sort_by_date.Name = "sort_by_date";
            this.sort_by_date.Size = new System.Drawing.Size(86, 38);
            this.sort_by_date.TabIndex = 4;
            this.sort_by_date.Text = "By date";
            this.sort_by_date.UseVisualStyleBackColor = true;
            this.sort_by_date.Click += new System.EventHandler(this.sort_by_date_Click);
            // 
            // sort_by_user
            // 
            this.sort_by_user.AutoSize = true;
            this.sort_by_user.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sort_by_user.Location = new System.Drawing.Point(104, 124);
            this.sort_by_user.Name = "sort_by_user";
            this.sort_by_user.Size = new System.Drawing.Size(99, 38);
            this.sort_by_user.TabIndex = 5;
            this.sort_by_user.Text = "By Name";
            this.sort_by_user.UseVisualStyleBackColor = true;
            this.sort_by_user.Click += new System.EventHandler(this.sort_by_user_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 216);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(546, 243);
            this.dataGridView1.TabIndex = 7;
            // 
            // category
            // 
            this.category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.category.Font = new System.Drawing.Font("Nirmala UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category.FormattingEnabled = true;
            this.category.Location = new System.Drawing.Point(219, 124);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(162, 31);
            this.category.TabIndex = 9;
            this.category.Text = "Category";
            this.category.SelectedIndexChanged += new System.EventHandler(this.category_SelectedIndexChanged);
            // 
            // add_category
            // 
            this.add_category.AutoSize = true;
            this.add_category.Font = new System.Drawing.Font("Nirmala UI Semilight", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_category.Location = new System.Drawing.Point(239, 161);
            this.add_category.Name = "add_category";
            this.add_category.Size = new System.Drawing.Size(124, 27);
            this.add_category.TabIndex = 10;
            this.add_category.Text = "Add category";
            this.add_category.UseVisualStyleBackColor = true;
            this.add_category.Click += new System.EventHandler(this.add_category_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(570, 492);
            this.Controls.Add(this.add_category);
            this.Controls.Add(this.category);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.sort_by_user);
            this.Controls.Add(this.sort_by_date);
            this.Controls.Add(this.user_login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add_transaction);
            this.Name = "Home";
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResizeEnd += new System.EventHandler(this.Home_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_transaction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel user_login;
        private System.Windows.Forms.Button sort_by_date;
        private System.Windows.Forms.Button sort_by_user;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox category;
        private System.Windows.Forms.Button add_category;
    }
}