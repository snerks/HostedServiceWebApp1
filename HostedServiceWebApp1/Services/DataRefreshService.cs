using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;

namespace HostedServiceWebApp1.Services
{
    public class DataRefreshService : BackgroundService
    {
        private readonly IRandomStringProvider _randomStringProvider;

        public DataRefreshService(IRandomStringProvider randomStringProvider)
        {
            _randomStringProvider = randomStringProvider;
        }

        protected override async Task ExecuteAsync(CancellationToken cancellationToken)
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                await _randomStringProvider.UpdateString(cancellationToken).ConfigureAwait(false);
                await Task.Delay(TimeSpan.FromSeconds(5), cancellationToken).ConfigureAwait(false);
            }
        }
    }
}
