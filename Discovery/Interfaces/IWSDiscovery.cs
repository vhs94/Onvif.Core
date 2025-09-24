using Onvif.Core.Discovery.Models;

namespace Onvif.Core.Discovery.Interfaces;

public interface IWSDiscovery
{
    Task<IEnumerable<DiscoveryDevice>> Discover(int timeout,
      CancellationToken cancellationToken = default);
    Task<IEnumerable<DiscoveryDevice>> Discover(int timeout, string ipAddress, int port,
        CancellationToken cancellationToken = default);
    Task<IEnumerable<DiscoveryDevice>> Discover(int timeout, int port,
       CancellationToken cancellationToken = default);
    Task<IEnumerable<DiscoveryDevice>> Discover(int timeout, IUdpClient client,
        CancellationToken cancellationToken = default);
}
