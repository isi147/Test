using System.Xml;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private Anket? anket;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JSON Dosyası|*.json|Butun Hamisi|*.*";
            saveFileDialog.Title = "Dosyayı Kaydet";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                anket = new Anket();
                anket.Name = textName.Text;
                anket.Surname = textSurname.Text;
                anket.FatherN = textFather.Text;
                anket.Birthday = date.Value;
                anket.Gender = radioMale.Checked ? "Erkek" : "Kadın";
                
                string json = JsonSerializer.Serialize(anket);

                File.WriteAllText(saveFileDialog.FileName, json);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON Dosyası|*.json";
            openFileDialog.Title = "Dosya Seç";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string json = File.ReadAllText(openFileDialog.FileName);
                anket = JsonSerializer.Deserialize<Anket>(json);

                textName.Text = anket!.Name;
                textSurname.Text = anket.Surname;
                textFather.Text = anket.FatherN;
                date.Value = anket.Birthday;
                
                if (anket.Gender == "Erkek")
                {
                    radioMale.Checked = true;
                }
                else
                {
                    radioFam.Checked = true;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}