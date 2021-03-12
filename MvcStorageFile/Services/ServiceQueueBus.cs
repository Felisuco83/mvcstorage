using Azure.Messaging.ServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MvcStorage.Services
{
    public class ServiceQueueBus
    {
        private ServiceBusClient client;
        List<string> mensajes;
        public ServiceQueueBus(string keys)
        {
            this.client = new ServiceBusClient(keys);
            mensajes = new List<string>();
        }
        public async Task SendMessage(string data)
        {
            //NECESITAMOS UN SENDER QUE ES EL QUE VA ASOCIADO A LA QUEUE
            ServiceBusSender sender = this.client.CreateSender("programeitors");
            //EL PROPIO MENSAJE
            ServiceBusMessage message = new ServiceBusMessage(data);
            //EL MENSAJE SE MANDA MEDIANTE EL SENDER
            await sender.SendMessageAsync(message);
        }

        private Queue<ServiceBusMessage> CreateMessages ()
        {
            Queue<ServiceBusMessage> mensajes = new Queue<ServiceBusMessage>();
            mensajes.Enqueue(new ServiceBusMessage("Primer mensaje"));
            mensajes.Enqueue(new ServiceBusMessage("Segundo mensaje"));
            mensajes.Enqueue(new ServiceBusMessage("Tercer mensaje"));
            return mensajes;
        }

        public async Task SendBatchMessages()
        {
            //RECUPERAMOS LOS MENSAJES EN EL BATCH
            Queue<ServiceBusMessage> colamensajes = this.CreateMessages();
            ServiceBusSender sender = this.client.CreateSender("programeitors");
            //LOS MENSAJES ESTAN EN MODO ENQUEUE A MEDIDA QUE LOS VAYAMOS PROCESANDO SE IRAN QUITANDO DE LA COLA Y PASANDO+
            // A PROCESO DEQUEUE, NO SABEMOS CUANTO TARDARÁ ESTE PROCESO, DEBEMOS HACER EL PROCESO DE BATCH EN UN BUCLE 
            //MIENTRAS LOS MENSAJES ESTEN EN LA COLA
            while (colamensajes.Count > 0)
            {
                //TODOS LOS MENSAJES DE LA COLA SE PROCESAN CON BATCH
                ServiceBusMessageBatch batch = await sender.CreateMessageBatchAsync();
                //LOS MENSAJES SE AGREGAN AL BATCH Y SE VAN PROCESANDO
                if (batch.TryAddMessage(colamensajes.Peek())) 
                {
                    colamensajes.Dequeue();
                }
                //SE VAN ENVIANDO LOS BATCH
                await sender.SendMessagesAsync(batch);
            }
        }

        public async Task<List<string>> RecibirMensajes()
        {
            ServiceBusProcessor processor = this.client.CreateProcessor("programeitors");
            processor.ProcessMessageAsync += MessageHandler;
            processor.ProcessErrorAsync += Processor_ProcessErrorAsync;
            await processor.StartProcessingAsync();
            Thread.Sleep(30000);
            //await processor.StopProcessingAsync();
            return this.mensajes;
        }

        private Task Processor_ProcessErrorAsync(ProcessErrorEventArgs arg)
        {
            return Task.CompletedTask;
        }

        private async Task MessageHandler (ProcessMessageEventArgs e)
        {
            string data = e.Message.Body.ToString();
            mensajes.Add(data);
            //DEBEMOS IR ELIMINANDO LOS MENSAJES DE LA COLA COMO LEIDOS/PROCESADOS
            await e.CompleteMessageAsync(e.Message);
        }


    }
}
