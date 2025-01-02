using DevExpress.Map.Kml.Model;
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
            barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem11 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem12 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem13 = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem14 = new DevExpress.XtraBars.BarButtonItem();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            _uiLayoutControl = new LayoutControl();
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
            barButtonItem15 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_uiLayoutControl).BeginInit();
            _uiLayoutControl.SuspendLayout();
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
            SuspendLayout();
            // 
            // ribbonControl1
            // 
            ribbonControl1.EmptyAreaImageOptions.ImagePadding = new Padding( 50, 51, 50, 51 );
            ribbonControl1.ExpandCollapseItem.Id = 0;
            ribbonControl1.Items.AddRange( new DevExpress.XtraBars.BarItem[ ] { ribbonControl1.ExpandCollapseItem, barButtonItem1, barButtonItem4, barButtonItem2, barButtonItem3, barButtonItem5, barButtonItem6, barButtonItem7, barButtonItem8, barButtonItem9, barButtonItem10, barButtonItem11, barButtonItem12, barButtonItem13, barButtonItem14, barButtonItem15 } );
            ribbonControl1.Location = new System.Drawing.Point( 0, 0 );
            ribbonControl1.Margin = new Padding( 5 );
            ribbonControl1.MaxItemId = 18;
            ribbonControl1.Name = "ribbonControl1";
            ribbonControl1.OptionsMenuMinWidth = 550;
            ribbonControl1.Pages.AddRange( new DevExpress.XtraBars.Ribbon.RibbonPage[ ] { ribbonPage1, ribbonPage2 } );
            ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            ribbonControl1.Size = new System.Drawing.Size( 1993, 134 );
            // 
            // barButtonItem1
            // 
            barButtonItem1.Caption = "New";
            barButtonItem1.Id = 1;
            barButtonItem1.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "barButtonItem1.ImageOptions.SvgImage" );
            barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem4
            // 
            barButtonItem4.Caption = "Banker";
            barButtonItem4.Id = 4;
            barButtonItem4.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "barButtonItem4.ImageOptions.SvgImage" );
            barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem2
            // 
            barButtonItem2.Caption = "Player";
            barButtonItem2.Id = 5;
            barButtonItem2.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "barButtonItem2.ImageOptions.SvgImage" );
            barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            barButtonItem3.Caption = "Tie";
            barButtonItem3.Id = 6;
            barButtonItem3.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "barButtonItem3.ImageOptions.SvgImage" );
            barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem5
            // 
            barButtonItem5.Caption = "N8";
            barButtonItem5.Id = 7;
            barButtonItem5.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "barButtonItem5.ImageOptions.SvgImage" );
            barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem6
            // 
            barButtonItem6.Caption = "N9";
            barButtonItem6.Id = 8;
            barButtonItem6.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "barButtonItem6.ImageOptions.SvgImage" );
            barButtonItem6.Name = "barButtonItem6";
            // 
            // barButtonItem7
            // 
            barButtonItem7.Caption = "N8";
            barButtonItem7.Id = 9;
            barButtonItem7.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "barButtonItem7.ImageOptions.SvgImage" );
            barButtonItem7.Name = "barButtonItem7";
            // 
            // barButtonItem8
            // 
            barButtonItem8.Caption = "N9";
            barButtonItem8.Id = 10;
            barButtonItem8.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "barButtonItem8.ImageOptions.SvgImage" );
            barButtonItem8.Name = "barButtonItem8";
            // 
            // barButtonItem9
            // 
            barButtonItem9.Caption = "Lucky6";
            barButtonItem9.Id = 11;
            barButtonItem9.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "barButtonItem9.ImageOptions.SvgImage" );
            barButtonItem9.Name = "barButtonItem9";
            // 
            // barButtonItem10
            // 
            barButtonItem10.Caption = "Lucky6(3)";
            barButtonItem10.Id = 12;
            barButtonItem10.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "barButtonItem10.ImageOptions.SvgImage" );
            barButtonItem10.Name = "barButtonItem10";
            // 
            // barButtonItem11
            // 
            barButtonItem11.Caption = "Lucky7";
            barButtonItem11.Id = 13;
            barButtonItem11.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "barButtonItem11.ImageOptions.SvgImage" );
            barButtonItem11.Name = "barButtonItem11";
            // 
            // barButtonItem12
            // 
            barButtonItem12.Caption = "Lucky76";
            barButtonItem12.Id = 14;
            barButtonItem12.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "barButtonItem12.ImageOptions.SvgImage" );
            barButtonItem12.Name = "barButtonItem12";
            // 
            // barButtonItem13
            // 
            barButtonItem13.Caption = "Panda";
            barButtonItem13.Id = 15;
            barButtonItem13.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "barButtonItem13.ImageOptions.SvgImage" );
            barButtonItem13.Name = "barButtonItem13";
            // 
            // barButtonItem14
            // 
            barButtonItem14.Caption = "B76";
            barButtonItem14.Id = 16;
            barButtonItem14.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "barButtonItem14.ImageOptions.SvgImage" );
            barButtonItem14.Name = "barButtonItem14";
            // 
            // ribbonPage1
            // 
            ribbonPage1.Groups.AddRange( new DevExpress.XtraBars.Ribbon.RibbonPageGroup[ ] { ribbonPageGroup1, ribbonPageGroup3, ribbonPageGroup4, ribbonPageGroup5 } );
            ribbonPage1.Name = "ribbonPage1";
            ribbonPage1.Text = "Home";
            // 
            // ribbonPageGroup1
            // 
            ribbonPageGroup1.ItemLinks.Add( barButtonItem1 );
            ribbonPageGroup1.Name = "ribbonPageGroup1";
            ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonPageGroup3
            // 
            ribbonPageGroup3.ItemLinks.Add( barButtonItem4 );
            ribbonPageGroup3.ItemLinks.Add( barButtonItem2 );
            ribbonPageGroup3.ItemLinks.Add( barButtonItem3 );
            ribbonPageGroup3.Name = "ribbonPageGroup3";
            ribbonPageGroup3.Text = "Game Result";
            // 
            // ribbonPageGroup4
            // 
            ribbonPageGroup4.ItemLinks.Add( barButtonItem5 );
            ribbonPageGroup4.ItemLinks.Add( barButtonItem6 );
            ribbonPageGroup4.ItemLinks.Add( barButtonItem7 );
            ribbonPageGroup4.ItemLinks.Add( barButtonItem8 );
            ribbonPageGroup4.Name = "ribbonPageGroup4";
            ribbonPageGroup4.Text = "ribbonPageGroup4";
            // 
            // ribbonPageGroup5
            // 
            ribbonPageGroup5.ItemLinks.Add( barButtonItem9 );
            ribbonPageGroup5.ItemLinks.Add( barButtonItem10 );
            ribbonPageGroup5.ItemLinks.Add( barButtonItem14 );
            ribbonPageGroup5.ItemLinks.Add( barButtonItem11 );
            ribbonPageGroup5.ItemLinks.Add( barButtonItem12 );
            ribbonPageGroup5.ItemLinks.Add( barButtonItem13 );
            ribbonPageGroup5.ItemLinks.Add( barButtonItem15 );
            ribbonPageGroup5.Name = "ribbonPageGroup5";
            ribbonPageGroup5.Text = "ribbonPageGroup5";
            // 
            // ribbonPage2
            // 
            ribbonPage2.Groups.AddRange( new DevExpress.XtraBars.Ribbon.RibbonPageGroup[ ] { ribbonPageGroup2 } );
            ribbonPage2.Name = "ribbonPage2";
            ribbonPage2.Text = "Insert";
            // 
            // ribbonPageGroup2
            // 
            ribbonPageGroup2.Name = "ribbonPageGroup2";
            ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // _uiLayoutControl
            // 
            _uiLayoutControl.Controls.Add( _cockRoachGrid );
            _uiLayoutControl.Controls.Add( _bigEyeGrid );
            _uiLayoutControl.Controls.Add( _beadPlateRoadGrid );
            _uiLayoutControl.Controls.Add( _smallRoadGrid );
            _uiLayoutControl.Controls.Add( _bigRoadGrid );
            _uiLayoutControl.Dock = DockStyle.Fill;
            _uiLayoutControl.Location = new System.Drawing.Point( 0, 134 );
            _uiLayoutControl.Name = "_uiLayoutControl";
            _uiLayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle( 2471, 535, 975, 600 );
            _uiLayoutControl.Root = _mainFormLayoutControlGroup;
            _uiLayoutControl.Size = new System.Drawing.Size( 1993, 823 );
            _uiLayoutControl.TabIndex = 1;
            _uiLayoutControl.Text = "BigRoad";
            // 
            // _cockRoachGrid
            // 
            _cockRoachGrid.Location = new System.Drawing.Point( 692, 637 );
            _cockRoachGrid.Name = "_cockRoachGrid";
            _cockRoachGrid.OptionsView.FixRowHeaderPanelWidth = true;
            _cockRoachGrid.OptionsView.MaxRowAutoHeight = 30;
            _cockRoachGrid.OptionsView.MinRowAutoHeight = 30;
            _cockRoachGrid.OptionsView.ShowRows = false;
            _cockRoachGrid.RecordWidth = 30;
            _cockRoachGrid.RepositoryItems.AddRange( new RepositoryItem[ ] { _cockRoachCBEdit } );
            _cockRoachGrid.RowHeaderWidth = 15;
            _cockRoachGrid.Rows.AddRange( new DevExpress.XtraVerticalGrid.Rows.BaseRow[ ] { _cockRoachRow0, _cockRoachRow1, _cockRoachRow2, _cockRoachRow3, _cockRoachRow4, _cockRoachRow5 } );
            _cockRoachGrid.Size = new System.Drawing.Size( 1289, 174 );
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
            _bigEyeGrid.Location = new System.Drawing.Point( 692, 312 );
            _bigEyeGrid.Name = "_bigEyeGrid";
            _bigEyeGrid.OptionsView.FixRowHeaderPanelWidth = true;
            _bigEyeGrid.OptionsView.MaxRowAutoHeight = 30;
            _bigEyeGrid.OptionsView.MinRowAutoHeight = 30;
            _bigEyeGrid.OptionsView.ShowRows = false;
            _bigEyeGrid.RecordWidth = 30;
            _bigEyeGrid.RepositoryItems.AddRange( new RepositoryItem[ ] { _bigEyeRoadCBEdit } );
            _bigEyeGrid.RowHeaderWidth = 15;
            _bigEyeGrid.Rows.AddRange( new DevExpress.XtraVerticalGrid.Rows.BaseRow[ ] { _bigEyeRoad0, _bigEyeRoad1, _bigEyeRoad2, _bigEyeRoad3, _bigEyeRoad4, _bigEyeRoad5 } );
            _bigEyeGrid.Size = new System.Drawing.Size( 1289, 117 );
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
            _beadPlateRoadGrid.Location = new System.Drawing.Point( 12, 312 );
            _beadPlateRoadGrid.Name = "_beadPlateRoadGrid";
            _beadPlateRoadGrid.OptionsView.FixRowHeaderPanelWidth = true;
            _beadPlateRoadGrid.OptionsView.MaxRowAutoHeight = 64;
            _beadPlateRoadGrid.OptionsView.MinRowAutoHeight = 64;
            _beadPlateRoadGrid.OptionsView.ShowRows = false;
            _beadPlateRoadGrid.RecordWidth = 64;
            _beadPlateRoadGrid.RepositoryItems.AddRange( new RepositoryItem[ ] { _beadPlateRepoCBEdit } );
            _beadPlateRoadGrid.RowHeaderWidth = 15;
            _beadPlateRoadGrid.Rows.AddRange( new DevExpress.XtraVerticalGrid.Rows.BaseRow[ ] { _beadPlateRow0, _beadPlateRow1, _beadPlateRow2, _beadPlateRow3, _beadPlateRow4, _beadPlateRow5 } );
            _beadPlateRoadGrid.Size = new System.Drawing.Size( 676, 499 );
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
            _smallRoadGrid.Location = new System.Drawing.Point( 692, 458 );
            _smallRoadGrid.Name = "_smallRoadGrid";
            _smallRoadGrid.OptionsView.FixRowHeaderPanelWidth = true;
            _smallRoadGrid.OptionsView.MaxRowAutoHeight = 30;
            _smallRoadGrid.OptionsView.MinRowAutoHeight = 30;
            _smallRoadGrid.OptionsView.ShowRows = false;
            _smallRoadGrid.RecordWidth = 30;
            _smallRoadGrid.RepositoryItems.AddRange( new RepositoryItem[ ] { _smallRoadImageCBEdit } );
            _smallRoadGrid.RowHeaderWidth = 15;
            _smallRoadGrid.Rows.AddRange( new DevExpress.XtraVerticalGrid.Rows.BaseRow[ ] { _smallRoadRow0, _smallRoadRow1, _smallRoadRow2, _smallRoadRow3, _smallRoadRow4, _smallRoadRow5 } );
            _smallRoadGrid.Size = new System.Drawing.Size( 1289, 150 );
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
            _bigRoadGrid.Size = new System.Drawing.Size( 1969, 246 );
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
            _mainFormLayoutControlGroup.Items.AddRange( new BaseLayoutItem[ ] { _bigRoadLayoutControlItem, _smallRoadLayoutControlItem, _beadPlateLayoutControlItem, _bigEyeLayoutControlItem, _cockRoachLayoutControlItem } );
            _mainFormLayoutControlGroup.Name = "Root";
            _mainFormLayoutControlGroup.Size = new System.Drawing.Size( 1993, 823 );
            _mainFormLayoutControlGroup.TextVisible = false;
            // 
            // _bigRoadLayoutControlItem
            // 
            _bigRoadLayoutControlItem.Control = _bigRoadGrid;
            _bigRoadLayoutControlItem.Location = new System.Drawing.Point( 0, 0 );
            _bigRoadLayoutControlItem.Name = "layoutControlItem2";
            _bigRoadLayoutControlItem.Size = new System.Drawing.Size( 1973, 275 );
            _bigRoadLayoutControlItem.Text = "Big Road";
            _bigRoadLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            _bigRoadLayoutControlItem.TextSize = new System.Drawing.Size( 111, 22 );
            // 
            // _smallRoadLayoutControlItem
            // 
            _smallRoadLayoutControlItem.Control = _smallRoadGrid;
            _smallRoadLayoutControlItem.Location = new System.Drawing.Point( 680, 421 );
            _smallRoadLayoutControlItem.Name = "layoutControlItem3";
            _smallRoadLayoutControlItem.Size = new System.Drawing.Size( 1293, 179 );
            _smallRoadLayoutControlItem.Text = "Small Road";
            _smallRoadLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            _smallRoadLayoutControlItem.TextSize = new System.Drawing.Size( 111, 22 );
            // 
            // _beadPlateLayoutControlItem
            // 
            _beadPlateLayoutControlItem.Control = _beadPlateRoadGrid;
            _beadPlateLayoutControlItem.Location = new System.Drawing.Point( 0, 275 );
            _beadPlateLayoutControlItem.Name = "layoutControlItem4";
            _beadPlateLayoutControlItem.Size = new System.Drawing.Size( 680, 528 );
            _beadPlateLayoutControlItem.Text = "Bead Plate";
            _beadPlateLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            _beadPlateLayoutControlItem.TextSize = new System.Drawing.Size( 111, 22 );
            // 
            // _bigEyeLayoutControlItem
            // 
            _bigEyeLayoutControlItem.Control = _bigEyeGrid;
            _bigEyeLayoutControlItem.Location = new System.Drawing.Point( 680, 275 );
            _bigEyeLayoutControlItem.Name = "layoutControlItem1";
            _bigEyeLayoutControlItem.Size = new System.Drawing.Size( 1293, 146 );
            _bigEyeLayoutControlItem.Text = "Big Eye Road";
            _bigEyeLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            _bigEyeLayoutControlItem.TextSize = new System.Drawing.Size( 111, 22 );
            // 
            // _cockRoachLayoutControlItem
            // 
            _cockRoachLayoutControlItem.Control = _cockRoachGrid;
            _cockRoachLayoutControlItem.Location = new System.Drawing.Point( 680, 600 );
            _cockRoachLayoutControlItem.Name = "layoutControlItem5";
            _cockRoachLayoutControlItem.Size = new System.Drawing.Size( 1293, 203 );
            _cockRoachLayoutControlItem.Text = "Cockroach Pig";
            _cockRoachLayoutControlItem.TextLocation = DevExpress.Utils.Locations.Top;
            _cockRoachLayoutControlItem.TextSize = new System.Drawing.Size( 111, 22 );
            // 
            // barButtonItem15
            // 
            barButtonItem15.Caption = "Tiger Tie";
            barButtonItem15.Id = 17;
            barButtonItem15.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "barButtonItem15.ImageOptions.SvgImage" );
            barButtonItem15.Name = "barButtonItem15";
            // 
            // RoadMapUI
            // 
            AutoScaleDimensions = new System.Drawing.SizeF( 10F, 22F );
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size( 1993, 957 );
            Controls.Add( _uiLayoutControl );
            Controls.Add( ribbonControl1 );
            Margin = new Padding( 5 );
            Name = "RoadMapUI";
            Ribbon = ribbonControl1;
            Text = "Baccarat RoadMap";
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)_uiLayoutControl).EndInit();
            _uiLayoutControl.ResumeLayout( false );
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
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private RepositoryItemImageComboBox _beadPlateRepoCBEdit;
        private RepositoryItemImageComboBox _smallRoadImageCBEdit;
        private RepositoryItemImageComboBox _bigRoadImageCBEdit;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem11;
        private DevExpress.XtraBars.BarButtonItem barButtonItem12;
        private DevExpress.XtraBars.BarButtonItem barButtonItem13;
        private DevExpress.XtraBars.BarButtonItem barButtonItem14;
        private DevExpress.XtraBars.BarButtonItem barButtonItem15;
    }
}

