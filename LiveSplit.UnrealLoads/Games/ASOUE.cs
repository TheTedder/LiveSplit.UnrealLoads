using System;
using System.Collections.Generic;
using LiveSplit.ComponentUtil;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace LiveSplit.UnrealLoads.Games
{
    class ASeriesOfUnfortunateEvents : GameSupport
    {
        public override HashSet<string> GameNames => new HashSet<string>
        {
            "A Series of Unfortunate Events",
            "Lemony Snicket's A Series of Unfortunate Events (PC)",
            "Lemony Snicket's A Series of Unfortunate Events"
        };

        public override HashSet<string> ProcessNames => new HashSet<string>
        {
            "game"
        };
    }
}