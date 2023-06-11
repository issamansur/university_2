using Lab6.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.Repositories
{
    public interface IShopRep
    {
        void AddShop(string name, string email, string address);
        void AddShop(Shop shop);
        bool DeleteShop(int id);
        bool UpdateShopEmail(int id, string newEmail);
        bool UpdateShopAddress(int id, string newAddress);
    }
}
