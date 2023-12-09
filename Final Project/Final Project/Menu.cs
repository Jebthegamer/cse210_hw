namespace Final_Project
{
    internal class Menu
    {
        public List<Selection> Selections { get; set; }
        public Menu()
        {
            Selection SSS = new Selection("SSS", true);
            Selection SSA = new Selection("SSA", false);
            Selection SAS = new Selection("SAS", false);
            Selection ASA = new Selection("ASA", false);
            Selection AAS = new Selection("AAS", false);
            Selections = new List<Selection>
        {
            SSS, SSA, SAS, ASA, AAS
        };
        }
        public void ChangeSelections(string name)
        {
            // Clear the previous selections; defaulting at SSS
            foreach (Selection selection in Selections)
            {
                selection.Status = false;
            }
            // Set the new selections depending on the input. 
            foreach (Selection selection in Selections)
            {
                if (selection.Name == name)
                    selection.Status = true;
            }
        }
        // Create triangles based on the inputs. SSA triangles are not included as they don't inherit from GeneralTriangle
        public GeneralTriangle CreateTriangle(double SideA, double SideB, double SideC, Angle AngleA, Angle AngleB, Angle AngleC)
        {
            foreach (Selection selection in Selections)
            {
                if (selection.Status)
                {
                    if (selection.Name == "SSS")
                        return new CosinesTriangle(SideA, SideB, SideC, AngleA, AngleB, AngleC, true);
                    else if (selection.Name == "SAS")
                        return new CosinesTriangle(SideA, SideB, SideC, AngleA, AngleB, AngleC, false);
                    else if (selection.Name == "ASA")
                        return new SinesTriangle(SideA, SideB, SideC, AngleA, AngleB, AngleC, false, false, false);
                    else if (selection.Name == "AAS")
                        return new SinesTriangle(SideA, SideB, SideC, AngleA, AngleB, AngleC, true, false, false);
                }
            }
            Angle angle = new Angle(0, true);
            return new SinesTriangle(0, 0, 0, angle, angle, angle, true, true, false);
        }
    }
}