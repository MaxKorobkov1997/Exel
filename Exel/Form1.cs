using Microsoft.Office.Interop.Excel;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exel
{
    public partial class Form1 : Form
    {
        List<Exel_Table> numbers;
        List<Exel_Table> exel_Tables;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14);
            dataGridView1.ReadOnly = true;
        }

        void Otk(string path)
        {
            dataGridView1.Columns.Clear();
            Exele_Reed exele_Reed = new Exele_Reed(path);
            numbers = exele_Reed.Exel_rid();
            //dataGridView1.DataSource = numbers;
            Zapol_Listbox();
        }

        private void Zapol_Listbox()
        {
            var words = new Dictionary<string, int>();
            foreach (var word in numbers)
            {
                if (words.ContainsKey(word.Name)) words[word.Name]++;
                else words.Add(word.Name, 1);
            }
            listBox1.Items.Clear();
            listBox1.Items.Add("Показать все");
            foreach (KeyValuePair<string, int> kvp in words)
            {
                listBox1.Items.Add("Key: " + kvp.Key + " Value: " + kvp.Value + "\n");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                Otk1(openFileDialog.FileName);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = listBox1.GetItemText(listBox1.SelectedItem);
            var words = new Dictionary<string, int>();
            var text_split = text.Split();
            dataGridView1.Columns.Clear();
            if (text == "Показать все")
                exel_Tables = numbers;
            //dataGridView1.DataSource = numbers;
            else
                exel_Tables = numbers.Where(o => o.Name == text_split[1]).ToList();
            foreach (var word in exel_Tables)
            {
                if (words.ContainsKey(word.Name_Nast)) words[word.Name_Nast]++;
                else words.Add(word.Name_Nast, 1);
            }
            listBox2.Items.Clear();
            listBox2.Items.Add("Показать все");
            foreach (KeyValuePair<string, int> kvp in words)
            {
                listBox2.Items.Add("Key: " + kvp.Key + " Value: " + kvp.Value + "\n");
            }
            //dataGridView1.DataSource = numbers.Where(e => e.Name == text_split[1]).ToList();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = listBox2.GetItemText(listBox2.SelectedItem);
            var text_split = text.Split();
            dataGridView1.Columns.Clear();
            if (text == "Показать все")
                dataGridView1.DataSource = exel_Tables;
            else
                dataGridView1.DataSource = exel_Tables.Where(e => e.Name_Nast == text_split[1]).ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Exel_Asposs exele_Reed = new Exel_Asposs(openFileDialog.FileName);
                numbers.AddRange(exele_Reed.Otk());
                Zapol_Listbox();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Otk1(openFileDialog.FileName);
            }
        }
        void Otk1(string path)
        {
            dataGridView1.Columns.Clear();
            Exel_Asposs exele_Reed = new Exel_Asposs(path);
            numbers = exele_Reed.Otk();
            //dataGridView1.DataSource = numbers;
            Zapol_Listbox();
        }
    }
}
