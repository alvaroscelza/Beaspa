using System;
using System.Collections.Generic;
using System.Drawing;

namespace Beaspa.Logic_Files
{
    [Serializable]
    public class Person
    {
        public Person()
        {
            AestheticCenters = new List<AestheticCenter>();
            Visits = new List<Visit>();
        }

        #region General Data
        public string NameAndSurname { get; set; }
        public string BirthDate { get; set; }
        public string CI { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string MedicSociety { get; set; }
        public string MobileEmergency { get; set; }
        public string Occupation { get; set; }
        public List<AestheticCenter> AestheticCenters { get; set; }
        public Image Image { get; set; }
        public string Observations { get; set; }
        public List<Visit> Visits { get; set; }
        #endregion
        #region Sicknesses
        public bool Diabetes { get; set; }
        public bool HeartProblems { get; set; }
        public bool Hypertension { get; set; }
        public bool MetallicProsthesis { get; set; }
        public bool Pacemaker { get; set; }
        public bool Allergies { get; set; }
        public string AllergiesDescription { get; set; }
        public bool Pregnancies { get; set; }
        public bool Surgeries { get; set; }
        #endregion
    }
}
