﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi2.Models
{
    public class User
    {
        public int UserId { get; set; }

        public string UserName { get; set; }

        public string Address { get; set; }

        public string Contact { get; set; }

    }
}