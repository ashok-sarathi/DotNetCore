﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ScaffoldDbLib.Models
{
    public partial class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
