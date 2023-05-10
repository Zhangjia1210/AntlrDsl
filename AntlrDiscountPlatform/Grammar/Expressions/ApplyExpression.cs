using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
#nullable enable
namespace AntlrDiscountPlatform.Grammar.Expressions;

public class ApplyExpression
{
    public ApplyExpression(int percentage)
    {
        Percentage = percentage;
    }

    public ApplyExpression(int percentage, ProductsExpression productsExpression)
    {
        Percentage = percentage;
        ProductsExpression = productsExpression;
    }

    public int Percentage { get; }

    public ProductsExpression ProductsExpression { get; }
}