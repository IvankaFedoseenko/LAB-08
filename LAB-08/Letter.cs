﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_08
{
    public class Letter : IMessage
    {
        public string Content { get; set; }

        public Letter(string content)
        {
            Content = content;
        }
    }
}
