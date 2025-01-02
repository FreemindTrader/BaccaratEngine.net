using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaccaratEngine
{
    public class GameAnalysisHelper
    {
        public enum RoadType
        {
            None,
            BigRoad,        // 大路
            BeadPlate,      // 珠盘
            BigEye,         // 大眼路
            SmallRoad,      // 小路
            CockRoachRoad,  // 蟑螂路
        }
        public enum RoadLength
        {
            None,
            Short,              // 短牌, 1-3 Rows
            Medium,             // 中牌, 4-5 Rows     
            Long,               // 长牌, 6+ Rows
            GoldenRoad = Long   // 金庄, 金闲.
        }

        public enum  MajorColor
        {
            None,
            Red = 1,
            Banker = Red,
            Blue = 2,
            Player = Blue
        }

        public enum ChopOrStreaks
        {
            None,
            Chop,           // 跳牌
            Streaks,        // 连
        }

        public enum Patterns
        {
            None,
            Symmetry,           // 1.	对称
            SameHeight,         // 2.	等高
            MirrorImage,        // 3.	镜像
            Cowboy,             // 4.	牛郎织女
            Valley,             // 5.	噶其
            BigFall,            // 6.	高跳
            SameLevel,          // 7.	齐头
            Pattern321,         // 8.	图形 3-2-1
            Pattern1234,        // 10.	图形 1-2-3-4
            Chops,              // 11.	大间隔
            Streaks,            // 12.  长龙
        }

        public enum BetConclusion
        {
            Skip = 0,
            Banker = 1,
            Player = 2,
            Tie    = 3,
            Lucky6 = 4,
            Lucky7 = 5,
        }
    }

}
