﻿using System.Xml;
using GameDataParser.Files;
using Maple2.File.IO.Crypto.Common;
using Maple2Storage.Types.Metadata;

namespace GameDataParser.Parsers
{
    internal class MasteryParser : Exporter<List<MasteryMetadata>>
    {
        public MasteryParser(MetadataResources resources) : base(resources, "mastery") { }

        protected override List<MasteryMetadata> Parse()
        {
            List<MasteryMetadata> masteryList = new List<MasteryMetadata>();
            foreach (PackFileEntry entry in Resources.XmlReader.Files)
            {
                if (!entry.Name.StartsWith("table/mastery") || entry.Name.StartsWith("table/masteryrecipe"))
                {
                    continue;
                }

                XmlDocument document = Resources.XmlReader.GetXmlDocument(entry);
                XmlNodeList masteries = document.SelectNodes("/ms2/mastery");

                foreach (XmlNode mastery in masteries)
                {
                    MasteryMetadata newMastery = new MasteryMetadata();
                    newMastery.Type = int.Parse(mastery.Attributes["type"].Value);

                    XmlNodeList grades = mastery.SelectNodes("v");

                    foreach (XmlNode grade in grades)
                    {
                        if (grade == null)
                        {
                            continue;
                        }

                        MasteryGrade newGrade = new MasteryGrade()
                        {
                            Grade = string.IsNullOrEmpty(grade.Attributes["grade"]?.Value)
                                ? 0
                                : int.Parse(grade.Attributes["grade"].Value),
                            Value = string.IsNullOrEmpty(grade.Attributes["value"]?.Value)
                                ? 0
                                : long.Parse(grade.Attributes["value"].Value),
                            RewardJobItemID = string.IsNullOrEmpty(grade.Attributes["rewardJobItemID"]?.Value)
                                ? 0
                                : int.Parse(grade.Attributes["rewardJobItemID"].Value),
                            RewardJobItemRank = string.IsNullOrEmpty(grade.Attributes["rewardJobItemRank"]?.Value)
                                ? 0
                                : int.Parse(grade.Attributes["rewardJobItemRank"].Value),
                            RewardJobItemCount = string.IsNullOrEmpty(grade.Attributes["rewardJobItemCount"]?.Value)
                                ? 0
                                : int.Parse(grade.Attributes["rewardJobItemCount"].Value),
                            Feature = grade.Attributes["feature"]?.Value
                        };

                        newMastery.Grades.Add(newGrade);
                    }

                    masteryList.Add(newMastery);
                }
            }

            return masteryList;
        }
    }
}
