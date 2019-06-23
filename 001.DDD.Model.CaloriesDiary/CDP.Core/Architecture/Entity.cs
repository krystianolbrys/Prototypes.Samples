﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CDP.Core.Architecture
{
    public abstract class Entity
    {
        protected Entity(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; }
    }
}
