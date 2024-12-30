using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Common;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BaccaratEngine
{    
    public class xColumn : INotifyPropertyChanged
    {
        public xColumn() { }


        int row0;
        int row5;
        int row4;
        int row3;
        int row2;
        int row1;

        protected void OnPropertyChanged( [CallerMemberName] string propertyName = "" )
        {
            if (PropertyChanged != null)
                PropertyChanged( this, new PropertyChangedEventArgs( propertyName ) );
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public int Row0
        {
            get => row0;
            set
            {
                if (row0 != value)
                {
                    row0 = value;
                    OnPropertyChanged();
                }
            }
        }

        public int Row1
        {
            get => row1;
            set
            {
                if (row1 != value)
                {
                    row1 = value;
                    OnPropertyChanged();
                }
            }
        }


        public int Row2
        {
            get => row2;
            set
            {
                if (row2 != value)
                {
                    row2 = value;
                    OnPropertyChanged();
                }
            }
        }


        public int Row3
        {
            get => row3;
            set
            {
                if (row3 != value)
                {
                    row3 = value;
                    OnPropertyChanged();
                }
            }
        }


        public int Row4
        {
            get => row4;
            set
            {
                if (row4 != value)
                {
                    row4 = value;
                    OnPropertyChanged();
                }
            }
        }


        public int Row5
        {
            get => row5;
            set
            {
                if (row5 != value)
                {
                    row5 = value;
                    OnPropertyChanged();
                }
            }
        }

        
        
        
    }
}
