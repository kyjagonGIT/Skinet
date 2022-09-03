using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Specifications
{
    public class ProductsWithTypesandBrandsSpecification : BaseSpecification<Product>
    {
        public ProductsWithTypesandBrandsSpecification()
        {
            // AddInclude(x => x.ProductType);
            // AddInclude(x => x.ProductBrand);
            LoadSubClassData();
        }

        public ProductsWithTypesandBrandsSpecification(int id) : base(x => x.Id == id)
        {
            LoadSubClassData();
        }

        private void LoadSubClassData()
        { 
            AddInclude(x => x.ProductType);
            AddInclude(x => x.ProductBrand);
        }
    }
}