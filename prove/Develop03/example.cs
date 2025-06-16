// public class Scripture
// {
//     public static string _reference;
//     private List<Verse> _verses;
//     public Scripture(StreamReader reader)
//     {
//         _verses = new List<Verse>();
//         _reference = reader.ReadLine().Trim();
//         _verses = new List<Verse>();
//         while (!reader.EndOfStream)
//         {
//             string text = reader.ReadLine().Trim();
//             _verses.Add(new Verse(text));
//         }
//     }
//     public static void Display()
//     {
//         Console.WriteLine($"{_reference}");
//     }
// }


// public class Verse
// {
//     private List<Word> _words;
//     public Verse(string text)
//     {
//         _words = new List<Word>();
//         // splits the verse into individual words
//         string[] parts = text.Split();

//         foreach (string part in parts)
//         {
//             Word word = new Word(part);
//             _words.Add(word);
//         }

//     }
// }

// public class Word
// {
//     private string _text;
//     private bool _visible;
//     public Word(string text)
//     {
//         _text = text;
//         _visible = true;
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         using (StreamReader reader = new StreamReader("1_Nephi_3_7.txt"))
//         {
//             Scripture scripture2 = new Scripture(reader);
//             Scripture.Display();
//         }
//     }
// }