
namespace Pomeridiano2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            List<double> conto = new List<double>();
            List<string> showMenuSelected = new List<string>();

           
                Console.WriteLine("Seleziona voci menu");
                Console.WriteLine("==============MENU===============");
                Console.WriteLine("1:  Coca Cola 150 ml (€ 2.50)");
                Console.WriteLine("2:  Insalata di pollo (€ 5.20)");
                Console.WriteLine("3:  Pizza Margherita (€ 10.00)");
                Console.WriteLine("4:  Pizza 4 Formaggi (€ 12.50)");
                Console.WriteLine("5:  Pz patatine fritte (€ 3.50)");
                Console.WriteLine("6:  Insalata di riso (€ 8.00)");
                Console.WriteLine("7:  Frutta di stagione (€ 5.00)");
                Console.WriteLine("8:  Pizza fritta (€ 6.80)");
                Console.WriteLine("9:  Piadina vegetariana (€ 6.00)");
                Console.WriteLine("10: Panino Hamburger (€ 7.90)");
                Console.WriteLine("11: Stampa conto finale e conferma");
                Console.WriteLine("==============MENU===============");
            while (true)
            {
                var scelta = Console.ReadLine();
                switch (scelta)
                {
                    case "1":
                        conto.Add(2.50);
                        showMenuSelected.Add("Coca Cola 2.50 €");
                        break;
                    case "2":
                        conto.Add(5.20);
                        showMenuSelected.Add("Insalata di pollo 5.20€");
                        break;
                    case "3":
                        conto.Add(10);
                        showMenuSelected.Add("Pizza Margherita 10.00€");
                        break;
                    case "4":
                        showMenuSelected.Add("Pizza 4 formaggi 12.50€");
                        conto.Add(12.50);
                        break;
                    case "5":
                        showMenuSelected.Add("Patatine Fritte 3.50€");
                        conto.Add(3.50);
                        break;
                    case "6":
                        showMenuSelected.Add("Insalata di riso 8.00€");
                        conto.Add(8);
                        break;
                    case "7":
                        showMenuSelected.Add("Frutta di stagione 5.00€");
                        conto.Add(5);
                        break;
                    case "8":
                        showMenuSelected.Add("Pizza Fritta 6.80€");
                        conto.Add(6.80);
                        break;
                    case "9":
                        showMenuSelected.Add("Piadina Vegetariana 6.00€");
                        conto.Add(6);
                        break;
                    case "10":
                        showMenuSelected.Add("Hamburger 7.90€");
                        conto.Add(7.90);
                        break;
                    case "11":
                        double TotConto = conto.Sum();
                        Console.WriteLine("Elementi selezionati:");
                        foreach (var item in showMenuSelected)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("Totale: " + TotConto.ToString("C"));
                        return; 
                    default:
                        Console.WriteLine("Scelta non valida. Riprova.");
                        break;
                }
            }
        }
    }
}
