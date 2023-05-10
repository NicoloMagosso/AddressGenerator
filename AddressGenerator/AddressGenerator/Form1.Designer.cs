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
            this.txtCIDR = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtLettura
            // 
            this.txtLettura.Location = new System.Drawing.Point(205, 79);
            this.txtLettura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLettura.Name = "txtLettura";
            this.txtLettura.Size = new System.Drawing.Size(116, 22);
            this.txtLettura.TabIndex = 0;
            this.txtLettura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLettura_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP:";
            // 
            // btnCalcola
            // 
            this.btnCalcola.Location = new System.Drawing.Point(223, 174);
            this.btnCalcola.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalcola.Name = "btnCalcola";
            this.btnCalcola.Size = new System.Drawing.Size(100, 28);
            this.btnCalcola.TabIndex = 2;
            this.btnCalcola.Text = "Calcola";
            this.btnCalcola.UseVisualStyleBackColor = true;
            this.btnCalcola.Click += new System.EventHandler(this.BtnCalcola_Click);
            // 
            // txtSM
            // 
            this.txtSM.AutoSize = true;
            this.txtSM.Location = new System.Drawing.Point(205, 134);
            this.txtSM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtSM.Name = "txtSM";
            this.txtSM.Size = new System.Drawing.Size(100, 16);
            this.txtSM.TabIndex = 3;
            this.txtSM.Text = "255.255.255.255";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Subnet Mask:";
            // 
            // txtCIDR
            // 
            this.txtCIDR.Location = new System.Drawing.Point(345, 79);
            this.txtCIDR.Name = "txtCIDR";
            this.txtCIDR.Size = new System.Drawing.Size(31, 22);
            this.txtCIDR.TabIndex = 5;
            this.txtCIDR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCIDR_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "/";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 293);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCIDR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSM);
            this.Controls.Add(this.btnCalcola);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLettura);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.TextBox txtCIDR;
        private System.Windows.Forms.Label label3;
    }
}

