namespace Sifre_Zorlugu
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
            txt_sifre = new TextBox();
            lbl_zorluk = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 114);
            label1.Name = "label1";
            label1.Size = new Size(149, 20);
            label1.TabIndex = 0;
            label1.Text = "Şifre Zorluk Derecesi:";
            // 
            // txt_sifre
            // 
            txt_sifre.Location = new Point(43, 31);
            txt_sifre.Name = "txt_sifre";
            txt_sifre.Size = new Size(402, 27);
            txt_sifre.TabIndex = 1;
            txt_sifre.TextChanged += txt_sifre_TextChanged;
            // 
            // lbl_zorluk
            // 
            lbl_zorluk.AutoSize = true;
            lbl_zorluk.ForeColor = Color.Red;
            lbl_zorluk.Location = new Point(270, 114);
            lbl_zorluk.Name = "lbl_zorluk";
            lbl_zorluk.Size = new Size(0, 20);
            lbl_zorluk.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 187);
            Controls.Add(txt_sifre);
            Controls.Add(lbl_zorluk);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Şifre Zorluk Derecesi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_sifre;
        private Label lbl_zorluk;
    }
}
