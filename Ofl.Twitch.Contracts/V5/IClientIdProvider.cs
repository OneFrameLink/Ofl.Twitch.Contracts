using System.Threading;
using System.Threading.Tasks;

namespace Ofl.Twitch.V5
{
    public interface IClientIdProvider
    {
        Task<string> GetClientIdAsync(CancellationToken cancellationToken);
    }
}
