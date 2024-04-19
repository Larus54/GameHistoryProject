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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblstatussuccess = new System.Windows.Forms.Label();
            this.lblstringupdate = new System.Windows.Forms.Label();
            this.lblupdate = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlInfo.SuspendLayout();
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
            this.lstgames.Location = new System.Drawing.Point(12, 69);
            this.lstgames.Name = "lstgames";
            this.lstgames.Size = new System.Drawing.Size(290, 434);
            this.lstgames.TabIndex = 22;
            this.lstgames.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstgames_DrawItem);
            // 
            // cmbTypes
            // 
            this.cmbTypes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.cmbTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypes.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTypes.ForeColor = System.Drawing.Color.White;
            this.cmbTypes.FormattingEnabled = true;
            this.cmbTypes.Location = new System.Drawing.Point(181, 40);
            this.cmbTypes.Name = "cmbTypes";
            this.cmbTypes.Size = new System.Drawing.Size(121, 23);
            this.cmbTypes.TabIndex = 38;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(124)))), ((int)(((byte)(146)))));
            this.lblCategory.Location = new System.Drawing.Point(201, 18);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(79, 19);
            this.lblCategory.TabIndex = 37;
            this.lblCategory.Text = "Categoria";
            // 
            // txtsearch
            // 
            this.txtsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.txtsearch.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.ForeColor = System.Drawing.Color.White;
            this.txtsearch.Location = new System.Drawing.Point(12, 40);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(162, 23);
            this.txtsearch.TabIndex = 35;
            // 
            // lblsearchtitle
            // 
            this.lblsearchtitle.AutoSize = true;
            this.lblsearchtitle.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearchtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(124)))), ((int)(((byte)(146)))));
            this.lblsearchtitle.Location = new System.Drawing.Point(68, 18);
            this.lblsearchtitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsearchtitle.Name = "lblsearchtitle";
            this.lblsearchtitle.Size = new System.Drawing.Size(50, 19);
            this.lblsearchtitle.TabIndex = 41;
            this.lblsearchtitle.Text = "Titolo";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lblupdate);
            this.pnlMain.Controls.Add(this.lblstatussuccess);
            this.pnlMain.Controls.Add(this.pnlInfo);
            this.pnlMain.Controls.Add(this.txtsearch);
            this.pnlMain.Controls.Add(this.lblsearchtitle);
            this.pnlMain.Controls.Add(this.lstgames);
            this.pnlMain.Controls.Add(this.lblCategory);
            this.pnlMain.Controls.Add(this.cmbTypes);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(869, 533);
            this.pnlMain.TabIndex = 42;
            // 
            // pnlInfo
            // 
            this.pnlInfo.AutoScroll = true;
            this.pnlInfo.AutoScrollMinSize = new System.Drawing.Size(0, 200);
            this.pnlInfo.Controls.Add(this.lblstringupdate);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlInfo.Location = new System.Drawing.Point(308, 0);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(561, 533);
            this.pnlInfo.TabIndex = 42;
            // 
            // lblstatussuccess
            // 
            this.lblstatussuccess.AutoSize = true;
            this.lblstatussuccess.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatussuccess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(124)))), ((int)(((byte)(146)))));
            this.lblstatussuccess.Location = new System.Drawing.Point(284, 507);
            this.lblstatussuccess.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblstatussuccess.Name = "lblstatussuccess";
            this.lblstatussuccess.Size = new System.Drawing.Size(0, 19);
            this.lblstatussuccess.TabIndex = 45;
            // 
            // lblstringupdate
            // 
            this.lblstringupdate.AutoSize = true;
            this.lblstringupdate.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstringupdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(124)))), ((int)(((byte)(146)))));
            this.lblstringupdate.Location = new System.Drawing.Point(-295, 504);
            this.lblstringupdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblstringupdate.Name = "lblstringupdate";
            this.lblstringupdate.Size = new System.Drawing.Size(13, 19);
            this.lblstringupdate.TabIndex = 44;
            this.lblstringupdate.Text = "-";
            // 
            // lblupdate
            // 
            this.lblupdate.AutoSize = true;
            this.lblupdate.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblupdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(124)))), ((int)(((byte)(146)))));
            this.lblupdate.Location = new System.Drawing.Point(10, 507);
            this.lblupdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblupdate.Name = "lblupdate";
            this.lblupdate.Size = new System.Drawing.Size(13, 19);
            this.lblupdate.TabIndex = 46;
            this.lblupdate.Text = "-";
            // 
            // frmBak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(869, 533);
            this.Controls.Add(this.pnlMain);
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBak";
            this.Text = "frmbak";
            this.Load += new System.EventHandler(this.frmBak_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstgames;
        private System.Windows.Forms.ComboBox cmbTypes;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label lblsearchtitle;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lblstatussuccess;
        private System.Windows.Forms.Label lblstringupdate;
        private System.Windows.Forms.Label lblupdate;
    }
}