using System.Collections;
namespace Day18
{
    /// <summary>Holds yoga member health metrics and calculated BMI.</summary>
    public class MedicationCenter
    {
        public int MemberId { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public string? Goal { get; set; }
        public double BMI { get; set; }
    }
    
    /// <summary>Maintains yoga member list, computes BMI, and determines applicable fees and goals.</summary>
    public class Question4
    {
        public static ArrayList memberList=new();

        public void AddYogaMember(int memberId,int age,double weight,double height,string goal)
        {
            // Build a new member record with the provided metrics
            MedicationCenter medicationCenter=new();
            medicationCenter.MemberId=memberId;
            medicationCenter.Age=age;
            medicationCenter.Weight=weight;
            medicationCenter.Height=height;
            medicationCenter.Goal=goal;
            memberList.Add(medicationCenter);
        }
        public double CalculateBMI(int memberId)
        {
            double bmi=0.0;
            if (memberList.Count==0)
            {
                return -1;
            }
            // Compute BMI for the matching member and store it
            foreach(MedicationCenter item in memberList)
            {
                if (item.MemberId == memberId)
                {
                    item.BMI=item.Weight/(item.Height*item.Height);
                    bmi=item.BMI;
                }
            }
            return bmi;           
        }

        public int CalculateYogaFee(int memberId)
        {
            int cost=0;
            // Derive goal and fee based on calculated BMI brackets
            foreach(MedicationCenter item in memberList)
            {
                if (item.MemberId == memberId)
                {
                    if (25 <=item.BMI && item.BMI< 30)
                    {
                        item.Goal="Weight Loss";
                        cost=2000;
                        
                    }
                    else if (30 <= item.BMI && item.BMI< 35)
                    {
                        item.Goal="Weight Loss";
                        cost=2500;
                    }
                    else if (35 <= item.BMI)
                    {
                        item.Goal="Weight Loss";
                        cost=3000;
                    }

                    else
                    {
                        item.Goal="Weight Gain";
                        cost=2500;
                    }
                    break;
                }
            }
            return cost;
        }
    }
}