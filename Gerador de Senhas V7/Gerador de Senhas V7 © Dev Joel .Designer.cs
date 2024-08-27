namespace Gerador_de_Senhas_V7
{
    partial class FrGerador
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrGerador));
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.BtnCopiar = new System.Windows.Forms.Button();
            this.chkMaiusculas = new System.Windows.Forms.CheckBox();
            this.chkMinusculas = new System.Windows.Forms.CheckBox();
            this.chkNumeros = new System.Windows.Forms.CheckBox();
            this.chkSimbolos = new System.Windows.Forms.CheckBox();
            this.NChars = new System.Windows.Forms.NumericUpDown();
            this.BtnGerar = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.LBLStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NChars)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Silver;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(8, 9);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(883, 49);
            this.txtPassword.TabIndex = 0;
            // 
            // BtnCopiar
            // 
            this.BtnCopiar.FlatAppearance.BorderSize = 0;
            this.BtnCopiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCopiar.ForeColor = System.Drawing.Color.White;
            this.BtnCopiar.Location = new System.Drawing.Point(913, 12);
            this.BtnCopiar.Name = "BtnCopiar";
            this.BtnCopiar.Size = new System.Drawing.Size(155, 47);
            this.BtnCopiar.TabIndex = 1;
            this.BtnCopiar.Text = "Copiar";
            this.BtnCopiar.UseVisualStyleBackColor = true;
            this.BtnCopiar.Click += new System.EventHandler(this.BtnCopiar_Click);
            // 
            // chkMaiusculas
            // 
            this.chkMaiusculas.AutoSize = true;
            this.chkMaiusculas.FlatAppearance.BorderSize = 0;
            this.chkMaiusculas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkMaiusculas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMaiusculas.Location = new System.Drawing.Point(12, 68);
            this.chkMaiusculas.Name = "chkMaiusculas";
            this.chkMaiusculas.Size = new System.Drawing.Size(151, 33);
            this.chkMaiusculas.TabIndex = 2;
            this.chkMaiusculas.Text = "Maiusculas";
            this.chkMaiusculas.UseVisualStyleBackColor = true;
            // 
            // chkMinusculas
            // 
            this.chkMinusculas.AutoSize = true;
            this.chkMinusculas.FlatAppearance.BorderSize = 0;
            this.chkMinusculas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkMinusculas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMinusculas.Location = new System.Drawing.Point(202, 68);
            this.chkMinusculas.Name = "chkMinusculas";
            this.chkMinusculas.Size = new System.Drawing.Size(151, 33);
            this.chkMinusculas.TabIndex = 3;
            this.chkMinusculas.Text = "Minusculas";
            this.chkMinusculas.UseVisualStyleBackColor = true;
            // 
            // chkNumeros
            // 
            this.chkNumeros.AutoSize = true;
            this.chkNumeros.FlatAppearance.BorderSize = 0;
            this.chkNumeros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkNumeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNumeros.Location = new System.Drawing.Point(383, 68);
            this.chkNumeros.Name = "chkNumeros";
            this.chkNumeros.Size = new System.Drawing.Size(130, 33);
            this.chkNumeros.TabIndex = 4;
            this.chkNumeros.Text = "Numeros";
            this.chkNumeros.UseVisualStyleBackColor = true;
            // 
            // chkSimbolos
            // 
            this.chkSimbolos.AutoSize = true;
            this.chkSimbolos.FlatAppearance.BorderSize = 0;
            this.chkSimbolos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkSimbolos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSimbolos.Location = new System.Drawing.Point(546, 68);
            this.chkSimbolos.Name = "chkSimbolos";
            this.chkSimbolos.Size = new System.Drawing.Size(133, 33);
            this.chkSimbolos.TabIndex = 5;
            this.chkSimbolos.Text = "Simbolos";
            this.chkSimbolos.UseVisualStyleBackColor = true;
            // 
            // NChars
            // 
            this.NChars.AutoSize = true;
            this.NChars.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NChars.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NChars.Location = new System.Drawing.Point(771, 67);
            this.NChars.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NChars.Name = "NChars";
            this.NChars.Size = new System.Drawing.Size(120, 34);
            this.NChars.TabIndex = 6;
            this.NChars.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnGerar
            // 
            this.BtnGerar.FlatAppearance.BorderSize = 0;
            this.BtnGerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGerar.ForeColor = System.Drawing.Color.White;
            this.BtnGerar.Location = new System.Drawing.Point(13, 117);
            this.BtnGerar.Name = "BtnGerar";
            this.BtnGerar.Size = new System.Drawing.Size(150, 50);
            this.BtnGerar.TabIndex = 7;
            this.BtnGerar.Text = "Gerar";
            this.BtnGerar.UseVisualStyleBackColor = true;
            this.BtnGerar.Click += new System.EventHandler(this.BtnGerar_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.FlatAppearance.BorderSize = 0;
            this.BtnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpar.ForeColor = System.Drawing.Color.White;
            this.BtnLimpar.Location = new System.Drawing.Point(178, 117);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(150, 50);
            this.BtnLimpar.TabIndex = 8;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.FlatAppearance.BorderSize = 0;
            this.BtnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSair.ForeColor = System.Drawing.Color.White;
            this.BtnSair.Location = new System.Drawing.Point(363, 117);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(150, 50);
            this.BtnSair.TabIndex = 9;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // LBLStatus
            // 
            this.LBLStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LBLStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLStatus.ForeColor = System.Drawing.Color.White;
            this.LBLStatus.Location = new System.Drawing.Point(13, 180);
            this.LBLStatus.Name = "LBLStatus";
            this.LBLStatus.Size = new System.Drawing.Size(1047, 41);
            this.LBLStatus.TabIndex = 10;
            // 
            // FrGerador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1072, 226);
            this.Controls.Add(this.LBLStatus);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnGerar);
            this.Controls.Add(this.NChars);
            this.Controls.Add(this.chkSimbolos);
            this.Controls.Add(this.chkNumeros);
            this.Controls.Add(this.chkMinusculas);
            this.Controls.Add(this.chkMaiusculas);
            this.Controls.Add(this.BtnCopiar);
            this.Controls.Add(this.txtPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrGerador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerador de Senhas V7 © Dev Joel Portugal 2024";
            ((System.ComponentModel.ISupportInitialize)(this.NChars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button BtnCopiar;
        private System.Windows.Forms.CheckBox chkMaiusculas;
        private System.Windows.Forms.CheckBox chkMinusculas;
        private System.Windows.Forms.CheckBox chkNumeros;
        private System.Windows.Forms.CheckBox chkSimbolos;
        private System.Windows.Forms.NumericUpDown NChars;
        private System.Windows.Forms.Button BtnGerar;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Label LBLStatus;
    }
}

