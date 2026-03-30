/* Ashton Tolman
 * Spring 2026
 * DinerMenu
 * https://github.com/Ashton-Tolman/DinerMenu.git
 */


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
            SoupButton.Select();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Displays Soup special
        private void SoupButton_Click(object sender, EventArgs e)
        {
            DinerSpecialsLabel.Text = "~Todays Special Soup~"+
                "\n The Oil Bath" +
                "\n A finely simmered oil broth served with " +
                "\nfuses, transistors, and small IC's";
        }

        //Displays Salad special
        private void SaladButton_Click(object sender, EventArgs e)
        {
            DinerSpecialsLabel.Text = "~Todays Special Salad~" +
                "\nSolder sticks served over a bed of broken PCBs'" +
                "\nwith bolts and servos on top";
        }

        //Displays Fish special
        private void FishButton_Click(object sender, EventArgs e)
        {
            DinerSpecialsLabel.Text = "~Todays Special Fish~" +
                "\nRoboCops own creation after hours of designing" +
                "\na finely tuned RC fish that can swim in water" +
                "\n" +
                "\n~Desert Option~" +
                "\nA leg";
        }
    }
}
