using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TheGenuisBubbleTea_GUI
{
    class Cart
    {
        FileManagement cartFile = new FileManagement(System.AppDomain.CurrentDomain.BaseDirectory + "/Cart/Cart.txt");
        FileManagement logfile = new FileManagement(System.AppDomain.CurrentDomain.BaseDirectory + "/Cart/logfile.txt");
        List<string> cart = new List<string>();
        int number = 1;
        string namewater;
        string pricewater;
        string toppping;
        string pricetopping;
        string sweetlevel;
        string size;
        string pricesize;
        string discount;
        string changemoney;

        public Cart()
        {
            
        }
        public Cart(string waterName, string waterPrice, string topping, string toppingPrice, string sweetLv, string size,string sizePrice)
        {
            this.namewater = waterName;
            this.pricewater = waterPrice;
            this.toppping = topping;
            this.pricetopping = toppingPrice;
            this.sweetlevel = sweetLv;
            this.size = size;
            this.pricesize = sizePrice;
        }
        public string Number
        {
            get { return number.ToString(); }
        }
        public string NameWater
        {
            get { return namewater; }
        }
        public string PriceWater
        {
            get { return pricewater; }
        }
        public string Topping
        {
            get { return toppping; }
        }
        public string PriceTopping
        {
            get { return pricetopping; }
        }
        public string SweetLevel
        {
            get { return sweetlevel; }
        }
        public string Size
        {
            get { return size; }
        }
        public string PriceSize
        {
            get { return pricesize; }
        }
        public void AddDrink(string itemName, string price)
        {
            this.namewater = itemName;
            this.pricewater = price;
            
            string drinkOrder = itemName + "," + price;

            cart.Add(drinkOrder);

            cartFile.WriteFile(cart);
        }

        public void AddTopping(string topping ,string pricetopping)
        {
            foreach (string i in cartFile.ReadFile())
            {
                if (i != "")
                {
                    string[] data = new string[2];
                    data = i.Split(',');
                    this.namewater = data[0];
                    this.pricewater = data[1];
                }


            }
            this.toppping = topping;
            this.pricetopping = pricetopping;
          


            string itemOrder = namewater + "," + pricewater + "," +topping + "," + pricetopping;

            cart.Add(itemOrder);
            cartFile.WriteFile(cart);
        }
        public void AddSweet(string sweet)
        {
            foreach (string i in cartFile.ReadFile())
            {
                if (i != "")
                {
                    string[] data = new string[4];
                    data = i.Split(',');
                    this.namewater = data[0];
                    this.pricewater = data[1];
                    this.toppping = data[2];
                    this.pricetopping = data[3];
                }


            }


            this.sweetlevel = sweet;

            string itemOrder = namewater + "," + pricewater + "," + toppping + "," + pricetopping + "," + sweet;

            cart.Add(itemOrder);
            cartFile.WriteFile(cart);
        }
        public void AddSize(string size ,string priceSize)
        {
            foreach (string i in cartFile.ReadFile())
            {
                if (i != "")
                {
                    string[] data = new string[5];
                    data = i.Split(',');
                    this.namewater = data[0];
                    this.pricewater = data[1];
                    this.toppping = data[2];
                    this.pricetopping = data[3];
                    this.sweetlevel = data[4];

                }


            }
            this.size = size;
            this.pricesize = priceSize;



            string itemOrder = namewater + "," + pricewater + "," + toppping + "," + this.pricetopping + "," + sweetlevel + "," +this.size + "," +pricesize;

            cart.Add(itemOrder);
            logfile.WriteAppendFile(cart);
            cartFile.WriteFile(cart);
        }

        public void AddCartToBill(string discount_, string changemoney_)
        {
            foreach (string i in cartFile.ReadFile())
            {
                if (i != "")
                {
                    string[] data = new string[7];
                    data = i.Split(',');
                    this.namewater = data[0];
                    this.pricewater = data[1];
                    this.toppping = data[2];
                    this.pricetopping = data[3];
                    this.sweetlevel = data[4];
                    this.size = data[5];
                    this.pricesize = data[6];
                }


            }
            this.discount = discount_;
            this.changemoney = changemoney_;



            string itemOrder = namewater + "," + pricewater + "," + toppping + "," + this.pricetopping + "," + sweetlevel + "," + this.size + "," + pricesize + "," +this.discount + "," +this.changemoney;

            cart.Add(itemOrder);
            logfile.WriteAppendFile(cart);
            cartFile.WriteFile(cart);
        }


        public List<string> LoadCart()
        {
            List<string> cartList = new List<string>();
            foreach (string i in cartFile.ReadFile())
            {
                string[] temp = new string[8];
                temp = i.Split(",");

                string itemName = temp[0];
                string itemPrice = temp[1];

                string itemCollect = itemName + "," + itemPrice + "/";
                cartList.Add(itemCollect);

            }
            return cartList;

        }
        public void AddCartToFile()
        {
            cartFile.WriteFile(cart);
        }
        public void ClearCart()
        {
            cart.Clear();
        }



    }
}
