namespace baterias
{
    partial class princial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(princial));
            this.dataGridViewbat = new System.Windows.Forms.DataGridView();
            this.txtBat = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnpesquisa = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewbat)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewbat
            // 
            this.dataGridViewbat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewbat.Location = new System.Drawing.Point(63, 164);
            this.dataGridViewbat.Name = "dataGridViewbat";
            this.dataGridViewbat.Size = new System.Drawing.Size(637, 225);
            this.dataGridViewbat.TabIndex = 0;
            this.dataGridViewbat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewbat_CellContentClick);
            // 
            // txtBat
            // 
            this.txtBat.BorderRadius = 10;
            this.txtBat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBat.DefaultText = "";
            this.txtBat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBat.DisabledState.Parent = this.txtBat;
            this.txtBat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBat.FocusedState.Parent = this.txtBat;
            this.txtBat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBat.ForeColor = System.Drawing.Color.Black;
            this.txtBat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBat.HoverState.Parent = this.txtBat;
            this.txtBat.Location = new System.Drawing.Point(63, 78);
            this.txtBat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBat.Name = "txtBat";
            this.txtBat.PasswordChar = '\0';
            this.txtBat.PlaceholderText = "";
            this.txtBat.SelectedText = "";
            this.txtBat.ShadowDecoration.Parent = this.txtBat;
            this.txtBat.Size = new System.Drawing.Size(501, 39);
            this.txtBat.TabIndex = 2;
            this.txtBat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBat_KeyDown);
            // 
            // btnpesquisa
            // 
            this.btnpesquisa.BorderRadius = 15;
            this.btnpesquisa.CheckedState.Parent = this.btnpesquisa;
            this.btnpesquisa.CustomImages.Parent = this.btnpesquisa;
            this.btnpesquisa.FillColor = System.Drawing.Color.Red;
            this.btnpesquisa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpesquisa.ForeColor = System.Drawing.Color.White;
            this.btnpesquisa.HoverState.Parent = this.btnpesquisa;
            this.btnpesquisa.Location = new System.Drawing.Point(595, 78);
            this.btnpesquisa.Name = "btnpesquisa";
            this.btnpesquisa.ShadowDecoration.Parent = this.btnpesquisa;
            this.btnpesquisa.Size = new System.Drawing.Size(105, 39);
            this.btnpesquisa.TabIndex = 6;
            this.btnpesquisa.Text = "Pesquisar";
            this.btnpesquisa.Click += new System.EventHandler(this.btnpesquisa_Click);
            // 
            // princial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnpesquisa);
            this.Controls.Add(this.txtBat);
            this.Controls.Add(this.dataGridViewbat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "princial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewbat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewbat;
        private Guna.UI2.WinForms.Guna2TextBox txtBat;
        private Guna.UI2.WinForms.Guna2Button btnpesquisa;
    }
}