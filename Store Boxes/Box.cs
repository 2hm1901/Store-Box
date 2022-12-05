using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Boxes
{
    public class Box
    {
        private int serialNumber;
        private Item item;
        private int itemQuantity;
        private double priceBox;
        public int SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public double PriceBox { get; set; }
        public Box()
        {
            Item = new Item();
        }

        public Box(int serialNumber, Item item, int itemQuantity, double priceBox)
        {
            SerialNumber = serialNumber;
            Item = item;
            ItemQuantity = itemQuantity;
            PriceBox = priceBox;
        }
    }
}
