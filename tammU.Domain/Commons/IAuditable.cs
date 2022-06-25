﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tammU.Domain.Enums;

namespace tammU.Domain.Commons
{
    public interface IAuditable
    {
        Guid Id { get; set; }
        DateTime CreatedAt { get; set; }
        DateTime? UpdatedAt { get; set; }
        Guid? UpdatedBy { get; set; }
        ItemState State { get; set; }
    }
}
