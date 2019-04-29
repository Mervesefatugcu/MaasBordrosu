namespace MaasBordrosu
{
    partial class MaasBordrosu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kullanıcıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yetkiliKullanıcıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelMaaşToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPersonelID = new System.Windows.Forms.Label();
            this.lblDönem = new System.Windows.Forms.Label();
            this.txtPersonelID = new System.Windows.Forms.TextBox();
            this.txtDönem = new System.Windows.Forms.TextBox();
            this.dgvMaasBordrosu = new System.Windows.Forms.DataGridView();
            this.btnGöster = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaasBordrosu)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcıToolStripMenuItem,
            this.personelİşlemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(773, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kullanıcıToolStripMenuItem
            // 
            this.kullanıcıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yetkiliKullanıcıToolStripMenuItem});
            this.kullanıcıToolStripMenuItem.Name = "kullanıcıToolStripMenuItem";
            this.kullanıcıToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.kullanıcıToolStripMenuItem.Text = "Kullanıcı";
            // 
            // yetkiliKullanıcıToolStripMenuItem
            // 
            this.yetkiliKullanıcıToolStripMenuItem.Name = "yetkiliKullanıcıToolStripMenuItem";
            this.yetkiliKullanıcıToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.yetkiliKullanıcıToolStripMenuItem.Text = "Yetkili Kullanıcı";
            this.yetkiliKullanıcıToolStripMenuItem.Click += new System.EventHandler(this.yetkiliKullanıcıToolStripMenuItem_Click);
            // 
            // personelİşlemleriToolStripMenuItem
            // 
            this.personelİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelBilgileriToolStripMenuItem,
            this.personelMaaşToolStripMenuItem});
            this.personelİşlemleriToolStripMenuItem.Name = "personelİşlemleriToolStripMenuItem";
            this.personelİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.personelİşlemleriToolStripMenuItem.Text = "Personel İşlemleri";
            // 
            // personelBilgileriToolStripMenuItem
            // 
            this.personelBilgileriToolStripMenuItem.Name = "personelBilgileriToolStripMenuItem";
            this.personelBilgileriToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.personelBilgileriToolStripMenuItem.Text = "Personel Bilgileri";
            this.personelBilgileriToolStripMenuItem.Click += new System.EventHandler(this.personelBilgileriToolStripMenuItem_Click);
            // 
            // personelMaaşToolStripMenuItem
            // 
            this.personelMaaşToolStripMenuItem.Name = "personelMaaşToolStripMenuItem";
            this.personelMaaşToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.personelMaaşToolStripMenuItem.Text = "Personel Maaş";
            this.personelMaaşToolStripMenuItem.Click += new System.EventHandler(this.personelMaaşToolStripMenuItem_Click);
            // 
            // lblPersonelID
            // 
            this.lblPersonelID.AutoSize = true;
            this.lblPersonelID.Location = new System.Drawing.Point(28, 77);
            this.lblPersonelID.Name = "lblPersonelID";
            this.lblPersonelID.Size = new System.Drawing.Size(62, 13);
            this.lblPersonelID.TabIndex = 1;
            this.lblPersonelID.Text = "Personel ID";
            // 
            // lblDönem
            // 
            this.lblDönem.AutoSize = true;
            this.lblDönem.Location = new System.Drawing.Point(224, 73);
            this.lblDönem.Name = "lblDönem";
            this.lblDönem.Size = new System.Drawing.Size(55, 13);
            this.lblDönem.TabIndex = 2;
            this.lblDönem.Text = "Brüt Ücret";
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.Location = new System.Drawing.Point(107, 70);
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.Size = new System.Drawing.Size(100, 20);
            this.txtPersonelID.TabIndex = 3;
            // 
            // txtDönem
            // 
            this.txtDönem.Location = new System.Drawing.Point(285, 70);
            this.txtDönem.Name = "txtDönem";
            this.txtDönem.Size = new System.Drawing.Size(112, 20);
            this.txtDönem.TabIndex = 4;
            // 
            // dgvMaasBordrosu
            // 
            this.dgvMaasBordrosu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaasBordrosu.Location = new System.Drawing.Point(35, 122);
            this.dgvMaasBordrosu.Name = "dgvMaasBordrosu";
            this.dgvMaasBordrosu.Size = new System.Drawing.Size(682, 242);
            this.dgvMaasBordrosu.TabIndex = 5;
            // 
            // btnGöster
            // 
            this.btnGöster.Location = new System.Drawing.Point(429, 68);
            this.btnGöster.Name = "btnGöster";
            this.btnGöster.Size = new System.Drawing.Size(75, 23);
            this.btnGöster.TabIndex = 6;
            this.btnGöster.Text = "Göster";
            this.btnGöster.UseVisualStyleBackColor = true;
            this.btnGöster.Click += new System.EventHandler(this.btnGöster_Click);
            // 
            // MaasBordrosu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 416);
            this.Controls.Add(this.btnGöster);
            this.Controls.Add(this.dgvMaasBordrosu);
            this.Controls.Add(this.txtDönem);
            this.Controls.Add(this.txtPersonelID);
            this.Controls.Add(this.lblDönem);
            this.Controls.Add(this.lblPersonelID);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MaasBordrosu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MaasBordrosu";
            this.Load += new System.EventHandler(this.MaasBordrosu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaasBordrosu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yetkiliKullanıcıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelMaaşToolStripMenuItem;
        private System.Windows.Forms.Label lblPersonelID;
        private System.Windows.Forms.Label lblDönem;
        private System.Windows.Forms.TextBox txtPersonelID;
        private System.Windows.Forms.TextBox txtDönem;
        private System.Windows.Forms.DataGridView dgvMaasBordrosu;
        private System.Windows.Forms.Button btnGöster;
    }
}