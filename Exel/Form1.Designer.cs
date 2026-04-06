namespace Exel
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
            dataGridView1 = new DataGridView();
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            listBox2 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(903, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(330, 305);
            dataGridView1.TabIndex = 0;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(351, 292);
            listBox1.TabIndex = 3;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(12, 341);
            button1.Name = "button1";
            button1.Size = new Size(331, 97);
            button1.TabIndex = 4;
            button1.Text = "Укажите эксель документ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button2.Location = new Point(395, 341);
            button2.Name = "button2";
            button2.Size = new Size(331, 97);
            button2.TabIndex = 5;
            button2.Text = "Добавить еще эксель документ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listBox2
            // 
            listBox2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(440, 12);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(351, 292);
            listBox2.TabIndex = 6;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // Form1
            // 
            ClientSize = new Size(1407, 470);
            Controls.Add(listBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ListBox listBox1;
        private Button button1;
        private Button button2;
        private ListBox listBox2;
    }
}
