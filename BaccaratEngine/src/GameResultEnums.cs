using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaccaratEngine
{
    

    public enum MoRoad
    {
        None,
        Red, 
        Blue
    }

    public static class GameBit
    {
        public const uint TaSignalBitsMask = 0xFFFFFF00;

        public const int POS_GResult = 1;
        public const int POS_GResult_length = 2;
        public const int POS_GNatural = POS_GResult + POS_GResult_length;
        public const int POS_GNatural_length = 3;
        public const int POS_GPair = POS_GNatural + POS_GNatural_length;
        public const int POS_GPair_length = 4;
        public const int POS_GTie = POS_GPair + POS_GPair_length;
        public const int POS_GTie_length = 3;
        public const int POS_GMonster = POS_GTie + POS_GTie_length;
        public const int POS_GMonster_length = 5;        
    }

    
    public enum GResult : byte
    {
        None = 0,
        B = 1,
        P = 2,
        T = 3
    }

    public enum GNatural : byte
    {
        None = 0,
        B8 = 1,
        B9 = 2,
        P8 = 3,
        P9 = 4
    }

    public enum GPair : byte
    {
        None = 0,
        BB = 1,
        PP = 2,
        B33,
        B44,
        B99,
        P33,
        P44,
        P99,
        BBPP
    }

    

    public enum GTie : byte
    {
        None = 0,
        T0 = 1,
        T6 = 2,        
    }



    public enum GMonster : byte
    {
        None = 0,
        B6 = 1,        // Lucky 6
        B63 = 2,       // Lucky 6 with 3 cards
        P7 = 3,        // player lucky 7
        P76 = 4,       // Player lucky 7 with over 6        
        P83 = 5,       // Player get 8 with 3 cards 
        B763 = 6,
        T0, 
        T6,
        T
    }

    public enum DImageIndex
    {
        None = 0,
        Red = 1,          // Banker win
        Blue = 2,          // Player Win
    }

    public enum GImageIndex
    {
        None = 0,
        B = 1,          // Banker win
        P = 2,          // Player Win
        T = 3,          // Game is Tie
        B8 = 4,         // Banker natural 8
        B9 = 5,         // Banker natural 9
        P8 = 6,         // Player natural 8
        P9 = 7,         // Player natural 9
        B6 = 8,        // Lucky 6
        B63 = 9,       // Lucky 6 with 3 cards
        P7 = 10,        // player lucky 7
        P76 = 11,       // Player lucky 7 with over 6        
        T6 = 12,        // Tiger Tie
        B763 = 13,
        P83 = 14,       // Player get 8 with 3 cards        
        
        
        B33 = 24,
        B44 = 15,
        B99 = 16,
        P33 = 17,
        P44 = 18,
        P99 = 19,
        BBPP = 20,
        T0 = 21,        // Tie at 0
        BB = 22,         // Banker has pair
        PP = 23,         // Player has pair
        
    }

}
