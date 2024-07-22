
namespace TodoList.Repositories
{
    internal class CSVRepository : IRepository<TodoModel>
    {
        string path;

        public CSVRepository(string path)
        {
            if(!File.Exists(path))
            {

            }
            this.path = path;
        }

        public TodoModel Add(TodoModel todo)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public List<TodoModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<TodoModel> GetAll(Func<TodoModel, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public TodoModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public TodoModel Update(TodoModel todo)
        {
            throw new NotImplementedException();
        }
    }
}
