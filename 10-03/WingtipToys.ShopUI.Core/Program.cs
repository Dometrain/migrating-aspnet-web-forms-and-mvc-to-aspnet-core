
using Microsoft.EntityFrameworkCore;
using WingtipToys.Data.Core;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddWebOptimizer(pipeline =>
{
    // Add JavaScript bundles
    pipeline.AddJavaScriptBundle("/bundles/modernizr",
        "Scripts/modernizr-2.6.2.js").UseContentRoot();
    pipeline.AddJavaScriptBundle("/bundles/bootstrap",
        "Scripts/bootstrap.js", "Scripts/respond.js").UseContentRoot();
    pipeline.AddJavaScriptBundle("/bundles/jquery",
        "Scripts/jquery-3.3.1.js").UseContentRoot();

    // Add CSS bundles
    pipeline.AddCssBundle("/content/css",
        "Content/bootstrap.css", "Content/Site.css").UseContentRoot();
});

builder.Services.AddDbContext<ProductContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("WingtipToys"))
           .LogTo(Console.WriteLine));

builder.Services.AddSystemWebAdapters()
    .AddJsonSessionSerializer(options =>
    {
        options.RegisterKey<string>("CartId");
    })
    .AddRemoteAppClient(options =>
    {
        options.RemoteAppUrl = new Uri(builder.Configuration["ProxyTo"]!);
        options.ApiKey = builder.Configuration["SystemWebApiKey"];
    })
.AddSessionClient()
.AddAuthenticationClient(true);

builder.Services.AddHttpForwarder();
builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ProductContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("WingtipToys")));

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseWebOptimizer();

app.UseAuthentication();
app.UseAuthorization();
app.UseSystemWebAdapters();

app.MapDefaultControllerRoute();
app.MapRazorPages().RequireSystemWebAdapterSession();

app.MapForwarder("/{folder:regex(Content|Bundles)}/{**catch-all}", app.Configuration["ProxyTo"])
    .WithOrder(int.MaxValue - 1);
app.MapForwarder("/{**catch-all}", app.Configuration["ProxyTo"])
    .ShortCircuit()
    .WithOrder(int.MaxValue);

app.Run();
