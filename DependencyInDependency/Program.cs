// See https://aka.ms/new-console-template for more information

using DependencyInDependency;
using Microsoft.Extensions.DependencyInjection;

var serviceCollector = new ServiceCollection();
serviceCollector.AddTransient<IService, Service>();
serviceCollector.AddScoped<IMainService, MainService>();


var serviceProvider = serviceCollector.BuildServiceProvider();
Console.WriteLine("************\t 1st Request \t ************\n\n");
var mainService = serviceProvider.GetRequiredService<IMainService>();

mainService.MainServiceType = "Scoped";
mainService.ServiceType = "Transient";
mainService.ShowBothService();


var scope = serviceProvider.CreateScope();

using (scope)
{
    Console.WriteLine("\n\n************\t 2nd Request \t ************\n\n");
    var mainService1 = scope.ServiceProvider.GetRequiredService<IMainService>();
    mainService1.ShowBothService();

}
Console.WriteLine("\n\n************\t 3rd Request \t ************\n\n");
var mainService2 = serviceProvider.GetRequiredService<IMainService>();

mainService2.ShowBothService();

