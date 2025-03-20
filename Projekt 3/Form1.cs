using System.CodeDom;

namespace Projekt_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        { }
            //zapis do pliku 
private void ExportToCSV(DataGridView dataGridView, string filePath)
        {
            // Tworzenie nag��wka pliku CSV
            string csvContent = "Column1,Column2,Column3" + Environment.NewLine;
            // Dodawanie danych z DataGridView
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                // Pomijaj wiersze niemieszcz�ce si� w DataGridView (np. wiersz zaznaczania)
                if (!row.IsNewRow)
                {
                    // Dodaj kolejne warto�ci w wierszu, oddzielone przecinkami
                    csvContent += string.Join(",", Array.ConvertAll(row.Cells.Cast<DataGridViewCell>()
                    .ToArray(), c => c.Value)) + Environment.NewLine;
                }
            }
            // Zapisanie zawarto�ci do pliku CSV
            File.WriteAllText(filePath, csvContent);
        }
    }
            

    }



