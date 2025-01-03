using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BaccaratEngine;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Layout;
using static DevExpress.Xpo.Helpers.AssociatedCollectionCriteriaHelper;

namespace RibbonRoadMapUI
{
    public partial class RoadMapUI : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private BindingList<xColumn> _bigRoadBindingList = new BindingList<xColumn>();
        private BindingList<xColumn> _beadPlateBindingList = new BindingList<xColumn>();
        private BindingList<xColumn> _bigEyeRoadBindingList = new BindingList<xColumn>();
        private BindingList<xColumn> _smallRoadBindingList = new BindingList<xColumn>();
        private BindingList<xColumn> _cockroachBindingList = new BindingList<xColumn>();

        private BindingList<xCards> _cardsDealtBindingList = new BindingList<xCards>();

        private BaccaratGameEngine _gameEngine;
        private BaccaratResultsEngine _gameResult;

        int _bigRoadInitColumn = 110;
        int _beadPlateInitColumns = 50;
        int _bigEyeInitColumns = 70;
        int _smallRoadInitColumns = 70;
        int _cockRoachInitColumns = 70;
        public RoadMapUI()
        {
            //UserLookAndFeel.Default.SetSkinStyle( SkinStyle.WXI );
            InitializeComponent();
            //_cardDealtGridView.ShownEditor += _cardDealtGridView_ShownEditor;
            _cardDealtGridView.CustomDrawCardBackground += _cardDealtGridView_CustomDrawCardBackground;
        }

        private void _cardDealtGridView_CustomDrawCardBackground( object sender, DevExpress.XtraGrid.Views.Layout.Events.LayoutViewCustomDrawCardBackgroundEventArgs e )
        {
            if (!e.IsFocused) return;
            // Perform default drawing
            e.DefaultDraw();
            using (var highlight = new SolidBrush( Color.FromArgb( 50, Color.LightSeaGreen ) ))
            {
                // Fill card with semi-transparent color
                e.Cache.FillRectangle( highlight, Rectangle.Inflate( e.Bounds, -1, -1 ) );
            }
        }

        protected override void OnLoad( EventArgs e )
        {
            PopulateData();

            _bigRoadGrid.DataSource = _bigRoadBindingList;
            _beadPlateRoadGrid.DataSource = _beadPlateBindingList;
            _bigEyeGrid.DataSource = _bigEyeRoadBindingList;
            _smallRoadGrid.DataSource = _smallRoadBindingList;
            _cockRoachGrid.DataSource = _cockroachBindingList;
            _cardsDealtGrid.DataSource = _cardsDealtBindingList;

            base.OnLoad( e );
        }

        private RoadmapGenerator _generator = new RoadmapGenerator();

        private IList<bigRoadPos> _bigRoadShowTies = null;
        private IList<bigRoadPos> _bigRoadNoTies = null;
        private IList<beadPlatePos> _beadPlate = null;
        private IList<MoRoad> _bigEyeRoad = null;
        private IList<MoRoad> _smallRoad = null;
        private IList<MoRoad> _cockRoachRoad = null;

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


            _bigRoadBindingList = _generator.initBindingList( _bigRoadInitColumn );
            _beadPlateBindingList = _generator.initBindingList( _beadPlateInitColumns );
            _bigEyeRoadBindingList = _generator.initBindingList( _bigEyeInitColumns ); ;
            _smallRoadBindingList = _generator.initBindingList( _smallRoadInitColumns ); ;
            _cockroachBindingList = _generator.initBindingList( _cockRoachInitColumns ); ;

            var result = _generator.bigRoadShowTies( gameResults, 100, 6 );
            //var result = _generator.initBigRoad( gameResults, 100, 6 );
            _bigRoadShowTies = result.RoadList;

            var bigRoadNoTie = _generator.initBigRoad( gameResults, 100, 6 );
            _bigRoadNoTies = bigRoadNoTie.RoadList;

            _beadPlate = _generator.beadPlate( gameResults, 50, 6 );
            _bigEyeRoad = _generator.bigEyeRoad( _bigRoadNoTies );
            _smallRoad = _generator.smallRoad( _bigRoadNoTies );
            _cockRoachRoad = _generator.cockroachPig( _bigRoadNoTies );

            _bigRoadBindingList = _bigRoadShowTies.UpdateBindingList( _bigRoadBindingList, result.MaxColumn );
            _beadPlateBindingList = _beadPlate.UpdateBindingList( _beadPlateBindingList, result.MaxColumn );
            _smallRoadBindingList = _smallRoad.UpdateBindingList( _smallRoadBindingList, result.MaxColumn, 6 );
            _bigEyeRoadBindingList = _bigEyeRoad.UpdateBindingList( _bigEyeRoadBindingList, result.MaxColumn, 6 );
            _cockroachBindingList = _cockRoachRoad.UpdateBindingList( _cockroachBindingList, result.MaxColumn, 6 );

            var playerCard = new xCards();
            playerCard.SetCard1( Card.CardSuit.Club, Card.CardValue.CA );
            playerCard.SetCard2( Card.CardSuit.Diamond, Card.CardValue.C3 );
            playerCard.SetCard3( Card.CardSuit.Spade, Card.CardValue.CK );

            


            var bankerCard = new xCards();
            bankerCard.SetCard1( Card.CardSuit.Heart, Card.CardValue.CA );
            bankerCard.SetCard2( Card.CardSuit.Spade, Card.CardValue.C2 );
            bankerCard.SetCard3( Card.CardSuit.Diamond, Card.CardValue.CK );

            var card1 = bankerCard.Card1;
            var card2 = bankerCard.Card2;
            var card3 = bankerCard.Card3;

            _cardsDealtBindingList.Add( playerCard );
            _cardsDealtBindingList.Add( bankerCard );

        }

        protected override void OnShown( EventArgs e )
        {
            _bigRoadGrid.LeftVisibleRecord = Math.Max( 0, _bigRoadBindingList.Count - _bigRoadInitColumn / 2 );
            _beadPlateRoadGrid.LeftVisibleRecord = Math.Max( 0, _beadPlate.Count / 2 );
            _smallRoadGrid.LeftVisibleRecord = Math.Max( 0, _smallRoadBindingList.Count - _bigEyeInitColumns / 2 );
            _bigEyeGrid.LeftVisibleRecord = Math.Max( 0, _bigEyeRoadBindingList.Count - _smallRoadInitColumns / 2 );
            _cockRoachGrid.LeftVisibleRecord = Math.Max( 0, _cockroachBindingList.Count - _cockRoachInitColumns / 2 );

            base.OnShown( e );
        }

        private void _newLiveGame_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
        {
            _bigRoadBindingList.Clear(); 
            _beadPlateBindingList.Clear();
            _smallRoadBindingList.Clear();
            _bigEyeRoadBindingList.Clear();
            _cockroachBindingList.Clear();

            _bigRoadBindingList = _generator.initBindingList( _bigRoadInitColumn );
            _beadPlateBindingList = _generator.initBindingList( _beadPlateInitColumns );
            _bigEyeRoadBindingList = _generator.initBindingList( _bigEyeInitColumns ); ;
            _smallRoadBindingList = _generator.initBindingList( _smallRoadInitColumns ); ;
            _cockroachBindingList = _generator.initBindingList( _cockRoachInitColumns ); ;

            

            _bigRoadGrid.DataSource = _bigRoadBindingList;
            _beadPlateRoadGrid.DataSource = _beadPlateBindingList;
            _bigEyeGrid.DataSource = _bigEyeRoadBindingList;
            _smallRoadGrid.DataSource = _smallRoadBindingList;
            _cockRoachGrid.DataSource = _cockroachBindingList;

            _gameEngine = new BaccaratGameEngine();
            _gameResult = new BaccaratResultsEngine();
            _gameEngine.Shoe.createDecks();
            _gameEngine.Shoe.shuffle();
        }
    }


}
