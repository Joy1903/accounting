namespace accounting
{
    partial class add_category
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
            this.categories_table = new System.Windows.Forms.DataGridView();
            this.add = new System.Windows.Forms.Button();
            this.back_home = new System.Windows.Forms.Button();
            this.category_title = new System.Windows.Forms.TextBox();
            this.type = new System.Windows.Forms.ComboBox();
            this.combo_to_delete = new System.Windows.Forms.ComboBox();
            this.delete_category = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.categories_table)).BeginInit();
            this.SuspendLayout();
            // 
            // categories_table
            // 
            this.categories_table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.categories_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categories_table.Location = new System.Drawing.Point(12, 126);
            this.categories_table.Name = "categories_table";
            this.categories_table.RowHeadersWidth = 51;
            this.categories_table.RowTemplate.Height = 24;
            this.categories_table.Size = new System.Drawing.Size(488, 182);
            this.categories_table.TabIndex = 0;
            // 
            // add
            // 
            this.add.AutoSize = true;
            this.add.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(427, 330);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(73, 30);
            this.add.TabIndex = 11;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // back_home
            // 
            this.back_home.AutoSize = true;
            this.back_home.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_home.Location = new System.Drawing.Point(12, 80);
            this.back_home.Name = "back_home";
            this.back_home.Size = new System.Drawing.Size(127, 30);
            this.back_home.TabIndex = 12;
            this.back_home.Text = "Back Home";
            this.back_home.UseVisualStyleBackColor = true;
            this.back_home.Click += new System.EventHandler(this.back_home_Click);
            // 
            // category_title
            // 
            this.category_title.Font = new System.Drawing.Font("Nirmala UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_title.Location = new System.Drawing.Point(12, 329);
            this.category_title.Name = "category_title";
            this.category_title.Size = new System.Drawing.Size(159, 30);
            this.category_title.TabIndex = 13;
            this.category_title.Text = "Name of category";
            this.category_title.Enter += new System.EventHandler(this.category_title_Enter);
            this.category_title.Leave += new System.EventHandler(this.category_title_Leave);
            // 
            // type
            // 
            this.type.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.type.Font = new System.Drawing.Font("Nirmala UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type.FormattingEnabled = true;
            this.type.Location = new System.Drawing.Point(212, 329);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(177, 31);
            this.type.TabIndex = 14;
            this.type.Text = "Type of category";
            // 
            // combo_to_delete
            // 
            this.combo_to_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo_to_delete.Font = new System.Drawing.Font("Nirmala UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_to_delete.FormattingEnabled = true;
            this.combo_to_delete.Location = new System.Drawing.Point(12, 393);
            this.combo_to_delete.Name = "combo_to_delete";
            this.combo_to_delete.Size = new System.Drawing.Size(278, 31);
            this.combo_to_delete.TabIndex = 15;
            this.combo_to_delete.Text = "Category";
            // 
            // delete_category
            // 
            this.delete_category.AutoSize = true;
            this.delete_category.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_category.Location = new System.Drawing.Point(427, 394);
            this.delete_category.Name = "delete_category";
            this.delete_category.Size = new System.Drawing.Size(73, 30);
            this.delete_category.TabIndex = 16;
            this.delete_category.Text = "delete";
            this.delete_category.UseVisualStyleBackColor = true;
            this.delete_category.Click += new System.EventHandler(this.delete_category_Click);
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
            this.label1.Size = new System.Drawing.Size(512, 77);
            this.label1.TabIndex = 17;
            this.label1.Text = "Category ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.Location = new System.Drawing.Point(10, 366);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 10);
            this.panel1.TabIndex = 18;
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(368, 80);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 30);
            this.button3.TabIndex = 19;
            this.button3.Text = "Change category";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // add_category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(512, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.delete_category);
            this.Controls.Add(this.combo_to_delete);
            this.Controls.Add(this.type);
            this.Controls.Add(this.category_title);
            this.Controls.Add(this.back_home);
            this.Controls.Add(this.add);
            this.Controls.Add(this.categories_table);
            this.Controls.Add(this.label1);
            this.Name = "add_category";
            this.Text = "add_category";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.add_category_FormClosing);
            this.Load += new System.EventHandler(this.add_category_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categories_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView categories_table;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button back_home;
        private System.Windows.Forms.TextBox category_title;
        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.ComboBox combo_to_delete;
        private System.Windows.Forms.Button delete_category;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
    }
}