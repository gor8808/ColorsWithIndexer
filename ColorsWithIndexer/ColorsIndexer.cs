using System;

namespace ColorsWithIndexer
{
    class ColorsIndexer
    {
        public string this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: return "#7FFFD4";
                    case 1: return "#191970";
                    case 2: return "#0000CD";
                    case 3: return "#FF00FF";
                    case 4: return "#9932CC";
                    case 5: return "#008000";
                    case 6: return "#0000CD";
                    case 7: return "#0000FF";
                    case 8: return "#FF00FF";
                    case 9: return "#008000";
                    case 10: return "#00FF00";
                    case 11: return "#EE82EE";
                    case 12: return "#00FA9A";
                    case 13: return "#0000FF";
                    case 14: return "#3B7A57";
                    case 15: return "#FFBF00";
                    case 16: return "#A4C639";
                    case 17: return "#CD9575";
                    case 18: return "#665D1E";
                    case 19: return "#915C83";
                    case 20: return "#841B2D";
                    case 21: return "#8DB600";
                    case 22: return "#4B5320";
                    case 23: return "#007FFF";
                    case 24: return "#89CFF0";
                    case 25: return "#848482";
                    case 26: return "#CAE00D";
                    case 27: return "#3D0C02";
                    case 28: return "#BF4F51";
                    case 29: return "#000000";
                    default:
                        throw new ArgumentOutOfRangeException("index");

                }
            }
        }
    }
}
