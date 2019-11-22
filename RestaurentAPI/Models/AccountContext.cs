using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAPI.Models
{
    public class AccountContext : IdentityDbContext
    {
        public AccountContext(DbContextOptions<AccountContext> options) : base(options)
        {
        }
    }
}
