namespace AddressGenerator
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
            this.txtLettura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalcola = new System.Windows.Forms.Button();
            this.txtSM = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtLettura
            // 
            this.txtLettura.Location = new System.Drawing.Point(154, 64);
            this.txtLettura.Name = "txtLettura";
            this.txtLettura.Size = new System.Drawing.Size(88, 20);
            this.txtLettura.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP:";
            // 
            // btnCalcola
            // 
            this.btnCalcola.Location = new System.Drawing.Point(167, 141);
            this.btnCalcola.Name = "btnCalcola";
            this.btnCalcola.Size = new System.Drawing.Size(75, 23);
            this.btnCalcola.TabIndex = 2;
            this.btnCalcola.Text = "Calcola";
            this.btnCalcola.UseVisualStyleBackColor = true;
            this.btnCalcola.Click += new System.EventHandler(this.BtnCalcola_Click);
            // 
            // txtSM
            // 
            this.txtSM.AutoSize = true;
            this.txtSM.Location = new System.Drawing.Point(154, 109);
            this.txtSM.Name = "txtSM";
            this.txtSM.Size = new System.Drawing.Size(88, 13);
            this.txtSM.TabIndex = 3;
            this.txtSM.Text = "255.255.255.255";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Subnet Mask:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 238);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSM);
            this.Controls.Add(this.btnCalcola);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLettura);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLettura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalcola;
        private System.Windows.Forms.Label txtSM;
        private System.Windows.Forms.Label label2;
    }
}

