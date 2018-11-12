using MarkOGDev.Microsoft_Samples.GenericHost_ConsoleApp.Interfaces;

namespace MarkOGDev.Microsoft_Samples.GenericHost_Sample.ConsoleApp.Services
{
    public class SimpleMessageService : ISimpleMessageService
    {
        public string GetHelloMessage()
        {
            return "Hello to everybody. We hope all are happy today.";
        }

        public string GetHelloMessage(string Name)
        {
            //Using string interpolation. https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated
            return $"Hello {Name}. We hope {Name} is happy today.";
        }

        public string GetHelloMessage(int FavNumber)
        {
            return $"Hello mate. {FavNumber} is your favorite number. We like the number {FavNumber}";
        }
    }
}
