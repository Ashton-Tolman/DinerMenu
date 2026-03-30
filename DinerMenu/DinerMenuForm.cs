


namespace DinerMenu
{
    public partial class DinerMenuForm : Form
    {
        public DinerMenuForm()

        //Defalut Methods------------------------------------------------------
        {
            InitializeComponent();
            SetDefaults();
        }

        //Custom Methods-------------------------------------------------------
        private void SetDefaults()
        {
            DinerSpecialsLabel.Text = "";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SoupButton_Click(object sender, EventArgs e)
        {
            DinerSpecialsLabel.Text = "Soup";
        }

        private void SaladButton_Click(object sender, EventArgs e)
        {
            DinerSpecialsLabel.Text = "Salad";
        }

        private void FishButton_Click(object sender, EventArgs e)
        {
            DinerSpecialsLabel.Text = "Fish";
        }
    }
}
