
using VerivoxTestApiProject.Services;
using VerivoxTestApiProject.Support;

namespace VerivoxTestApiProject.StepDefinitions
{
    [Binding]
    public class AddressCheckerStepDefinitions
    {
        private ApiServices apiService;
        private RestResponse response;
        private string resourcePath;

        public AddressCheckerStepDefinitions()
        {
            apiService = new ApiServices("https://service.verivox.de");
        }

        [Given(@"the address checking service endpoint: ""([^""]*)""")]
        public void GivenTheAddressCheckingServiceEndpoint(string endPoint)
        {
            resourcePath = endPoint;
        }

        /// <summary>
        /// Verifies that a response is returned when the GET CITIES service makes a request.
        /// </summary>
        /// <param name="postcode">Valid or Invalid German Postcodes</param>
        /// <task name="GetData"> A async Task that makes the GET service request and returns response</task>
        [When(@"I request the cities for postcode (.*)")]
        public async Task WhenIRequestTheCitiesForPostcode(string postcode)
        {
            string completeURI = $"{resourcePath}/{postcode.Replace("\"", "")}";
            try
            {
                response = await apiService.GetData(completeURI);
            }
            catch (Exception ex)
            {
                Assert.Fail($"Failed to recieve GET city response! {ex.Message}");
            }

        }

        /// <summary>
        /// Verifies that the service response contains the expected list of cities.
        /// </summary>
        /// <param name="expectedCitylists">A comma-separated string of expected city names.</param>
        /// <function name="GetListOfCityOrStreet"> Returns a list of city or streets having params as response Object and node name</function>
        [Then(@"I should receive a response with ""([^""]*)""")]
        public void ThenIShouldReceiveAResponseWith(string expectedCitylists)
        {

            try
            {
                if (response.IsSuccessStatusCode)
                {
                    //Trim White Spaces and select the city from the array, then convert to List of strings
                    var expectedCityLists = expectedCitylists.Split(',').Select(s => s.Trim()).ToList();
                    var actualCityLists = JsonBuilders.GetListOfCityOrStreet(response, "Cities");


                    CollectionAssert.AreEquivalent(expectedCityLists, actualCityLists, "The City List in service response do not match with the expected result!");
                }
            }
            catch (Exception ex)
            {
                Assert.Fail($"Error while validating the actual and expected list of city/cities! {ex.Message}");
            }

        }

        /// <summary>
        /// Verifies that the service request recieves data for success & no data for a failure in the response body.
        /// </summary>
        [Then(@"No JSON data is returned for HTTP error status")]
        public void ThenNoJSONDataIsReturnedForHTTPErrorStatus()
        {
            if (response.IsSuccessStatusCode)
            {
                Assert.IsNotEmpty(response.Content, "The response is empty for 200 status code");
            }
            else
            {
                Assert.IsEmpty(response.Content, "The response should not return JSON Data when error occured"); 
            }
        }

        /// <summary>
        /// Verifies that the service request returns the expected HTTP status codes for both success and failure cases.
        /// </summary>
        [Then(@"The response (.*) status code should match")]
        public void ThenTheHTTPStatusCodeShouldMatch(int expectedStatusCodes)
        {
            Assert.AreEqual(expectedStatusCodes, (int)response.StatusCode); 
        }

        /// <summary>
        /// Verifies that a response is returned when the GET STREET service makes a request.
        /// </summary>
        [When(@"I request the streets for ""([^""]*)"" with postcode ""([^""]*)""")]
        public async Task WhenIRequestTheStreetsForWithPostcode(string city, string postcode)
        {
            var completeURI = $"{resourcePath}/{postcode.Replace("\"", "")}/{city}/streets";
            try
            {
                response = await apiService.GetData(completeURI);
            }
            catch (Exception ex)
            {
                Assert.Fail($"Failed to recieve GET streets response! {ex.Message}");
            }
        }

        /// <summary>
        /// Verifies that the service response contains the expected list of streets.
        /// </summary>
        /// <param name="streetsData">The name of a test variable that contains the streets for a city name</param>
        [Then(@"I should receive a response with a list of streets for ""([^""]*)""")]
        public void ThenIShouldReceiveAResponseWithAListOfStreetsFor(string cityName)
        {
            try
            {
                if (response.IsSuccessful)
                {
                    var expectedStreetList = GetTestDataForStreets(cityName);
                    var actualStreetList = JsonBuilders.GetListOfCityOrStreet(response, "Streets");

                    CollectionAssert.AreEquivalent(expectedStreetList, actualStreetList, "The Street List in service response do not match with the expected result!");
                }
            }
            catch (Exception ex)
            {
                Assert.Fail($"Error while validating the actual and expected list of streets! {ex.Message}");
            }
        }


        /// <summary>
        /// Verifies that atleast 1 street should exists from the list of streets
        /// Verifies if the no of streets in the response matches as expected
        /// <function name="GetNoOfCitiesOrStreets"> Returns total no streets having params as response Object and node name</function>
        /// </summary>
        [Then(@"The response should contain (.*) streets")]
        public void ThenTheResponseShouldContainStreets(int expectedCountOfStreets)
        {
            try
            {
                if (response.IsSuccessful)
                {
                    var actualStreetCount = JsonBuilders.GetNoOfCitiesOrStreets(response, "Streets");

                    Assert.GreaterOrEqual(actualStreetCount, 1, "Atleast 1 street should exists from the list of streets");

                    Assert.AreEqual(actualStreetCount, expectedCountOfStreets, "The No of Streets do not match!");
                }
            }
            catch (Exception ex)
            {
                Assert.Fail($"Error while asserting no of streets! {ex.Message}");
            }
        }

        /// <summary>
        /// Verifies that street names with special characters and dashes from the streets 
        /// </summary>
        [Then(@"The street names with special characters and dashes displayed correctly")]
        public void ThenTheStreetNamesWithSpecialCharactersAndDashesDisplayedCorrectly()
        {
            if (response.IsSuccessful)
            {
                //Special Chars: German umlaumts, alphabets, numbers, dot and dashes
                var specialChars = @"[-.äöüëïÄÖÜËÏ0-9A-Za-z]+";
                var actualStreetList = JsonBuilders.GetListOfCityOrStreet(response, "Streets");

                foreach (string street in actualStreetList)
                {
                    if (!Regex.IsMatch(street, specialChars))
                    {
                        Console.WriteLine(street);
                        Assert.Fail($"This street name has an invalid character: {street}");
                    }
                }
            }    
        }



        public static List<string> GetTestDataForStreets(string varName)
        {
            TestData testData = new TestData();

            if (varName == "Berlin")
            {
                return testData.berlinStreets;
            }
            else if (varName == "Fischerbach")
            {
                return testData.fischerbachStreets;
            }
            else if (varName == "Haslach")
            {
                return testData.haslachsStreets;
            }
            else if (varName == "Hofstetten")
            {
                return testData.hofstettenStreets;
            }
            else
            {
                return null;
            }           
        }
    }
   
}
