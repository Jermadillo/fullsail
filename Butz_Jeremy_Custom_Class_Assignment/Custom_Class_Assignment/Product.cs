﻿using System;
namespace Custom_Class_Assignment
{
    public class Product
    {


        //these are my member variables.
        string mItemName;
        decimal mCostToMake;
        decimal mSellingPrice;


        //this is my constructor function
        public Product(string _ItemName, decimal _CostToMake, decimal _SellingPrice)
        {
            mItemName = _ItemName;
            mCostToMake = _CostToMake;
            mSellingPrice = _SellingPrice;




        }
        //Getters that return the information from where it was called

        public string GetItemName()
        {
            return mItemName;
        }
        public decimal GetCostToMake()
        {
            return mCostToMake;
        }
        public decimal GetSellingPrice()
        {
            return mSellingPrice;

        }

        // This section covers all my setters with the included parameters

        public void SetItemName (string _ItemName)
        {
            //change the member varible and use the parameter
            this.mItemName = _ItemName;

        }
        public void SetCostToMake (decimal _CostToMake)
        {
            this.mCostToMake = _CostToMake;

        }
        public void SetSellingPrice (decimal _SellingPrice)
        {
            this.mSellingPrice = _SellingPrice;

        }


        //this is the function for the total profit of an item


        public decimal TotalProfit (decimal _TotalQuantity)
        {

            decimal profit = mSellingPrice - mCostToMake;
            return profit;
        }
        

    }


}
