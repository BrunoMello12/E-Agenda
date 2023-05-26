namespace E_Agenda.WinFormsApp.ModuloTarefa
{
    partial class TelaAtualizacaoItensForm
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
            btnGravar = new Button();
            txtTitulo = new TextBox();
            txtId = new TextBox();
            label2 = new Label();
            label1 = new Label();
            listItens = new CheckedListBox();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(304, 269);
            button2.Name = "button2";
            button2.Size = new Size(75, 44);
            button2.TabIndex = 20;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(218, 269);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 44);
            btnGravar.TabIndex = 19;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(126, 67);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.ReadOnly = true;
            txtTitulo.Size = new Size(203, 23);
            txtTitulo.TabIndex = 18;
            // 
            // txtId
            // 
            txtId.Location = new Point(126, 24);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(86, 23);
            txtId.TabIndex = 17;
            txtId.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(56, 65);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 16;
            label2.Text = "Título:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(88, 24);
            label1.Name = "label1";
            label1.Size = new Size(32, 25);
            label1.TabIndex = 15;
            label1.Text = "Id:";
            // 
            // listItens
            // 
            listItens.FormattingEnabled = true;
            listItens.Location = new Point(36, 111);
            listItens.Name = "listItens";
            listItens.Size = new Size(332, 148);
            listItens.TabIndex = 21;
            // 
            // TelaAtualizacaoItensForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 325);
            Controls.Add(listItens);
            Controls.Add(button2);
            Controls.Add(btnGravar);
            Controls.Add(txtTitulo);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TelaAtualizacaoItensForm";
            Text = "TelaAtualizacaoItensForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button btnGravar;
        private TextBox txtTitulo;
        private TextBox txtId;
        private Label label2;
        private Label label1;
        private CheckedListBox listItens;
    }
}