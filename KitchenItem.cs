using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2___Objektorienterad_programmering
{
    internal class KitchenItem : IKitchenAppliance
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Brand { get; set; }
        
        public bool IsFunctioning { get; set; }

        public KitchenItem(int id, string type, string brand, bool isFunctioning = true)
        {
            Id = id;
            Type = type;
            Brand = brand;
            IsFunctioning = isFunctioning;
        }
    }
}
