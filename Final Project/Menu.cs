using System;

public class Menu
{
    public List<Selection> Selections { get; set; }
    public Menu()
    {
        Selection SSS = new Selection("SSS", false);
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
    // Create triangles based on the inputs.
    public GeneralTriangle CreateTriangles(double SideA, Angle AngleB, double SideC, Angle AngleA, double SideB, Angle AngleC)
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
                    return new SinesTriangle(SideA, SideB, SideC, AngleA, AngleB, AngleC, false, false);
                else if (selection.Name == "AAS")
                    return new SinesTriangle(SideA, SideB, SideC, AngleA, AngleB, AngleC, true, false);
                else if (selection.Name == "SSA")
                    return new SSA(SideA, SideB, SideC, AngleA, AngleB, AngleC);
            }
        }
        
    }
}
