using BaccaratEngine;
using DevExpress.CodeParser.Diagnostics;
using DevExpress.Diagram.Core.Native;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static DevExpress.Xpo.Helpers.AssociatedCollectionCriteriaHelper;

namespace RoadMapUI
{
    public partial class RoadMapUI : DevExpress.XtraEditors.DirectXForm
    {
        private BindingList<xColumn> _bigRoadBindingList = new BindingList<xColumn>();
        private BindingList<xColumn> _beadPlateBindingList = new BindingList<xColumn>();
        private BindingList<xColumn> _bigEyeRoadBindingList = new BindingList<xColumn>();
        private BindingList<xColumn> _smallRoadBindingList = new BindingList<xColumn>();
        private BindingList<xColumn> _cockroachBindingList = new BindingList<xColumn>();


        public RoadMapUI()
        {
            InitializeComponent();                                   
        }

        

        protected override void OnLoad( EventArgs e )
        {            
            PopulateData();

            _bigRoadGrid.DataSource = _bigRoadBindingList;
            _beadPlateGridControl.DataSource = _beadPlateBindingList;
            _bigEyeGrid.DataSource = _bigEyeRoadBindingList;
            _smallRoadGrid.DataSource = _smallRoadBindingList;
            _cockRoachGrid.DataSource = _cockroachBindingList;

            base.OnLoad( e );
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
            _bigRoadBindingList = _generator.initBindingList( 110 );
            _beadPlateBindingList = _generator.initBindingList( 50 );
            _bigEyeRoadBindingList = _generator.initBindingList( 70 ); ;
            _smallRoadBindingList = _generator.initBindingList( 70 ); ;
            _cockroachBindingList = _generator.initBindingList( 70 ); ;

            List<GameResult> gameResults = new List<GameResult>();

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
            gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'banker8', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'banker8', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.B, GNatural.B8 ) );           //  {'outcome': 'b )); // 'natural': 'banker8', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.B, GNatural.B9 ) );           //  {'outcome': 'b )); // 'natural': 'banker8', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'banker8', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'banker8', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'banker8', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'banker8', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.T ) );           //  {'outcome': 't )); //natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.T ) );           //  {'outcome': 't )); //natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.T ) );           //  {'outcome': 't )); //natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.T ) );           //  {'outcome': 't )); //natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.T ) );           //  {'outcome': 't )); //natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.T, GMonster.T6 ) );           //  {'outcome': 't )); //natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.T ) );           //  {'outcome': 't )); //natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.T ) );           //  {'outcome': 't )); //natural': 'none', 'pair': 'none'},


            gameResults.Add( new GameResult( GResult.P, GNatural.P8 ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.P, GNatural.P9 ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.P, GMonster.P7 ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.P, GMonster.P76 ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'}

            gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.B, GMonster.B63 ) );           //  {'outcome': 'b )); // 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.B, GMonster.B6 ) );           //  {'outcome': 'b )); // 'natural': 'banker8', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'p )); //},
            gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'banker8', 'pair': 'both'},
            gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'banker8', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.B, GMonster.B763 ) );           //  {'outcome': 'b )); // 'natural': 'banker9', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'player8', 'pair': 'p )); //},
            gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'banker8', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.P ) );           //  {'outcome': 'p )); //, 'natural': 'player8', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.B ) );           //  {'outcome': 'b )); // 'natural': 'none', 'pair': 'none'},
            gameResults.Add( new GameResult( GResult.P, GMonster.P83 ) );           //  {'outcome': 'p )); //, 'natural': 'none', 'pair': 'none'},
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


            var result = _generator.bigRoadShowTies( gameResults, 100, 6 );
            //var result = _generator.bigRoad( gameResults, 100, 6 );
            _bigRoad = result.RoadList;

            var beadPlate = _generator.beadPlate( gameResults, 50, 6 );

            _bigRoadBindingList = _bigRoad.UpdateBindingList( _bigRoadBindingList, result.MaxColumn );
            _beadPlateBindingList = beadPlate.UpdateBindingList( _beadPlateBindingList, result.MaxColumn );

        }
    }
}
