namespace E_Agenda.WinFormsApp.ModuloCategorias
{
    partial class TelaVisualizarCategoriasForm
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
            groupBox1 = new GroupBox();
            label2 = new Label();
            listDespesas = new ListBox();
            btnFechar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(66, 55);
            label1.Name = "label1";
            label1.Size = new Size(80, 21);
            label1.TabIndex = 0;
            label1.Text = "Categoria:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listDespesas);
            groupBox1.Location = new Point(35, 91);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(444, 280);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Despesas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(152, 55);
            label2.Name = "label2";
            label2.Size = new Size(36, 21);
            label2.TabIndex = 3;
            label2.Text = "LBL";
            // 
            // listDespesas
            // 
            listDespesas.Dock = DockStyle.Fill;
            listDespesas.FormattingEnabled = true;
            listDespesas.ItemHeight = 15;
            listDespesas.Location = new Point(3, 19);
            listDespesas.Name = "listDespesas";
            listDespesas.Size = new Size(438, 258);
            listDespesas.TabIndex = 0;
            // 
            // btnFechar
            // 
            btnFechar.DialogResult = DialogResult.Cancel;
            btnFechar.Location = new Point(391, 395);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(88, 43);
            btnFechar.TabIndex = 4;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            // 
            // TelaVisualizaçãoCategoriasForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 450);
            Controls.Add(btnFechar);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "TelaVisualizaçãoCategoriasForm";
            Text = "TelaVisualizaçãoCategoriasForm";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private ListBox listDespesas;
        private Label label2;
        private Button btnFechar;
    }
}