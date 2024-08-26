using Entities;


namespace Data.Repositories
{
    public class AssigmentRepository : Repository<Assigment>, IAssigmentRepository
    {
        public AssigmentRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
