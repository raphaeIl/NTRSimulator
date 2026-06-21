using NTRSimulator.Common.Protocol;

namespace NTRSimulator.Common.Packets
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public sealed class PacketHandlerAttribute : Attribute
    {
        public MsgId ReqMsgId { get; }

        public MsgId RespMsgId { get; }

        public PacketHandlerAttribute(MsgId reqMsgId, MsgId respMsgId = MsgId.MsgNone)
        {
            ReqMsgId = reqMsgId;
            RespMsgId = respMsgId;
        }
    }
}
