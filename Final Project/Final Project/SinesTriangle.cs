namespace Final_Project
{
    // The easiest triangles to solve; solve for the third angle and plug in.
    // Some extra math is added to allow for SSA to hitchhike a little bit here.
    internal class SinesTriangle : GeneralTriangle
    {
        // This boolean is to help keep the AAS and ASA triangles separate.
        private bool AAS { get; set; }
        // These second two Booleans are to keep SSA triangles separate from AAS and ASA triangles
        private bool SSA { get; set; }
        private bool DoubleTriangle { get; set; }
        public SinesTriangle(double A, double B, double C, Angle a, Angle b, Angle c, bool type, bool identifier, bool Double) : base(A, B, C, a, b, c)
        {
            AAS = type;
            SSA = identifier;
            DoubleTriangle = Double;
            SolveTriangle();
        }
        public override void SolveTriangle()
        {
            // If it's not the first triangle of SSA, skip this. Otherwise solve for AngleB.
            if (SSA && !DoubleTriangle)
            {
                AngleB = new Angle(Math.Asin(SideB * Math.Sin(AngleA.Radians) / SideA), false);
            }
            // Regardless of which triangle is inputted, solving for AngleC is needed.
            AngleC = new Angle(180 - (AngleA.Degrees + AngleB.Degrees), true);
            // AAS and SSA needs to have SideC solved for.
            if (AAS)
            {
                SideC = SideA * Math.Sin(AngleC.Radians) / Math.Sin(AngleA.Radians);
            }
            // ASA needs SideA solved.
            else
            {
                SideA = SideC * Math.Sin(AngleA.Radians) / Math.Sin(AngleC.Radians);
            }
            // AAS and ASA needs SideB solved.
            if (!SSA)
            {
                SideB = SideC * Math.Sin(AngleB.Radians) / Math.Sin(AngleC.Radians);
            }
            DetermineReality();

        }
    }
}