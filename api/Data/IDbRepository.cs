namespace RPSheets.Data
{
    public interface IDbRepository
    {
        public Task<T> Read<T>(Guid id) where T : class;
        public Task<List<T>> ReadList<T>() where T : class;
        public Task<T> Create<T>(T item) where T : class;
        public Task<T> Update<T>(T item) where T : class;

        public Task<T> Delete<T>(Guid id) where T : class;
    }
}
