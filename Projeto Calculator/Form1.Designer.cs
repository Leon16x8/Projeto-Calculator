
namespace Projeto_Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Mais = new System.Windows.Forms.Button();
            this.raiz = new System.Windows.Forms.Button();
            this.menos = new System.Windows.Forms.Button();
            this.mult = new System.Windows.Forms.Button();
            this.divi = new System.Windows.Forms.Button();
            this.potencia = new System.Windows.Forms.Button();
            this.boxprimeironum = new System.Windows.Forms.TextBox();
            this.boxsegundonum = new System.Windows.Forms.TextBox();
            this.PrimeiroNumero = new System.Windows.Forms.Label();
            this.SegundoNumero = new System.Windows.Forms.Label();
            this.resultado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // Mais
            // 
            this.Mais.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Mais.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Mais.BackgroundImage")));
            this.Mais.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Mais.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Mais.ForeColor = System.Drawing.Color.Transparent;
            this.Mais.Location = new System.Drawing.Point(52, 151);
            this.Mais.Name = "Mais";
            this.Mais.Size = new System.Drawing.Size(58, 47);
            this.Mais.TabIndex = 8;
            this.Mais.UseVisualStyleBackColor = false;
            this.Mais.Click += new System.EventHandler(this.Mais_Click);
            // 
            // raiz
            // 
            this.raiz.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("raiz.BackgroundImage")));
            this.raiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.raiz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.raiz.ForeColor = System.Drawing.Color.Transparent;
            this.raiz.Location = new System.Drawing.Point(80, 204);
            this.raiz.Name = "raiz";
            this.raiz.Size = new System.Drawing.Size(58, 47);
            this.raiz.TabIndex = 9;
            this.raiz.UseVisualStyleBackColor = true;
            this.raiz.Click += new System.EventHandler(this.raiz_Click);
            // 
            // menos
            // 
            this.menos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menos.BackgroundImage")));
            this.menos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.menos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menos.ForeColor = System.Drawing.Color.Transparent;
            this.menos.Location = new System.Drawing.Point(116, 170);
            this.menos.Name = "menos";
            this.menos.Size = new System.Drawing.Size(58, 28);
            this.menos.TabIndex = 11;
            this.menos.UseVisualStyleBackColor = true;
            this.menos.Click += new System.EventHandler(this.menos_Click);
            // 
            // mult
            // 
            this.mult.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mult.BackgroundImage")));
            this.mult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mult.ForeColor = System.Drawing.Color.Transparent;
            this.mult.Location = new System.Drawing.Point(116, 117);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(58, 47);
            this.mult.TabIndex = 12;
            this.mult.UseVisualStyleBackColor = true;
            this.mult.Click += new System.EventHandler(this.mult_Click);
            // 
            // divi
            // 
            this.divi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("divi.BackgroundImage")));
            this.divi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.divi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.divi.ForeColor = System.Drawing.Color.Transparent;
            this.divi.Location = new System.Drawing.Point(180, 151);
            this.divi.Name = "divi";
            this.divi.Size = new System.Drawing.Size(58, 47);
            this.divi.TabIndex = 13;
            this.divi.UseVisualStyleBackColor = true;
            this.divi.Click += new System.EventHandler(this.divi_Click);
            // 
            // potencia
            // 
            this.potencia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("potencia.BackgroundImage")));
            this.potencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.potencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.potencia.ForeColor = System.Drawing.Color.Transparent;
            this.potencia.Location = new System.Drawing.Point(144, 204);
            this.potencia.Name = "potencia";
            this.potencia.Size = new System.Drawing.Size(58, 47);
            this.potencia.TabIndex = 14;
            this.potencia.UseVisualStyleBackColor = true;
            this.potencia.Click += new System.EventHandler(this.potencia_Click);
            // 
            // boxprimeironum
            // 
            this.boxprimeironum.Location = new System.Drawing.Point(170, 64);
            this.boxprimeironum.Name = "boxprimeironum";
            this.boxprimeironum.Size = new System.Drawing.Size(116, 20);
            this.boxprimeironum.TabIndex = 15;
            this.boxprimeironum.TextChanged += new System.EventHandler(this.boxprimeironum_TextChanged);
            // 
            // boxsegundonum
            // 
            this.boxsegundonum.Location = new System.Drawing.Point(22, 64);
            this.boxsegundonum.Name = "boxsegundonum";
            this.boxsegundonum.Size = new System.Drawing.Size(116, 20);
            this.boxsegundonum.TabIndex = 16;
            this.boxsegundonum.TextChanged += new System.EventHandler(this.boxsegundonum_TextChanged);
            // 
            // PrimeiroNumero
            // 
            this.PrimeiroNumero.AutoSize = true;
            this.PrimeiroNumero.BackColor = System.Drawing.Color.Transparent;
            this.PrimeiroNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrimeiroNumero.Location = new System.Drawing.Point(19, 46);
            this.PrimeiroNumero.Name = "PrimeiroNumero";
            this.PrimeiroNumero.Size = new System.Drawing.Size(99, 13);
            this.PrimeiroNumero.TabIndex = 17;
            this.PrimeiroNumero.Text = "Primeiro Numero";
            // 
            // SegundoNumero
            // 
            this.SegundoNumero.AutoSize = true;
            this.SegundoNumero.BackColor = System.Drawing.Color.Transparent;
            this.SegundoNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SegundoNumero.Location = new System.Drawing.Point(167, 46);
            this.SegundoNumero.Name = "SegundoNumero";
            this.SegundoNumero.Size = new System.Drawing.Size(104, 13);
            this.SegundoNumero.TabIndex = 18;
            this.SegundoNumero.Text = "Segundo Numero";
            this.SegundoNumero.Click += new System.EventHandler(this.SegundoNumero_Click);
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.BackColor = System.Drawing.Color.Transparent;
            this.resultado.Font = new System.Drawing.Font("Kristen ITC", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado.Location = new System.Drawing.Point(127, 283);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(35, 40);
            this.resultado.TabIndex = 19;
            this.resultado.Text = "--";
            this.resultado.Click += new System.EventHandler(this.resultado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "By xFr";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.ForeColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Location = new System.Drawing.Point(191, 340);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(31, 13);
            this.linkLabel1.TabIndex = 21;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "LINK";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(298, 362);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.SegundoNumero);
            this.Controls.Add(this.PrimeiroNumero);
            this.Controls.Add(this.boxsegundonum);
            this.Controls.Add(this.boxprimeironum);
            this.Controls.Add(this.potencia);
            this.Controls.Add(this.divi);
            this.Controls.Add(this.mult);
            this.Controls.Add(this.menos);
            this.Controls.Add(this.raiz);
            this.Controls.Add(this.Mais);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Mais;
        private System.Windows.Forms.Button raiz;
        private System.Windows.Forms.Button menos;
        private System.Windows.Forms.Button mult;
        private System.Windows.Forms.Button divi;
        private System.Windows.Forms.Button potencia;
        private System.Windows.Forms.TextBox boxprimeironum;
        private System.Windows.Forms.TextBox boxsegundonum;
        private System.Windows.Forms.Label PrimeiroNumero;
        private System.Windows.Forms.Label SegundoNumero;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

