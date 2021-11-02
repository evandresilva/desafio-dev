using CNABImporter.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CNABImporter.Service.Test.Config
{
    public static class ConfigContext
    {
        public static MyContext GetInMemory()
        {
            var options = new DbContextOptionsBuilder<MyContext>()
                .UseInMemoryDatabase("MemoryDB")
                .Options;
            var context = new MyContext(options);
            context.Database.EnsureCreated();
            return context;
        }
    }
}
