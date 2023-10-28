namespace CandaIdea_Task
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.browseButton = new System.Windows.Forms.Button();
            this.dataGridViewFiles = new System.Windows.Forms.DataGridView();
            this.SearchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.WriteToTxtFileButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // browseButton
            // 
            this.browseButton.Font = new System.Drawing.Font("B Nazanin", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.browseButton.Location = new System.Drawing.Point(12, 308);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(137, 27);
            this.browseButton.TabIndex = 0;
            this.browseButton.Text = "Browse Folders Or Files";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // dataGridViewFiles
            // 
            this.dataGridViewFiles.AllowUserToAddRows = false;
            this.dataGridViewFiles.AllowUserToDeleteRows = false;
            this.dataGridViewFiles.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFiles.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridViewFiles.Location = new System.Drawing.Point(12, 130);
            this.dataGridViewFiles.MaximumSize = new System.Drawing.Size(800, 150);
            this.dataGridViewFiles.MinimumSize = new System.Drawing.Size(500, 150);
            this.dataGridViewFiles.Name = "dataGridViewFiles";
            this.dataGridViewFiles.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("B Nazanin", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFiles.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewFiles.RowHeadersVisible = false;
            this.dataGridViewFiles.RowHeadersWidth = 160;
            this.dataGridViewFiles.Size = new System.Drawing.Size(770, 150);
            this.dataGridViewFiles.TabIndex = 1;
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("B Nazanin", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.SearchButton.Location = new System.Drawing.Point(12, 87);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(137, 23);
            this.SearchButton.TabIndex = 0;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click_1);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(617, 55);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(151, 20);
            this.searchTextBox.TabIndex = 2;
            // 
            // WriteToTxtFileButton
            // 
            this.WriteToTxtFileButton.Location = new System.Drawing.Point(12, 361);
            this.WriteToTxtFileButton.Name = "WriteToTxtFileButton";
            this.WriteToTxtFileButton.Size = new System.Drawing.Size(137, 26);
            this.WriteToTxtFileButton.TabIndex = 3;
            this.WriteToTxtFileButton.Text = "TxtFile";
            this.WriteToTxtFileButton.UseVisualStyleBackColor = true;
            this.WriteToTxtFileButton.Click += new System.EventHandler(this.WriteToTxtFileButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.WriteToTxtFileButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.dataGridViewFiles);
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "Form1";
            this.Text = "Folder Browser Dialog";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.DataGridView dataGridViewFiles;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button WriteToTxtFileButton;
    }
}

