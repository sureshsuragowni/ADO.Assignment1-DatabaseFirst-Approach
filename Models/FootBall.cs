using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootBall2.Models
{
    public class FootBall
    {

        public int MatchID { get; set; }
        public string TeamName1 { get; set; }
        public string TeamName2 { get; set; }
        public string Status { get; set; }
        public string WinningTeam { get; set; }
        public Nullable<int> Points { get; set; }
    }
}