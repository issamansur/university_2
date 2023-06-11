using Lab6.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Lab6
{
    class Program
    {

        static void Main(string[] args)
        {
            /*
            Вариант №3:
            - работа со сведениями об интернет-магазинах (добавление, удаление, изменение адреса и информации о доставке)
            - работа с товарами (добавление, удаление, изменение сведений о товаре)
            */
            using (EshopsContext context = new EshopsContext())
            {
                context.AddItem("bow", 1, 100);
                context.AddShop("OAO", null, null);
            }

        }
    }
}