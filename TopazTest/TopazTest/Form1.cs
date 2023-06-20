using Newtonsoft.Json;

namespace TopazTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Root DeserializedClass;
        private string LastFileDirectory;

        private async void OpenFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select file";
            openFileDialog.Filter = "All files(*.*)|*.*|Json file (*.json)|*.json";
            openFileDialog.InitialDirectory = @"C:\";
            openFileDialog.FilterIndex = 2;
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName != "")
            {
                LastFileDirectory = new FileInfo(openFileDialog.FileName).Directory.FullName;
                string jsonText;
                var fileName = openFileDialog.FileName;
                using (var reader = new StreamReader(fileName))
                {
                    jsonText = await reader.ReadToEndAsync();
                }

                try
                {
                    Root? tempRoot = JsonConvert.DeserializeObject<Root>(jsonText);
                    if (tempRoot is null)
                        throw new Exception();
                    else
                    {
                        DeserializedClass = tempRoot;
                    }
                    DisplayData(DeserializedClass);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при чтении JSON"/*ex.Message*/);
                }
            }
            else return;
        }
        private void DisplayData(Root data)
        {
            JsonDataGrid.Rows.Clear();
            for (int i = 0; i < data?.parameters.Count; i++)
            {
                JsonDataGrid.Rows.Add();
                JsonDataGrid["nameColumn", i].Value = data.parameters[i].name;
                JsonDataGrid["valueColumn", i].Value = data.parameters[i].value;
                JsonDataGrid["groupColumn", i].Value = data.parameters[i].group;
                if (data.parameters[i].name.Contains("nsgbr"))
                {
                    JsonDataGrid["nameColumn", i].Style.BackColor = Color.FromArgb(-256);
                }
            }

            JsonTextBox.Text = JsonConvert.SerializeObject(data, Formatting.Indented);
        }

        private void JsonDataGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Parameter tempParameter = DeserializedClass.parameters[e.RowIndex];
            switch (e.ColumnIndex)
            {
                case 0:
                    tempParameter.name = JsonDataGrid[e.ColumnIndex, e.RowIndex].Value.ToString();
                    break;
                case 1:
                    tempParameter.value = JsonDataGrid[e.ColumnIndex, e.RowIndex].Value.ToString();
                    break;
                case 2:
                    tempParameter.group = JsonDataGrid[e.ColumnIndex, e.RowIndex].Value.ToString();
                    break;
            }
        }

        private void SaveFromTableButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Select file";
            saveFileDialog.Filter = "All files(*.*)|*.*|Json file (*.json)|*.json";
            saveFileDialog.InitialDirectory = LastFileDirectory;
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                using(var writer = new StreamWriter(saveFileDialog.FileName))
                {
                    writer.Write(JsonConvert.SerializeObject(DeserializedClass, Formatting.None));
                }
            }
            else return;

            DisplayData(DeserializedClass);

        }

        private void SaveFromTextboxButton_Click(object sender, EventArgs e)
        {
            try
            {
                Root? tempRoot = JsonConvert.DeserializeObject<Root>(JsonTextBox.Text);
                if (tempRoot is null)
                    throw new Exception();
                else
                {
                    DeserializedClass = tempRoot;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось преобразовать текст в Json");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Select file";
            saveFileDialog.Filter = "All files(*.*)|*.*|Json file (*.json)|*.json";
            saveFileDialog.InitialDirectory = LastFileDirectory;
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                using (var writer = new StreamWriter(saveFileDialog.FileName))
                {
                    writer.Write(JsonConvert.SerializeObject(DeserializedClass, Formatting.None));
                }
            }
            else return;

            DisplayData(DeserializedClass);
        }
    }
}