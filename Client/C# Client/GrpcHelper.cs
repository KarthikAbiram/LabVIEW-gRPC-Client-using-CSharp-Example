using System;
using System.Threading;
using Grpc.Core;

//There is some trouble in accessing some of the gRPC functionalities (like setting the gRPC deadline value) in LabVIEW. 
//These functionalities are wrapped up in custom C# code like below, which can be used.

namespace gRPC_Helper
{
    public class GrpcHelper
    {
        public static CallOptions GetCallOptions(double timeout_secs)
        {
                var callOptions = new CallOptions()
                .WithCancellationToken(CancellationToken.None)
                .WithDeadline(DateTime.UtcNow.AddSeconds(timeout_secs))
                .WithHeaders(Metadata.Empty);
                return callOptions;
        }
    }
}
