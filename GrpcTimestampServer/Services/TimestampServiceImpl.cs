using Grpc.Core;
using GrpcTimestampServer;

public class TimestampServiceImpl : TimestampService.TimestampServiceBase
{
    public override Task<TimestampReply> SendTimestamp(TimestampRequest request, ServerCallContext context)
    {
        return Task.FromResult(new TimestampReply
        {
            Message = "Timestamp received: " + request.Timestamp
        });
    }
}
