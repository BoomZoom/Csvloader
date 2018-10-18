using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    public class Product
    {
        public int Id { get; set; }
        public int ProviderId { get; set; }
        public int CattegoryId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public DateTime DateCreationTime { get; set; }
        public DateTime DateUpdateTime { get; set; }

    }
}
