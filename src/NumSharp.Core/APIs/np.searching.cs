﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NumSharp.Core
{
    public static partial class np
    {
        public static int argmax(NDArray nd)
            => nd.argmax();
    }
}
