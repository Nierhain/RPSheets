namespace RPSheets.Data
{
    public class Repository : IDbRepository
    {
        private readonly RPSheetsContext _context;

        public Repository(RPSheetsContext context)
        {
            _context = context;
        }

        public Task<T> Create<T>(T item) where T : class
        {
            throw new NotImplementedException();
        }

        public Task<T> Delete<T>(Guid id) where T : class
        {
            throw new NotImplementedException();
        }

        public Task<T> Read<T>(Guid id) where T : class
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> ReadList<T>() where T : class
        {
            throw new NotImplementedException();
        }

        public Task<T> Update<T>(T item) where T : class
        {
            throw new NotImplementedException();
        }
    }
}
