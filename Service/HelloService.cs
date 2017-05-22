
using ServiceStack;

namespace Core_SelfHost_ServiceStack
{
    public class HelloRequest {
        public string Name { get; set; }
    }

    public class HelloResponse {
        public string Result { get; set; }
    }

    public class HelloService : Service
    {
        public object Any(HelloRequest request) 
        {
            return new HelloResponse { Result = "Hello, " + request.Name };
        }
    }
}