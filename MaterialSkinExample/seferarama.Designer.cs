namespace MaterialSkinExample
{
    partial class seferarama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(seferarama));
            this.tum_seferler_ListView = new MaterialSkin.Controls.MaterialListView();
            this.sefer_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.varis_peron_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kalkis_tarih_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kalkis_saat_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.guzergah_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.plaka_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sofor_columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tarih_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tarih_label = new System.Windows.Forms.Label();
            this.guzergah_label = new System.Windows.Forms.Label();
            this.guzergah_comboBox = new System.Windows.Forms.ComboBox();
            this.herseyi_temizleButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cikar_ContextMenuStrip = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.cikarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.cikar_ContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tum_seferler_ListView
            // 
            this.tum_seferler_ListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tum_seferler_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.sefer_columnHeader,
            this.varis_peron_columnHeader,
            this.kalkis_tarih_columnHeader,
            this.kalkis_saat_columnHeader,
            this.guzergah_columnHeader,
            this.plaka_columnHeader,
            this.sofor_columnHeader});
            this.tum_seferler_ListView.Depth = 0;
            this.tum_seferler_ListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.tum_seferler_ListView.FullRowSelect = true;
            this.tum_seferler_ListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.tum_seferler_ListView.Location = new System.Drawing.Point(17, 286);
            this.tum_seferler_ListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.tum_seferler_ListView.MouseState = MaterialSkin.MouseState.OUT;
            this.tum_seferler_ListView.Name = "tum_seferler_ListView";
            this.tum_seferler_ListView.OwnerDraw = true;
            this.tum_seferler_ListView.Size = new System.Drawing.Size(756, 277);
            this.tum_seferler_ListView.TabIndex = 92;
            this.tum_seferler_ListView.UseCompatibleStateImageBehavior = false;
            this.tum_seferler_ListView.View = System.Windows.Forms.View.Details;
            this.tum_seferler_ListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tum_seferler_ListView_Click_MouseClick);
            // 
            // sefer_columnHeader
            // 
            this.sefer_columnHeader.Text = "Sefer No";
            this.sefer_columnHeader.Width = 90;
            // 
            // varis_peron_columnHeader
            // 
            this.varis_peron_columnHeader.DisplayIndex = 3;
            this.varis_peron_columnHeader.Text = "Varış Peronu";
            this.varis_peron_columnHeader.Width = 110;
            // 
            // kalkis_tarih_columnHeader
            // 
            this.kalkis_tarih_columnHeader.DisplayIndex = 1;
            this.kalkis_tarih_columnHeader.Text = "Kalkış Tarihi";
            this.kalkis_tarih_columnHeader.Width = 120;
            // 
            // kalkis_saat_columnHeader
            // 
            this.kalkis_saat_columnHeader.DisplayIndex = 2;
            this.kalkis_saat_columnHeader.Text = "Kalkış Saati";
            this.kalkis_saat_columnHeader.Width = 120;
            // 
            // guzergah_columnHeader
            // 
            this.guzergah_columnHeader.Text = "Güzergah";
            this.guzergah_columnHeader.Width = 230;
            // 
            // plaka_columnHeader
            // 
            this.plaka_columnHeader.DisplayIndex = 6;
            this.plaka_columnHeader.Text = "Plaka";
            this.plaka_columnHeader.Width = 130;
            // 
            // sofor_columnHeader
            // 
            this.sofor_columnHeader.DisplayIndex = 5;
            this.sofor_columnHeader.Text = "Şoför";
            this.sofor_columnHeader.Width = 140;
            // 
            // tarih_dateTimePicker
            // 
            this.tarih_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tarih_dateTimePicker.Location = new System.Drawing.Point(304, 218);
            this.tarih_dateTimePicker.Name = "tarih_dateTimePicker";
            this.tarih_dateTimePicker.Size = new System.Drawing.Size(154, 20);
            this.tarih_dateTimePicker.TabIndex = 95;
            this.tarih_dateTimePicker.ValueChanged += new System.EventHandler(this.tarih_dateTimePicker_ValueChanged);
            // 
            // tarih_label
            // 
            this.tarih_label.AutoSize = true;
            this.tarih_label.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tarih_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(100)))), ((int)(((byte)(157)))));
            this.tarih_label.Location = new System.Drawing.Point(236, 216);
            this.tarih_label.Name = "tarih_label";
            this.tarih_label.Size = new System.Drawing.Size(57, 25);
            this.tarih_label.TabIndex = 94;
            this.tarih_label.Text = "Tarih:";
            // 
            // guzergah_label
            // 
            this.guzergah_label.AutoSize = true;
            this.guzergah_label.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guzergah_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(100)))), ((int)(((byte)(157)))));
            this.guzergah_label.Location = new System.Drawing.Point(205, 254);
            this.guzergah_label.Name = "guzergah_label";
            this.guzergah_label.Size = new System.Drawing.Size(88, 25);
            this.guzergah_label.TabIndex = 96;
            this.guzergah_label.Text = "Güzergah:";
            // 
            // guzergah_comboBox
            // 
            this.guzergah_comboBox.FormattingEnabled = true;
            this.guzergah_comboBox.Items.AddRange(new object[] {
            "İstanbul-Tekirdağ",
            "İstanbul-Tekirdağ-Kırklareli",
            "İstanbul-Demirköy-İğneada",
            "İstanbul-Çerkezköy-Kapakli-Saray",
            "İstanbul-Lüleburgaz-Pınarhisar"});
            this.guzergah_comboBox.Location = new System.Drawing.Point(304, 259);
            this.guzergah_comboBox.Name = "guzergah_comboBox";
            this.guzergah_comboBox.Size = new System.Drawing.Size(154, 21);
            this.guzergah_comboBox.TabIndex = 97;
            this.guzergah_comboBox.SelectedIndexChanged += new System.EventHandler(this.guzergah_comboBox_SelectedIndexChanged);
            // 
            // herseyi_temizleButton
            // 
            this.herseyi_temizleButton.AutoSize = true;
            this.herseyi_temizleButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.herseyi_temizleButton.Depth = 0;
            this.herseyi_temizleButton.Icon = global::MaterialSkinExample.resimlerim.clear_icon;
            this.herseyi_temizleButton.Location = new System.Drawing.Point(480, 218);
            this.herseyi_temizleButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.herseyi_temizleButton.Name = "herseyi_temizleButton";
            this.herseyi_temizleButton.Primary = true;
            this.herseyi_temizleButton.Size = new System.Drawing.Size(104, 36);
            this.herseyi_temizleButton.TabIndex = 93;
            this.herseyi_temizleButton.Text = "TEMİZLE";
            this.herseyi_temizleButton.UseVisualStyleBackColor = true;
            this.herseyi_temizleButton.Click += new System.EventHandler(this.herseyi_temizleButton_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox8.Image = global::MaterialSkinExample.resimlerim.dolu_tabela;
            this.pictureBox8.Location = new System.Drawing.Point(494, 73);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(122, 136);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 90;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox3.Image = global::MaterialSkinExample.resimlerim.dolu_tabela;
            this.pictureBox3.Location = new System.Drawing.Point(157, 70);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(122, 136);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 89;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(282, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 87;
            this.pictureBox1.TabStop = false;
            // 
            // cikar_ContextMenuStrip
            // 
            this.cikar_ContextMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cikar_ContextMenuStrip.Depth = 0;
            this.cikar_ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cikarToolStripMenuItem});
            this.cikar_ContextMenuStrip.MouseState = MaterialSkin.MouseState.HOVER;
            this.cikar_ContextMenuStrip.Name = "cikar_ContextMenuStrip";
            this.cikar_ContextMenuStrip.Size = new System.Drawing.Size(102, 26);
            // 
            // cikarToolStripMenuItem
            // 
            this.cikarToolStripMenuItem.Image = global::MaterialSkinExample.resimlerim.cancel;
            this.cikarToolStripMenuItem.Name = "cikarToolStripMenuItem";
            this.cikarToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.cikarToolStripMenuItem.Text = "Çıkar";
            this.cikarToolStripMenuItem.Click += new System.EventHandler(this.cikarToolStripMenuItem_Click);
            // 
            // seferarama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 575);
            this.Controls.Add(this.guzergah_comboBox);
            this.Controls.Add(this.guzergah_label);
            this.Controls.Add(this.tarih_dateTimePicker);
            this.Controls.Add(this.tarih_label);
            this.Controls.Add(this.herseyi_temizleButton);
            this.Controls.Add(this.tum_seferler_ListView);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Name = "seferarama";
            this.Text = "Tüm Seferler Listesi";
            this.Load += new System.EventHandler(this.seferarama_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tum_seferler_ListView_Click_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.cikar_ContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton herseyi_temizleButton;
        private MaterialSkin.Controls.MaterialListView tum_seferler_ListView;
        private System.Windows.Forms.ColumnHeader sefer_columnHeader;
        private System.Windows.Forms.ColumnHeader varis_peron_columnHeader;
        private System.Windows.Forms.ColumnHeader kalkis_tarih_columnHeader;
        private System.Windows.Forms.ColumnHeader kalkis_saat_columnHeader;
        private System.Windows.Forms.ColumnHeader guzergah_columnHeader;
        private System.Windows.Forms.ColumnHeader plaka_columnHeader;
        private System.Windows.Forms.ColumnHeader sofor_columnHeader;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker tarih_dateTimePicker;
        public System.Windows.Forms.Label tarih_label;
        public System.Windows.Forms.Label guzergah_label;
        private System.Windows.Forms.ComboBox guzergah_comboBox;
        private MaterialSkin.Controls.MaterialContextMenuStrip cikar_ContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem cikarToolStripMenuItem;
    }
}