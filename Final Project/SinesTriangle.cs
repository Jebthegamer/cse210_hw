using System;
using System.Math;

public class SinesTriangle : GeneralTriangle
{
    private bool AAS { get; set; }
    public SinesTriangle(double A, double B, double C, Angle a, Angle b, Angle c, bool type) : base(A, B, C, a, b, c)
	{
		AAS = type;
		SolveTriangle();
	}
	private override SolveTriangle()
	{
		AngleC = 180 - (AngleA + AngleB);
		if (AAS)
		{
			SideC = SideA * Math.Sin(AngleC) / Math.Sin(AngleA);
		}
		else
		{
			SideA = SideC * Math.Sin(AngleA) / Math.Sin(AngleC);
		}
		SideB = SideC * Math.Sin(AngleB) / Math.Sin(AngleC);
	}
}
