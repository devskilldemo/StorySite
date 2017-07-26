﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorySite.Data
{
    public class Story
    {
        public Guid ID { get; set; }
        public string Title { get; set; }
        public string StoryBody { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedOn { get; set; }
        public double Rating { get; set; }
        public virtual List<Comment> Comments { get; set; }
    }
}
