using Serilog;

namespace FakeUserGeneratorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .CreateLogger();

            Log.Information("Application started.");

            for (int i = 0; i < 5; i++)
            {
                var fakeUser = FakeUser.GenerateFakeUser();
                Log.Information("Generated User: {@FakeUser}", fakeUser);
                Console.WriteLine($"Name: {fakeUser.Name}");
                Console.WriteLine($"Surname: {fakeUser.Surname}");
                Console.WriteLine($"Contact Phone Number: {fakeUser.ContactPhoneNumber}");
                Console.WriteLine($"Email: {fakeUser.Email}");
                Console.WriteLine($"Address: {fakeUser.Address}");
                Console.WriteLine("----------------------------");
            }

            Log.Information("Application finished.");
        }
    }
}
