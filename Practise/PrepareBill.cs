using System.ComponentModel;

namespace Question3
{
    public enum CommodityCategory
    {
        Furniture,

        Grocery,

        Service
    };

    public class Commidity
    {
        public CommodityCategory Category;
        public string CommidityName;
        public int CommidityQuantity;
        public double CommidityPrice;

        public Commidity(CommodityCategory category, string commidityname, int commidityquantity, double commidityprice)
        {
            this.Category = category;
            this.CommidityName = commidityname;
            this.CommidityQuantity = commidityquantity;
            this.CommidityPrice = commidityprice;
        }
    }

    class PrepareBill
    {
        private readonly IDictionary<CommodityCategory,double> _taxRates;

        public PrepareBill()
        {
         _taxRates=new Dictionary<CommodityCategory,double>();   
        }
        public void SetTaxRates(CommodityCategory category,double taxRate)
        {
            if (!_taxRates.ContainsKey(category))
            {
                _taxRates[category]=taxRate;
            }
        }
        public double CalculateBillAmount(IList<Commidity> items)
        {
            double total=0.0;

            foreach(var item in items)
            {
                if (!_taxRates.ContainsKey(item.Category))
                {
                    throw new ArgumentException("Category not Found");
                }
                else
                {
                    double tax=_taxRates[item.Category];
                    double price=(item.CommidityQuantity*item.CommidityPrice);
                    total+= price + price*tax/100;
                }
            }
            return total;
        }
    }
}