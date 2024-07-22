
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TodoList.Repositories
{
    internal class XMLRepository : IRepository<TodoModel>
    {

        string path;
        XDocument document;

        public XMLRepository(string path)
        {
            this.path = path;
            if (!File.Exists(path))
            {
                new XDocument(new XElement("Root",
                    new XElement("RunID", "0"))).Save(path);
            }
            document = XDocument.Load(path);

        }

        public TodoModel Add(TodoModel todo)
        {
            todo.Id = GetRunID();
            document.Root.Add(ToXml(todo));
            document.Root.Save(path);
            return todo;
        }

        public void DeleteById(int id)
        {
            var element = document.Root.Elements("Todo")
                                .FirstOrDefault(e => (int)e.Element("Id") == id);
            if (element != null)
            {
                element.Remove();
                document.Save(path);
            }
            else
            {
                throw new Exception($"Todo with ID {id} not found.");
            }
        }

        public List<TodoModel> GetAll()
        {
            var todos = document.Root.Elements("Todo")
                        .Select(e => new TodoModel
                        {
                            Id = (int)e.Element("ID"),
                            Title = (string)e.Element("Title"),
                            Date = DateOnly.Parse((string)e.Element("Date")),
                            Done = (bool)e.Element("Done")
                        }).ToList();
            return todos;
        }

        public List<TodoModel> GetAll(Func<TodoModel, bool> predicate)
        {
            return GetAll().Where(predicate).ToList();
        }

        public TodoModel GetById(int id)
        {
            return document.Root.Descendants("ToDo")
                .Where(td => int.Parse(td.Element("ID").Value) == id)
                .Select(td => new TodoModel
                (id,
                td.Element("Title").Value,
                DateOnly.Parse(td.Element("Date").Value),
                bool.Parse(td.Element("Done").Value)))
                .FirstOrDefault()!;
        }

        public TodoModel Update(TodoModel todo)
        {
            int id = todo.Id;
            var element = document.Root.Elements("Todo")
                                .FirstOrDefault(e => int.Parse(e.Element("ID").Value) == id);
            element.Element("Title").Value = todo.Title;
            element.Element("Date").Value = todo.Date.ToString();
            element.Element("Done").Value = todo.Done.ToString();
            //element.Save(path);
            document.Root.Save(path);
            return todo;
        }

        private XElement ToXml(TodoModel todo)
        {
            return new XElement("Todo",
                new XElement("ID", todo.Id),
                new XElement("Title", todo.Title),
                new XElement("Date", todo.XmlDate),
                new XElement("Done", todo.Done)
            );
        }

        private int GetRunID()
        {
            XElement RunId = document.Root.Element("RunID");
            int runID = int.Parse(RunId.Value);
            RunId.Value = $"{runID + 1}";
            RunId.Save(path);
            return runID;
        }
    }
}
