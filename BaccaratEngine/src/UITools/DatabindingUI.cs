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

        public static BindingList<bigRoadPos> ToBindingList( this IList<bigRoadPos> bigRoadItems, int maxColumns )
        {
            var bindingList = new BindingList<bigRoadPos>();

            return bindingList;
        }
    }

}