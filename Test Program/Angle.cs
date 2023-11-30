using System;

public class Angle
{
	public float degrees { get; set; }
    public float radians { get; set; }
    public Angle(float deg = 0, float rad = 0)
	{
			degrees = deg;
			radians = rad;
	}
	public float getDegrees()
	{
		return degrees;
	}
	public float getRadians()
	{
		return radians;
	}
	private void conversion()
	{
		if (degrees == 0)
		{
			degrees = (radians * 180) / Math.PI;
		}
		else
		{
			radians = (degrees * Math.PI) / 180;
		}
	}
}
