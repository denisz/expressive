﻿using Expressive.Expressions;
using System;

namespace Expressive.Functions.Date
{
    internal sealed class MillisecondsBetweenFunction : FunctionBase
    {
        #region FunctionBase Members

        public override string Name { get { return "MillisecondsBetween"; } }

        public override object Evaluate(IExpression[] parameters)
        {
            this.ValidateParameterCount(parameters, 2, 2);

            var startObject = parameters[0].Evaluate(Variables);
            var endObject = parameters[1].Evaluate(Variables);

            if (startObject == null || endObject == null) return null;

            DateTime start = Convert.ToDateTime(startObject);
            DateTime end = Convert.ToDateTime(endObject);

            return (end - start).TotalMilliseconds;
        }

        #endregion
    }
}
