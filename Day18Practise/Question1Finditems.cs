namespace Day18
{
    public class Question1
    {
        public static SortedDictionary<string, long> itemDetails = new SortedDictionary<string, long>
        {
            { "Pen", 120 },
            { "Pencil", 80 },
            { "Notebook", 200 },
            { "Eraser", 50 },
            { "Marker", 150 }
        };

        public SortedDictionary<string, long> FindItemDetails(long soldCount)
        {
            SortedDictionary<string, long> sd = new();
            foreach (var item in itemDetails)
            {
                if (item.Value == soldCount)
                {
                    sd.Add(item.Key, item.Value);
                }
            }
            return sd;
        }

        public List<string> FindMinandMaxSoldItems()
        {
            long mini = int.MaxValue;
            long maxi = int.MinValue;
            string minkey = "";
            string maxkey = "";
            List<string> list = new();

            foreach (var item in itemDetails)
            {
                if (item.Value < mini)
                {
                    mini = item.Value;
                    minkey = item.Key;
                }
                else if (item.Value > maxi)
                {
                    maxi = item.Value;
                    maxkey = item.Key;
                }
            }
            list.Add(minkey);
            list.Add(maxkey);

            return list;
        }


        public Dictionary<string, long> SortByCount()
        {
            SortedDictionary<long, string> sd = new();
            Dictionary<string, long> dictionary = new();
            foreach (var item in itemDetails)
            {
                sd.Add(item.Value, item.Key);
            }

            foreach (var item in sd)
            {
                dictionary.Add(item.Value, item.Key);
            }
            return dictionary;
        }
    }
}