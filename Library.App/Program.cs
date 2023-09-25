using Library.App;
using Library.Business.Classes;
using Library.Common.Classes;
using Library.Common.Interfaces;
using Library.Data.Classes;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<HttpReader>();

builder.Services.AddScoped<IData, BooksData>();
builder.Services.AddScoped<BookBusiness>();

await builder.Build().RunAsync();
