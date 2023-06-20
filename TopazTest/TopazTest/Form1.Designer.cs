namespace TopazTest
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.JsonDataGrid = new System.Windows.Forms.DataGridView();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JsonTextBox = new System.Windows.Forms.RichTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.SaveFromTableButton = new System.Windows.Forms.Button();
            this.SaveFromTextboxButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.JsonDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Location = new System.Drawing.Point(12, 12);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(134, 23);
            this.OpenFileButton.TabIndex = 0;
            this.OpenFileButton.Text = "Открыть файл";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // JsonDataGrid
            // 
            this.JsonDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.JsonDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameColumn,
            this.valueColumn,
            this.groupColumn});
            this.JsonDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.JsonDataGrid.Location = new System.Drawing.Point(0, 0);
            this.JsonDataGrid.Name = "JsonDataGrid";
            this.JsonDataGrid.RowTemplate.Height = 25;
            this.JsonDataGrid.Size = new System.Drawing.Size(542, 566);
            this.JsonDataGrid.TabIndex = 1;
            this.JsonDataGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.JsonDataGrid_CellEndEdit);
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "Name";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.Width = 150;
            // 
            // valueColumn
            // 
            this.valueColumn.HeaderText = "Value";
            this.valueColumn.Name = "valueColumn";
            this.valueColumn.Width = 150;
            // 
            // groupColumn
            // 
            this.groupColumn.HeaderText = "Group";
            this.groupColumn.Name = "groupColumn";
            this.groupColumn.Width = 150;
            // 
            // JsonTextBox
            // 
            this.JsonTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.JsonTextBox.Location = new System.Drawing.Point(0, 0);
            this.JsonTextBox.Name = "JsonTextBox";
            this.JsonTextBox.Size = new System.Drawing.Size(550, 566);
            this.JsonTextBox.TabIndex = 2;
            this.JsonTextBox.Text = "";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 41);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.JsonDataGrid);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.JsonTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(1096, 566);
            this.splitContainer1.SplitterDistance = 542;
            this.splitContainer1.TabIndex = 3;
            // 
            // SaveFromTableButton
            // 
            this.SaveFromTableButton.Location = new System.Drawing.Point(152, 12);
            this.SaveFromTableButton.Name = "SaveFromTableButton";
            this.SaveFromTableButton.Size = new System.Drawing.Size(150, 23);
            this.SaveFromTableButton.TabIndex = 4;
            this.SaveFromTableButton.Text = "Сохранить из таблицы";
            this.SaveFromTableButton.UseVisualStyleBackColor = true;
            this.SaveFromTableButton.Click += new System.EventHandler(this.SaveFromTableButton_Click);
            // 
            // SaveFromTextboxButton
            // 
            this.SaveFromTextboxButton.Location = new System.Drawing.Point(308, 12);
            this.SaveFromTextboxButton.Name = "SaveFromTextboxButton";
            this.SaveFromTextboxButton.Size = new System.Drawing.Size(219, 23);
            this.SaveFromTextboxButton.TabIndex = 4;
            this.SaveFromTextboxButton.Text = "Сохранить из текстового редактора";
            this.SaveFromTextboxButton.UseVisualStyleBackColor = true;
            this.SaveFromTextboxButton.Click += new System.EventHandler(this.SaveFromTextboxButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 619);
            this.Controls.Add(this.SaveFromTextboxButton);
            this.Controls.Add(this.SaveFromTableButton);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.OpenFileButton);
            this.Name = "Form1";
            this.Text = "NPP Topaz Test Exesize";
            ((System.ComponentModel.ISupportInitialize)(this.JsonDataGrid)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button OpenFileButton;
        private DataGridView JsonDataGrid;
        private RichTextBox JsonTextBox;
        private DataGridViewTextBoxColumn nameColumn;
        private DataGridViewTextBoxColumn valueColumn;
        private DataGridViewTextBoxColumn groupColumn;
        private SplitContainer splitContainer1;
        private Button SaveFromTableButton;
        private Button SaveFromTextboxButton;
    }
}