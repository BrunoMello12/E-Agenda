namespace E_Agenda.WinFormsApp.ModuloTarefa
{
    partial class TelaCadastroItensForm
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
            txtTitulo = new TextBox();
            txtId = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            btnGravar = new Button();
            txtTituloItem = new TextBox();
            label3 = new Label();
            listItens = new ListBox();
            btnAdicionar = new Button();
            SuspendLayout();
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(134, 112);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.ReadOnly = true;
            txtTitulo.Size = new Size(203, 23);
            txtTitulo.TabIndex = 8;
            // 
            // txtId
            // 
            txtId.Location = new Point(134, 69);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(86, 23);
            txtId.TabIndex = 7;
            txtId.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(64, 110);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 6;
            label2.Text = "Título:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(96, 69);
            label1.Name = "label1";
            label1.Size = new Size(32, 25);
            label1.TabIndex = 5;
            label1.Text = "Id:";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(318, 362);
            button2.Name = "button2";
            button2.Size = new Size(75, 44);
            button2.TabIndex = 10;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(232, 362);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 44);
            btnGravar.TabIndex = 9;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // txtTituloItem
            // 
            txtTituloItem.Location = new Point(134, 152);
            txtTituloItem.Name = "txtTituloItem";
            txtTituloItem.Size = new Size(173, 23);
            txtTituloItem.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(30, 150);
            label3.Name = "label3";
            label3.Size = new Size(98, 25);
            label3.TabIndex = 11;
            label3.Text = "Descrição:";
            // 
            // listItens
            // 
            listItens.FormattingEnabled = true;
            listItens.ItemHeight = 15;
            listItens.Location = new Point(30, 196);
            listItens.Name = "listItens";
            listItens.Size = new Size(343, 139);
            listItens.TabIndex = 13;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(318, 152);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 14;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // TelaCadastroItensForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 418);
            Controls.Add(btnAdicionar);
            Controls.Add(listItens);
            Controls.Add(txtTituloItem);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(btnGravar);
            Controls.Add(txtTitulo);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TelaCadastroItensForm";
            Text = "TelaCadastroItensForm";
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox txtTitulo;
        private TextBox txtId;
        private Label label2;
        private Label label1;
        private Button button2;
        private Button btnGravar;
        private TextBox txtTituloItem;
        private Label label3;
        private ListBox listItens;
        private Button btnAdicionar;
    }
    #endregion
}
