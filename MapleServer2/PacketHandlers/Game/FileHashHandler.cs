﻿using MaplePacketLib2.Tools;
using MapleServer2.Constants;
using MapleServer2.Servers.Game;

namespace MapleServer2.PacketHandlers.Game
{
    public class FileHashHandler : GamePacketHandler
    {
        public override RecvOp OpCode => RecvOp.FILE_HASH;

        public FileHashHandler() : base() { }

        public override void Handle(GameSession session, PacketReader packet)
        {
            packet.ReadInt();
            string filename = packet.ReadMapleString();
            string md5 = packet.ReadMapleString();

            Logger.Debug("Hash for {filename}: {md5}", filename, md5);
        }
    }
}
