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
        int[,] adjections;

        public Form1()
        {
            InitializeComponent();
            ErrorLabelsSet();
            SearchGraphFile.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        public void ReadFromFile(string fileName)
        {
            StreamReader sr = new StreamReader(fileName);
            string graphStringLines = sr.ReadToEnd();
            this.graphRichTextBox.Text = graphStringLines;
            sr.Close();
        }

        public void BuildGraph()
        {
            Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");
            for (int i = 0; i < Math.Sqrt(adjections.Length); i++)
            {
                for (int j = 0; j < Math.Sqrt(adjections.Length); j++)
                {
                    if (i != j)
                    {
                        if (adjections[i, j] != 0)
                        {
                            graph.AddEdge((i + 1).ToString(), adjections[i, j].ToString(), (j + 1).ToString());
                        }
                    }
                }
            }
            for (int i = 0; i < Math.Sqrt(adjections.Length); i++)
            {
                Microsoft.Msagl.Drawing.Node graphNode = graph.FindNode((i+1).ToString());
                graphNode.Attr.Shape = Microsoft.Msagl.Drawing.Shape.Circle;
            }
            graphViewer.Graph = graph;
        }

        public void ErrorLabelsSet()
        {
            fileErrorText.Text = "";
            buildOrMatrixErrorText.Text = "";
            findSolutionErrorText.Text = "";
        }

        private void searchFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.SearchGraphFile.ShowDialog() == DialogResult.Cancel)
                {
                    throw new Exception("File not selected.");
                }
                string fileName = SearchGraphFile.FileName;
                this.searchFileTextBox.Text = fileName;
                ReadFromFile(fileName);
                fileErrorText.ForeColor = Color.Green;
                fileErrorText.Text = "Complete read data.";
            }
            catch (Exception excpt)
            {
                fileErrorText.ForeColor = Color.Red;
                fileErrorText.Text = "Exception: " + excpt.Message;
            }
            textHideTimer.Start();
        }

        private void buildGraphButton_Click(object sender, EventArgs e)
        {
            try
            {
                string[] graphMatrix = graphRichTextBox.Lines;
                string[] graphMatrixLine;
                int[,] adjectionsCopy = new int[graphMatrix.Length, graphMatrix.Length];
                if (graphMatrix == null)
                {
                    throw new Exception("Graph matrix is empty.");
                }
                if (graphMatrix.Length != graphMatrix[0].Split(' ').Length)
                {
                    throw new Exception("Solution cant be find for this graph matrix.");
                }
                for (int i = 0; i < graphMatrix.Length; i++)
                {
                    graphMatrixLine = graphMatrix[i].Split(' ');
                    for (int j = 0; j < graphMatrix.Length; j++)
                    {
                        adjectionsCopy[i, j] = int.Parse(graphMatrixLine[j]);
                    }
                }
                for (int i = 0; i < graphMatrix.Length; i++)
                {
                    for (int j = 0; j < graphMatrix.Length; j++)
                    {
                        if (i == j && adjectionsCopy[i, j] != 0)
                        {
                            throw new Exception("Diagonal is not zero.");
                        }
                        if (adjectionsCopy[i, j] != adjectionsCopy[j, i])
                        {
                            throw new Exception("The matrix is ​​not symmetrical.");
                        }
                    }
                }
                this.adjections = adjectionsCopy;
                this.BuildGraph();
                buildOrMatrixErrorText.ForeColor = Color.Green;
                buildOrMatrixErrorText.Text = "Data read success. Graph is built.";
            }
            catch (Exception excpt)
            {
                buildOrMatrixErrorText.ForeColor = Color.Red;
                buildOrMatrixErrorText.Text = "Exception: " + excpt.Message;
            }
            textHideTimer.Start();
        }

        private void findSolutionButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (adjections == null)
                {
                    throw new Exception("Adjections array is null");
                }
                BranchBound sltn = new BranchBound((int)Math.Sqrt(adjections.Length));
                Tuple<int, int[]> result = sltn.GetResult(adjections);
                int pathCost = result.Item1;
                int[] path = result.Item2;
                int i = 0;
                while (i < path.Length-1)
                {
                    Microsoft.Msagl.Drawing.Node graphNode1 = graphViewer.Graph.FindNode((path[i] + 1).ToString());
                    Microsoft.Msagl.Drawing.Node graphNode2 = graphViewer.Graph.FindNode((path[i + 1] + 1).ToString());
                    Microsoft.Msagl.Drawing.Edge graphEdge = graphViewer.Graph
                                                              .Edges
                                                              .Select(p => p)
                                                              .Where(p => p.SourceNode == graphNode1 && p.TargetNode == graphNode2)
                                                              .Single();
                    graphEdge.Attr.Color = Microsoft.Msagl.Drawing.Color.Green;
                    i += 1;
                }
                findSolutionErrorText.ForeColor = Color.Green;
                findSolutionErrorText.Text = "Solution find success with path cost " + pathCost;
            }
            catch (Exception excpt)
            {
                findSolutionErrorText.ForeColor = Color.Red;
                findSolutionErrorText.Text = "Exception: " + excpt.Message;
            }
            textHideTimer.Start();
        }

        private void textHideTimer_Tick(object sender, EventArgs e)
        {
            Timer _t = sender as Timer;
            ErrorLabelsSet();
            _t.Stop();
        }
    }
}