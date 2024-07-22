using ReaLTaiizor.Forms;
using System.Globalization;
using System.Windows.Forms;

namespace TodoList
{
    enum Mode
    {
        Add,
        Edit
    }

    internal partial class Todos : MaterialForm
    {
        private List<TodoModel> todos;
        private Mode mode;
        private IRepository<TodoModel> repository;
        int selectedID = 0;

        public Todos(IRepository<TodoModel> repository)
        {
            InitializeComponent();
            this.repository = repository;
            Load();
        }
        public void Load()
        {
            SetMode(Mode.Add);
            todos = repository.GetAll();
            dataGridView_tasks.DataSource = todos;
        }
        private void populateViewWithTodo() { }

        // populate form from selected row
        private void dataGridView_tasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView_tasks.Rows[e.RowIndex];
            if (row != null)
            {
                selectedID = (int)row.Cells[0].Value;
                textbox_title.Text = row.Cells[1].Value.ToString();
                hopeDatePicker1.Date = DateTime.Parse(row.Cells[2].Value.ToString());
                checkbox_isDone.Checked = (bool)row.Cells[4].Value;
            }
            SetMode(Mode.Edit);
        }

        private void SetMode(Mode mode)
        {
            this.mode = mode;
            switch (mode)
            {
                case Mode.Add:
                    button_action.Text = "Add";
                    break;
                case Mode.Edit:
                    button_action.Text = "Edit";
                    break;
            }
        }

        // add or edit based on mode
        private void button_action_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textbox_title.Text))
            {
                MessageBox.Show("Enter Title");
                return;
            }
            if (mode == Mode.Edit)
            {
                //TodoModel selectedItem = repository.GetById("Id");
                repository.Update(SelectedItem());
                Load();
            }
            else
            {
                repository.Add(SelectedItem());
                Load();
            }
        }

        private TodoModel SelectedItem()
        {
            return new TodoModel(
                selectedID,
                textbox_title.Text.ToString(),
                DateOnly.FromDateTime(hopeDatePicker1.Date),
                checkbox_isDone.Checked
                );
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            CleanAll();
        }

        private void CleanAll()
        {
            textbox_title.Text = string.Empty;
            checkbox_isDone.Checked = false;
            hopeDatePicker1.Date = DateTime.Now;
            SetMode(Mode.Add);
        }
    }
}
