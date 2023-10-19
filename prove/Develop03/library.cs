using System.Threading.Tasks.Dataflow;

public class Library {
    private List<Reference> _references = new List<Reference>();
    private string _filename = "library.txt";
    public Library()
    {
        if(File.Exists(_filename)){
            string[] lines = System.IO.File.ReadAllLines(_filename);
            foreach (string line in lines)
            {
                string[] parts = line.Split("/");
                string book = parts[0];
                int chapter = int.Parse(parts[1]);
                int firstVerse = int.Parse(parts[2]);
                int lastVerse = int.Parse(parts[3]);
                string text = parts[4];
                if (lastVerse == 0)
                {
                    Reference myReference = new Reference(book, chapter, firstVerse, text);
                    _references.Add(myReference);
                }
                else 
                {
                    Reference myReference = new Reference(book, chapter, firstVerse, lastVerse, text);
                    _references.Add(myReference);
                } 
            }
        }
        else {
            Console.WriteLine($"File name {_filename} does not exist");
        }
    }

    public Reference GetReferenceGenerator()
    {
        Random random = new Random();
        int rand_number = random.Next(0,_references.Count());
        return _references[rand_number];
    }
}
