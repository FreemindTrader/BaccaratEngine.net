using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaccaratEngine
{    
    /// <summary>
    /// Bit 13 - 17  = Five bits for monster Info
    /// Bit 10 - 12  = Three bits for Tie Info
    /// Bit 06 - 09  = Four bits for Pair info
    /// Bit 03 - 05  = Three bits for Natural Info
    /// Bit 02 - 01  = Two bits sued to represent the game result
    public struct GBits
    {
        private uint _gBits;

        public GBits( GResult gameResult, GNatural isNatural, GPair hasPair, GTie isTie, GMonster monster )
        {
            _gBits = 0;
            _gBits = _gBits | (uint)gameResult;
            _gBits = BitHelper.SetBits( _gBits, (uint)isNatural, 1, GameBit.POS_GNatural, GameBit.POS_GNatural_length );
            _gBits = BitHelper.SetBits( _gBits, (uint)hasPair, 1, GameBit.POS_GPair, GameBit.POS_GPair_length );
            _gBits = BitHelper.SetBits( _gBits, (uint)isTie, 1, GameBit.POS_GTie, GameBit.POS_GTie_length );
            _gBits = BitHelper.SetBits( _gBits, (uint)monster, 1, GameBit.POS_GMonster, GameBit.POS_GMonster_length );
        }

        public GResult ResultInfo
        {
            get
            {
                var result = BitHelper.GetBits( _gBits, GameBit.POS_GResult, GameBit.POS_GResult_length, false );

                return (GResult)result;
            }

            set
            {
                uint gResult = (uint)value;

                _gBits = BitHelper.SetBits( _gBits, gResult, 1, GameBit.POS_GResult, GameBit.POS_GResult_length );
            }
        }

        public GNatural NaturalInfo
        {
            get
            {
                var natural = BitHelper.GetBits( _gBits, GameBit.POS_GNatural, GameBit.POS_GNatural_length, false );

                return (GNatural)natural;
            }

            set
            {
                uint natural = (uint)value;

                _gBits = BitHelper.SetBits( _gBits, natural, 1, GameBit.POS_GNatural, GameBit.POS_GNatural_length );
            }
        }

        public GPair PairInfo
        {
            get
            {
                var natural = BitHelper.GetBits( _gBits, GameBit.POS_GPair, GameBit.POS_GPair_length, false );

                return (GPair)natural;
            }

            set
            {
                uint natural = (uint)value;

                _gBits = BitHelper.SetBits( _gBits, natural, 1, GameBit.POS_GPair, GameBit.POS_GPair_length );
            }
        }

        public GTie TieInfo
        {
            get
            {
                var natural = BitHelper.GetBits( _gBits, GameBit.POS_GTie, GameBit.POS_GTie_length, false );

                return (GTie)natural;
            }

            set
            {
                uint natural = (uint)value;

                _gBits = BitHelper.SetBits( _gBits, natural, 1, GameBit.POS_GTie, GameBit.POS_GTie_length );
            }
        }

        public GMonster MonsterInfo
        {
            get
            {
                var natural = BitHelper.GetBits( _gBits, GameBit.POS_GMonster, GameBit.POS_GMonster_length, false );

                return (GMonster)natural;
            }

            set
            {
                uint natural = (uint)value;

                _gBits = BitHelper.SetBits( _gBits, natural, 1, GameBit.POS_GMonster, GameBit.POS_GMonster_length );
            }
        }
    }

}
