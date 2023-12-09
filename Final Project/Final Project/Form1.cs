using System;
namespace Final_Project
{
    public partial class Form1 : Form
    {
        private Menu menu;
        private bool units;

        public Form1()
        {
            menu = new Menu();
            Displayer displayer = new Displayer();
            units = true;
            InitializeComponent();
        }
        // The next five functions are dedicated to doing visual changes to set up for calculations.
        private void button2_Click_1(object sender, EventArgs e)
        {
            ValueA.Text = "0";
            ValueB.Text = "0";
            ValueC.Text = "0";
            LabelA.Text = "SideA";
            LabelB.Text = "SideB";
            LabelC.Text = "SideC";
            menu.ChangeSelections("SSS");
            FactTxt.Text = "SSS triangles don't have any given angles.";
            FactTxt2.Text = "As such, the law of cosines is used to solve these triangles.";
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
            FactTxt.Text = "SAS triangles are unique among the triangles with given angles.";
            FactTxt2.Text = "Their given angle is between the two sides, so we'll use the law of cosines.";
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
            FactTxt.Text = "AAS triangles are the easiest triangles to solve.";
            FactTxt2.Text = "Two angles allow us to go right into the law of sines.";
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
            FactTxt.Text = "ASA triangles are easy to solve because they have two angles.";
            FactTxt2.Text = "However, we need to solve for the third angle before using law of sines.";
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
            FactTxt.Text = "SSA is 'ambiguous' because having multiple triangles is possible.";
            FactTxt2.Text = "Try entering the values of 2, 3, and 34 degrees to see this in action.";
        }
        // This function will display the results given after taking the inputs from the text boxes.
        private void button7_Click(object sender, EventArgs e)
        {
            if (ValueA.Text == "0" || ValueB.Text == "0" || ValueC.Text == "0")
            { }
            else
            {

                Displayer displayer = new Displayer();
                Angle angle = new Angle(0, true);
                GeneralTriangle triangle;
                string type = "";
                foreach (Selection selection in menu.Selections)
                {
                    if (selection.Status)
                    {
                        type = selection.Name;
                    }
                }
                // Create a triangle of the matching type.
                if (type == "SSS")
                {
                    triangle = menu.CreateTriangle(Convert.ToDouble(ValueA.Text), Convert.ToDouble(ValueB.Text), Convert.ToDouble(ValueC.Text), angle, angle, angle);
                }
                else if (type == "SAS")
                {
                    Angle angle1 = new Angle(Convert.ToDouble(ValueB.Text), units);
                    triangle = menu.CreateTriangle(Convert.ToDouble(ValueA.Text), Convert.ToDouble(ValueC.Text), 0, angle, angle, angle1);
                }
                else if (type == "AAS")
                {
                    Angle angle1 = new Angle(Convert.ToDouble(ValueA.Text), units);
                    Angle angle2 = new Angle(Convert.ToDouble(ValueB.Text), units);
                    triangle = menu.CreateTriangle(Convert.ToDouble(ValueC.Text), 0, 0, angle1, angle2, angle);
                }
                else if (type == "ASA")
                {
                    Angle angle1 = new Angle(Convert.ToDouble(ValueA.Text), units);
                    Angle angle2 = new Angle(Convert.ToDouble(ValueC.Text), units);
                    triangle = menu.CreateTriangle(0, 0, Convert.ToDouble(ValueB.Text), angle1, angle2, angle);
                }
                // Unfortunately, SSA doesn't play nicely with the other triangles, meaning that it did have to become a separate type.
                else if (type == "SSA")
                {
                    Angle angle1 = new Angle(Convert.ToDouble(ValueC.Text), units);
                    SSATriangle TriangleSSA = new SSATriangle(Convert.ToDouble(ValueA.Text), Convert.ToDouble(ValueB.Text), 0, angle1, angle, angle);
                    displayer.DisplayTriangle(TriangleSSA, LabelSideA, LabelSideB, LabelSideC, LabelAngleA, LabelAngleB, LabelAngleC, LabelAngleB2, LabelAngleC2, LabelSideC2, units);
                    triangle = new SinesTriangle(0, 0, 0, angle, angle, angle, true, false, false);
                }
                else
                {
                    triangle = new SinesTriangle(0, 0, 0, angle, angle, angle, true, false, false);
                }
                if (type != "SSA")
                {
                    displayer.DisplayTriangle(triangle, LabelSideA, LabelSideB, LabelSideC, LabelAngleA, LabelAngleB, LabelAngleC, LabelAngleB2, LabelAngleC2, LabelSideC2, units);
                }
            }

        }
        // These two functions allow for the conversion between angles and degrees as the input unit.
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