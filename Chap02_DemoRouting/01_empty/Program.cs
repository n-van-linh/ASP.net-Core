

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.UseStaticFiles();
app.MapGet("/", () => "Hello World!");
app.MapGet("/index", () => 
 {

     return
    Results.File("D:\\HocTap\\ASP.net\\Chap02_DemoRouting\\01_empty\\wwwroot\\home.html", "text/html");
 }
);
app.MapGet("/detail", () =>
{
    var file = "wwwroot/detail.html";
    var content = File.ReadAllText(file);
    return Results.Content(content,"text/html") ;
}
);

app.Run();
