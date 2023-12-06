using System;

public class CosinesTriangle : GeneralTriangle
{
    private bool SSS;
    public CosinesTriangle(double A, double B, double C, Angle a, Angle b, Angle c, bool type) : base(A, B, C, a, b, c)
    {
        SSS = type;
        SolveTriangle();
	}
    private override SolveTriangle()
    {
        if (SSS)
        {
            AngleC = new Angle(Math.Acos((SideA * SideA) + (SideB * SideB) - (SideC * SideC) / (2 * SideA * SideB)), false);
        }
        else
        {
            SideC = Math.Sqrt((SideA * SideA) + (SideB * SideB) - (2 * SideA * SideB * Math.Cos(AngleC)));
        }
        AngleA = Math.Asin(SideA * Math.Sin(AngleC) / SideC);
        AngleB = new Angle(180 - (AngleA.Degrees + AngleC.Degrees), true);
        DetermineReality();
    }
}
