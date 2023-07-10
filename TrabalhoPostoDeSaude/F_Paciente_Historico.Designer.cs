
namespace TrabalhoPostoDeSaude
{
    partial class F_Paciente_Historico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Paciente_Historico));
            this.label1 = new System.Windows.Forms.Label();
            this.lb_consultas = new System.Windows.Forms.ListBox();
            this.btn_historico_inserir = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_medicos = new System.Windows.Forms.ComboBox();
            this.tb_diag = new System.Windows.Forms.TextBox();
            this.tb_sala = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_enfermeiros = new System.Windows.Forms.ComboBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(497, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insira um novo registro de consulta:";
            // 
            // lb_consultas
            // 
            this.lb_consultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_consultas.FormattingEnabled = true;
            this.lb_consultas.HorizontalScrollbar = true;
            this.lb_consultas.ItemHeight = 25;
            this.lb_consultas.Location = new System.Drawing.Point(525, 118);
            this.lb_consultas.Name = "lb_consultas";
            this.lb_consultas.Size = new System.Drawing.Size(414, 379);
            this.lb_consultas.TabIndex = 2;
            // 
            // btn_historico_inserir
            // 
            this.btn_historico_inserir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_historico_inserir.BackgroundImage")));
            this.btn_historico_inserir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_historico_inserir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_historico_inserir.FlatAppearance.BorderSize = 0;
            this.btn_historico_inserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_historico_inserir.Location = new System.Drawing.Point(239, 523);
            this.btn_historico_inserir.Name = "btn_historico_inserir";
            this.btn_historico_inserir.Size = new System.Drawing.Size(138, 58);
            this.btn_historico_inserir.TabIndex = 3;
            this.btn_historico_inserir.UseVisualStyleBackColor = true;
            this.btn_historico_inserir.Click += new System.EventHandler(this.btn_historico_inserir_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Window;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(47, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 25);
            this.label9.TabIndex = 51;
            this.label9.Text = "Id da ficha:";
            // 
            // tb_id
            // 
            this.tb_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_id.Location = new System.Drawing.Point(170, 145);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(302, 31);
            this.tb_id.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 456);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 25);
            this.label4.TabIndex = 46;
            this.label4.Text = "Diagnóstico:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 45;
            this.label3.Text = "Sala:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 44;
            this.label2.Text = "Medico:";
            // 
            // cb_medicos
            // 
            this.cb_medicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_medicos.FormattingEnabled = true;
            this.cb_medicos.Location = new System.Drawing.Point(170, 210);
            this.cb_medicos.Name = "cb_medicos";
            this.cb_medicos.Size = new System.Drawing.Size(302, 33);
            this.cb_medicos.TabIndex = 43;
            // 
            // tb_diag
            // 
            this.tb_diag.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_diag.Location = new System.Drawing.Point(170, 453);
            this.tb_diag.Name = "tb_diag";
            this.tb_diag.Size = new System.Drawing.Size(302, 31);
            this.tb_diag.TabIndex = 39;
            // 
            // tb_sala
            // 
            this.tb_sala.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_sala.Location = new System.Drawing.Point(170, 392);
            this.tb_sala.Name = "tb_sala";
            this.tb_sala.Size = new System.Drawing.Size(302, 31);
            this.tb_sala.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 25);
            this.label5.TabIndex = 53;
            this.label5.Text = "Enfermeiro:";
            // 
            // cb_enfermeiros
            // 
            this.cb_enfermeiros.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_enfermeiros.FormattingEnabled = true;
            this.cb_enfermeiros.Location = new System.Drawing.Point(170, 274);
            this.cb_enfermeiros.Name = "cb_enfermeiros";
            this.cb_enfermeiros.Size = new System.Drawing.Size(302, 33);
            this.cb_enfermeiros.TabIndex = 52;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Culture = new System.Globalization.CultureInfo("pt-BR");
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.Location = new System.Drawing.Point(170, 331);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(302, 31);
            this.maskedTextBox1.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Window;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(101, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 25);
            this.label6.TabIndex = 55;
            this.label6.Text = "Data:";
            // 
            // F_Paciente_Historico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_enfermeiros);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_medicos);
            this.Controls.Add(this.tb_diag);
            this.Controls.Add(this.tb_sala);
            this.Controls.Add(this.btn_historico_inserir);
            this.Controls.Add(this.lb_consultas);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_Paciente_Historico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Histórico diagnósticos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.F_Paciente_Historico_FormClosed);
            this.Load += new System.EventHandler(this.F_Paciente_Historico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lb_consultas;
        private System.Windows.Forms.Button btn_historico_inserir;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_medicos;
        private System.Windows.Forms.TextBox tb_diag;
        private System.Windows.Forms.TextBox tb_sala;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_enfermeiros;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label6;
    }
}