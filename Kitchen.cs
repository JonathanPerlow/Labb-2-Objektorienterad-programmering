namespace Labb_2
{
    internal class Kitchen
    {
        List<KitchenItem> KitchenItemList = new List<KitchenItem>();
        public int ListCount
        {
            get
            {
                return KitchenItemList.Count;
            }
        }

        public enum AllowedTypes
        {
            Våffeljärn,
            Mixer,
            Vattenkokare,
            Brödrost,
            Kaffebryggare,
            Mikrovågsugn,
            Toaster,
            Ugn
        }

        public enum AllowedBrand
        {
            OBHNordica,
            Philips,
            Electrolux,
            Champion,
            Bosch,
            Siemens,
        }

        public enum AllowedWorking
        {
            j,
            n
        }


        public Kitchen()
        {
            KitchenItemList.Add(new KitchenItem(1, "Mikrovågsugn", "Siemens"));
            KitchenItemList.Add(new KitchenItem(2, "Toaster", "Siemens"));
            KitchenItemList.Add(new KitchenItem(3, "Ugn", "Bosch", false));
        }

        public string Use(int userChoice)
        {

            string message = "";
            foreach (KitchenItem item in KitchenItemList)
            {
                if(item.Id == userChoice)
                {
                    if (item.IsFunctioning == true)
                    {
                        message = $"Använder {item.Type}.....";
                    }
                    else if (item.IsFunctioning == false)
                    {
                        message = $"{item.Type} är trasig och behöver repareras :(.";
                    }
                    return message;
                }
            }
            return  "Ditt val finns inte"; 

        }


        public void AddKitchenStuff(string type, string brand, string isFunctioning)
        {
            int number = KitchenItemList.Count + 1;

            if (isFunctioning == "j")
            {
                KitchenItemList.Add(new KitchenItem(number, type, brand, true));
            }

            else if (isFunctioning == "n")
            {
                KitchenItemList.Add(new KitchenItem(number, type, brand, false));
            }
        }

        public bool CheckValidOption(string type, string brand, string working)
        {
            bool result1 = false;
            bool result2 = false;
            bool result3 = false;

            foreach (object item in Enum.GetValues(typeof(AllowedTypes)))
            {
                if (item.ToString() == type)
                {
                    result1 = true;
                }
            }
            foreach (object item in Enum.GetValues(typeof(AllowedBrand)))
            {
                if (item.ToString() == brand)
                {
                    result2 = true;
                }
            }
            foreach (object item in Enum.GetValues(typeof(AllowedWorking)))
            {
                result3 = true;
            }

            if (result1 == true && result2 == true && result3 == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string RemoveKitchenStuff(int number)
        {
            if (KitchenItemList.Count == 0)
            {
                return "Listan är tom";
            }

            foreach (KitchenItem item in KitchenItemList.ToList())
            {
                if (item.Id == number)
                {
                    KitchenItemList.Remove(item);
                    return $"{item.Type} är bortaget";
                }
            }

            return "Ditt val finns inte";
        }



        public string PrintList()
        {
            string message = "";
            foreach (KitchenItem item in KitchenItemList)
            {
                if (item.IsFunctioning == true)
                {
                    message += $"{item.Id}: Din {item.Type} är av märket {item.Brand} och är i godkänt skick\n";
                }
                else
                {
                    message += $"{item.Id}: Din {item.Type} är av märket {item.Brand} och är ej i godkänt skick\n";
                }
            }
            return message;
        }

        public string TypesMenu()
        {
            string message = "Tillåtna typer är:";
            foreach (object item in Enum.GetValues(typeof(AllowedTypes)))
            {
                message += $"\n{item}";
            }
            return message;
        }

        public string BrandMenu()
        {
            string message = "Tillåtna typer är";
            foreach (object item in Enum.GetValues(typeof(AllowedBrand)))
            {
                message += $"\n{item}";
            }
            return message;
        }

        public string SubMenu()
        {
            string menuMessage = "";
            foreach (KitchenItem item in KitchenItemList)
            {
                menuMessage += $"{item.Id}: {item.Type}\n";
            }
            return menuMessage;
        }

        public string Menu()
        {
            return "-----------KÖKET-----------\n" +
                            "1. Använd köksapparat\n" +
                            "2. Lägg till köksapparat\n" +
                            "3. Lista köksapparater\n" +
                            "4. Ta bort köksapparat\n" +
                            "5: Avsluta\n" +
                            "Ange val:\n" +
                            ">";

        }

    }
}
