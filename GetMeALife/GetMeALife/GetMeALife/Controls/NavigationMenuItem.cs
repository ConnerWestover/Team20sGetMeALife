﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMeALife.Controls
{
    public class NavigationMenuItem
    {
        public NavigationMenuItem()
        {
            TargetType = typeof(NavigationDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}