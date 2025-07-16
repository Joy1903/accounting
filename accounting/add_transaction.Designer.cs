namespace accounting
{
    partial class add_transaction
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.main_form = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.category = new System.Windows.Forms.ComboBox();
            this.Comment = new System.Windows.Forms.TextBox();
            this.tottal_sum = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(460, 78);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Transaction";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.main_form);
            this.panel1.Controls.Add(this.date);
            this.panel1.Controls.Add(this.category);
            this.panel1.Controls.Add(this.Comment);
            this.panel1.Controls.Add(this.tottal_sum);
            this.panel1.Controls.Add(this.Add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 372);
            this.panel1.TabIndex = 2;
            // 
            // main_form
            // 
            this.main_form.AutoSize = true;
            this.main_form.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_form.Location = new System.Drawing.Point(3, 3);
            this.main_form.Name = "main_form";
            this.main_form.Size = new System.Drawing.Size(127, 30);
            this.main_form.TabIndex = 10;
            this.main_form.Text = "Back Home";
            this.main_form.UseVisualStyleBackColor = true;
            this.main_form.Click += new System.EventHandler(this.main_form_Click);
            // 
            // date
            // 
            this.date.CalendarFont = new System.Drawing.Font("Nirmala UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(145, 182);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(176, 22);
            this.date.TabIndex = 9;
            // 
            // category
            // 
            this.category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.category.Font = new System.Drawing.Font("Nirmala UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category.FormattingEnabled = true;
            this.category.Location = new System.Drawing.Point(145, 134);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(172, 31);
            this.category.TabIndex = 8;
            this.category.Text = "Category";
            // 
            // Comment
            // 
            this.Comment.Font = new System.Drawing.Font("Nirmala UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comment.Location = new System.Drawing.Point(145, 219);
            this.Comment.Name = "Comment";
            this.Comment.Size = new System.Drawing.Size(176, 30);
            this.Comment.TabIndex = 7;
            this.Comment.Text = "Comment";
            this.Comment.Enter += new System.EventHandler(this.Comment_Enter);
            this.Comment.Leave += new System.EventHandler(this.Comment_Leave);
            // 
            // tottal_sum
            // 
            this.tottal_sum.Font = new System.Drawing.Font("Nirmala UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tottal_sum.Location = new System.Drawing.Point(145, 84);
            this.tottal_sum.Name = "tottal_sum";
            this.tottal_sum.Size = new System.Drawing.Size(176, 30);
            this.tottal_sum.TabIndex = 6;
            this.tottal_sum.Text = "Total sum";
            this.tottal_sum.Enter += new System.EventHandler(this.tottal_sum_Enter);
            this.tottal_sum.Leave += new System.EventHandler(this.tottal_sum_Leave);
            // 
            // Add
            // 
            this.Add.AutoSize = true;
            this.Add.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(141, 296);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(180, 41);
            this.Add.TabIndex = 1;
            this.Add.Text = "Add transaction";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // add_transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "add_transaction";
            this.Text = "add_transaction";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.add_transaction_FormClosing);
            this.Load += new System.EventHandler(this.add_transaction_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox Comment;
        private System.Windows.Forms.TextBox tottal_sum;
        private System.Windows.Forms.ComboBox category;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Button main_form;
    }
}