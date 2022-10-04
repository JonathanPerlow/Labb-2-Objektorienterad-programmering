using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2___Objektorienterad_programmering
{
    internal interface IKitchenAppliance
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Brand { get; set; }
        
        public bool IsFunctioning { get; set; }
    }
}
