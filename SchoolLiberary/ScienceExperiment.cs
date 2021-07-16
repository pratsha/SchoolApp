using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLiberary
{
    class ScienceExperiment: IScored
    {
        public string Hypothesis { get; set; }
        public string Material { get; set; }
        public string Method { get; set; }
        public string Conclusion { get; set; }
        public float Score { get ; set; }
        public float MaximumScore { get; set; }
    }
}
