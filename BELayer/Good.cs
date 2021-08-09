using System;
using System.Collections.Generic;
using System.Text;

namespace BELayer
{
    public class Good
    {
        enum GoodType { Nutrition, Clothes, Communication, Cleaning, Infants, Pets};
        private string Id;
        private float price;
        private string Shop;
        private float Quantity;
        private string Picture { get; set; }
        private string Description { get; set; }
        private GoodType Type;
        private string Name { get; set; }
        public string getID()
        {
            return Id;
        }
    }
}
