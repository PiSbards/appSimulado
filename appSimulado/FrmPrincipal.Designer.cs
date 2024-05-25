namespace appSimulado
{
    partial class FrmPrincipal
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
            this.lblIdProf = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeslogar = new System.Windows.Forms.Button();
            this.lblNomeProfessor = new System.Windows.Forms.Label();
            this.dgvTurma = new System.Windows.Forms.DataGridView();
            this.btnCadastrarTurma = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTurma = new System.Windows.Forms.Label();
            this.btnAtividade = new System.Windows.Forms.Button();
            this.lblTurmaID = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurma)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdProf
            // 
            this.lblIdProf.AutoSize = true;
            this.lblIdProf.BackColor = System.Drawing.Color.Transparent;
            this.lblIdProf.ForeColor = System.Drawing.Color.Transparent;
            this.lblIdProf.Location = new System.Drawing.Point(693, 69);
            this.lblIdProf.Name = "lblIdProf";
            this.lblIdProf.Size = new System.Drawing.Size(0, 13);
            this.lblIdProf.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnDeslogar);
            this.panel1.Controls.Add(this.lblNomeProfessor);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 40);
            this.panel1.TabIndex = 1;
            // 
            // btnDeslogar
            // 
            this.btnDeslogar.Location = new System.Drawing.Point(668, 7);
            this.btnDeslogar.Name = "btnDeslogar";
            this.btnDeslogar.Size = new System.Drawing.Size(75, 23);
            this.btnDeslogar.TabIndex = 1;
            this.btnDeslogar.Text = "LogOff";
            this.btnDeslogar.UseVisualStyleBackColor = true;
            this.btnDeslogar.Click += new System.EventHandler(this.btnDeslogar_Click);
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
            // dgvTurma
            // 
            this.dgvTurma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurma.Location = new System.Drawing.Point(16, 152);
            this.dgvTurma.Name = "dgvTurma";
            this.dgvTurma.Size = new System.Drawing.Size(494, 194);
            this.dgvTurma.TabIndex = 2;
            this.dgvTurma.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTurma_CellClick);
            // 
            // btnCadastrarTurma
            // 
            this.btnCadastrarTurma.Location = new System.Drawing.Point(16, 69);
            this.btnCadastrarTurma.Name = "btnCadastrarTurma";
            this.btnCadastrarTurma.Size = new System.Drawing.Size(120, 39);
            this.btnCadastrarTurma.TabIndex = 3;
            this.btnCadastrarTurma.Text = "Nova Turma";
            this.btnCadastrarTurma.UseVisualStyleBackColor = true;
            this.btnCadastrarTurma.Click += new System.EventHandler(this.btnCadastrarTurma_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "TURMAS";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(641, 314);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(102, 32);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "Excluir Turma";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(516, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "SELECIONE UMA TURMA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(528, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Turma:";
            // 
            // lblTurma
            // 
            this.lblTurma.AutoSize = true;
            this.lblTurma.Location = new System.Drawing.Point(542, 275);
            this.lblTurma.Name = "lblTurma";
            this.lblTurma.Size = new System.Drawing.Size(0, 13);
            this.lblTurma.TabIndex = 8;
            // 
            // btnAtividade
            // 
            this.btnAtividade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtividade.Location = new System.Drawing.Point(531, 314);
            this.btnAtividade.Name = "btnAtividade";
            this.btnAtividade.Size = new System.Drawing.Size(104, 32);
            this.btnAtividade.TabIndex = 9;
            this.btnAtividade.Text = "Visualizar Ativs.";
            this.btnAtividade.UseVisualStyleBackColor = true;
            this.btnAtividade.Click += new System.EventHandler(this.btnAtividade_Click);
            // 
            // lblTurmaID
            // 
            this.lblTurmaID.AutoSize = true;
            this.lblTurmaID.Location = new System.Drawing.Point(542, 241);
            this.lblTurmaID.Name = "lblTurmaID";
            this.lblTurmaID.Size = new System.Drawing.Size(0, 13);
            this.lblTurmaID.TabIndex = 10;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(371, 123);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 11;
            this.btnAtualizar.Text = "atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 360);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.lblTurmaID);
            this.Controls.Add(this.btnAtividade);
            this.Controls.Add(this.lblIdProf);
            this.Controls.Add(this.lblTurma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCadastrarTurma);
            this.Controls.Add(this.dgvTurma);
            this.Controls.Add(this.panel1);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdProf;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDeslogar;
        private System.Windows.Forms.Label lblNomeProfessor;
        private System.Windows.Forms.DataGridView dgvTurma;
        private System.Windows.Forms.Button btnCadastrarTurma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTurma;
        private System.Windows.Forms.Button btnAtividade;
        private System.Windows.Forms.Label lblTurmaID;
        private System.Windows.Forms.Button btnAtualizar;
    }
}