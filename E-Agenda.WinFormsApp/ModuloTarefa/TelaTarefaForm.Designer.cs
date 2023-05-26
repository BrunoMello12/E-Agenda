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
            btnGravar = new Button();
            button2 = new Button();
            label4 = new Label();
            txtData = new DateTimePicker();
            cmbPrioridade = new ComboBox();
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
            txtId.Size = new Size(86, 23);
            txtId.TabIndex = 3;
            txtId.Text = "0";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(127, 98);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(203, 23);
            txtTitulo.TabIndex = 4;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(169, 243);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 44);
            btnGravar.TabIndex = 6;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
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
            // txtData
            // 
            txtData.Format = DateTimePickerFormat.Short;
            txtData.Location = new Point(127, 195);
            txtData.Name = "txtData";
            txtData.Size = new Size(117, 23);
            txtData.TabIndex = 12;
            // 
            // cmbPrioridade
            // 
            cmbPrioridade.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPrioridade.FormattingEnabled = true;
            cmbPrioridade.Location = new Point(123, 153);
            cmbPrioridade.Name = "cmbPrioridade";
            cmbPrioridade.Size = new Size(121, 23);
            cmbPrioridade.TabIndex = 13;
            // 
            // TelaTarefaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 299);
            Controls.Add(cmbPrioridade);
            Controls.Add(txtData);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(btnGravar);
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
        private Button btnGravar;
        private Button button2;
        private Label label4;
        private DateTimePicker txtData;
        private ComboBox cmbPrioridade;
    }
}