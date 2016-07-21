﻿using Expressive.Expressions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Expressive.Operators.Additive
{
    internal class PlusOperator : OperatorBase
    {
        #region IOperator Members

        public override string[] Tags { get { return new[] { "+" }; } }

        public override IExpression BuildExpression(string previousToken, IExpression[] expressions)
        {
            if (IsUnary(previousToken))
            {
                return new UnaryExpression(UnaryExpressionType.Plus, expressions[0] ?? expressions[1]);
            }

            return new BinaryExpression(BinaryExpressionType.Add, expressions[0], expressions[1]);
        }

        public override bool CanGetCaptiveTokens(string previousToken, string token, Queue<string> remainingTokens)
        {
            var remainingTokensCopy = new Queue<string>(remainingTokens.ToArray());

            return this.GetCaptiveTokens(previousToken, token, remainingTokensCopy).Any();
        }

        public override string[] GetInnerCaptiveTokens(string[] allCaptiveTokens)
        {
            return allCaptiveTokens.Skip(1).ToArray();
        }

        public override OperatorPrecedence GetPrecedence(string previousToken)
        {
            if (IsUnary(previousToken))
            {
                return OperatorPrecedence.UnaryPlus;
            }
            return OperatorPrecedence.Add;
        }

        #endregion

        private bool IsUnary(string previousToken)
        {
            return string.IsNullOrEmpty(previousToken) ||
                string.Equals(previousToken, "(", StringComparison.Ordinal) ||
                previousToken.IsArithmeticOperator();
        }
    }
}
