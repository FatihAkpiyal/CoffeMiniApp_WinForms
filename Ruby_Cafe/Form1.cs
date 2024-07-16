namespace Ruby_Cafe
{
    public partial class Form1 : Form
    {

        int money = 100;
        int beer = 3;
        int hamburger = 5;
        int coffe = 2;


        int TotalPrice = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            moneyLabel.Text = money.ToString() + "$";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            TotalPrice += beer;
            cardListBox.Items.Add($"- Beer {beer}$");

        }

        private void hamburgerPictureBox_Click(object sender, EventArgs e)
        {
            TotalPrice += hamburger;
            cardListBox.Items.Add($"- Hamburger {hamburger}$");
        }

        private void coffePictureBox_Click(object sender, EventArgs e)
        {
            TotalPrice += coffe;
            cardListBox.Items.Add($"- Coffe {coffe}$");
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            if (TotalPrice <= 1000)
            {
                money = money - TotalPrice;

                moneyLabel.Text = money.ToString() + "$";

                MessageBox.Show("Thank you for shopping from us!");
            }
            else
            {
                MessageBox.Show("Insuficcient Funds");
            }
        }
    }
}
