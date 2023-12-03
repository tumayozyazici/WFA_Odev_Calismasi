namespace Mail_Sifre__Login
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txt_mail = new TextBox();
            btn_giris = new Button();
            label2 = new Label();
            txt_sifre = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 0;
            label1.Text = "Mail Adresi:";
            // 
            // txt_mail
            // 
            txt_mail.Location = new Point(115, 25);
            txt_mail.Name = "txt_mail";
            txt_mail.Size = new Size(320, 27);
            txt_mail.TabIndex = 1;
            // 
            // btn_giris
            // 
            btn_giris.Location = new Point(12, 150);
            btn_giris.Name = "btn_giris";
            btn_giris.Size = new Size(423, 71);
            btn_giris.TabIndex = 3;
            btn_giris.Text = "Giriş Yap";
            btn_giris.UseVisualStyleBackColor = true;
            btn_giris.Click += btn_giris_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 94);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 0;
            label2.Text = "Şifre:";
            // 
            // txt_sifre
            // 
            txt_sifre.Location = new Point(115, 91);
            txt_sifre.Name = "txt_sifre";
            txt_sifre.Size = new Size(320, 27);
            txt_sifre.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 269);
            Controls.Add(btn_giris);
            Controls.Add(txt_sifre);
            Controls.Add(label2);
            Controls.Add(txt_mail);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Bilgi Girişi";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_mail;
        private Button btn_giris;
        private Label label2;
        private TextBox txt_sifre;
    }
}
