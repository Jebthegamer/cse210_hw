namespace Final_Project
{
    public class Selection
    {
        public string Name { get; set; }
        public bool Status { get; set; }
        public Selection(string name, bool status)
        {
            Status = status;
            Name = name;
        }
	}
}