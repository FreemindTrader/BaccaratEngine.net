namespace RoadmapAnalysisUI
{
    partial class RoadMapAnalysis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( RoadMapAnalysis ) );
            ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            _svgBeadPlate = new DevExpress.Utils.SvgImageCollection( components );
            roadmapAnalysisControl1 = new RoadmapAnalysisControl();
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_svgBeadPlate).BeginInit();
            SuspendLayout();
            // 
            // ribbonControl1
            // 
            ribbonControl1.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding( 50, 51, 50, 51 );
            ribbonControl1.ExpandCollapseItem.Id = 0;
            ribbonControl1.Items.AddRange( new DevExpress.XtraBars.BarItem[ ] { ribbonControl1.ExpandCollapseItem } );
            ribbonControl1.Location = new System.Drawing.Point( 0, 0 );
            ribbonControl1.Margin = new System.Windows.Forms.Padding( 5 );
            ribbonControl1.MaxItemId = 1;
            ribbonControl1.Name = "ribbonControl1";
            ribbonControl1.OptionsMenuMinWidth = 550;
            ribbonControl1.Pages.AddRange( new DevExpress.XtraBars.Ribbon.RibbonPage[ ] { ribbonPage1 } );
            ribbonControl1.Size = new System.Drawing.Size( 2195, 237 );
            // 
            // ribbonPage1
            // 
            ribbonPage1.Groups.AddRange( new DevExpress.XtraBars.Ribbon.RibbonPageGroup[ ] { ribbonPageGroup1 } );
            ribbonPage1.Name = "ribbonPage1";
            ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            ribbonPageGroup1.Name = "ribbonPageGroup1";
            ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // _svgBeadPlate
            // 
            _svgBeadPlate.ImageSize = new System.Drawing.Size( 36, 36 );
            _svgBeadPlate.Add( "transparent", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgBeadPlate.transparent" ) );
            _svgBeadPlate.Add( "B", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgBeadPlate.B" ) );
            _svgBeadPlate.Add( "bedPlateBlue", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgBeadPlate.bedPlateBlue" ) );
            _svgBeadPlate.Add( "bedPlateTie", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgBeadPlate.bedPlateTie" ) );
            _svgBeadPlate.Add( "bedPlateB8", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgBeadPlate.bedPlateB8" ) );
            _svgBeadPlate.Add( "B9", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgBeadPlate.B9" ) );
            _svgBeadPlate.Add( "P8", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgBeadPlate.P8" ) );
            _svgBeadPlate.Add( "P9", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgBeadPlate.P9" ) );
            _svgBeadPlate.Add( "B6", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgBeadPlate.B6" ) );
            _svgBeadPlate.Add( "B63_2", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgBeadPlate.B63_2" ) );
            _svgBeadPlate.Add( "P7", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgBeadPlate.P7" ) );
            _svgBeadPlate.Add( "P76", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgBeadPlate.P76" ) );
            _svgBeadPlate.Add( "TT", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgBeadPlate.TT" ) );
            _svgBeadPlate.Add( "B76", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgBeadPlate.B76" ) );
            _svgBeadPlate.Add( "P83", (DevExpress.Utils.Svg.SvgImage)resources.GetObject( "_svgBeadPlate.P83" ) );
            // 
            // roadmapAnalysisControl1
            // 
            roadmapAnalysisControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            roadmapAnalysisControl1.Location = new System.Drawing.Point( 0, 237 );
            roadmapAnalysisControl1.Name = "roadmapAnalysisControl1";
            roadmapAnalysisControl1.Size = new System.Drawing.Size( 2195, 865 );
            roadmapAnalysisControl1.TabIndex = 5;
            // 
            // RoadMapAnalysis
            // 
            AutoScaleDimensions = new System.Drawing.SizeF( 10F, 22F );
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size( 2195, 1102 );
            Controls.Add( roadmapAnalysisControl1 );
            Controls.Add( ribbonControl1 );
            Margin = new System.Windows.Forms.Padding( 5 );
            Name = "RoadMapAnalysis";
            Ribbon = ribbonControl1;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)_svgBeadPlate).EndInit();
            ResumeLayout( false );
            PerformLayout();
        }



        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.Utils.SvgImageCollection _svgBeadPlate;
        private RoadmapAnalysisControl roadmapAnalysisControl1;
    }
}

