namespace Final_Project
{
    //  This class allows for the easy conversion between degrees and radians as an input and output value.
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