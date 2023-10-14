
namespace SalesmanTask
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Msagl.Core.Geometry.Curves.PlaneTransformation planeTransformation2 = new Microsoft.Msagl.Core.Geometry.Curves.PlaneTransformation();
            this.graphRichTextBox = new System.Windows.Forms.RichTextBox();
            this.searchFileLabel = new System.Windows.Forms.Label();
            this.SearchGraphFile = new System.Windows.Forms.OpenFileDialog();
            this.searchFileTextBox = new System.Windows.Forms.TextBox();
            this.searchFileButton = new System.Windows.Forms.Button();
            this.graphViewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            this.buildGraphButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // graphRichTextBox
            // 
            this.graphRichTextBox.Location = new System.Drawing.Point(576, 61);
            this.graphRichTextBox.Name = "graphRichTextBox";
            this.graphRichTextBox.Size = new System.Drawing.Size(272, 211);
            this.graphRichTextBox.TabIndex = 0;
            this.graphRichTextBox.Text = "";
            // 
            // searchFileLabel
            // 
            this.searchFileLabel.AutoSize = true;
            this.searchFileLabel.Location = new System.Drawing.Point(573, 20);
            this.searchFileLabel.Name = "searchFileLabel";
            this.searchFileLabel.Size = new System.Drawing.Size(158, 13);
            this.searchFileLabel.TabIndex = 1;
            this.searchFileLabel.Text = "Choose file path for graph matrix";
            // 
            // SearchGraphFile
            // 
            this.SearchGraphFile.FileName = "SearchGraphFile";
            // 
            // searchFileTextBox
            // 
            this.searchFileTextBox.Location = new System.Drawing.Point(576, 36);
            this.searchFileTextBox.Name = "searchFileTextBox";
            this.searchFileTextBox.ReadOnly = true;
            this.searchFileTextBox.Size = new System.Drawing.Size(233, 20);
            this.searchFileTextBox.TabIndex = 2;
            // 
            // searchFileButton
            // 
            this.searchFileButton.Location = new System.Drawing.Point(815, 35);
            this.searchFileButton.Name = "searchFileButton";
            this.searchFileButton.Size = new System.Drawing.Size(33, 20);
            this.searchFileButton.TabIndex = 3;
            this.searchFileButton.Text = "...";
            this.searchFileButton.UseVisualStyleBackColor = true;
            this.searchFileButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // graphViewer
            // 
            this.graphViewer.ArrowheadLength = 10D;
            this.graphViewer.AsyncLayout = false;
            this.graphViewer.AutoScroll = true;
            this.graphViewer.BackwardEnabled = false;
            this.graphViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.graphViewer.BuildHitTree = true;
            this.graphViewer.CurrentLayoutMethod = Microsoft.Msagl.GraphViewerGdi.LayoutMethod.UseSettingsOfTheGraph;
            this.graphViewer.EdgeInsertButtonVisible = true;
            this.graphViewer.FileName = "";
            this.graphViewer.ForwardEnabled = false;
            this.graphViewer.Graph = null;
            this.graphViewer.InsertingEdge = false;
            this.graphViewer.LayoutAlgorithmSettingsButtonVisible = true;
            this.graphViewer.LayoutEditingEnabled = true;
            this.graphViewer.Location = new System.Drawing.Point(12, 36);
            this.graphViewer.LooseOffsetForRouting = 0.25D;
            this.graphViewer.MouseHitDistance = 0.05D;
            this.graphViewer.Name = "graphViewer";
            this.graphViewer.NavigationVisible = true;
            this.graphViewer.NeedToCalculateLayout = true;
            this.graphViewer.OffsetForRelaxingInRouting = 0.6D;
            this.graphViewer.PaddingForEdgeRouting = 8D;
            this.graphViewer.PanButtonPressed = false;
            this.graphViewer.SaveAsImageEnabled = true;
            this.graphViewer.SaveAsMsaglEnabled = true;
            this.graphViewer.SaveButtonVisible = true;
            this.graphViewer.SaveGraphButtonVisible = true;
            this.graphViewer.SaveInVectorFormatEnabled = true;
            this.graphViewer.Size = new System.Drawing.Size(543, 408);
            this.graphViewer.TabIndex = 4;
            this.graphViewer.TightOffsetForRouting = 0.125D;
            this.graphViewer.ToolBarIsVisible = true;
            this.graphViewer.Transform = planeTransformation2;
            this.graphViewer.UndoRedoButtonsVisible = true;
            this.graphViewer.WindowZoomButtonPressed = false;
            this.graphViewer.ZoomF = 1D;
            this.graphViewer.ZoomWindowThreshold = 0.05D;
            // 
            // buildGraphButton
            // 
            this.buildGraphButton.Location = new System.Drawing.Point(576, 278);
            this.buildGraphButton.Name = "buildGraphButton";
            this.buildGraphButton.Size = new System.Drawing.Size(272, 41);
            this.buildGraphButton.TabIndex = 5;
            this.buildGraphButton.Text = "Build graph";
            this.buildGraphButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 456);
            this.Controls.Add(this.buildGraphButton);
            this.Controls.Add(this.graphViewer);
            this.Controls.Add(this.searchFileButton);
            this.Controls.Add(this.searchFileTextBox);
            this.Controls.Add(this.searchFileLabel);
            this.Controls.Add(this.graphRichTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox graphRichTextBox;
        private System.Windows.Forms.Label searchFileLabel;
        private System.Windows.Forms.OpenFileDialog SearchGraphFile;
        private System.Windows.Forms.TextBox searchFileTextBox;
        private System.Windows.Forms.Button searchFileButton;
        private Microsoft.Msagl.GraphViewerGdi.GViewer graphViewer;
        private System.Windows.Forms.Button buildGraphButton;
    }
}

