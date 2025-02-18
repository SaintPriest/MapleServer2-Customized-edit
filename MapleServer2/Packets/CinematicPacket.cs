﻿using Maple2.Trigger.Enum;
using MaplePacketLib2.Tools;
using MapleServer2.Constants;

namespace MapleServer2.Packets
{
    public static class CinematicPacket
    {
        private enum CinematicPacketMode : byte
        {
            HideUi = 0x1,
            View = 0x3,
            SetSceneSkip = 0x4,
            StartSceneSkip = 0x5,
            Conversation = 0x6,
            BalloonTalk = 0x8,
            Caption = 0xA,
        }

        public static Packet HideUi(bool hide)
        {
            PacketWriter pWriter = PacketWriter.Of(SendOp.CINEMATIC);
            pWriter.WriteEnum(CinematicPacketMode.HideUi);
            pWriter.WriteBool(hide);
            return pWriter;
        }

        public static Packet View(int type)
        {
            PacketWriter pWriter = PacketWriter.Of(SendOp.CINEMATIC);
            pWriter.WriteEnum(CinematicPacketMode.View);
            pWriter.WriteInt(type);
            pWriter.WriteUnicodeString("");
            pWriter.WriteUnicodeString("");
            return pWriter;
        }

        public static Packet SetSceneSkip(string skipState)
        {
            PacketWriter pWriter = PacketWriter.Of(SendOp.CINEMATIC);
            pWriter.WriteEnum(CinematicPacketMode.SetSceneSkip);
            pWriter.WriteByte(1); //??
            pWriter.WriteMapleString(skipState);
            return pWriter;
        }

        public static Packet StartSceneSkip()
        {
            PacketWriter pWriter = PacketWriter.Of(SendOp.CINEMATIC);
            pWriter.WriteEnum(CinematicPacketMode.StartSceneSkip);
            return pWriter;
        }

        public static Packet Conversation(int npcId, string stringId, int delay, Align align)
        {
            PacketWriter pWriter = PacketWriter.Of(SendOp.CINEMATIC);
            pWriter.WriteEnum(CinematicPacketMode.Conversation);
            pWriter.WriteInt(npcId);
            pWriter.WriteMapleString(npcId.ToString());
            pWriter.WriteUnicodeString(stringId);
            pWriter.WriteInt(delay);
            pWriter.WriteEnum(align);
            return pWriter;
        }

        public static Packet BalloonTalk(int objectId, bool isNpcId, string msg, int duration, int delayTick)
        {
            PacketWriter pWriter = PacketWriter.Of(SendOp.CINEMATIC);
            pWriter.WriteEnum(CinematicPacketMode.BalloonTalk);
            pWriter.WriteBool(isNpcId);
            pWriter.WriteInt(objectId);
            pWriter.WriteUnicodeString(msg);
            pWriter.WriteInt(duration);
            pWriter.WriteInt(delayTick);
            return pWriter;
        }

        public static Packet Caption(CaptionType type, string title, string script, string align, float offsetRateX, float offsetRateY, int duration, float scale)
        {
            PacketWriter pWriter = PacketWriter.Of(SendOp.CINEMATIC);
            pWriter.WriteEnum(CinematicPacketMode.Caption);
            pWriter.WriteUnicodeString(type.ToString() + "Caption");
            pWriter.WriteUnicodeString(title);
            pWriter.WriteUnicodeString(script);
            pWriter.WriteUnicodeString(align);
            pWriter.WriteInt(duration);
            pWriter.WriteFloat(offsetRateX);
            pWriter.WriteFloat(offsetRateY);
            pWriter.WriteFloat(scale);
            return pWriter;
        }
    }
}
