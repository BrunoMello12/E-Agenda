namespace E_Agenda.WinFormsApp.ModuloContato
{
    partial class TelaContatoForm
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
            btnGravar = new Button();
            label1 = new Label();
            txtId = new TextBox();
            label2 = new Label();
            txtNome = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtTelefone = new TextBox();
            txtEmpresa = new TextBox();
            txtEmail = new TextBox();
            txtCargo = new TextBox();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(417, 270);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(92, 42);
            btnGravar.TabIndex = 2;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(74, 47);
            label1.Name = "label1";
            label1.Size = new Size(26, 21);
            label1.TabIndex = 4;
            label1.Text = "Id:";
            // 
            // txtId
            // 
            txtId.Location = new Point(107, 47);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 5;
            txtId.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(45, 96);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 6;
            label2.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(107, 98);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(517, 23);
            txtNome.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(30, 150);
            label3.Name = "label3";
            label3.Size = new Size(70, 21);
            label3.TabIndex = 8;
            label3.Text = "Telefone:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(27, 198);
            label4.Name = "label4";
            label4.Size = new Size(73, 21);
            label4.TabIndex = 9;
            label4.Text = "Empresa:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(345, 150);
            label5.Name = "label5";
            label5.Size = new Size(57, 21);
            label5.TabIndex = 10;
            label5.Text = "E-mail:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(347, 202);
            label6.Name = "label6";
            label6.Size = new Size(55, 21);
            label6.TabIndex = 11;
            label6.Text = "Cargo:";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(107, 150);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(216, 23);
            txtTelefone.TabIndex = 12;
            // 
            // txtEmpresa
            // 
            txtEmpresa.Location = new Point(106, 200);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.Size = new Size(216, 23);
            txtEmpresa.TabIndex = 13;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(408, 152);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(216, 23);
            txtEmail.TabIndex = 14;
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(408, 204);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(216, 23);
            txtCargo.TabIndex = 15;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(515, 270);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(92, 42);
            btnCancelar.TabIndex = 16;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaContatoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 324);
            Controls.Add(btnCancelar);
            Controls.Add(txtCargo);
            Controls.Add(txtEmail);
            Controls.Add(txtEmpresa);
            Controls.Add(txtTelefone);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(btnGravar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaContatoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro De Contatos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnGravar;
        private Label label1;
        private TextBox txtId;
        private Label label2;
        private TextBox txtNome;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtTelefone;
        private TextBox txtEmpresa;
        private TextBox txtEmail;
        private TextBox txtCargo;
        private Button btnCancelar;
        private Button button2;
    }
}