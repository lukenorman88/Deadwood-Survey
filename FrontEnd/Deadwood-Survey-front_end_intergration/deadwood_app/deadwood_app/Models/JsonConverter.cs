using Newtonsoft.Json;

namespace deadwood_app.Models
{
    /// <summary>
    /// Converts Survey to a JSON string
    /// </summary>
    public class JsonConverter
    {
        public static string Convert(Survey survey)
        {
            return JsonConvert.SerializeObject(survey);
        }
    }
}
