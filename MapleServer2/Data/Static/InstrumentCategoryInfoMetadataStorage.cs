﻿using Maple2Storage.Types;
using Maple2Storage.Types.Metadata;
using ProtoBuf;

namespace MapleServer2.Data.Static
{
    public static class InstrumentCategoryInfoMetadataStorage
    {
        private static readonly Dictionary<int, InstrumentCategoryInfoMetadata> package = new Dictionary<int, InstrumentCategoryInfoMetadata>();

        public static void Init()
        {
            using FileStream stream = File.OpenRead($"{Paths.RESOURCES}/ms2-instrument-category-info-metadata");
            List<InstrumentCategoryInfoMetadata> items = Serializer.Deserialize<List<InstrumentCategoryInfoMetadata>>(stream);
            foreach (InstrumentCategoryInfoMetadata item in items)
            {
                package[item.CategoryId] = item;
            }
        }

        public static bool IsValid(int categoryId)
        {
            return package.ContainsKey(categoryId);
        }

        public static InstrumentCategoryInfoMetadata GetMetadata(int categoryId)
        {
            return package.GetValueOrDefault(categoryId);
        }

        public static int GetId(int categoryId)
        {
            return package.GetValueOrDefault(categoryId).CategoryId;
        }
    }
}
