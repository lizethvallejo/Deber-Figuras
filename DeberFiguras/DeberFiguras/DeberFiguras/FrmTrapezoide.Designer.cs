namespace DeberFiguras
{
    partial class FrmTrapezoide
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
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.grbProcess = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.grbCanvas = new System.Windows.Forms.GroupBox();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.GRbOutputs = new System.Windows.Forms.GroupBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtPerimeter = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.grblnputs = new System.Windows.Forms.GroupBox();
            this.txtBaseMenor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBaseMayor = new System.Windows.Forms.TextBox();
            this.lblLado = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.grbProcess.SuspendLayout();
            this.grbCanvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.GRbOutputs.SuspendLayout();
            this.grblnputs.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(33, 379);
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(247, 56);
            this.trackBar1.TabIndex = 24;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            this.trackBar1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.trackBar1_KeyDown);
            this.trackBar1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.trackBar1_PreviewKeyDown);
            // 
            // grbProcess
            // 
            this.grbProcess.Controls.Add(this.btnReset);
            this.grbProcess.Controls.Add(this.btnCalculate);
            this.grbProcess.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbProcess.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbProcess.Location = new System.Drawing.Point(5, 163);
            this.grbProcess.Name = "grbProcess";
            this.grbProcess.Size = new System.Drawing.Size(296, 87);
            this.grbProcess.TabIndex = 23;
            this.grbProcess.TabStop = false;
            this.grbProcess.Text = "Proceso";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(159, 41);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(119, 30);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Resetear";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(27, 41);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(102, 30);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // grbCanvas
            // 
            this.grbCanvas.Controls.Add(this.picCanvas);
            this.grbCanvas.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCanvas.Location = new System.Drawing.Point(322, 24);
            this.grbCanvas.Name = "grbCanvas";
            this.grbCanvas.Size = new System.Drawing.Size(473, 347);
            this.grbCanvas.TabIndex = 22;
            this.grbCanvas.TabStop = false;
            this.grbCanvas.Text = "Gráfico";
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(7, 35);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(460, 291);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            // 
            // GRbOutputs
            // 
            this.GRbOutputs.Controls.Add(this.txtArea);
            this.GRbOutputs.Controls.Add(this.txtPerimeter);
            this.GRbOutputs.Controls.Add(this.lblArea);
            this.GRbOutputs.Controls.Add(this.lblPerimeter);
            this.GRbOutputs.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRbOutputs.Location = new System.Drawing.Point(8, 256);
            this.GRbOutputs.Name = "GRbOutputs";
            this.GRbOutputs.Size = new System.Drawing.Size(293, 107);
            this.GRbOutputs.TabIndex = 21;
            this.GRbOutputs.TabStop = false;
            this.GRbOutputs.Text = "Salidas";
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(125, 65);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(150, 28);
            this.txtArea.TabIndex = 3;
            // 
            // txtPerimeter
            // 
            this.txtPerimeter.Location = new System.Drawing.Point(125, 30);
            this.txtPerimeter.Name = "txtPerimeter";
            this.txtPerimeter.Size = new System.Drawing.Size(150, 28);
            this.txtPerimeter.TabIndex = 2;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(7, 68);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(57, 22);
            this.lblArea.TabIndex = 1;
            this.lblArea.Text = "Área:";
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Location = new System.Drawing.Point(6, 36);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(101, 22);
            this.lblPerimeter.TabIndex = 0;
            this.lblPerimeter.Text = "Perímetro:";
            // 
            // grblnputs
            // 
            this.grblnputs.Controls.Add(this.txtAltura);
            this.grblnputs.Controls.Add(this.label2);
            this.grblnputs.Controls.Add(this.txtBaseMenor);
            this.grblnputs.Controls.Add(this.label1);
            this.grblnputs.Controls.Add(this.txtBaseMayor);
            this.grblnputs.Controls.Add(this.lblLado);
            this.grblnputs.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grblnputs.Location = new System.Drawing.Point(5, 24);
            this.grblnputs.Name = "grblnputs";
            this.grblnputs.Size = new System.Drawing.Size(296, 133);
            this.grblnputs.TabIndex = 20;
            this.grblnputs.TabStop = false;
            this.grblnputs.Text = "Entradas";
            // 
            // txtBaseMenor
            // 
            this.txtBaseMenor.Location = new System.Drawing.Point(128, 55);
            this.txtBaseMenor.Name = "txtBaseMenor";
            this.txtBaseMenor.Size = new System.Drawing.Size(147, 28);
            this.txtBaseMenor.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Base Menor :";
            // 
            // txtBaseMayor
            // 
            this.txtBaseMayor.Location = new System.Drawing.Point(128, 21);
            this.txtBaseMayor.Name = "txtBaseMayor";
            this.txtBaseMayor.Size = new System.Drawing.Size(147, 28);
            this.txtBaseMayor.TabIndex = 2;
            // 
            // lblLado
            // 
            this.lblLado.AutoSize = true;
            this.lblLado.Location = new System.Drawing.Point(10, 27);
            this.lblLado.Name = "lblLado";
            this.lblLado.Size = new System.Drawing.Size(122, 22);
            this.lblLado.TabIndex = 0;
            this.lblLado.Text = "Base Mayor :";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(128, 89);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(147, 28);
            this.txtAltura.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Altura :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(615, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "r:antihorario l:horario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "↑:arriba ↓:abajo →:izquierda ←:derecha";
            // 
            // FrmTrapezoide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.grbProcess);
            this.Controls.Add(this.grbCanvas);
            this.Controls.Add(this.GRbOutputs);
            this.Controls.Add(this.grblnputs);
            this.Name = "FrmTrapezoide";
            this.Text = "FrmTrapezoide";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmTrapezoide_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.grbProcess.ResumeLayout(false);
            this.grbCanvas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.GRbOutputs.ResumeLayout(false);
            this.GRbOutputs.PerformLayout();
            this.grblnputs.ResumeLayout(false);
            this.grblnputs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.GroupBox grbProcess;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox grbCanvas;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.GroupBox GRbOutputs;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtPerimeter;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.GroupBox grblnputs;
        private System.Windows.Forms.TextBox txtBaseMenor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBaseMayor;
        private System.Windows.Forms.Label lblLado;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}