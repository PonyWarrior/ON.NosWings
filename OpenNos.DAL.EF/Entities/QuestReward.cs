﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenNos.DAL.EF
{
    public class QuestReward
    {
        #region Properties

        public long QuestRewardId { get; set; }

        public byte RewardType { get; set; }

        public int Data { get; set; }

        public int Amount { get; set; }

        public long QuestId { get; set; }

        #endregion
    }
}
