using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLiberary
{
    public class Teachers: Person
    {
       
        public string Subject { get; set; }
        public override float ComputeGradeAverage()
        {
            return 0.0f;
        }
    }
}
