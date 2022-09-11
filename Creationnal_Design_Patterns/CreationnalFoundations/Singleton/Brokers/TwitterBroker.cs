namespace Creationnal_Design_Patterns.CreationnalFoundations.Singleton.Brokers
{
    public sealed class TwitterBroker
    {
        private TwitterBroker()
        { }

        public static TwitterBroker TwitterBrokerInstance { get; } = new TwitterBroker();

        public int Timeout { get; set; }
    }
}
