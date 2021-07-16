using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLiberary
{
    class EnglishPaper
    {
        public string Title { get; set; }
        public int MinimumWorkHour { get; set; }

        public string PaperText { get; set; }
        public int WordCount
        {
            get {return PaperText.WordCount(); }
        }
    }
}
