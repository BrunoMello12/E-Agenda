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
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            FiltroFuturo = new Panel();
            FiltroFuturo.SuspendLayout();
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
            rdbCompromissosTodos.CheckedChanged += rdbCompromissosTodos_CheckedChanged;
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
            rdbCompromissosPassados.CheckedChanged += rdbCompromissosPassados_CheckedChanged;
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
            rdbCompromissosFuturos.CheckedChanged += rdbCompromissosFuturos_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(7, 9);
            label1.Name = "label1";
            label1.Size = new Size(270, 21);
            label1.TabIndex = 3;
            label1.Text = "Filtro para os Compromissos Futuros:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(126, 42);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(94, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(126, 86);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(94, 23);
            dateTimePicker2.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(31, 44);
            label2.Name = "label2";
            label2.Size = new Size(89, 21);
            label2.TabIndex = 6;
            label2.Text = "Data Inicial:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(38, 87);
            label3.Name = "label3";
            label3.Size = new Size(82, 21);
            label3.TabIndex = 7;
            label3.Text = "Data Final:";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(227, 346);
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
            button2.Location = new Point(317, 346);
            button2.Name = "button2";
            button2.Size = new Size(84, 39);
            button2.TabIndex = 9;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // FiltroFuturo
            // 
            FiltroFuturo.Controls.Add(label1);
            FiltroFuturo.Controls.Add(dateTimePicker1);
            FiltroFuturo.Controls.Add(dateTimePicker2);
            FiltroFuturo.Controls.Add(label3);
            FiltroFuturo.Controls.Add(label2);
            FiltroFuturo.Location = new Point(48, 172);
            FiltroFuturo.Name = "FiltroFuturo";
            FiltroFuturo.Size = new Size(306, 168);
            FiltroFuturo.TabIndex = 10;
            FiltroFuturo.Visible = false;
            // 
            // TelaFiltro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 397);
            Controls.Add(FiltroFuturo);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(rdbCompromissosFuturos);
            Controls.Add(rdbCompromissosPassados);
            Controls.Add(rdbCompromissosTodos);
            Name = "TelaFiltro";
            Text = "TelaFiltro";
            FiltroFuturo.ResumeLayout(false);
            FiltroFuturo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rdbCompromissosTodos;
        private RadioButton rdbCompromissosPassados;
        private RadioButton rdbCompromissosFuturos;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Panel FiltroFuturo;
    }
}