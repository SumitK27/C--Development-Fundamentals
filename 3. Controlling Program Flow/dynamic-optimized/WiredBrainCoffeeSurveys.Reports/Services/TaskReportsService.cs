using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiredBrainCoffeeSurveys.Reports.Services
{
    public static class TasksReportService
    {
        public static void GenerateTasksReport(SurveyResults results)
        {
            // Calculated values
            double responseRate = results.NumberResponded / results.NumberSurveyed;
            double overallScore = (results.CoffeeScore + results.FoodScore + results.FoodScore + results.PriceScore) / 4;

            // Selection Statements
            var tasks = new List<string>();

            if (results.CoffeeScore < results.FoodScore)
            {
                tasks.Add("Investigate coffee recipe and ingredients.");
            }

            tasks.Add(overallScore > 8 ? "Work with leadership to award the staff." : "Work with employees to improve ideas.");

            tasks.Add(responseRate switch
            {
                var rate when rate < 0.33 => "Research options to improve response rate.",
                var rate when rate > 0.33 && rate < 0.66 => "Reward participants with free coffee coupon.",
                var rate when rate > 0.66 => "Rewards participants with discount coffee coupon."
            });

            tasks.Add(results.AreaToImprove switch
            {
                "RewardsProgram" => "Revisit the rewards deals.",
                "Cleanliness" => "Contact the cleaning vendor",
                "MobileApp" => "Contact the consulting firm about the app.",
                _ => "Investigate individual comments for ideas."
            });

            Console.WriteLine(Environment.NewLine + "Tasks Output:");
            foreach (var task in tasks)
            {
                Console.WriteLine(task);
            }

            File.WriteAllLines("TasksReport.csv", tasks);
        }
    }
}
