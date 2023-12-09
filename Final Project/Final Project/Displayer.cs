using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{ 
    // Unfortunately, I couldn't make SSA a GeneralTriangle. Therefore, I needed to overload DisplayTriangle. Both have effectively the same function.
    internal class Displayer
    {
        public Displayer() { }
        
        // Input the triangle and the labels.
        public void DisplayTriangle(GeneralTriangle triangle, Label SideA, Label SideB, Label SideC, Label AngleA, Label AngleB, Label AngleC, Label AngleB2, Label AngleC2, Label SideC2, bool unit)
        {
            // If it's real, check. Then, set the outputs to be correct.
            if (triangle.IsReal)
            {
                SideA.Text = Math.Round(triangle.SideA, 3).ToString();
                SideB.Text = Math.Round(triangle.SideB, 3).ToString();
                SideC.Text = Math.Round(triangle.SideC, 3).ToString();
                if (unit)
                {
                    AngleA.Text = Math.Round(triangle.AngleA.Degrees, 3).ToString();
                    AngleB.Text = Math.Round(triangle.AngleB.Degrees, 3).ToString();
                    AngleC.Text = Math.Round(triangle.AngleC.Degrees, 3).ToString();
                }
                else
                {
                    AngleA.Text = Math.Round(triangle.AngleA.Radians, 3).ToString();
                    AngleB.Text = Math.Round(triangle.AngleB.Radians, 3).ToString();
                    AngleC.Text = Math.Round(triangle.AngleC.Radians, 3).ToString();
                }
            }
            // If it's not real, clear the outputs as invalid.
            else
            {
                List<Label> labels = new List<Label>
                {
                    SideA, SideB, SideC, AngleA, AngleB, AngleC
                };
                foreach (Label label in labels)
                {
                    label.Text = "Invalid input";
                }
            }
            // Regardless, these values need to be set to 'No value'
            AngleB2.Text = "No value";
            AngleC2.Text = "No value";
            SideC2.Text = "No value";
        }
        // This is the overload which also uses AngleB2, AngleC2, and SideC2 if needed. Otherwise, it's identical.
        public void DisplayTriangle(SSATriangle SSA, Label SideA, Label SideB, Label SideC, Label AngleA, Label AngleB, Label AngleC, Label AngleB2, Label AngleC2, Label SideC2, bool unit)
        {
            if (SSA.Triangles[0].IsReal)
            {
                SideA.Text = Math.Round(SSA.Triangles[0].SideA, 3).ToString();
                SideB.Text = Math.Round(SSA.Triangles[0].SideB, 3).ToString();
                SideC.Text = Math.Round(SSA.Triangles[0].SideC, 3).ToString();
               if (unit)
               {
                    AngleA.Text = Math.Round(SSA.Triangles[0].AngleA.Degrees, 3).ToString();
                    AngleB.Text = Math.Round(SSA.Triangles[0].AngleB.Degrees, 3).ToString();
                    AngleC.Text = Math.Round(SSA.Triangles[0].AngleC.Degrees, 3).ToString();
                }
                    else
                {
                    AngleA.Text = Math.Round(SSA.Triangles[0].AngleA.Radians, 3).ToString();
                    AngleB.Text = Math.Round(SSA.Triangles[0].AngleB.Radians, 3).ToString();
                    AngleC.Text = Math.Round(SSA.Triangles[0].AngleC.Radians, 3).ToString();
                }
            }
                else
            {
                List<Label> labels = new List<Label>
                {
                        SideA, SideB, SideC, AngleA, AngleB, AngleC
                };
                    foreach (Label label in labels)
                {
                        label.Text = "Invalid input";
                }
            }
            if (SSA.Triangles.Count == 1)
            { 
                List<Label> labels = new List<Label>
                {
                    AngleB2, SideC2, AngleC2
                };
                foreach (Label label in labels)
                {
                    label.Text = "No value";
                }
            }
            else
            {
                SideA.Text = Math.Round(SSA.Triangles[1].SideA, 3).ToString();
                SideB.Text = Math.Round(SSA.Triangles[1].SideB, 3).ToString();
                SideC2.Text = Math.Round(SSA.Triangles[1].SideC, 3).ToString();
                if (unit)
                {
                    AngleA.Text = Math.Round(SSA.Triangles[1].AngleA.Degrees, 3).ToString();
                    AngleB2.Text = Math.Round(SSA.Triangles[1].AngleB.Degrees, 3).ToString();
                    AngleC2.Text = Math.Round(SSA.Triangles[1].AngleC.Degrees, 3).ToString();
                }
                else
                {
                    AngleA.Text = Math.Round(SSA.Triangles[1].AngleA.Radians, 3).ToString();
                    AngleB2.Text = Math.Round(SSA.Triangles[1].AngleB.Radians, 3).ToString();
                    AngleC2.Text = Math.Round(SSA.Triangles[1].AngleC.Radians, 3).ToString();
                }
            }
        }
    }
}
