namespace EncriptadorDeMensagens
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.txtMensagem = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCriptografar = new System.Windows.Forms.Button();
            this.btnDecodificar = new System.Windows.Forms.Button();
            this.btnAjuda = new System.Windows.Forms.Button();
            this.tipBalao = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // txtMensagem
            // 
            this.txtMensagem.Location = new System.Drawing.Point(12, 28);
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(414, 190);
            this.txtMensagem.TabIndex = 0;
            this.txtMensagem.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mensagem:";
            // 
            // btnCriptografar
            // 
            this.btnCriptografar.Location = new System.Drawing.Point(15, 224);
            this.btnCriptografar.Name = "btnCriptografar";
            this.btnCriptografar.Size = new System.Drawing.Size(75, 23);
            this.btnCriptografar.TabIndex = 2;
            this.btnCriptografar.Text = "Criptografar";
            this.tipBalao.SetToolTip(this.btnCriptografar, "Torna a mensagem contida na caixa de texto uma mensagem criptografada.");
            this.btnCriptografar.UseVisualStyleBackColor = true;
            this.btnCriptografar.Click += new System.EventHandler(this.btnCriptografar_Click);
            // 
            // btnDecodificar
            // 
            this.btnDecodificar.Location = new System.Drawing.Point(110, 224);
            this.btnDecodificar.Name = "btnDecodificar";
            this.btnDecodificar.Size = new System.Drawing.Size(75, 23);
            this.btnDecodificar.TabIndex = 3;
            this.btnDecodificar.Text = "Decodificar";
            this.tipBalao.SetToolTip(this.btnDecodificar, "Torna a mensagem criptografada contida na caixa de texto uma mensagem legível.");
            this.btnDecodificar.UseVisualStyleBackColor = true;
            this.btnDecodificar.Click += new System.EventHandler(this.btnDecodificar_Click);
            // 
            // btnAjuda
            // 
            this.btnAjuda.Location = new System.Drawing.Point(351, 224);
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.Size = new System.Drawing.Size(75, 23);
            this.btnAjuda.TabIndex = 4;
            this.btnAjuda.Text = "Ajuda";
            this.btnAjuda.UseVisualStyleBackColor = true;
            this.btnAjuda.Click += new System.EventHandler(this.btnAjuda_Click);
            // 
            // tipBalao
            // 
            this.tipBalao.AutomaticDelay = 1000;
            this.tipBalao.IsBalloon = true;
            this.tipBalao.Tag = "";
            this.tipBalao.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tipBalao.ToolTipTitle = "Criptografia";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 258);
            this.Controls.Add(this.btnAjuda);
            this.Controls.Add(this.btnDecodificar);
            this.Controls.Add(this.btnCriptografar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMensagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.Text = "Criptografia de Mensagens";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtMensagem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCriptografar;
        private System.Windows.Forms.Button btnDecodificar;
        private System.Windows.Forms.Button btnAjuda;
        private System.Windows.Forms.ToolTip tipBalao;
    }
}

