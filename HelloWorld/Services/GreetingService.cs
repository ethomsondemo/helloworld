using System;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld.Services
{
    public class GreetingService
    {
        public Greeting GetGreeting()
        {
            return new Greeting()
            {
                Salutation = "Hello",
                Audience = "VS Live",
                Description = "Welcome to Las Vegas (Code on the Strip!)"
            };
        }

        public Task<Greeting> GetGreetingAsync()
        {
            return new Task<Greeting>(() => GetGreeting());
        }
    }
}
