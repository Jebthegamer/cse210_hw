namespace Final_Project
{
    public partial class Form1 : Form
    {
        private Menu menu;
        public bool units;
        public Form1()
        {
            menu = new Menu();
            units = true;
            InitializeComponent();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ValueA.Text = "0";
            ValueB.Text = "0";
            ValueC.Text = "0";
            LabelA.Text = "SideA";
            LabelB.Text = "SideB";
            LabelC.Text = "SideC";
            menu.ChangeSelections("SSS");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ValueA.Text = "0";
            ValueB.Text = "0";
            ValueC.Text = "0";
            LabelA.Text = "SideA";
            LabelB.Text = "AngleC";
            LabelC.Text = "SideB";
            menu.ChangeSelections("SAS");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ValueA.Text = "0";
            ValueB.Text = "0";
            ValueC.Text = "0";
            LabelA.Text = "AngleA";
            LabelB.Text = "AngleB";
            LabelC.Text = "SideA";
            menu.ChangeSelections("AAS");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ValueA.Text = "0";
            ValueB.Text = "0";
            ValueC.Text = "0";
            LabelA.Text = "AngleA";
            LabelB.Text = "SideC";
            LabelC.Text = "AngleB";
            menu.ChangeSelections("ASA");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ValueA.Text = "0";
            ValueB.Text = "0";
            ValueC.Text = "0";
            LabelA.Text = "SideA";
            LabelB.Text = "SideB";
            LabelC.Text = "AngleA";
            menu.ChangeSelections("SSA");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (ValueA.Text == "0" || ValueB.Text == "0" || ValueC.Text == "0")
            { }
            else {
            string type = "";
            foreach (Selection selection in menu.Selections)
            {
                if (selection.Status)
                {
                    type = selection.Name;
                }
            }
            if (type == "SSS")
            {
                GeneralTriangle triangle = menu.CreateTriangles();
            }
            }
        }

        private void degrees_Click(object sender, EventArgs e)
        {
            units = true;
            Unit.Text = "Degrees";
        }

        private void radians_Click(object sender, EventArgs e)
        {
            units = false;
            Unit.Text = "Radians";
        }
    }
}