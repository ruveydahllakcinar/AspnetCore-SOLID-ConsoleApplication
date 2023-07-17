using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.App.DIP_BadCode
{
    public class ProductService //High level module
    {
        private readonly ProductRepositoryFromSqlServer _repository;

        public ProductService(ProductRepositoryFromSqlServer repository)
        {
            _repository = repository;
        }

        public List<string> GetAll()
        {
            return _repository.GetAll();
        }
    }


    public class ProductRepositoryFromSqlServer //Low level module
    {
        public List<string> GetAll() 
        { 
            return new List<string>() { "Pencil 1" ,"Pencil 2"};
        }
    }
}

// Bu bir kötü kod örneği. Çünkü high kevek module, low level modulün kim olduğunu biliyor. 