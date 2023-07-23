using Newtonsoft.Json;
using System.IO;

namespace WiredBrainCoffeeSurveys.Reports.Services
{
    class SurveyDataService
    {
        public static SurveyResults GetSurveyDataByFileName(string fileName)
        {
            return JsonConvert.DeserializeObject<SurveyResults>
                    (File.ReadAllText($"../../../Data/{fileName}.json"));
        }
    }
}