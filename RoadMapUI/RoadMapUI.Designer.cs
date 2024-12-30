using DevExpress.XtraEditors.Controls;
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
            _roadImagesCombo = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            _svgBaccarat = new DevExpress.Utils.SvgImageCollection( components );
            row = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            row1 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            row2 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            row3 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            row4 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            row5 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            directXFormContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_roadmapGridControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_roadImagesCombo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_svgBaccarat).BeginInit();
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
            _roadmapGridControl.RepositoryItems.AddRange( new DevExpress.XtraEditors.Repository.RepositoryItem[ ] { _roadImagesCombo } );
            _roadmapGridControl.Rows.AddRange( new DevExpress.XtraVerticalGrid.Rows.BaseRow[ ] { row, row1, row2, row3, row4, row5 } );
            _roadmapGridControl.Size = new System.Drawing.Size( 1606, 877 );
            _roadmapGridControl.TabIndex = 0;
            // 
            // _roadImagesCombo
            // 
            _roadImagesCombo.AutoHeight = false;
            _roadImagesCombo.Buttons.AddRange( new EditorButton[ ] { new EditorButton( ButtonPredefines.Combo ) } );
            _roadImagesCombo.HtmlImages = _svgBaccarat;
            _roadImagesCombo.Items.AddRange( new ImageComboBoxItem[ ] { new ImageComboBoxItem( "banker", (short)1, 0 ), new ImageComboBoxItem( "banker6", (short)2, 1 ), new ImageComboBoxItem( "banker8", (short)3, 2 ), new ImageComboBoxItem( "banker9", (short)4, 3 ), new ImageComboBoxItem( "banker63", (short)5, 4 ), new ImageComboBoxItem( "player", (short)6, 5 ), new ImageComboBoxItem( "player7", (short)7, 6 ), new ImageComboBoxItem( "banker8", (short)8, 7 ), new ImageComboBoxItem( "player9", (short)9, 8 ), new ImageComboBoxItem( "player83", (short)10, 9 ), new ImageComboBoxItem( "tie", (short)11, 10 ), new ImageComboBoxItem( "tigerTie", (short)12, 11 ) } );
            _roadImagesCombo.LargeImages = _svgBaccarat;
            _roadImagesCombo.Name = "_roadImagesCombo";
            _roadImagesCombo.SmallImages = _svgBaccarat;
            // 
            // _svgBaccarat
            // 
            _svgBaccarat.Add( "banker", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgBaccarat.banker" ) );
            _svgBaccarat.Add( "banker6", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgBaccarat.banker6" ) );
            _svgBaccarat.Add( "banker8", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgBaccarat.banker8" ) );
            _svgBaccarat.Add( "banker9", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgBaccarat.banker9" ) );
            _svgBaccarat.Add( "banker63", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgBaccarat.banker63" ) );
            _svgBaccarat.Add( "player", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgBaccarat.player" ) );
            _svgBaccarat.Add( "player7", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgBaccarat.player7" ) );
            _svgBaccarat.Add( "player8", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgBaccarat.player8" ) );
            _svgBaccarat.Add( "player9", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgBaccarat.player9" ) );
            _svgBaccarat.Add( "player83", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgBaccarat.player83" ) );
            _svgBaccarat.Add( "tie", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgBaccarat.tie" ) );
            _svgBaccarat.Add( "tigerTie", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgBaccarat.tigerTie" ) );
            // 
            // row
            // 
            row.Name = "row";
            row.Properties.Caption = "Row0";
            row.Properties.FieldName = "Row0";
            //row.Properties.RowEdit = _roadImagesCombo;
            // 
            // row1
            // 
            row1.Name = "row1";
            row1.Properties.Caption = "Row1";
            row1.Properties.FieldName = "Row1";
            //row1.Properties.RowEdit = _roadImagesCombo;
            // 
            // row2
            // 
            row2.Name = "row2";
            row2.Properties.Caption = "Row2";
            row2.Properties.FieldName = "Row2";
            //row2.Properties.RowEdit = _roadImagesCombo;
            // 
            // row3
            // 
            row3.Name = "row3";
            row3.Properties.Caption = "Row3";
            row3.Properties.FieldName = "Row3";
            //row3.Properties.RowEdit = _roadImagesCombo;
            // 
            // row4
            // 
            row4.Name = "row4";
            row4.Properties.Caption = "Row4";
            row4.Properties.FieldName = "Row4";
            //row4.Properties.RowEdit = _roadImagesCombo;
            // 
            // row5
            // 
            row5.Name = "row5";
            row5.Properties.Caption = "Row5";
            row5.Properties.FieldName = "Row5";
            //row5.Properties.RowEdit = _roadImagesCombo;
            // 
            // RoadMapUI
            // 
            AutoScaleDimensions = new System.Drawing.SizeF( 10F, 22F );
            AutoScaleMode = AutoScaleMode.Font;
            ChildControls.Add( directXFormContainerControl1 );
            ClientSize = new System.Drawing.Size( 1608, 924 );
            Margin = new Padding( 5 );
            Name = "RoadMapUI";
            Text = "Form1";
            directXFormContainerControl1.ResumeLayout( false );
            ((System.ComponentModel.ISupportInitialize)_roadmapGridControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)_roadImagesCombo).EndInit();
            ((System.ComponentModel.ISupportInitialize)_svgBaccarat).EndInit();
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
        private DevExpress.Utils.SvgImageCollection _svgBaccarat;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox _roadImagesCombo;
    }
}

