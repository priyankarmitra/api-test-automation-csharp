
namespace VerivoxTestApiProject.Support
{
    public class JsonBuilders
    {
        public static List<string> GetListOfCityOrStreet(RestResponse response, string nodeName)
        {
            try
            {
                JToken apiResponseJson = JToken.Parse(response.Content);
                JArray streetsArray = (JArray)apiResponseJson[nodeName];
                return streetsArray.ToObject<List<string>>();
            }
            catch (Exception ex)
            {
                Assert.Fail("Error: " + ex.Message);
            }

            return null;
        }

        public static int GetNoOfCitiesOrStreets(RestResponse response, string nodeName)
        {
            try
            {
                JToken apiResponseJson = JToken.Parse(response.Content);
                JArray streetsArray = (JArray)apiResponseJson[nodeName];
                return streetsArray.Count;
            }
            catch (Exception ex)
            {
                Assert.Fail("Error: " + ex.Message);
            }

            return 0;
        }
    }
}
