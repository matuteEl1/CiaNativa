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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStock));
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new ArtsentApp.Custom_Controls.RoundButton();
            this.tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblMain.AutoSize = true;
            this.tblMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblMain.BackColor = System.Drawing.Color.Azure;
            this.tblMain.BackgroundImage = global::ArtsentApp.Properties.Resources.NativaDesc;
            this.tblMain.CausesValidation = false;
            this.tblMain.ColumnCount = 1;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Controls.Add(this.cboProducto, 0, 1);
            this.tblMain.Controls.Add(this.dgvStock, 0, 2);
            this.tblMain.Controls.Add(this.btnRefresh, 0, 0);
            this.tblMain.Location = new System.Drawing.Point(4, 3);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 3;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.58108F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.783784F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.46622F));
            this.tblMain.Size = new System.Drawing.Size(979, 591);
            this.tblMain.TabIndex = 0;
            this.tblMain.Tag = "Elija producto";
            // 
            // cboProducto
            // 
            this.cboProducto.AllowDrop = true;
            this.cboProducto.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cboProducto.BackColor = System.Drawing.Color.Silver;
            this.cboProducto.DropDownHeight = 15;
            this.cboProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProducto.DropDownWidth = 100;
            this.cboProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProducto.IntegralHeight = false;
            this.cboProducto.Location = new System.Drawing.Point(189, 119);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(600, 38);
            this.cboProducto.TabIndex = 0;
            this.cboProducto.SelectedIndexChanged += new System.EventHandler(this.cboProducto_SelectedIndexChanged);
            // 
            // dgvStock
            // 
            this.dgvStock.AllowUserToOrderColumns = true;
            this.dgvStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStock.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvStock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvStock.CausesValidation = false;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Location = new System.Drawing.Point(3, 163);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.RowHeadersWidth = 62;
            this.dgvStock.RowTemplate.Height = 28;
            this.dgvStock.Size = new System.Drawing.Size(973, 425);
            this.dgvStock.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRefresh.BackColor = System.Drawing.Color.Black;
            this.btnRefresh.BackgroundImage = global::ArtsentApp.Properties.Resources.refrezcar;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.Location = new System.Drawing.Point(885, 13);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(91, 82);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.UseVisualStyleBackColor = false;
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
            this.tblMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.DataGridView dgvStock;
        private Custom_Controls.RoundButton btnRefresh;
    }
}

