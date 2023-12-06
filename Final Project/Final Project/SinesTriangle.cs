namespace Final_Project
{
    internal class SinesTriangle : GeneralTriangle
    {
        private bool AAS { get; set; }
        private bool SSA { get; set; }
        public SinesTriangle(double A, double B, double C, Angle a, Angle b, Angle c, bool type, bool identifier) : base(A, B, C, a, b, c)
        {
            AAS = type;
            SSA = identifier;
            SolveTriangle();
        }
        public override void SolveTriangle()
        {
            if (SSA)
            {
                AngleB = new Angle(SideB * Math.Sin(AngleA.Radians), false);
            }
            AngleC = new Angle(180 - (AngleA.Degrees + AngleB.Degrees), true);
            if (AAS)
            {
                SideC = SideA * Math.Sin(AngleC.Radians) / Math.Sin(AngleA.Radians);
            }
            else
            {
                SideA = SideC * Math.Sin(AngleA.Radians) / Math.Sin(AngleC.Radians);
            }
            if (!SSA)
            {
                SideB = SideC * Math.Sin(AngleB.Radians) / Math.Sin(AngleC.Radians);
            }
            DetermineReality();

        }
    }
}