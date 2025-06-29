using RabbitMQ.Client;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RabbitMQ.Client.Events;


namespace MultiShop.RabbitMQMessageApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateMessage()
        {
            var connectionFactory = new ConnectionFactory()
            {
                HostName = "localhost"
            };
            var connection = connectionFactory.CreateConnection();
            var channel = connection.CreateModel();
            channel.QueueDeclare("Kuyruk1", durable: false, exclusive: false, autoDelete: false, arguments: null);
            var messageContent = "merhaba bu bir RabbitMQ mesajıdır.";
            var byteMessageContent = System.Text.Encoding.UTF8.GetBytes(messageContent);
            channel.BasicPublish(exchange: "", routingKey: "Kuyruk1", basicProperties: null, body: byteMessageContent);


            return Ok("mesajınız kuyruğa alınmıştır.");
        }
        private static string message;

        [HttpGet]
        public IActionResult ReadMessage()
        {
            var connectionFactory = new ConnectionFactory()
            {
                HostName = "localhost"
            };
            var connection = connectionFactory.CreateConnection();
            var channel = connection.CreateModel();
            var consumer =new EventingBasicConsumer(channel);
            consumer.Received += (model, ea) =>
            {
                var body = ea.Body.ToArray();
                message = System.Text.Encoding.UTF8.GetString(body);
            };
            channel.BasicConsume(queue: "Kuyruk1", autoAck: true, consumer: consumer);
            if (string.IsNullOrEmpty(message))
            {
                return NotFound("Kuyrukta mesaj bulunmamaktadır.");
            }
            return Ok();
        }
    }
}
