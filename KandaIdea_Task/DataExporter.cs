using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace CandaIdea_Task
{
    public class DataExporter
    {
        public static void ExportToTxt(DataGridView dataGridView)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Text files|*.txt";
                    saveFileDialog.Title = "Save as text file";
                    saveFileDialog.FileName = "DataExport.txt";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                        {
                            for (int i = 0; i < dataGridView.Columns.Count; i++)
                            {
                                sw.Write(dataGridView.Columns[i].HeaderText);
                                if (i < dataGridView.Columns.Count - 1)
                                    sw.Write(","); // Separating columns with a comma
                            }
                            sw.WriteLine(); // End of header line

                            foreach (DataGridViewRow row in dataGridView.Rows)
                            {
                                for (int i = 0; i < dataGridView.Columns.Count; i++)
                                {
                                    if (row.Cells[i].Value != null)
                                    {
                                        sw.Write(row.Cells[i].Value.ToString());
                                    }

                                    if (i < dataGridView.Columns.Count - 1)
                                        sw.Write(","); // Separating columns with a comma
                                }
                                sw.WriteLine(); // End of record line
                            }
                        }

                        MessageBox.Show("Data exported successfully!", "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting data: " + ex.Message, "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

