﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo.Models
{
    public class ToDoClass
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public bool IsUrgent { get; set; }
        public bool IsDone { get; set; }
        public int Votes { get; set; }
    }
}
