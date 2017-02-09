namespace KMK_GUI.VIEWS.SUB_FORMS.PRODUTO
{
    partial class SubCategoriaProdutoForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCADSubCatSubCategoria = new System.Windows.Forms.TextBox();
            this.cbboxCADSubCatCategoria = new System.Windows.Forms.ComboBox();
            this.btnCADSubCatProdNovo = new System.Windows.Forms.Button();
            this.btnCADSubCatProdSair = new System.Windows.Forms.Button();
            this.btnCADSubCatProdCancelar = new System.Windows.Forms.Button();
            this.btnCADSubCatProdSalvar = new System.Windows.Forms.Button();
            this.dtgrMDCADSubCategoria = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCADSubCatProdPesquisa = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrMDCADSubCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtCADSubCatSubCategoria);
            this.panel1.Controls.Add(this.cbboxCADSubCatCategoria);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 125);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "SubCategoria";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Categoria :";
            // 
            // txtCADSubCatSubCategoria
            // 
            this.txtCADSubCatSubCategoria.Location = new System.Drawing.Point(6, 85);
            this.txtCADSubCatSubCategoria.Name = "txtCADSubCatSubCategoria";
            this.txtCADSubCatSubCategoria.Size = new System.Drawing.Size(304, 20);
            this.txtCADSubCatSubCategoria.TabIndex = 1;
            // 
            // cbboxCADSubCatCategoria
            // 
            this.cbboxCADSubCatCategoria.FormattingEnabled = true;
            this.cbboxCADSubCatCategoria.Items.AddRange(new object[] {
            "Bebidas",
            "Alimentação"});
            this.cbboxCADSubCatCategoria.Location = new System.Drawing.Point(6, 29);
            this.cbboxCADSubCatCategoria.Name = "cbboxCADSubCatCategoria";
            this.cbboxCADSubCatCategoria.Size = new System.Drawing.Size(201, 21);
            this.cbboxCADSubCatCategoria.TabIndex = 0;
            // 
            // btnCADSubCatProdNovo
            // 
            this.btnCADSubCatProdNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnCADSubCatProdNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCADSubCatProdNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCADSubCatProdNovo.Location = new System.Drawing.Point(12, 429);
            this.btnCADSubCatProdNovo.Name = "btnCADSubCatProdNovo";
            this.btnCADSubCatProdNovo.Size = new System.Drawing.Size(74, 47);
            this.btnCADSubCatProdNovo.TabIndex = 1;
            this.btnCADSubCatProdNovo.Text = "Novo";
            this.btnCADSubCatProdNovo.UseVisualStyleBackColor = true;
            // 
            // btnCADSubCatProdSair
            // 
            this.btnCADSubCatProdSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnCADSubCatProdSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCADSubCatProdSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCADSubCatProdSair.Location = new System.Drawing.Point(307, 429);
            this.btnCADSubCatProdSair.Name = "btnCADSubCatProdSair";
            this.btnCADSubCatProdSair.Size = new System.Drawing.Size(74, 47);
            this.btnCADSubCatProdSair.TabIndex = 2;
            this.btnCADSubCatProdSair.Text = "Sair";
            this.btnCADSubCatProdSair.UseVisualStyleBackColor = true;
            this.btnCADSubCatProdSair.Click += new System.EventHandler(this.btnCADSubCatProdSair_Click);
            // 
            // btnCADSubCatProdCancelar
            // 
            this.btnCADSubCatProdCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnCADSubCatProdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCADSubCatProdCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCADSubCatProdCancelar.Location = new System.Drawing.Point(109, 429);
            this.btnCADSubCatProdCancelar.Name = "btnCADSubCatProdCancelar";
            this.btnCADSubCatProdCancelar.Size = new System.Drawing.Size(74, 47);
            this.btnCADSubCatProdCancelar.TabIndex = 3;
            this.btnCADSubCatProdCancelar.Text = "Cancelar";
            this.btnCADSubCatProdCancelar.UseVisualStyleBackColor = true;
            // 
            // btnCADSubCatProdSalvar
            // 
            this.btnCADSubCatProdSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnCADSubCatProdSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCADSubCatProdSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCADSubCatProdSalvar.Location = new System.Drawing.Point(207, 429);
            this.btnCADSubCatProdSalvar.Name = "btnCADSubCatProdSalvar";
            this.btnCADSubCatProdSalvar.Size = new System.Drawing.Size(74, 47);
            this.btnCADSubCatProdSalvar.TabIndex = 4;
            this.btnCADSubCatProdSalvar.Text = "Salvar";
            this.btnCADSubCatProdSalvar.UseVisualStyleBackColor = true;
            this.btnCADSubCatProdSalvar.Click += new System.EventHandler(this.btnCADSubCatProdSalvar_Click);
            // 
            // dtgrMDCADSubCategoria
            // 
            this.dtgrMDCADSubCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrMDCADSubCategoria.Location = new System.Drawing.Point(12, 220);
            this.dtgrMDCADSubCategoria.Name = "dtgrMDCADSubCategoria";
            this.dtgrMDCADSubCategoria.Size = new System.Drawing.Size(369, 192);
            this.dtgrMDCADSubCategoria.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 171);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(251, 20);
            this.textBox2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Categoria :";
            // 
            // btnCADSubCatProdPesquisa
            // 
            this.btnCADSubCatProdPesquisa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnCADSubCatProdPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCADSubCatProdPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCADSubCatProdPesquisa.Location = new System.Drawing.Point(287, 164);
            this.btnCADSubCatProdPesquisa.Name = "btnCADSubCatProdPesquisa";
            this.btnCADSubCatProdPesquisa.Size = new System.Drawing.Size(94, 33);
            this.btnCADSubCatProdPesquisa.TabIndex = 8;
            this.btnCADSubCatProdPesquisa.Text = "Pesquisa";
            this.btnCADSubCatProdPesquisa.UseVisualStyleBackColor = true;
            // 
            // SubCategoriaProdutoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(395, 488);
            this.Controls.Add(this.btnCADSubCatProdPesquisa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dtgrMDCADSubCategoria);
            this.Controls.Add(this.btnCADSubCatProdSalvar);
            this.Controls.Add(this.btnCADSubCatProdCancelar);
            this.Controls.Add(this.btnCADSubCatProdSair);
            this.Controls.Add(this.btnCADSubCatProdNovo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SubCategoriaProdutoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SubCategoriaProdutoForm";
            this.Load += new System.EventHandler(this.SubCategoriaProdutoForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrMDCADSubCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCADSubCatSubCategoria;
        private System.Windows.Forms.ComboBox cbboxCADSubCatCategoria;
        private System.Windows.Forms.Button btnCADSubCatProdNovo;
        private System.Windows.Forms.Button btnCADSubCatProdSair;
        private System.Windows.Forms.Button btnCADSubCatProdCancelar;
        private System.Windows.Forms.Button btnCADSubCatProdSalvar;
        private System.Windows.Forms.DataGridView dtgrMDCADSubCategoria;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCADSubCatProdPesquisa;
    }
}