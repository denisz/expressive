﻿using Expressive.Expressions;

namespace Expressive.Operators.Logic
{
    internal class OrOperator : OperatorBase
    {
        #region OperatorBase Members

        public override string[] Tags { get { return new[] { "||", "or" }; } }

        public override IExpression BuildExpression(Token previousToken, IExpression[] expressions)
        {
            return new BinaryExpression(BinaryExpressionType.Or, expressions[0], expressions[1]);
        }

        public override OperatorPrecedence GetPrecedence(Token previousToken)
        {
            return OperatorPrecedence.Or;
        }

        #endregion
    }
}
