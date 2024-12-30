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


        BaccaratEx row6;
        BaccaratEx row5;
        BaccaratEx row4;
        BaccaratEx row3;
        BaccaratEx row2;
        BaccaratEx row1;

        public BaccaratEx Row1
        {
            get => row1;
            set => row1 = value;
        }


        public BaccaratEx Row2
        {
            get => row2;
            set => row2 = value;
        }


        public BaccaratEx Row3
        {
            get => row3;
            set => row3 = value;
        }


        public BaccaratEx Row4
        {
            get => row4;
            set => row4 = value;
        }


        public BaccaratEx Row5
        {
            get => row5;
            set => row5 = value;
        }

        
        public BaccaratEx Row6
        {
            get => row6;
            set => row6 = value;
        }
        
    }
}
