using System;

namespace Beaspa.Logic_Files
{
    [Serializable]
    public class Visit
    {
        public string DateTime { get; set; }
        public string Motive { get; set; }
        public string Treatment { get; set; }
        public string NumberOfSessions { get; set; }
        public string AmountToPay { get; set; }
    }
}
