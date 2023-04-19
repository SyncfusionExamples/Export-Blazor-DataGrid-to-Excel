using Grid_Excel_Export.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Syncfusion.Blazor;
var builder = WebApplication.CreateBuilder(args);
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mgo+DSMBaFt+QHFqVkNrWU5FcUBAXWFKblZ8QGRTf15gBShNYlxTR3ZbQ1pjTHtUdkRrXXpW;Mgo+DSMBPh8sVXJ1S0d+X1RPc0BDWnxLflF1VWZTell6dFVWESFaRnZdQV1nSHlTc0BkWX5Wd3Rd;ORg4AjUWIQA/Gnt2VFhhQlJBfVpdXGRWfFN0RnNcdVt3flVGcC0sT3RfQF5jTX9UdkBmXn9feH1QTg==;MTc0NjY4OEAzMjMxMmUzMTJlMzMzNW5uWXRPL0NvR1psY3JLOVc0RUhlSFFhcDlHNndmcytvb2ZTeHRpWWJGVEU9;MTc0NjY4OUAzMjMxMmUzMTJlMzMzNURFYmFaNDV3cXM3dTFnZmIzVnZoWDBBNTlrQU5mTHZycXUzMlpXcjhIN009;NRAiBiAaIQQuGjN/V0d+XU9Hc1RHQmJOYVF2R2BJelR1c19GYEwgOX1dQl9gSXpScUVmXHhecnRXRWg=;MTc0NjY5MUAzMjMxMmUzMTJlMzMzNU91MlJRaU1WdmprUUdudVhjU3E4bDB5MEFhaVZBUGd5Tjc2RTFDK2R0eHc9;MTc0NjY5MkAzMjMxMmUzMTJlMzMzNVNhbUhYRXBMTm9mTUZDYkRrNXl3dUw3cnpIOHhibGI5ZHVGaVM0RDMyN2M9;Mgo+DSMBMAY9C3t2VFhhQlJBfVpdXGRWfFN0RnNcdVt3flVGcC0sT3RfQF5jTX9UdkBmXn9ccXBTTg==;MTc0NjY5NEAzMjMxMmUzMTJlMzMzNWI0OCszb21kOWhPajN1R3NsOEpvaVRVTkRvVmFMdUd3VFpwMFhYZjJPSmc9;MTc0NjY5NUAzMjMxMmUzMTJlMzMzNWtVRkI3Q0tGNGlQeVpUbHl1UHFpZEhoVjVsWVNML3VLZWVGOUNYakpPTkU9;MTc0NjY5NkAzMjMxMmUzMTJlMzMzNU91MlJRaU1WdmprUUdudVhjU3E4bDB5MEFhaVZBUGd5Tjc2RTFDK2R0eHc9");

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
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
