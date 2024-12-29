using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaccaratEngine
{
    public enum MoRoad
    {
        Red, 
        Blue
    }

    public enum Baccarat
    {
        P,
        B,
        T
    }

    public enum Baccarat89
    {
        None,
        P8,
        P9,
        B8,
        B9        
    }

    public enum BaccaratPairs
    {
        None,
        PP,
        BB,
        BBPP,        
    }

    public enum BaccaratXXX
    {
        None = 0,
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
