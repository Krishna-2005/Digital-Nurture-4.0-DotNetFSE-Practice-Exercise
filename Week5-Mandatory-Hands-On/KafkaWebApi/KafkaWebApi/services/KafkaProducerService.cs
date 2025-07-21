using Confluent.Kafka;
using Microsoft.Extensions.Configuration;
using System;
using System.Threading.Tasks;

namespace KafkaWebApi.Services
{
    public class KafkaProducerService
    {
        private readonly string _bootstrapServers = "localhost:9092";
        private readonly string _topic = "test-topic";

        public async Task SendMessageAsync(string message)
        {
            var config = new ProducerConfig { BootstrapServers = _bootstrapServers };

            using var producer = new ProducerBuilder<Null, string>(config).Build();
            var result = await producer.ProduceAsync(_topic, new Message<Null, string> { Value = message });

            Console.WriteLine($"✅ Message delivered to: {result.TopicPartitionOffset}");
        }
    }
}
