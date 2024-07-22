namespace TodoList
{
    partial class Todos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textbox_title = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            label_title = new ReaLTaiizor.Controls.MaterialLabel();
            label_date = new ReaLTaiizor.Controls.MaterialLabel();
            hopeDatePicker1 = new ReaLTaiizor.Controls.HopeDatePicker();
            checkbox_isDone = new ReaLTaiizor.Controls.MaterialCheckBox();
            dataGridView_tasks = new DataGridView();
            button_action = new ReaLTaiizor.Controls.MaterialButton();
            button_Cancel = new ReaLTaiizor.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView_tasks).BeginInit();
            SuspendLayout();
            // 
            // textbox_title
            // 
            textbox_title.AnimateReadOnly = false;
            textbox_title.AutoCompleteMode = AutoCompleteMode.None;
            textbox_title.AutoCompleteSource = AutoCompleteSource.None;
            textbox_title.BackgroundImageLayout = ImageLayout.None;
            textbox_title.CharacterCasing = CharacterCasing.Normal;
            textbox_title.Depth = 0;
            textbox_title.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textbox_title.HideSelection = true;
            textbox_title.LeadingIcon = null;
            textbox_title.Location = new Point(42, 128);
            textbox_title.MaxLength = 32767;
            textbox_title.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            textbox_title.Name = "textbox_title";
            textbox_title.PasswordChar = '\0';
            textbox_title.PrefixSuffixText = null;
            textbox_title.ReadOnly = false;
            textbox_title.RightToLeft = RightToLeft.No;
            textbox_title.SelectedText = "";
            textbox_title.SelectionLength = 0;
            textbox_title.SelectionStart = 0;
            textbox_title.ShortcutsEnabled = true;
            textbox_title.Size = new Size(312, 48);
            textbox_title.TabIndex = 0;
            textbox_title.TabStop = false;
            textbox_title.TextAlign = HorizontalAlignment.Left;
            textbox_title.TrailingIcon = null;
            textbox_title.UseSystemPasswordChar = false;
            // 
            // label_title
            // 
            label_title.AutoSize = true;
            label_title.Depth = 0;
            label_title.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label_title.Location = new Point(42, 94);
            label_title.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            label_title.Name = "label_title";
            label_title.Size = new Size(87, 19);
            label_title.TabIndex = 1;
            label_title.Text = "Task details";
            // 
            // label_date
            // 
            label_date.AutoSize = true;
            label_date.Depth = 0;
            label_date.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label_date.Location = new Point(42, 209);
            label_date.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            label_date.Name = "label_date";
            label_date.Size = new Size(66, 19);
            label_date.TabIndex = 3;
            label_date.Text = "Due Date";
            // 
            // hopeDatePicker1
            // 
            hopeDatePicker1.BackColor = Color.White;
            hopeDatePicker1.BorderColor = Color.FromArgb(220, 223, 230);
            hopeDatePicker1.Date = new DateTime(2024, 7, 22, 0, 0, 0, 0);
            hopeDatePicker1.DayNames = "MTWTFSS";
            hopeDatePicker1.DaysTextColor = Color.FromArgb(96, 98, 102);
            hopeDatePicker1.DayTextColorA = Color.FromArgb(48, 49, 51);
            hopeDatePicker1.DayTextColorB = Color.FromArgb(144, 147, 153);
            hopeDatePicker1.HeaderFormat = "{0} Y - {1} M";
            hopeDatePicker1.HeaderTextColor = Color.FromArgb(48, 49, 51);
            hopeDatePicker1.HeadLineColor = Color.FromArgb(228, 231, 237);
            hopeDatePicker1.HoverColor = Color.FromArgb(235, 238, 245);
            hopeDatePicker1.Location = new Point(42, 243);
            hopeDatePicker1.Name = "hopeDatePicker1";
            hopeDatePicker1.NMColor = Color.FromArgb(192, 196, 204);
            hopeDatePicker1.NMHoverColor = Color.FromArgb(64, 158, 255);
            hopeDatePicker1.NYColor = Color.FromArgb(192, 196, 204);
            hopeDatePicker1.NYHoverColor = Color.FromArgb(64, 158, 255);
            hopeDatePicker1.PMColor = Color.FromArgb(192, 196, 204);
            hopeDatePicker1.PMHoverColor = Color.FromArgb(64, 158, 255);
            hopeDatePicker1.PYColor = Color.FromArgb(192, 196, 204);
            hopeDatePicker1.PYHoverColor = Color.FromArgb(64, 158, 255);
            hopeDatePicker1.SelectedBackColor = Color.FromArgb(64, 158, 255);
            hopeDatePicker1.SelectedTextColor = Color.White;
            hopeDatePicker1.Size = new Size(250, 270);
            hopeDatePicker1.TabIndex = 4;
            hopeDatePicker1.Text = "hopeDatePicker1";
            hopeDatePicker1.ValueTextColor = Color.FromArgb(43, 133, 228);
            // 
            // checkbox_isDone
            // 
            checkbox_isDone.AutoSize = true;
            checkbox_isDone.Depth = 0;
            checkbox_isDone.Location = new Point(42, 551);
            checkbox_isDone.Margin = new Padding(0);
            checkbox_isDone.MouseLocation = new Point(-1, -1);
            checkbox_isDone.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            checkbox_isDone.Name = "checkbox_isDone";
            checkbox_isDone.ReadOnly = false;
            checkbox_isDone.Ripple = true;
            checkbox_isDone.Size = new Size(72, 37);
            checkbox_isDone.TabIndex = 5;
            checkbox_isDone.Text = "Done";
            checkbox_isDone.UseAccentColor = false;
            checkbox_isDone.UseVisualStyleBackColor = true;
            // 
            // dataGridView_tasks
            // 
            dataGridView_tasks.AllowUserToAddRows = false;
            dataGridView_tasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_tasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_tasks.Location = new Point(412, 128);
            dataGridView_tasks.Name = "dataGridView_tasks";
            dataGridView_tasks.RowHeadersWidth = 51;
            dataGridView_tasks.Size = new Size(525, 460);
            dataGridView_tasks.TabIndex = 6;
            dataGridView_tasks.CellContentClick += dataGridView_tasks_CellContentClick;
            // 
            // button_action
            // 
            button_action.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_action.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            button_action.Depth = 0;
            button_action.HighEmphasis = true;
            button_action.Icon = null;
            button_action.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            button_action.Location = new Point(255, 551);
            button_action.Margin = new Padding(4, 6, 4, 6);
            button_action.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            button_action.Name = "button_action";
            button_action.NoAccentTextColor = Color.Empty;
            button_action.Size = new Size(85, 36);
            button_action.TabIndex = 7;
            button_action.Text = "ADD|EDIT";
            button_action.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            button_action.UseAccentColor = false;
            button_action.UseVisualStyleBackColor = true;
            button_action.Click += button_action_Click;
            // 
            // button_Cancel
            // 
            button_Cancel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_Cancel.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            button_Cancel.Depth = 0;
            button_Cancel.HighEmphasis = true;
            button_Cancel.Icon = null;
            button_Cancel.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            button_Cancel.Location = new Point(162, 552);
            button_Cancel.Margin = new Padding(4, 6, 4, 6);
            button_Cancel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            button_Cancel.Name = "button_Cancel";
            button_Cancel.NoAccentTextColor = Color.Empty;
            button_Cancel.Size = new Size(85, 36);
            button_Cancel.TabIndex = 8;
            button_Cancel.Text = "Cancel";
            button_Cancel.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            button_Cancel.UseAccentColor = false;
            button_Cancel.UseVisualStyleBackColor = true;
            button_Cancel.Click += button_Cancel_Click;
            // 
            // Todos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 728);
            Controls.Add(button_Cancel);
            Controls.Add(button_action);
            Controls.Add(dataGridView_tasks);
            Controls.Add(checkbox_isDone);
            Controls.Add(hopeDatePicker1);
            Controls.Add(label_date);
            Controls.Add(label_title);
            Controls.Add(textbox_title);
            Name = "Todos";
            Text = "Todos";
            ((System.ComponentModel.ISupportInitialize)dataGridView_tasks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit textbox_title;
        private ReaLTaiizor.Controls.MaterialLabel label_title;
        private ReaLTaiizor.Controls.MaterialLabel label_date;
        private ReaLTaiizor.Controls.HopeDatePicker hopeDatePicker1;
        private ReaLTaiizor.Controls.MaterialCheckBox checkbox_isDone;
        private DataGridView dataGridView_tasks;
        private ReaLTaiizor.Controls.MaterialButton button_action;
        private Button button_cancel;
        private ReaLTaiizor.Controls.MaterialButton button_Cancel;
    }
}