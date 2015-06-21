namespace HainthemePlaceholdit
{
    partial class MainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.folderBrowserDialog_images = new System.Windows.Forms.FolderBrowserDialog();
            this.button_pickfoder = new System.Windows.Forms.Button();
            this.textBox_path = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStrip_option = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.themeColorPickerToolStripSplitButton_bgcolor = new ExHtmlEditor.ColorPicker.ThemeColorPickerToolStripSplitButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.themeColorPickerToolStripSplitButton_txtcolor = new ExHtmlEditor.ColorPicker.ThemeColorPickerToolStripSplitButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox_text = new System.Windows.Forms.ToolStripTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_start = new System.Windows.Forms.Button();
            this.label_status = new System.Windows.Forms.Label();
            this.progressBar_status = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_images = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.toolStrip_option.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_images)).BeginInit();
            this.SuspendLayout();
            // 
            // button_pickfoder
            // 
            this.button_pickfoder.Location = new System.Drawing.Point(390, 17);
            this.button_pickfoder.Margin = new System.Windows.Forms.Padding(4);
            this.button_pickfoder.Name = "button_pickfoder";
            this.button_pickfoder.Size = new System.Drawing.Size(99, 28);
            this.button_pickfoder.TabIndex = 0;
            this.button_pickfoder.Text = "Browser";
            this.button_pickfoder.UseVisualStyleBackColor = true;
            this.button_pickfoder.Click += new System.EventHandler(this.button_pickfoder_Click);
            // 
            // textBox_path
            // 
            this.textBox_path.Location = new System.Drawing.Point(12, 20);
            this.textBox_path.Name = "textBox_path";
            this.textBox_path.Size = new System.Drawing.Size(371, 23);
            this.textBox_path.TabIndex = 1;
            this.textBox_path.TextChanged += new System.EventHandler(this.textBox_path_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.toolStrip_option);
            this.groupBox1.Location = new System.Drawing.Point(13, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 60);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Option";
            // 
            // toolStrip_option
            // 
            this.toolStrip_option.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStrip_option.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.themeColorPickerToolStripSplitButton_bgcolor,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.toolStripLabel2,
            this.themeColorPickerToolStripSplitButton_txtcolor,
            this.toolStripSeparator3,
            this.toolStripSeparator4,
            this.toolStripLabel3,
            this.toolStripTextBox_text});
            this.toolStrip_option.Location = new System.Drawing.Point(3, 19);
            this.toolStrip_option.Name = "toolStrip_option";
            this.toolStrip_option.Size = new System.Drawing.Size(470, 25);
            this.toolStrip_option.TabIndex = 0;
            this.toolStrip_option.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(50, 22);
            this.toolStripLabel1.Text = "BgColor";
            // 
            // themeColorPickerToolStripSplitButton_bgcolor
            // 
            this.themeColorPickerToolStripSplitButton_bgcolor.Color = System.Drawing.Color.LightGray;
            this.themeColorPickerToolStripSplitButton_bgcolor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.themeColorPickerToolStripSplitButton_bgcolor.Image = ((System.Drawing.Image)(resources.GetObject("themeColorPickerToolStripSplitButton_bgcolor.Image")));
            this.themeColorPickerToolStripSplitButton_bgcolor.ImageHeight = 16;
            this.themeColorPickerToolStripSplitButton_bgcolor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.themeColorPickerToolStripSplitButton_bgcolor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.themeColorPickerToolStripSplitButton_bgcolor.ImageWidth = 32;
            this.themeColorPickerToolStripSplitButton_bgcolor.Name = "themeColorPickerToolStripSplitButton_bgcolor";
            this.themeColorPickerToolStripSplitButton_bgcolor.Size = new System.Drawing.Size(48, 22);
            this.themeColorPickerToolStripSplitButton_bgcolor.Text = "themeColorPickerToolStripSplitButton1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(52, 22);
            this.toolStripLabel2.Text = "TxtColor";
            // 
            // themeColorPickerToolStripSplitButton_txtcolor
            // 
            this.themeColorPickerToolStripSplitButton_txtcolor.Color = System.Drawing.Color.Gray;
            this.themeColorPickerToolStripSplitButton_txtcolor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.themeColorPickerToolStripSplitButton_txtcolor.Image = ((System.Drawing.Image)(resources.GetObject("themeColorPickerToolStripSplitButton_txtcolor.Image")));
            this.themeColorPickerToolStripSplitButton_txtcolor.ImageHeight = 16;
            this.themeColorPickerToolStripSplitButton_txtcolor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.themeColorPickerToolStripSplitButton_txtcolor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.themeColorPickerToolStripSplitButton_txtcolor.ImageWidth = 32;
            this.themeColorPickerToolStripSplitButton_txtcolor.Name = "themeColorPickerToolStripSplitButton_txtcolor";
            this.themeColorPickerToolStripSplitButton_txtcolor.Size = new System.Drawing.Size(48, 22);
            this.themeColorPickerToolStripSplitButton_txtcolor.Text = "themeColorPickerToolStripSplitButton2";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(29, 22);
            this.toolStripLabel3.Text = "Text";
            // 
            // toolStripTextBox_text
            // 
            this.toolStripTextBox_text.Name = "toolStripTextBox_text";
            this.toolStripTextBox_text.Size = new System.Drawing.Size(200, 25);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_start);
            this.groupBox2.Controls.Add(this.label_status);
            this.groupBox2.Controls.Add(this.progressBar_status);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dataGridView_images);
            this.groupBox2.Location = new System.Drawing.Point(16, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 260);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DoInBackground";
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(374, 56);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(90, 32);
            this.button_start.TabIndex = 4;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(58, 65);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(28, 17);
            this.label_status.TabIndex = 3;
            this.label_status.Text = "0/0";
            // 
            // progressBar_status
            // 
            this.progressBar_status.Location = new System.Drawing.Point(61, 27);
            this.progressBar_status.Name = "progressBar_status";
            this.progressBar_status.Size = new System.Drawing.Size(403, 23);
            this.progressBar_status.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Status";
            // 
            // dataGridView_images
            // 
            this.dataGridView_images.AllowUserToAddRows = false;
            this.dataGridView_images.AllowUserToDeleteRows = false;
            this.dataGridView_images.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_images.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_images.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView_images.Location = new System.Drawing.Point(6, 95);
            this.dataGridView_images.Name = "dataGridView_images";
            this.dataGridView_images.ReadOnly = true;
            this.dataGridView_images.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_images.Size = new System.Drawing.Size(458, 159);
            this.dataGridView_images.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Name";
            this.Column1.FillWeight = 120F;
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Size";
            this.Column2.FillWeight = 80F;
            this.Column2.HeaderText = "Size";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 389);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox_path);
            this.Controls.Add(this.button_pickfoder);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(511, 422);
            this.MinimumSize = new System.Drawing.Size(511, 422);
            this.Name = "MainFrm";
            this.Text = "Haintheme Placeholdit tool";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip_option.ResumeLayout(false);
            this.toolStrip_option.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_images)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_images;
        private System.Windows.Forms.Button button_pickfoder;
        private System.Windows.Forms.TextBox textBox_path;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip toolStrip_option;
        private ExHtmlEditor.ColorPicker.ThemeColorPickerToolStripSplitButton themeColorPickerToolStripSplitButton_bgcolor;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private ExHtmlEditor.ColorPicker.ThemeColorPickerToolStripSplitButton themeColorPickerToolStripSplitButton_txtcolor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox_text;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView_images;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar_status;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

