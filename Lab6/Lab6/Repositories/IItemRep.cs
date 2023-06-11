using Lab6.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.Repositories
{
    public interface IItemRep
    {
        void AddItem(string title, int amount, decimal price);
        void AddItem(Item item);
        bool DeleteItem(int id);
        bool UpdateItemAmount(int id, int addAmount);
        bool UpdateItemPrice(int id, decimal newPrice);
    }
}
