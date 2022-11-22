using System;
using Microsoft.EntityFrameworkCore;

namespace LegitBankApp.Model
{
    public class ApplicationContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("Server=localhost;port=3306;Database=bankapp;Uid=root;Pwd=Adebayo58641999");

        }

    }
    
}