using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaccaratEngine
{    
    public class xColumn
    {
        public xColumn() { }


        GBits row0;
        GBits row5;
        GBits row4;
        GBits row3;
        GBits row2;
        GBits row1;

        public GBits Row0
        {
            get => row0;
            set => row0 = value;
        }

        public GBits Row1
        {
            get => row1;
            set => row1 = value;
        }


        public GBits Row2
        {
            get => row2;
            set => row2 = value;
        }


        public GBits Row3
        {
            get => row3;
            set => row3 = value;
        }


        public GBits Row4
        {
            get => row4;
            set => row4 = value;
        }


        public GBits Row5
        {
            get => row5;
            set => row5 = value;
        }

        
        
        
    }
}
