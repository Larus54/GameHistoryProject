namespace GameHistoryProject
{
    partial class frmmain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmain));
            this.lblusername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbltitlegame = new System.Windows.Forms.Label();
            this.lbldeveloper = new System.Windows.Forms.Label();
            this.pnlTopbar = new System.Windows.Forms.Panel();
            this.lblnumversion = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlNavIndicator = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lbltitle = new System.Windows.Forms.Label();
            this.lbluser = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTabTitle = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnsettings = new System.Windows.Forms.Button();
            this.btnTabSearch = new System.Windows.Forms.Button();
            this.btnlibrary = new System.Windows.Forms.Button();
            this.picicon = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.lblstatussuccess = new System.Windows.Forms.Label();
            this.pnlTopbar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picicon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(124)))), ((int)(((byte)(146)))));
            this.lblusername.Location = new System.Drawing.Point(11, 655);
            this.lblusername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(105, 20);
            this.lblusername.TabIndex = 0;
            this.lblusername.Text = "Benvenuto: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(124)))), ((int)(((byte)(146)))));
            this.label1.Location = new System.Drawing.Point(785, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Status:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbltitlegame
            // 
            this.lbltitlegame.AutoSize = true;
            this.lbltitlegame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitlegame.Location = new System.Drawing.Point(515, 229);
            this.lbltitlegame.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltitlegame.Name = "lbltitlegame";
            this.lbltitlegame.Size = new System.Drawing.Size(16, 24);
            this.lbltitlegame.TabIndex = 7;
            this.lbltitlegame.Text = ".";
            // 
            // lbldeveloper
            // 
            this.lbldeveloper.AutoSize = true;
            this.lbldeveloper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldeveloper.Location = new System.Drawing.Point(515, 258);
            this.lbldeveloper.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldeveloper.Name = "lbldeveloper";
            this.lbldeveloper.Size = new System.Drawing.Size(14, 20);
            this.lbldeveloper.TabIndex = 8;
            this.lbldeveloper.Text = "-";
            // 
            // pnlTopbar
            // 
            this.pnlTopbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.pnlTopbar.Controls.Add(this.lblstatussuccess);
            this.pnlTopbar.Controls.Add(this.btnMinimize);
            this.pnlTopbar.Controls.Add(this.lblnumversion);
            this.pnlTopbar.Controls.Add(this.lblVersion);
            this.pnlTopbar.Controls.Add(this.btnclose);
            this.pnlTopbar.Controls.Add(this.label3);
            this.pnlTopbar.Controls.Add(this.label1);
            this.pnlTopbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopbar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopbar.Name = "pnlTopbar";
            this.pnlTopbar.Size = new System.Drawing.Size(1069, 60);
            this.pnlTopbar.TabIndex = 13;
            this.pnlTopbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTopbar_MouseDown);
            this.pnlTopbar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTopbar_MouseMove);
            // 
            // lblnumversion
            // 
            this.lblnumversion.AutoSize = true;
            this.lblnumversion.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumversion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(124)))), ((int)(((byte)(146)))));
            this.lblnumversion.Location = new System.Drawing.Point(705, 4);
            this.lblnumversion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnumversion.Name = "lblnumversion";
            this.lblnumversion.Size = new System.Drawing.Size(40, 19);
            this.lblnumversion.TabIndex = 17;
            this.lblnumversion.Text = "0.13";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(124)))), ((int)(((byte)(146)))));
            this.lblVersion.Location = new System.Drawing.Point(636, 2);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(75, 20);
            this.lblVersion.TabIndex = 15;
            this.lblVersion.Text = "Version:";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(124)))), ((int)(((byte)(146)))));
            this.label3.Location = new System.Drawing.Point(11, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 28);
            this.label3.TabIndex = 14;
            this.label3.Text = "GameHistory - Project";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.pnlNavIndicator);
            this.panel2.Controls.Add(this.btnsettings);
            this.panel2.Controls.Add(this.btnTabSearch);
            this.panel2.Controls.Add(this.btnlibrary);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 624);
            this.panel2.TabIndex = 14;
            // 
            // pnlNavIndicator
            // 
            this.pnlNavIndicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(99)))), ((int)(((byte)(135)))));
            this.pnlNavIndicator.Location = new System.Drawing.Point(0, 436);
            this.pnlNavIndicator.Name = "pnlNavIndicator";
            this.pnlNavIndicator.Size = new System.Drawing.Size(2, 100);
            this.pnlNavIndicator.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.lbltitle);
            this.panel3.Controls.Add(this.lbluser);
            this.panel3.Controls.Add(this.picicon);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 160);
            this.panel3.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "MENU";
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(124)))), ((int)(((byte)(146)))));
            this.lbltitle.Location = new System.Drawing.Point(57, 75);
            this.lbltitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(54, 19);
            this.lbltitle.TabIndex = 16;
            this.lbltitle.Text = "Utente";
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(124)))), ((int)(((byte)(146)))));
            this.lbluser.Location = new System.Drawing.Point(58, 46);
            this.lbluser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(15, 19);
            this.lbluser.TabIndex = 15;
            this.lbluser.Text = "-";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.panel4.Controls.Add(this.lblTabTitle);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(200, 60);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(869, 42);
            this.panel4.TabIndex = 15;
            // 
            // lblTabTitle
            // 
            this.lblTabTitle.AutoSize = true;
            this.lblTabTitle.Font = new System.Drawing.Font("Roboto", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(124)))), ((int)(((byte)(146)))));
            this.lblTabTitle.Location = new System.Drawing.Point(6, 7);
            this.lblTabTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTabTitle.Name = "lblTabTitle";
            this.lblTabTitle.Size = new System.Drawing.Size(89, 28);
            this.lblTabTitle.TabIndex = 16;
            this.lblTabTitle.Text = "Libreria";
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(200, 102);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(869, 582);
            this.pnlMain.TabIndex = 16;
            // 
            // btnsettings
            // 
            this.btnsettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnsettings.FlatAppearance.BorderSize = 0;
            this.btnsettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsettings.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(124)))), ((int)(((byte)(146)))));
            this.btnsettings.Image = ((System.Drawing.Image)(resources.GetObject("btnsettings.Image")));
            this.btnsettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsettings.Location = new System.Drawing.Point(0, 572);
            this.btnsettings.Name = "btnsettings";
            this.btnsettings.Size = new System.Drawing.Size(200, 52);
            this.btnsettings.TabIndex = 17;
            this.btnsettings.Text = "Impostazioni";
            this.btnsettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsettings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnsettings.UseVisualStyleBackColor = true;
            this.btnsettings.Click += new System.EventHandler(this.btnsettings_Click);
            // 
            // btnTabSearch
            // 
            this.btnTabSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTabSearch.FlatAppearance.BorderSize = 0;
            this.btnTabSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabSearch.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTabSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(124)))), ((int)(((byte)(146)))));
            this.btnTabSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnTabSearch.Image")));
            this.btnTabSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTabSearch.Location = new System.Drawing.Point(0, 212);
            this.btnTabSearch.Name = "btnTabSearch";
            this.btnTabSearch.Size = new System.Drawing.Size(200, 52);
            this.btnTabSearch.TabIndex = 16;
            this.btnTabSearch.Text = "Ricerca";
            this.btnTabSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTabSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnTabSearch.UseVisualStyleBackColor = true;
            this.btnTabSearch.Click += new System.EventHandler(this.btnTabSearch_Click);
            // 
            // btnlibrary
            // 
            this.btnlibrary.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnlibrary.FlatAppearance.BorderSize = 0;
            this.btnlibrary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlibrary.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlibrary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(124)))), ((int)(((byte)(146)))));
            this.btnlibrary.Image = ((System.Drawing.Image)(resources.GetObject("btnlibrary.Image")));
            this.btnlibrary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlibrary.Location = new System.Drawing.Point(0, 160);
            this.btnlibrary.Name = "btnlibrary";
            this.btnlibrary.Size = new System.Drawing.Size(200, 52);
            this.btnlibrary.TabIndex = 15;
            this.btnlibrary.Text = "Libreria";
            this.btnlibrary.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlibrary.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnlibrary.UseVisualStyleBackColor = true;
            this.btnlibrary.Click += new System.EventHandler(this.btnlibrary_Click);
            // 
            // picicon
            // 
            this.picicon.Image = ((System.Drawing.Image)(resources.GetObject("picicon.Image")));
            this.picicon.Location = new System.Drawing.Point(11, 42);
            this.picicon.Name = "picicon";
            this.picicon.Size = new System.Drawing.Size(41, 55);
            this.picicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picicon.TabIndex = 15;
            this.picicon.TabStop = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackgroundImage = global::GameHistoryProject.Properties.Resources.minimize;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(999, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(29, 34);
            this.btnMinimize.TabIndex = 18;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnclose
            // 
            this.btnclose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnclose.BackgroundImage")));
            this.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Location = new System.Drawing.Point(1029, 14);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(29, 34);
            this.btnclose.TabIndex = 0;
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // lblstatussuccess
            // 
            this.lblstatussuccess.AutoSize = true;
            this.lblstatussuccess.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatussuccess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(124)))), ((int)(((byte)(146)))));
            this.lblstatussuccess.Location = new System.Drawing.Point(785, 23);
            this.lblstatussuccess.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblstatussuccess.Name = "lblstatussuccess";
            this.lblstatussuccess.Size = new System.Drawing.Size(0, 19);
            this.lblstatussuccess.TabIndex = 44;
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1069, 684);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlTopbar);
            this.Controls.Add(this.lbldeveloper);
            this.Controls.Add(this.lbltitlegame);
            this.Controls.Add(this.lblusername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmmain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameHistoryProject";
            this.pnlTopbar.ResumeLayout(false);
            this.pnlTopbar.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picicon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbltitlegame;
        private System.Windows.Forms.Label lbldeveloper;
        private System.Windows.Forms.Panel pnlTopbar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox picicon;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnlibrary;
        private System.Windows.Forms.Button btnTabSearch;
        private System.Windows.Forms.Button btnsettings;
        private System.Windows.Forms.Panel pnlNavIndicator;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTabTitle;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblnumversion;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Label lblstatussuccess;
    }
}