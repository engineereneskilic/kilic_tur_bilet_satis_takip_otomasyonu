﻿namespace MaterialSkinExample
{
    partial class giris
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
            this.guvenlik_label = new System.Windows.Forms.Label();
            this.guvenlik_textbox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.guvenlik_kodu_label = new System.Windows.Forms.Label();
            this.giris_button = new MaterialSkin.Controls.MaterialRaisedButton();
            this.sifre_textbox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.kullanici_adi_textbox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.kullanici_adi_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guvenlik_label
            // 
            this.guvenlik_label.AutoSize = true;
            this.guvenlik_label.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guvenlik_label.ForeColor = System.Drawing.Color.Black;
            this.guvenlik_label.Location = new System.Drawing.Point(227, 430);
            this.guvenlik_label.Name = "guvenlik_label";
            this.guvenlik_label.Size = new System.Drawing.Size(74, 22);
            this.guvenlik_label.TabIndex = 30;
            this.guvenlik_label.Text = "79643089";
            // 
            // guvenlik_textbox
            // 
            this.guvenlik_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guvenlik_textbox.Depth = 0;
            this.guvenlik_textbox.Hint = "";
            this.guvenlik_textbox.Location = new System.Drawing.Point(138, 429);
            this.guvenlik_textbox.MaxLength = 32767;
            this.guvenlik_textbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.guvenlik_textbox.Name = "guvenlik_textbox";
            this.guvenlik_textbox.PasswordChar = '\0';
            this.guvenlik_textbox.SelectedText = "";
            this.guvenlik_textbox.SelectionLength = 0;
            this.guvenlik_textbox.SelectionStart = 0;
            this.guvenlik_textbox.Size = new System.Drawing.Size(109, 23);
            this.guvenlik_textbox.TabIndex = 25;
            this.guvenlik_textbox.TabStop = false;
            this.guvenlik_textbox.UseSystemPasswordChar = false;
            // 
            // guvenlik_kodu_label
            // 
            this.guvenlik_kodu_label.AutoSize = true;
            this.guvenlik_kodu_label.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guvenlik_kodu_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(100)))), ((int)(((byte)(157)))));
            this.guvenlik_kodu_label.Location = new System.Drawing.Point(12, 430);
            this.guvenlik_kodu_label.Name = "guvenlik_kodu_label";
            this.guvenlik_kodu_label.Size = new System.Drawing.Size(120, 22);
            this.guvenlik_kodu_label.TabIndex = 29;
            this.guvenlik_kodu_label.Text = "Güvenlik Kodu:";
            // 
            // giris_button
            // 
            this.giris_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.giris_button.AutoSize = true;
            this.giris_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.giris_button.Depth = 0;
            this.giris_button.ForeColor = System.Drawing.Color.DarkRed;
            this.giris_button.Icon = null;
            this.giris_button.Location = new System.Drawing.Point(246, 468);
            this.giris_button.MouseState = MaterialSkin.MouseState.HOVER;
            this.giris_button.Name = "giris_button";
            this.giris_button.Primary = true;
            this.giris_button.Size = new System.Drawing.Size(55, 36);
            this.giris_button.TabIndex = 28;
            this.giris_button.Text = "Giriş";
            this.giris_button.UseVisualStyleBackColor = false;
            this.giris_button.Click += new System.EventHandler(this.giris_button_Click);
            // 
            // sifre_textbox
            // 
            this.sifre_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sifre_textbox.Depth = 0;
            this.sifre_textbox.Hint = "Şifre";
            this.sifre_textbox.Location = new System.Drawing.Point(138, 397);
            this.sifre_textbox.MaxLength = 32767;
            this.sifre_textbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.sifre_textbox.Name = "sifre_textbox";
            this.sifre_textbox.PasswordChar = '*';
            this.sifre_textbox.SelectedText = "";
            this.sifre_textbox.SelectionLength = 0;
            this.sifre_textbox.SelectionStart = 0;
            this.sifre_textbox.Size = new System.Drawing.Size(163, 23);
            this.sifre_textbox.TabIndex = 24;
            this.sifre_textbox.TabStop = false;
            this.sifre_textbox.UseSystemPasswordChar = true;
            // 
            // kullanici_adi_textbox
            // 
            this.kullanici_adi_textbox.Depth = 0;
            this.kullanici_adi_textbox.Hint = "Kullanıcı Adı";
            this.kullanici_adi_textbox.Location = new System.Drawing.Point(138, 368);
            this.kullanici_adi_textbox.MaxLength = 32767;
            this.kullanici_adi_textbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.kullanici_adi_textbox.Name = "kullanici_adi_textbox";
            this.kullanici_adi_textbox.PasswordChar = '\0';
            this.kullanici_adi_textbox.SelectedText = "";
            this.kullanici_adi_textbox.SelectionLength = 0;
            this.kullanici_adi_textbox.SelectionStart = 0;
            this.kullanici_adi_textbox.Size = new System.Drawing.Size(163, 23);
            this.kullanici_adi_textbox.TabIndex = 23;
            this.kullanici_adi_textbox.TabStop = false;
            this.kullanici_adi_textbox.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(100)))), ((int)(((byte)(157)))));
            this.label1.Location = new System.Drawing.Point(85, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 22);
            this.label1.TabIndex = 27;
            this.label1.Text = "Şifre:";
            // 
            // kullanici_adi_label
            // 
            this.kullanici_adi_label.AutoSize = true;
            this.kullanici_adi_label.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullanici_adi_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(100)))), ((int)(((byte)(157)))));
            this.kullanici_adi_label.Location = new System.Drawing.Point(22, 369);
            this.kullanici_adi_label.Name = "kullanici_adi_label";
            this.kullanici_adi_label.Size = new System.Drawing.Size(110, 22);
            this.kullanici_adi_label.TabIndex = 26;
            this.kullanici_adi_label.Text = "Kullanıcı Adı:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MaterialSkinExample.resimlerim.logo_icon;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(42, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 302);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 513);
            this.Controls.Add(this.guvenlik_label);
            this.Controls.Add(this.guvenlik_textbox);
            this.Controls.Add(this.guvenlik_kodu_label);
            this.Controls.Add(this.giris_button);
            this.Controls.Add(this.sifre_textbox);
            this.Controls.Add(this.kullanici_adi_textbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kullanici_adi_label);
            this.Controls.Add(this.pictureBox1);
            this.Name = "giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "giris";
            this.Load += new System.EventHandler(this.giris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label guvenlik_label;
        private MaterialSkin.Controls.MaterialSingleLineTextField guvenlik_textbox;
        private System.Windows.Forms.Label guvenlik_kodu_label;
        private MaterialSkin.Controls.MaterialRaisedButton giris_button;
        private MaterialSkin.Controls.MaterialSingleLineTextField sifre_textbox;
        private MaterialSkin.Controls.MaterialSingleLineTextField kullanici_adi_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label kullanici_adi_label;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}