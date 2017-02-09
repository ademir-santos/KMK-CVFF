namespace KMK_GUI.VIEWS
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.txtLgLogin = new System.Windows.Forms.TextBox();
            this.txtLgSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLgEntrar = new System.Windows.Forms.Button();
            this.btnLgSair = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLgLogin
            // 
            this.txtLgLogin.Location = new System.Drawing.Point(16, 32);
            this.txtLgLogin.Name = "txtLgLogin";
            this.txtLgLogin.Size = new System.Drawing.Size(233, 20);
            this.txtLgLogin.TabIndex = 0;
            // 
            // txtLgSenha
            // 
            this.txtLgSenha.Location = new System.Drawing.Point(16, 98);
            this.txtLgSenha.Name = "txtLgSenha";
            this.txtLgSenha.Size = new System.Drawing.Size(233, 20);
            this.txtLgSenha.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuário :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha :";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(194, 121);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(55, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.txtLgLogin);
            this.panel1.Controls.Add(this.txtLgSenha);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(88, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 147);
            this.panel1.TabIndex = 5;
            // 
            // btnLgEntrar
            // 
            this.btnLgEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnLgEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLgEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLgEntrar.Location = new System.Drawing.Point(88, 215);
            this.btnLgEntrar.Name = "btnLgEntrar";
            this.btnLgEntrar.Size = new System.Drawing.Size(75, 35);
            this.btnLgEntrar.TabIndex = 6;
            this.btnLgEntrar.Text = "Entrar";
            this.btnLgEntrar.UseVisualStyleBackColor = true;
            this.btnLgEntrar.Click += new System.EventHandler(this.btnLgEntrar_Click);
            // 
            // btnLgSair
            // 
            this.btnLgSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnLgSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLgSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLgSair.Location = new System.Drawing.Point(282, 215);
            this.btnLgSair.Name = "btnLgSair";
            this.btnLgSair.Size = new System.Drawing.Size(75, 35);
            this.btnLgSair.TabIndex = 7;
            this.btnLgSair.Text = "Sair";
            this.btnLgSair.UseVisualStyleBackColor = true;
            this.btnLgSair.Click += new System.EventHandler(this.btnLgSair_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(446, 262);
            this.Controls.Add(this.btnLgSair);
            this.Controls.Add(this.btnLgEntrar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtLgLogin;
        private System.Windows.Forms.TextBox txtLgSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLgEntrar;
        private System.Windows.Forms.Button btnLgSair;
    }
}