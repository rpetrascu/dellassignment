﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dell.Models
{
    public class Customer
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Email { get; set; }
    }
}