using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AntlrDiscountPlatform.Grammar.Expressions;

namespace AntlrDiscountPlatform.Grammar.Visitors;
public class ProductsVisitor : DiscountsParserBaseVisitor<ProductsExpression>
{
    public override ProductsExpression VisitProducts(DiscountsParser.ProductsContext context)
    {
        var products = context.product()
            .Select(x => x.GetText())
            .ToList();

        return new ProductsExpression(products);
    }
}