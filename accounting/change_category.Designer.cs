namespace accounting
{
    partial class change_category
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
            this.category_title = new System.Windows.Forms.TextBox();
            this.type = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // category_title
            // 
            this.category_title.Font = new System.Drawing.Font("Nirmala UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_title.Location = new System.Drawing.Point(12, 12);
            this.category_title.Name = "category_title";
            this.category_title.Size = new System.Drawing.Size(159, 30);
            this.category_title.TabIndex = 14;
            this.category_title.Text = "Name of category";
            // 
            // type
            // 
            this.type.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.type.Font = new System.Drawing.Font("Nirmala UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type.FormattingEnabled = true;
            this.type.Location = new System.Drawing.Point(177, 11);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(177, 31);
            this.type.TabIndex = 15;
            this.type.Text = "Type of category";
            // 
            // change_category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 450);
            this.Controls.Add(this.type);
            this.Controls.Add(this.category_title);
            this.Name = "change_category";
            this.Text = "change_category";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox category_title;
        private System.Windows.Forms.ComboBox type;
    }
}