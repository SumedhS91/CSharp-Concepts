using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace player
{
    public class Player
    {
        private int _TShirtNO;

        public int TShirtNo
        {
            get { return _TShirtNO; }
            set { _TShirtNO = value; }
        }

        public string PlayerName { get; set; }
        public string TeamName { get; set; }
        public string Country { get; set; }
        public int Remuneration { get; set; }

        public int ren()
        {
            TShirtNo=11;
            PlayerName = "Bale";
            TeamName = "Real Madrid";
            Country="Spain";
            Remuneration = 20000;
            return Remuneration;
        }
    }
}
