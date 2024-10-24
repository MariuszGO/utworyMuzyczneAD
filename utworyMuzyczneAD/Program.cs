using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        class albumy
        {
            string artist { get; set; }
            string album { get; set; }
            int songsNumber { get; set; }
            int year { get; set; }
            Int32 downloadNumber { get; set; }
            public void odczytaj()
            {
                string plik = "Data.txt";
                string linia;
                int ilosc=0;

                StreamReader sr = new StreamReader(plik);

                while (!sr.EndOfStream) { 
                
                    ilosc++;
                    

                }


                while (!sr.EndOfStream)
                {
                    linia = sr.ReadLine();
                   ilosc++;
                    Console.WriteLine(linia);
                   
                }
                Console.WriteLine(ilosc);

            }

        };//koniec klasy albumy

        
    

        static void Main(string[] args)
        {
            albumy album = new albumy();

            album.odczytaj();

            Console.WriteLine("Hello World!");


        }
    }
}