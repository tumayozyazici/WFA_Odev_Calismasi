namespace Sifre_Zorlugu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            /*
             •Şifre 6veya daha azkarakterise ➔düşük
            •Sadece rakamlardan oluşuyorsa veya sadece harflerden oluşuyorsa ➔düşük
            •Şifre 7 karakter, hem rakamlardan hem de harflerden oluşuyorsa ➔orta
            •Şifre enaz 8 karakter ise, hem rakamlardan, hem deharflerdenoluşuyorsa ➔yüksek
            •Düşük seviye kırmızı, orta seviye turuncu, yüksek seviye de yeşil renkte yazılmalıdır.
            NOT: Zorlukderecesinin belirlenmesi textbox’ın “TextChanged”olayında yapılmalıdır.
             */
            InitializeComponent();
        }
        public string Seviye(string sifre)
        {
            int uzunluk = sifre.Length;
            if (uzunluk <= 6)
            {
                return "Düşük";
            }

            bool harfChk = false;
            bool sayiChk = false;
            for (int i = 0; i < sifre.Length; i++)
            {
                char x = Convert.ToChar(sifre.Substring(i, 1));
                if (char.IsLetter(x))
                {
                    harfChk = true;
                }
                else if (char.IsDigit(x))
                {
                    sayiChk = true;
                }
            }

            if (harfChk == true && sayiChk == true && uzunluk > 7)
            {
                return "Yüksek";
            }
            else if (harfChk == true && sayiChk == true && uzunluk == 7)
            {
                return "Orta";
            }
            else if (harfChk == true && sayiChk == false || harfChk == false && sayiChk == true)
            {
                return "Düşük";
            }
            else
            {
                return "Düşük";
            }
        }
        private void txt_sifre_TextChanged(object sender, EventArgs e)
        {
            lbl_zorluk.Text = Seviye(txt_sifre.Text);
            if (Seviye(txt_sifre.Text) == "Yüksek")
            {
                lbl_zorluk.ForeColor = Color.Green;
            }
            else if (Seviye(txt_sifre.Text) == "Orta")
            {
                lbl_zorluk.ForeColor = Color.Orange;
            }
            else if (Seviye(txt_sifre.Text) == "Düşük")
            {
                lbl_zorluk.ForeColor= Color.Red;
            }
        }
    }
}
