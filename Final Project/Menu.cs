using System;

public class Menu
{
    public List<Selection> Selections { get; set; }
    public Menu()
    {
        Selection SideA = new Selection("SideA", false);
        Selection SideB = new Selection("SideB", false);
        Selection SideC = new Selection("SideC", false);
        Selection AngleA = new Selection("AngleA", false);
        Selection AngleB = new Selection("AngleB", false);
        Selection AngleC = new Selection("AngleC", false);
    Selections = new List<Selection>
        {
            SideA, AngleC, SideB, AngleA, SideC, AngleB
        };
    }
    public void ChangeSelections(List<string> names)
    {
        // Clear the previous selections; defaulting at SSS
        foreach (Selection selection in Selections)
        {
            selection.Status = false;
        }
        // Set the new selections depending on the three inputs. 
        foreach (string name in names)
        {
            foreach (Selection selection in Selections)
            {
                if (selection.Name == name)
                    selection.Status = true;
            }
        }
    }
    // Create triangles based on the inputs.
    public void CreateTriangles()
    {
        List<bool> choices = new List<bool>();
        
    }
}
