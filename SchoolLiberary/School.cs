using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLiberary
{
    public class School
    {

       public string Name { get ; set ; }
       public string Address { get; set ; }
       public string City { get ; set ; }
       public string Zip { get ; set ; }
       public string PhoneNumber { get ; set ; }

       public string State { get; set; }

       private string _twitterAddress;
       public string TwitterAddress
        {
            get { return _twitterAddress; }
            set
            {
                if (value.StartsWith("@"))
                { _twitterAddress = value; }
                else
                {
                    throw new Exception("The twiiter address is wrong.");
                }
            }
        }

        public School()
        {
            Name = "Untitled School";
            PhoneNumber = "555-1234";

        }
        public School(string SchoolName, string SchoolPhoneNumber)
        {
            Name = SchoolName;
            PhoneNumber = SchoolPhoneNumber;
        }

        //public float AverageThreeScores(float a, float b, float c)
        //{
        //    var result = (a + b + c) / 3;
        //    return result;
        //}

        public static float AverageThreeScores(float a, float b, float c) => (a + b + c) / 3;
        public static int AverageThreeScores(int a, int b, int c)
        {
            return (a + b + c) / 3;
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(this.Name);
            sb.AppendLine(this.Address);
            sb.AppendLine(this.City);
            sb.Append(", " );
            sb.Append(this.State);
            sb.Append("  ");
            return sb.ToString();
        }
    }
}
