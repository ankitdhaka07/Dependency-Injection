// See https://aka.ms/new-console-template for more information

using Microsoft.Extensions.DependencyInjection;
using ServiceLifetimeDI;
using System.Runtime.InteropServices.Marshalling;

//made a service collector on which we will register our services

var serviceCollection = new ServiceCollection();
serviceCollection.AddSingleton<ISingletonService, SingletonService>();
serviceCollection.AddScoped<IScopedService, ScopedService>();
serviceCollection.AddTransient<ITransientService, TransientService>();
IServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();
Console.WriteLine("************\t 1st Request \t ************\n");
var transientService = serviceProvider.GetRequiredService<ITransientService>();
var scopedService = serviceProvider.GetRequiredService<IScopedService>();
var singletonService = serviceProvider.GetRequiredService<ISingletonService>();
transientService.GoGuid();
scopedService.GoGuid();
singletonService.GoGuid();

using (var scope = serviceProvider.CreateScope())
{
    Console.WriteLine("************\t 2nd Request \t ************\n");
    var transientService1 = scope.ServiceProvider.GetRequiredService<ITransientService>();
    var scopedService1 = scope.ServiceProvider.GetRequiredService<IScopedService>();
    var singletonService1 = scope.ServiceProvider.GetRequiredService<ISingletonService>();
    transientService1.GoGuid();
    scopedService1.GoGuid();
    singletonService1.GoGuid();

}

Console.WriteLine("************\t 3rd Request \t ************\n");
var transientService2 = serviceProvider.GetRequiredService<ITransientService>();
var scopedService2 = serviceProvider.GetRequiredService<IScopedService>();
var singletonService2 = serviceProvider.GetRequiredService<ISingletonService>();
transientService2.GoGuid();
scopedService2.GoGuid();
singletonService2.GoGuid();