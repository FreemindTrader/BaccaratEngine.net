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
    public static class UIExtensions
    {

        public static BindingList<xColumn> ToBindingList( this IList<bigRoadPos> bigRoadItems, int maxColumns )
        {
            var bindingList = new BindingList<xColumn>();

            for (int i = 0; i < maxColumns; i++)
            {
                var perColumn = bigRoadItems.Where( x => x.Column == i ).OrderBy( x => x.Row );

                if ( perColumn.Count() > 0 )
                {
                    var colEntry = new xColumn();

                    foreach (bigRoadPos brCell in perColumn)
                    {
                        switch (brCell.Row)
                        {
                            case 0:
                            colEntry.Row0 = brCell.Result.RawData;
                            break;
                            case 1:
                            colEntry.Row1 = brCell.Result.RawData;
                            break;
                            case 2:
                            colEntry.Row2 = brCell.Result.RawData;
                            break;
                            case 3:
                            colEntry.Row3 = brCell.Result.RawData;
                            break;
                            case 4:
                            colEntry.Row4 = brCell.Result.RawData;
                            break;
                            case 5:
                            colEntry.Row5 = brCell.Result.RawData;
                            break;
                        }
                    }
                }

                
            }
            return bindingList;
        }
    }

}