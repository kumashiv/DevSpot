﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevSpot.Data;
using Microsoft.EntityFrameworkCore;

namespace DevSpot.Tests
{
    internal class JobPostingRepositoryTests
    {
        private readonly DbContextOptions<ApplicationDbContext> _options;

        public JobPostingRepositoryTests()
        {
            _options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("JobPostingDb")
                .Options;
        }

        //private ApplicationDbContext CreateDbContext() => new ApplicationDbContext(_options);
        // or write this as
        private ApplicationDbContext CreateDbContext()
        {
            return new ApplicationDbContext(_options);
        }


    }
}
