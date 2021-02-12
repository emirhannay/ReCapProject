﻿using ReCapProject.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapProject.Entities.Concrete
{
    public class Color:IEntity
    {
        public string ColorId { get; set; }
        public string ColorName { get; set; }
    }
}
