using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaccaratEngine
{
    public enum GameResultOutcomes
    {
        Player,
        Banker,
        Tie
    }

    public enum GameResultNatural
    {
        NoNatural,
        PlayerNatural8,
        PlayerNatural9,
        BankerNatural8,
        BankerNatural9        
    }

    public enum GameResultPair
    {
        NoPair,
        PlayerPair,
        BankerPair,
        BothPair,        
    }

    public enum GameResultMonster
    {
        NoMonster = 0,
        Tie =1,
        TigerTie, 
        Lucky6,        
        Lucky63 = 3,
        Lucky7,
        Lucky73,
        Tiger,
        Dragon,
        Panda
    }
}
