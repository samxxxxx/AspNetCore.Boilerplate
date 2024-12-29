using AspNetCore.Boilerplate.Service.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCore.Boilerplate.EntityFrameworkCore.Data
{
    public class ApplicationDbContext : IdentityDbContext<AspNetCoreBoilerplateUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    }
}
