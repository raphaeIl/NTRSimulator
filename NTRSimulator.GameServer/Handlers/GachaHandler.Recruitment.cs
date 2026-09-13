using NTRSimulator.Common.Networking;
using NTRSimulator.Common.Proto;

namespace NTRSimulator.GameServer.Handlers;

public sealed partial class GachaHandler
{
    public override void HandleGachaList(CS_GachaList request, Connection connection)
        => connection.Send(recruitment.GetBannerList(connection));

    public override void HandleGachaOnetime(CS_GachaOnetime request, Connection connection)
        => recruitment.Draw(connection, request.GachaId, 1);

    public override void HandleGachaTentimes(CS_GachaTentimes request, Connection connection)
    {
        if (request.GachaId == 221001)
            HandleLegacyOutfitTentimes(request, connection);
        else
            recruitment.Draw(connection, request.GachaId, 10);
    }

    public override void HandleGachaSelectUp(CS_GachaSelectUp request, Connection connection)
        => recruitment.Select(connection, request.GachaId, request.OAIDHJMAEMM);

    public override void HandleGetGachaCounter(CS_GetGachaCounter request, Connection connection)
        => connection.Send(new SC_GetGachaCounter());
}
