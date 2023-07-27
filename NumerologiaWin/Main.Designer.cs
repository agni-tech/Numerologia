namespace NumerologiaWin
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.cmdEncerrar = new System.Windows.Forms.Button();
            this.cmdCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtText = new System.Windows.Forms.TextBox();
            this.lbResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdEncerrar
            // 
            this.cmdEncerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cmdEncerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdEncerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cmdEncerrar.FlatAppearance.BorderSize = 3;
            this.cmdEncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdEncerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEncerrar.ForeColor = System.Drawing.Color.Cornsilk;
            this.cmdEncerrar.Location = new System.Drawing.Point(394, 300);
            this.cmdEncerrar.Name = "cmdEncerrar";
            this.cmdEncerrar.Size = new System.Drawing.Size(154, 57);
            this.cmdEncerrar.TabIndex = 1;
            this.cmdEncerrar.TabStop = false;
            this.cmdEncerrar.Text = "Fechar Programa";
            this.cmdEncerrar.UseVisualStyleBackColor = false;
            this.cmdEncerrar.Click += new System.EventHandler(this.cmdEncerrar_Click);
            // 
            // cmdCalcular
            // 
            this.cmdCalcular.BackColor = System.Drawing.Color.MediumPurple;
            this.cmdCalcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdCalcular.FlatAppearance.BorderColor = System.Drawing.Color.Olive;
            this.cmdCalcular.FlatAppearance.BorderSize = 3;
            this.cmdCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCalcular.Location = new System.Drawing.Point(781, 32);
            this.cmdCalcular.Name = "cmdCalcular";
            this.cmdCalcular.Size = new System.Drawing.Size(153, 97);
            this.cmdCalcular.TabIndex = 2;
            this.cmdCalcular.TabStop = false;
            this.cmdCalcular.Text = "Calcular";
            this.cmdCalcular.UseVisualStyleBackColor = false;
            this.cmdCalcular.Click += new System.EventHandler(this.cmdCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(48, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(715, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Digite uma palavra ou uma frase e clique em Calcular ou pressione <ENTER> no tecl" +
    "ado";
            // 
            // txtText
            // 
            this.txtText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtText.Location = new System.Drawing.Point(52, 80);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(711, 38);
            this.txtText.TabIndex = 0;
            this.txtText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtText_KeyDown);
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.BackColor = System.Drawing.Color.Transparent;
            this.lbResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.ForeColor = System.Drawing.Color.Coral;
            this.lbResult.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbResult.Location = new System.Drawing.Point(72, 169);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(16, 24);
            this.lbResult.TabIndex = 5;
            this.lbResult.Text = " ";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(946, 369);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdCalcular);
            this.Controls.Add(this.cmdEncerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "  Numerologia App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdEncerrar;
        private System.Windows.Forms.Button cmdCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Label lbResult;
    }
}

