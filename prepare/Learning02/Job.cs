    public class Job
    {
        public string Company;
        public string JobTitle;
        public int StartYear;
        public int EndYear;
        public void Display()
        {
            Console.WriteLine($"{JobTitle} ({Company}) {StartYear}-{EndYear}");
        }
       // public int MyProperty { get; set; }
       // Obtained by typing "prop" then hitting tab
    }