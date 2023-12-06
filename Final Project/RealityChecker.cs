using System;

public class RealityChecker
{
	public RealityChecker()
	{
	}
	public bool DetermineReality(GeneralTriangle triangle)
	{
		bool real == true;
		if (triangle == null) real = false;
		else
		{
			if (triangle.SideA == triangle.SideB + triangle.SideC) real = false;
			if (triangle.SideB == triangle.SideA + triangle.SideC) real = false;
            if (triangle.SideC == triangle.SideA + triangle.SideB) real = false;
			if (triangle.AngleA.Degrees + triangle.AngleB.Degrees + triangle.AngleC.Degrees > 180) real = false;
        }
		return real;
	}
}
