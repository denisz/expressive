﻿using Expressive.Expressions;

namespace Expressive.Operators.Relational
{
    internal class EqualOperator : OperatorBase
    {
        #region OperatorBase Members

        public override string[] Tags { get { return new[] { "=", "==" }; } }

        public override IExpression BuildExpression(Token previousToken, IExpression[] expressions)
        {
            return new BinaryExpression(BinaryExpressionType.Equal, expressions[0], expressions[1]);
        }

        public override OperatorPrecedence GetPrecedence(Token previousToken)
        {
            return OperatorPrecedence.Equal;
        }

        #endregion
    }
}
