using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TestApp
{
    public partial class MainForm : Form
    {
        private Rectangle originalFormRectangle;
        private List<Rectangle> originalItemRectangles = new List<Rectangle>();
        private Control[] controls = new Control[10];
        private string _savePath = @"C:\temp\MyDataset.xml";
        private Dictionary<string, string> _directoryDictionary;

        public MainForm()
        {
            InitializeComponent();
            Control[] controls = { ReceptionFieldLabel, ShipmentFiledLabel , ReceptionLabel, ShipmentLabel,
                                    ReceptionTextBox, ShipmentTextBox, ReceptionDataGridView, ShipmentDataGridView,
                                    ClearButton, DirectoryButton };
            this.controls = controls;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _directoryDictionary = new Dictionary<string, string>();
            DataSet dataSet = new DataSet();
            try
            {
                if (File.Exists(_savePath))
                {
                    dataSet.ReadXml(_savePath);
                    DataTable dataTable = dataSet.Tables[0];
                    foreach (DataRow row in dataTable.Rows)
                    {
                        string Name = row.ItemArray[1].ToString();
                        string ID = row.ItemArray[0].ToString();
                        _directoryDictionary.Add(Name, ID);
                    }
                }
                    
            }
            catch
            {
                if (File.Exists(@"MyDataset.xml"))
                {
                    dataSet.ReadXml(@"MyDataset.xml");
                    DataTable dataTable = dataSet.Tables[0];
                    foreach (DataRow row in dataTable.Rows)
                    {
                        string Name = row.ItemArray[1].ToString();
                        string ID = row.ItemArray[0].ToString();
                        _directoryDictionary.Add(Name, ID);
                    }
                }
                 
            }
            originalFormRectangle = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);

            foreach (Control c in controls)
                originalItemRectangles.Add(new Rectangle(c.Location.X, c.Location.Y, c.Size.Width, c.Size.Height));
        }

        private void MainForm_Resize(object sender, EventArgs e)
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

        private void ReceptionTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (ReceptionTextBox.Text.Length > 24)
                {
                    string[] inputCodes = ReceptionTextBox.Text.Split(' ');
                    foreach (var code in inputCodes)
                        AddToDataGridView(code, ReceptionDataGridView, ShipmentDataGridView);
                }
                else
                {
                    AddToDataGridView(ReceptionTextBox.Text, ReceptionDataGridView, ShipmentDataGridView);
                }
                ReceptionTextBox.Clear();
            }
        }

        private void ShipmentTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (ShipmentTextBox.Text.Length > 24)
                {
                    string[] inputCodes = ShipmentTextBox.Text.Split(' ');
                    foreach (var code in inputCodes)
                        AddToDataGridView(code, ShipmentDataGridView, ReceptionDataGridView);
                }
                else
                {
                    AddToDataGridView(ShipmentTextBox.Text, ShipmentDataGridView, ReceptionDataGridView);
                }
                ShipmentTextBox.Clear();
            }
        }

        private void AddToDataGridView(string ID, DataGridView DGV, DataGridView anotherDGV)
        {
            if (_directoryDictionary.ContainsKey(ID))
            {
                string needValue = _directoryDictionary[ID];
                bool hasOverlap = false;

                foreach (DataGridViewRow anotherRow in anotherDGV.Rows)
                {
                    if ((string)anotherRow.Cells[0].Value == needValue)
                    {
                        string value = anotherRow.Cells[1].Value.ToString();
                        int intValue = int.Parse(value);
                        if (intValue > 1)
                            anotherRow.Cells[1].Value = (intValue - 1).ToString();
                        else
                            anotherDGV.Rows.Remove(anotherRow);
                    }
                }

                foreach (DataGridViewRow row in DGV.Rows)
                {
                    if ((string)row.Cells[0].Value == needValue)
                    {
                        string value = row.Cells[1].Value.ToString();
                        int newValue = int.Parse(value) + 1;
                        row.Cells[1].Value = newValue.ToString();
                        hasOverlap = true;
                        break;
                    }
                }

                if (!hasOverlap)
                {
                    DGV.Rows.Add(needValue, "1");
                }
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ReceptionDataGridView.Rows.Clear();
            ShipmentDataGridView.Rows.Clear();
        }

        private void DirectoryButton_Click(object sender, EventArgs e)
        {
            Directory directory = new Directory();
            directory.DirectoryChanged += UpdateDirectory;
            directory.Show();
        }

        private void UpdateDirectory(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(_savePath);
            DataTable dataTable = dataSet.Tables[0];
            _directoryDictionary.Clear();
            foreach (DataRow row in dataTable.Rows)
            {
                _directoryDictionary.Add(row.ItemArray[1].ToString(), row.ItemArray[0].ToString());
            }
        }
    }
}
