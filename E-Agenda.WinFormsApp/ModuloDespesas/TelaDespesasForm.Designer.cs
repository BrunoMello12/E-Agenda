namespace E_Agenda.WinFormsApp.ModuloDespesas
{
    partial class TelaDespesasForm
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
            txtId = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtDescricao = new TextBox();
            label3 = new Label();
            txtValor = new TextBox();
            label4 = new Label();
            txtData = new DateTimePicker();
            label5 = new Label();
            cmbPagamento = new ComboBox();
            groupBox1 = new GroupBox();
            listCategorias = new CheckedListBox();
            button2 = new Button();
            btnGravar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(115, 48);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 0;
            txtId.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(83, 46);
            label1.Name = "label1";
            label1.Size = new Size(26, 21);
            label1.TabIndex = 1;
            label1.Text = "Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(29, 77);
            label2.Name = "label2";
            label2.Size = new Size(80, 21);
            label2.TabIndex = 2;
            label2.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(115, 77);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(175, 23);
            txtDescricao.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(60, 111);
            label3.Name = "label3";
            label3.Size = new Size(49, 21);
            label3.TabIndex = 4;
            label3.Text = "Valor:";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(115, 109);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(100, 23);
            txtValor.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(60, 142);
            label4.Name = "label4";
            label4.Size = new Size(45, 21);
            label4.TabIndex = 6;
            label4.Text = "Data:";
            // 
            // txtData
            // 
            txtData.Format = DateTimePickerFormat.Short;
            txtData.Location = new Point(111, 142);
            txtData.Name = "txtData";
            txtData.Size = new Size(104, 23);
            txtData.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 177);
            label5.Name = "label5";
            label5.Size = new Size(115, 21);
            label5.TabIndex = 8;
            label5.Text = "Forma de pgto:";
            // 
            // cmbPagamento
            // 
            cmbPagamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPagamento.FormattingEnabled = true;
            cmbPagamento.Location = new Point(133, 179);
            cmbPagamento.Name = "cmbPagamento";
            cmbPagamento.Size = new Size(121, 23);
            cmbPagamento.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listCategorias);
            groupBox1.Location = new Point(29, 222);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(322, 173);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Categorias";
            // 
            // listCategorias
            // 
            listCategorias.Dock = DockStyle.Fill;
            listCategorias.FormattingEnabled = true;
            listCategorias.Location = new Point(3, 19);
            listCategorias.Name = "listCategorias";
            listCategorias.Size = new Size(316, 151);
            listCategorias.TabIndex = 0;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(273, 413);
            button2.Name = "button2";
            button2.Size = new Size(75, 44);
            button2.TabIndex = 12;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(187, 413);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 44);
            btnGravar.TabIndex = 11;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // TelaDespesasForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 469);
            Controls.Add(button2);
            Controls.Add(btnGravar);
            Controls.Add(groupBox1);
            Controls.Add(cmbPagamento);
            Controls.Add(label5);
            Controls.Add(txtData);
            Controls.Add(label4);
            Controls.Add(txtValor);
            Controls.Add(label3);
            Controls.Add(txtDescricao);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtId);
            Name = "TelaDespesasForm";
            Text = "TelaDespesasForm";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private Label label1;
        private Label label2;
        private TextBox txtDescricao;
        private Label label3;
        private TextBox txtValor;
        private Label label4;
        private DateTimePicker txtData;
        private Label label5;
        private ComboBox cmbPagamento;
        private GroupBox groupBox1;
        private CheckedListBox listCategorias;
        private Button button2;
        private Button btnGravar;
    }
}