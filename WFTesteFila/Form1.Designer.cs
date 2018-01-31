namespace WFTesteFila
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.lstMSMQ = new System.Windows.Forms.ListBox();
            this.btnLer = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.messageQueue1 = new System.Messaging.MessageQueue();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mensagem";
            // 
            // txtMensagem
            // 
            this.txtMensagem.Location = new System.Drawing.Point(79, 13);
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(287, 20);
            this.txtMensagem.TabIndex = 1;
            // 
            // lstMSMQ
            // 
            this.lstMSMQ.FormattingEnabled = true;
            this.lstMSMQ.Location = new System.Drawing.Point(16, 40);
            this.lstMSMQ.Name = "lstMSMQ";
            this.lstMSMQ.Size = new System.Drawing.Size(350, 173);
            this.lstMSMQ.TabIndex = 2;
            // 
            // btnLer
            // 
            this.btnLer.Location = new System.Drawing.Point(256, 226);
            this.btnLer.Name = "btnLer";
            this.btnLer.Size = new System.Drawing.Size(110, 23);
            this.btnLer.TabIndex = 3;
            this.btnLer.Text = "Ler Mensagem";
            this.btnLer.UseVisualStyleBackColor = true;
            this.btnLer.Click += new System.EventHandler(this.btnLer_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(16, 226);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(109, 23);
            this.btnEnviar.TabIndex = 3;
            this.btnEnviar.Text = "Enviar Mensagem";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // messageQueue1
            // 
            this.messageQueue1.MessageReadPropertyFilter.LookupId = true;
            this.messageQueue1.SynchronizingObject = this;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(373, 13);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(286, 200);
            this.treeView1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(373, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(286, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Exibir Filas Particulares";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnLer);
            this.Controls.Add(this.lstMSMQ);
            this.Controls.Add(this.txtMensagem);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Teste de Filas ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.ListBox lstMSMQ;
        private System.Windows.Forms.Button btnLer;
        private System.Windows.Forms.Button btnEnviar;
        private System.Messaging.MessageQueue messageQueue1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TreeView treeView1;
    }
}

