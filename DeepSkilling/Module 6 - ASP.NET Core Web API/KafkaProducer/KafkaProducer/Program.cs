using Confluent.Kafka;

var config = new ProducerConfig
{
    BootstrapServers = "localhost:9092"
};

using var producer = new ProducerBuilder<Null, string>(config).Build();

Console.WriteLine("Kafka Producer Started");
Console.WriteLine("----------------------");

while (true)
{
    Console.Write("Enter Message : ");
    string msg = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(msg))
        continue;

    await producer.ProduceAsync("ChatTopic",
        new Message<Null, string> { Value = msg });

    Console.WriteLine("Message Sent!");
}