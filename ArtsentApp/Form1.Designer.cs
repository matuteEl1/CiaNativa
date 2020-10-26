namespace ArtsentApp
{
    partial class frmStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStock));
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.chkDesc = new System.Windows.Forms.CheckBox();
            this.btnImportar = new System.Windows.Forms.Button();
            this.lblDisponible = new System.Windows.Forms.Label();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.lblCodDesc = new System.Windows.Forms.Label();
            this.chkDescripcion = new System.Windows.Forms.CheckBox();
            this.tblEncabezado = new System.Windows.Forms.TableLayoutPanel();
            this.picImagenArtsent = new System.Windows.Forms.PictureBox();
            this.btnRefresh = new ArtsentApp.Custom_Controls.RoundButton();
            this.tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.tblEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagenArtsent)).BeginInit();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblMain.BackColor = System.Drawing.Color.White;
            this.tblMain.CausesValidation = false;
            this.tblMain.ColumnCount = 1;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Controls.Add(this.dgvStock, 0, 4);
            this.tblMain.Controls.Add(this.chkDesc, 0, 1);
            this.tblMain.Controls.Add(this.btnImportar, 0, 6);
            this.tblMain.Controls.Add(this.lblDisponible, 0, 5);
            this.tblMain.Controls.Add(this.cboProducto, 0, 2);
            this.tblMain.Controls.Add(this.lblCodDesc, 0, 3);
            this.tblMain.Controls.Add(this.tblEncabezado, 0, 0);
            this.tblMain.Location = new System.Drawing.Point(4, 3);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 7;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.23324F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.040098F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.554622F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.722689F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.57143F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.193144F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.64187F));
            this.tblMain.Size = new System.Drawing.Size(988, 595);
            this.tblMain.TabIndex = 0;
            this.tblMain.Tag = "Elija producto";
            // 
            // dgvStock
            // 
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.AllowUserToOrderColumns = true;
            this.dgvStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStock.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvStock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvStock.CausesValidation = false;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Location = new System.Drawing.Point(3, 207);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStock.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStock.RowHeadersVisible = false;
            this.dgvStock.RowHeadersWidth = 62;
            this.dgvStock.RowTemplate.Height = 28;
            this.dgvStock.Size = new System.Drawing.Size(982, 283);
            this.dgvStock.TabIndex = 1;
            // 
            // chkDesc
            // 
            this.chkDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.chkDesc.AutoSize = true;
            this.chkDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDesc.Location = new System.Drawing.Point(3, 87);
            this.chkDesc.Name = "chkDesc";
            this.chkDesc.Size = new System.Drawing.Size(209, 35);
            this.chkDesc.TabIndex = 4;
            this.chkDesc.Text = "buscar por descripcion";
            this.chkDesc.UseVisualStyleBackColor = true;
            this.chkDesc.CheckedChanged += new System.EventHandler(this.chkDesc_CheckedChanged);
            // 
            // btnImportar
            // 
            this.btnImportar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnImportar.BackgroundImage = global::ArtsentApp.Properties.Resources.importar;
            this.btnImportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImportar.Location = new System.Drawing.Point(3, 539);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(49, 52);
            this.btnImportar.TabIndex = 3;
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // lblDisponible
            // 
            this.lblDisponible.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDisponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisponible.ForeColor = System.Drawing.Color.Red;
            this.lblDisponible.Location = new System.Drawing.Point(201, 497);
            this.lblDisponible.Name = "lblDisponible";
            this.lblDisponible.Size = new System.Drawing.Size(585, 33);
            this.lblDisponible.TabIndex = 5;
            this.lblDisponible.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboProducto
            // 
            this.cboProducto.AllowDrop = true;
            this.cboProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboProducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboProducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboProducto.BackColor = System.Drawing.Color.Silver;
            this.cboProducto.DropDownHeight = 100;
            this.cboProducto.DropDownWidth = 100;
            this.cboProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProducto.IntegralHeight = false;
            this.cboProducto.Location = new System.Drawing.Point(194, 130);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(600, 28);
            this.cboProducto.TabIndex = 0;
            this.cboProducto.SelectionChangeCommitted += new System.EventHandler(this.cboProducto_SelectionChangeCommitted);
            this.cboProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboProducto_KeyPress);
            // 
            // lblCodDesc
            // 
            this.lblCodDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCodDesc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCodDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodDesc.Location = new System.Drawing.Point(207, 168);
            this.lblCodDesc.Name = "lblCodDesc";
            this.lblCodDesc.Size = new System.Drawing.Size(573, 32);
            this.lblCodDesc.TabIndex = 6;
            this.lblCodDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkDescripcion
            // 
            this.chkDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkDescripcion.AutoSize = true;
            this.chkDescripcion.FlatAppearance.BorderSize = 2;
            this.chkDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDescripcion.Location = new System.Drawing.Point(399, 113);
            this.chkDescripcion.Margin = new System.Windows.Forms.Padding(5);
            this.chkDescripcion.Name = "chkDescripcion";
            this.chkDescripcion.Size = new System.Drawing.Size(181, 22);
            this.chkDescripcion.TabIndex = 4;
            this.chkDescripcion.Text = "filtrar por descripcion";
            this.chkDescripcion.UseVisualStyleBackColor = true;
            // 
            // tblEncabezado
            // 
            this.tblEncabezado.ColumnCount = 3;
            this.tblEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tblEncabezado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblEncabezado.Controls.Add(this.btnRefresh, 2, 0);
            this.tblEncabezado.Controls.Add(this.picImagenArtsent, 1, 0);
            this.tblEncabezado.Location = new System.Drawing.Point(3, 3);
            this.tblEncabezado.Name = "tblEncabezado";
            this.tblEncabezado.RowCount = 1;
            this.tblEncabezado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblEncabezado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblEncabezado.Size = new System.Drawing.Size(982, 78);
            this.tblEncabezado.TabIndex = 7;
            // 
            // picImagenArtsent
            // 
            this.picImagenArtsent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picImagenArtsent.BackgroundImage = global::ArtsentApp.Properties.Resources.NativaDesc;
            this.picImagenArtsent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picImagenArtsent.Location = new System.Drawing.Point(101, 3);
            this.picImagenArtsent.Name = "picImagenArtsent";
            this.picImagenArtsent.Size = new System.Drawing.Size(779, 72);
            this.picImagenArtsent.TabIndex = 4;
            this.picImagenArtsent.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.Black;
            this.btnRefresh.BackgroundImage = global::ArtsentApp.Properties.Resources.refrezcar;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.Location = new System.Drawing.Point(886, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(93, 72);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmStock
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(988, 599);
            this.Controls.Add(this.tblMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStock";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Stock Consolidado";
            this.Load += new System.EventHandler(this.frmStock_Load);
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.tblEncabezado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImagenArtsent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.CheckBox chkDescripcion;
        private System.Windows.Forms.CheckBox chkDesc;
        private System.Windows.Forms.Label lblDisponible;
        private System.Windows.Forms.Label lblCodDesc;
        private System.Windows.Forms.TableLayoutPanel tblEncabezado;
        private Custom_Controls.RoundButton btnRefresh;
        private System.Windows.Forms.PictureBox picImagenArtsent;
    }
}

