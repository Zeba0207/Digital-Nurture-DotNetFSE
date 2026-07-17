using Confluent.Kafka;

namespace KafkaChatClient
{
    public partial class Form1 : Form
    {
        ProducerConfig producerConfig;
        ConsumerConfig consumerConfig;

        public Form1()
        {
            InitializeComponent();

            producerConfig = new ProducerConfig
            {
                BootstrapServers = "localhost:9092"
            };

            consumerConfig = new ConsumerConfig
            {
                BootstrapServers = "localhost:9092",
                GroupId = "chat-group",
                AutoOffsetReset = AutoOffsetReset.Earliest
            };

            StartConsumer();
        }

        private void StartConsumer()
        {
            Task.Run(() =>
            {
                using var consumer = new ConsumerBuilder<Ignore, string>(consumerConfig).Build();

                consumer.Subscribe("ChatTopic");

                while (true)
                {
                    try
                    {
                        var result = consumer.Consume();

                        Invoke(new Action(() =>
                        {
                            rtbMessages.AppendText(result.Message.Value + Environment.NewLine);
                        }));
                    }
                    catch
                    {
                    }
                }
            });
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            using var producer = new ProducerBuilder<Null, string>(producerConfig).Build();

            await producer.ProduceAsync("ChatTopic",
                new Message<Null, string>
                {
                    Value = txtMessage.Text
                });

            txtMessage.Clear();
        }
    }
}