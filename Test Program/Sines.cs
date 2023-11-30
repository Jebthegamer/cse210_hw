using System;

public class Sines
{
    public float sideA { get; set; }
    public float sideB { get; set; }
    public float sideC { get; set; }
    public Angle angleA { get; set; }
    public Angle angleB { get; set; }
    public Angle angleC { get; set; }


    public Sines(float A = 0, float B = 0, float C = 0, angle a = 0, angle b = 0, angle c = 0)
	{
        sideA = A; sideB = B; sideC = C; angleA = a; angleB = b; angleC = c;
	}
}

