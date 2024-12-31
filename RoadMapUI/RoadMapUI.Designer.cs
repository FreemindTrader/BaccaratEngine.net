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
            directXFormContainerControl1 = new DevExpress.XtraEditors.DirectXFormContainerControl();
            _roadmapGridControl = new DevExpress.XtraVerticalGrid.VGridControl();
            repositoryItemImageComboBox1 = new RepositoryItemImageComboBox();
            _svgBaccarat = new DevExpress.Utils.SvgImageCollection( components );
            row = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            row1 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            row2 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            row3 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            row4 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            row5 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            _pngBaccarat = new DevExpress.Utils.ImageCollection( components );
            directXFormContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_roadmapGridControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemImageComboBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_svgBaccarat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_pngBaccarat).BeginInit();
            SuspendLayout();
            // 
            // directXFormContainerControl1
            // 
            directXFormContainerControl1.Controls.Add( _roadmapGridControl );
            directXFormContainerControl1.Location = new System.Drawing.Point( 1, 46 );
            directXFormContainerControl1.Margin = new Padding( 5 );
            directXFormContainerControl1.Name = "directXFormContainerControl1";
            directXFormContainerControl1.Size = new System.Drawing.Size( 1606, 877 );
            directXFormContainerControl1.TabIndex = 0;
            // 
            // _roadmapGridControl
            // 
            _roadmapGridControl.Dock = DockStyle.Fill;
            _roadmapGridControl.Location = new System.Drawing.Point( 0, 0 );
            _roadmapGridControl.Name = "_roadmapGridControl";
            _roadmapGridControl.OptionsView.MaxRowAutoHeight = 48;
            _roadmapGridControl.OptionsView.MinRowAutoHeight = 48;
            _roadmapGridControl.RecordWidth = 48;
            _roadmapGridControl.RepositoryItems.AddRange( new RepositoryItem[ ] { repositoryItemImageComboBox1 } );
            _roadmapGridControl.RightToLeft = RightToLeft.No;
            _roadmapGridControl.RowHeaderWidth = 15;
            _roadmapGridControl.Rows.AddRange( new DevExpress.XtraVerticalGrid.Rows.BaseRow[ ] { row, row1, row2, row3, row4, row5 } );
            _roadmapGridControl.Size = new System.Drawing.Size( 1606, 877 );
            _roadmapGridControl.TabIndex = 0;
            // 
            // repositoryItemImageComboBox1
            // 
            repositoryItemImageComboBox1.AutoHeight = false;
            repositoryItemImageComboBox1.Buttons.AddRange( new EditorButton[ ] { new EditorButton( ButtonPredefines.Combo ) } );
            repositoryItemImageComboBox1.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            repositoryItemImageComboBox1.HtmlImages = _svgBaccarat;
            repositoryItemImageComboBox1.Items.AddRange( new ImageComboBoxItem[ ] { new ImageComboBoxItem( "", 0, 0 ), new ImageComboBoxItem( "", 1, 1 ), new ImageComboBoxItem( "", 2, 2 ), new ImageComboBoxItem( "", 3, 3 ) } );
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
            // _pngBaccarat
            // 
            _pngBaccarat.ImageStream = (DevExpress.Utils.ImageCollectionStreamer)resources.GetObject( "_pngBaccarat.ImageStream" );
            _pngBaccarat.Images.SetKeyName( 0, "B" );
            _pngBaccarat.Images.SetKeyName( 1, "P" );
            // 
            // RoadMapUI
            // 
            AutoScaleDimensions = new System.Drawing.SizeF( 10F, 22F );
            AutoScaleMode = AutoScaleMode.Font;
            ChildControls.Add( directXFormContainerControl1 );
            ClientSize = new System.Drawing.Size( 1608, 924 );
            Margin = new Padding( 5 );
            Name = "RoadMapUI";
            Text = "Baccarat RoadMap";
            directXFormContainerControl1.ResumeLayout( false );
            ((System.ComponentModel.ISupportInitialize)_roadmapGridControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemImageComboBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)_svgBaccarat).EndInit();
            ((System.ComponentModel.ISupportInitialize)_pngBaccarat).EndInit();
            ResumeLayout( false );
        }

        #endregion

        private DevExpress.XtraEditors.DirectXFormContainerControl directXFormContainerControl1;
        private DevExpress.XtraVerticalGrid.VGridControl _roadmapGridControl;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow row;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow row1;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow row2;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow row3;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow row4;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow row5;

        private DevExpress.Utils.ImageCollection _pngBaccarat;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox _imageCBRepo;
        private DevExpress.Utils.SvgImageCollection _svgBaccarat;
        private RepositoryItemImageComboBox repositoryItemImageComboBox1;
    }
}

