﻿using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAccess.Contexts;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext>options) : base(options)
    {

    }
    public DbSet<SlideItem> SlideItems { get; set; } = null!;
    public DbSet<ShippingItem2> ShippingItems2 { get; set; } = null!;


}
