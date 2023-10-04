using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MagicTableTopGamingWebsite.App_Code
{
    public class CartItem
    {

        private string itemName = null;
        private double cost = 0;


        public CartItem()
        {

        }

        public string getItemName()
        {
            return this.itemName;
        }

        public void setItemName(string itemName)
        {
            this.itemName = itemName;
        }

        public double getCost()
        {
            return this.cost;
        }

        public void setCost(double cost)
        {
            this.cost = cost;
        }
    }
}