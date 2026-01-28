// namespace Day22
// {
//     public class Program
//     {
//         public static void Main(string[] args)
//         {
//             //obsolete Attribute Example
//             ObsoleteAttributeExample oa=new();
//             Console.WriteLine(oa.OldAdd(5,3));  // obsolete just gives a warning for the developers, if we use it anyway it will run
//             Console.WriteLine(oa.Add(5,3));
//         }
//     }
// }

// File: ParkingFeeCalculator.cs
using System;
using System.Collections.Generic;

class ParkingFeeCalculator
{
    static void Main()
    {
        Console.WriteLine("=== PARKING FEE CALCULATOR ===\n");
        
        // Sample data: VehicleType, Hours
        List<(char, double)> parkingRecords = new List<(char, double)>
        {
            ('C', 2.5),     // Car, 2.5 hours
            ('C', 12.0),    // Car, 12 hours (max fee applies)
            ('M', 4.0),     // Motorcycle, 4 hours
            ('T', 6.5),     // Truck, 6.5 hours
            ('C', 0.25),    // Car, 15 minutes (free)
            ('M', 10.0)     // Motorcycle, 10 hours (discount)
        };
        
        foreach (var record in parkingRecords)
        {
            CalculateAndDisplayFee(record.Item1, record.Item2);
            Console.WriteLine("------------------------");
        }
    }
    
    static void CalculateAndDisplayFee(char vehicleType, double hours)
    {
        double hourlyRate = GetHourlyRate(vehicleType);
        double dailyMax = GetDailyMaximum(vehicleType);
        string vehicleName = GetVehicleName(vehicleType);
        
        double fee = CalculateParkingFee(hours, hourlyRate, dailyMax);
        
        Console.WriteLine($"Vehicle: {vehicleName}");
        Console.WriteLine($"Parking Duration: {hours:F2} hours");
        Console.WriteLine($"Hourly Rate: ${hourlyRate:F2}");
        Console.WriteLine($"Daily Maximum: ${dailyMax:F2}");
        Console.WriteLine($"Total Fee: ${fee:F2}");
    }
    
    static double CalculateParkingFee(double hours, double hourlyRate, double dailyMax)
    {
        // First 30 minutes free
        // double fee=0.0;
        // double minutes=hours*0.6;
        // if(minutes<=30.0){
        //  return fee;
        // }
        // // Remove first 30 minutes from calculation
        // double days=hours/24.0;
        // hours=hours%24.0;
        // minutes=minutes-30;
        // hours=minutes/60;
        // minutes=minutes%60;
        // fee+=(hours*hourlyRate)+(minutes*(hourlyRate/60));
        // fee+=days*dailyMax;
        // return fee;

        double fee=0.0;
        if(hours<=0.5){
            return fee;
        }

        hours=hours-0.5;
        int days=(int)(hours/24.0);
        hours=hours%24.0;
        fee+=(days*dailyMax);
        fee+=(hours*hourlyRate);

        if(days>=1|| hours>8.0){
            return fee-fee*0.1;
        }
        return fee;
        
    }
    
    static double GetHourlyRate(char vehicleType)
    {
        return vehicleType switch
        {
            'C' => 3.00,  // Car
            'M' => 2.00,  // Motorcycle
            'T' => 5.00,  // Truck
            _ => 0.00
        };
    }
    
    static double GetDailyMaximum(char vehicleType)
    {
        return vehicleType switch
        {
            'C' => 25.00,  // Car
            'M' => 15.00,  // Motorcycle
            'T' => 40.00,  // Truck
            _ => 0.00
        };
    }
    
    static string GetVehicleName(char vehicleType)
    {
        return vehicleType switch
        {
            'C' => "Car",
            'M' => "Motorcycle",
            'T' => "Truck",
            _ => "Unknown"
        };
    }
}