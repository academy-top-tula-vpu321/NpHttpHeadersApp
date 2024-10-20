HttpClient client = new();

client.DefaultRequestHeaders.Add("User-Agent", "Net Client");
client.DefaultRequestHeaders.Add("My-Header", "Hello world");

HttpRequestMessage request = new(HttpMethod.Get, "https://localhost:7140");
request.Headers.Add("Accept", "application/json");

//var response = await client.GetAsync("https://localhost:7140");
var response = await client.SendAsync(request);
string content = await response.Content.ReadAsStringAsync();



Console.WriteLine(content);