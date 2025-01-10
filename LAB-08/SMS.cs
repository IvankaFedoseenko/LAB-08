using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_08
{
    public class SMS : IMessage
    {
        public string Content { get; set; }

        public SMS(string content)
        {
            Content = content;
        }
    }
}
