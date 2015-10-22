 while (true)
            {
                Console.WriteLine("Pie Receipe App!");
                string piechoice = Console.ReadLine();

                switch (piechoice)
                {
                    case "Apple":
                        Console.WriteLine("Apple pie contains apples, sugar, and flour");
                        break;
                    case "Cherry":
                        Console.WriteLine("Cherry pie contains cherries, sugar, and flour");
                        break;
                    case "Pumpkin":
                        Console.WriteLine("Pumpkin pie contains processed pumpkin, sugar, and flour, and vanilla and cinnamon.");
                        break;
                    default:
                        Console.WriteLine("I don't know that receipe.");
                        break;
                }

                Console.WriteLine("Would you like to try again??");
                string choice = Console.ReadLine();
                if (choice != "yes")
                {
                    break;
                }

            }
