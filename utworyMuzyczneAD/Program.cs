class Program
{

    class albumy
    {
        public string artist { get; set; }
        public string album { get; set; }
        public Int32 songsNumber { get; set; }
        public Int32 year { get; set; }
        public Int32 downloadNumber { get; set; }

        public override string ToString()
        {
            return $"Zespół: {artist}, Album: \"{album}\", Utwory: {songsNumber}, Rok: {year}, Ilosc Pobran: {downloadNumber}";
        }
        public void odczyt(string filePath, List<albumy> utwory)
        {
            


            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    albumy u = new albumy();


                    u.artist = line;
                    u.album = sr.ReadLine().Trim('"');
                    u.songsNumber = int.Parse(sr.ReadLine());
                    u.year = int.Parse(sr.ReadLine());
                    u.downloadNumber = int.Parse(sr.ReadLine());

                    sr.ReadLine();

                    utwory.Add(u);

                }

            }

        }//koniec odczyt

        public void wyswietl(List<albumy> utwory)
        {
            int liczba = 0;
            foreach (var u1 in utwory)
            {
                liczba++;
                Console.WriteLine(liczba);
                Console.WriteLine(u1);
            }
        }

    };

    static void Main()
    {
        string filePath = "Data.txt";

        if (File.Exists(filePath))
        {

            List<albumy> utwory = new List<albumy>();

            var cc = new albumy();

            cc.odczyt(filePath, utwory);
            cc.wyswietl(utwory);

        }
        else
        {
            Console.WriteLine("Plik nie istnieje.");
        }
    }
}