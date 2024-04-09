namespace GameHistoryProject.Panel
{
    partial class frmLibrary
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
            this.lblTabTitle = new System.Windows.Forms.Label();
            this.pnlDock = new System.Windows.Forms.Panel();
            this.pnlNavIndicator = new System.Windows.Forms.Panel();
            this.btnWIP = new System.Windows.Forms.Button();
            this.btnFavourite = new System.Windows.Forms.Button();
            this.btnBak = new System.Windows.Forms.Button();
            this.pnlDock.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTabTitle
            // 
            this.lblTabTitle.AutoSize = true;
            this.lblTabTitle.Font = new System.Drawing.Font("Roboto", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(124)))), ((int)(((byte)(146)))));
            this.lblTabTitle.Location = new System.Drawing.Point(297, 278);
            this.lblTabTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTabTitle.Name = "lblTabTitle";
            this.lblTabTitle.Size = new System.Drawing.Size(239, 35);
            this.lblTabTitle.TabIndex = 17;
            this.lblTabTitle.Text = "Work In Progress";
            // 
            // pnlDock
            // 
            this.pnlDock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.pnlDock.Controls.Add(this.pnlNavIndicator);
            this.pnlDock.Controls.Add(this.btnWIP);
            this.pnlDock.Controls.Add(this.btnFavourite);
            this.pnlDock.Controls.Add(this.btnBak);
            this.pnlDock.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDock.Location = new System.Drawing.Point(0, 0);
            this.pnlDock.Name = "pnlDock";
            this.pnlDock.Size = new System.Drawing.Size(869, 49);
            this.pnlDock.TabIndex = 18;
            // 
            // pnlNavIndicator
            // 
            this.pnlNavIndicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(99)))), ((int)(((byte)(135)))));
            this.pnlNavIndicator.Location = new System.Drawing.Point(436, 0);
            this.pnlNavIndicator.Name = "pnlNavIndicator";
            this.pnlNavIndicator.Size = new System.Drawing.Size(100, 2);
            this.pnlNavIndicator.TabIndex = 19;
            // 
            // btnWIP
            // 
            this.btnWIP.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnWIP.FlatAppearance.BorderSize = 0;
            this.btnWIP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWIP.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWIP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(124)))), ((int)(((byte)(146)))));
            this.btnWIP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWIP.Location = new System.Drawing.Point(580, 0);
            this.btnWIP.Name = "btnWIP";
            this.btnWIP.Size = new System.Drawing.Size(289, 49);
            this.btnWIP.TabIndex = 18;
            this.btnWIP.Text = "WIP";
            this.btnWIP.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnWIP.UseVisualStyleBackColor = true;
            // 
            // btnFavourite
            // 
            this.btnFavourite.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnFavourite.FlatAppearance.BorderSize = 0;
            this.btnFavourite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFavourite.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFavourite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(124)))), ((int)(((byte)(146)))));
            this.btnFavourite.Image = global::GameHistoryProject.Properties.Resources.library;
            this.btnFavourite.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFavourite.Location = new System.Drawing.Point(289, 0);
            this.btnFavourite.Name = "btnFavourite";
            this.btnFavourite.Size = new System.Drawing.Size(291, 49);
            this.btnFavourite.TabIndex = 17;
            this.btnFavourite.Text = "Preferiti";
            this.btnFavourite.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFavourite.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnFavourite.UseVisualStyleBackColor = true;
            this.btnFavourite.Click += new System.EventHandler(this.btnFavourite_Click);
            // 
            // btnBak
            // 
            this.btnBak.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBak.FlatAppearance.BorderSize = 0;
            this.btnBak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBak.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBak.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(124)))), ((int)(((byte)(146)))));
            this.btnBak.Image = global::GameHistoryProject.Properties.Resources.library;
            this.btnBak.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBak.Location = new System.Drawing.Point(0, 0);
            this.btnBak.Name = "btnBak";
            this.btnBak.Size = new System.Drawing.Size(289, 49);
            this.btnBak.TabIndex = 16;
            this.btnBak.Text = "Bacheca";
            this.btnBak.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBak.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBak.UseVisualStyleBackColor = true;
            this.btnBak.Click += new System.EventHandler(this.btnBak_Click);
            // 
            // frmLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(869, 582);
            this.Controls.Add(this.pnlDock);
            this.Controls.Add(this.lblTabTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLibrary";
            this.Text = "frmLibrary";
            this.pnlDock.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTabTitle;
        private System.Windows.Forms.Panel pnlDock;
        private System.Windows.Forms.Button btnBak;
        private System.Windows.Forms.Button btnFavourite;
        private System.Windows.Forms.Button btnWIP;
        private System.Windows.Forms.Panel pnlNavIndicator;
    }
}