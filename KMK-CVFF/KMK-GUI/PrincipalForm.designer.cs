namespace KMK_GUI
{
    partial class PrincipalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrncFrmSair = new System.Windows.Forms.Button();
            this.btnMDParSis = new System.Windows.Forms.Button();
            this.btnMDRelatorios = new System.Windows.Forms.Button();
            this.btnMDBalcao = new System.Windows.Forms.Button();
            this.btnMDDelivery = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbSecaoUsuario = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnPrncFrmSair);
            this.panel1.Controls.Add(this.btnMDParSis);
            this.panel1.Controls.Add(this.btnMDRelatorios);
            this.panel1.Controls.Add(this.btnMDBalcao);
            this.panel1.Controls.Add(this.btnMDDelivery);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(135, 587);
            this.panel1.TabIndex = 0;
            // 
            // btnPrncFrmSair
            // 
            this.btnPrncFrmSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrncFrmSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnPrncFrmSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrncFrmSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrncFrmSair.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPrncFrmSair.Location = new System.Drawing.Point(16, 480);
            this.btnPrncFrmSair.Name = "btnPrncFrmSair";
            this.btnPrncFrmSair.Size = new System.Drawing.Size(97, 88);
            this.btnPrncFrmSair.TabIndex = 4;
            this.btnPrncFrmSair.Text = "Sair";
            this.btnPrncFrmSair.UseVisualStyleBackColor = true;
            this.btnPrncFrmSair.Click += new System.EventHandler(this.btnPrncFrmSair_Click);
            // 
            // btnMDParSis
            // 
            this.btnMDParSis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnMDParSis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMDParSis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMDParSis.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMDParSis.Location = new System.Drawing.Point(16, 333);
            this.btnMDParSis.Name = "btnMDParSis";
            this.btnMDParSis.Size = new System.Drawing.Size(97, 88);
            this.btnMDParSis.TabIndex = 3;
            this.btnMDParSis.Text = "Sistema";
            this.btnMDParSis.UseVisualStyleBackColor = true;
            this.btnMDParSis.Click += new System.EventHandler(this.btnMDParSis_Click);
            // 
            // btnMDRelatorios
            // 
            this.btnMDRelatorios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnMDRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMDRelatorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMDRelatorios.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMDRelatorios.Location = new System.Drawing.Point(16, 228);
            this.btnMDRelatorios.Name = "btnMDRelatorios";
            this.btnMDRelatorios.Size = new System.Drawing.Size(97, 88);
            this.btnMDRelatorios.TabIndex = 2;
            this.btnMDRelatorios.Text = "Relatórios";
            this.btnMDRelatorios.UseVisualStyleBackColor = true;
            // 
            // btnMDBalcao
            // 
            this.btnMDBalcao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnMDBalcao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMDBalcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMDBalcao.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMDBalcao.Location = new System.Drawing.Point(16, 123);
            this.btnMDBalcao.Name = "btnMDBalcao";
            this.btnMDBalcao.Size = new System.Drawing.Size(97, 88);
            this.btnMDBalcao.TabIndex = 1;
            this.btnMDBalcao.Text = "Balcão";
            this.btnMDBalcao.UseVisualStyleBackColor = true;
            this.btnMDBalcao.Click += new System.EventHandler(this.btnMDBalcao_Click);
            // 
            // btnMDDelivery
            // 
            this.btnMDDelivery.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnMDDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMDDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMDDelivery.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMDDelivery.Location = new System.Drawing.Point(16, 19);
            this.btnMDDelivery.Name = "btnMDDelivery";
            this.btnMDDelivery.Size = new System.Drawing.Size(97, 88);
            this.btnMDDelivery.TabIndex = 0;
            this.btnMDDelivery.Text = "Delivery";
            this.btnMDDelivery.UseVisualStyleBackColor = true;
            this.btnMDDelivery.Click += new System.EventHandler(this.btnMDDelivery_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(907, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuário :";
            // 
            // lbSecaoUsuario
            // 
            this.lbSecaoUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSecaoUsuario.AutoSize = true;
            this.lbSecaoUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lbSecaoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSecaoUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbSecaoUsuario.Location = new System.Drawing.Point(978, 14);
            this.lbSecaoUsuario.Name = "lbSecaoUsuario";
            this.lbSecaoUsuario.Size = new System.Drawing.Size(0, 15);
            this.lbSecaoUsuario.TabIndex = 2;
            this.lbSecaoUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1092, 611);
            this.Controls.Add(this.lbSecaoUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KMK - C.F.E";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PrincipalForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPrncFrmSair;
        private System.Windows.Forms.Button btnMDParSis;
        private System.Windows.Forms.Button btnMDRelatorios;
        private System.Windows.Forms.Button btnMDBalcao;
        private System.Windows.Forms.Button btnMDDelivery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbSecaoUsuario;
    }
}