using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorApp1;
var url = "https://qpkxfoqxocontrcrslbc.supabase.co";
var key = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6InFwa3hmb3F4b2NvbnRyY3JzbGJjIiwicm9sZSI6ImFub24iLCJpYXQiOjE3NTg3NTM3OTEsImV4cCI6MjA3NDMyOTc5MX0.SLBJabMXSYL3feIwCUm9eJz3kSZC2AG5cjJyOuskQX4";
var options = new Supabase.SupabaseOptions

{
    AutoConnectRealtime = true
};
var supabase = new Supabase.Client(url, key, options);
await supabase.InitializeAsync();

builder.Services.AddSingleton(supabase);
var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
