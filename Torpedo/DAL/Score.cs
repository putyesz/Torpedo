using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Torpedo.DAL
{
    public class Score : DbContext
    {
        public Score() : base("Score")
        {
        }

        public DbSet<Score>

    }
}