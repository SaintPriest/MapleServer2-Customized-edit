﻿using MapleServer2.Database;
using MapleServer2.Types;

namespace MapleServer2.Managers
{
    public class BuddyManager
    {
        private readonly Dictionary<long, Buddy> BuddyList;

        public BuddyManager()
        {
            BuddyList = new Dictionary<long, Buddy>();
            List<Buddy> list = DatabaseManager.Buddies.FindAll();
            foreach (Buddy buddy in list)
            {
                AddBuddy(buddy);
            }
        }

        public void AddBuddy(Buddy buddy) => BuddyList.Add(buddy.Id, buddy);

        public void RemoveBuddy(Buddy buddy) => BuddyList.Remove(buddy.Id);

        public List<Buddy> GetBuddies(long characterId) => BuddyList.Values.Where(b => b.CharacterId == characterId).ToList();

        public Buddy GetBuddyByPlayerAndId(Player player, long id) =>
            BuddyList.Values.ToList()
            .Where(o => o.Friend.CharacterId != player.CharacterId && o.SharedId == id)
            .FirstOrDefault();

        public static bool IsFriend(Player player1, Player player2) =>
            player1.BuddyList.Any(o => o.Friend.CharacterId == player2.CharacterId && o.Blocked == false);

        public static bool IsBlocked(Player player, Player otherPlayer) =>
            otherPlayer.BuddyList.Any(o => o.Friend.CharacterId == player.CharacterId && o.Blocked == true);

        public void SetFriendSessions(Player player) =>
            BuddyList.Values.Where(x => x.Friend.CharacterId == player.CharacterId).ToList().ForEach(x => x.Friend.Session = player.Session);
    }
}
