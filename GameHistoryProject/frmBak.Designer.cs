namespace GameHistoryProject
{
    partial class frmBak
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
            this.lstgames = new System.Windows.Forms.ListBox();
            this.cmbTypes = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.lblsearchtitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstgames
            // 
            this.lstgames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.lstgames.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstgames.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstgames.ForeColor = System.Drawing.Color.White;
            this.lstgames.FormattingEnabled = true;
            this.lstgames.ItemHeight = 18;
            this.lstgames.Location = new System.Drawing.Point(12, 66);
            this.lstgames.Name = "lstgames";
            this.lstgames.Size = new System.Drawing.Size(290, 434);
            this.lstgames.TabIndex = 22;
            // 
            // cmbTypes
            // 
            this.cmbTypes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.cmbTypes.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTypes.ForeColor = System.Drawing.Color.White;
            this.cmbTypes.FormattingEnabled = true;
            this.cmbTypes.Location = new System.Drawing.Point(181, 29);
            this.cmbTypes.Name = "cmbTypes";
            this.cmbTypes.Size = new System.Drawing.Size(121, 23);
            this.cmbTypes.TabIndex = 38;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(124)))), ((int)(((byte)(146)))));
            this.lblCategory.Location = new System.Drawing.Point(202, 8);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(86, 19);
            this.lblCategory.TabIndex = 37;
            this.lblCategory.Text = "Categoria";
            // 
            // txtsearch
            // 
            this.txtsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.txtsearch.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.ForeColor = System.Drawing.Color.White;
            this.txtsearch.Location = new System.Drawing.Point(12, 29);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(162, 23);
            this.txtsearch.TabIndex = 35;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // lblsearchtitle
            // 
            this.lblsearchtitle.AutoSize = true;
            this.lblsearchtitle.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearchtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(124)))), ((int)(((byte)(146)))));
            this.lblsearchtitle.Location = new System.Drawing.Point(68, 7);
            this.lblsearchtitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsearchtitle.Name = "lblsearchtitle";
            this.lblsearchtitle.Size = new System.Drawing.Size(56, 19);
            this.lblsearchtitle.TabIndex = 41;
            this.lblsearchtitle.Text = "Titolo";
            // 
            // frmBak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(869, 533);
            this.Controls.Add(this.lblsearchtitle);
            this.Controls.Add(this.cmbTypes);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.lstgames);
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBak";
            this.Text = "frmbak";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstgames;
        private System.Windows.Forms.ComboBox cmbTypes;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label lblsearchtitle;
    }
}