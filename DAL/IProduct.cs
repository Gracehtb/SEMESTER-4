

using System.Collections.Generic;
using ProjectRpl.Models;

namespace ProjectRpl.DAL{
    public interface IProduct
    {
        IEnumerable<Product> GetAll();
        
        Product GetById(string Id_Product);

        void Insert(Product pro);
    void Update(Product pro);
    void Delete(string Id_Product);

        IEnumerable<Product> GetAllByNama(string nama);
    }

}