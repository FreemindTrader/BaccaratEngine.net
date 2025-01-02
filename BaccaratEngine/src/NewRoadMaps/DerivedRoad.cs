using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaccaratEngine
{
    public abstract class DerivedRoad : RoadMapCore
    {
        /// <summary>
        /// Derived Road using the given cycle
        /// </summary>
        /// <param name="initBigRoad">initBigRoad The big road data</param>
        /// <param name="cycleLength">Cycle used to calculate the derived road</param>
        /// <returns>A new list of derived road items (i.e., list of red/blue)</returns>
        public IList<MoRoad> derivedRoad( IList<bigRoadPos> initBigRoad, int cycleLength )
        {
            var columnDefinitionsDictionary = this.bigRoadColumnDefinitions( initBigRoad );
            /*
                1.    Let k be the Cycle of the roadmap.  k = 1 for big eye road.
                2.    Assume that the last icon added to the 大路 (Big Road) is on row m of column n.
                2.a.    If m >= 2, we compare with column (n-k).
                2.a.1.    If there is no such column (i.e. before the 1st column) …  No need to add any icon.
                2.a.2.    If there is such a column, and the column has p icons.
                2.a.2.1.    If m <= p  …  The answer is red.
                2.a.2.2.    If m = p + 1  …  The answer is blue.
                2.a.2.3.    If m > p + 1  … The answer is red.
                2.b.    If m = 1, reverse the result (Banker to Player, and vice versa), determine the result as in rule 2.a above, and reverse the answer (Red to blue, and vice versa) to get the real answer.
            */
            IList<MoRoad> outcomes = new List<MoRoad>();
            var k = cycleLength;

            var columnDefinitions = columnDefinitionsDictionary.Values;

            foreach (var bigRoadColumn in columnDefinitions)
            {
                var outcome = MoRoad.Blue;
                var n = bigRoadColumn.LogicalColumn;

                for (var m = 0; m < bigRoadColumn.LogicalColumnDepth; m++)
                {
                    var rowMDepth = m + 1;

                    if (rowMDepth >= 2)
                    {
                        var compareColumn = n - k;

                        // Step 2.a.1 - No column exists here.
                        // I seemed to have fixed a bug in the original Javascript code for BigEyeRoad. The second Column Second row was not calculated becuase the code was as followed
                        // if (compareColumn <= 0)
                        // I changed it to be as followed.
                        // Column 0 is there. Because in C#, we represent the first column as 0, instead of 1.
                        if (compareColumn < 0)
                            continue;

                        // Step 2.a.1
                        if (!columnDefinitionsDictionary.ContainsKey( compareColumn ))
                            continue;

                        var p = columnDefinitionsDictionary[compareColumn].LogicalColumnDepth;

                        if (rowMDepth <= p)
                        {
                            outcome = MoRoad.Red;
                        }
                        else if (rowMDepth == (p + 1))
                        {
                            outcome = MoRoad.Blue;
                        }
                        else if (rowMDepth > (p + 1))
                        {
                            outcome = MoRoad.Red;
                        }

                        outcomes.Add( outcome );
                    }
                    else
                    {
                        var kDistanceColumn = n - (k + 1);
                        var leftColumn = n - 1;

                        if (columnDefinitionsDictionary.ContainsKey( kDistanceColumn ) && columnDefinitionsDictionary.ContainsKey( leftColumn ))
                        {
                            var kDistanceColumnDefinition = columnDefinitionsDictionary[kDistanceColumn];
                            var leftColumnDefinition = columnDefinitionsDictionary[leftColumn];

                            if (kDistanceColumnDefinition.LogicalColumnDepth == leftColumnDefinition.LogicalColumnDepth)
                                outcome = MoRoad.Red;
                            else
                                outcome = MoRoad.Blue;

                            outcomes.Add( outcome );
                        }
                    }
                }
            }

            return outcomes;
        }
    }
}
