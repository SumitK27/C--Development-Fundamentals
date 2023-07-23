using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace WiredBrainCoffeeSurveys.Reports
{
  class Program
  {
    static void Main(string[] args)
    {
      bool exitApp = false;

      do
      {
        Console.WriteLine("Please specify a report to run (rewards, comments, tasks, exit)");
        var selectedReport = Console.ReadLine();

        switch (selectedReport)
        {
          case "rewards":
            GenerateWinnerEmails();
            break;
          case "comments":
            GenerateCommentsReport();
            break;
          case "tasks":
            GenerateTasksReport();
            break;
          case "exit":
            exitApp = true;
            break;
          default:
            Console.WriteLine("Sorry, that's not a valid option.");
            break;
        }

        Console.WriteLine();
      } while (!exitApp);

    }

    public static void GenerateWinnerEmails()
    {
      var selectedEmails = new List<string>();
      int counter = 0;

      Console.WriteLine(Environment.NewLine + "Selected Winners Output:");
      while (selectedEmails.Count < 2 && counter < Q1Results.Responses.Count)
      {
        var currentItem = Q1Results.Responses[counter];

        if (currentItem.FavoriteProduct == Q1Results.FavoriteProduct)
        {
          selectedEmails.Add(currentItem.EmailAddress);
          Console.WriteLine(currentItem.EmailAddress);
        }

        counter++;
      }

      File.WriteAllLines("WinnersReport.csv", selectedEmails);
    }

    public static void GenerateCommentsReport()
    {
      var comments = new List<string>();

      Console.WriteLine(Environment.NewLine + "Comments Output:");
      for (var i = 0; i < Q1Results.Responses.Count; i++)
      {
        var response = Q1Results.Responses[i];

        if (response.WouldRecommend < 7.0)
        {
          Console.WriteLine(response.Comments);
          comments.Add(response.Comments);
        }
      }

      foreach (var response in Q1Results.Responses)
      {
        if (response.AreaToImprove == Q1Results.AreaToImprove)
        {
          Console.WriteLine(response.Comments);
          comments.Add(response.Comments);
        }
      }

      File.WriteAllLines("CommentsReport.csv", comments);
    }

    public static void GenerateTasksReport()
    {
      // Calculated values
      double responseRate = Q1Results.NumberResponded / Q1Results.NumberSurveyed;
      double unansweredCount = Q1Results.NumberSurveyed - Q1Results.NumberResponded;
      double overallScore = (Q1Results.CoffeeScore + Q1Results.FoodScore + Q1Results.FoodScore + Q1Results.PriceScore) / 4;

      Console.WriteLine($"Response Percentage: {responseRate}");
      Console.WriteLine($"Unanswered Surveys : {unansweredCount}");
      Console.WriteLine($"Overall Score {overallScore}");

      // Logical comparision
      bool higherCoffeeScore = Q1Results.CoffeeScore > Q1Results.FoodScore;
      bool customerRecommended = Q1Results.WouldRecommend >= 7;
      bool noGranolaYesCappucino = Q1Results.LeastFavoriteProduct == "Granola" && Q1Results.FavoriteProduct == "Cappucino";

      Console.WriteLine($"Coffee Score Higher Than Food: {higherCoffeeScore}");
      Console.WriteLine($"Customers Would Recommend Us: {customerRecommended}");
      Console.WriteLine($"Hate Granola, Love Cappucino: {noGranolaYesCappucino}");

      // Selection Statements
      var tasks = new List<string>();

      if (Q1Results.CoffeeScore < Q1Results.FoodScore)
      {
        tasks.Add("Investigate coffee recipe and ingredients.");
      }

      if (overallScore > 8)
      {
        tasks.Add("Work with leadership to award the staff.");
      }
      else
      {
        tasks.Add("Work with employees to improve ideas.");
      }

      if (responseRate < 0.33)
      {
        tasks.Add("Research and improve the response rate.");
      }
      else if (responseRate >= 0.33 && responseRate <= 0.66)
      {
        tasks.Add("Collect your free coffee coupon.");
      }
      else
      {
        tasks.Add("Collect your discount coffee coupons.");
      }

      switch (Q1Results.AreaToImprove)
      {
        case "RewardsProgram":
          tasks.Add("Revisit the reward deal.");
          break;
        case "Cleanliness":
          tasks.Add("Contact the cleaning vendor.");
          break;
        case "MobileApp":
          tasks.Add("Contact consulting firm about app.");
          break;
        default:
          tasks.Add("Investigate the individual comments for ideas.");
          break;
      }

      Console.WriteLine(Environment.NewLine + "Tasks Output:");
      foreach (var task in tasks)
      {
        Console.WriteLine(task);
      }

      File.WriteAllLines("TasksReport.csv", tasks);
    }
  }
}
