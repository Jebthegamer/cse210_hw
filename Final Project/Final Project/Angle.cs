namespace Final_Project
{
    public class Angle
    {
        public double Degrees { get; set; }
        public double Radians { get; set; }
        public Angle(double value, bool deg)
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
}