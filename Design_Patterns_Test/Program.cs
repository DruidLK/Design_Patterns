using Creationnal_Design_Patterns.CreationnalFoundations.Singleton.Brokers;

namespace Design_Patterns_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var twitterBroker = TwitterBroker.TwitterBrokerInstance;
            twitterBroker.Timeout = 10;

            var twitterBroker_2 = TwitterBroker.TwitterBrokerInstance;
            System.Console.WriteLine(twitterBroker_2.Timeout);

        }
    }
}
