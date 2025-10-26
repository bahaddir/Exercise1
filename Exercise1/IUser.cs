using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public interface IUser
    {
        int Id { get;}
        string UserName { get; }
        string Name { get;}
        string Surname { get;}
        string Email { get;}
        string Password { get;}
        
        DateTime CreatedAt { get; }
    }
}
