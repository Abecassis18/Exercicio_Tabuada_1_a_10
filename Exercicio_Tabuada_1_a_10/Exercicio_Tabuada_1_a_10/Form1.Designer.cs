namespace Exercicio_Tabuada_1_a_10
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lstResultado = new System.Windows.Forms.ListView();
            this.btnEncerrar = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(37, 271);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(12, 12);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(133, 20);
            this.txtNum.TabIndex = 1;
            // 
            // lstResultado
            // 
            this.lstResultado.HideSelection = false;
            this.lstResultado.Location = new System.Drawing.Point(12, 51);
            this.lstResultado.Name = "lstResultado";
            this.lstResultado.Size = new System.Drawing.Size(133, 211);
            this.lstResultado.TabIndex = 2;
            this.lstResultado.UseCompatibleStateImageBehavior = false;
            // 
            // btnEncerrar
            // 
            this.btnEncerrar.Location = new System.Drawing.Point(37, 300);
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.Size = new System.Drawing.Size(75, 23);
            this.btnEncerrar.TabIndex = 3;
            this.btnEncerrar.Text = "Encerrar";
            this.btnEncerrar.UseVisualStyleBackColor = true;
            this.btnEncerrar.Click += new System.EventHandler(this.btnEncerrar_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(159, 335);
            this.Controls.Add(this.btnEncerrar);
            this.Controls.Add(this.lstResultado);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.btnCalcular);
            this.Name = "Form1";
            this.Text = "Tabuada";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.ListView lstResultado;
        private System.Windows.Forms.Button btnEncerrar;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

