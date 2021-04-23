using System;
using System.Collections.Generic;
using System.Text;

namespace this_one
{
    class sticker
    {
        public string color;
        public sticker next;
        public String id;
        public sticker(String c, String s)
        {
            color = c;
            next = null;
            id = s;
        }

        
    }
}
