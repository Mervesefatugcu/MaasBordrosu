namespace MaasBordrosu
{
    partial class PersonelMaas
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
            this.lblPersonelID = new System.Windows.Forms.Label();
            this.lblDönem = new System.Windows.Forms.Label();
            this.lblBrütUcret = new System.Windows.Forms.Label();
            this.txtPersonelID = new System.Windows.Forms.TextBox();
            this.txtBrütUcret = new System.Windows.Forms.TextBox();
            this.txtDönem = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.dgvMaas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPersonelID
            // 
            this.lblPersonelID.AutoSize = true;
            this.lblPersonelID.Location = new System.Drawing.Point(51, 56);
            this.lblPersonelID.Name = "lblPersonelID";
            this.lblPersonelID.Size = new System.Drawing.Size(62, 13);
            this.lblPersonelID.TabIndex = 0;
            this.lblPersonelID.Text = "Personel ID";
            // 
            // lblDönem
            // 
            this.lblDönem.AutoSize = true;
            this.lblDönem.Location = new System.Drawing.Point(72, 94);
            this.lblDönem.Name = "lblDönem";
            this.lblDönem.Size = new System.Drawing.Size(41, 13);
            this.lblDönem.TabIndex = 1;
            this.lblDönem.Text = "Dönem";
            // 
            // lblBrütUcret
            // 
            this.lblBrütUcret.AutoSize = true;
            this.lblBrütUcret.Location = new System.Drawing.Point(246, 56);
            this.lblBrütUcret.Name = "lblBrütUcret";
            this.lblBrütUcret.Size = new System.Drawing.Size(55, 13);
            this.lblBrütUcret.TabIndex = 2;
            this.lblBrütUcret.Text = "Brüt Ücret";
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.Location = new System.Drawing.Point(128, 49);
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.Size = new System.Drawing.Size(100, 20);
            this.txtPersonelID.TabIndex = 3;
            // 
            // txtBrütUcret
            // 
            this.txtBrütUcret.Location = new System.Drawing.Point(316, 49);
            this.txtBrütUcret.Name = "txtBrütUcret";
            this.txtBrütUcret.Size = new System.Drawing.Size(100, 20);
            this.txtBrütUcret.TabIndex = 4;
            // 
            // txtDönem
            // 
            this.txtDönem.Location = new System.Drawing.Point(128, 87);
            this.txtDönem.Name = "txtDönem";
            this.txtDönem.Size = new System.Drawing.Size(100, 20);
            this.txtDönem.TabIndex = 5;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(153, 113);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            // 
            // dgvMaas
            // 
            this.dgvMaas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaas.Location = new System.Drawing.Point(54, 157);
            this.dgvMaas.Name = "dgvMaas";
            this.dgvMaas.Size = new System.Drawing.Size(396, 202);
            this.dgvMaas.TabIndex = 7;
            // 
            // PersonelMaas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 390);
            this.Controls.Add(this.dgvMaas);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtDönem);
            this.Controls.Add(this.txtBrütUcret);
            this.Controls.Add(this.txtPersonelID);
            this.Controls.Add(this.lblBrütUcret);
            this.Controls.Add(this.lblDönem);
            this.Controls.Add(this.lblPersonelID);
            this.Name = "PersonelMaas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonelMaas";
            this.Load += new System.EventHandler(this.PersonelMaas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPersonelID;
        private System.Windows.Forms.Label lblDönem;
        private System.Windows.Forms.Label lblBrütUcret;
        private System.Windows.Forms.TextBox txtPersonelID;
        private System.Windows.Forms.TextBox txtBrütUcret;
        private System.Windows.Forms.TextBox txtDönem;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DataGridView dgvMaas;
    }
}