using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static BaccaratEngine.GameAnalysisHelper;

namespace RoadmapAnalysisUI
{
    public partial class RoadMapAnalysis : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DataTable Table;
        public RoadMapAnalysis()
        {
            InitializeComponent();
        }

        private void Form1_Load( object sender, System.EventArgs e )
        {
            //Table = CreatePivotTable( 100 );
            //_roadAnalysisGrid.DataSource = GetData();
        }

        private BindingList<BettingSuggestion> GetData()
        {
            BindingList<BettingSuggestion> list = new BindingList<BettingSuggestion>();
            BindingList<Details> details = new BindingList<Details>();
            for (int i = 0; i < 10; i++)
            {
                details.Add( new Details() { ID = i, Name = "Name" + i } );
                list.Add( new BettingSuggestion() { ID = i, Name = "Name" + i, Details = details } );
            }
            return list;
        }

        public class BettingSuggestion
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public BindingList<Details> Details { get; set; }
        }
        public class Details
        {
            public int ID { get; set; }
            public string Name { get; set; }
        }

        private static DataTable CreatePivotTable( int RowCount )
        {
            Random rnd = new Random();

            DataTable tbl = new DataTable();
            tbl.Columns.Add( "GameID", typeof( int ) );
            tbl.Columns.Add( "RoadType", typeof( string ) );
            tbl.Columns.Add( "RoadLength", typeof( int ) );
            tbl.Columns.Add( "Majority", typeof( MajorColor ) );
            tbl.Columns.Add( "MoreBy", typeof( int ) );
            tbl.Columns.Add( "ChopStreak", typeof( ChopOrStreaks ) );
            tbl.Columns.Add( "Row1_2", typeof( decimal ) );
            tbl.Columns.Add( "Row2_3", typeof( decimal ) );
            tbl.Columns.Add( "Row3_4", typeof( decimal ) );
            tbl.Columns.Add( "Row4_5", typeof( decimal ) );
            tbl.Columns.Add( "Row5_N", typeof( decimal ) );            
            tbl.Columns.Add( "Pattern", typeof( Patterns ) );
            tbl.Columns.Add( "IsNatural", typeof( bool ) );
            tbl.Columns.Add( "RoadBroken", typeof( bool ) );
            tbl.Columns.Add( "NumberOfBroken", typeof( int ) );
            tbl.Columns.Add( "BankerOfPlayer", typeof( BetConclusion ) );

            var game11 = new object[ ] { 1, RoadType.BigRoad.ToString(),      (int) RoadLength.Short, MajorColor.Banker, 1, ChopOrStreaks.Streaks, 0, 0, 0, 0, 0, Patterns.None, false, false, 0, BetConclusion.Skip };
            var game12 = new object[ ] { 1, RoadType.BeadPlate.ToString(),    (int) RoadLength.None,  MajorColor.Banker, 1, ChopOrStreaks.Streaks, 0, 0, 0, 0, 0, Patterns.None, false, false, 0, BetConclusion.Skip };
            var game13 = new object[ ] { 1, RoadType.BigEye.ToString(),       (int) RoadLength.None,  MajorColor.None,   0, ChopOrStreaks.None, 0, 0, 0, 0, 0, Patterns.None, false, false, 0, BetConclusion.Skip };
            var game14 = new object[ ] { 1, RoadType.SmallRoad.ToString(),    (int) RoadLength.None,  MajorColor.None,   0, ChopOrStreaks.None, 0, 0, 0, 0, 0, Patterns.None, false, false, 0, BetConclusion.Skip };
            var game15 = new object[ ] { 1, RoadType.CockRoachRoad.ToString(), (int) RoadLength.None,  MajorColor.None,   0, ChopOrStreaks.None, 0, 0, 0, 0, 0, Patterns.None, false, false, 0, BetConclusion.Skip };

            var game21 = new object[ ] { 2, RoadType.BigRoad.ToString(),      (int) RoadLength.Short, MajorColor.Banker, 2, ChopOrStreaks.Streaks, 0, 0, 0, 0, 0, Patterns.None, false, false, 0, BetConclusion.Skip };
            var game22 = new object[ ] { 2, RoadType.BeadPlate.ToString(),    (int) RoadLength.None,  MajorColor.Banker, 2, ChopOrStreaks.Streaks, 0, 0, 0, 0, 0, Patterns.None, false, false, 0, BetConclusion.Skip };
            var game23 = new object[ ] { 2, RoadType.BigEye.ToString(),       (int) RoadLength.None,  MajorColor.None,   0, ChopOrStreaks.None, 0, 0, 0, 0, 0, Patterns.None, false, false, 0, BetConclusion.Skip };
            var game24 = new object[ ] { 2, RoadType.SmallRoad.ToString(),    (int) RoadLength.None,  MajorColor.None,   0, ChopOrStreaks.None, 0, 0, 0, 0, 0, Patterns.None, false, false, 0, BetConclusion.Skip };
            var game25 = new object[ ] { 2, RoadType.CockRoachRoad.ToString(), (int) RoadLength.None,  MajorColor.None,   0, ChopOrStreaks.None, 0, 0, 0, 0, 0, Patterns.None, false, false, 0, BetConclusion.Skip };

            var game31 = new object[ ] { 3, RoadType.BigRoad.ToString(),      (int) RoadLength.Medium,MajorColor.Banker, 3, ChopOrStreaks.Streaks, 0, 0, 0, 0, 0, Patterns.Streaks, false, false, 0, BetConclusion.Banker };
            var game32 = new object[ ] { 3, RoadType.BeadPlate.ToString(),    (int) RoadLength.None,  MajorColor.Banker, 3, ChopOrStreaks.Streaks, 0, 0, 0, 0, 0, Patterns.None, false, false, 0, BetConclusion.Skip };
            var game33 = new object[ ] { 3, RoadType.BigEye.ToString(),       (int) RoadLength.None,  MajorColor.None,   0, ChopOrStreaks.None, 0, 0, 0, 0, 0, Patterns.None, false, false, 0, BetConclusion.Skip };
            var game34 = new object[ ] { 3, RoadType.SmallRoad.ToString(),    (int) RoadLength.None,  MajorColor.None,   0, ChopOrStreaks.None, 0, 0, 0, 0, 0, Patterns.None, false, false, 0, BetConclusion.Skip };
            var game35 = new object[ ] { 3, RoadType.CockRoachRoad.ToString(), (int) RoadLength.None,  MajorColor.None,   0, ChopOrStreaks.None, 0, 0, 0, 0, 0, Patterns.None, false, false, 0, BetConclusion.Skip };

            var game41 = new object[ ] { 4, RoadType.BigRoad.ToString(),      (int) RoadLength.Medium,MajorColor.Banker, 4, ChopOrStreaks.Streaks, 0, 0, 0, 0, 0, Patterns.Streaks, false, false, 0, BetConclusion.Banker };
            var game42 = new object[ ] { 4, RoadType.BeadPlate.ToString(),    (int) RoadLength.None,  MajorColor.Banker, 4, ChopOrStreaks.Streaks, 0, 0, 0, 0, 0, Patterns.None, false, false, 0, BetConclusion.Skip };
            var game43 = new object[ ] { 4, RoadType.BigEye.ToString(),       (int) RoadLength.None,  MajorColor.None,   0, ChopOrStreaks.None, 0, 0, 0, 0, 0, Patterns.None, false, false, 0, BetConclusion.Skip };
            var game44 = new object[ ] { 4, RoadType.SmallRoad.ToString(),    (int) RoadLength.None,  MajorColor.None,   0, ChopOrStreaks.None, 0, 0, 0, 0, 0, Patterns.None, false, false, 0, BetConclusion.Skip };
            var game45 = new object[ ] { 4, RoadType.CockRoachRoad.ToString(), (int) RoadLength.None,  MajorColor.None,   0, ChopOrStreaks.None, 0, 0, 0, 0, 0, Patterns.None, false, false, 0, BetConclusion.Skip };

            var game51 = new object[ ] { 5, RoadType.BigRoad.ToString(),      (int) RoadLength.Long,  MajorColor.Banker, 5, ChopOrStreaks.Streaks, 0, 0, 0, 0, 0, Patterns.Streaks, false, false, 0, BetConclusion.Banker };
            var game52 = new object[ ] { 5, RoadType.BeadPlate.ToString(),    (int) RoadLength.None,  MajorColor.Banker, 5, ChopOrStreaks.Streaks, 0, 0, 0, 0, 0, Patterns.None, false, false, 0, BetConclusion.Skip };
            var game53 = new object[ ] { 5, RoadType.BigEye.ToString(),       (int) RoadLength.None,  MajorColor.None,   0, ChopOrStreaks.None, 0, 0, 0, 0, 0, Patterns.None, false, false, 0, BetConclusion.Skip };
            var game54 = new object[ ] { 5, RoadType.SmallRoad.ToString(),    (int) RoadLength.None,  MajorColor.None,   0, ChopOrStreaks.None, 0, 0, 0, 0, 0, Patterns.None, false, false, 0, BetConclusion.Skip };
            var game55 = new object[ ] { 5, RoadType.CockRoachRoad.ToString(), (int) RoadLength.None,  MajorColor.None,   0, ChopOrStreaks.None, 0, 0, 0, 0, 0, Patterns.None, false, false, 0, BetConclusion.Skip };

            var game61 = new object[ ] { 6, RoadType.BigRoad.ToString(),      (int) RoadLength.Long,  MajorColor.Banker, 6, ChopOrStreaks.Streaks, 0, 0, 0, 0, 0, Patterns.Streaks, false, false, 0, BetConclusion.Banker };
            var game62 = new object[ ] { 6, RoadType.BeadPlate.ToString(),    (int) RoadLength.None,  MajorColor.Banker, 6, ChopOrStreaks.Streaks, 0, 0, 0, 0, 0, Patterns.None, false, false, 0, BetConclusion.Skip };
            var game63 = new object[ ] { 6, RoadType.BigEye.ToString(),       (int) RoadLength.None,  MajorColor.None,   0, ChopOrStreaks.None, 0, 0, 0, 0, 0, Patterns.None, false, false, 0, BetConclusion.Skip };
            var game64 = new object[ ] { 6, RoadType.SmallRoad.ToString(),    (int) RoadLength.None,  MajorColor.None,   0, ChopOrStreaks.None, 0, 0, 0, 0, 0, Patterns.None, false, false, 0, BetConclusion.Skip };
            var game65 = new object[ ] { 6, RoadType.CockRoachRoad.ToString(), (int) RoadLength.None,  MajorColor.None,   0, ChopOrStreaks.None, 0, 0, 0, 0, 0, Patterns.None, false, false, 0, BetConclusion.Skip };

            var game71 = new object[ ] { 7, RoadType.BigRoad.ToString(),      (int) RoadLength.Long,  MajorColor.Banker, 7, ChopOrStreaks.Streaks, 0, 0, 0, 0, 0, Patterns.Streaks, false, false, 0, BetConclusion.Banker };
            var game72 = new object[ ] { 7, RoadType.BeadPlate.ToString(),    (int) RoadLength.None,  MajorColor.Banker, 7, ChopOrStreaks.Streaks, 0, 0, 0, 0, 0, Patterns.None, false, false, 0, BetConclusion.Skip };
            var game73 = new object[ ] { 7, RoadType.BigEye.ToString(),       (int) RoadLength.None,  MajorColor.None,   0, ChopOrStreaks.None, 0, 0, 0, 0, 0, Patterns.None, false, false, 0, BetConclusion.Skip };
            var game74 = new object[ ] { 7, RoadType.SmallRoad.ToString(),    (int) RoadLength.None,  MajorColor.None,   0, ChopOrStreaks.None, 0, 0, 0, 0, 0, Patterns.None, false, false, 0, BetConclusion.Skip };
            var game75 = new object[ ] { 7, RoadType.CockRoachRoad.ToString(), (int) RoadLength.None,  MajorColor.None,   0, ChopOrStreaks.None, 0, 0, 0, 0, 0, Patterns.None, false, false, 0, BetConclusion.Skip };

            var game81 = new object[ ] { 8, RoadType.BigRoad.ToString(),      (int) RoadLength.Long,  MajorColor.Banker, 8, ChopOrStreaks.Streaks, 0, 0, 0, 0, 0, Patterns.Streaks, false, false, 0, BetConclusion.Banker };
            var game82 = new object[ ] { 8, RoadType.BeadPlate.ToString(),    (int) RoadLength.None,  MajorColor.Banker, 8, ChopOrStreaks.Streaks, 0, 0, 0, 0, 0, Patterns.None, false, false, 0, BetConclusion.Skip };
            var game83 = new object[ ] { 8, RoadType.BigEye.ToString(),       (int) RoadLength.None,  MajorColor.None,   0, ChopOrStreaks.None, 0, 0, 0, 0, 0, Patterns.None, false, false, 0, BetConclusion.Skip };
            var game84 = new object[ ] { 8, RoadType.SmallRoad.ToString(),    (int) RoadLength.None,  MajorColor.None,   0, ChopOrStreaks.None, 0, 0, 0, 0, 0, Patterns.None, false, false, 0, BetConclusion.Skip };
            var game85 = new object[ ] { 8, RoadType.CockRoachRoad.ToString(), (int) RoadLength.None,  MajorColor.None,   0, ChopOrStreaks.None, 0, 0, 0, 0, 0, Patterns.None, false, false, 0, BetConclusion.Skip };

            var game91 = new object[ ] { 9, RoadType.BigRoad.ToString(),      (int) RoadLength.Long,  MajorColor.Banker, 9, ChopOrStreaks.Streaks, 0, 0, 0, 0, 0, Patterns.Streaks, false, false, 0, BetConclusion.Banker };
            var game92 = new object[ ] { 9, RoadType.BeadPlate.ToString(),    (int) RoadLength.None,  MajorColor.Banker, 9, ChopOrStreaks.Streaks, 0, 0, 0, 0, 0, Patterns.None, false, false, 0, BetConclusion.Skip };
            var game93 = new object[ ] { 9, RoadType.BigEye.ToString(),       (int) RoadLength.None,  MajorColor.None,   0, ChopOrStreaks.None, 0, 0, 0, 0, 0, Patterns.None, false, false, 0, BetConclusion.Skip };
            var game94 = new object[ ] { 9, RoadType.SmallRoad.ToString(),    (int) RoadLength.None,  MajorColor.None,   0, ChopOrStreaks.None, 0, 0, 0, 0, 0, Patterns.None, false, false, 0, BetConclusion.Skip };
            var game95 = new object[ ] { 9, RoadType.CockRoachRoad.ToString(), (int) RoadLength.None,  MajorColor.None,   0, ChopOrStreaks.None, 0, 0, 0, 0, 0, Patterns.None, false, false, 0, BetConclusion.Skip };

            var game101 = new object[ ] { 10, RoadType.BigRoad.ToString(),      (int) RoadLength.Long,  MajorColor.Banker, 9, ChopOrStreaks.Streaks, 0, 0, 0, 0, 0, Patterns.Streaks, false, true, 0, BetConclusion.Banker };
            var game102 = new object[ ] { 10, RoadType.BeadPlate.ToString(),    (int) RoadLength.None,  MajorColor.Banker, 9, ChopOrStreaks.Streaks, 0, 0, 0, 0, 0, Patterns.None, false, false, 0, BetConclusion.Skip };
            var game103 = new object[ ] { 10, RoadType.BigEye.ToString(),       (int) RoadLength.None,  MajorColor.None,   0, ChopOrStreaks.None, 0, 0, 0, 0, 0, Patterns.None, false, false, 0, BetConclusion.Skip };
            var game104 = new object[ ] { 10, RoadType.SmallRoad.ToString(),    (int) RoadLength.None,  MajorColor.None,   0, ChopOrStreaks.None, 0, 0, 0, 0, 0, Patterns.None, false, false, 0, BetConclusion.Skip };
            var game105 = new object[ ] { 10, RoadType.CockRoachRoad.ToString(), (int) RoadLength.None,  MajorColor.None,   0, ChopOrStreaks.None, 0, 0, 0, 0, 0, Patterns.None, false, false, 0, BetConclusion.Skip };

            tbl.Rows.Add( game11 );
            tbl.Rows.Add( game12 );
            tbl.Rows.Add( game13 );
            tbl.Rows.Add( game14 );
            tbl.Rows.Add( game15 );

            tbl.Rows.Add( game21 );
            tbl.Rows.Add( game22 );
            tbl.Rows.Add( game23 );
            tbl.Rows.Add( game24 );
            tbl.Rows.Add( game25 );

            tbl.Rows.Add( game31 );
            tbl.Rows.Add( game32 );
            tbl.Rows.Add( game33 );
            tbl.Rows.Add( game34 );
            tbl.Rows.Add( game35 );

            tbl.Rows.Add( game41 );
            tbl.Rows.Add( game42 );
            tbl.Rows.Add( game43 );
            tbl.Rows.Add( game44 );
            tbl.Rows.Add( game45 );

            tbl.Rows.Add( game51 );
            tbl.Rows.Add( game52 );
            tbl.Rows.Add( game53 );
            tbl.Rows.Add( game54 );
            tbl.Rows.Add( game55 );

            tbl.Rows.Add( game61 );
            tbl.Rows.Add( game62 );
            tbl.Rows.Add( game63 );
            tbl.Rows.Add( game64 );
            tbl.Rows.Add( game65 );

            tbl.Rows.Add( game71 );
            tbl.Rows.Add( game72 );
            tbl.Rows.Add( game73 );
            tbl.Rows.Add( game74 );
            tbl.Rows.Add( game75 );

            tbl.Rows.Add( game81 );
            tbl.Rows.Add( game82 );
            tbl.Rows.Add( game83 );
            tbl.Rows.Add( game84 );
            tbl.Rows.Add( game85 );

            tbl.Rows.Add( game91 );
            tbl.Rows.Add( game92 );
            tbl.Rows.Add( game93 );
            tbl.Rows.Add( game94 );
            tbl.Rows.Add( game95 );

            tbl.Rows.Add( game101 );
            tbl.Rows.Add( game102 );
            tbl.Rows.Add( game103 );
            tbl.Rows.Add( game104 );
            tbl.Rows.Add( game105 );

            return tbl;
        }
    }
}
