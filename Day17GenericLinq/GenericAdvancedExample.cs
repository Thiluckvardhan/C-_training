namespace Day17
{
    public class Student
    {
        public string? Name { get; set; }
        public int Id{get;set;}
    }
    public class UGStudent : Student
    {
        public int HighSchoolMarks { get; set; }
    }
    public class PGStudent : Student
    {
        public int UGMarks { get; set; }
    }
    public class MyGlobalType<T, K>
    {
        public string GetDataType(T t, K k)
        {
            return typeof(T).Name + typeof(K).Name;
        }
    }
}
