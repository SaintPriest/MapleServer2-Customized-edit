﻿using MaplePacketLib2.Tools;
using MapleServer2.Constants;
using MapleServer2.Types;

namespace MapleServer2.Packets
{
    public static class VibratePacket
    {
        public static Packet Vibrate(string objectHash, SkillCast skillCast, IFieldObject<Player> player)
        {
            PacketWriter pWriter = PacketWriter.Of(SendOp.VIBRATE);
            pWriter.WriteByte(1);
            pWriter.WriteMapleString(objectHash);
            pWriter.WriteLong(skillCast.SkillSN);
            pWriter.WriteInt(skillCast.SkillId);
            pWriter.WriteShort(skillCast.SkillLevel);
            pWriter.WriteByte(); // motion point?
            pWriter.WriteByte();
            pWriter.Write(player.Coord.ToShort());
            pWriter.Write(player.Value.Session.ServerTick);
            pWriter.WriteMapleString("");
            pWriter.WriteByte();

            return pWriter;
        }
    }
}
