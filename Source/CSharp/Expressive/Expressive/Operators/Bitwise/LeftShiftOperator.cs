﻿using Expressive.Expressions;

namespace Expressive.Operators.Bitwise
{
    internal class LeftShiftOperator : OperatorBase
    {
        #region OperatorBase Members

        public override string[] Tags { get { return new[] { "<<" }; } }

        public override IExpression BuildExpression(Token previousToken, IExpression[] expressions)
        {
            return new BinaryExpression(BinaryExpressionType.LeftShift, expressions[0], expressions[1]);
        }

        public override OperatorPrecedence GetPrecedence(Token previousToken)
        {
            return OperatorPrecedence.LeftShift;
        }

        #endregion
    }
}
