using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AntlrDiscountPlatform.Grammar.Expressions;

public class RuleExpression
{
    public RuleExpression(List<ApplyExpression> applyExpressions)
    {
        ApplyExpressions = applyExpressions;
    }

    public RuleExpression(IBasketExpression basketExpression, List<ApplyExpression> applyExpressions)
    {
        BasketExpression = basketExpression;
        ApplyExpressions = applyExpressions;
    }

    public IBasketExpression BasketExpression { get; }
    public List<ApplyExpression> ApplyExpressions { get; }
}