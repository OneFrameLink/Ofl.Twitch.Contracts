using System.Threading;
using System.Threading.Tasks;

namespace Ofl.Twitch.V5
{
    public interface ITwitchClient
    {
        Task<Video> GetVideo(string id, CancellationToken cancellationToken);
    }
}
