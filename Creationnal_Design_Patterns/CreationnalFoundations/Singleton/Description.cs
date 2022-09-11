namespace Creationnal_Design_Patterns.CreationnalFoundations.Singleton
{
    internal class Description
    {
        //16. Singleton Ensure a class only has one instance,
        //and provide a global point of access to it.

        //maintain a state entire the application
        //the application talkes to the twitter
        //broker knows how instantiate the needed configuration
        //to talk to twitter so we do not need to instantiate
        //each time we need the twitter api, if we need it
        //in different services, so it is better to make a 
        //one class only instantiated once and used by the 
        //services, or u can use it also
        //to send same message to different services
        //by using messaging
    }
}
