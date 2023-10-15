
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Msagl.Core.Geometry.Curves.PlaneTransformation planeTransformation1 = new Microsoft.Msagl.Core.Geometry.Curves.PlaneTransformation();
            this.graphRichTextBox = new System.Windows.Forms.RichTextBox();
            this.searchFileLabel = new System.Windows.Forms.Label();
            this.SearchGraphFile = new System.Windows.Forms.OpenFileDialog();
            this.searchFileTextBox = new System.Windows.Forms.TextBox();
            this.searchFileButton = new System.Windows.Forms.Button();
            this.buildGraphButton = new System.Windows.Forms.Button();
            this.graphLabel = new System.Windows.Forms.Label();
            this.findSolutionButton = new System.Windows.Forms.Button();
            this.fileErrorText = new System.Windows.Forms.Label();
            this.buildOrMatrixErrorText = new System.Windows.Forms.Label();
            this.textHideTimer = new System.Windows.Forms.Timer(this.components);
            this.findSolutionErrorText = new System.Windows.Forms.Label();
            this.graphViewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            this.SuspendLayout();
            // 
            // graphRichTextBox
            // 
            this.graphRichTextBox.Location = new System.Drawing.Point(650, 75);
            this.graphRichTextBox.Name = "graphRichTextBox";
            this.graphRichTextBox.Size = new System.Drawing.Size(272, 300);
            this.graphRichTextBox.TabIndex = 0;
            this.graphRichTextBox.Text = "";
            // 
            // searchFileLabel
            // 
            this.searchFileLabel.AutoSize = true;
            this.searchFileLabel.Location = new System.Drawing.Point(647, 20);
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
            this.searchFileTextBox.Location = new System.Drawing.Point(650, 36);
            this.searchFileTextBox.Name = "searchFileTextBox";
            this.searchFileTextBox.ReadOnly = true;
            this.searchFileTextBox.Size = new System.Drawing.Size(233, 20);
            this.searchFileTextBox.TabIndex = 2;
            // 
            // searchFileButton
            // 
            this.searchFileButton.Location = new System.Drawing.Point(889, 35);
            this.searchFileButton.Name = "searchFileButton";
            this.searchFileButton.Size = new System.Drawing.Size(33, 20);
            this.searchFileButton.TabIndex = 3;
            this.searchFileButton.Text = "...";
            this.searchFileButton.UseVisualStyleBackColor = true;
            this.searchFileButton.Click += new System.EventHandler(this.searchFileButton_Click);
            // 
            // buildGraphButton
            // 
            this.buildGraphButton.Location = new System.Drawing.Point(650, 380);
            this.buildGraphButton.Name = "buildGraphButton";
            this.buildGraphButton.Size = new System.Drawing.Size(272, 41);
            this.buildGraphButton.TabIndex = 5;
            this.buildGraphButton.Text = "Build or rebuild graph";
            this.buildGraphButton.UseVisualStyleBackColor = true;
            this.buildGraphButton.Click += new System.EventHandler(this.buildGraphButton_Click);
            // 
            // graphLabel
            // 
            this.graphLabel.AutoSize = true;
            this.graphLabel.Location = new System.Drawing.Point(12, 20);
            this.graphLabel.Name = "graphLabel";
            this.graphLabel.Size = new System.Drawing.Size(96, 13);
            this.graphLabel.TabIndex = 6;
            this.graphLabel.Text = "Graph visualisation";
            // 
            // findSolutionButton
            // 
            this.findSolutionButton.Location = new System.Drawing.Point(12, 380);
            this.findSolutionButton.Name = "findSolutionButton";
            this.findSolutionButton.Size = new System.Drawing.Size(622, 41);
            this.findSolutionButton.TabIndex = 7;
            this.findSolutionButton.Text = "Find solution";
            this.findSolutionButton.UseVisualStyleBackColor = true;
            this.findSolutionButton.Click += new System.EventHandler(this.findSolutionButton_Click);
            // 
            // fileErrorText
            // 
            this.fileErrorText.AutoSize = true;
            this.fileErrorText.Location = new System.Drawing.Point(647, 59);
            this.fileErrorText.Name = "fileErrorText";
            this.fileErrorText.Size = new System.Drawing.Size(35, 13);
            this.fileErrorText.TabIndex = 8;
            this.fileErrorText.Text = "label1";
            // 
            // buildOrMatrixErrorText
            // 
            this.buildOrMatrixErrorText.AutoSize = true;
            this.buildOrMatrixErrorText.Location = new System.Drawing.Point(647, 424);
            this.buildOrMatrixErrorText.Name = "buildOrMatrixErrorText";
            this.buildOrMatrixErrorText.Size = new System.Drawing.Size(35, 13);
            this.buildOrMatrixErrorText.TabIndex = 9;
            this.buildOrMatrixErrorText.Text = "label2";
            // 
            // textHideTimer
            // 
            this.textHideTimer.Interval = 5000;
            this.textHideTimer.Tick += new System.EventHandler(this.textHideTimer_Tick);
            // 
            // findSolutionErrorText
            // 
            this.findSolutionErrorText.AutoSize = true;
            this.findSolutionErrorText.Location = new System.Drawing.Point(12, 424);
            this.findSolutionErrorText.Name = "findSolutionErrorText";
            this.findSolutionErrorText.Size = new System.Drawing.Size(35, 13);
            this.findSolutionErrorText.TabIndex = 10;
            this.findSolutionErrorText.Text = "label3";
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
            this.graphViewer.EdgeInsertButtonVisible = false;
            this.graphViewer.FileName = "";
            this.graphViewer.ForwardEnabled = false;
            this.graphViewer.Graph = null;
            this.graphViewer.InsertingEdge = false;
            this.graphViewer.LayoutAlgorithmSettingsButtonVisible = true;
            this.graphViewer.LayoutEditingEnabled = true;
            this.graphViewer.Location = new System.Drawing.Point(15, 36);
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
            this.graphViewer.Size = new System.Drawing.Size(619, 339);
            this.graphViewer.TabIndex = 11;
            this.graphViewer.TightOffsetForRouting = 0.125D;
            this.graphViewer.ToolBarIsVisible = true;
            this.graphViewer.Transform = planeTransformation1;
            this.graphViewer.UndoRedoButtonsVisible = true;
            this.graphViewer.WindowZoomButtonPressed = false;
            this.graphViewer.ZoomF = 1D;
            this.graphViewer.ZoomWindowThreshold = 0.05D;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 442);
            this.Controls.Add(this.graphViewer);
            this.Controls.Add(this.findSolutionErrorText);
            this.Controls.Add(this.buildOrMatrixErrorText);
            this.Controls.Add(this.fileErrorText);
            this.Controls.Add(this.findSolutionButton);
            this.Controls.Add(this.graphLabel);
            this.Controls.Add(this.buildGraphButton);
            this.Controls.Add(this.searchFileButton);
            this.Controls.Add(this.searchFileTextBox);
            this.Controls.Add(this.searchFileLabel);
            this.Controls.Add(this.graphRichTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(954, 485);
            this.MinimizeBox = false;
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
        private System.Windows.Forms.Button buildGraphButton;
        private System.Windows.Forms.Label graphLabel;
        private System.Windows.Forms.Button findSolutionButton;
        private System.Windows.Forms.Label fileErrorText;
        private System.Windows.Forms.Label buildOrMatrixErrorText;
        private System.Windows.Forms.Timer textHideTimer;
        private System.Windows.Forms.Label findSolutionErrorText;
        private Microsoft.Msagl.GraphViewerGdi.GViewer graphViewer;
    }
}

