
namespace TrabalhoPostoDeSaude
{
    partial class F_Paciente_Exame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Paciente_Exame));
            this.tb1_nome_exame = new System.Windows.Forms.TextBox();
            this.tb2_data_exame = new System.Windows.Forms.TextBox();
            this.lb_lista_exames = new System.Windows.Forms.ListBox();
            this.btn_pac_exames_inserir = new System.Windows.Forms.Button();
            this.btn_pac_exames_apagar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_id_exame = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_cpf_med = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb1_nome_exame
            // 
            this.tb1_nome_exame.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb1_nome_exame.Location = new System.Drawing.Point(170, 102);
            this.tb1_nome_exame.Name = "tb1_nome_exame";
            this.tb1_nome_exame.Size = new System.Drawing.Size(340, 31);
            this.tb1_nome_exame.TabIndex = 0;
            // 
            // tb2_data_exame
            // 
            this.tb2_data_exame.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb2_data_exame.Location = new System.Drawing.Point(170, 152);
            this.tb2_data_exame.Name = "tb2_data_exame";
            this.tb2_data_exame.Size = new System.Drawing.Size(340, 31);
            this.tb2_data_exame.TabIndex = 1;
            // 
            // lb_lista_exames
            // 
            this.lb_lista_exames.BackColor = System.Drawing.SystemColors.Window;
            this.lb_lista_exames.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_lista_exames.FormattingEnabled = true;
            this.lb_lista_exames.ItemHeight = 22;
            this.lb_lista_exames.Location = new System.Drawing.Point(87, 227);
            this.lb_lista_exames.Name = "lb_lista_exames";
            this.lb_lista_exames.Size = new System.Drawing.Size(782, 312);
            this.lb_lista_exames.TabIndex = 2;
            // 
            // btn_pac_exames_inserir
            // 
            this.btn_pac_exames_inserir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_pac_exames_inserir.BackgroundImage")));
            this.btn_pac_exames_inserir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pac_exames_inserir.FlatAppearance.BorderSize = 0;
            this.btn_pac_exames_inserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pac_exames_inserir.Location = new System.Drawing.Point(766, 125);
            this.btn_pac_exames_inserir.Name = "btn_pac_exames_inserir";
            this.btn_pac_exames_inserir.Size = new System.Drawing.Size(138, 58);
            this.btn_pac_exames_inserir.TabIndex = 3;
            this.btn_pac_exames_inserir.UseVisualStyleBackColor = true;
            this.btn_pac_exames_inserir.Click += new System.EventHandler(this.btn_pac_exames_inserir_Click);
            // 
            // btn_pac_exames_apagar
            // 
            this.btn_pac_exames_apagar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_pac_exames_apagar.BackgroundImage")));
            this.btn_pac_exames_apagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_pac_exames_apagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pac_exames_apagar.FlatAppearance.BorderSize = 0;
            this.btn_pac_exames_apagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pac_exames_apagar.Location = new System.Drawing.Point(423, 559);
            this.btn_pac_exames_apagar.Name = "btn_pac_exames_apagar";
            this.btn_pac_exames_apagar.Size = new System.Drawing.Size(138, 58);
            this.btn_pac_exames_apagar.TabIndex = 4;
            this.btn_pac_exames_apagar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome do exame:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Data entrega:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(332, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(324, 43);
            this.label3.TabIndex = 7;
            this.label3.Text = "Insira um novo exame:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(516, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Código exame:";
            // 
            // tb_id_exame
            // 
            this.tb_id_exame.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_id_exame.Location = new System.Drawing.Point(650, 102);
            this.tb_id_exame.Name = "tb_id_exame";
            this.tb_id_exame.Size = new System.Drawing.Size(110, 31);
            this.tb_id_exame.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(538, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cpf médico:";
            // 
            // tb_cpf_med
            // 
            this.tb_cpf_med.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cpf_med.Location = new System.Drawing.Point(650, 152);
            this.tb_cpf_med.Name = "tb_cpf_med";
            this.tb_cpf_med.Size = new System.Drawing.Size(110, 31);
            this.tb_cpf_med.TabIndex = 10;
            // 
            // F_Paciente_Exame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_cpf_med);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_id_exame);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_pac_exames_apagar);
            this.Controls.Add(this.btn_pac_exames_inserir);
            this.Controls.Add(this.lb_lista_exames);
            this.Controls.Add(this.tb2_data_exame);
            this.Controls.Add(this.tb1_nome_exame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_Paciente_Exame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exames do paciente";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.F_Paciente_Exame_FormClosed);
            this.Load += new System.EventHandler(this.F_Paciente_Exame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb1_nome_exame;
        private System.Windows.Forms.TextBox tb2_data_exame;
        private System.Windows.Forms.ListBox lb_lista_exames;
        private System.Windows.Forms.Button btn_pac_exames_inserir;
        private System.Windows.Forms.Button btn_pac_exames_apagar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_id_exame;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_cpf_med;
    }
}