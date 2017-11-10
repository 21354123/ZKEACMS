/* http://www.zkea.net/ Copyright 2016 ZKEASOFT http://www.zkea.net/licenses */
using Easy.RepositoryPattern;
using System;
using System.Collections.Generic;
using ZKEACMS.Product.Models;
using Easy;
using Microsoft.EntityFrameworkCore;

namespace ZKEACMS.Product.Service
{
    public class ProductCategoryTagService : ServiceBase<ProductCategoryTag>, IProductCategoryTagService
    {
        public ProductCategoryTagService(IApplicationContext applicationContext, ProductDbContext dbContext) : base(applicationContext, dbContext)
        {
        }

        public override DbSet<ProductCategoryTag> CurrentDbSet
        {
            get
            {
                return (DbContext as ProductDbContext).ProductCategoryTag;
            }
        }
    }
}
