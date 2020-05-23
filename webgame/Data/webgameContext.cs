using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using webgame.Models;

namespace webgame.Data
{
    public class webgameContext : DbContext
    {
        public webgameContext (DbContextOptions<webgameContext> options)
            : base(options)
        {
        }

        public DbSet<webgame.Models.HighScore> HighScore { get; set; }
    }
}
