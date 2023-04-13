
namespace AsesoriasPascualBravo
{
    partial class FrmAgendarCita
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAgendar = new FontAwesome.Sharp.IconButton();
            this.dgvAsesoriasDisponibles = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsesoriasDisponibles)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnAgendar);
            this.panel1.Controls.Add(this.dgvAsesoriasDisponibles);
            this.panel1.Location = new System.Drawing.Point(4, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 477);
            this.panel1.TabIndex = 34;
            // 
            // btnAgendar
            // 
            this.btnAgendar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.btnAgendar.FlatAppearance.BorderSize = 0;
            this.btnAgendar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgendar.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendar.ForeColor = System.Drawing.Color.DarkGray;
            this.btnAgendar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnAgendar.IconColor = System.Drawing.Color.DarkGray;
            this.btnAgendar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnAgendar.IconSize = 15;
            this.btnAgendar.Location = new System.Drawing.Point(631, 11);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Padding = new System.Windows.Forms.Padding(30, 0, 20, 0);
            this.btnAgendar.Size = new System.Drawing.Size(131, 38);
            this.btnAgendar.TabIndex = 36;
            this.btnAgendar.Text = "Agendar";
            this.btnAgendar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgendar.UseVisualStyleBackColor = false;
            this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click);
            // 
            // dgvAsesoriasDisponibles
            // 
            this.dgvAsesoriasDisponibles.AllowUserToAddRows = false;
            this.dgvAsesoriasDisponibles.AllowUserToDeleteRows = false;
            this.dgvAsesoriasDisponibles.AllowUserToResizeColumns = false;
            this.dgvAsesoriasDisponibles.AllowUserToResizeRows = false;
            this.dgvAsesoriasDisponibles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAsesoriasDisponibles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAsesoriasDisponibles.BackgroundColor = System.Drawing.Color.White;
            this.dgvAsesoriasDisponibles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAsesoriasDisponibles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAsesoriasDisponibles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAsesoriasDisponibles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAsesoriasDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAsesoriasDisponibles.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.dgvAsesoriasDisponibles.Location = new System.Drawing.Point(11, 11);
            this.dgvAsesoriasDisponibles.Name = "dgvAsesoriasDisponibles";
            this.dgvAsesoriasDisponibles.ReadOnly = true;
            this.dgvAsesoriasDisponibles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAsesoriasDisponibles.RowHeadersVisible = false;
            this.dgvAsesoriasDisponibles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvAsesoriasDisponibles.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAsesoriasDisponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAsesoriasDisponibles.Size = new System.Drawing.Size(614, 456);
            this.dgvAsesoriasDisponibles.TabIndex = 35;
            this.dgvAsesoriasDisponibles.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAsesoriasDisponibles_CellMouseClick);
            // 
            // FrmAgendarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(772, 480);
            this.Controls.Add(this.panel1);
            this.Name = "FrmAgendarCita";
            this.Text = "Agendamientos";
            this.Load += new System.EventHandler(this.FrmAgendarCita_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsesoriasDisponibles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvAsesoriasDisponibles;
        private FontAwesome.Sharp.IconButton btnAgendar;
    }
}