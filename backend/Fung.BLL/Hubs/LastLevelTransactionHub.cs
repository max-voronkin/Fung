using Microsoft.AspNetCore.SignalR;

namespace Fung.BLL.Hubs
{
    public sealed class LastLevelTransactionHub : Hub
    {
        public async Task SetConnectionAsync(int tankId)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, tankId.ToString());
        }

    }
}
