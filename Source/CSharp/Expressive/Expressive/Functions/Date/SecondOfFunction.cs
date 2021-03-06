﻿using Expressive.Expressions;
using System;

namespace Expressive.Functions.Date
{
    internal sealed class SecondOfFunction : FunctionBase
    {
        #region FunctionBase Members

        public override string Name { get { return "SecondOf"; } }

        public override object Evaluate(IExpression[] parameters)
        {
            this.ValidateParameterCount(parameters, 1, 1);

            var dateObject = parameters[0].Evaluate(Variables);

            if (dateObject == null) return null;

            DateTime date = Convert.ToDateTime(dateObject);

            return date.Second;
        }

        #endregion
    }
}
