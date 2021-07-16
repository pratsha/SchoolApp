using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLiberary
{
    public static class ExtensionMethods
    {
        public static int WordCount(this string str)
        {
            var wordCount= str.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
            return wordCount;
        }
    }
}
