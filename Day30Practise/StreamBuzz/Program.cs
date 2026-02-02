using System;
using System.Collections.Generic;
using System.Linq;

#region Models

/// <summary>
/// Represents statistics for a content creator on StreamBuzz.
/// </summary>
public class CreatorStats
{
    public string CreatorName { get; set; }
    public double[] WeeklyLikes { get; set; }
    
    public static List<CreatorStats> EngagementBoard { get; set; } = new List<CreatorStats>();
}

#endregion

/// <summary>
/// Main program for managing creator engagement and analytics on StreamBuzz.
/// </summary>
public class Program
{
    #region Creator Management

    /// <summary>
    /// Registers a new creator to the engagement board.
    /// </summary>
    /// <param name="record">The creator statistics to register</param>
    public void RegisterCreator(CreatorStats record)
    {
        CreatorStats.EngagementBoard.Add(record);
    }

    #endregion

    #region Analytics

    /// <summary>
    /// Gets the count of posts exceeding the like threshold for each creator.
    /// </summary>
    /// <param name="records">List of creator statistics to analyze</param>
    /// <param name="likeThreshold">The minimum number of likes required</param>
    /// <returns>Dictionary with creator names and their top post counts</returns>
    public Dictionary<string, int> GetTopPostCounts(List<CreatorStats> records, double likeThreshold)
    {
        Dictionary<string, int> result = new Dictionary<string, int>();
        
        foreach (var creator in records)
        {
            int count = 0;
            foreach (var likes in creator.WeeklyLikes)
            {
                if (likes >= likeThreshold)
                {
                    count++;
                }
            }
            
            if (count > 0)
            {
                result[creator.CreatorName] = count;
            }
        }
        
        return result;
    }

    /// <summary>
    /// Calculates the average weekly likes across all creators.
    /// </summary>
    /// <returns>The average number of likes per week</returns>
    public double CalculateAverageLikes()
    {
        if (CreatorStats.EngagementBoard.Count == 0)
        {
            return 0;
        }
        
        double totalLikes = 0;
        int totalWeeks = 0;
        
        foreach (var creator in CreatorStats.EngagementBoard)
        {
            foreach (var likes in creator.WeeklyLikes)
            {
                totalLikes += likes;
            }
            totalWeeks += creator.WeeklyLikes.Length;
        }
        
        return totalWeeks > 0 ? totalLikes / totalWeeks : 0;
    }

    #endregion

    #region Entry Point

    /// <summary>
    /// Entry point of the application. Displays menu and handles user interactions.
    /// </summary>
    /// <param name="args">Command-line arguments</param>
    public static void Main(string[] args)
    {
        Program program = new Program();
        bool running = true;

        while (running)
        {
            Console.WriteLine("1. Register Creator");
            Console.WriteLine("2. Show Top Posts");
            Console.WriteLine("3. Calculate Average Likes");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Enter your choice:");
            
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Enter Creator Name:");
                    string creatorName = Console.ReadLine();
                    
                    Console.WriteLine("Enter weekly likes (Week 1 to 4):");
                    double[] weeklyLikes = new double[4];
                    
                    for (int i = 0; i < 4; i++)
                    {
                        weeklyLikes[i] = double.Parse(Console.ReadLine());
                    }
                    
                    CreatorStats newCreator = new CreatorStats
                    {
                        CreatorName = creatorName,
                        WeeklyLikes = weeklyLikes
                    };
                    
                    program.RegisterCreator(newCreator);
                    Console.WriteLine("Creator registered successfully");
                    Console.WriteLine();
                    break;

                case "2":
                    Console.WriteLine("Enter like threshold:");
                    double threshold = double.Parse(Console.ReadLine());
                    
                    Dictionary<string, int> topPosts = program.GetTopPostCounts(CreatorStats.EngagementBoard, threshold);
                    
                    if (topPosts.Count == 0)
                    {
                        Console.WriteLine("No top-performing posts this week");
                    }
                    else
                    {
                        foreach (var entry in topPosts)
                        {
                            Console.WriteLine($"{entry.Key} - {entry.Value}");
                        }
                    }
                    Console.WriteLine();
                    break;

                case "3":
                    double average = program.CalculateAverageLikes();
                    Console.WriteLine($"Overall average weekly likes: {average}");
                    Console.WriteLine();
                    break;

                case "4":
                    Console.WriteLine("Logging off - Keep Creating with StreamBuzz!");
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    Console.WriteLine();
                    break;
            }
        }
    }

    #endregion
}
