using System;

namespace MyDictionaryOdev5
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> musteri = new MyDictionary<int, string>();

            musteri.Add(5243, "Ali ÇEŞME");
            musteri.Add(5555, "Ayşe GÜL");

            Console.WriteLine(musteri.Count);

        }
    }
}
