using ServiceStack;

namespace Core_SelfHost_ServiceStack
{
    // [Route("/ping")]
    public class PingRequest {}

    public class PingService : Service
    {
        public object Any(PingRequest request) 
        {
            return "Pong!";
        }
    }
}