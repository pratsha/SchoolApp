using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLiberary
{
    public class Students : Person
    {
        public enum GradeLevel { Freshman, Sophomore, Junior, Senior }
        public GradeLevel Grade {get;set;}

        public override float ComputeGradeAverage()
        {
            return 4.0f;
        }

        public override string SendMessage(string message)
        {
            var orginal= base.SendMessage(message);
            var sb = new StringBuilder(orginal);
            sb.AppendLine("This message is private and confidential.");
            return sb.ToString();
        }
    }
}
