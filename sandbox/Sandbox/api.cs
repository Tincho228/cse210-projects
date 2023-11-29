
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Xml.XPath;

public class API {
    protected string  _response;

    public string GetResponse()
    {
        return _response;
    }

    public async Task GetJson() {

        try
        {
            Console.WriteLine("En proceso");
            HttpClient client = new HttpClient();
            using HttpResponseMessage response = await client.GetAsync("https://api.openweathermap.org/data/2.5/forecast?q=San%20Rafael,AR&appid=0bd1671316868f5ad2775ab7ede5bf47&units=metric");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            // Above three lines can be replaced with new helper method below
            // string responseBody = await client.GetStringAsync(uri);
            Console.WriteLine($"Waiting for data");
            SpinningAnimation(2);
            _response = responseBody;
        }
        catch (HttpRequestException e)
            {
            Console.WriteLine("\nException Caught!");
            Console.WriteLine("Message :{0} ", e.Message);
            }
    }
    public void SpinningAnimation(int time){
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("—");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("—");
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(time);
        int i = 0;
        while(DateTime.Now < endTime)
        {
            string part = animationStrings[i];
            Console.Write(part);
            Thread.Sleep(500);
            Console.Write("\b \b");
            i++;
            if(i >= animationStrings.Count())
            {
                i = 0;
            }
        }
        
    }
}