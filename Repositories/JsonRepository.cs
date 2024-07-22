using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList.Repositories
{
    class JsonModel
    {
        public int RunID { get; set; }
        public List<TodoModel> Todos { get; set; }

        public JsonModel(int runID, List<TodoModel> todos)
        {
            RunID = runID;
            Todos = todos;
        }
    }

    internal class JsonRepository : IRepository<TodoModel>
    {
        string FilePath;

        public JsonRepository(string file)
        {
            if (!File.Exists(file))
            {
                string initString = JsonConvert.SerializeObject(
                    new JsonModel(0, []),
                    Formatting.Indented);
                File.WriteAllText(file, initString);
            }
            FilePath = file;
        }


        public TodoModel Add(TodoModel todo)
        {
            JsonModel json = GetJsonModel();
            todo.Id = json.RunID++;
            json.Todos.Add(todo);
            string jsonString = JsonConvert.SerializeObject(json, Formatting.Indented);
            File.WriteAllText(FilePath, jsonString);
            return todo;
        }

        public void DeleteById(int id)
        {
            JsonModel json = GetJsonModel();
            TodoModel todo1 = json.Todos.FirstOrDefault(e => e.Id == id);
            json.Todos.Remove(todo1);
            string jsonString = JsonConvert.SerializeObject(json, Formatting.Indented);
            File.WriteAllText(FilePath, jsonString);
        }

        public List<TodoModel> GetAll()
        {
            JsonModel json = GetJsonModel();
            return json.Todos ?? [];
        }

        public List<TodoModel> GetAll(Func<TodoModel, bool> predicate)
        {
            return GetAll().Where(predicate).ToList();

        }

        public TodoModel GetById(int id)
        {
            JsonModel json = GetJsonModel();
            TodoModel todo = json.Todos.FirstOrDefault(e => e.Id == id);
            return todo;
        }

        public TodoModel Update(TodoModel todo)
        {
            JsonModel json = GetJsonModel();
            TodoModel todo1 = json.Todos.FirstOrDefault(e => e.Id == todo.Id);
            json.Todos.Remove(todo1);
            todo1.Title = todo.Title;
            todo1.Done = todo.Done;
            todo1.Date = todo.Date;
            json.Todos.Add(todo1);
            string jsonString = JsonConvert.SerializeObject(json, Formatting.Indented);
            File.WriteAllText(FilePath, jsonString);
            return todo1;

        }

        private JsonModel GetJsonModel()
        {
            string jsonString = File.ReadAllText(FilePath);
            return JsonConvert.DeserializeObject<JsonModel>(jsonString);
        }
    }
}
