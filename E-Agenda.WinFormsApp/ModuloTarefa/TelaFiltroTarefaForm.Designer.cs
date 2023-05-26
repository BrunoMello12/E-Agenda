namespace E_Agenda.WinFormsApp.ModuloTarefa
{
    partial class TelaFiltroTarefaForm
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
            button2 = new Button();
            btnFiltrar = new Button();
            rdbTarefasPendentes = new RadioButton();
            rdbTarefasConcluidas = new RadioButton();
            rdbTodasTarefas = new RadioButton();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(350, 168);
            button2.Name = "button2";
            button2.Size = new Size(84, 39);
            button2.TabIndex = 14;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnFiltrar.DialogResult = DialogResult.OK;
            btnFiltrar.Location = new Point(260, 168);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(84, 39);
            btnFiltrar.TabIndex = 13;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // rdbTarefasPendentes
            // 
            rdbTarefasPendentes.AutoSize = true;
            rdbTarefasPendentes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdbTarefasPendentes.Location = new Point(25, 120);
            rdbTarefasPendentes.Name = "rdbTarefasPendentes";
            rdbTarefasPendentes.Size = new Size(286, 25);
            rdbTarefasPendentes.TabIndex = 12;
            rdbTarefasPendentes.TabStop = true;
            rdbTarefasPendentes.Text = "Visualizar somente Tarefas Pendentes";
            rdbTarefasPendentes.UseVisualStyleBackColor = true;
            // 
            // rdbTarefasConcluidas
            // 
            rdbTarefasConcluidas.AutoSize = true;
            rdbTarefasConcluidas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdbTarefasConcluidas.Location = new Point(25, 77);
            rdbTarefasConcluidas.Name = "rdbTarefasConcluidas";
            rdbTarefasConcluidas.Size = new Size(288, 25);
            rdbTarefasConcluidas.TabIndex = 11;
            rdbTarefasConcluidas.TabStop = true;
            rdbTarefasConcluidas.Text = "Visualizar somente Tarefas concluídas";
            rdbTarefasConcluidas.UseVisualStyleBackColor = true;
            // 
            // rdbTodasTarefas
            // 
            rdbTodasTarefas.AutoSize = true;
            rdbTodasTarefas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdbTodasTarefas.Location = new Point(25, 33);
            rdbTodasTarefas.Name = "rdbTodasTarefas";
            rdbTodasTarefas.Size = new Size(208, 25);
            rdbTodasTarefas.TabIndex = 10;
            rdbTodasTarefas.TabStop = true;
            rdbTodasTarefas.Text = "Visualizar todas as Tarefas";
            rdbTodasTarefas.UseVisualStyleBackColor = true;
            // 
            // TelaFiltroTarefaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 219);
            Controls.Add(button2);
            Controls.Add(btnFiltrar);
            Controls.Add(rdbTarefasPendentes);
            Controls.Add(rdbTarefasConcluidas);
            Controls.Add(rdbTodasTarefas);
            Name = "TelaFiltroTarefaForm";
            Text = "TelaFiltroTarefaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button btnFiltrar;
        private RadioButton rdbTarefasPendentes;
        private RadioButton rdbTarefasConcluidas;
        private RadioButton rdbTodasTarefas;
    }
}