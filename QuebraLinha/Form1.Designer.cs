namespace QuebraLinha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.lblQuant = new System.Windows.Forms.Label();
            this.txtQuant = new System.Windows.Forms.TextBox();
            this.dlgAbrir = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionar.Location = new System.Drawing.Point(57, 51);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(146, 23);
            this.btnSelecionar.TabIndex = 1;
            this.btnSelecionar.Text = "Selecionar Arquivo";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // lblQuant
            // 
            this.lblQuant.AutoSize = true;
            this.lblQuant.Location = new System.Drawing.Point(12, 9);
            this.lblQuant.Name = "lblQuant";
            this.lblQuant.Size = new System.Drawing.Size(200, 13);
            this.lblQuant.TabIndex = 2;
            this.lblQuant.Text = "Quantidade de linhas para cada quebra :";
            // 
            // txtQuant
            // 
            this.txtQuant.Location = new System.Drawing.Point(15, 25);
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtQuant.Size = new System.Drawing.Size(188, 20);
            this.txtQuant.TabIndex = 3;
            this.txtQuant.Text = "80000";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(219, 87);
            this.Controls.Add(this.txtQuant);
            this.Controls.Add(this.lblQuant);
            this.Controls.Add(this.btnSelecionar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.Text = "Quebrador de Linhas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Label lblQuant;
        private System.Windows.Forms.TextBox txtQuant;
        private System.Windows.Forms.OpenFileDialog dlgAbrir;
    }
}

