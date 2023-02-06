namespace DevaloreAss.Controllers
{
    public class ApiHelper
    {
        public static HttpClient? ApiClient { get; private set; }
        

        // to initialize the client that will call for the free-API
        // 
        public static void InitalizeClient() {
            ApiClient= new HttpClient();
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            
        }
    }
}
