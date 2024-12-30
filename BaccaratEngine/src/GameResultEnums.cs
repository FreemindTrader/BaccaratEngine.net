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
        P = 10,
        B = 20,
        T = 30,
    }

    public enum BaccaratEx
    {
        None = 0,
        P = 10,
        P8 = 11,
        P9 = 12,                
        P7 = 13,
        P76 = 14,
        P83 = 15,
        PP = 16,

        B = 20,        
        B8 = 21,
        B9 = 22,
        B6 = 23,
        B63 = 24,
        B7 = 25,
        B76 = 26,
        BB = 27,

        T = 30,
        T0 = 31,
        T6 = 32,

        BBPP = 40
    }    
}
