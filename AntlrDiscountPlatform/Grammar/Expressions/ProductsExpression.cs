using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AntlrDiscountPlatform.Grammar.Expressions;

public class ProductsExpression
{
    public ProductsExpression(List<string> products)
    {
        Products = products;
    }

    public List<string> Products { get; }

    public Predicate<Product> Filter
    {
        get { return product => Products.Contains(product.Name); }
    }
}
