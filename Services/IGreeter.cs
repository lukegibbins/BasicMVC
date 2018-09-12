using Microsoft.Extensions.Configuration;

namespace ChillAndGrill
{
    public interface IGreeter
    {
        string GetMessageOfTheDay();
    }

    public class Greeter: IGreeter
    {
        private IConfiguration _configuration;

        public Greeter(IConfiguration config)
        {
            _configuration = config;
        }

        public string GetMessageOfTheDay()
        {
            return _configuration["Greeting"];
        }
    }

}