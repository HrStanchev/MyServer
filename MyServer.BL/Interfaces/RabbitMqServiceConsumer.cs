using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;

namespace MyServer.BL.Interfaces
{
    public class RabbitMqServiceConsumer : IHostedService
    {
        public Task StartAsync(CancellationToken cancellationToken)
        {
            Task.Factory.StartNew(() =>
            {

            }, cancellationToken);

            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
