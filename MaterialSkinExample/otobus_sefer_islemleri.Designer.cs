namespace MaterialSkinExample
{
    partial class otobus_sefer_islemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(otobus_sefer_islemleri));
            this.gelen_otobus_plaka_label = new System.Windows.Forms.Label();
            this.yenisefer_ekleButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.secilen_otobus_ListView = new MaterialSkin.Controls.MaterialListView();
            this.sefer_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.varis_peron_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kalkis_tarih_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kalkis_saat_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.guzergah_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sofor_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listeyi_yenileButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cikar_ContextMenuStrip = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.cikarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.cikar_ContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // gelen_otobus_plaka_label
            // 
            this.gelen_otobus_plaka_label.AutoSize = true;
            this.gelen_otobus_plaka_label.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gelen_otobus_plaka_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(100)))), ((int)(((byte)(157)))));
            this.gelen_otobus_plaka_label.Location = new System.Drawing.Point(308, 71);
            this.gelen_otobus_plaka_label.Name = "gelen_otobus_plaka_label";
            this.gelen_otobus_plaka_label.Size = new System.Drawing.Size(203, 33);
            this.gelen_otobus_plaka_label.TabIndex = 81;
            this.gelen_otobus_plaka_label.Text = "secilen otobüs plaka";
            // 
            // yenisefer_ekleButton
            // 
            this.yenisefer_ekleButton.AutoSize = true;
            this.yenisefer_ekleButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.yenisefer_ekleButton.Depth = 0;
            this.yenisefer_ekleButton.Icon = global::MaterialSkinExample.resimlerim.plus_icon;
            this.yenisefer_ekleButton.Location = new System.Drawing.Point(256, 262);
            this.yenisefer_ekleButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.yenisefer_ekleButton.Name = "yenisefer_ekleButton";
            this.yenisefer_ekleButton.Primary = true;
            this.yenisefer_ekleButton.Size = new System.Drawing.Size(122, 36);
            this.yenisefer_ekleButton.TabIndex = 84;
            this.yenisefer_ekleButton.Text = "Yeni Sefer";
            this.yenisefer_ekleButton.UseVisualStyleBackColor = true;
            this.yenisefer_ekleButton.Click += new System.EventHandler(this.yenisefer_ekleButton_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::MaterialSkinExample.resimlerim.dolu_tabela;
            this.pictureBox8.Location = new System.Drawing.Point(483, 123);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(122, 136);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 83;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::MaterialSkinExample.resimlerim.dolu_tabela;
            this.pictureBox3.Location = new System.Drawing.Point(146, 120);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(122, 136);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 82;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(271, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 80;
            this.pictureBox1.TabStop = false;
            // 
            // secilen_otobus_ListView
            // 
            this.secilen_otobus_ListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.secilen_otobus_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.sefer_columnHeader,
            this.varis_peron_columnHeader,
            this.kalkis_tarih_columnHeader,
            this.kalkis_saat_columnHeader,
            this.guzergah_columnHeader,
            this.sofor_columnHeader});
            this.secilen_otobus_ListView.Depth = 0;
            this.secilen_otobus_ListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.secilen_otobus_ListView.FullRowSelect = true;
            this.secilen_otobus_ListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.secilen_otobus_ListView.Location = new System.Drawing.Point(24, 332);
            this.secilen_otobus_ListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.secilen_otobus_ListView.MouseState = MaterialSkin.MouseState.OUT;
            this.secilen_otobus_ListView.Name = "secilen_otobus_ListView";
            this.secilen_otobus_ListView.OwnerDraw = true;
            this.secilen_otobus_ListView.Size = new System.Drawing.Size(756, 248);
            this.secilen_otobus_ListView.TabIndex = 85;
            this.secilen_otobus_ListView.UseCompatibleStateImageBehavior = false;
            this.secilen_otobus_ListView.View = System.Windows.Forms.View.Details;
            this.secilen_otobus_ListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.secilen_otobus_ListView_Click_MouseClick);
            // 
            // sefer_columnHeader
            // 
            this.sefer_columnHeader.Text = "Sefer No";
            this.sefer_columnHeader.Width = 104;
            // 
            // varis_peron_columnHeader
            // 
            this.varis_peron_columnHeader.DisplayIndex = 3;
            this.varis_peron_columnHeader.Text = "Varış Peronu";
            this.varis_peron_columnHeader.Width = 120;
            // 
            // kalkis_tarih_columnHeader
            // 
            this.kalkis_tarih_columnHeader.DisplayIndex = 1;
            this.kalkis_tarih_columnHeader.Text = "Kalkış Tarihi";
            this.kalkis_tarih_columnHeader.Width = 105;
            // 
            // kalkis_saat_columnHeader
            // 
            this.kalkis_saat_columnHeader.DisplayIndex = 2;
            this.kalkis_saat_columnHeader.Text = "Kalkış Saati";
            this.kalkis_saat_columnHeader.Width = 126;
            // 
            // guzergah_columnHeader
            // 
            this.guzergah_columnHeader.Text = "Güzergah";
            this.guzergah_columnHeader.Width = 200;
            // 
            // sofor_columnHeader
            // 
            this.sofor_columnHeader.Text = "Şoför";
            this.sofor_columnHeader.Width = 140;
            // 
            // listeyi_yenileButton
            // 
            this.listeyi_yenileButton.AutoSize = true;
            this.listeyi_yenileButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.listeyi_yenileButton.Depth = 0;
            this.listeyi_yenileButton.Icon = global::MaterialSkinExample.resimlerim.update_icon;
            this.listeyi_yenileButton.Location = new System.Drawing.Point(405, 262);
            this.listeyi_yenileButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.listeyi_yenileButton.Name = "listeyi_yenileButton";
            this.listeyi_yenileButton.Primary = true;
            this.listeyi_yenileButton.Size = new System.Drawing.Size(94, 36);
            this.listeyi_yenileButton.TabIndex = 86;
            this.listeyi_yenileButton.Text = "YENİLE";
            this.listeyi_yenileButton.UseVisualStyleBackColor = true;
            this.listeyi_yenileButton.Click += new System.EventHandler(this.listeyi_yenileButton_Click);
            // 
            // cikar_ContextMenuStrip
            // 
            this.cikar_ContextMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cikar_ContextMenuStrip.Depth = 0;
            this.cikar_ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cikarToolStripMenuItem});
            this.cikar_ContextMenuStrip.MouseState = MaterialSkin.MouseState.HOVER;
            this.cikar_ContextMenuStrip.Name = "cikar_ContextMenuStrip";
            this.cikar_ContextMenuStrip.Size = new System.Drawing.Size(153, 48);
            // 
            // cikarToolStripMenuItem
            // 
            this.cikarToolStripMenuItem.Image = global::MaterialSkinExample.resimlerim.cancel;
            this.cikarToolStripMenuItem.Name = "cikarToolStripMenuItem";
            this.cikarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cikarToolStripMenuItem.Text = "Çıkar";
            this.cikarToolStripMenuItem.Click += new System.EventHandler(this.cikarToolStripMenuItem_Click);
            // 
            // otobus_sefer_islemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 592);
            this.Controls.Add(this.listeyi_yenileButton);
            this.Controls.Add(this.secilen_otobus_ListView);
            this.Controls.Add(this.yenisefer_ekleButton);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.gelen_otobus_plaka_label);
            this.Controls.Add(this.pictureBox1);
            this.Name = "otobus_sefer_islemleri";
            this.Text = "secilen otobüs plaka";
            this.Load += new System.EventHandler(this.otobus_sefer_islemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.cikar_ContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialRaisedButton yenisefer_ekleButton;
        public System.Windows.Forms.Label gelen_otobus_plaka_label;
        private MaterialSkin.Controls.MaterialListView secilen_otobus_ListView;
        private System.Windows.Forms.ColumnHeader sefer_columnHeader;
        private System.Windows.Forms.ColumnHeader varis_peron_columnHeader;
        private System.Windows.Forms.ColumnHeader kalkis_tarih_columnHeader;
        private System.Windows.Forms.ColumnHeader kalkis_saat_columnHeader;
        private System.Windows.Forms.ColumnHeader guzergah_columnHeader;
        private System.Windows.Forms.ColumnHeader sofor_columnHeader;
        private MaterialSkin.Controls.MaterialRaisedButton listeyi_yenileButton;
        private MaterialSkin.Controls.MaterialContextMenuStrip cikar_ContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem cikarToolStripMenuItem;
    }
}