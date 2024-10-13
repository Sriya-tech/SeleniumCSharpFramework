[Test]
public void GetBooksApiTest()
{
    var client = new RestClient("https://demoqa.com/BookStore/v1/Books");
    var request = new RestRequest(Method.GET);
    var response = client.Execute(request);

    // Assert the API response
    Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

    var books = JsonConvert.DeserializeObject<BookResponse>(response.Content);
    Assert.That(books.Books.Count, Is.GreaterThan(0));
}