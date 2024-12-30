using BaccaratEngine;
using DevExpress.CodeParser.Diagnostics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RoadMapUI
{
    public partial class RoadMapUI : DevExpress.XtraEditors.DirectXForm
    {
        private BindingList<xColumn> _roadMapColumns = new BindingList<xColumn>();
        public RoadMapUI()
        {
            InitializeComponent();            
            
            _roadmapGrid.CustomDrawRowValueCell += _roadmapGrid_CustomDrawRowValueCell;
        }

        protected override void OnLoad( EventArgs e )
        {            
            PopulateData();

            _roadmapGrid.DataSource = _roadMapColumns;

            base.OnLoad( e );
        }

        private void _roadmapGrid_CustomDrawRowValueCell( object sender, DevExpress.XtraVerticalGrid.Events.CustomDrawRowValueCellEventArgs e )
        {
            //_bigRoad.Where( s => s.Row == e.Row && s.Column == e.)
            var cellIndex = e.CellIndex;
            var recordIndex = e.RecordIndex;

            var found = _bigRoad.Where( x => x.Column == recordIndex && x.Row == cellIndex );

            //if ( found.Count() > 0 )
            //{
            //    var outcome = found.First();
            //    e.CellText = outcome.Result.Outcome.ToString();
            //}
            //else
            //{
            //    e.CellText = "";
            //}



            //e.Handled = true;
        }

        private RoadmapGenerator _generator = new RoadmapGenerator();
        
        private new IList<bigRoadPos> _bigRoad = null;

        public class RoadMapBindingList : BindingList<xColumn>
        {

            protected override bool SupportsSearchingCore
            {
                get { return true; }
            }
            //protected override int FindCore( PropertyDescriptor prop, object key )
            //{
            //    // Ignore the prop value and search by family name.
            //    for (int i = 0; i < Count; ++i)
            //    {
            //        if (Items[i].Name.ToLower() == ((string)key).ToLower())
            //            return i;
            //    }
            //    return -1;
            //}
        }

        public void PopulateData()
        {
            List<GameResult> gameResults = new List<GameResult>();
            //[
            gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'player8', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'banker8', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'banker8', 'pair': 'b//},
            gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.T ) );           //  {'outcome': 't )); //natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'player8', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.T ) );           //  {'outcome': 't )); //natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'player9', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'player9', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.T ) );           //  {'outcome': 't )); //natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'player8', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'player9', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'player9', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'banker9', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'player9', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'banker8', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'player8', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.T ) );           //  {'outcome': 't )); //natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'banker9', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'player9', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.T ) );           //  {'outcome': 't )); //natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'banker8', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'banker8', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'p )); //},
            gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'banker8', 'pair': 'both'},
            gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'banker8', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'banker9', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'player8', 'pair': 'p )); //},
            gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'banker8', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'player8', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'banker9', 'pair': 'p )); //},
            gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'banker9', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'player8', 'pair': 'both'},
            gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'player9', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'banker8', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'player9', 'pair': 'b//},
            gameResults.Add( new GameResult( GResult.T ) );           //  {'outcome': 't )); //natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'player9', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'banker8', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.T ) );           //  {'outcome': 't )); //natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'player8', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'banker9', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.T ) );           //  {'outcome': 't )); //natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'banker9', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.T ) );           //  {'outcome': 't )); //natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'banker9', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'banker9', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'banker8', 'pair': 'p )); //},
            gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'}];


            var result = _generator.bigRoad( gameResults, 100, 6 );
            _bigRoad = result.RoadList;
            
            

            _roadMapColumns = _bigRoad.ToBindingList( result.MaxColumn );

        }
    }
}
