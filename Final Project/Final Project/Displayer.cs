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
            if (triangle.GetIsReal())
            {
                SideA.Text = Math.Round(triangle.GetSideA(), 3).ToString();
                SideB.Text = Math.Round(triangle.GetSideB(), 3).ToString();
                SideC.Text = Math.Round(triangle.GetSideC(), 3).ToString();
                if (unit)
                {
                    AngleA.Text = Math.Round(triangle.GetAngleA().Degrees, 3).ToString();
                    AngleB.Text = Math.Round(triangle.GetAngleB().Degrees, 3).ToString();
                    AngleC.Text = Math.Round(triangle.GetAngleC().Degrees, 3).ToString();
                }
                else
                {
                    AngleA.Text = Math.Round(triangle.GetAngleA().Radians, 3).ToString();
                    AngleB.Text = Math.Round(triangle.GetAngleB().Radians, 3).ToString();
                    AngleC.Text = Math.Round(triangle.GetAngleC().Radians, 3).ToString();
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
            if (SSA.Triangles[0].GetIsReal())
            {
                SideA.Text = Math.Round(SSA.Triangles[0].GetSideA(), 3).ToString();
                SideB.Text = Math.Round(SSA.Triangles[0].GetSideB(), 3).ToString();
                SideC.Text = Math.Round(SSA.Triangles[0].GetSideC(), 3).ToString();
               if (unit)
               {
                    AngleA.Text = Math.Round(SSA.Triangles[0].GetAngleA().Degrees, 3).ToString();
                    AngleB.Text = Math.Round(SSA.Triangles[0].GetAngleB().Degrees, 3).ToString();
                    AngleC.Text = Math.Round(SSA.Triangles[0].GetAngleC().Degrees, 3).ToString();
                }
                    else
                {
                    AngleA.Text = Math.Round(SSA.Triangles[0].GetAngleA().Radians, 3).ToString();
                    AngleB.Text = Math.Round(SSA.Triangles[0].GetAngleB().Radians, 3).ToString();
                    AngleC.Text = Math.Round(SSA.Triangles[0].GetAngleC().Radians, 3).ToString();
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
                SideA.Text = Math.Round(SSA.Triangles[1].GetSideA(), 3).ToString();
                SideB.Text = Math.Round(SSA.Triangles[1].GetSideB(), 3).ToString();
                SideC2.Text = Math.Round(SSA.Triangles[1].GetSideC(), 3).ToString();
                if (unit)
                {
                    AngleA.Text = Math.Round(SSA.Triangles[1].GetAngleA().Degrees, 3).ToString();
                    AngleB2.Text = Math.Round(SSA.Triangles[1].GetAngleB().Degrees, 3).ToString();
                    AngleC2.Text = Math.Round(SSA.Triangles[1].GetAngleC().Degrees, 3).ToString();
                }
                else
                {
                    AngleA.Text = Math.Round(SSA.Triangles[1].GetAngleA().Radians, 3).ToString();
                    AngleB2.Text = Math.Round(SSA.Triangles[1].GetAngleB().Radians, 3).ToString();
                    AngleC2.Text = Math.Round(SSA.Triangles[1].GetAngleC().Radians, 3).ToString();
                }
            }
        }
    }
}
