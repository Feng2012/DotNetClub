﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetClub.Core.Entity
{
    public class UserCollect
    {
        public int UserID { get; set; }

        public int TopicID { get; set; }

        public DateTime CreateDate { get; set; }

        public virtual Topic Topic { get; set; }
    }
}
