namespace scrabble3D
{
    internal class Program
    {
        static string porowLiter(char[] haslo, List<char> literyZKostek)
        {
            foreach (char c in haslo) {
                if (!literyZKostek.Contains(c))
                    return "NIE";
                literyZKostek.Remove(c);
            }

            return "TAK";
        }

        static void Main(string[] args)
        {
            List<string> wyniki = new List<string>();
            int.TryParse(Console.ReadLine(), out int n);
            for(int i = 0; i < n; i++)
            {
                int.TryParse(Console.ReadLine(), out int k);
                char[] haslo = Console.ReadLine().ToCharArray();
                List<char> literyZKostek = new List<char>();
                for(int j = 0; j < k; j++)
                {
                    string[] kostka = Console.ReadLine().Split(' ');
                    foreach(string c in kostka) {
                        if (haslo.Contains(c[0]))
                        {
                            literyZKostek.Add(c[0]);
                            break;
                        }

                    }
                }
                wyniki.Add(porowLiter(haslo, literyZKostek));
            }

            foreach(string w in wyniki)
                Console.WriteLine(w);
        }
    }
}
