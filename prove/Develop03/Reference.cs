// This class is largely useless, and that is because I think of a scripture reference as the book's title, the chapter number
// and the number of the verses, which all can be stored in a single string. However, because we're going to be using this as an
// exercise in encapsulation, I still created and used this class instead of a string. There are no methods needed to modify a single
// string, but this encapsulates the value of the string so that it needs to be accessed by calling the GetReference function, as
// opposed to being easily accessible.
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