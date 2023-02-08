using Grid_Excel_Export.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Syncfusion.Blazor;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mgo+DSMBaFt/QHRqVVhkVVpHaV5CQmFJfFBmRGFTelZ6dFVWESFaRnZdQV1hSXZTdkBrWnhacHVX;Mgo+DSMBPh8sVXJ0S0J+XE9Af1RBQmJJYVF2R2BJflx6cV1MYFxBNQtUQF1hSn5Rdk1jWXpWc3NRRGNe;ORg4AjUWIQA/Gnt2VVhkQlFaclZJXnxIfkx0RWFab19yflBOalxRVAciSV9jS31TdEVrWX9beHdSQ2JeUw==;MTA4NTI2NUAzMjMwMmUzNDJlMzBqeGowTHg5aVNLc0lpQVk5cmRSd3JZSDVGVURRc3BVSk8yQ3VRRjh1M0lVPQ==;MTA4NTI2NkAzMjMwMmUzNDJlMzBnYkpaZHhabGJtQ2c0MW40VDNrSDR6dXc0MG0wZ3NtZVZjeHhWTlVsY0VnPQ==;NRAiBiAaIQQuGjN/V0Z+WE9EaFtLVmBWf1NpR2NbfE5xdl9DaFZRRGYuP1ZhSXxQdkdjUX9edXxWQWdVVEc=;MTA4NTI2OEAzMjMwMmUzNDJlMzBRNXFwR1JEQStmc2tXQ2E0TkF2eDNLL2RqOWl4UXFJNmZBakszbmtMT1JFPQ==;MTA4NTI2OUAzMjMwMmUzNDJlMzBRUUUyTzJWZUtzWjJ6dTNNRGFXSmlXTjgrSERiL2w1aFFwV2g0MlhjaFRZPQ==;Mgo+DSMBMAY9C3t2VVhkQlFaclZJXnxIfkx0RWFab19yflBOalxRVAciSV9jS31TdEVrWX9beHddRmNaUw==;MTA4NTI3MUAzMjMwMmUzNDJlMzBUcmFKc3RGQVJLRG51NGlEaEd1VU1tV1I2OGRVYjVjcnY4Unc0a3NoLzlNPQ==;MTA4NTI3MkAzMjMwMmUzNDJlMzBCdWprYlVFMTY2NW9CeXB6ZjBGQThpdXp4QlJNUTdsQm4rdHFTejI3SHg0PQ==;MTA4NTI3M0AzMjMwMmUzNDJlMzBRNXFwR1JEQStmc2tXQ2E0TkF2eDNLL2RqOWl4UXFJNmZBakszbmtMT1JFPQ==");
builder.Services.AddSyncfusionBlazor();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
