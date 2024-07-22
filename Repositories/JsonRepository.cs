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
                string initString = JsonConvert.SerializeObject(new JsonModel(0, []));
                File.WriteAllText(file, initString);
            }
            FilePath = file;
        }


        public TodoModel Add(TodoModel todo)
        {
            JsonModel json = GetJsonModel();
            todo.Id = json.RunID++;
            json.Todos.Add(todo);
            string jsonString = JsonConvert.SerializeObject(json);
            File.WriteAllText(FilePath, jsonString);
            return todo;
        }

        public void DeleteById(int id)
        {
            JsonModel json = GetJsonModel();
            TodoModel todo1 = json.Todos.FirstOrDefault(e => e.Id == id);
            json.Todos.Remove(todo1);
            string jsonString = JsonConvert.SerializeObject(json);
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
            int todoIndex = json.Todos.FindIndex(e => e.Id == todo.Id);
            json.Todos[todoIndex].Title = todo.Title;
            json.Todos[todoIndex].Done = todo.Done;
            json.Todos[todoIndex].Date = todo.Date;
            string jsonString = JsonConvert.SerializeObject(json);
            File.WriteAllText(FilePath, jsonString);
            return json.Todos[todoIndex];
            ;

        }

        private JsonModel GetJsonModel()
        {
            string jsonString = File.ReadAllText(FilePath);
            return JsonConvert.DeserializeObject<JsonModel>(jsonString);
        }
    }
}
