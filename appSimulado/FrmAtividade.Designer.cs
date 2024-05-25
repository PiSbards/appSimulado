namespace appSimulado
{
    partial class FrmAtividade
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
            this.lblAtvId = new System.Windows.Forms.Label();
            this.lblAtvNome = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastrarAtividade = new System.Windows.Forms.Button();
            this.dgvAtividade = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblNomeProfessor = new System.Windows.Forms.Label();
            this.lblIdProf = new System.Windows.Forms.Label();
            this.lblIdTurma = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtividade)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAtvId
            // 
            this.lblAtvId.AutoSize = true;
            this.lblAtvId.Location = new System.Drawing.Point(538, 245);
            this.lblAtvId.Name = "lblAtvId";
            this.lblAtvId.Size = new System.Drawing.Size(0, 13);
            this.lblAtvId.TabIndex = 19;
            // 
            // lblAtvNome
            // 
            this.lblAtvNome.AutoSize = true;
            this.lblAtvNome.Location = new System.Drawing.Point(538, 279);
            this.lblAtvNome.Name = "lblAtvNome";
            this.lblAtvNome.Size = new System.Drawing.Size(0, 13);
            this.lblAtvNome.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(524, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "ATIVIDADE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(512, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "SELECIONE UMA ATIVIDADE:";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(593, 318);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(146, 32);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.Text = "Excluir Atividade";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "ATIVIDADES";
            // 
            // btnCadastrarAtividade
            // 
            this.btnCadastrarAtividade.Location = new System.Drawing.Point(12, 73);
            this.btnCadastrarAtividade.Name = "btnCadastrarAtividade";
            this.btnCadastrarAtividade.Size = new System.Drawing.Size(120, 39);
            this.btnCadastrarAtividade.TabIndex = 12;
            this.btnCadastrarAtividade.Text = "Nova Atividade";
            this.btnCadastrarAtividade.UseVisualStyleBackColor = true;
            // 
            // dgvAtividade
            // 
            this.dgvAtividade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtividade.Location = new System.Drawing.Point(12, 156);
            this.dgvAtividade.Name = "dgvAtividade";
            this.dgvAtividade.Size = new System.Drawing.Size(494, 194);
            this.dgvAtividade.TabIndex = 11;
            this.dgvAtividade.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAtividade_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnVoltar);
            this.panel1.Controls.Add(this.lblNomeProfessor);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 40);
            this.panel1.TabIndex = 20;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(668, 7);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblNomeProfessor
            // 
            this.lblNomeProfessor.AutoSize = true;
            this.lblNomeProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProfessor.Location = new System.Drawing.Point(13, 12);
            this.lblNomeProfessor.Name = "lblNomeProfessor";
            this.lblNomeProfessor.Size = new System.Drawing.Size(0, 15);
            this.lblNomeProfessor.TabIndex = 0;
            // 
            // lblIdProf
            // 
            this.lblIdProf.AutoSize = true;
            this.lblIdProf.BackColor = System.Drawing.Color.Transparent;
            this.lblIdProf.ForeColor = System.Drawing.Color.Transparent;
            this.lblIdProf.Location = new System.Drawing.Point(687, 60);
            this.lblIdProf.Name = "lblIdProf";
            this.lblIdProf.Size = new System.Drawing.Size(0, 13);
            this.lblIdProf.TabIndex = 0;
            // 
            // lblIdTurma
            // 
            this.lblIdTurma.AutoSize = true;
            this.lblIdTurma.BackColor = System.Drawing.Color.Transparent;
            this.lblIdTurma.ForeColor = System.Drawing.Color.Transparent;
            this.lblIdTurma.Location = new System.Drawing.Point(310, 60);
            this.lblIdTurma.Name = "lblIdTurma";
            this.lblIdTurma.Size = new System.Drawing.Size(0, 13);
            this.lblIdTurma.TabIndex = 21;
            // 
            // FrmAtividade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 359);
            this.Controls.Add(this.lblIdTurma);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblIdProf);
            this.Controls.Add(this.lblAtvId);
            this.Controls.Add(this.lblAtvNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCadastrarAtividade);
            this.Controls.Add(this.dgvAtividade);
            this.Name = "FrmAtividade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAtividade";
            this.Load += new System.EventHandler(this.FrmAtividade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtividade)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAtvId;
        private System.Windows.Forms.Label lblAtvNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastrarAtividade;
        private System.Windows.Forms.DataGridView dgvAtividade;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblNomeProfessor;
        private System.Windows.Forms.Label lblIdProf;
        private System.Windows.Forms.Label lblIdTurma;
    }
}