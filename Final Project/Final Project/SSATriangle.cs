namespace Final_Project
{
    internal class SSATriangle : GeneralTriangle
    {
        public List<GeneralTriangle> Triangles { get; set; }
        public SSATriangle(double A, double B, double C, Angle a, Angle b, Angle c) : base(A, B, C, a, b, c)
        {
            Triangles = new List<GeneralTriangle>();
        }
        public override void SolveTriangle()
        {
            if (SideB < SideA)
            {

                Triangles.Add(new SinesTriangle(SideA, SideB, SideC2, AngleA, AngleB, AngleC, true, true));
            }
            else if (SideB == SideA)
            {
                if (AngleA.Degrees < 90)
                    Triangles.Add(new SinesTriangle(SideA, SideB, SideC2, AngleA, AngleB, AngleC, true, true));
                else
                    IsReal = false;
            }
            else if (SideB2 > SideA)
            {
                if (AngleA.Degrees > 90)
                    IsReal = false;
                else
                {
                    double h = SideB * Math.Sin(AngleA.Radians);
                    if (SideA > h)
                    {
                        Triangles.Add(new SinesTriangle(SideA, SideB, SideC, AngleA, AngleB, AngleC, true, true));
                        if (Triangles[0].IsReal)
                        {
                            Angle AngleB2 = new Angle((180 - Triangles[0].AngleB.Degrees), true);
                            Triangles.Add(new SinesTriangle(SideA, SideB, SideC, AngleA, AngleB2, AngleC, true, true));
                        }
                        else
                        {
                            AngleB2 = new Angle((180 - (SideB * Math.Sin(AngleA.Radians_))), false);
                            Triangles.Add(new SinesTriangle(SideA, SideB, SideC, AngleA, AngleB2, AngleC, true, true));
                        }
                    }
                    else if (SideA == h)
                    {
                        Triangles.Add(new SinesTriangle(SideA, SideB, SideC, AngleA, AngleB, AngleC, true, true));
                    }
                    else if (SideA < h)
                        IsReal = false;
                }
            }
        }
}