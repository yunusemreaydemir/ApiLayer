using BusinessLayer.Abstarct;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Delete(Product t)
        {
           _productDal.Delete(t);
        }

        public Product GetByID(int id)
        {
            return _productDal.GetByID(id);
        }

        public List<Product> Getlist()
        {
            return _productDal.Getlist();
        }

        public void Insert(Product t)
        {
            _productDal.Insert(t);
        }

        public void Update(Product t)
        {
            _productDal.Update(t);
        }
    }
}
