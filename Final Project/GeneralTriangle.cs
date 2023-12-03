using System;

public abstract class GeneralTriangle
{
    public double sideA { get; set; }
    public double sideB { get; set; }
    public double sideC { get; set; }
    public Angle angleA { get; set; }
    public Angle angleB { get; set; }
    public Angle angleC { get; set; }

    public GeneralTriangle(double A, double B, double C, Angle a, Angle b, Angle c)
    {
        sideA = A; sideB = B; sideC = C; angleA = a; angleB = b; angleC = c;
    }
    protected abstract void SolveTriangle();

    public double GetSideA() { return sideA;}
    public double GetSideB() { return sideB;}
    public double GetSideC() { return sideC;}
    public double GetAngleA() { return angleA;}
    public double GetAngleB() { return angleB;}
    public double GetAngleC() { return angleC;}
}
