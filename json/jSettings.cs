using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsgCountPlusNET.json
{
    public class jSettings
    {
        public ulong id = 0;
        public string name = String.Empty;
        public List<jRankReward> rankRewards = new List<jRankReward>();
        public bool allowLevels = true;
        public bool allowScoring = true;
        public bool allowRankRewards = false;
        public bool rewardOnLevel = true; //true = rewards are based on level || false = reward based on score
        public bool specialScoreSwitch = true; //true = use msg / time || false = use raw message count
        public double scoreinterval = 1; //interval by which score is measured || 1 = 1 day etc.

        public string s1;
        public string s2 = " is now at rank ";

        public string rewardMessage(string name, string rewardName) {
            return s1 + name + s2 + rewardName;
        }
        public jRankReward checkRewards(int score)
        {
            jRankReward tmp;
            jRankReward potential = new jRankReward() { scoreThreshold = 0 };
            for (int i = 0; i < rankRewards.Count; i++)
            {
                tmp = rankRewards[i];
                if (tmp.scoreThreshold > score)
                {
                    continue;
                }
                else
                {
                    if (tmp.scoreThreshold > potential.scoreThreshold)
                    {
                        potential = tmp;
                    }
                    else continue;
                }
            }
            return potential;
        }
    }
}
