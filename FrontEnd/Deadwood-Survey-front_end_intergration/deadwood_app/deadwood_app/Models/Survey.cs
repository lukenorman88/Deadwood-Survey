using System;
using System.Collections.Generic;
using System.Text;

namespace deadwood_app.Models
{
    public class Survey
    {
        public Survey()
        {

        }

        
        public bool enviroGroup { get; set; }
        public bool performedSurveyBefore { get; set; }
        public string woodlandName { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string gridRef { get; set; }
        public double woodlandSize { get; set; }
        public string deadwoodStandingOrLying { get; set; }
        public double deadwoodDiameter { get; set; }
        public double deadwoodLength { get; set; }
        public string deadwoodSpecies { get; set; }
        public string holesInDeadwood { get; set; }
        public string floraOnDeadwood { get; set; }
        public string faunaOnDeadwood { get; set; }
        public double pencilDepth { get; set; }
        public string deadwoodSoftness { get; set; }
        public string faunaInDeadwood { get; set; }
        public string deadwoodColour { get; set; }
        public int deadwoodDecay { get; set; }
        
    }
}
