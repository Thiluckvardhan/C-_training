using System;

namespace Day2
{
    /// <summary>
    /// This class calculates profit or loss percentage based on Cost Price and Selling Price.
    /// Formula: 
    /// Profit/Loss = Selling Price - Cost Price
    /// Profit/Loss Percentage = (Profit/Loss / Cost Price) * 100
    /// </summary>
    public class ProfitorLoss
    {
        #region Functionality
        /// <summary>
        /// Reads cost and selling prices and prints profit/loss and percentage.
        /// </summary>
        /// <remarks>
        /// Handles division-by-zero by reporting 0% when cost price is 0.
        /// </remarks>
        public static void CalculateAndDisplayResult()
        {
            #region Declarations
            double costPrice, sellingPrice, profit, profitPercentage;
            #endregion

            #region Code Functionality
            Console.Write("Enter Cost Price: Rs. ");
            costPrice = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Selling Price: Rs. ");
            sellingPrice = Convert.ToDouble(Console.ReadLine());

            profit = sellingPrice - costPrice;
            profitPercentage = (costPrice == 0) ? 0 : (profit / costPrice) * 100;

            Console.WriteLine($"\nCost Price: Rs. {costPrice}");
            Console.WriteLine($"Selling Price: Rs. {sellingPrice}");
            Console.WriteLine($"Profit/Loss: Rs. {profit}");
            Console.WriteLine($"Profit/Loss Percentage: {profitPercentage:F2}%");
            Console.WriteLine($"Status: {(profit > 0 ? "PROFIT" : profit < 0 ? "LOSS" : "NO PROFIT NO LOSS")}");
            #endregion
        }
        #endregion
    }
}
