
namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.markaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rejestracjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zdjecieDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.klientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.pojazdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wypozyczalniaDataSet = new WindowsFormsApp2.WypozyczalniaDataSet();
            this.pojazdTableAdapter = new WindowsFormsApp2.WypozyczalniaDataSetTableAdapters.pojazdTableAdapter();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Tabela = new System.Windows.Forms.ToolStripMenuItem();
            this.gToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.klienciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwisko = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klientTableAdapter = new WindowsFormsApp2.WypozyczalniaDataSetTableAdapters.klientTableAdapter();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dodaj = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.cena = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pojazdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wypozyczalniaDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.markaDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.rejestracjaDataGridViewTextBoxColumn,
            this.cenaDataGridViewTextBoxColumn,
            this.zdjecieDataGridViewImageColumn,
            this.klientDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pojazdBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // markaDataGridViewTextBoxColumn
            // 
            this.markaDataGridViewTextBoxColumn.DataPropertyName = "marka";
            this.markaDataGridViewTextBoxColumn.HeaderText = "marka";
            this.markaDataGridViewTextBoxColumn.Name = "markaDataGridViewTextBoxColumn";
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            // 
            // rejestracjaDataGridViewTextBoxColumn
            // 
            this.rejestracjaDataGridViewTextBoxColumn.DataPropertyName = "rejestracja";
            this.rejestracjaDataGridViewTextBoxColumn.HeaderText = "rejestracja";
            this.rejestracjaDataGridViewTextBoxColumn.Name = "rejestracjaDataGridViewTextBoxColumn";
            // 
            // cenaDataGridViewTextBoxColumn
            // 
            this.cenaDataGridViewTextBoxColumn.DataPropertyName = "cena";
            this.cenaDataGridViewTextBoxColumn.HeaderText = "cena";
            this.cenaDataGridViewTextBoxColumn.Name = "cenaDataGridViewTextBoxColumn";
            // 
            // zdjecieDataGridViewImageColumn
            // 
            this.zdjecieDataGridViewImageColumn.DataPropertyName = "zdjecie";
            this.zdjecieDataGridViewImageColumn.HeaderText = "zdjecie";
            this.zdjecieDataGridViewImageColumn.Name = "zdjecieDataGridViewImageColumn";
            // 
            // klientDataGridViewTextBoxColumn
            // 
            this.klientDataGridViewTextBoxColumn.DataPropertyName = "klient";
            this.klientDataGridViewTextBoxColumn.HeaderText = "klient";
            this.klientDataGridViewTextBoxColumn.Name = "klientDataGridViewTextBoxColumn";
            this.klientDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.klientDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // pojazdBindingSource
            // 
            this.pojazdBindingSource.DataMember = "pojazd";
            this.pojazdBindingSource.DataSource = this.wypozyczalniaDataSet;
            // 
            // wypozyczalniaDataSet
            // 
            this.wypozyczalniaDataSet.DataSetName = "WypozyczalniaDataSet";
            this.wypozyczalniaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pojazdTableAdapter
            // 
            this.pojazdTableAdapter.ClearBeforeFill = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(15, 422);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(111, 20);
            this.textBox3.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 406);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nr. rejestracyjny";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(15, 373);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(114, 20);
            this.textBox2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Model";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 325);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Marka";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tabela});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Tabela
            // 
            this.Tabela.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gToolStripMenuItem,
            this.klienciToolStripMenuItem});
            this.Tabela.Name = "Tabela";
            this.Tabela.Size = new System.Drawing.Size(52, 20);
            this.Tabela.Text = "Tabela";
            // 
            // gToolStripMenuItem
            // 
            this.gToolStripMenuItem.Name = "gToolStripMenuItem";
            this.gToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.gToolStripMenuItem.Text = "Pojazdy";
            this.gToolStripMenuItem.Click += new System.EventHandler(this.gToolStripMenuItem_Click);
            // 
            // klienciToolStripMenuItem
            // 
            this.klienciToolStripMenuItem.Name = "klienciToolStripMenuItem";
            this.klienciToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.klienciToolStripMenuItem.Text = "Klienci";
            this.klienciToolStripMenuItem.Click += new System.EventHandler(this.klienciToolStripMenuItem_Click_1);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nazwisko,
            this.imie,
            this.telefon});
            this.dataGridView2.DataSource = this.klientBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 71);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(643, 150);
            this.dataGridView2.TabIndex = 13;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazwisko
            // 
            this.nazwisko.DataPropertyName = "nazwisko";
            this.nazwisko.HeaderText = "nazwisko";
            this.nazwisko.Name = "nazwisko";
            // 
            // imie
            // 
            this.imie.DataPropertyName = "imie";
            this.imie.HeaderText = "imie";
            this.imie.Name = "imie";
            // 
            // telefon
            // 
            this.telefon.DataPropertyName = "telefon";
            this.telefon.HeaderText = "telefon";
            this.telefon.Name = "telefon";
            // 
            // klientBindingSource
            // 
            this.klientBindingSource.DataMember = "klient";
            this.klientBindingSource.DataSource = this.wypozyczalniaDataSet;
            // 
            // klientTableAdapter
            // 
            this.klientTableAdapter.ClearBeforeFill = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 227);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 37);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Usuń zaznaczony wiersz";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(130, 227);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 37);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Zapisz zmiany";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dodaj
            // 
            this.dodaj.Location = new System.Drawing.Point(157, 419);
            this.dodaj.Name = "dodaj";
            this.dodaj.Size = new System.Drawing.Size(75, 23);
            this.dodaj.TabIndex = 20;
            this.dodaj.Text = "Dodaj";
            this.dodaj.UseVisualStyleBackColor = true;
            this.dodaj.Click += new System.EventHandler(this.dodaj_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(172, 325);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 21;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // cena
            // 
            this.cena.AutoSize = true;
            this.cena.Location = new System.Drawing.Point(172, 306);
            this.cena.Name = "cena";
            this.cena.Size = new System.Drawing.Size(32, 13);
            this.cena.TabIndex = 22;
            this.cena.Text = "Cena";
            this.cena.Click += new System.EventHandler(this.cena_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cena);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.dodaj);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Form1";
            this.Text = "Database App";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pojazdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wypozyczalniaDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private WypozyczalniaDataSet wypozyczalniaDataSet;
        private System.Windows.Forms.BindingSource pojazdBindingSource;
        private WypozyczalniaDataSetTableAdapters.pojazdTableAdapter pojazdTableAdapter;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Tabela;
        private System.Windows.Forms.ToolStripMenuItem gToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem klienciToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource klientBindingSource;
        private WypozyczalniaDataSetTableAdapters.klientTableAdapter klientTableAdapter;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rejestracjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn zdjecieDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewLinkColumn klientDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button dodaj;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label cena;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwisko;
        private System.Windows.Forms.DataGridViewTextBoxColumn imie;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefon;
    }
}

