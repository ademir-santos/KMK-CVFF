namespace KMK_GUI.VIEWS.SUB_FORMS.FORM_PADRAO
{
    partial class IncluirProdutoModelo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCADProdutoSalvar = new System.Windows.Forms.Button();
            this.btnCADProdutoCancelar = new System.Windows.Forms.Button();
            this.btnCADProdutoNovo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnCADProdutoSalvar);
            this.panel1.Controls.Add(this.btnCADProdutoCancelar);
            this.panel1.Controls.Add(this.btnCADProdutoNovo);
            this.panel1.Location = new System.Drawing.Point(12, 269);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 86);
            this.panel1.TabIndex = 0;
            // 
            // btnCADProdutoSalvar
            // 
            this.btnCADProdutoSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCADProdutoSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnCADProdutoSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCADProdutoSalvar.Location = new System.Drawing.Point(143, 19);
            this.btnCADProdutoSalvar.Name = "btnCADProdutoSalvar";
            this.btnCADProdutoSalvar.Size = new System.Drawing.Size(95, 43);
            this.btnCADProdutoSalvar.TabIndex = 7;
            this.btnCADProdutoSalvar.Text = "Salvar";
            this.btnCADProdutoSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCADProdutoCancelar
            // 
            this.btnCADProdutoCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCADProdutoCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnCADProdutoCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCADProdutoCancelar.Location = new System.Drawing.Point(278, 19);
            this.btnCADProdutoCancelar.Name = "btnCADProdutoCancelar";
            this.btnCADProdutoCancelar.Size = new System.Drawing.Size(95, 43);
            this.btnCADProdutoCancelar.TabIndex = 6;
            this.btnCADProdutoCancelar.Text = "Cancelar";
            this.btnCADProdutoCancelar.UseVisualStyleBackColor = true;
            // 
            // btnCADProdutoNovo
            // 
            this.btnCADProdutoNovo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCADProdutoNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnCADProdutoNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCADProdutoNovo.Location = new System.Drawing.Point(15, 19);
            this.btnCADProdutoNovo.Name = "btnCADProdutoNovo";
            this.btnCADProdutoNovo.Size = new System.Drawing.Size(95, 43);
            this.btnCADProdutoNovo.TabIndex = 5;
            this.btnCADProdutoNovo.Text = "Novo";
            this.btnCADProdutoNovo.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(391, 247);
            this.panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 179);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Ingredientes";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(9, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(248, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingredientes";
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Location = new System.Drawing.Point(6, 22);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(369, 151);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // IncluirProdutoModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(416, 367);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IncluirProdutoModelo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IncluirProdutoModelo";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCADProdutoSalvar;
        private System.Windows.Forms.Button btnCADProdutoCancelar;
        private System.Windows.Forms.Button btnCADProdutoNovo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
    }
}