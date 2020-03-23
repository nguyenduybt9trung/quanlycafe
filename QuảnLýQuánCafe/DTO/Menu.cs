using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuảnLýQuánCafe.DTO
{
   public class Menu
    {
        public Menu(int count,float price, string foodName, float totalPrice = 0)
        {
            this.TotalPrice = totalPrice;
            this.Price = price;
            this.Count = count;
            this.FoodName = foodName;
        }

        public Menu(DataRow row)
        {
            this.TotalPrice = (float)Convert.ToDouble(row["totalPrice"].ToString());
            this.Price =(float)Convert.ToDouble(row ["price"].ToString());
            this.Count =(int)row["count"];
            this.FoodName = row["Name"].ToString();
        }

        private float totalPrice;
        public float TotalPrice 
        { 
            get => totalPrice;
            set => totalPrice = value; 
        }

        private float price;
        public float Price 
        { 
            get => price; 
            set => price = value;
        }

        private int count;
        public int Count 
        {
            get => count;
            set => count = value;
        }


        private string foodName;
        public string FoodName 
        { 
            get => foodName; 
            set => foodName = value; 
        }
        
    }
}
