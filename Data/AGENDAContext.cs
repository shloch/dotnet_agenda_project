#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AGENDA.Models;

    public class AGENDAContext : DbContext
    {
        public AGENDAContext (DbContextOptions<AGENDAContext> options)
            : base(options)
        {
        }

        public DbSet<AGENDA.Models.Agenda> Agenda { get; set; }
    }
