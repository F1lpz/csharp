

using kniha;

public class Program
        {
            static void Main(string[] args)
            {
                List<Kniha> knihas = new List<Kniha>()

            {
                new Kniha() { Autor = "Joanne K. Rowling", rokVydania = 2019, PreDospelych = false },
                new Kniha() { Autor = "Jack Carr", rokVydania = 2022, PreDospelych = true },
                new Kniha() { Autor = "Collen Hooverova", rokVydania = 2023, PreDospelych = true },

             };

                List<Kniha> knihyPreMladez = knihas.Where(kniha => !kniha.PreDospelych).ToList();
                List<Kniha> knihyOdNajstarsej = knihas.OrderBy(kniha => kniha.ReleaseYear).ToList();
                List<Kniha> knihyOdNajnovsej = knihas.OrderByDescending(kniha => kniha.ReleaseYear).ToList();
                List<Kniha> knihyPreMladezOdNajstarsej = knihas.Where(kniha => !kniha.PreDospelych).OrderBy(kniha => kniha.ReleaseYear).ToList();

                var vysledok = knihas.GroupBy(p => p.ReleaseYear);

                foreach (Kniha kniha in knihyOdNajstarsej)
                {
                    Console.WriteLine($"LINQ:Kniha napisana {kniha.Autor} je urcena pre deti");
                }
            }
        }
    
