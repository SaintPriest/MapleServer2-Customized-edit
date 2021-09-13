﻿using Maple2Storage.Types;
using MapleServer2.Database.Types;
using SqlKata.Execution;

namespace MapleServer2.Database.Classes
{
    public class DatabaseMeretMarket : DatabaseTable
    {
        public DatabaseMeretMarket() : base("MeretMarketItems") { }

        public List<MeretMarketItem> FindAllByCategoryId(MeretMarketCategory category)
        {
            List<MeretMarketItem> items = QueryFactory.Query(TableName).Where("Category", (int) category).Get<MeretMarketItem>().ToList();
            foreach (MeretMarketItem item in items.Where(x => x.BannerId != 0))
            {
                item.Banner = DatabaseManager.Banners.FindById(item.BannerId);
            }
            return items;
        }

        public MeretMarketItem FindById(int id) => QueryFactory.Query(TableName).Where("MarketId", id).Get<MeretMarketItem>().FirstOrDefault();
    }
}
