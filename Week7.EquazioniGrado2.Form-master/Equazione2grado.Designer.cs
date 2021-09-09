
namespace Week7.EquazioniGrado2.Form_master
{
    partial class Equazione2grado
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_ValueA = new System.Windows.Forms.TextBox();
            this.textBox_ValueB = new System.Windows.Forms.TextBox();
            this.textBox_valueC = new System.Windows.Forms.TextBox();
            this.Label1Num = new System.Windows.Forms.Label();
            this.label2Num = new System.Windows.Forms.Label();
            this.label3Num = new System.Windows.Forms.Label();
            this.btn_Risoluzione = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.labelSolution = new System.Windows.Forms.Label();
            this.textBoxTitolo = new System.Windows.Forms.TextBox();
            this.btnCalcoloDelta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_ValueA
            // 
            this.textBox_ValueA.Location = new System.Drawing.Point(217, 156);
            this.textBox_ValueA.Name = "textBox_ValueA";
            this.textBox_ValueA.Size = new System.Drawing.Size(214, 31);
            this.textBox_ValueA.TabIndex = 0;
            this.textBox_ValueA.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox_ValueB
            // 
            this.textBox_ValueB.Location = new System.Drawing.Point(752, 152);
            this.textBox_ValueB.Name = "textBox_ValueB";
            this.textBox_ValueB.Size = new System.Drawing.Size(194, 31);
            this.textBox_ValueB.TabIndex = 1;
            this.textBox_ValueB.TextChanged += new System.EventHandler(this.textBox_ValueB_TextChanged);
            // 
            // textBox_valueC
            // 
            this.textBox_valueC.Location = new System.Drawing.Point(1248, 153);
            this.textBox_valueC.Name = "textBox_valueC";
            this.textBox_valueC.Size = new System.Drawing.Size(183, 31);
            this.textBox_valueC.TabIndex = 2;
            this.textBox_valueC.TextChanged += new System.EventHandler(this.textBox_valueC_TextChanged);
            // 
            // Label1Num
            // 
            this.Label1Num.AutoSize = true;
            this.Label1Num.Location = new System.Drawing.Point(-6, 155);
            this.Label1Num.Name = "Label1Num";
            this.Label1Num.Size = new System.Drawing.Size(183, 25);
            this.Label1Num.TabIndex = 3;
            this.Label1Num.Text = "Inserisci il valore di a :";
            this.Label1Num.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2Num
            // 
            this.label2Num.AutoSize = true;
            this.label2Num.Location = new System.Drawing.Point(536, 156);
            this.label2Num.Name = "label2Num";
            this.label2Num.Size = new System.Drawing.Size(185, 25);
            this.label2Num.TabIndex = 4;
            this.label2Num.Text = "Inserisci il valore di b :";
            // 
            // label3Num
            // 
            this.label3Num.AutoSize = true;
            this.label3Num.Location = new System.Drawing.Point(1029, 155);
            this.label3Num.Name = "label3Num";
            this.label3Num.Size = new System.Drawing.Size(182, 25);
            this.label3Num.TabIndex = 5;
            this.label3Num.Text = "Inserisci il valore di c :";
            this.label3Num.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btn_Risoluzione
            // 
            this.btn_Risoluzione.Location = new System.Drawing.Point(493, 354);
            this.btn_Risoluzione.Name = "btn_Risoluzione";
            this.btn_Risoluzione.Size = new System.Drawing.Size(399, 91);
            this.btn_Risoluzione.TabIndex = 6;
            this.btn_Risoluzione.Text = "Risolvi Equazione di secondo grado";
            this.btn_Risoluzione.UseVisualStyleBackColor = true;
            this.btn_Risoluzione.Click += new System.EventHandler(this.btn_Risoluzione_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(536, 504);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(330, 31);
            this.textBox4.TabIndex = 7;
            // 
            // labelSolution
            // 
            this.labelSolution.AutoSize = true;
            this.labelSolution.Location = new System.Drawing.Point(415, 507);
            this.labelSolution.Name = "labelSolution";
            this.labelSolution.Size = new System.Drawing.Size(93, 25);
            this.labelSolution.TabIndex = 8;
            this.labelSolution.Text = "Soluzione:";
            // 
            // textBoxTitolo
            // 
            this.textBoxTitolo.Location = new System.Drawing.Point(536, 40);
            this.textBoxTitolo.Multiline = true;
            this.textBoxTitolo.Name = "textBoxTitolo";
            this.textBoxTitolo.Size = new System.Drawing.Size(371, 46);
            this.textBoxTitolo.TabIndex = 9;
            this.textBoxTitolo.Text = "Equazione di secondo grado";
            this.textBoxTitolo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalcoloDelta
            // 
            this.btnCalcoloDelta.Location = new System.Drawing.Point(578, 247);
            this.btnCalcoloDelta.Name = "btnCalcoloDelta";
            this.btnCalcoloDelta.Size = new System.Drawing.Size(244, 34);
            this.btnCalcoloDelta.TabIndex = 10;
            this.btnCalcoloDelta.Text = "Calcolare il Delta";
            this.btnCalcoloDelta.UseVisualStyleBackColor = true;
            this.btnCalcoloDelta.Click += new System.EventHandler(this.button1_Click);
            // 
            // Equazione2grado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 608);
            this.Controls.Add(this.btnCalcoloDelta);
            this.Controls.Add(this.textBoxTitolo);
            this.Controls.Add(this.labelSolution);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.btn_Risoluzione);
            this.Controls.Add(this.label3Num);
            this.Controls.Add(this.label2Num);
            this.Controls.Add(this.Label1Num);
            this.Controls.Add(this.textBox_valueC);
            this.Controls.Add(this.textBox_ValueB);
            this.Controls.Add(this.textBox_ValueA);
            this.Name = "Equazione2grado";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_ValueA;
        private System.Windows.Forms.TextBox textBox_ValueB;
        private System.Windows.Forms.Label Label1Num;
        private System.Windows.Forms.Label label2Num;
        private System.Windows.Forms.Label label3Num;
        private System.Windows.Forms.Button btn_Risoluzione;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label labelSolution;
        private System.Windows.Forms.TextBox textBoxTitolo;
        private System.Windows.Forms.Button btnCalcoloDelta;
        public System.Windows.Forms.TextBox textBox_valueC;
    }
}

