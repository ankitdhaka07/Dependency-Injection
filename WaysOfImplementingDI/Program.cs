

using BuiltInDIContainer;
using Microsoft.Extensions.DependencyInjection;

var serviceProvider = new ServiceCollection().AddScoped<IMailServiceDependency, MailServiceDependency>()
                            .BuildServiceProvider();
var mailService = serviceProvider.GetRequiredService<IMailServiceDependency>();

Console.WriteLine("********\t From ConstructorInjection \t********\n\n");
var constructorInjection = new ConstructorInjection(mailService);
constructorInjection.SendPremMessage();

Console.WriteLine("********\t From MethodInjection \t********\n\n");
var methodInjection = new MethodInjection();
methodInjection.SendPremMessage(mailService);

Console.WriteLine("********\t From PropertyInjection \t********\n\n");
var propertyInjection = new PropertyInjection();
propertyInjection._mailService = mailService;
propertyInjection.SendPremMessage();
