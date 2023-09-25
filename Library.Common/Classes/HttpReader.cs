using Library.Common.Interfaces;
using System.Net.Http.Json;

namespace Library.Common.Classes;

public class HttpReader
{
    HttpClient _http;

    public HttpReader(HttpClient http) =>  _http = http;
    
    public async Task<List<IBook>> ReadFile(string fileName)
    {
        var result = await _http.GetFromJsonAsync<List<Book>>(fileName);
        return result is null ? new List<IBook>() : result.Cast<IBook>().ToList();
    }

    public async Task<List<IBook>> ReadFile<T>(string fileName) where T : class, IBook
    {
        var result = await _http.GetFromJsonAsync<List<T>>(fileName);
        return result is null ? new List<IBook>() : result.Cast<IBook>().ToList();
    }

}
