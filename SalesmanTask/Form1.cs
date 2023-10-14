using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace SalesmanTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //EXAMPLE ONLY
            Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");
            //create the graph content
            graph.AddEdge("A", "B");
            graph.AddEdge("B", "C");
            graph.AddEdge("A", "C").Attr.Color = Microsoft.Msagl.Drawing.Color.Green;
            graph.FindNode("A").Attr.FillColor = Microsoft.Msagl.Drawing.Color.Magenta;
            graph.FindNode("B").Attr.FillColor = Microsoft.Msagl.Drawing.Color.MistyRose;
            Microsoft.Msagl.Drawing.Node c = graph.FindNode("C");
            c.Attr.FillColor = Microsoft.Msagl.Drawing.Color.PaleGreen;
            c.Attr.Shape = Microsoft.Msagl.Drawing.Shape.Diamond;
            //bind the graph to the viewer
            graphViewer.Graph = graph;
            //associate the viewer with the form

            SearchGraphFile.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.SearchGraphFile.ShowDialog() == DialogResult.Cancel)
            {
                MessageBox.Show("Файл не выбран. Повторите попытку.");
                return;
            }
            string fileName = SearchGraphFile.FileName;
            this.searchFileTextBox.Text = fileName;
            ReadFromFile(fileName);
        }

        public void ReadFromFile(string fileName)
        {
            try
            {
                StreamReader sr = new StreamReader(fileName);
                string graphStringLines = sr.ReadToEnd();
                this.graphRichTextBox.Text = graphStringLines;
                sr.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка: " + e.Message);
            }
            finally
            {
                MessageBox.Show("Чтение из файла прошло успешно. Данные отображены.");
            }
        }
    }
}
