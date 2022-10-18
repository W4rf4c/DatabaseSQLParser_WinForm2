namespace DatabaseSQLParser_WinForm
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.query = new System.Windows.Forms.Button();
            this.Drives = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utvonal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kiolvas = new System.Windows.Forms.Button();
            this.cw = new System.Windows.Forms.Label();
            this.button_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Drives)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(398, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "Beolvasás";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(100, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(286, 23);
            this.comboBox1.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(64, 120);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(322, 222);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mappa:";
            // 
            // query
            // 
            this.query.Location = new System.Drawing.Point(713, 386);
            this.query.Name = "query";
            this.query.Size = new System.Drawing.Size(75, 23);
            this.query.TabIndex = 8;
            this.query.Text = "query";
            this.query.UseVisualStyleBackColor = true;
            this.query.Click += new System.EventHandler(this.query_Click);
            // 
            // Drives
            // 
            this.Drives.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Drives.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.utvonal});
            this.Drives.Location = new System.Drawing.Point(414, 120);
            this.Drives.Name = "Drives";
            this.Drives.RowTemplate.Height = 25;
            this.Drives.Size = new System.Drawing.Size(284, 222);
            this.Drives.TabIndex = 9;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // utvonal
            // 
            this.utvonal.HeaderText = "utvonal";
            this.utvonal.Name = "utvonal";
            // 
            // kiolvas
            // 
            this.kiolvas.Location = new System.Drawing.Point(713, 415);
            this.kiolvas.Name = "kiolvas";
            this.kiolvas.Size = new System.Drawing.Size(75, 23);
            this.kiolvas.TabIndex = 10;
            this.kiolvas.Text = "Kiolvas";
            this.kiolvas.UseVisualStyleBackColor = true;
            this.kiolvas.Click += new System.EventHandler(this.kiolvas_Click);
            // 
            // cw
            // 
            this.cw.AutoSize = true;
            this.cw.Location = new System.Drawing.Point(64, 386);
            this.cw.Name = "cw";
            this.cw.Size = new System.Drawing.Size(38, 15);
            this.cw.TabIndex = 11;
            this.cw.Text = "label1";
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(482, 54);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 12;
            this.button_delete.Text = "Törlés";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 453);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.cw);
            this.Controls.Add(this.kiolvas);
            this.Controls.Add(this.Drives);
            this.Controls.Add(this.query);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Drives)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private ComboBox comboBox1;
        private RichTextBox richTextBox1;
        private Label label2;
        private Button query;
        private DataGridView Drives;
        private Button kiolvas;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn utvonal;
        private Label cw;
        private Button button_delete;
    }
}