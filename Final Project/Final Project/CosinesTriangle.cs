namespace Final_Project
{
    internal class CosinesTriangle : GeneralTriangle
    {
        private bool SSS;
        public CosinesTriangle(double A, double B, double C, Angle a, Angle b, Angle c, bool type) : base(A, B, C, a, b, c)
        {
            SSS = type;
            SolveTriangle();
        }
        public override void SolveTriangle()
        {
            if (SSS)
            {
                AngleC = new Angle(Math.Acos((SideA * SideA) + (SideB * SideB) - (SideC * SideC) / (2 * SideA * SideB)), false);
            }
            else
            {
                SideC = Math.Sqrt((SideA * SideA) + (SideB * SideB) - (2 * SideA * SideB * Math.Cos(AngleC.Radians)));
            }
            AngleA = new Angle(Math.Asin(SideA * Math.Sin(AngleC.Radians) / SideC), false);
            AngleB = new Angle(180 - (AngleA.Degrees + AngleC.Degrees), true);
            DetermineReality();
        }
    }
}