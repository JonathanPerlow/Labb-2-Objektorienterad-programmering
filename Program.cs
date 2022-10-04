using Labb_2___Objektorienterad_programmering;
//Kitchen TestPrint = new Kitchen();
////TestPrint.PrintList();
//TestPrint.AddKitchenStuff("VåffelHjärn", "Electrolux", false);
//TestPrint.PrintList();
//TestPrint.RemoveKitchenStuff(1);
//TestPrint.PrintList();
//TestPrint.RemoveKitchenStuff(2);
//TestPrint.PrintList();


Kitchen Kitchen = new Kitchen();
bool run = true;
string type;
string name;
string working;
bool usererrorcatch1;
bool usererrorcatch2;
bool usererrorcatch3;
bool usererrorcatch4;



while (run)
{

    Console.WriteLine(Kitchen.Menu());
    usererrorcatch1 = int.TryParse(Console.ReadLine(), out int userInput);
    if (usererrorcatch1 == true)
    {
        switch (userInput)
        {
            case 1:
                Console.WriteLine("Välj köksapparat: ");
                Console.WriteLine(Kitchen.PrintList());
                Console.Write("Ange val: \n>");
                usererrorcatch2 = int.TryParse(Console.ReadLine(), out int userChoice2);
                //userChoice = GetUserChoice();
                if (usererrorcatch2 == true)
                {
                    Console.WriteLine(Kitchen.Use(userChoice2));
                }
                else
                {
                    Console.WriteLine("Använd endast siffror");
                }
                break;
            case 2:
                Console.Write("Ange typ: \n>");
                type = Console.ReadLine();
                Console.Write("Ange namn: \n");
                name = Console.ReadLine();
                Console.Write("Ange om den fungerar (j/n)\n>");
                working = Console.ReadLine();
                Kitchen.AddKitchenStuff(type, name, working);
                break;
            case 3:
                Console.WriteLine(Kitchen.PrintList());
                break;
            case 4:
                Console.WriteLine("Välj köksapparat: ");
                Console.WriteLine(Kitchen.PrintList());
                Console.Write("Ange val: \n>");
                usererrorcatch3 = int.TryParse(Console.ReadLine(), out int userChoice3);
                Kitchen.RemoveKitchenStuff(userChoice3);
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
        //userInput.GetType();
        Console.WriteLine($"Använd endast siffror!");
    }

}
