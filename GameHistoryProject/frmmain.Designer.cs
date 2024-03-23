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
            this.components = new System.ComponentModel.Container();
            this.lblusername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblstatus = new System.Windows.Forms.Label();
            this.lstgames = new System.Windows.Forms.ListBox();
            this.imglist = new System.Windows.Forms.ImageList(this.components);
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbltitlegame = new System.Windows.Forms.Label();
            this.lbldeveloper = new System.Windows.Forms.Label();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.cmbTypes = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.Location = new System.Drawing.Point(9, 338);
            this.lblusername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(94, 20);
            this.lblusername.TabIndex = 0;
            this.lblusername.Text = "Benvenuto: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(638, 338);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Status:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatus.Location = new System.Drawing.Point(695, 338);
            this.lblstatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(14, 20);
            this.lblstatus.TabIndex = 2;
            this.lblstatus.Text = "-";
            this.lblstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstgames
            // 
            this.lstgames.FormattingEnabled = true;
            this.lstgames.Location = new System.Drawing.Point(9, 62);
            this.lstgames.Margin = new System.Windows.Forms.Padding(2);
            this.lstgames.Name = "lstgames";
            this.lstgames.Size = new System.Drawing.Size(234, 264);
            this.lstgames.TabIndex = 3;
            this.lstgames.SelectedIndexChanged += new System.EventHandler(this.lstgames_SelectedIndexChanged);
            // 
            // imglist
            // 
            this.imglist.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imglist.ImageSize = new System.Drawing.Size(16, 16);
            this.imglist.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(9, 36);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(150, 20);
            this.txtsearch.TabIndex = 4;
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(162, 35);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnsearch.Size = new System.Drawing.Size(80, 22);
            this.btnsearch.TabIndex = 5;
            this.btnsearch.Text = "Cerca";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ricerca gioco";
            // 
            // lbltitlegame
            // 
            this.lbltitlegame.AutoSize = true;
            this.lbltitlegame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitlegame.Location = new System.Drawing.Point(266, 12);
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
            this.lbldeveloper.Location = new System.Drawing.Point(266, 41);
            this.lbldeveloper.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldeveloper.Name = "lbldeveloper";
            this.lbldeveloper.Size = new System.Drawing.Size(14, 20);
            this.lbldeveloper.TabIndex = 8;
            this.lbldeveloper.Text = "-";
            // 
            // txtdescription
            // 
            this.txtdescription.Enabled = false;
            this.txtdescription.Location = new System.Drawing.Point(268, 83);
            this.txtdescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtdescription.Multiline = true;
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtdescription.Size = new System.Drawing.Size(293, 243);
            this.txtdescription.TabIndex = 10;
            // 
            // cmbTypes
            // 
            this.cmbTypes.FormattingEnabled = true;
            this.cmbTypes.Location = new System.Drawing.Point(162, 12);
            this.cmbTypes.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTypes.Name = "cmbTypes";
            this.cmbTypes.Size = new System.Drawing.Size(81, 21);
            this.cmbTypes.TabIndex = 11;
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(748, 366);
            this.Controls.Add(this.cmbTypes);
            this.Controls.Add(this.txtdescription);
            this.Controls.Add(this.lbldeveloper);
            this.Controls.Add(this.lbltitlegame);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.lstgames);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblusername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmmain";
            this.Text = "GameHistoryProject";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmmain_FormClosed);
            this.Load += new System.EventHandler(this.frmmain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.ListBox lstgames;
        private System.Windows.Forms.ImageList imglist;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbltitlegame;
        private System.Windows.Forms.Label lbldeveloper;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.ComboBox cmbTypes;
    }
}