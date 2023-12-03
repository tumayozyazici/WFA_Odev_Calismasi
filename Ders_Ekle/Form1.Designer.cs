namespace Ders_Ekle
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
            txt_ders = new TextBox();
            btn_ekle = new Button();
            cmb_ders = new ComboBox();
            lst_ders = new ListBox();
            btn_secme = new Button();
            SuspendLayout();
            // 
            // txt_ders
            // 
            txt_ders.Location = new Point(12, 12);
            txt_ders.Name = "txt_ders";
            txt_ders.PlaceholderText = "Ders Adı: ";
            txt_ders.Size = new Size(223, 27);
            txt_ders.TabIndex = 1;
            // 
            // btn_ekle
            // 
            btn_ekle.Location = new Point(263, 6);
            btn_ekle.Name = "btn_ekle";
            btn_ekle.Size = new Size(175, 39);
            btn_ekle.TabIndex = 2;
            btn_ekle.Text = "EKLE";
            btn_ekle.UseVisualStyleBackColor = true;
            btn_ekle.Click += btn_ekle_Click;
            // 
            // cmb_ders
            // 
            cmb_ders.FormattingEnabled = true;
            cmb_ders.Location = new Point(12, 56);
            cmb_ders.Name = "cmb_ders";
            cmb_ders.Size = new Size(426, 28);
            cmb_ders.TabIndex = 3;
            cmb_ders.SelectedIndexChanged += cmb_ders_SelectedIndexChanged;
            // 
            // lst_ders
            // 
            lst_ders.FormattingEnabled = true;
            lst_ders.ItemHeight = 20;
            lst_ders.Location = new Point(12, 90);
            lst_ders.Name = "lst_ders";
            lst_ders.Size = new Size(426, 344);
            lst_ders.TabIndex = 4;
            lst_ders.SelectedIndexChanged += lst_ders_SelectedIndexChanged;
            // 
            // btn_secme
            // 
            btn_secme.Location = new Point(12, 452);
            btn_secme.Name = "btn_secme";
            btn_secme.Size = new Size(427, 58);
            btn_secme.TabIndex = 5;
            btn_secme.Text = "HİÇ BİRŞEY SEÇME";
            btn_secme.UseVisualStyleBackColor = true;
            btn_secme.Click += btn_secme_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 518);
            Controls.Add(btn_secme);
            Controls.Add(lst_ders);
            Controls.Add(cmb_ders);
            Controls.Add(btn_ekle);
            Controls.Add(txt_ders);
            Name = "Form1";
            Text = "Ders Ekleme";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_ders;
        private Button btn_ekle;
        private ComboBox cmb_ders;
        private ListBox lst_ders;
        private Button btn_secme;
    }
}
