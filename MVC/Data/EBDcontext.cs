using Microsoft.EntityFrameworkCore;
using MVC.Models;

public class EDBcontext : DbContext
{
    public EDBcontext()
    {
    }

    public EDBcontext(DbContextOptions<EDBcontext> options) : base(options)
    {
    }

    public DbSet<EmployeeModel> Employees { get; set; }
}
