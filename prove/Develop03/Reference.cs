public class Reference
{
    private string _reference { get; set; }
   
    public string GetReference()
    {
        return _reference;
    }

    public Reference(string reference)
    {
        _reference = reference;
    }
}
// Console.WriteLine(${reference.GetReference()});