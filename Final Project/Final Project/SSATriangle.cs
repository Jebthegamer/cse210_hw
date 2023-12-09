namespace Final_Project
{
    // SSA triangles are annoying to work with due to their more complicated math. However, you solve them using the law of sines.
    // This means I can create a list of them instead of having to deal with making it massively different than the other triangles.
    internal class SSATriangle
    {
        public List<GeneralTriangle> Triangles { get; set; }
        public SSATriangle(double A, double B, double C, Angle a, Angle b, Angle c)
        {
            Triangles = new List<GeneralTriangle>();
            SinesTriangle triangle = new SinesTriangle(A, B, C, a, b, c, true, true, false);
            Triangles.Add(triangle);
            SolveSecondTriangle();
        }

        private void SolveSecondTriangle()
        {
            // This function will determine if the SSA triangle could correspond to multiple values. 
            if ((Triangles[0].GetSideB() > Triangles[0].GetSideA()) && (Triangles[0].GetAngleA().Degrees < 90))
            {
                double h = Triangles[0].GetSideB() * Math.Sin(Triangles[0].GetAngleA().Radians);
                double SinB = (Triangles[0].GetSideB() * Math.Sin(Triangles[0].GetAngleA().Radians) / Triangles[0].GetSideA());
                if ((Triangles[0].GetSideA() > h) || ((SinB < 1) && (SinB > 0)))
                {
                    Angle AngleB2 = new Angle((180 - Triangles[0].GetAngleB().Degrees), true);
                    Triangles.Add(new SinesTriangle(Triangles[0].GetSideA(), Triangles[0].GetSideB(), 0, Triangles[0].GetAngleA(), AngleB2, Triangles[0].GetAngleC(), true, true, true));
                }
            }
        }
    }
}