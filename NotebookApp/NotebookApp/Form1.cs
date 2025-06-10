using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotebookApp
{
    public partial class NoteTaker : Form
    {
        DataTable notes = new DataTable();
        bool editing = false;

        public NoteTaker()
        {
            InitializeComponent();
        }

        private void NoteTaker_Load(object sender, EventArgs e)
        {
            notes.Columns.Add("Title");
            notes.Columns.Add("Note");

            previousNotes.DataSource = notes;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            if (previousNotes.CurrentCell != null &&
        previousNotes.CurrentCell.RowIndex >= 0 &&
        notes.Rows.Count > previousNotes.CurrentCell.RowIndex)
            {
                int rowIndex = previousNotes.CurrentCell.RowIndex;
                titleBox.Text = notes.Rows[rowIndex].ItemArray[0].ToString();
                noteBox.Text = notes.Rows[rowIndex].ItemArray[1].ToString(); // not içeriği olduğunu varsayarsak
                editing = true;
            }
            else
            {
                MessageBox.Show("Yüklenecek bir not seçilmedi veya not listesi boş.",
                                "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (previousNotes.CurrentCell != null && previousNotes.Rows.Count > 0)
                {
                    int rowIndex = previousNotes.CurrentCell.RowIndex;

                    if (rowIndex >= 0 && rowIndex < notes.Rows.Count)
                    {
                        notes.Rows[rowIndex].Delete();
                    }
                    else
                    {
                        MessageBox.Show("Silinecek geçerli bir not seçili değil.");
                    }
                }
                else
                {
                    MessageBox.Show("Silinecek not bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            if (previousNotes.CurrentCell != null &&
        notes.Rows.Count > previousNotes.CurrentCell.RowIndex &&
        previousNotes.CurrentCell.RowIndex >= 0)
            {
                titleBox.Text = notes.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
                noteBox.Text = notes.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[1].ToString(); // Sanırım burası 1 olmalı, başlık ile not farklı olabilir
                editing = true;
            }
            else
            {
                MessageBox.Show("Yüklenebilecek not bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void newNoteButton_Click(object sender, EventArgs e)
        {
            titleBox.Text = "";
            noteBox.Text = "";
            editing = false;
        }

        private void previousNoteButton_Click(object sender, EventArgs e)
        {
            // DataTable'da en az 2 kayıt olup olmadığını kontrol etsin
            if (notes.Rows.Count < 2 || previousNotes.CurrentCell == null)
            {
                MessageBox.Show("Önceki not yok veya seçim yapılmamış.");
                return;
            }

            int currentIndex = previousNotes.CurrentCell.RowIndex;
            int previousIndex = currentIndex - 1;

            // previousIndex geçerli bir satır mı?
            if (previousIndex >= 0)
            {
                titleBox.Text = notes.Rows[previousIndex]["Title"].ToString();
                noteBox.Text = notes.Rows[previousIndex]["Note"].ToString();
                editing = true;

                previousNotes.CurrentCell = previousNotes.Rows[previousIndex].Cells[0];
            }
            else
            {
                MessageBox.Show("Daha önceki bir not bulunamadı.");
            }
        }

        private void previousNotes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && notes.Rows.Count > e.RowIndex)
            {
                titleBox.Text = notes.Rows[e.RowIndex].ItemArray[0].ToString();
                noteBox.Text = notes.Rows[e.RowIndex].ItemArray[1].ToString(); // Not kısmı olduğunu varsayarsak 1. sütun
                editing = true;
            }
            else
            {
                MessageBox.Show("Geçerli bir not seçilmedi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
