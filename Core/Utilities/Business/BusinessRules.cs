﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        public static IResult Run(params IAsyncResult[] logics)
        {
            foreach (var logic in logics)
            {
                if (!logic.IsCompleted)
                {
                    return null;
                }
            }

            return null;
        }
    }
}
