using Labb_2;
Kitchen Kitchen = new Kitchen();



UserInteraction();




void UserInteraction()
{
    bool run = true;
    string type;
    string brand;
    string working;
    bool userErrorCatch1;

    while (run)
    {

        Console.Write(Kitchen.Menu());
        userErrorCatch1 = int.TryParse(Console.ReadLine(), out int userInput);
        if (userErrorCatch1 == true)
        {
            switch (userInput)
            {
                case 1:
                    Console.WriteLine("Välj köksapparat: ");
                    Console.WriteLine(Kitchen.SubMenu());
                    Console.WriteLine("Ange val:");
                    Console.Write(">");
                    Console.WriteLine(CheckUserChoice(Console.ReadLine()));
                    break;

                case 2:
                    Console.WriteLine("Ange typ:");
                    Console.WriteLine(Kitchen.TypesMenu());
                    Console.Write(">");
                    type = Console.ReadLine();

                    Console.Write("Ange märke: \n");
                    Console.WriteLine(Kitchen.BrandMenu());
                    Console.Write(">");
                    brand = Console.ReadLine();

                    Console.Write("Ange om den fungerar (j/n)\n>");
                    working = Console.ReadLine();

                    if (Kitchen.CheckValidOption(type, brand, working) == true)
                    {
                        Kitchen.AddKitchenStuff(type, brand, working);
                        Console.WriteLine($"{type} har lagts till bland dina andra köksapparater");
                    }
                    else
                    {
                        Console.WriteLine("Någon av dina inputs var ogiltiga, försök igen.");
                    }

                    break;

                case 3:
                    Console.WriteLine(Kitchen.PrintList());
                    break;

                case 4:
                    if (Kitchen.ListCount == 0)
                    {
                        Console.WriteLine("Listan är tom");
                        break;
                    }
                    Console.WriteLine("Välj köksapparat: ");
                    Console.WriteLine(Kitchen.SubMenu());
                    Console.Write("Ange val: \n>");
                    Console.WriteLine(RemoveKitchenStuff(Console.ReadLine()));
                    break;

                case 5:
                    run = false;
                    break;

                default:
                    Console.WriteLine("Ogiltig val, välj mellan alternativ: 1 - 5.");
                    break;
            }
        }
        else
        {
            Console.WriteLine($"Använd endast siffror!");
        }

    }

}

string RemoveKitchenStuff(string userInput)
{
    bool userErrorCatch = false;
    userErrorCatch = int.TryParse(userInput, out int userChoice3);
    string message = "";
    if (userErrorCatch == true)
    {
        message = Kitchen.RemoveKitchenStuff(userChoice3);
    }
    else
    {
        message = "Använd endast siffror";
    }
    return message;
}

string CheckUserChoice(string userInput)
{
    bool userErrorCatch = false;
    userErrorCatch = int.TryParse(userInput, out int userChoice3);
    string message = "";
    if (userErrorCatch == true)
    {
        message = Kitchen.Use(userChoice3);
    }
    else
    {
        message = "Använd endast siffror";
    }
    return message;

}
