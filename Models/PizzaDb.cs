using Microsoft.EntityFrameworkCore;

namespace PizzaStore.Models;

public class PizzaDb(DbContextOptions<PizzaDb> options) : DbContext(options)
{
    public DbSet<Pizza> Pizzas { get; set; } = null!;
}

