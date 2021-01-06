using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TheGenuisBubbleTea_GUI
{
    class Beverage
    {
        public Cart cart = new Cart();
        private string filename;
        string bevName;
        string bevPrice;
        string toppping;
        string pricetopping;
        string sweetlevel;
        string size;
        string pricesize;
        string discount;
        string changemoney;

        public Beverage(string filename)
        {
            this.filename = filename;
        }

        public string Name { get; set; }
        public string Value { get; set; }

        public Beverage()
        {

        }
        public Beverage(string name, string value)
        {
            Name = name;
            Value = value;
        }
        public void AddDrinkToCart(List<string> itemList, string itemName)
        {
            foreach (string i in itemList)
            {
                string[] temp = new string[2];
                temp = i.Split(",");
                 this.bevName = temp[0];
                 this.bevPrice = temp[1];

                if (bevName == itemName)
                {
                    cart.AddDrink(bevName, bevPrice);
                    break;
                }
            }
        }
        public void AddToppingToCart(List<string> itemList,string itemName)
        {
            foreach (string i in itemList)
            {
                string[] temp = new string[2];
                temp = i.Split(",");

                toppping = temp[0];
                pricetopping = temp[1];

                if (toppping == itemName)
                {
                    cart.AddTopping(toppping, pricetopping);
                    break;
                }
            }
        }
        public void AddSweetToCart(List<string> itemList, string itemName)
        {
            foreach (string i in itemList)
            {
                string[] temp = new string[0];
                temp = i.Split(",");

                sweetlevel = temp[0];

                if (sweetlevel == itemName)
                {
                    cart.AddSweet(sweetlevel);
                    break;
                }
            }
        }
        public void AddSizeToCart(List<string> itemList, string itemName)
        {
            foreach (string i in itemList)
            {
                string[] temp = new string[2];
                temp = i.Split(",");

                size = temp[0];
                pricesize = temp[1];

                if (size == itemName)
                {
                    cart.AddSize(size, pricesize);
                    break;
                }
            }
        }
        public void AddCartToBill(string discount, string changemoney)
        {

            cart.AddCartToBill(discount, changemoney);

        }

        public void ShowDetail()
        {
            foreach (string i in ReadFile())
            {
                if (i != "")
                {
                    string[] data = new string[2];
                    data = i.Split(',');
                    Name = data[0];
                    Value = data[1];
                }
            }
            Console.WriteLine("{0}\t {1}\t {2}", Name, Value);
        }

        public List<string> ReadFile()
        {
            List<string> content = new List<string>();
            StreamReader streamReader = new StreamReader(filename);
            string line = streamReader.ReadLine();
            while (line != null)
            {
                content.Add(line);
                line = streamReader.ReadLine();
            }
            streamReader.Close();
            return content;
        }
    }
}
