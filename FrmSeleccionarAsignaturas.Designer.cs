
namespace AsesoriasPascualBravo
{
    partial class FrmSeleccionarAsignaturas
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbAsignaturas = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnAgregarAsignatura = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.asignaturas_UIPascualBravoDataSet = new AsesoriasPascualBravo.Asignaturas_UIPascualBravoDataSet();
            this.tblAsignaturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_AsignaturasTableAdapter = new AsesoriasPascualBravo.Asignaturas_UIPascualBravoDataSetTableAdapters.tbl_AsignaturasTableAdapter();
            this.DgvAsignaturas = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignaturas_UIPascualBravoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAsignaturasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAsignaturas)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbAsignaturas
            // 
            this.cmbAsignaturas.DataSource = this.tblAsignaturasBindingSource;
            this.cmbAsignaturas.DisplayMember = "Nombre";
            this.cmbAsignaturas.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.cmbAsignaturas.FormattingEnabled = true;
            this.cmbAsignaturas.Location = new System.Drawing.Point(3, 37);
            this.cmbAsignaturas.Name = "cmbAsignaturas";
            this.cmbAsignaturas.Size = new System.Drawing.Size(214, 27);
            this.cmbAsignaturas.TabIndex = 0;
            this.cmbAsignaturas.ValueMember = "IdRows";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnAgregarAsignatura);
            this.panel2.Controls.Add(this.materialLabel1);
            this.panel2.Controls.Add(this.cmbAsignaturas);
            this.panel2.Location = new System.Drawing.Point(5, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(790, 77);
            this.panel2.TabIndex = 1;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(7, 15);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(172, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Asignaturas Disponibles";
            // 
            // btnAgregarAsignatura
            // 
            this.btnAgregarAsignatura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.btnAgregarAsignatura.FlatAppearance.BorderSize = 0;
            this.btnAgregarAsignatura.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarAsignatura.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarAsignatura.ForeColor = System.Drawing.Color.DarkGray;
            this.btnAgregarAsignatura.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnAgregarAsignatura.IconColor = System.Drawing.Color.DarkGray;
            this.btnAgregarAsignatura.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnAgregarAsignatura.IconSize = 20;
            this.btnAgregarAsignatura.Location = new System.Drawing.Point(246, 37);
            this.btnAgregarAsignatura.Name = "btnAgregarAsignatura";
            this.btnAgregarAsignatura.Padding = new System.Windows.Forms.Padding(30, 0, 20, 0);
            this.btnAgregarAsignatura.Size = new System.Drawing.Size(207, 27);
            this.btnAgregarAsignatura.TabIndex = 8;
            this.btnAgregarAsignatura.Text = "Agregar Asignatura";
            this.btnAgregarAsignatura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarAsignatura.UseVisualStyleBackColor = false;
            this.btnAgregarAsignatura.Click += new System.EventHandler(this.btnAgregarAsignatura_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::AsesoriasPascualBravo.Properties.Resources.pb;
            this.pictureBox1.Location = new System.Drawing.Point(652, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // asignaturas_UIPascualBravoDataSet
            // 
            this.asignaturas_UIPascualBravoDataSet.DataSetName = "Asignaturas_UIPascualBravoDataSet";
            this.asignaturas_UIPascualBravoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblAsignaturasBindingSource
            // 
            this.tblAsignaturasBindingSource.DataMember = "tbl_Asignaturas";
            this.tblAsignaturasBindingSource.DataSource = this.asignaturas_UIPascualBravoDataSet;
            // 
            // tbl_AsignaturasTableAdapter
            // 
            this.tbl_AsignaturasTableAdapter.ClearBeforeFill = true;
            // 
            // DgvAsignaturas
            // 
            this.DgvAsignaturas.AllowUserToAddRows = false;
            this.DgvAsignaturas.AllowUserToDeleteRows = false;
            this.DgvAsignaturas.AllowUserToResizeColumns = false;
            this.DgvAsignaturas.AllowUserToResizeRows = false;
            this.DgvAsignaturas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvAsignaturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvAsignaturas.BackgroundColor = System.Drawing.Color.White;
            this.DgvAsignaturas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvAsignaturas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvAsignaturas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvAsignaturas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvAsignaturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvAsignaturas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.DgvAsignaturas.Location = new System.Drawing.Point(-1, 85);
            this.DgvAsignaturas.Name = "DgvAsignaturas";
            this.DgvAsignaturas.ReadOnly = true;
            this.DgvAsignaturas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvAsignaturas.RowHeadersVisible = false;
            this.DgvAsignaturas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.DgvAsignaturas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvAsignaturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvAsignaturas.Size = new System.Drawing.Size(796, 366);
            this.DgvAsignaturas.TabIndex = 36;
            // 
            // FrmSeleccionarAsignaturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DgvAsignaturas);
            this.Controls.Add(this.panel2);
            this.Name = "FrmSeleccionarAsignaturas";
            this.Text = "FrmSeleccionarAsignaturas";
            this.Load += new System.EventHandler(this.FrmSeleccionarAsignaturas_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignaturas_UIPascualBravoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAsignaturasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAsignaturas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbAsignaturas;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private FontAwesome.Sharp.IconButton btnAgregarAsignatura;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Asignaturas_UIPascualBravoDataSet asignaturas_UIPascualBravoDataSet;
        private System.Windows.Forms.BindingSource tblAsignaturasBindingSource;
        private Asignaturas_UIPascualBravoDataSetTableAdapters.tbl_AsignaturasTableAdapter tbl_AsignaturasTableAdapter;
        private System.Windows.Forms.DataGridView DgvAsignaturas;
    }
}