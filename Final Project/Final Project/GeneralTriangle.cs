namespace Final_Project
{
    public abstract class GeneralTriangle
    {
        // All triangles need three sides and two angles.
        protected double SideA { get; set; }
        protected double SideB { get; set; }
        public double SideC { get; set; }
        protected Angle AngleA { get; set; }
        protected Angle AngleB { get; set; }
        protected Angle AngleC { get; set; }
        protected bool IsReal { get; set; }

        public GeneralTriangle(double A, double B, double C, Angle a, Angle b, Angle c)
        {
            SideA = A; SideB = B; SideC = C; AngleA = a; AngleB = b; AngleC = c;
            IsReal = true;
        }
        // All of the triangles need to be solved.
        public abstract void SolveTriangle();

        protected void DetermineReality()
        {
            // This is a function to determine if the resulting triangle is possible.
            // If it isn't then set the output to be false.
            if (SideA == SideB + SideC) IsReal = false;
            if (SideB == SideA + SideC) IsReal = false;
            if (SideC == SideA + SideB) IsReal = false;
            if (AngleA.Degrees + AngleB.Degrees + AngleC.Degrees > 180) IsReal = false;
        }
        public double GetSideA() { return SideA;  }
        public double GetSideB() { return SideB;  }
        public double GetSideC() {  return SideC; }
        public Angle GetAngleA() { return AngleA; }
        public Angle GetAngleB() { return AngleB; }
        public Angle GetAngleC() { return AngleC; }
        public bool GetIsReal() { return IsReal; }
    }
}