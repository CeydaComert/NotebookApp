namespace NotebookApp
{
    partial class NoteTaker
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.noteBox = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.note = new System.Windows.Forms.Label();
            this.previousNoteButton = new System.Windows.Forms.Button();
            this.newNoteButton = new System.Windows.Forms.Button();
            this.previousNotes = new System.Windows.Forms.DataGridView();
            this.saveButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.previousNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(12, 42);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(340, 22);
            this.titleBox.TabIndex = 0;
            // 
            // noteBox
            // 
            this.noteBox.Location = new System.Drawing.Point(12, 93);
            this.noteBox.Multiline = true;
            this.noteBox.Name = "noteBox";
            this.noteBox.Size = new System.Drawing.Size(340, 487);
            this.noteBox.TabIndex = 1;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("MV Boli", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(13, 13);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(64, 23);
            this.title.TabIndex = 2;
            this.title.Text = "Başlık";
            // 
            // note
            // 
            this.note.AutoSize = true;
            this.note.Font = new System.Drawing.Font("MV Boli", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.note.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.note.Location = new System.Drawing.Point(13, 67);
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(55, 23);
            this.note.TabIndex = 3;
            this.note.Text = "Not:";
            // 
            // previousNoteButton
            // 
            this.previousNoteButton.Location = new System.Drawing.Point(12, 586);
            this.previousNoteButton.Name = "previousNoteButton";
            this.previousNoteButton.Size = new System.Drawing.Size(120, 37);
            this.previousNoteButton.TabIndex = 4;
            this.previousNoteButton.Text = "Önceki Not";
            this.previousNoteButton.UseVisualStyleBackColor = true;
            this.previousNoteButton.Click += new System.EventHandler(this.previousNoteButton_Click);
            // 
            // newNoteButton
            // 
            this.newNoteButton.Location = new System.Drawing.Point(232, 586);
            this.newNoteButton.Name = "newNoteButton";
            this.newNoteButton.Size = new System.Drawing.Size(120, 37);
            this.newNoteButton.TabIndex = 5;
            this.newNoteButton.Text = "Yeni Not";
            this.newNoteButton.UseVisualStyleBackColor = true;
            this.newNoteButton.Click += new System.EventHandler(this.newNoteButton_Click);
            // 
            // previousNotes
            // 
            this.previousNotes.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.previousNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.previousNotes.DefaultCellStyle = dataGridViewCellStyle1;
            this.previousNotes.Location = new System.Drawing.Point(374, 12);
            this.previousNotes.Name = "previousNotes";
            this.previousNotes.RowHeadersWidth = 51;
            this.previousNotes.RowTemplate.Height = 24;
            this.previousNotes.Size = new System.Drawing.Size(339, 438);
            this.previousNotes.TabIndex = 6;
            this.previousNotes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.previousNotes_CellDoubleClick);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(374, 456);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(194, 37);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Kaydet";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(374, 499);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(194, 37);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Sil";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(374, 542);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(194, 37);
            this.loadButton.TabIndex = 9;
            this.loadButton.Text = "Aç";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // NoteTaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(725, 635);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.previousNotes);
            this.Controls.Add(this.newNoteButton);
            this.Controls.Add(this.previousNoteButton);
            this.Controls.Add(this.note);
            this.Controls.Add(this.title);
            this.Controls.Add(this.noteBox);
            this.Controls.Add(this.titleBox);
            this.Name = "NoteTaker";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.NoteTaker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.previousNotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.TextBox noteBox;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label note;
        private System.Windows.Forms.Button previousNoteButton;
        private System.Windows.Forms.Button newNoteButton;
        private System.Windows.Forms.DataGridView previousNotes;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button loadButton;
    }
}

