﻿namespace ProyectoFinalBueno
{
    partial class FPrincipal
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
            this.BttnDarAlta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BttnDarAlta
            // 
            this.BttnDarAlta.Location = new System.Drawing.Point(197, 12);
            this.BttnDarAlta.Name = "BttnDarAlta";
            this.BttnDarAlta.Size = new System.Drawing.Size(75, 23);
            this.BttnDarAlta.TabIndex = 0;
            this.BttnDarAlta.Text = "Dar Alta libro";
            this.BttnDarAlta.UseVisualStyleBackColor = true;
            this.BttnDarAlta.Click += new System.EventHandler(this.BttnDarAlta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 120);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // FPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BttnDarAlta);
            this.Name = "FPrincipal";
            this.Text = "Compra y venta ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BttnDarAlta;
        public System.Windows.Forms.Label label1;
    }
}

