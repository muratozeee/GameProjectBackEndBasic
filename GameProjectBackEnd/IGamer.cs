﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectBackEnd
{
     interface IGamer
    {
        public string NickName { get; set; }
        public string Password { get; set; }
        public string E_Mail { get; set; }



    }
}
