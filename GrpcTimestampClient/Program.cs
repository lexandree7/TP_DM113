using System;
using System.Threading.Tasks;
using Grpc.Net.Client;
using GrpcTimestampServer;

class Program
{
    static async Task Main(string[] args)
    {
        using var channel = GrpcChannel.ForAddress("https://localhost:5001");
        var client = new TimestampService.TimestampServiceClient(channel);
        var timestamp = DateTime.UtcNow.ToString("o");
        var reply = await client.SendTimestampAsync(new TimestampRequest { Timestamp = timestamp });
        Console.WriteLine("Server response: " + reply.Message);
    }
}
