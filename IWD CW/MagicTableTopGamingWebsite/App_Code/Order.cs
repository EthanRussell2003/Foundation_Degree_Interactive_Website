using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MagicTableTopGamingWebsite.App_Code
{
    public class Order
    {
        private string user;
        private double total;

        public Order() { 
        
        }

        public string getUser() {
            return this.user;
        }

        public double getTotal() {
            return this.total;
        }
        public void setUser(string user) {
            this.user = user;
        }

        public void setTotal(double total) {
            this.total = total;
        }
    }
}