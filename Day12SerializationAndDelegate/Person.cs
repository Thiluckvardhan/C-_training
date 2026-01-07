namespace Day12
{
    public class Person
    {
        public string Name { get; set; }      // Will become <Name>...</Name>
        public int Age { get; set; }          // Will become <Age>...</Age>

        // An integer array to store marks.
        // This will become a repeated XML element list.
        // public int[] Marks { get; set; }      // Will become <Marks><int>..</int></Marks>
        public List<int> Marks { get; set; } // Marks in list form instead of array

    }

}


