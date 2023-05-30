namespace E_Agenda.WinFormsApp.ModuloCategorias
{
    partial class TelaCategoriasForm
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
            txtId = new TextBox();
            label2 = new Label();
            txtTitulo = new TextBox();
            button2 = new Button();
            btnGravar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(64, 62);
            label1.Name = "label1";
            label1.Size = new Size(26, 21);
            label1.TabIndex = 0;
            label1.Text = "Id:";
            // 
            // txtId
            // 
            txtId.Location = new Point(105, 62);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 1;
            txtId.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(47, 114);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 2;
            label2.Text = "Título:";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(105, 114);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(100, 23);
            txtTitulo.TabIndex = 3;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(207, 209);
            button2.Name = "button2";
            button2.Size = new Size(75, 33);
            button2.TabIndex = 23;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(126, 209);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 33);
            btnGravar.TabIndex = 22;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // TelaCategoriasForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 254);
            Controls.Add(button2);
            Controls.Add(btnGravar);
            Controls.Add(txtTitulo);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Name = "TelaCategoriasForm";
            Text = "TelaCategoriasForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtId;
        private Label label2;
        private TextBox txtTitulo;
        private Button button2;
        private Button btnGravar;
    }
}