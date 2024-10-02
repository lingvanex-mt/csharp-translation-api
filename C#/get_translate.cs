using RestSharp;


var options = new RestClientOptions("https://api-b2b.backenster.com/b1/api/v3/translate");
var client = new RestClient(options);
var request = new RestRequest("");
request.AddHeader("accept", "application/json");
request.AddJsonBody("{\"from\":\"en_GB\",\"to\":\"de_DE\",\"data\":\"London is the capital and largest city of England and of the United Kingdom.\",\"platform\":\"api\"}", false);
var response = await client.PostAsync(request);

Console.WriteLine("{0}", response.Content);
