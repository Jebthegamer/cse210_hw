namespace Final_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Menu menu = new Menu();
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ValueA.Text = "0";
            ValueB.Text = "0";
            ValueC.Text = "0";
            LabelA.Text = "SideA";
            LabelB.Text = "SideB";
            LabelC.Text = "SideC";
            menu.ChangeSelection("SSS");
        }
    }
}