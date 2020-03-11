
using System.Collections.Generic;
using ProjectRpl.Models;

namespace ProjectRpl.DAL
{
    public interface ILogin
    {
        IEnumerable<Login> GetAll();
        Login GetById(string username);
    }
    
}