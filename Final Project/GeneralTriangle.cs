using System;

public abstract class GeneralTriangle
{
    public double sideA { get; set; }
    public double sideB { get; set; }
    public double sideC { get; set; }
    public Angle angleA { get; set; }
    public Angle angleB { get; set; }
    public Angle angleC { get; set; }
    public bool IsReal { get; set; }

    public GeneralTriangle(double A, double B, double C, Angle a, Angle b, Angle c)
    {
        sideA = A; sideB = B; sideC = C; angleA = a; angleB = b; angleC = c;
        IsReal = true;
    }
    protected abstract void SolveTriangle();

    protected void DetermineReality(GeneralTriangle triangle)
    {
        if (triangle == null) IsReal = false;
        else
        {
            if (triangle.SideA == triangle.SideB + triangle.SideC) IsReal = false;
            if (triangle.SideB == triangle.SideA + triangle.SideC) IsReal = false;
            if (triangle.SideC == triangle.SideA + triangle.SideB) IsReal = false;
            if (triangle.AngleA.Degrees + triangle.AngleB.Degrees + triangle.AngleC.Degrees > 180) IsReal = false;
        }
    }
    public double GetSideA() { return sideA;}
    public double GetSideB() { return sideB;}
    public double GetSideC() { return sideC;}
    public double GetAngleA() { return angleA;}
    public double GetAngleB() { return angleB;}
    public double GetAngleC() { return angleC;}
}
