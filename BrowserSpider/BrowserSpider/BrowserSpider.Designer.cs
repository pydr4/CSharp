namespace BrowserSpider
{
    partial class browserSpiderFrm
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
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chromeDataGrid = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.fireFoxDataGrid = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.operaDataGrid = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chromeDataGrid)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fireFoxDataGrid)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.operaDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Browser History Viewer";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 58);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1122, 646);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chromeDataGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1114, 617);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Google Chrome History";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chromeDataGrid
            // 
            this.chromeDataGrid.AllowUserToAddRows = false;
            this.chromeDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.chromeDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chromeDataGrid.Location = new System.Drawing.Point(3, 3);
            this.chromeDataGrid.Name = "chromeDataGrid";
            this.chromeDataGrid.RowHeadersVisible = false;
            this.chromeDataGrid.RowTemplate.Height = 24;
            this.chromeDataGrid.Size = new System.Drawing.Size(1108, 611);
            this.chromeDataGrid.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.fireFoxDataGrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1114, 617);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "FireFox History";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // fireFoxDataGrid
            // 
            this.fireFoxDataGrid.AllowUserToAddRows = false;
            this.fireFoxDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.fireFoxDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fireFoxDataGrid.Location = new System.Drawing.Point(3, 3);
            this.fireFoxDataGrid.Name = "fireFoxDataGrid";
            this.fireFoxDataGrid.RowHeadersVisible = false;
            this.fireFoxDataGrid.RowTemplate.Height = 24;
            this.fireFoxDataGrid.Size = new System.Drawing.Size(1108, 611);
            this.fireFoxDataGrid.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.operaDataGrid);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1114, 617);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Opera History";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // operaDataGrid
            // 
            this.operaDataGrid.AllowUserToAddRows = false;
            this.operaDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.operaDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.operaDataGrid.Location = new System.Drawing.Point(3, 3);
            this.operaDataGrid.Name = "operaDataGrid";
            this.operaDataGrid.RowHeadersVisible = false;
            this.operaDataGrid.RowTemplate.Height = 24;
            this.operaDataGrid.Size = new System.Drawing.Size(1108, 611);
            this.operaDataGrid.TabIndex = 2;
            // 
            // browserSpiderFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 717);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "browserSpiderFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Browser Spider";
            this.Load += new System.EventHandler(this.browserSpiderFrm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chromeDataGrid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fireFoxDataGrid)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.operaDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView chromeDataGrid;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView fireFoxDataGrid;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView operaDataGrid;
    }
}

