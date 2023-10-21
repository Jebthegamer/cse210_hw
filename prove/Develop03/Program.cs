using System;
using System.Diagnostics.Contracts;
class Program
{
    static void Main(string[] args)
    {    
        // Unfortunately, I couldn't make my idea to read a file work, so I instead have to hard-code my scriptures.
        List<Scripture> scriptures = new List<Scripture>();
        Scripture scripture1 = new Scripture("This is my work and glory -to bring to pass the immortality and eternal life of man.", "Moses 1:39");
        scriptures.Add(scripture1);
        scripture1 = new Scripture("The Lord called his people Zion, because they were of one heart and one mind.", "Moses 7:18");
        scriptures.Add(scripture1);
        scripture1 = new Scripture("And I will make of thee a great nation, and I will bless thee above measure, and make thy name great among all nations, and thou shalt be a blessing unto thy seed after thee, that in their hands they shall bear this ministry and Priesthood unto all nations. And I will bless them through thy name; for as many as receive this Gospel shall be called after thy name, and shall be accounted thy seed, and shall rise up and bless thee, as their father. And I will bless them that bless thee, and curse them that curse thee; and in thee (that is, in thy Priesthood) and in thy seed (that is, thy Priesthood), for I give unto thee a promise that this right shall continue in thee, and in thy seed after thee (that is to say, the literal seed, or the seed of the body) shall all the families of the earth be blessed, even with the blessings of the Gospel, which are the blessings of salvation, even of life eternal.", "Abraham 2:9-11");
        scriptures.Add(scripture1);
        scripture1 = new Scripture("Now the Lord had shown unto me, Abraham, the intelligences that were organized before the world was; and among all these there were many of the noble and great ones. And God saw these souls that they were good, and he stood in the midst of them, and he said: These I will make my rulers; for he stood among those that were spirits, and he saw that they were good; and he said unto me: Abraham, thou art one of them; thou wast chosen before thou wast born.", "Abraham 3:22-23");
        scriptures.Add(scripture1);
        scripture1 = new Scripture("And God said, Let us make man in our image, after our likeness: and let them have dominion over the fish of the sea, and over the fowl of the air, and over the cattle, and over all the earth, and over every creeping thing that creepeth upon the earth. So God created man in his own image, in the image of God created he him; male and female created he them.", "Genesis 1:26–27");
        scriptures.Add(scripture1);
        scripture1 = new Scripture("Therefore shall a man leave his father and his mother, and shall cleave unto his wife: and they shall be one flesh.", "Genesis 2:24");
        scriptures.Add(scripture1);

        // Select a random scripture from the list to be mastered.
        var random = new Random();
        int index = random.Next(scriptures.Count);
        // Start a while loop
        bool remain = true;
        while (remain)
        {
            Console.Clear();
            // Display the scripture.
            scriptures[index].DisplayScripture();
            
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine();
            if (input == "quit")
            {
                remain = false;
            }
            else
            {
                remain = scriptures[index].HideWords();
            }
        }
    }
}