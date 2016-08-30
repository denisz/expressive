﻿using Expressive.Expressions;
using System;

namespace Expressive.Functions.Date
{
    internal sealed class MinuteOfFunction : FunctionBase
    {
        #region FunctionBase Members

        public override string Name { get { return "MinuteOf"; } }

        public override object Evaluate(IExpression[] parameters)
        {
            this.ValidateParameterCount(parameters, 1, 1);

            DateTime date = Convert.ToDateTime(parameters[0].Evaluate(Variables));

            return date.Minute;
        }

        #endregion
    }
}
