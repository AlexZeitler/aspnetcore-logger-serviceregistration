namespace AspNetCoreLoggerInServiceRegistration.Registrations;

public static class SomeRegistrationExtensions
{
  public static IServiceCollection RegisterSomething(
    this IServiceCollection services
  )
  {
    var sp = services.BuildServiceProvider();
    var logger = sp.GetService<ILogger>();
    
    logger.Log(
      LogLevel.Warning,
      "Nothing gets registered here..."
    );
    return services;
  }
}