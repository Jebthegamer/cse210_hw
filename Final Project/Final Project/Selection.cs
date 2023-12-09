namespace Final_Project
{
    public class Selection
    {
        // This class allows for a boolean with a label to exist; making life significantly easier in the menu.
        public string Name { get; set; }
        public bool Status { get; set; }
        public Selection(string name, bool status)
        {
            Status = status;
            Name = name;
        }
	}
}