namespace Projekt_3
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
            button1 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            imie = new DataGridViewTextBoxColumn();
            nazwisko = new DataGridViewTextBoxColumn();
            wiek = new DataGridViewTextBoxColumn();
            stanowisko = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(622, 58);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "Dodaj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button7_Click;
            // 
            // button5
            // 
            button5.Location = new Point(622, 137);
            button5.Name = "button5";
            button5.Size = new Size(112, 34);
            button5.TabIndex = 4;
            button5.Text = "Usun";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button7_Click;
            // 
            // button6
            // 
            button6.Location = new Point(438, 353);
            button6.Name = "button6";
            button6.Size = new Size(154, 34);
            button6.TabIndex = 5;
            button6.Text = "odczyt z csv.";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(84, 353);
            button7.Name = "button7";
            button7.Size = new Size(151, 34);
            button7.TabIndex = 6;
            button7.Text = "Zapis do .csv";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, imie, nazwisko, wiek, stanowisko });
            dataGridView1.Location = new Point(84, 58);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(508, 258);
            dataGridView1.TabIndex = 7;
            // 
            // id
            // 
            id.HeaderText = "id";
            id.MinimumWidth = 8;
            id.Name = "id";
            id.Width = 40;
            // 
            // imie
            // 
            imie.HeaderText = "imie";
            imie.MinimumWidth = 8;
            imie.Name = "imie";
            // 
            // nazwisko
            // 
            nazwisko.HeaderText = "nazwisko";
            nazwisko.MinimumWidth = 8;
            nazwisko.Name = "nazwisko";
            // 
            // wiek
            // 
            wiek.HeaderText = "wiek";
            wiek.MinimumWidth = 8;
            wiek.Name = "wiek";
            // 
            // stanowisko
            // 
            stanowisko.HeaderText = "stanowisko";
            stanowisko.MinimumWidth = 8;
            stanowisko.Name = "stanowisko";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button5;
        private Button button6;
        private Button button7;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn imie;
        private DataGridViewTextBoxColumn nazwisko;
        private DataGridViewTextBoxColumn wiek;
        private DataGridViewTextBoxColumn stanowisko;
    }
}
