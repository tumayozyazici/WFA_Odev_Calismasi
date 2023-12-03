namespace Mail_Sifre__Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //Mail adresi isminiz@ank10.com þeklinde, þifre de ank10isminiz þeklindeolmalýdýr.

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hosgeldiniz");
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            if (txt_mail.Text == "" || txt_sifre.Text == "")
            {
                MessageBox.Show("Mail veya þifre boþ girilemez.");
            }
            else
            {
                if (Login(txt_mail.Text, txt_sifre.Text) == true)
                {
                    MessageBox.Show("Giriþ yapýldý.");
                }
            }
        }
        private string IsimAl(string mail)
        {
            int index;
            index = mail.IndexOf('@');
            mail = mail.Remove(index);
            return mail;
        }
        private bool Login(string mail, string sifre)
        {
            if (mail == IsimAl(mail) + "@ank10.com" && sifre == ("ank10" + IsimAl(mail)))
            {
                return true;
            }
            MessageBox.Show("Hatalý mail veya þifre giriþi.");
            return false;
        }
    }
}
