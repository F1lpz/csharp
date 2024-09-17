Console.WriteLine("Ako sa voláš?");
string? meno = Console.ReadLine();
Console.WriteLine("Ahoj, " + meno + "\n");

Console.WriteLine("Koľko máš rokov?");
string vstup = Console.ReadLine() ?? "0";
int vek = int.Parse(vstup);
Console.WriteLine("Máš " + vek + " rokov.");

Console.WriteLine("ake je tvoje oblubene jedlo?");
string? jedlo = Console.ReadLine();
Console.WriteLine("mmmmm " + jedlo);

Console.WriteLine("rikaju mi " + meno + " mam " + vek + " a mam rad " + jedlo);