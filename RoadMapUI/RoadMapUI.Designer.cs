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
            directXFormContainerControl1 = new DevExpress.XtraEditors.DirectXFormContainerControl();
            _roadmapGrid = new DevExpress.XtraVerticalGrid.VGridControl();
            row = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            row1 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            row2 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            row3 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            row4 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            row5 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            directXFormContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_roadmapGrid).BeginInit();
            SuspendLayout();
            // 
            // directXFormContainerControl1
            // 
            directXFormContainerControl1.Controls.Add( _roadmapGrid );
            directXFormContainerControl1.Location = new System.Drawing.Point( 1, 46 );
            directXFormContainerControl1.Margin = new System.Windows.Forms.Padding( 5 );
            directXFormContainerControl1.Name = "directXFormContainerControl1";
            directXFormContainerControl1.Size = new System.Drawing.Size( 1606, 877 );
            directXFormContainerControl1.TabIndex = 0;
            // 
            // vGridControl1
            // 
            _roadmapGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            _roadmapGrid.Location = new System.Drawing.Point( 0, 0 );
            _roadmapGrid.Name = "vGridControl1";
            _roadmapGrid.Rows.AddRange( new DevExpress.XtraVerticalGrid.Rows.BaseRow[ ] { row, row1, row2, row3, row4, row5 } );
            _roadmapGrid.Size = new System.Drawing.Size( 1606, 877 );
            _roadmapGrid.TabIndex = 0;
            // 
            // row
            // 
            row.Name = "row";
            row.Properties.Caption = "Row0";
            row.Properties.FieldName = "Row0";
            // 
            // row1
            // 
            row1.Name = "row1";
            row1.Properties.Caption = "Row1";
            row1.Properties.FieldName = "Row1";
            // 
            // row2
            // 
            row2.Name = "row2";
            row2.Properties.Caption = "Row2";
            row2.Properties.FieldName = "Row2";
            // 
            // row3
            // 
            row3.Name = "row3";
            row3.Properties.Caption = "Row3";
            row3.Properties.FieldName = "Row3";
            // 
            // row4
            // 
            row4.Name = "row4";
            row4.Properties.Caption = "Row4";
            row4.Properties.FieldName = "Row4";
            // 
            // row5
            // 
            row5.Name = "row5";
            row5.Properties.Caption = "Row5";
            row5.Properties.FieldName = "Row5";
            // 
            // RoadMapUI
            // 
            AutoScaleDimensions = new System.Drawing.SizeF( 10F, 22F );
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ChildControls.Add( directXFormContainerControl1 );
            ClientSize = new System.Drawing.Size( 1608, 924 );
            Margin = new System.Windows.Forms.Padding( 5 );
            Name = "RoadMapUI";
            Text = "Form1";
            directXFormContainerControl1.ResumeLayout( false );
            ((System.ComponentModel.ISupportInitialize)_roadmapGrid).EndInit();
            ResumeLayout( false );
        }

        #endregion

        private DevExpress.XtraEditors.DirectXFormContainerControl directXFormContainerControl1;
        private DevExpress.XtraVerticalGrid.VGridControl _roadmapGrid;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow row;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow row1;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow row2;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow row3;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow row4;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow row5;
    }
}

