using System;
using WiredBrainCoffeeSurveys.Reports.Services;

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

                if (selectedReport == "exit")
                {
                    exitApp = true;
                    break;
                }
                Console.WriteLine("Please select which quater of data: (Q1, Q2)");
                var selectedFile = Console.ReadLine();

                var surveyResults = SurveyDataService.GetSurveyDataByFileName(selectedFile);

                switch (selectedReport)
                {
                    case "rewards":
                        RewardsReportService.GenerateWinnerEmails(surveyResults);
                        break;
                    case "comments":
                        CommentsReportService.GenerateCommentsReport(surveyResults);
                        break;
                    case "tasks":
                        TasksReportService.GenerateTasksReport(surveyResults);
                        break;
                    default:
                        Console.WriteLine("Sorry, that's not a valid option.");
                        break;
                }
                Console.WriteLine();

            } while (!exitApp);

        }
    }
}
