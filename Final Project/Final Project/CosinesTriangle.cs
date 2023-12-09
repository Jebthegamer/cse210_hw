namespace Final_Project
{
    // Cosines triangles have a bit more complex math, but it's nothing a computer can't handle.
    internal class CosinesTriangle : GeneralTriangle
    {
        // A boolean to separate SSS and SAS
        private bool SSS;
        public CosinesTriangle(double A, double B, double C, Angle a, Angle b, Angle c, bool type) : base(A, B, C, a, b, c)
        {
            SSS = type;
            SolveTriangle();
        }
        public override void SolveTriangle()
        {
            // If it's SSS, solve for AngleC using the law of cosines.
            if (SSS)
            {
                AngleC = new Angle(Math.Acos(((SideA * SideA) + (SideB * SideB) - (SideC * SideC)) / (2 * SideA * SideB)), false);
            }
            // SAS needs SideC to be solved.
            else
            {
                SideC = Math.Sqrt((SideA * SideA) + (SideB * SideB) - (2 * SideA * SideB * Math.Cos(AngleC.Radians)));
            }
            // At this point, the two inputs are identical, meaning that AngleA and AngleB can be solved together.
            AngleA = new Angle(Math.Asin(SideA * Math.Sin(AngleC.Radians) / SideC), false);
            AngleB = new Angle(180 - (AngleA.Degrees + AngleC.Degrees), true);
            DetermineReality();
        }
    }
}