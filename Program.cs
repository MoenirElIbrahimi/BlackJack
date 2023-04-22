namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {

            dealer dealer = new dealer();

            // Een lijst van opties
            List<string> options = new List<string>();
            options.Add("Hit(1)");
            options.Add("Stand(2)");
            options.Add("Kaarten schudden(3)");
            options.Add("Kaarten uitdelen(4)");

            // Een scorebord
            int correct = 0;
            int incorrect = 0;

            while (true)
            {
                // Toon de lijst van opties
                Console.WriteLine("Welkom bij Black jack hier kan je leren hoe je moet werken als een dealer. je krijgt een aantal opties en jij moet kiezen tussen de opties in de verloop van de game om dan beter de game begrijpen.");
                for (int i = 0; i < options.Count; i++)
                {
                    Console.WriteLine((i + 1) + ". " + options[i]);
                }

                // Laat de gebruiker een keuze maken
                Console.Write("je begint de game maak een keuze (1-" + options.Count + "): ");
                int choice = Convert.ToInt32(Console.ReadLine());

                // Voer de actie uit op basis van de keuze van de gebruiker
                switch (choice)
                {
                    case 1: // Hit
                        dealer.Hit(new card("Ace", "10")); // Voeg een kaart toe aan de hand van de dealer
                        Console.WriteLine("Dealer has " + dealer.Hand.Count + " cards in their hand.");
                        break;
                    case 2: // Stand
                        dealer.Stand(); // De dealer stopt met kaarten trekken
                        Console.WriteLine("Dealer stands.");
                        break;
                    case 3: // Kaarten schudden
                        dealer.Shuffle();
                        Console.WriteLine("Cards have been shuffled.");
                        break;
                    case 4: // Kaarten uitdelen
                        dealer.Deal(); // Deel kaarten uit aan de speler en de dealer
                        Console.WriteLine("Cards have been dealt.");
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

                // Toon de score van de dealer
                Console.WriteLine("Dealer score: " + dealer.Score);

                // Vraag of de gebruiker nog door wil gaan
                //                Console.Write("Do you want to continue? (y/n): ");
                //              string answer = Console.ReadLine();

                // Als de gebruiker niet meer door wil gaan, stop dan met de loop
                //            if (answer.ToLower() != "y")
                //          {
                //            break;
                //   }
                // }




                Console.WriteLine("Final score: " + correct + " correct, " + incorrect + " incorrect.");
                break;
            }
        }
    }
}
        