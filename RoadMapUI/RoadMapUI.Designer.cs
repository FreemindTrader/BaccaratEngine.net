using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using System.Windows.Controls;
using System.Windows.Forms;

namespace RoadMapUI
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
            _mainForm = new DevExpress.XtraEditors.DirectXFormContainerControl();
            
            _roadmapGridControl = new DevExpress.XtraVerticalGrid.VGridControl();
            repositoryItemImageComboBox1 = new RepositoryItemImageComboBox();
            _svgBaccarat = new DevExpress.Utils.SvgImageCollection( components );
            row = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            row1 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            row2 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            row3 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            row4 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            row5 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            _mainForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_roadmapGridControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemImageComboBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_svgBaccarat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            SuspendLayout();
            // 
            // _mainForm
            // 
            _mainForm.Controls.Add( _roadmapGridControl );
            _mainForm.Location = new System.Drawing.Point( 1, 46 );
            _mainForm.Margin = new Padding( 5 );
            _mainForm.Name = "_mainForm";
            _mainForm.Size = new System.Drawing.Size( 1606, 877 );
            _mainForm.TabIndex = 0;
            
            // 
            // _roadmapGridControl
            // 
            _roadmapGridControl.Location = new System.Drawing.Point( 326, 77 );
            _roadmapGridControl.Name = "_roadmapGridControl";
            _roadmapGridControl.Dock = DockStyle.Fill;
            _roadmapGridControl.OptionsView.MaxRowAutoHeight = 48;
            _roadmapGridControl.OptionsView.MinRowAutoHeight = 48;
            _roadmapGridControl.RecordWidth = 48;
            _roadmapGridControl.RepositoryItems.AddRange( new RepositoryItem[ ] { repositoryItemImageComboBox1 } );
            _roadmapGridControl.RightToLeft = RightToLeft.No;
            _roadmapGridControl.RowHeaderWidth = 15;
            _roadmapGridControl.Rows.AddRange( new DevExpress.XtraVerticalGrid.Rows.BaseRow[ ] { row, row1, row2, row3, row4, row5 } );
            _roadmapGridControl.Size = new System.Drawing.Size( 1093, 277 );
            _roadmapGridControl.TabIndex = 0;
            // 
            // repositoryItemImageComboBox1
            // 
            repositoryItemImageComboBox1.AutoHeight = false;
            repositoryItemImageComboBox1.Buttons.AddRange( new EditorButton[ ] { new EditorButton( ButtonPredefines.Combo ) } );
            repositoryItemImageComboBox1.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            repositoryItemImageComboBox1.HtmlImages = _svgBaccarat;
            repositoryItemImageComboBox1.Items.AddRange( new ImageComboBoxItem[ ] { new ImageComboBoxItem( "", 0, 0 ), new ImageComboBoxItem( "", 1, 1 ), new ImageComboBoxItem( "", 2, 2 ), new ImageComboBoxItem( "", 3, 3 ), new ImageComboBoxItem( "", 4, 4 ), new ImageComboBoxItem( "", 5, 5 ), new ImageComboBoxItem( "", 6, 6 ), new ImageComboBoxItem( "", 7, 7 ), new ImageComboBoxItem( "", 8, 8 ), new ImageComboBoxItem( "", 9, 9 ), new ImageComboBoxItem( "", 10, 10 ), new ImageComboBoxItem( "", 11, 11 ), new ImageComboBoxItem( "", 12, 12 ), new ImageComboBoxItem( "", 13, 13 ), new ImageComboBoxItem( "", 14, 14 ) } );
            repositoryItemImageComboBox1.LargeImages = _svgBaccarat;
            repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            repositoryItemImageComboBox1.SmallImages = _svgBaccarat;
            // 
            // _svgBaccarat
            // 
            _svgBaccarat.ImageSize = new System.Drawing.Size( 28, 28 );
            _svgBaccarat.Add( "transparent", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgBaccarat.transparent" ) );
            _svgBaccarat.Add( "banker", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgBaccarat.banker" ) );
            _svgBaccarat.Add( "player", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgBaccarat.player" ) );
            _svgBaccarat.Add( "tie", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgBaccarat.tie" ) );
            _svgBaccarat.Add( "banker8", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgBaccarat.banker8" ) );
            _svgBaccarat.Add( "banker9", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgBaccarat.banker9" ) );
            _svgBaccarat.Add( "player8", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgBaccarat.player8" ) );
            _svgBaccarat.Add( "player9", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgBaccarat.player9" ) );
            _svgBaccarat.Add( "banker6", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgBaccarat.banker6" ) );
            _svgBaccarat.Add( "banker63", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgBaccarat.banker63" ) );
            _svgBaccarat.Add( "player7", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgBaccarat.player7" ) );
            _svgBaccarat.Add( "player76", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgBaccarat.player76" ) );
            _svgBaccarat.Add( "tigerTie", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgBaccarat.tigerTie" ) );
            _svgBaccarat.Add( "B76_3", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgBaccarat.B76_3" ) );
            _svgBaccarat.Add( "player83", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgBaccarat.player83" ) );
            // 
            // row
            // 
            row.Name = "row";
            row.Properties.Caption = "Row0";
            row.Properties.FieldName = "Row0";
            row.Properties.RowEdit = repositoryItemImageComboBox1;
            // 
            // row1
            // 
            row1.Name = "row1";
            row1.Properties.Caption = "Row1";
            row1.Properties.FieldName = "Row1";
            row1.Properties.RowEdit = repositoryItemImageComboBox1;
            // 
            // row2
            // 
            row2.Name = "row2";
            row2.Properties.Caption = "Row2";
            row2.Properties.FieldName = "Row2";
            row2.Properties.RowEdit = repositoryItemImageComboBox1;
            // 
            // row3
            // 
            row3.Name = "row3";
            row3.Properties.Caption = "Row3";
            row3.Properties.FieldName = "Row3";
            row3.Properties.RowEdit = repositoryItemImageComboBox1;
            // 
            // row4
            // 
            row4.Name = "row4";
            row4.Properties.Caption = "Row4";
            row4.Properties.FieldName = "Row4";
            row4.Properties.RowEdit = repositoryItemImageComboBox1;
            // 
            // row5
            // 
            row5.Name = "row5";
            row5.Properties.Caption = "Row5";
            row5.Properties.FieldName = "Row5";
            row5.Properties.RowEdit = repositoryItemImageComboBox1;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Name = "Root";
            Root.Size = new System.Drawing.Size( 1606, 877 );
            Root.TextVisible = false;
            // 
            // RoadMapUI
            // 
            AutoScaleDimensions = new System.Drawing.SizeF( 10F, 22F );
            AutoScaleMode = AutoScaleMode.Font;
            ChildControls.Add( _mainForm );
            ClientSize = new System.Drawing.Size( 1608, 924 );
            Margin = new Padding( 5 );
            Name = "RoadMapUI";
            Text = "Baccarat RoadMap";
            _mainForm.ResumeLayout( false );
            ((System.ComponentModel.ISupportInitialize)_roadmapGridControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemImageComboBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)_svgBaccarat).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ResumeLayout( false );
        }

        #endregion

        private DevExpress.XtraEditors.DirectXFormContainerControl _mainForm;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox _imageCBRepo;
        private DevExpress.Utils.SvgImageCollection _svgBaccarat;        
        private DevExpress.XtraVerticalGrid.VGridControl _roadmapGridControl;
        private RepositoryItemImageComboBox _svgBaccaratComboxRepoItems;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow _bigRoadGridRow0;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow _bigRoadGridRow1;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow _bigRoadGridRow2;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow _bigRoadGridRow3;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow _bigRoadGridRow4;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow _bigRowGridRow5;
        
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow row;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow row1;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow row2;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow row3;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow row4;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow row5;
    }
}

