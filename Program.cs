using System;
using System.Threading.Tasks;
using Azure.Messaging.ServiceBus;
using Configuration;

class Program
{
    static async Task Main(string[] args)
    {
        string connectionString = AppConfiguration.ConnectionString;
        string queueName = AppConfiguration.QueueName;

        const int RETRY_MESSAGE_QUANTITY = 3;

        ServiceBusClient client = new ServiceBusClient(connectionString);

        ServiceBusSender sender = client.CreateSender(queueName);

        try
        {
            using ServiceBusMessageBatch messageBatch = await sender.CreateMessageBatchAsync();

            for (int i = 1; i <= RETRY_MESSAGE_QUANTITY; i++)
            {
                if (!messageBatch.TryAddMessage(new ServiceBusMessage($"Message {i}")))
                {
                    throw new Exception($"The message {i} is too large to fit in the batch.");
                }
            }
            await sender.SendMessagesAsync(messageBatch);
            Console.WriteLine($"It has been published a batch of {RETRY_MESSAGE_QUANTITY} messages in the queue.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
        finally
        {
            await sender.DisposeAsync();
            await client.DisposeAsync();
        }

        Console.WriteLine("The messages have been sent to the queue. Check the Azure portal to verify.");
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();

        ServiceBusProcessor processor;
        client = new ServiceBusClient(connectionString);
        processor = client.CreateProcessor(queueName, new ServiceBusProcessorOptions());

        try
        {
            processor.ProcessMessageAsync += MessageHandler;

            processor.ProcessErrorAsync += ErrorHandler;

            await processor.StartProcessingAsync();

            Console.WriteLine("Wait a minute and then press any key to stop processing.");
            Console.ReadKey();

            Console.WriteLine("\nStop the receiver...");
            await processor.StopProcessingAsync();
            Console.WriteLine("Stopped receiving messages");
        }
        finally
        {
            
            await processor.DisposeAsync();
            await client.DisposeAsync();
        }

        async Task MessageHandler(ProcessMessageEventArgs args)
        {
            string body = args.Message.Body.ToString();
            Console.WriteLine($"Received: {body}");

            await args.CompleteMessageAsync(args.Message);
        }

        Task ErrorHandler(ProcessErrorEventArgs args)
        {
            Console.WriteLine(args.Exception.ToString());
            return Task.CompletedTask;
        }
    }
}
