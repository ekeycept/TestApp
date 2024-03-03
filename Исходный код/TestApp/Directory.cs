using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TestApp
{
    public partial class Directory : Form
    {
        private Rectangle originalFormRectangle;
        private List<Rectangle> originalItemRectangles = new List<Rectangle>();
        private Control[] controls = new Control[9];
        private DataTable _dataTable = new DataTable();
        public event EventHandler DirectoryChanged;
        private string _savePath = @"C:\temp\MyDataset.xml";

        public Directory()
        {
            InitializeComponent();

            Control[] controls = { DirectoryLabel, NamingLabel, IDLabel, NamingTextBox,
                                    IDTextBox, DirectoryDataGridView, AddButton, SaveButton,
                                    DeleteButton};
            this.controls = controls;
        }

        private void Directory_Load(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();
            try
            {
                if(File.Exists(_savePath))
                {
                    dataSet.ReadXml(_savePath);
                    _dataTable = dataSet.Tables[0];
                    DirectoryDataGridView.Columns.Clear();
                    DirectoryDataGridView.DataSource = _dataTable;
                }
            }
            catch 
            {
                if (File.Exists(@"MyDataset.xml"))
                {
                    dataSet.ReadXml(@"MyDataset.xml");
                    _dataTable = dataSet.Tables[0];
                    DirectoryDataGridView.Columns.Clear();
                    DirectoryDataGridView.DataSource = _dataTable;
                }
                    
            }

            originalFormRectangle = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);

            foreach (Control c in controls)
                originalItemRectangles.Add(new Rectangle(c.Location.X, c.Location.Y, c.Size.Width, c.Size.Height));
        }

        private void Directory_Resize(object sender, EventArgs e)
        {
            for (int i = 0; i < originalItemRectangles.Count; i++)
            {
                ResizeItem(originalItemRectangles[i], controls[i]);
            }
        }

        private void ResizeItem(Rectangle r, Control c)
        {
            float xRatio = (float)(this.Width) / (float)(originalFormRectangle.Width);
            float yRatio = (float)(this.Height) / (float)(originalFormRectangle.Height);

            int newX = (int)(r.Location.X * xRatio);
            int newY = (int)(r.Location.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!IsHEX(IDTextBox.Text))
            {
                MessageBox.Show("Введенный идентификатор содержит недопустимые символы", "Ошибка");
                return;
            }

            if (IDTextBox.Text.Length != 24)
            {
                MessageBox.Show("Введенный идентификатор меньше 24 символов", "Ошибка");
                return;
            }

            foreach (DataGridViewRow row in DirectoryDataGridView.Rows)
            {
                if (row.Cells[1].Value.ToString() == IDTextBox.Text)
                {
                    MessageBox.Show("Такой идентификатор уже существует. Объект: " + row.Cells[0].Value.ToString(), "Ошибка");
                    return;
                }
            }
            if (DirectoryDataGridView.DataSource == null)
            {
                DirectoryDataGridView.Rows.Add(NamingTextBox.Text, IDTextBox.Text);
            }
            else
            {
                DataRow dr = _dataTable.NewRow();
                dr[0] = NamingTextBox.Text;
                dr[1] = IDTextBox.Text;
                _dataTable.Rows.Add(dr);
            }
            NamingTextBox.Clear();
            IDTextBox.Clear();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DirectoryDataGridView.SelectedRows)
            {
                DirectoryDataGridView.Rows.RemoveAt(row.Index);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            foreach (DataGridViewColumn column in DirectoryDataGridView.Columns)
            {
                dt.Columns.Add(column.HeaderText, typeof(string));
            }
            foreach (DataGridViewRow row in DirectoryDataGridView.Rows)
            {
                dt.Rows.Add(row.Cells[0].Value, row.Cells[1].Value);
            }
            DataSet dataSet = new DataSet();
            dataSet.Tables.Add(dt);

            try
            {
                dataSet.WriteXml(_savePath);
            }
            catch
            {
                dataSet.WriteXml(@"MyDataset.xml");
            }
            finally
            {
                DirectoryChanged?.Invoke(sender, e);
            }
        }

        private bool IsHEX(string hex24)
        {
            return Regex.IsMatch(hex24, @"^[a-zA-Z0-9]+$");
        }
    }
}
