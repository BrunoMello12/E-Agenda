namespace E_Agenda.WinFormsApp.ModuloTarefa
{
    partial class TelaTarefaForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtId = new TextBox();
            txtTitulo = new TextBox();
            button1 = new Button();
            button2 = new Button();
            rdbPrioridadeBaixa = new RadioButton();
            rdbPrioridadeMedia = new RadioButton();
            rdbPrioridadeAlta = new RadioButton();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(89, 55);
            label1.Name = "label1";
            label1.Size = new Size(32, 25);
            label1.TabIndex = 0;
            label1.Text = "Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(57, 96);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 1;
            label2.Text = "Título:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 148);
            label3.Name = "label3";
            label3.Size = new Size(109, 25);
            label3.TabIndex = 2;
            label3.Text = "Prioridade: ";
            // 
            // txtId
            // 
            txtId.Location = new Point(127, 55);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 3;
            txtId.Text = "0";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(127, 98);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(132, 23);
            txtTitulo.TabIndex = 4;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(169, 243);
            button1.Name = "button1";
            button1.Size = new Size(75, 44);
            button1.TabIndex = 6;
            button1.Text = "Gravar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(255, 243);
            button2.Name = "button2";
            button2.Size = new Size(75, 44);
            button2.TabIndex = 7;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // rdbPrioridadeBaixa
            // 
            rdbPrioridadeBaixa.AutoSize = true;
            rdbPrioridadeBaixa.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            rdbPrioridadeBaixa.Location = new Point(127, 149);
            rdbPrioridadeBaixa.Name = "rdbPrioridadeBaixa";
            rdbPrioridadeBaixa.Size = new Size(63, 24);
            rdbPrioridadeBaixa.TabIndex = 8;
            rdbPrioridadeBaixa.TabStop = true;
            rdbPrioridadeBaixa.Text = "Baixa";
            rdbPrioridadeBaixa.UseVisualStyleBackColor = true;
            // 
            // rdbPrioridadeMedia
            // 
            rdbPrioridadeMedia.AutoSize = true;
            rdbPrioridadeMedia.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            rdbPrioridadeMedia.Location = new Point(201, 149);
            rdbPrioridadeMedia.Name = "rdbPrioridadeMedia";
            rdbPrioridadeMedia.Size = new Size(69, 24);
            rdbPrioridadeMedia.TabIndex = 9;
            rdbPrioridadeMedia.TabStop = true;
            rdbPrioridadeMedia.Text = "Media";
            rdbPrioridadeMedia.UseVisualStyleBackColor = true;
            // 
            // rdbPrioridadeAlta
            // 
            rdbPrioridadeAlta.AutoSize = true;
            rdbPrioridadeAlta.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            rdbPrioridadeAlta.Location = new Point(287, 149);
            rdbPrioridadeAlta.Name = "rdbPrioridadeAlta";
            rdbPrioridadeAlta.Size = new Size(54, 24);
            rdbPrioridadeAlta.TabIndex = 10;
            rdbPrioridadeAlta.TabStop = true;
            rdbPrioridadeAlta.Text = "Alta";
            rdbPrioridadeAlta.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(61, 193);
            label4.Name = "label4";
            label4.Size = new Size(60, 25);
            label4.TabIndex = 11;
            label4.Text = "Data: ";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(127, 195);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(117, 23);
            dateTimePicker1.TabIndex = 12;
            // 
            // TelaTarefaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 299);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(rdbPrioridadeAlta);
            Controls.Add(rdbPrioridadeMedia);
            Controls.Add(rdbPrioridadeBaixa);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtTitulo);
            Controls.Add(txtId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TelaTarefaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaTarefaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtId;
        private TextBox txtTitulo;
        private Button button1;
        private Button button2;
        private RadioButton rdbPrioridadeBaixa;
        private RadioButton rdbPrioridadeMedia;
        private RadioButton rdbPrioridadeAlta;
        private Label label4;
        private DateTimePicker dateTimePicker1;
    }
}