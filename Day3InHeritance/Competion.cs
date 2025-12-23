namespace Day3
{
    public class Competion{
    int Com_Id;
    String Com_Name;

    public Competion()
    {
        Com_Id=0;
        Com_Name=String.Empty;
    }

    public String GetDetails()
    {
        return "Id "+Com_Id+"Name "+Com_Name;
    }
}
}