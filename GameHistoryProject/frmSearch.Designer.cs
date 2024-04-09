namespace GameHistoryProject
{
    partial class frmSearch
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
            this.btnFavorite = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblsearchtitle = new System.Windows.Forms.Label();
            this.piccover = new System.Windows.Forms.PictureBox();
            this.btnMore = new System.Windows.Forms.Button();
            this.txtdescription = new System.Windows.Forms.RichTextBox();
            this.lbldeveloper = new System.Windows.Forms.Label();
            this.lbltitlegame = new System.Windows.Forms.Label();
            this.lstgames = new System.Windows.Forms.ListBox();
            this.cmbTypes = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.btnSearchGame = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piccover)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFavorite);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.lblsearchtitle);
            this.panel1.Controls.Add(this.piccover);
            this.panel1.Controls.Add(this.btnMore);
            this.panel1.Controls.Add(this.txtdescription);
            this.panel1.Controls.Add(this.lbldeveloper);
            this.panel1.Controls.Add(this.lbltitlegame);
            this.panel1.Controls.Add(this.lstgames);
            this.panel1.Controls.Add(this.cmbTypes);
            this.panel1.Controls.Add(this.lblCategory);
            this.panel1.Controls.Add(this.btnSearchGame);
            this.panel1.Controls.Add(this.txtsearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 582);
            this.panel1.TabIndex = 0;
            // 
            // btnFavorite
            // 
            this.btnFavorite.FlatAppearance.BorderSize = 0;
            this.btnFavorite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFavorite.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFavorite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(124)))), ((int)(((byte)(146)))));
            this.btnFavorite.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFavorite.Location = new System.Drawing.Point(640, 523);
            this.btnFavorite.Name = "btnFavorite";
            this.btnFavorite.Size = new System.Drawing.Size(217, 42);
            this.btnFavorite.TabIndex = 42;
            this.btnFavorite.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFavorite.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnFavorite.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(124)))), ((int)(((byte)(146)))));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(640, 454);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(217, 63);
            this.btnAdd.TabIndex = 41;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblsearchtitle
            // 
            this.lblsearchtitle.AutoSize = true;
            this.lblsearchtitle.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearchtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(124)))), ((int)(((byte)(146)))));
            this.lblsearchtitle.Location = new System.Drawing.Point(72, 22);
            this.lblsearchtitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsearchtitle.Name = "lblsearchtitle";
            this.lblsearchtitle.Size = new System.Drawing.Size(50, 19);
            this.lblsearchtitle.TabIndex = 40;
            this.lblsearchtitle.Text = "Titolo";
            // 
            // piccover
            // 
            this.piccover.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.piccover.Location = new System.Drawing.Point(640, 142);
            this.piccover.Name = "piccover";
            this.piccover.Size = new System.Drawing.Size(217, 306);
            this.piccover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piccover.TabIndex = 39;
            this.piccover.TabStop = false;
            // 
            // btnMore
            // 
            this.btnMore.FlatAppearance.BorderSize = 0;
            this.btnMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMore.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(124)))), ((int)(((byte)(146)))));
            this.btnMore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMore.Location = new System.Drawing.Point(323, 523);
            this.btnMore.Name = "btnMore";
            this.btnMore.Size = new System.Drawing.Size(307, 42);
            this.btnMore.TabIndex = 38;
            this.btnMore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMore.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMore.UseVisualStyleBackColor = true;
            this.btnMore.Click += new System.EventHandler(this.btnMore_Click);
            // 
            // txtdescription
            // 
            this.txtdescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.txtdescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtdescription.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescription.ForeColor = System.Drawing.Color.White;
            this.txtdescription.Location = new System.Drawing.Point(323, 142);
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.ReadOnly = true;
            this.txtdescription.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtdescription.Size = new System.Drawing.Size(307, 375);
            this.txtdescription.TabIndex = 37;
            this.txtdescription.Text = "";
            // 
            // lbldeveloper
            // 
            this.lbldeveloper.AutoSize = true;
            this.lbldeveloper.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldeveloper.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(124)))), ((int)(((byte)(146)))));
            this.lbldeveloper.Location = new System.Drawing.Point(320, 111);
            this.lbldeveloper.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldeveloper.Name = "lbldeveloper";
            this.lbldeveloper.Size = new System.Drawing.Size(13, 19);
            this.lbldeveloper.TabIndex = 36;
            this.lbldeveloper.Text = "-";
            // 
            // lbltitlegame
            // 
            this.lbltitlegame.AutoSize = true;
            this.lbltitlegame.Font = new System.Drawing.Font("Roboto", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitlegame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(124)))), ((int)(((byte)(146)))));
            this.lbltitlegame.Location = new System.Drawing.Point(319, 77);
            this.lbltitlegame.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltitlegame.Name = "lbltitlegame";
            this.lbltitlegame.Size = new System.Drawing.Size(21, 28);
            this.lbltitlegame.TabIndex = 35;
            this.lbltitlegame.Text = "-";
            // 
            // lstgames
            // 
            this.lstgames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.lstgames.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstgames.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstgames.ForeColor = System.Drawing.Color.White;
            this.lstgames.FormattingEnabled = true;
            this.lstgames.ItemHeight = 18;
            this.lstgames.Location = new System.Drawing.Point(15, 77);
            this.lstgames.Name = "lstgames";
            this.lstgames.Size = new System.Drawing.Size(290, 488);
            this.lstgames.TabIndex = 21;
            this.lstgames.SelectedIndexChanged += new System.EventHandler(this.lstgames_SelectedIndexChanged);
            // 
            // cmbTypes
            // 
            this.cmbTypes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.cmbTypes.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTypes.ForeColor = System.Drawing.Color.White;
            this.cmbTypes.FormattingEnabled = true;
            this.cmbTypes.Location = new System.Drawing.Point(184, 43);
            this.cmbTypes.Name = "cmbTypes";
            this.cmbTypes.Size = new System.Drawing.Size(121, 23);
            this.cmbTypes.TabIndex = 34;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(124)))), ((int)(((byte)(146)))));
            this.lblCategory.Location = new System.Drawing.Point(205, 22);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(79, 19);
            this.lblCategory.TabIndex = 33;
            this.lblCategory.Text = "Categoria";
            // 
            // btnSearchGame
            // 
            this.btnSearchGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchGame.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(124)))), ((int)(((byte)(146)))));
            this.btnSearchGame.Image = global::GameHistoryProject.Properties.Resources.search;
            this.btnSearchGame.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchGame.Location = new System.Drawing.Point(314, 37);
            this.btnSearchGame.Name = "btnSearchGame";
            this.btnSearchGame.Size = new System.Drawing.Size(95, 33);
            this.btnSearchGame.TabIndex = 28;
            this.btnSearchGame.Text = "Search";
            this.btnSearchGame.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchGame.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSearchGame.UseVisualStyleBackColor = true;
            this.btnSearchGame.Click += new System.EventHandler(this.btnSearchGame_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.txtsearch.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.ForeColor = System.Drawing.Color.White;
            this.txtsearch.Location = new System.Drawing.Point(15, 43);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(162, 23);
            this.txtsearch.TabIndex = 27;
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(869, 582);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSearch";
            this.Text = "frmSearch";
            this.Load += new System.EventHandler(this.frmSearch_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piccover)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbTypes;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Button btnSearchGame;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.ListBox lstgames;
        private System.Windows.Forms.Label lbldeveloper;
        private System.Windows.Forms.Label lbltitlegame;
        private System.Windows.Forms.Button btnMore;
        private System.Windows.Forms.RichTextBox txtdescription;
        private System.Windows.Forms.PictureBox piccover;
        private System.Windows.Forms.Label lblsearchtitle;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnFavorite;
    }
}