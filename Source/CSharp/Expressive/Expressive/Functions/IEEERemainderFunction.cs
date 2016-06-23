﻿using Expressive.Expressions;
using System;

namespace Expressive.Functions
{
    internal class IEEERemainderFunction : FunctionBase
    {
        #region FunctionBase Members

        public override string Name { get { return "IEEERemainder"; } }

        public override object Evaluate(IExpression[] parameters)
        {
            this.ValidateParameterCount(parameters, 2, 2);

            return Math.IEEERemainder(Convert.ToDouble(parameters[0].Evaluate(Variables)), Convert.ToDouble(parameters[1].Evaluate(Variables)));
        }

        #endregion
    }
}