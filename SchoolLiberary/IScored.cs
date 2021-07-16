using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLiberary
{
    public interface IScored
    {
        float Score { get; set; }
        float MaximumScore { get; set; }
    }
}
