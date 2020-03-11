


using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;
using Microsoft.Extensions.Configuration;
using ProjectRpl.Models;

namespace ProjectRpl.DAL {
    public class ProductDAL : IProduct
    {

        private IConfiguration _config;
        
        public ProductDAL (IConfiguration config)
        {
            _config = config;
        }

        private string getConnStr()
        {
            return _config.GetConnectionString("DefaultConnection");
        }
        public void Delete(string Id_Product)
        {
            using(SqlConnection conn = new SqlConnection(getConnStr())){
                var strSql =@"delete from Product where Id_Product=@Id_Product";
                try
                {
                    var param = new {Id_Product=Id_Product};
                    conn.Execute(strSql,param);
                }catch(SqlException sqlEx){
                    throw new Exception($"Error: {sqlEx.Message}");
                }
            }
        }

        public IEnumerable<Product> GetAll()
        {
            using(SqlConnection conn = new SqlConnection(getConnStr()))
            {
            var strSql = @"select * from Product order by Id_Product";
            return conn.Query<Product>(strSql);
            }
        }

        public Product GetById(string id)
        {
            using(SqlConnection conn = new SqlConnection(getConnStr()))
            {
            var strSql = @"select * from Product where Id_Product=@Id_Product";
            var param = new {Id_Product=id};
            var data = conn.QuerySingleOrDefault<Product>(strSql,param);
            if(data!=null)
            return data;
            else
            throw new Exception("Data tidak ditemukan !");
            }   
        }

        public IEnumerable<Product> GetAllByNama(string nama_product)
        {
            using(SqlConnection conn = new SqlConnection(getConnStr())){
                string strSql = @"select * from Product where Nama_Product like @Nama_Product";
                var param = new {nama_product="%"+nama_product+"%"};
                return conn.Query<Product>(strSql, param);
            }
        }

        public void Insert(Product pro)
        {
            using(SqlConnection conn = new SqlConnection(getConnStr()))
            {
                var strSql = @"insert into Product(Id_Product,Nama_Product,deskripsi,stok,harga,image,Id_Kategori) values (@Id_Product,@Nama_Product,@deskripsi,@stok,@harga,@image,@Id_Kategori)";

                try{
                    var param = new {Id_Product=pro.Id_Product,Nama_Product=pro.Nama_Product,deskripsi=pro.deskripsi,stok=pro.stok,harga=pro.harga,image=pro.image,Id_Kategori=pro.Id_Kategori};
                    conn.Execute(strSql, param);


                }
                catch (SqlException sqlEx)
                {
                    throw new Exception($"Error : {sqlEx.Message}");
                }
            }
        }

        public void Update(Product pro)
        {
            using(SqlConnection conn = new SqlConnection(getConnStr()))
            {
                var strSql = @"update Product set Nama_Product=@Nama_Product,deskripsi=@deskripsi,stok=@stok,harga=@harga,image=@image,Id_Kategori=@Id_Kategori where Id_Product=@Id_Product";
                try{
                    var param = new {Nama_Product=pro.Nama_Product,deskripsi=pro.deskripsi,stok=pro.stok,harga=pro.harga,image=pro.image,Id_Kategori=pro.Id_Kategori,Id_Product=pro.Id_Product};
                    conn.Execute(strSql,param);

                }catch(SqlException sqlEx){
                    throw new Exception(sqlEx.Message);
                }
            }
        }
    }
}