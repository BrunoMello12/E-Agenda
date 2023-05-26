namespace E_Agenda.WinFormsApp.ModuloCompromisso
{
    partial class TelaFiltro
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
            rdbCompromissosTodos = new RadioButton();
            rdbCompromissosPassados = new RadioButton();
            rdbCompromissosFuturos = new RadioButton();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // rdbCompromissosTodos
            // 
            rdbCompromissosTodos.AutoSize = true;
            rdbCompromissosTodos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdbCompromissosTodos.Location = new Point(29, 54);
            rdbCompromissosTodos.Name = "rdbCompromissosTodos";
            rdbCompromissosTodos.Size = new Size(268, 25);
            rdbCompromissosTodos.TabIndex = 0;
            rdbCompromissosTodos.TabStop = true;
            rdbCompromissosTodos.Text = "Visualizar Todos os Compromissos";
            rdbCompromissosTodos.UseVisualStyleBackColor = true;
            // 
            // rdbCompromissosPassados
            // 
            rdbCompromissosPassados.AutoSize = true;
            rdbCompromissosPassados.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdbCompromissosPassados.Location = new Point(29, 98);
            rdbCompromissosPassados.Name = "rdbCompromissosPassados";
            rdbCompromissosPassados.Size = new Size(335, 25);
            rdbCompromissosPassados.TabIndex = 1;
            rdbCompromissosPassados.TabStop = true;
            rdbCompromissosPassados.Text = "Visualizar somente Compromissos Passados";
            rdbCompromissosPassados.UseVisualStyleBackColor = true;
            // 
            // rdbCompromissosFuturos
            // 
            rdbCompromissosFuturos.AutoSize = true;
            rdbCompromissosFuturos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdbCompromissosFuturos.Location = new Point(29, 141);
            rdbCompromissosFuturos.Name = "rdbCompromissosFuturos";
            rdbCompromissosFuturos.Size = new Size(325, 25);
            rdbCompromissosFuturos.TabIndex = 2;
            rdbCompromissosFuturos.TabStop = true;
            rdbCompromissosFuturos.Text = "Visualizar somente Compromissos Futuros";
            rdbCompromissosFuturos.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(227, 218);
            button1.Name = "button1";
            button1.Size = new Size(84, 39);
            button1.TabIndex = 8;
            button1.Text = "Filtrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(317, 218);
            button2.Name = "button2";
            button2.Size = new Size(84, 39);
            button2.TabIndex = 9;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // TelaFiltro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 269);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(rdbCompromissosFuturos);
            Controls.Add(rdbCompromissosPassados);
            Controls.Add(rdbCompromissosTodos);
            Name = "TelaFiltro";
            Text = "TelaFiltro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rdbCompromissosTodos;
        private RadioButton rdbCompromissosPassados;
        private RadioButton rdbCompromissosFuturos;
        private Button button1;
        private Button button2;
    }
}