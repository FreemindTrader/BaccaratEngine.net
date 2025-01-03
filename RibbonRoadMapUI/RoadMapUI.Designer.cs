﻿using DevExpress.Map.Kml.Model;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraLayout;
using System.Windows.Forms;

namespace RibbonRoadMapUI
{
    partial class RoadMapUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( RoadMapUI ) );
            ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            _newGame = new DevExpress.XtraBars.BarButtonItem();
            _bankerWin = new DevExpress.XtraBars.BarButtonItem();
            _playerWin = new DevExpress.XtraBars.BarButtonItem();
            _gameTie = new DevExpress.XtraBars.BarButtonItem();
            _banker8 = new DevExpress.XtraBars.BarButtonItem();
            _banker9 = new DevExpress.XtraBars.BarButtonItem();
            _player8 = new DevExpress.XtraBars.BarButtonItem();
            _player9 = new DevExpress.XtraBars.BarButtonItem();
            _lucky6 = new DevExpress.XtraBars.BarButtonItem();
            _lucky63Cards = new DevExpress.XtraBars.BarButtonItem();
            _lucky7 = new DevExpress.XtraBars.BarButtonItem();
            _lucky76 = new DevExpress.XtraBars.BarButtonItem();
            _panda = new DevExpress.XtraBars.BarButtonItem();
            _banker7Over6 = new DevExpress.XtraBars.BarButtonItem();
            _tigerTie = new DevExpress.XtraBars.BarButtonItem();
            skinDropDownButtonItem1 = new DevExpress.XtraBars.SkinDropDownButtonItem();
            skinPaletteDropDownButtonItem1 = new DevExpress.XtraBars.SkinPaletteDropDownButtonItem();
            barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            barCheckItem1 = new DevExpress.XtraBars.BarCheckItem();
            barCheckItem2 = new DevExpress.XtraBars.BarCheckItem();
            barCheckItem3 = new DevExpress.XtraBars.BarCheckItem();
            barCheckItem4 = new DevExpress.XtraBars.BarCheckItem();
            barCheckItem5 = new DevExpress.XtraBars.BarCheckItem();
            _newLiveGame = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            _uiLayoutControl = new LayoutControl();
            _cardsDealtGrid = new DevExpress.XtraGrid.GridControl();
            _cardDealtGridView = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            _card1 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            _cardImageCBEdit = new RepositoryItemImageComboBox();
            _svgCards = new DevExpress.Utils.SvgImageCollection( components );
            layoutViewField__playerCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            _card2 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            layoutViewField_layoutViewColumn1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            _card3 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            layoutViewField_layoutViewColumn1_1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            emptySpaceItem1 = new EmptySpaceItem();
            Item1 = new EmptySpaceItem();
            roadmapAnalysisControl1 = new RoadmapAnalysisUI.RoadmapAnalysisControl();
            _cockRoachGrid = new DevExpress.XtraVerticalGrid.VGridControl();
            _cockRoachCBEdit = new RepositoryItemImageComboBox();
            _cockRoachSvg = new DevExpress.Utils.SvgImageCollection( components );
            _cockRoachRow0 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            _cockRoachRow1 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            _cockRoachRow2 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            _cockRoachRow3 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            _cockRoachRow4 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            _cockRoachRow5 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            _bigEyeGrid = new DevExpress.XtraVerticalGrid.VGridControl();
            _bigEyeRoadCBEdit = new RepositoryItemImageComboBox();
            _bigEyeRoadSvg = new DevExpress.Utils.SvgImageCollection( components );
            _bigEyeRoad0 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            _bigEyeRoad1 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            _bigEyeRoad2 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            _bigEyeRoad3 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            _bigEyeRoad4 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            _bigEyeRoad5 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            _beadPlateRoadGrid = new DevExpress.XtraVerticalGrid.VGridControl();
            _beadPlateRepoCBEdit = new RepositoryItemImageComboBox();
            _beadPlateRoadSvg = new DevExpress.Utils.SvgImageCollection( components );
            _beadPlateRow0 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            _beadPlateRow1 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            _beadPlateRow2 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            _beadPlateRow3 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            _beadPlateRow4 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            _beadPlateRow5 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            _smallRoadGrid = new DevExpress.XtraVerticalGrid.VGridControl();
            _smallRoadImageCBEdit = new RepositoryItemImageComboBox();
            _smallRoadSvg = new DevExpress.Utils.SvgImageCollection( components );
            _smallRoadRow0 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            _smallRoadRow1 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            _smallRoadRow2 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            _smallRoadRow3 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            _smallRoadRow4 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            _smallRoadRow5 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            _bigRoadGrid = new DevExpress.XtraVerticalGrid.VGridControl();
            _bigRoadImageCBEdit = new RepositoryItemImageComboBox();
            _bigRoadSvg = new DevExpress.Utils.SvgImageCollection( components );
            _bigRoadRow0 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            _bigRoadRow1 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            _bigRoadRow2 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            _bigRoadRow3 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            _bigRoadRow4 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            _bigRoadRow5 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            _mainFormLayoutControlGroup = new LayoutControlGroup();
            _bigRoadLayoutControlItem = new LayoutControlItem();
            _smallRoadLayoutControlItem = new LayoutControlItem();
            _beadPlateLayoutControlItem = new LayoutControlItem();
            _bigEyeLayoutControlItem = new LayoutControlItem();
            _cockRoachLayoutControlItem = new LayoutControlItem();
            layoutControlItem1 = new LayoutControlItem();
            layoutControlItem2 = new LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_uiLayoutControl).BeginInit();
            _uiLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_cardsDealtGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_cardDealtGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_cardImageCBEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_svgCards).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutViewField__playerCard1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutViewField_layoutViewColumn1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutViewField_layoutViewColumn1_1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutViewCard1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Item1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_cockRoachGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_cockRoachCBEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_cockRoachSvg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_bigEyeGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_bigEyeRoadCBEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_bigEyeRoadSvg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_beadPlateRoadGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_beadPlateRepoCBEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_beadPlateRoadSvg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_smallRoadGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_smallRoadImageCBEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_smallRoadSvg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_bigRoadGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_bigRoadImageCBEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_bigRoadSvg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_mainFormLayoutControlGroup).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_bigRoadLayoutControlItem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_smallRoadLayoutControlItem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_beadPlateLayoutControlItem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_bigEyeLayoutControlItem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_cockRoachLayoutControlItem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            SuspendLayout();
            // 
            // ribbonControl1
            // 
            ribbonControl1.EmptyAreaImageOptions.ImagePadding = new Padding( 50, 51, 50, 51 );
            ribbonControl1.ExpandCollapseItem.Id = 0;
            ribbonControl1.Items.AddRange( new DevExpress.XtraBars.BarItem[ ] { ribbonControl1.ExpandCollapseItem, _newGame, _bankerWin, _playerWin, _gameTie, _banker8, _banker9, _player8, _player9, _lucky6, _lucky63Cards, _lucky7, _lucky76, _panda, _banker7Over6, _tigerTie, skinDropDownButtonItem1, skinPaletteDropDownButtonItem1, barButtonItem1, barButtonItem2, barButtonItem3, barCheckItem1, barCheckItem2, barCheckItem3, barCheckItem4, barCheckItem5, _newLiveGame, barButtonItem5 } );
            ribbonControl1.Location = new System.Drawing.Point( 0, 0 );
            ribbonControl1.Margin = new Padding( 5 );
            ribbonControl1.MaxItemId = 32;
            ribbonControl1.Name = "ribbonControl1";
            ribbonControl1.OptionsMenuMinWidth = 550;
            ribbonControl1.Pages.AddRange( new DevExpress.XtraBars.Ribbon.RibbonPage[ ] { ribbonPage3, ribbonPage1, ribbonPage2 } );
            ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office365;
            ribbonControl1.Size = new System.Drawing.Size( 1993, 237 );
            // 
            // _newGame
            // 
            _newGame.Caption = "New";
            _newGame.Id = 1;
            _newGame.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_newGame.ImageOptions.SvgImage" );
            _newGame.Name = "_newGame";
            // 
            // _bankerWin
            // 
            _bankerWin.Caption = "Banker";
            _bankerWin.Id = 4;
            _bankerWin.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_bankerWin.ImageOptions.SvgImage" );
            _bankerWin.Name = "_bankerWin";
            // 
            // _playerWin
            // 
            _playerWin.Caption = "Player";
            _playerWin.Id = 5;
            _playerWin.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_playerWin.ImageOptions.SvgImage" );
            _playerWin.Name = "_playerWin";
            // 
            // _gameTie
            // 
            _gameTie.Caption = "Tie";
            _gameTie.Id = 6;
            _gameTie.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_gameTie.ImageOptions.SvgImage" );
            _gameTie.Name = "_gameTie";
            // 
            // _banker8
            // 
            _banker8.Caption = "N8";
            _banker8.Id = 7;
            _banker8.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_banker8.ImageOptions.SvgImage" );
            _banker8.Name = "_banker8";
            // 
            // _banker9
            // 
            _banker9.Caption = "N9";
            _banker9.Id = 8;
            _banker9.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_banker9.ImageOptions.SvgImage" );
            _banker9.Name = "_banker9";
            // 
            // _player8
            // 
            _player8.Caption = "N8";
            _player8.Id = 9;
            _player8.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_player8.ImageOptions.SvgImage" );
            _player8.Name = "_player8";
            // 
            // _player9
            // 
            _player9.Caption = "N9";
            _player9.Id = 10;
            _player9.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_player9.ImageOptions.SvgImage" );
            _player9.Name = "_player9";
            // 
            // _lucky6
            // 
            _lucky6.Caption = "Lucky6";
            _lucky6.Id = 11;
            _lucky6.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_lucky6.ImageOptions.SvgImage" );
            _lucky6.Name = "_lucky6";
            // 
            // _lucky63Cards
            // 
            _lucky63Cards.Caption = "Lucky6(3)";
            _lucky63Cards.Id = 12;
            _lucky63Cards.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_lucky63Cards.ImageOptions.SvgImage" );
            _lucky63Cards.Name = "_lucky63Cards";
            // 
            // _lucky7
            // 
            _lucky7.Caption = "Lucky7";
            _lucky7.Id = 13;
            _lucky7.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_lucky7.ImageOptions.SvgImage" );
            _lucky7.Name = "_lucky7";
            // 
            // _lucky76
            // 
            _lucky76.Caption = "Lucky76";
            _lucky76.Id = 14;
            _lucky76.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_lucky76.ImageOptions.SvgImage" );
            _lucky76.Name = "_lucky76";
            // 
            // _panda
            // 
            _panda.Caption = "Panda";
            _panda.Id = 15;
            _panda.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_panda.ImageOptions.SvgImage" );
            _panda.Name = "_panda";
            // 
            // _banker7Over6
            // 
            _banker7Over6.Caption = "B76";
            _banker7Over6.Id = 16;
            _banker7Over6.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_banker7Over6.ImageOptions.SvgImage" );
            _banker7Over6.Name = "_banker7Over6";
            // 
            // _tigerTie
            // 
            _tigerTie.Caption = "Tiger Tie";
            _tigerTie.Id = 17;
            _tigerTie.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_tigerTie.ImageOptions.SvgImage" );
            _tigerTie.Name = "_tigerTie";
            // 
            // skinDropDownButtonItem1
            // 
            skinDropDownButtonItem1.ActAsDropDown = true;
            skinDropDownButtonItem1.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            skinDropDownButtonItem1.Id = 18;
            skinDropDownButtonItem1.Name = "skinDropDownButtonItem1";
            // 
            // skinPaletteDropDownButtonItem1
            // 
            skinPaletteDropDownButtonItem1.ActAsDropDown = true;
            skinPaletteDropDownButtonItem1.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            skinPaletteDropDownButtonItem1.Id = 19;
            skinPaletteDropDownButtonItem1.Name = "skinPaletteDropDownButtonItem1";
            // 
            // barButtonItem1
            // 
            barButtonItem1.Caption = "Banker";
            barButtonItem1.Id = 20;
            barButtonItem1.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "barButtonItem1.ImageOptions.SvgImage" );
            barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            barButtonItem2.Caption = "Player";
            barButtonItem2.Id = 21;
            barButtonItem2.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "barButtonItem2.ImageOptions.SvgImage" );
            barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            barButtonItem3.Caption = "Tie";
            barButtonItem3.Id = 22;
            barButtonItem3.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "barButtonItem3.ImageOptions.SvgImage" );
            barButtonItem3.Name = "barButtonItem3";
            // 
            // barCheckItem1
            // 
            barCheckItem1.Caption = "100";
            barCheckItem1.Id = 25;
            barCheckItem1.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "barCheckItem1.ImageOptions.SvgImage" );
            barCheckItem1.Name = "barCheckItem1";
            // 
            // barCheckItem2
            // 
            barCheckItem2.Caption = "500";
            barCheckItem2.Id = 26;
            barCheckItem2.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "barCheckItem2.ImageOptions.SvgImage" );
            barCheckItem2.Name = "barCheckItem2";
            // 
            // barCheckItem3
            // 
            barCheckItem3.Caption = "1000";
            barCheckItem3.Id = 27;
            barCheckItem3.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "barCheckItem3.ImageOptions.SvgImage" );
            barCheckItem3.Name = "barCheckItem3";
            // 
            // barCheckItem4
            // 
            barCheckItem4.Caption = "5000";
            barCheckItem4.Id = 28;
            barCheckItem4.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "barCheckItem4.ImageOptions.SvgImage" );
            barCheckItem4.Name = "barCheckItem4";
            // 
            // barCheckItem5
            // 
            barCheckItem5.Caption = "50";
            barCheckItem5.Id = 29;
            barCheckItem5.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "barCheckItem5.ImageOptions.SvgImage" );
            barCheckItem5.Name = "barCheckItem5";
            // 
            // _newLiveGame
            // 
            _newLiveGame.Caption = "New Game";
            _newLiveGame.Id = 30;
            _newLiveGame.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_newLiveGame.ImageOptions.SvgImage" );
            _newLiveGame.ItemShortcut = new DevExpress.XtraBars.BarShortcut( Keys.Control | Keys.N );
            _newLiveGame.Name = "_newLiveGame";
            _newLiveGame.ItemClick += _newLiveGame_ItemClick;
            // 
            // barButtonItem5
            // 
            barButtonItem5.Caption = "Deal";
            barButtonItem5.Id = 31;
            barButtonItem5.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "barButtonItem5.ImageOptions.SvgImage" );
            barButtonItem5.Name = "barButtonItem5";
            // 
            // ribbonPage3
            // 
            ribbonPage3.Groups.AddRange( new DevExpress.XtraBars.Ribbon.RibbonPageGroup[ ] { ribbonPageGroup8, ribbonPageGroup6, ribbonPageGroup7 } );
            ribbonPage3.Name = "ribbonPage3";
            ribbonPage3.Text = "Live";
            // 
            // ribbonPageGroup8
            // 
            ribbonPageGroup8.ItemLinks.Add( _newLiveGame );
            ribbonPageGroup8.ItemLinks.Add( barButtonItem5 );
            ribbonPageGroup8.Name = "ribbonPageGroup8";
            ribbonPageGroup8.Text = "New Game";
            // 
            // ribbonPageGroup6
            // 
            ribbonPageGroup6.ItemLinks.Add( barButtonItem1 );
            ribbonPageGroup6.ItemLinks.Add( barButtonItem2 );
            ribbonPageGroup6.ItemLinks.Add( barButtonItem3 );
            ribbonPageGroup6.Name = "ribbonPageGroup6";
            ribbonPageGroup6.Text = "Sides";
            // 
            // ribbonPageGroup7
            // 
            ribbonPageGroup7.ItemLinks.Add( barCheckItem5 );
            ribbonPageGroup7.ItemLinks.Add( barCheckItem1 );
            ribbonPageGroup7.ItemLinks.Add( barCheckItem2 );
            ribbonPageGroup7.ItemLinks.Add( barCheckItem3 );
            ribbonPageGroup7.ItemLinks.Add( barCheckItem4 );
            ribbonPageGroup7.Name = "ribbonPageGroup7";
            ribbonPageGroup7.Text = "Amount";
            // 
            // ribbonPage1
            // 
            ribbonPage1.Groups.AddRange( new DevExpress.XtraBars.Ribbon.RibbonPageGroup[ ] { ribbonPageGroup1, ribbonPageGroup3, ribbonPageGroup4, ribbonPageGroup5 } );
            ribbonPage1.Name = "ribbonPage1";
            ribbonPage1.Text = "Road Map";
            // 
            // ribbonPageGroup1
            // 
            ribbonPageGroup1.ItemLinks.Add( _newGame );
            ribbonPageGroup1.Name = "ribbonPageGroup1";
            ribbonPageGroup1.Text = "RoadMap";
            // 
            // ribbonPageGroup3
            // 
            ribbonPageGroup3.ItemLinks.Add( _bankerWin );
            ribbonPageGroup3.ItemLinks.Add( _playerWin );
            ribbonPageGroup3.ItemLinks.Add( _gameTie );
            ribbonPageGroup3.Name = "ribbonPageGroup3";
            ribbonPageGroup3.Text = "Game Result";
            // 
            // ribbonPageGroup4
            // 
            ribbonPageGroup4.ItemLinks.Add( _banker8 );
            ribbonPageGroup4.ItemLinks.Add( _banker9 );
            ribbonPageGroup4.ItemLinks.Add( _player8 );
            ribbonPageGroup4.ItemLinks.Add( _player9 );
            ribbonPageGroup4.Name = "ribbonPageGroup4";
            ribbonPageGroup4.Text = "Natural";
            // 
            // ribbonPageGroup5
            // 
            ribbonPageGroup5.ItemLinks.Add( _lucky6 );
            ribbonPageGroup5.ItemLinks.Add( _lucky63Cards );
            ribbonPageGroup5.ItemLinks.Add( _banker7Over6 );
            ribbonPageGroup5.ItemLinks.Add( _lucky7 );
            ribbonPageGroup5.ItemLinks.Add( _lucky76 );
            ribbonPageGroup5.ItemLinks.Add( _panda );
            ribbonPageGroup5.ItemLinks.Add( _tigerTie );
            ribbonPageGroup5.Name = "ribbonPageGroup5";
            ribbonPageGroup5.Text = "Monsters";
            // 
            // ribbonPage2
            // 
            ribbonPage2.Groups.AddRange( new DevExpress.XtraBars.Ribbon.RibbonPageGroup[ ] { ribbonPageGroup2 } );
            ribbonPage2.Name = "ribbonPage2";
            ribbonPage2.Text = "View";
            // 
            // ribbonPageGroup2
            // 
            ribbonPageGroup2.ItemLinks.Add( skinDropDownButtonItem1 );
            ribbonPageGroup2.ItemLinks.Add( skinPaletteDropDownButtonItem1 );
            ribbonPageGroup2.Name = "ribbonPageGroup2";
            ribbonPageGroup2.Text = "Skins";
            // 
            // _uiLayoutControl
            // 
            _uiLayoutControl.Controls.Add( _cardsDealtGrid );
            _uiLayoutControl.Controls.Add( roadmapAnalysisControl1 );
            _uiLayoutControl.Controls.Add( _cockRoachGrid );
            _uiLayoutControl.Controls.Add( _bigEyeGrid );
            _uiLayoutControl.Controls.Add( _beadPlateRoadGrid );
            _uiLayoutControl.Controls.Add( _smallRoadGrid );
            _uiLayoutControl.Controls.Add( _bigRoadGrid );
            _uiLayoutControl.Dock = DockStyle.Fill;
            _uiLayoutControl.Location = new System.Drawing.Point( 0, 237 );
            _uiLayoutControl.Name = "_uiLayoutControl";
            _uiLayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle( 2471, 535, 975, 600 );
            _uiLayoutControl.Root = _mainFormLayoutControlGroup;
            _uiLayoutControl.Size = new System.Drawing.Size( 1993, 720 );
            _uiLayoutControl.TabIndex = 1;
            _uiLayoutControl.Text = "BigRoad";
            // 
            // _cardsDealtGrid
            // 
            _cardsDealtGrid.Location = new System.Drawing.Point( 677, 12 );
            _cardsDealtGrid.MainView = _cardDealtGridView;
            _cardsDealtGrid.MaximumSize = new System.Drawing.Size( 800, 0 );
            _cardsDealtGrid.MenuManager = ribbonControl1;
            _cardsDealtGrid.Name = "_cardsDealtGrid";
            _cardsDealtGrid.RepositoryItems.AddRange( new RepositoryItem[ ] { _cardImageCBEdit } );
            _cardsDealtGrid.ShowOnlyPredefinedDetails = true;
            _cardsDealtGrid.Size = new System.Drawing.Size( 446, 236 );
            _cardsDealtGrid.TabIndex = 11;
            _cardsDealtGrid.ViewCollection.AddRange( new DevExpress.XtraGrid.Views.Base.BaseView[ ] { _cardDealtGridView } );
            // 
            // _cardDealtGridView
            // 
            _cardDealtGridView.CardMinSize = new System.Drawing.Size( 223, 370 );
            _cardDealtGridView.Columns.AddRange( new DevExpress.XtraGrid.Columns.LayoutViewColumn[ ] { _card1, _card2, _card3 } );
            _cardDealtGridView.GridControl = _cardsDealtGrid;
            _cardDealtGridView.Images = _svgCards;
            _cardDealtGridView.Name = "_cardDealtGridView";
            _cardDealtGridView.OptionsBehavior.ScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            _cardDealtGridView.OptionsView.CardArrangeRule = DevExpress.XtraGrid.Views.Layout.LayoutCardArrangeRule.AllowPartialCards;
            _cardDealtGridView.OptionsView.ShowCardBorderIfCaptionHidden = false;
            _cardDealtGridView.OptionsView.ShowCardCaption = false;
            _cardDealtGridView.OptionsView.ShowCardExpandButton = false;
            _cardDealtGridView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            _cardDealtGridView.OptionsView.ShowHeaderPanel = false;
            _cardDealtGridView.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.Row;
            _cardDealtGridView.TemplateCard = layoutViewCard1;
            // 
            // _card1
            // 
            _card1.ColumnEdit = _cardImageCBEdit;
            _card1.FieldName = "Card1";
            _card1.ImageOptions.Alignment = System.Drawing.StringAlignment.Center;
            _card1.LayoutViewField = layoutViewField__playerCard1;
            _card1.MinWidth = 30;
            _card1.Name = "_card1";
            _card1.Width = 112;
            // 
            // _cardImageCBEdit
            // 
            _cardImageCBEdit.AutoHeight = false;
            _cardImageCBEdit.Buttons.AddRange( new EditorButton[ ] { new EditorButton( ButtonPredefines.Combo ) } );
            _cardImageCBEdit.HtmlImages = _svgCards;
            _cardImageCBEdit.Items.AddRange( new ImageComboBoxItem[ ] { new ImageComboBoxItem( "", 0, 0 ), new ImageComboBoxItem( "", 1, 1 ), new ImageComboBoxItem( "", 2, 2 ), new ImageComboBoxItem( "", 3, 3 ), new ImageComboBoxItem( "", 4, 4 ), new ImageComboBoxItem( "", 5, 5 ), new ImageComboBoxItem( "", 6, 6 ), new ImageComboBoxItem( "", 7, 7 ), new ImageComboBoxItem( "", 8, 8 ), new ImageComboBoxItem( "", 9, 9 ), new ImageComboBoxItem( "", 10, 10 ), new ImageComboBoxItem( "", 11, 11 ), new ImageComboBoxItem( "", 12, 12 ), new ImageComboBoxItem( "", 13, 13 ), new ImageComboBoxItem( "", 14, 14 ), new ImageComboBoxItem( "", 15, 15 ), new ImageComboBoxItem( "", 16, 16 ), new ImageComboBoxItem( "", 17, 17 ), new ImageComboBoxItem( "", 18, 18 ), new ImageComboBoxItem( "", 19, 19 ), new ImageComboBoxItem( "", 20, 20 ), new ImageComboBoxItem( "", 21, 21 ), new ImageComboBoxItem( "", 22, 22 ), new ImageComboBoxItem( "", 23, 23 ), new ImageComboBoxItem( "", 24, 24 ), new ImageComboBoxItem( "", 25, 25 ), new ImageComboBoxItem( "", 26, 26 ), new ImageComboBoxItem( "", 27, 27 ), new ImageComboBoxItem( "", 28, 28 ), new ImageComboBoxItem( "", 29, 29 ), new ImageComboBoxItem( "", 30, 30 ), new ImageComboBoxItem( "", 31, 31 ), new ImageComboBoxItem( "", 32, 32 ), new ImageComboBoxItem( "", 33, 33 ), new ImageComboBoxItem( "", 34, 34 ), new ImageComboBoxItem( "", 35, 35 ), new ImageComboBoxItem( "", 36, 36 ), new ImageComboBoxItem( "", 37, 37 ), new ImageComboBoxItem( "", 38, 38 ), new ImageComboBoxItem( "", 39, 39 ), new ImageComboBoxItem( "", 40, 40 ), new ImageComboBoxItem( "", 41, 41 ), new ImageComboBoxItem( "", 42, 42 ), 
                new ImageComboBoxItem( "", 43, 43 ),
            new ImageComboBoxItem( "", 44, 44 ),
            new ImageComboBoxItem( "", 45, 45 ),
            new ImageComboBoxItem( "", 46, 46 ),
            new ImageComboBoxItem( "", 47, 47 ),
            new ImageComboBoxItem( "", 48, 48 ),
            new ImageComboBoxItem( "", 49, 49 ),
            new ImageComboBoxItem( "", 50, 50 ),

            new ImageComboBoxItem( "", 51, 51 ),
            new ImageComboBoxItem( "", 52, 52 ),

            } );
            _cardImageCBEdit.LargeImages = _svgCards;
            _cardImageCBEdit.Name = "_cardImageCBEdit";
            _cardImageCBEdit.SmallImages = _svgCards;
            // 
            // _svgCards
            // 
            _svgCards.ImageSize = new System.Drawing.Size( 50, 70 );
            _svgCards.Add( "transparent", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgCards.transparent" ) );
            _svgCards.Add( "clubs_ace", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgCards.clubs_ace" ) );
            _svgCards.Add( "clubs_2", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgCards.clubs_2" ) );
            _svgCards.Add( "clubs_3", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgCards.clubs_3" ) );
            _svgCards.Add( "clubs_4", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgCards.clubs_4" ) );
            _svgCards.Add( "clubs_5", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgCards.clubs_5" ) );
            _svgCards.Add( "clubs_6", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgCards.clubs_6" ) );
            _svgCards.Add( "clubs_7", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgCards.clubs_7" ) );
            _svgCards.Add( "clubs_8", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgCards.clubs_8" ) );
            _svgCards.Add( "clubs_9", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgCards.clubs_9" ) );
            _svgCards.Add( "clubs_10", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgCards.clubs_10" ) );
            _svgCards.Add( "clubs_jack", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgCards.clubs_jack" ) );
            _svgCards.Add( "clubs_queen", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgCards.clubs_queen" ) );
            _svgCards.Add( "clubs_king", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgCards.clubs_king" ) );
            _svgCards.Add( "diamonds_ace", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgCards.diamonds_ace" ) );
            _svgCards.Add( "diamonds_2", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgCards.diamonds_2" ) );
            _svgCards.Add( "diamonds_3", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgCards.diamonds_3" ) );
            _svgCards.Add( "diamonds_4", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgCards.diamonds_4" ) );
            _svgCards.Add( "diamonds_5", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgCards.diamonds_5" ) );
            _svgCards.Add( "diamonds_6", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgCards.diamonds_6" ) );
            _svgCards.Add( "diamonds_7", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgCards.diamonds_7" ) );
            _svgCards.Add( "diamonds_8", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgCards.diamonds_8" ) );
            _svgCards.Add( "diamonds_9", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgCards.diamonds_9" ) );
            _svgCards.Add( "diamonds_10", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgCards.diamonds_10" ) );
            _svgCards.Add( "diamonds_jack", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgCards.diamonds_jack" ) );
            _svgCards.Add( "diamonds_queen", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgCards.diamonds_queen" ) );
            _svgCards.Add( "diamonds_king", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgCards.diamonds_king" ) );
            _svgCards.Add( "hearts_ace", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgCards.hearts_ace" ) );
            _svgCards.Add( "hearts_2", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgCards.hearts_2" ) );
            _svgCards.Add( "hearts_3", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgCards.hearts_3" ) );
            _svgCards.Add( "hearts_4", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgCards.hearts_4" ) );
            _svgCards.Add( "hearts_5", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgCards.hearts_5" ) );
            _svgCards.Add( "hearts_6", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgCards.hearts_6" ) );
            _svgCards.Add( "hearts_7", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgCards.hearts_7" ) );
            _svgCards.Add( "hearts_8", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgCards.hearts_8" ) );
            _svgCards.Add( "hearts_9", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgCards.hearts_9" ) );
            _svgCards.Add( "hearts_10", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgCards.hearts_10" ) );
            _svgCards.Add( "hearts_jack", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgCards.hearts_jack" ) );
            _svgCards.Add( "hearts_queen", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgCards.hearts_queen" ) );
            _svgCards.Add( "hearts_king", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgCards.hearts_king" ) );
            _svgCards.Add( "spades_ace", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgCards.spades_ace" ) );
            _svgCards.Add( "spades_2", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgCards.spades_2" ) );
            _svgCards.Add( "spades_3", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgCards.spades_3" ) );
            _svgCards.Add( "spades_4", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgCards.spades_4" ) );
            _svgCards.Add( "spades_5", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgCards.spades_5" ) );
            _svgCards.Add( "spades_6", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgCards.spades_6" ) );
            _svgCards.Add( "spades_7", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgCards.spades_7" ) );
            _svgCards.Add( "spades_8", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgCards.spades_8" ) );
            _svgCards.Add( "spades_9", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgCards.spades_9" ) );
            _svgCards.Add( "spades_10", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgCards.spades_10" ) );
            _svgCards.Add( "spades_jack", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgCards.spades_jack" ) );
            _svgCards.Add( "spades_queen", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgCards.spades_queen" ) );
            _svgCards.Add( "spades_king", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgCards.spades_king" ) );
            // 
            // layoutViewField__playerCard1
            // 
            layoutViewField__playerCard1.EditorPreferredWidth = 94;
            layoutViewField__playerCard1.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            layoutViewField__playerCard1.Location = new System.Drawing.Point( 0, 0 );
            layoutViewField__playerCard1.MaxSize = new System.Drawing.Size( 100, 158 );
            layoutViewField__playerCard1.MinSize = new System.Drawing.Size( 100, 158 );
            layoutViewField__playerCard1.Name = "layoutViewField__playerCard1";
            layoutViewField__playerCard1.Size = new System.Drawing.Size( 100, 158 );
            layoutViewField__playerCard1.SizeConstraintsType = SizeConstraintsType.Custom;
            layoutViewField__playerCard1.Spacing = new DevExpress.XtraLayout.Utils.Padding( 1, 1, 1, 1 );
            layoutViewField__playerCard1.TextSize = new System.Drawing.Size( 0, 0 );
            layoutViewField__playerCard1.TextVisible = false;
            // 
            // _card2
            // 
            _card2.ColumnEdit = _cardImageCBEdit;
            _card2.FieldName = "Card2";
            _card2.ImageOptions.Alignment = System.Drawing.StringAlignment.Center;
            _card2.LayoutViewField = layoutViewField_layoutViewColumn1;
            _card2.MinWidth = 30;
            _card2.Name = "_card2";
            _card2.Width = 112;
            // 
            // layoutViewField_layoutViewColumn1
            // 
            layoutViewField_layoutViewColumn1.EditorPreferredWidth = 99;
            layoutViewField_layoutViewColumn1.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            layoutViewField_layoutViewColumn1.Location = new System.Drawing.Point( 100, 0 );
            layoutViewField_layoutViewColumn1.MaxSize = new System.Drawing.Size( 100, 158 );
            layoutViewField_layoutViewColumn1.MinSize = new System.Drawing.Size( 100, 158 );
            layoutViewField_layoutViewColumn1.Name = "layoutViewField_layoutViewColumn1";
            layoutViewField_layoutViewColumn1.Size = new System.Drawing.Size( 103, 158 );
            layoutViewField_layoutViewColumn1.SizeConstraintsType = SizeConstraintsType.Custom;
            layoutViewField_layoutViewColumn1.TextSize = new System.Drawing.Size( 0, 0 );
            layoutViewField_layoutViewColumn1.TextVisible = false;
            // 
            // _card3
            // 
            _card3.ColumnEdit = _cardImageCBEdit;
            _card3.FieldName = "Card3";
            _card3.ImageOptions.Alignment = System.Drawing.StringAlignment.Center;
            _card3.LayoutViewField = layoutViewField_layoutViewColumn1_1;
            _card3.MinWidth = 30;
            _card3.Name = "_card3";
            _card3.Width = 112;
            // 
            // layoutViewField_layoutViewColumn1_1
            // 
            layoutViewField_layoutViewColumn1_1.EditorPreferredWidth = 96;
            layoutViewField_layoutViewColumn1_1.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            layoutViewField_layoutViewColumn1_1.Location = new System.Drawing.Point( 50, 158 );
            layoutViewField_layoutViewColumn1_1.MaxSize = new System.Drawing.Size( 100, 158 );
            layoutViewField_layoutViewColumn1_1.MinSize = new System.Drawing.Size( 100, 158 );
            layoutViewField_layoutViewColumn1_1.Name = "layoutViewField_layoutViewColumn1_1";
            layoutViewField_layoutViewColumn1_1.Size = new System.Drawing.Size( 100, 192 );
            layoutViewField_layoutViewColumn1_1.SizeConstraintsType = SizeConstraintsType.Custom;
            layoutViewField_layoutViewColumn1_1.TextSize = new System.Drawing.Size( 0, 0 );
            layoutViewField_layoutViewColumn1_1.TextVisible = false;
            // 
            // layoutViewCard1
            // 
            layoutViewCard1.CustomizationFormText = "TemplateCard";
            layoutViewCard1.GroupBordersVisible = false;
            layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            layoutViewCard1.Items.AddRange( new BaseLayoutItem[ ] { layoutViewField__playerCard1, layoutViewField_layoutViewColumn1_1, layoutViewField_layoutViewColumn1, emptySpaceItem1, Item1 } );
            layoutViewCard1.Name = "layoutViewCard1";
            layoutViewCard1.OptionsItemText.TextToControlDistance = 5;
            layoutViewCard1.Text = "TemplateCard";
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.AllowHotTrack = false;
            emptySpaceItem1.CustomizationFormText = "Empty Space Item";
            emptySpaceItem1.Location = new System.Drawing.Point( 150, 158 );
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new System.Drawing.Size( 53, 192 );
            emptySpaceItem1.TextSize = new System.Drawing.Size( 0, 0 );
            // 
            // Item1
            // 
            Item1.AllowHotTrack = false;
            Item1.CustomizationFormText = "Item1";
            Item1.Location = new System.Drawing.Point( 0, 158 );
            Item1.Name = "Item1";
            Item1.Size = new System.Drawing.Size( 50, 192 );
            Item1.TextSize = new System.Drawing.Size( 0, 0 );
            // 
            // roadmapAnalysisControl1
            // 
            roadmapAnalysisControl1.Location = new System.Drawing.Point( 1127, 12 );
            roadmapAnalysisControl1.Name = "roadmapAnalysisControl1";
            roadmapAnalysisControl1.Size = new System.Drawing.Size( 854, 696 );
            roadmapAnalysisControl1.TabIndex = 10;
            // 
            // _cockRoachGrid
            // 
            _cockRoachGrid.Location = new System.Drawing.Point( 590, 577 );
            _cockRoachGrid.Name = "_cockRoachGrid";
            _cockRoachGrid.OptionsView.FixRowHeaderPanelWidth = true;
            _cockRoachGrid.OptionsView.MaxRowAutoHeight = 30;
            _cockRoachGrid.OptionsView.MinRowAutoHeight = 30;
            _cockRoachGrid.OptionsView.ShowRows = false;
            _cockRoachGrid.RecordWidth = 30;
            _cockRoachGrid.RepositoryItems.AddRange( new RepositoryItem[ ] { _cockRoachCBEdit } );
            _cockRoachGrid.RowHeaderWidth = 15;
            _cockRoachGrid.Rows.AddRange( new DevExpress.XtraVerticalGrid.Rows.BaseRow[ ] { _cockRoachRow0, _cockRoachRow1, _cockRoachRow2, _cockRoachRow3, _cockRoachRow4, _cockRoachRow5 } );
            _cockRoachGrid.Size = new System.Drawing.Size( 533, 131 );
            _cockRoachGrid.TabIndex = 9;
            // 
            // _cockRoachCBEdit
            // 
            _cockRoachCBEdit.AutoHeight = false;
            _cockRoachCBEdit.Buttons.AddRange( new EditorButton[ ] { new EditorButton( ButtonPredefines.Combo ) } );
            _cockRoachCBEdit.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            _cockRoachCBEdit.HtmlImages = _cockRoachSvg;
            _cockRoachCBEdit.Items.AddRange( new ImageComboBoxItem[ ] { new ImageComboBoxItem( "", 0, 0 ), new ImageComboBoxItem( "", 1, 1 ), new ImageComboBoxItem( "", 2, 2 ) } );
            _cockRoachCBEdit.LargeImages = _cockRoachSvg;
            _cockRoachCBEdit.Name = "_cockRoachCBEdit";
            _cockRoachCBEdit.SmallImages = _cockRoachSvg;
            // 
            // _cockRoachSvg
            // 
            _cockRoachSvg.Add( "transparent", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_cockRoachSvg.transparent" ) );
            _cockRoachSvg.Add( "red", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_cockRoachSvg.red" ) );
            _cockRoachSvg.Add( "Blue", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_cockRoachSvg.Blue" ) );
            // 
            // _cockRoachRow0
            // 
            _cockRoachRow0.Name = "_cockRoachRow0";
            _cockRoachRow0.Properties.FieldName = "Row0";
            _cockRoachRow0.Properties.RowEdit = _cockRoachCBEdit;
            // 
            // _cockRoachRow1
            // 
            _cockRoachRow1.Name = "_cockRoachRow1";
            _cockRoachRow1.Properties.FieldName = "Row1";
            _cockRoachRow1.Properties.RowEdit = _cockRoachCBEdit;
            // 
            // _cockRoachRow2
            // 
            _cockRoachRow2.Name = "_cockRoachRow2";
            _cockRoachRow2.Properties.FieldName = "Row2";
            _cockRoachRow2.Properties.RowEdit = _cockRoachCBEdit;
            // 
            // _cockRoachRow3
            // 
            _cockRoachRow3.Name = "_cockRoachRow3";
            _cockRoachRow3.Properties.FieldName = "Row3";
            _cockRoachRow3.Properties.RowEdit = _cockRoachCBEdit;
            // 
            // _cockRoachRow4
            // 
            _cockRoachRow4.Name = "_cockRoachRow4";
            _cockRoachRow4.Properties.FieldName = "Row4";
            _cockRoachRow4.Properties.RowEdit = _cockRoachCBEdit;
            // 
            // _cockRoachRow5
            // 
            _cockRoachRow5.Name = "_cockRoachRow5";
            _cockRoachRow5.Properties.FieldName = "Row5";
            _cockRoachRow5.Properties.RowEdit = _cockRoachCBEdit;
            // 
            // _bigEyeGrid
            // 
            _bigEyeGrid.Location = new System.Drawing.Point( 590, 277 );
            _bigEyeGrid.Name = "_bigEyeGrid";
            _bigEyeGrid.OptionsView.FixRowHeaderPanelWidth = true;
            _bigEyeGrid.OptionsView.MaxRowAutoHeight = 30;
            _bigEyeGrid.OptionsView.MinRowAutoHeight = 30;
            _bigEyeGrid.OptionsView.ShowRows = false;
            _bigEyeGrid.RecordWidth = 30;
            _bigEyeGrid.RepositoryItems.AddRange( new RepositoryItem[ ] { _bigEyeRoadCBEdit } );
            _bigEyeGrid.RowHeaderWidth = 15;
            _bigEyeGrid.Rows.AddRange( new DevExpress.XtraVerticalGrid.Rows.BaseRow[ ] { _bigEyeRoad0, _bigEyeRoad1, _bigEyeRoad2, _bigEyeRoad3, _bigEyeRoad4, _bigEyeRoad5 } );
            _bigEyeGrid.Size = new System.Drawing.Size( 533, 121 );
            _bigEyeGrid.TabIndex = 8;
            // 
            // _bigEyeRoadCBEdit
            // 
            _bigEyeRoadCBEdit.AutoHeight = false;
            _bigEyeRoadCBEdit.Buttons.AddRange( new EditorButton[ ] { new EditorButton( ButtonPredefines.Combo ) } );
            _bigEyeRoadCBEdit.HtmlImages = _bigEyeRoadSvg;
            _bigEyeRoadCBEdit.Items.AddRange( new ImageComboBoxItem[ ] { new ImageComboBoxItem( "Trans", 0, 0 ), new ImageComboBoxItem( "Red", 1, 1 ), new ImageComboBoxItem( "Blue", 2, 2 ) } );
            _bigEyeRoadCBEdit.LargeImages = _bigEyeRoadSvg;
            _bigEyeRoadCBEdit.Name = "_bigEyeRoadCBEdit";
            _bigEyeRoadCBEdit.SmallImages = _bigEyeRoadSvg;
            // 
            // _bigEyeRoadSvg
            // 
            _bigEyeRoadSvg.Add( "transparent", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_bigEyeRoadSvg.transparent" ) );
            _bigEyeRoadSvg.Add( "bigEyeRed2", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_bigEyeRoadSvg.bigEyeRed2" ) );
            _bigEyeRoadSvg.Add( "bigEyeBlue2", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_bigEyeRoadSvg.bigEyeBlue2" ) );
            // 
            // _bigEyeRoad0
            // 
            _bigEyeRoad0.Name = "_bigEyeRoad0";
            _bigEyeRoad0.Properties.FieldName = "Row0";
            _bigEyeRoad0.Properties.RowEdit = _bigEyeRoadCBEdit;
            // 
            // _bigEyeRoad1
            // 
            _bigEyeRoad1.Name = "_bigEyeRoad1";
            _bigEyeRoad1.Properties.FieldName = "Row1";
            _bigEyeRoad1.Properties.RowEdit = _bigEyeRoadCBEdit;
            // 
            // _bigEyeRoad2
            // 
            _bigEyeRoad2.Name = "_bigEyeRoad2";
            _bigEyeRoad2.Properties.FieldName = "Row2";
            _bigEyeRoad2.Properties.RowEdit = _bigEyeRoadCBEdit;
            // 
            // _bigEyeRoad3
            // 
            _bigEyeRoad3.Name = "_bigEyeRoad3";
            _bigEyeRoad3.Properties.FieldName = "Row3";
            _bigEyeRoad3.Properties.RowEdit = _bigEyeRoadCBEdit;
            // 
            // _bigEyeRoad4
            // 
            _bigEyeRoad4.Name = "_bigEyeRoad4";
            _bigEyeRoad4.Properties.FieldName = "Row4";
            _bigEyeRoad4.Properties.RowEdit = _bigEyeRoadCBEdit;
            // 
            // _bigEyeRoad5
            // 
            _bigEyeRoad5.Name = "_bigEyeRoad5";
            _bigEyeRoad5.Properties.FieldName = "Row5";
            _bigEyeRoad5.Properties.RowEdit = _bigEyeRoadCBEdit;
            // 
            // _beadPlateRoadGrid
            // 
            _beadPlateRoadGrid.Location = new System.Drawing.Point( 12, 277 );
            _beadPlateRoadGrid.Name = "_beadPlateRoadGrid";
            _beadPlateRoadGrid.OptionsView.FixRowHeaderPanelWidth = true;
            _beadPlateRoadGrid.OptionsView.MaxRowAutoHeight = 64;
            _beadPlateRoadGrid.OptionsView.MinRowAutoHeight = 64;
            _beadPlateRoadGrid.OptionsView.ShowRows = false;
            _beadPlateRoadGrid.RecordWidth = 64;
            _beadPlateRoadGrid.RepositoryItems.AddRange( new RepositoryItem[ ] { _beadPlateRepoCBEdit } );
            _beadPlateRoadGrid.RowHeaderWidth = 15;
            _beadPlateRoadGrid.Rows.AddRange( new DevExpress.XtraVerticalGrid.Rows.BaseRow[ ] { _beadPlateRow0, _beadPlateRow1, _beadPlateRow2, _beadPlateRow3, _beadPlateRow4, _beadPlateRow5 } );
            _beadPlateRoadGrid.Size = new System.Drawing.Size( 574, 431 );
            _beadPlateRoadGrid.TabIndex = 7;
            // 
            // _beadPlateRepoCBEdit
            // 
            _beadPlateRepoCBEdit.AutoHeight = false;
            _beadPlateRepoCBEdit.Buttons.AddRange( new EditorButton[ ] { new EditorButton( ButtonPredefines.Combo ) } );
            _beadPlateRepoCBEdit.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            _beadPlateRepoCBEdit.HtmlImages = _beadPlateRoadSvg;
            _beadPlateRepoCBEdit.Items.AddRange( new ImageComboBoxItem[ ] { new ImageComboBoxItem( "", 0, 0 ), new ImageComboBoxItem( "", 1, 1 ), new ImageComboBoxItem( "", 2, 2 ), new ImageComboBoxItem( "", 3, 3 ), new ImageComboBoxItem( "", 4, 4 ), new ImageComboBoxItem( "", 5, 5 ), new ImageComboBoxItem( "", 6, 6 ), new ImageComboBoxItem( "", 7, 7 ), new ImageComboBoxItem( "", 8, 8 ), new ImageComboBoxItem( "", 9, 9 ), new ImageComboBoxItem( "", 10, 10 ), new ImageComboBoxItem( "", 11, 11 ), new ImageComboBoxItem( "", 12, 12 ), new ImageComboBoxItem( "", 13, 13 ), new ImageComboBoxItem( "", 14, 14 ) } );
            _beadPlateRepoCBEdit.LargeImages = _beadPlateRoadSvg;
            _beadPlateRepoCBEdit.Name = "_beadPlateRepoCBEdit";
            _beadPlateRepoCBEdit.SmallImages = _beadPlateRoadSvg;
            // 
            // _beadPlateRoadSvg
            // 
            _beadPlateRoadSvg.ImageSize = new System.Drawing.Size( 36, 36 );
            _beadPlateRoadSvg.Add( "transparent", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_beadPlateRoadSvg.transparent" ) );
            _beadPlateRoadSvg.Add( "B", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_beadPlateRoadSvg.B" ) );
            _beadPlateRoadSvg.Add( "bedPlateBlue", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_beadPlateRoadSvg.bedPlateBlue" ) );
            _beadPlateRoadSvg.Add( "bedPlateTie", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_beadPlateRoadSvg.bedPlateTie" ) );
            _beadPlateRoadSvg.Add( "bedPlateB8", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_beadPlateRoadSvg.bedPlateB8" ) );
            _beadPlateRoadSvg.Add( "B9", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_beadPlateRoadSvg.B9" ) );
            _beadPlateRoadSvg.Add( "P8", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_beadPlateRoadSvg.P8" ) );
            _beadPlateRoadSvg.Add( "P9", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_beadPlateRoadSvg.P9" ) );
            _beadPlateRoadSvg.Add( "B6", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_beadPlateRoadSvg.B6" ) );
            _beadPlateRoadSvg.Add( "B63_2", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_beadPlateRoadSvg.B63_2" ) );
            _beadPlateRoadSvg.Add( "P7", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_beadPlateRoadSvg.P7" ) );
            _beadPlateRoadSvg.Add( "P76", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_beadPlateRoadSvg.P76" ) );
            _beadPlateRoadSvg.Add( "TT", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_beadPlateRoadSvg.TT" ) );
            _beadPlateRoadSvg.Add( "B76", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_beadPlateRoadSvg.B76" ) );
            _beadPlateRoadSvg.Add( "P83", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_beadPlateRoadSvg.P83" ) );
            // 
            // _beadPlateRow0
            // 
            _beadPlateRow0.Name = "_beadPlateRow0";
            _beadPlateRow0.Properties.Caption = "Row0";
            _beadPlateRow0.Properties.FieldName = "Row0";
            _beadPlateRow0.Properties.RowEdit = _beadPlateRepoCBEdit;
            // 
            // _beadPlateRow1
            // 
            _beadPlateRow1.Name = "_beadPlateRow1";
            _beadPlateRow1.Properties.Caption = "Row1";
            _beadPlateRow1.Properties.FieldName = "Row1";
            _beadPlateRow1.Properties.RowEdit = _beadPlateRepoCBEdit;
            // 
            // _beadPlateRow2
            // 
            _beadPlateRow2.Name = "_beadPlateRow2";
            _beadPlateRow2.Properties.Caption = "Row2";
            _beadPlateRow2.Properties.FieldName = "Row2";
            _beadPlateRow2.Properties.RowEdit = _beadPlateRepoCBEdit;
            // 
            // _beadPlateRow3
            // 
            _beadPlateRow3.Name = "_beadPlateRow3";
            _beadPlateRow3.Properties.Caption = "Row3";
            _beadPlateRow3.Properties.FieldName = "Row3";
            _beadPlateRow3.Properties.RowEdit = _beadPlateRepoCBEdit;
            // 
            // _beadPlateRow4
            // 
            _beadPlateRow4.Name = "_beadPlateRow4";
            _beadPlateRow4.Properties.Caption = "Row4";
            _beadPlateRow4.Properties.FieldName = "Row4";
            _beadPlateRow4.Properties.RowEdit = _beadPlateRepoCBEdit;
            // 
            // _beadPlateRow5
            // 
            _beadPlateRow5.Name = "_beadPlateRow5";
            _beadPlateRow5.Properties.Caption = "Row5";
            _beadPlateRow5.Properties.FieldName = "Row5";
            _beadPlateRow5.Properties.RowEdit = _beadPlateRepoCBEdit;
            // 
            // _smallRoadGrid
            // 
            _smallRoadGrid.Location = new System.Drawing.Point( 590, 427 );
            _smallRoadGrid.Name = "_smallRoadGrid";
            _smallRoadGrid.OptionsView.FixRowHeaderPanelWidth = true;
            _smallRoadGrid.OptionsView.MaxRowAutoHeight = 30;
            _smallRoadGrid.OptionsView.MinRowAutoHeight = 30;
            _smallRoadGrid.OptionsView.ShowRows = false;
            _smallRoadGrid.RecordWidth = 30;
            _smallRoadGrid.RepositoryItems.AddRange( new RepositoryItem[ ] { _smallRoadImageCBEdit } );
            _smallRoadGrid.RowHeaderWidth = 15;
            _smallRoadGrid.Rows.AddRange( new DevExpress.XtraVerticalGrid.Rows.BaseRow[ ] { _smallRoadRow0, _smallRoadRow1, _smallRoadRow2, _smallRoadRow3, _smallRoadRow4, _smallRoadRow5 } );
            _smallRoadGrid.Size = new System.Drawing.Size( 533, 121 );
            _smallRoadGrid.TabIndex = 6;
            // 
            // _smallRoadImageCBEdit
            // 
            _smallRoadImageCBEdit.AutoHeight = false;
            _smallRoadImageCBEdit.Buttons.AddRange( new EditorButton[ ] { new EditorButton( ButtonPredefines.Combo ) } );
            _smallRoadImageCBEdit.HtmlImages = _smallRoadSvg;
            _smallRoadImageCBEdit.Items.AddRange( new ImageComboBoxItem[ ] { new ImageComboBoxItem( "", 0, 0 ), new ImageComboBoxItem( "", 1, 1 ), new ImageComboBoxItem( "", 2, 2 ) } );
            _smallRoadImageCBEdit.LargeImages = _smallRoadSvg;
            _smallRoadImageCBEdit.Name = "_smallRoadImageCBEdit";
            _smallRoadImageCBEdit.SmallImages = _smallRoadSvg;
            // 
            // _smallRoadSvg
            // 
            _smallRoadSvg.Add( "transparent", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_smallRoadSvg.transparent" ) );
            _smallRoadSvg.Add( "SmallRoadRed", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_smallRoadSvg.SmallRoadRed" ) );
            _smallRoadSvg.Add( "SmallRoadBlue2", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_smallRoadSvg.SmallRoadBlue2" ) );
            // 
            // _smallRoadRow0
            // 
            _smallRoadRow0.Name = "_smallRoadRow0";
            _smallRoadRow0.Properties.FieldName = "Row0";
            _smallRoadRow0.Properties.RowEdit = _smallRoadImageCBEdit;
            // 
            // _smallRoadRow1
            // 
            _smallRoadRow1.Name = "_smallRoadRow1";
            _smallRoadRow1.Properties.FieldName = "Row1";
            _smallRoadRow1.Properties.RowEdit = _smallRoadImageCBEdit;
            // 
            // _smallRoadRow2
            // 
            _smallRoadRow2.Name = "_smallRoadRow2";
            _smallRoadRow2.Properties.FieldName = "Row2";
            _smallRoadRow2.Properties.RowEdit = _smallRoadImageCBEdit;
            // 
            // _smallRoadRow3
            // 
            _smallRoadRow3.Name = "_smallRoadRow3";
            _smallRoadRow3.Properties.FieldName = "Row3";
            _smallRoadRow3.Properties.RowEdit = _smallRoadImageCBEdit;
            // 
            // _smallRoadRow4
            // 
            _smallRoadRow4.Name = "_smallRoadRow4";
            _smallRoadRow4.Properties.FieldName = "Row4";
            _smallRoadRow4.Properties.RowEdit = _smallRoadImageCBEdit;
            // 
            // _smallRoadRow5
            // 
            _smallRoadRow5.Name = "_smallRoadRow5";
            _smallRoadRow5.Properties.FieldName = "Row5";
            _smallRoadRow5.Properties.RowEdit = _smallRoadImageCBEdit;
            // 
            // _bigRoadGrid
            // 
            _bigRoadGrid.Location = new System.Drawing.Point( 12, 37 );
            _bigRoadGrid.Name = "_bigRoadGrid";
            _bigRoadGrid.OptionsView.FixRowHeaderPanelWidth = true;
            _bigRoadGrid.OptionsView.MaxRowAutoHeight = 48;
            _bigRoadGrid.OptionsView.MinRowAutoHeight = 48;
            _bigRoadGrid.OptionsView.ShowRows = false;
            _bigRoadGrid.RecordWidth = 48;
            _bigRoadGrid.RepositoryItems.AddRange( new RepositoryItem[ ] { _bigRoadImageCBEdit } );
            _bigRoadGrid.RightToLeft = RightToLeft.No;
            _bigRoadGrid.RowHeaderWidth = 15;
            _bigRoadGrid.Rows.AddRange( new DevExpress.XtraVerticalGrid.Rows.BaseRow[ ] { _bigRoadRow0, _bigRoadRow1, _bigRoadRow2, _bigRoadRow3, _bigRoadRow4, _bigRoadRow5 } );
            _bigRoadGrid.Size = new System.Drawing.Size( 661, 211 );
            _bigRoadGrid.TabIndex = 5;
            // 
            // _bigRoadImageCBEdit
            // 
            _bigRoadImageCBEdit.AutoHeight = false;
            _bigRoadImageCBEdit.Buttons.AddRange( new EditorButton[ ] { new EditorButton( ButtonPredefines.Combo ) } );
            _bigRoadImageCBEdit.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            _bigRoadImageCBEdit.HtmlImages = _bigRoadSvg;
            _bigRoadImageCBEdit.Items.AddRange( new ImageComboBoxItem[ ] { new ImageComboBoxItem( "", 0, 0 ), new ImageComboBoxItem( "", 1, 1 ), new ImageComboBoxItem( "", 2, 2 ), new ImageComboBoxItem( "", 3, 3 ), new ImageComboBoxItem( "", 4, 4 ), new ImageComboBoxItem( "", 5, 5 ), new ImageComboBoxItem( "", 6, 6 ), new ImageComboBoxItem( "", 7, 7 ), new ImageComboBoxItem( "", 8, 8 ), new ImageComboBoxItem( "", 9, 9 ), new ImageComboBoxItem( "", 10, 10 ), new ImageComboBoxItem( "", 11, 11 ), new ImageComboBoxItem( "", 12, 12 ), new ImageComboBoxItem( "", 13, 13 ), new ImageComboBoxItem( "", 14, 14 ) } );
            _bigRoadImageCBEdit.LargeImages = _bigRoadSvg;
            _bigRoadImageCBEdit.Name = "_bigRoadImageCBEdit";
            _bigRoadImageCBEdit.SmallImages = _bigRoadSvg;
            // 
            // _bigRoadSvg
            // 
            _bigRoadSvg.ImageSize = new System.Drawing.Size( 28, 28 );
            _bigRoadSvg.Add( "transparent", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_bigRoadSvg.transparent" ) );
            _bigRoadSvg.Add( "banker", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_bigRoadSvg.banker" ) );
            _bigRoadSvg.Add( "player", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_bigRoadSvg.player" ) );
            _bigRoadSvg.Add( "tie", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_bigRoadSvg.tie" ) );
            _bigRoadSvg.Add( "banker8", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_bigRoadSvg.banker8" ) );
            _bigRoadSvg.Add( "banker9", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_bigRoadSvg.banker9" ) );
            _bigRoadSvg.Add( "player8", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_bigRoadSvg.player8" ) );
            _bigRoadSvg.Add( "player9", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_bigRoadSvg.player9" ) );
            _bigRoadSvg.Add( "banker6", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_bigRoadSvg.banker6" ) );
            _bigRoadSvg.Add( "banker63", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_bigRoadSvg.banker63" ) );
            _bigRoadSvg.Add( "player7", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_bigRoadSvg.player7" ) );
            _bigRoadSvg.Add( "player76", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_bigRoadSvg.player76" ) );
            _bigRoadSvg.Add( "tigerTie", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_bigRoadSvg.tigerTie" ) );
            _bigRoadSvg.Add( "B76_3", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_bigRoadSvg.B76_3" ) );
            _bigRoadSvg.Add( "player83", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_bigRoadSvg.player83" ) );
            // 
            // _bigRoadRow0
            // 
            _bigRoadRow0.Name = "_bigRoadRow0";
            _bigRoadRow0.Properties.Caption = "Row0";
            _bigRoadRow0.Properties.FieldName = "Row0";
            _bigRoadRow0.Properties.RowEdit = _bigRoadImageCBEdit;
            // 
            // _bigRoadRow1
            // 
            _bigRoadRow1.Name = "_bigRoadRow1";
            _bigRoadRow1.Properties.Caption = "Row1";
            _bigRoadRow1.Properties.FieldName = "Row1";
            _bigRoadRow1.Properties.RowEdit = _bigRoadImageCBEdit;
            // 
            // _bigRoadRow2
            // 
            _bigRoadRow2.Name = "_bigRoadRow2";
            _bigRoadRow2.Properties.Caption = "Row2";
            _bigRoadRow2.Properties.FieldName = "Row2";
            _bigRoadRow2.Properties.RowEdit = _bigRoadImageCBEdit;
            // 
            // _bigRoadRow3
            // 
            _bigRoadRow3.Name = "_bigRoadRow3";
            _bigRoadRow3.Properties.Caption = "Row3";
            _bigRoadRow3.Properties.FieldName = "Row3";
            _bigRoadRow3.Properties.RowEdit = _bigRoadImageCBEdit;
            // 
            // _bigRoadRow4
            // 
            _bigRoadRow4.Name = "_bigRoadRow4";
            _bigRoadRow4.Properties.Caption = "Row4";
            _bigRoadRow4.Properties.FieldName = "Row4";
            _bigRoadRow4.Properties.RowEdit = _bigRoadImageCBEdit;
            // 
            // _bigRoadRow5
            // 
            _bigRoadRow5.Name = "_bigRoadRow5";
            _bigRoadRow5.Properties.Caption = "Row5";
            _bigRoadRow5.Properties.FieldName = "Row5";
            _bigRoadRow5.Properties.RowEdit = _bigRoadImageCBEdit;
            // 
            // _mainFormLayoutControlGroup
            // 
            _mainFormLayoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            _mainFormLayoutControlGroup.GroupBordersVisible = false;
            _mainFormLayoutControlGroup.Items.AddRange( new BaseLayoutItem[ ] { _bigRoadLayoutControlItem, _smallRoadLayoutControlItem, _beadPlateLayoutControlItem, _bigEyeLayoutControlItem, _cockRoachLayoutControlItem, layoutControlItem1, layoutControlItem2 } );
            _mainFormLayoutControlGroup.Name = "Root";
            _mainFormLayoutControlGroup.Size = new System.Drawing.Size( 1993, 720 );
            _mainFormLayoutControlGroup.TextVisible = false;
            // 
            // _bigRoadLayoutControlItem
            // 
            _bigRoadLayoutControlItem.Control = _bigRoadGrid;
            _bigRoadLayoutControlItem.Location = new System.Drawing.Point( 0, 0 );
            _bigRoadLayoutControlItem.Name = "layoutControlItem2";
            _bigRoadLayoutControlItem.Size = new System.Drawing.Size( 665, 240 );
            _bigRoadLayoutControlItem.Text = "Big Road";
            _bigRoadLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            _bigRoadLayoutControlItem.TextSize = new System.Drawing.Size( 111, 22 );
            // 
            // _smallRoadLayoutControlItem
            // 
            _smallRoadLayoutControlItem.Control = _smallRoadGrid;
            _smallRoadLayoutControlItem.Location = new System.Drawing.Point( 578, 390 );
            _smallRoadLayoutControlItem.Name = "layoutControlItem3";
            _smallRoadLayoutControlItem.Size = new System.Drawing.Size( 537, 150 );
            _smallRoadLayoutControlItem.Text = "Small Road";
            _smallRoadLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            _smallRoadLayoutControlItem.TextSize = new System.Drawing.Size( 111, 22 );
            // 
            // _beadPlateLayoutControlItem
            // 
            _beadPlateLayoutControlItem.Control = _beadPlateRoadGrid;
            _beadPlateLayoutControlItem.Location = new System.Drawing.Point( 0, 240 );
            _beadPlateLayoutControlItem.Name = "layoutControlItem4";
            _beadPlateLayoutControlItem.Size = new System.Drawing.Size( 578, 460 );
            _beadPlateLayoutControlItem.Text = "Bead Plate";
            _beadPlateLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            _beadPlateLayoutControlItem.TextSize = new System.Drawing.Size( 111, 22 );
            // 
            // _bigEyeLayoutControlItem
            // 
            _bigEyeLayoutControlItem.Control = _bigEyeGrid;
            _bigEyeLayoutControlItem.Location = new System.Drawing.Point( 578, 240 );
            _bigEyeLayoutControlItem.Name = "layoutControlItem1";
            _bigEyeLayoutControlItem.Size = new System.Drawing.Size( 537, 150 );
            _bigEyeLayoutControlItem.Text = "Big Eye Road";
            _bigEyeLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            _bigEyeLayoutControlItem.TextSize = new System.Drawing.Size( 111, 22 );
            // 
            // _cockRoachLayoutControlItem
            // 
            _cockRoachLayoutControlItem.Control = _cockRoachGrid;
            _cockRoachLayoutControlItem.Location = new System.Drawing.Point( 578, 540 );
            _cockRoachLayoutControlItem.Name = "layoutControlItem5";
            _cockRoachLayoutControlItem.Size = new System.Drawing.Size( 537, 160 );
            _cockRoachLayoutControlItem.Text = "Cockroach Pig";
            _cockRoachLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            _cockRoachLayoutControlItem.TextSize = new System.Drawing.Size( 111, 22 );
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = roadmapAnalysisControl1;
            layoutControlItem1.Location = new System.Drawing.Point( 1115, 0 );
            layoutControlItem1.Name = "item0";
            layoutControlItem1.Size = new System.Drawing.Size( 858, 700 );
            layoutControlItem1.TextSize = new System.Drawing.Size( 0, 0 );
            layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = _cardsDealtGrid;
            layoutControlItem2.CustomizationFormText = "Hand Dealt";
            layoutControlItem2.Location = new System.Drawing.Point( 665, 0 );
            layoutControlItem2.MaxSize = new System.Drawing.Size( 450, 0 );
            layoutControlItem2.MinSize = new System.Drawing.Size( 450, 1 );
            layoutControlItem2.Name = "item1";
            layoutControlItem2.Size = new System.Drawing.Size( 450, 240 );
            layoutControlItem2.SizeConstraintsType = SizeConstraintsType.Custom;
            layoutControlItem2.TextSize = new System.Drawing.Size( 0, 0 );
            layoutControlItem2.TextVisible = false;
            // 
            // RoadMapUI
            // 
            AutoScaleDimensions = new System.Drawing.SizeF( 10F, 22F );
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size( 1993, 957 );
            Controls.Add( _uiLayoutControl );
            Controls.Add( ribbonControl1 );
            IconOptions.Icon = (System.Drawing.Icon)resources.GetObject( "RoadMapUI.IconOptions.Icon" );
            Margin = new Padding( 5 );
            Name = "RoadMapUI";
            Ribbon = ribbonControl1;
            Text = "Baccarat RoadMap";
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)_uiLayoutControl).EndInit();
            _uiLayoutControl.ResumeLayout( false );
            ((System.ComponentModel.ISupportInitialize)_cardsDealtGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)_cardDealtGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)_cardImageCBEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)_svgCards).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutViewField__playerCard1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutViewField_layoutViewColumn1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutViewField_layoutViewColumn1_1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutViewCard1).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Item1).EndInit();
            ((System.ComponentModel.ISupportInitialize)_cockRoachGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)_cockRoachCBEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)_cockRoachSvg).EndInit();
            ((System.ComponentModel.ISupportInitialize)_bigEyeGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)_bigEyeRoadCBEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)_bigEyeRoadSvg).EndInit();
            ((System.ComponentModel.ISupportInitialize)_beadPlateRoadGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)_beadPlateRepoCBEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)_beadPlateRoadSvg).EndInit();
            ((System.ComponentModel.ISupportInitialize)_smallRoadGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)_smallRoadImageCBEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)_smallRoadSvg).EndInit();
            ((System.ComponentModel.ISupportInitialize)_bigRoadGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)_bigRoadImageCBEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)_bigRoadSvg).EndInit();
            ((System.ComponentModel.ISupportInitialize)_mainFormLayoutControlGroup).EndInit();
            ((System.ComponentModel.ISupportInitialize)_bigRoadLayoutControlItem).EndInit();
            ((System.ComponentModel.ISupportInitialize)_smallRoadLayoutControlItem).EndInit();
            ((System.ComponentModel.ISupportInitialize)_beadPlateLayoutControlItem).EndInit();
            ((System.ComponentModel.ISupportInitialize)_bigEyeLayoutControlItem).EndInit();
            ((System.ComponentModel.ISupportInitialize)_cockRoachLayoutControlItem).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ResumeLayout( false );
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;


        private DevExpress.XtraLayout.LayoutControl _uiLayoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup _mainFormLayoutControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem _bigRoadLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem _smallRoadLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem _beadPlateLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem _bigEyeLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem _cockRoachLayoutControlItem;

        private DevExpress.XtraVerticalGrid.VGridControl _bigRoadGrid;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow _bigRoadRow0;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow _bigRoadRow1;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow _bigRoadRow2;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow _bigRoadRow3;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow _bigRoadRow4;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow _bigRoadRow5;


        private DevExpress.XtraVerticalGrid.VGridControl _beadPlateRoadGrid;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow _beadPlateRow0;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow _beadPlateRow1;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow _beadPlateRow2;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow _beadPlateRow3;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow _beadPlateRow4;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow _beadPlateRow5;

        private DevExpress.XtraVerticalGrid.VGridControl _smallRoadGrid;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow _smallRoadRow0;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow _smallRoadRow1;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow _smallRoadRow2;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow _smallRoadRow3;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow _smallRoadRow4;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow _smallRoadRow5;

        private DevExpress.XtraVerticalGrid.VGridControl _bigEyeGrid;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow _bigEyeRoad0;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow _bigEyeRoad1;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow _bigEyeRoad2;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow _bigEyeRoad3;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow _bigEyeRoad4;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow _bigEyeRoad5;

        private DevExpress.XtraVerticalGrid.VGridControl _cockRoachGrid;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow _cockRoachRow0;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow _cockRoachRow1;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow _cockRoachRow2;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow _cockRoachRow3;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow _cockRoachRow4;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow _cockRoachRow5;





        private RepositoryItemImageComboBox _imageCBRepo;
        
        private RepositoryItemImageComboBox _bigRoadCBEdit;
        private RepositoryItemImageComboBox _beadPlateCBEdit;
        private RepositoryItemImageComboBox _smallRoadCBEdit;
        private RepositoryItemImageComboBox _bigEyeRoadCBEdit;
        private RepositoryItemImageComboBox _cockRoachCBEdit;

        private DevExpress.Utils.SvgImageCollection _cockRoachSvg;
        private DevExpress.Utils.SvgImageCollection _beadPlateRoadSvg;
        private DevExpress.Utils.SvgImageCollection _smallRoadSvg;
        private DevExpress.Utils.SvgImageCollection _bigEyeRoadSvg;
        private DevExpress.Utils.SvgImageCollection _bigRoadSvg;
        private DevExpress.XtraBars.BarButtonItem _newGame;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private RepositoryItemImageComboBox _beadPlateRepoCBEdit;
        private RepositoryItemImageComboBox _smallRoadImageCBEdit;
        private RepositoryItemImageComboBox _bigRoadImageCBEdit;
        private DevExpress.XtraBars.BarButtonItem _bankerWin;
        private DevExpress.XtraBars.BarButtonItem _playerWin;
        private DevExpress.XtraBars.BarButtonItem _gameTie;
        private DevExpress.XtraBars.BarButtonItem _banker8;
        private DevExpress.XtraBars.BarButtonItem _banker9;
        private DevExpress.XtraBars.BarButtonItem _player8;
        private DevExpress.XtraBars.BarButtonItem _player9;
        private DevExpress.XtraBars.BarButtonItem _lucky6;
        private DevExpress.XtraBars.BarButtonItem _lucky63Cards;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem _lucky7;
        private DevExpress.XtraBars.BarButtonItem _lucky76;
        private DevExpress.XtraBars.BarButtonItem _panda;
        private DevExpress.XtraBars.BarButtonItem _banker7Over6;
        private DevExpress.XtraBars.BarButtonItem _tigerTie;
        private DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem1;
        private DevExpress.XtraBars.SkinPaletteDropDownButtonItem skinPaletteDropDownButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarCheckItem barCheckItem1;
        private DevExpress.XtraBars.BarCheckItem barCheckItem2;
        private DevExpress.XtraBars.BarCheckItem barCheckItem3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.BarCheckItem barCheckItem4;
        private DevExpress.XtraBars.BarCheckItem barCheckItem5;
        private RoadmapAnalysisUI.RoadmapAnalysisControl roadmapAnalysisControl1;
        private LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.BarButtonItem _newLiveGame;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraGrid.GridControl _cardsDealtGrid;
        private LayoutControlItem layoutControlItem2;
        private DevExpress.Utils.SvgImageCollection _svgCards;
        private DevExpress.XtraGrid.Views.Layout.LayoutView _cardDealtGridView;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn _card1;
        private RepositoryItemImageComboBox _cardImageCBEdit;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn _card2;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn _card3;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField__playerCard1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn1_1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
        private EmptySpaceItem emptySpaceItem1;
        private EmptySpaceItem Item1;
    }
}

