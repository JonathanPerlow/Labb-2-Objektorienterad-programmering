using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2___Objektorienterad_programmering
{
    internal class Kitchen
    {
        List<KitchenItem> KitchenItemList = new List<KitchenItem>();


        public Kitchen()
        {
            Random isWorking = new Random();
            isWorking.Next();
            KitchenItemList.Add(new KitchenItem(1, "Microwave oven", "Siemens"));
            KitchenItemList.Add(new KitchenItem(2, "Toaster", "Siemens"));
            KitchenItemList.Add(new KitchenItem(3, "Oven", "Bosch", false));
        }

        public string Use(int userChoice)
        {
            //try
            //{
            //    userChoice.GetType == typeof(int);
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
            string message = "";
            foreach (KitchenItem item in KitchenItemList)
            {
                // If the kitchen appliance is working and the user inputs matches the item id.
                if (item.IsFunctioning == true && item.Id == userChoice)
                {
                    message = $"Using {item.Type}.....";
                    //Console.WriteLine($"Using {item.Type}.....");
                }
                else if (item.IsFunctioning == false && item.Id == userChoice)
                {
                    message = $"{item.Type} is broken and needs to be repaired :(.";
                    //Console.WriteLine($"{item.Type} is broken and needs to be repaired :(.");
                }
            }
            return message;

        }


        public void AddKitchenStuff(string type, string brand, string isFunctioning)
        {
            bool check;
            int number = KitchenItemList.Count + 1;
            if(isFunctioning == "j")
            {
                //check = true;
                KitchenItemList.Add(new KitchenItem(number, type, brand, true));
            }
            else if(isFunctioning == "n")
            {
                KitchenItemList.Add(new KitchenItem(number, type, brand, false));
                //check = false;  
            }
            //return new KitchenItem(number, type, brand, check);
        }

        public void RemoveKitchenStuff(int number)
        {
            //number--;
            foreach (KitchenItem item in KitchenItemList.ToList())
            {
                if(item.Id == number)
                {
                    KitchenItemList.Remove(item);
                    
                }
                //if (item.Id != 1)
                //{

                //}


            }
            //KitchenItemList.RemoveAt(number - 1);
        }


        public string PrintList()
        {
            string message = "";
            foreach (KitchenItem item in KitchenItemList)
            {
                message += $"{item.Id}: {item.Type}\n";
                
            }
            return message;
        }

        public string Menu()
        {
            return          "-----------KÖKET-----------\n" +
                            "1. Använd köksapparat\n" +
                            "2. Lägg till köksapparat\n" +
                            "3. Lista köksapparater\n" +
                            "4. Ta bort köksapparat\n" +
                            "5: Avsluta\n" +
                            "Ange val:\n" +
                            ">";
            
        }

        public void ErrorHandler( )
        {

        }


    }
}
