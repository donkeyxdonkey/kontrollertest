using System;
using System.Collections.Generic;
using System.Text;

namespace kontrollertest
{
    public class PlayerControls
    {
        public string North { get; set; }
        public string East { get; set; }
        public string South { get; set; }
        public string West { get; set; }

        public PlayerControls()
        {
            North = "N";
            East = "E";
            South = "S";
            West = "W";
        }

        public void AlternativeControls()
        {
            North = "W";
            East = "D";
            West = "A";
        }

    }


}
