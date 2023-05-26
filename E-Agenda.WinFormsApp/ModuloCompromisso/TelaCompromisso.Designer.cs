namespace E_Agenda.WinFormsApp.ModuloCompromisso
{
    partial class TelaCompromisso
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
            label6 = new Label();
            label7 = new Label();
            label9 = new Label();
            ckbSelecionarContato = new CheckBox();
            cmbContatos = new ComboBox();
            rdbRemoto = new RadioButton();
            rdbPresencial = new RadioButton();
            txtLocalRemoto = new TextBox();
            txtLocalPresencial = new TextBox();
            txtId = new TextBox();
            txtAssunto = new TextBox();
            txtData = new DateTimePicker();
            txtHorarioInicio = new DateTimePicker();
            txtHorarioTermino = new DateTimePicker();
            btnGravar = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(57, 24);
            label1.Name = "label1";
            label1.Size = new Size(26, 21);
            label1.TabIndex = 0;
            label1.Text = "Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(14, 70);
            label2.Name = "label2";
            label2.Size = new Size(69, 21);
            label2.TabIndex = 1;
            label2.Text = "Assunto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(38, 112);
            label3.Name = "label3";
            label3.Size = new Size(45, 21);
            label3.TabIndex = 2;
            label3.Text = "Data:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(33, 153);
            label6.Name = "label6";
            label6.Size = new Size(50, 21);
            label6.TabIndex = 5;
            label6.Text = "Início:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(33, 307);
            label7.Name = "label7";
            label7.Size = new Size(92, 21);
            label7.TabIndex = 6;
            label7.Text = "Localização:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(200, 153);
            label9.Name = "label9";
            label9.Size = new Size(69, 21);
            label9.TabIndex = 8;
            label9.Text = "Término:";
            // 
            // ckbSelecionarContato
            // 
            ckbSelecionarContato.AutoSize = true;
            ckbSelecionarContato.Location = new Point(26, 218);
            ckbSelecionarContato.Name = "ckbSelecionarContato";
            ckbSelecionarContato.Size = new Size(273, 19);
            ckbSelecionarContato.TabIndex = 9;
            ckbSelecionarContato.Text = "Deseja marcar um contato neste comprimisso?";
            ckbSelecionarContato.UseVisualStyleBackColor = true;
            ckbSelecionarContato.CheckedChanged += ckbSelecionarContato_CheckedChanged;
            // 
            // cmbContatos
            // 
            cmbContatos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbContatos.Enabled = false;
            cmbContatos.FormattingEnabled = true;
            cmbContatos.Location = new Point(26, 243);
            cmbContatos.Name = "cmbContatos";
            cmbContatos.Size = new Size(160, 23);
            cmbContatos.TabIndex = 10;
            // 
            // rdbRemoto
            // 
            rdbRemoto.AutoSize = true;
            rdbRemoto.Location = new Point(134, 305);
            rdbRemoto.Name = "rdbRemoto";
            rdbRemoto.Size = new Size(70, 19);
            rdbRemoto.TabIndex = 11;
            rdbRemoto.TabStop = true;
            rdbRemoto.Text = "Remoto:";
            rdbRemoto.UseVisualStyleBackColor = true;
            rdbRemoto.CheckedChanged += rdbRemoto_CheckedChanged;
            // 
            // rdbPresencial
            // 
            rdbPresencial.AutoSize = true;
            rdbPresencial.Location = new Point(134, 337);
            rdbPresencial.Name = "rdbPresencial";
            rdbPresencial.Size = new Size(81, 19);
            rdbPresencial.TabIndex = 12;
            rdbPresencial.TabStop = true;
            rdbPresencial.Text = "Presencial:";
            rdbPresencial.UseVisualStyleBackColor = true;
            rdbPresencial.CheckedChanged += rdbPresencial_CheckedChanged;
            // 
            // txtLocalRemoto
            // 
            txtLocalRemoto.Enabled = false;
            txtLocalRemoto.Location = new Point(222, 305);
            txtLocalRemoto.Name = "txtLocalRemoto";
            txtLocalRemoto.Size = new Size(206, 23);
            txtLocalRemoto.TabIndex = 13;
            // 
            // txtLocalPresencial
            // 
            txtLocalPresencial.Enabled = false;
            txtLocalPresencial.Location = new Point(222, 337);
            txtLocalPresencial.Name = "txtLocalPresencial";
            txtLocalPresencial.Size = new Size(206, 23);
            txtLocalPresencial.TabIndex = 14;
            // 
            // txtId
            // 
            txtId.Location = new Point(89, 26);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(97, 23);
            txtId.TabIndex = 15;
            txtId.Text = "0";
            // 
            // txtAssunto
            // 
            txtAssunto.Location = new Point(89, 72);
            txtAssunto.Name = "txtAssunto";
            txtAssunto.Size = new Size(339, 23);
            txtAssunto.TabIndex = 16;
            // 
            // txtData
            // 
            txtData.Format = DateTimePickerFormat.Short;
            txtData.Location = new Point(89, 112);
            txtData.Name = "txtData";
            txtData.Size = new Size(155, 23);
            txtData.TabIndex = 17;
            // 
            // txtHorarioInicio
            // 
            txtHorarioInicio.CustomFormat = "HH:mm";
            txtHorarioInicio.Format = DateTimePickerFormat.Custom;
            txtHorarioInicio.Location = new Point(89, 153);
            txtHorarioInicio.Name = "txtHorarioInicio";
            txtHorarioInicio.ShowUpDown = true;
            txtHorarioInicio.Size = new Size(97, 23);
            txtHorarioInicio.TabIndex = 18;
            // 
            // txtHorarioTermino
            // 
            txtHorarioTermino.CustomFormat = "HH:mm";
            txtHorarioTermino.Format = DateTimePickerFormat.Custom;
            txtHorarioTermino.Location = new Point(275, 153);
            txtHorarioTermino.Name = "txtHorarioTermino";
            txtHorarioTermino.ShowUpDown = true;
            txtHorarioTermino.Size = new Size(97, 23);
            txtHorarioTermino.TabIndex = 19;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(275, 412);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 33);
            btnGravar.TabIndex = 20;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(356, 412);
            button2.Name = "button2";
            button2.Size = new Size(75, 33);
            button2.TabIndex = 21;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // TelaCompromisso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 457);
            Controls.Add(button2);
            Controls.Add(btnGravar);
            Controls.Add(txtHorarioTermino);
            Controls.Add(txtHorarioInicio);
            Controls.Add(txtData);
            Controls.Add(txtAssunto);
            Controls.Add(txtId);
            Controls.Add(txtLocalPresencial);
            Controls.Add(txtLocalRemoto);
            Controls.Add(rdbPresencial);
            Controls.Add(rdbRemoto);
            Controls.Add(cmbContatos);
            Controls.Add(ckbSelecionarContato);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TelaCompromisso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaCompromisso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label6;
        private Label label7;
        private Label label9;
        private CheckBox ckbSelecionarContato;
        private ComboBox cmbContatos;
        private RadioButton rdbRemoto;
        private RadioButton rdbPresencial;
        private TextBox txtLocalRemoto;
        private TextBox txtLocalPresencial;
        private TextBox txtId;
        private TextBox txtAssunto;
        private DateTimePicker txtData;
        private DateTimePicker txtHorarioInicio;
        private DateTimePicker txtHorarioTermino;
        private Button btnGravar;
        private Button button2;
    }
}