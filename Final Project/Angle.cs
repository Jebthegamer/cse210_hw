using System;
using System.Math;

public class Angle
{ 
	public double Degrees {  get; set; }
	public double Radians { get; set; }
	public Angle(float value, bool deg)
	{
		if (deg)
		{
			Degrees = value;
			Radians = Degrees * Math.PI / 180;
		}
		else 
		{
			Radians = value;
            Degrees = Radians * 180 / Math.PI;
		}
	}
}
