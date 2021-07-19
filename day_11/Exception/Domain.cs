using System;
using System.Text;

namespace ExceptionHandling
{
    class Domain : Exception
    {
        public string Text { get; set; }
        public string SubText { get; set; }

        public Domain(string Text, string subtext) : base(String.Format($"{Text}:{subtext}")) { }
    }
}
