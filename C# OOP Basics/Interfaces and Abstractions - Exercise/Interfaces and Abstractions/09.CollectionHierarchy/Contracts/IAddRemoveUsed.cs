﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy.Contracts
{
    public interface IAddRemoveUsed : IAddRemove
    {
        void Used();
    }
}