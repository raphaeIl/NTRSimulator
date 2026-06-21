using Microsoft.Extensions.Logging;
using NTRSimulator.Common.Protocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTRSimulator.Common.Utils
{
    public static class PacketUtils
    {
        public static void LogBasePackets(
            string packetVerb,
            string mainMessageVerb,
            IReadOnlyList<BasePacket> packets,
            ushort sequenceId,
            byte encryptionFlag,
            byte[] rawMainMessage,
            ILogger logger)
        {
            string sendMode = sequenceId == 0 ? "unsequenced" : "sequenced";

            foreach (BasePacket packet in packets)
            {
                MsgIdResolver.TryResolve(
                    packet.RawMsgId,
                    out MsgId resolvedMsgId,
                    out string resolvedProtoName,
                    out string? resolvedTranslatedClassName
                );

                logger.LogInformation(
                    "{PacketVerb} {SendMode} packet raw msg id {RawMsgId}, resolved msg id {ResolvedMsgIdName} ({ResolvedMsgIdEnumValue}), proto {ResolvedProtoName}, translated proto class {ResolvedTranslatedProtoClassName}, payload length {PayloadLength}, raw length {RawLength}",
                    packetVerb,
                    sendMode,
                    packet.RawMsgId,
                    resolvedMsgId.ToString(),
                    (int)resolvedMsgId,
                    resolvedProtoName,
                    resolvedTranslatedClassName ?? "<missing>",
                    packet.RawIMessageData.Length,
                    packet.RawPacketData.Length
                );
                logger.LogInformation("{PacketVerb} packet raw bytes: {Bytes}", packetVerb, HexUtils.FormatBytes(packet.RawPacketData));
                logger.LogInformation("{PacketVerb} packet payload bytes: {Bytes}", packetVerb, HexUtils.FormatBytes(packet.RawIMessageData));
            }

            logger.LogInformation(
                "{MainMessageVerb} {SendMode} main message seq {SequenceId} with {PacketCount} packet(s), isEncrypted {IsEncrypted}, encryptedByte {EncryptedByte}, total bytes {TotalBytes}",
                mainMessageVerb,
                sendMode,
                sequenceId,
                packets.Count,
                encryptionFlag > 0,
                encryptionFlag,
                rawMainMessage.Length
            );
            logger.LogInformation("{MainMessageVerb} main message bytes: {Bytes}", mainMessageVerb, HexUtils.FormatBytes(rawMainMessage));
            logger.LogInformation(
                "{MainMessageVerb} IMessage(s):{NewLine}{Messages}",
                mainMessageVerb,
                Environment.NewLine,
                FormatBasePackets(packets)
            );
        }

        private static string FormatBasePackets(IReadOnlyList<BasePacket> packets)
        {
            return string.Join(
                Environment.NewLine,
                packets.Select(packet =>
                    packet.Message is not null
                        ? $"{packet.MsgId}: {packet.Message}"
                        : $"{packet.MsgId}: <unparsed> {"" ?? "<unknown parse error>"}"
                )
            );
        }

        private static string FormatOutgoingMessages(MainMessage message)
        {
            return FormatBasePackets(message.Packets);
        }
    }
}
