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
        Image _image = Image.FromFile( "c:\\circle2.png" );
        Image _blue = Image.FromFile( "c:\\circle3.png" );
        public RoadMapUI()
        {
            InitializeComponent();            
            
            //_roadmapGridControl.CustomDrawRowValueCell += _roadmapGrid_CustomDrawRowValueCell;
            //_roadmapGridControl.CustomRecordCellEdit += _roadmapGridControl_CustomRecordCellEdit;
        }

        private void _roadmapGridControl_CustomRecordCellEdit( object sender, DevExpress.XtraVerticalGrid.Events.GetCustomRowCellEditEventArgs e )
        {
            
        }

        protected override void OnLoad( EventArgs e )
        {            
            PopulateData();

            _roadmapGridControl.DataSource = _roadMapColumns;

            base.OnLoad( e );
        }

        private void _roadmapGrid_CustomDrawRowValueCell( object sender, DevExpress.XtraVerticalGrid.Events.CustomDrawRowValueCellEventArgs e )
        {
            //e.DefaultDraw();
            // Paint images in cells if discounts > 0.
            //
            
            if ( e.CellText == "1")
                e.Cache.DrawImage( _image, e.Bounds.Location );
            else if ( e.CellText == "2")
                e.Cache.DrawImage( _blue, e.Bounds.Location );

            e.Appearance.BackColor = Color.FromArgb( 60, Color.White );

            e.Handled = true;
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
            _roadMapColumns = _generator.createBigRoadBindingList( 110 );

            List<GameResult> gameResults = new List<GameResult>();
            //[
            gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
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
            
            

            _roadMapColumns = _bigRoad.UpdateBindingList( _roadMapColumns, result.MaxColumn );

        }
    }
}
