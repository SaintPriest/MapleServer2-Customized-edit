﻿using Maple2Storage.Enums;
using MapleServer2.Database;

namespace MapleServer2.Types
{
    public class Account
    {
        public long Id { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public long CreationTime { get; set; }
        public long LastLoginTime { get; set; }
        public int CharacterSlots { get; set; }
        public long VIPExpiration { get; set; }

        public Currency Meret { get; set; }
        public Currency GameMeret { get; set; }
        public Currency EventMeret { get; set; }
        public Currency MesoToken { get; private set; }

        public long HomeId;
        public Home Home;
        public BankInventory BankInventory;

        public Account() { }

        public Account(long accountId, string username, string passwordHash,
            long creationTime, long lastLoginTime, int characterSlots, long meretAmount,
            long gameMeretAmount, long eventMeretAmount, long mesoTokens, long homeId, long vipExpiration,
            BankInventory bankInventory)
        {
            Id = accountId;
            Username = username;
            PasswordHash = passwordHash;
            CreationTime = creationTime;
            LastLoginTime = lastLoginTime;
            CharacterSlots = characterSlots;
            Meret = new Currency(CurrencyType.Meret, meretAmount);
            GameMeret = new Currency(CurrencyType.GameMeret, gameMeretAmount);
            EventMeret = new Currency(CurrencyType.EventMeret, eventMeretAmount);
            MesoToken = new Currency(CurrencyType.MesoToken, mesoTokens);
            BankInventory = bankInventory;
            VIPExpiration = vipExpiration;
            HomeId = homeId;
        }

        public Account(string username, string passwordHash)
        {
            Username = username;
            PasswordHash = passwordHash;
            CreationTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds() + Environment.TickCount;
            LastLoginTime = CreationTime;
            CharacterSlots = 50;
            Meret = new Currency(CurrencyType.Meret, 0);
            GameMeret = new Currency(CurrencyType.GameMeret, 0);
            EventMeret = new Currency(CurrencyType.EventMeret, 0);
            MesoToken = new Currency(CurrencyType.MesoToken, 0);
            BankInventory = new BankInventory();

            Id = DatabaseManager.Accounts.Insert(this);
        }

        public bool RemoveMerets(long amount)
        {
            if (Meret.Modify(-amount) || GameMeret.Modify(-amount) || EventMeret.Modify(-amount))
            {
                return true;
            }

            if (Meret.Amount + GameMeret.Amount + EventMeret.Amount >= amount)
            {
                long rest = Meret.Amount + GameMeret.Amount + EventMeret.Amount - amount;
                Meret.SetAmount(rest);
                GameMeret.SetAmount(0);
                EventMeret.SetAmount(0);

                return true;
            }

            return false;
        }

        public bool IsVip()
        {
            return VIPExpiration > DateTimeOffset.UtcNow.ToUnixTimeSeconds();
        }
    }
}
