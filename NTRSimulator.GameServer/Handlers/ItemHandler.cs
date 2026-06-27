using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;
using EntityItem = NTRSimulator.Database.Entities.Item;
using ProtoItem = NTRSimulator.Common.Proto.Item;
using NTRSimulator.Database.Entities;
using NTRSimulator.GameServer.Services;

namespace NTRSimulator.GameServer.Handlers
{
    public sealed class ItemHandler(IInventoryService inventoryService) : ItemHandlerBase
    {
        private const int ItemsPerResponse = 200;

        public override void HandleItems(CS_Items request, Connection connection)
        {
            if (connection.Account == null) return;

            EntityItem[] items = inventoryService.GetPlayerInventory<EntityItem>(connection.Account.Uid);

            if (items.Length == 0)
            {
                connection.SendAutoEncrypted(new SC_Items());
                return;
            }

            int offset = 0;
            while (offset < items.Length)
            {
                SC_Items response = new SC_Items();
                int end = Math.Min(offset + ItemsPerResponse, items.Length);

                for (int i = offset; i < end; i++)
                    response.Items[items[i].ItemId] = items[i].Count;

                connection.SendAutoEncrypted(response);
                offset += ItemsPerResponse;
            }
        }
    }
}
