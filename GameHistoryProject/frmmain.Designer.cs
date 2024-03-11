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
            this.lblusernamae = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblstatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblusernamae
            // 
            this.lblusernamae.AutoSize = true;
            this.lblusernamae.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusernamae.Location = new System.Drawing.Point(12, 416);
            this.lblusernamae.Name = "lblusernamae";
            this.lblusernamae.Size = new System.Drawing.Size(117, 25);
            this.lblusernamae.TabIndex = 0;
            this.lblusernamae.Text = "Benvenuto: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(638, 416);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Status:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatus.Location = new System.Drawing.Point(714, 416);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(19, 25);
            this.lblstatus.TabIndex = 2;
            this.lblstatus.Text = "-";
            this.lblstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblusernamae);
            this.Name = "frmmain";
            this.Text = "GameHistoryProject";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmmain_FormClosed);
            this.Load += new System.EventHandler(this.frmmain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblusernamae;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblstatus;
    }
}