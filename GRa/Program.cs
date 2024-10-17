class Gra
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int wybor_komputera = rnd.Next(3);

        Console.WriteLine("Witaj w grze Kamień,papier nożyce! Zmierz się z naszym komputerem");
        Console.Write("Co wybierasz: kamień (k), papier (p) czy nożyce (n): ");
        string wybor_gracza = Console.ReadLine();

        int wybor_gracza_int;
        switch(wybor_gracza)
        {
            case "k":
            {
                wybor_gracza_int = 0;
                break;
            }
            case "p":
            {
                wybor_gracza_int = 1;
                break;
            }
            case "n":
            {
                wybor_gracza_int = 2;
                break;
            }
            default:
            {
                    Console.WriteLine("Zła odpowiedź");
                    break;
            }
        }
    }
}