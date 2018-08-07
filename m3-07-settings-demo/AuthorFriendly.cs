﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pluralsight.json.net.m3.d7
{
    class AuthorFriendly
    {
        public string name { get; set; }

        public string[] courses { get; set; }

        public DateTime since { get; set; }

        public bool happy { get; set; }

        public object issues { get; set; }

        public List<AuthorFriendly> FellowAuthors { get; set; }
    }
}
