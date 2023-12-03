namespace Ders_Ekle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            DersEkle(txt_ders.Text);
        }

        private void DersEkle(string ders)
        {
            if (txt_ders.Text == "")
            {
                MessageBox.Show("Ders giriþ alaný boþ geçilemez.");
            }
            else
            {
                lst_ders.Items.Add(ders);
                cmb_ders.Items.Add(ders);
            }
        }

        private void lst_ders_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dersAdi = lst_ders.SelectedItem.ToString();
            MessageBox.Show($"List Box'tan seçilen dersin adý {dersAdi}.");
        }

        private void cmb_ders_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dersAdi = cmb_ders.SelectedItem.ToString();
            MessageBox.Show($"Combo Box'tan seçilen dersin adý {dersAdi}.");
        }

        private void btn_secme_Click(object sender, EventArgs e)
        {
            lst_ders.Items.Clear();
            cmb_ders.Items.Clear();
        }
    }
}
