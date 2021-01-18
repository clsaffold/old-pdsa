using System;
using PdsaTracker.Models
using Microsoft.EntityFrameworkCore;

namespace PdsaTracker.Data

{
	public class PdsaDbContext: DbContext
	{
		public DbSet<Pdsa> Pdsas { get; set; }

		public PdsaDbContext(DbContextOptions<PdsaDbContext> options) : base(option)
		//static private Dictionary<int, Pdsa> Entries = new Dictionary<int, pdsa>();
		{
		}
	}
}
