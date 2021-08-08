﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BELayer
{
    public class Good
    {
        enum GoodType { Nutrition, Clothes, Communication, Cleaning, Infants, Pets};
        private int Id;
        private float price;
        private String Shop;
        private float Quantity;
        private string Picture { get; set; }
        private string Description { get; set; }
        private GoodType Type;
        private string Name { get; set; }


    }
}
