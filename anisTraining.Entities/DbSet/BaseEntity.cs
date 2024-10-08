﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anisTraining.Entities.DbSet
{
    public class BaseEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public DateTime AddedDate { get; set; } = DateTime.Now;

        public DateTime UpdatedDate { get; set; } = DateTime.Now;

        public int Status { get; set; }
    }
}
