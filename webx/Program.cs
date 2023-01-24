using BusinessLogic;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.MapGet("/", () => "The Factorial of (4) = "+FactorialService.CalculateFactorial(4));
app.Run();