using Microsoft.AspNetCore.Mvc;
using MvcStorage.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcStorage.Controllers
{
    public class QueueController : Controller
    {
        ServiceQueueBus ServiceBus;
        public QueueController(ServiceQueueBus bus)
        {
            this.ServiceBus = bus;
        }
        public IActionResult Index ()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(string mensaje, string accion)
        {
            if(accion.ToLower() == "mensaje")
            {
                await this.ServiceBus.SendMessage(mensaje);
            } else if(accion.ToLower() == "batch")
            {
                await this.ServiceBus.SendBatchMessages();
            } else if (accion.ToLower() == "recibir")
            {
                List<string> mensajes = await this.ServiceBus.RecibirMensajes();
                return View(mensajes);
            }
            return View();
        }
    }
}
