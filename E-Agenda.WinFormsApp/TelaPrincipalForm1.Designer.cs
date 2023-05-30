namespace E_Agenda.WinFormsApp
{
    partial class TelaPrincipalForm1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            cadastrosMenuItem = new ToolStripMenuItem();
            contatosMenuItem = new ToolStripMenuItem();
            compromissosMenuItem = new ToolStripMenuItem();
            tarefasToolStripMenuItem = new ToolStripMenuItem();
            despesasMenuItem = new ToolStripMenuItem();
            desespesasMenuItem = new ToolStripMenuItem();
            categoriasMenuItem = new ToolStripMenuItem();
            relatóriosMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblRodape = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            btnInserir = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnExcluir = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnFiltrar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnAdicionar = new ToolStripButton();
            btnAtualizar = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            lblTipoCadastro = new ToolStripLabel();
            pnlRegistros = new Panel();
            btnVisualizar = new ToolStripButton();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosMenuItem, relatóriosMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosMenuItem
            // 
            cadastrosMenuItem.DropDownItems.AddRange(new ToolStripItem[] { contatosMenuItem, compromissosMenuItem, tarefasToolStripMenuItem, despesasMenuItem });
            cadastrosMenuItem.Name = "cadastrosMenuItem";
            cadastrosMenuItem.Size = new Size(71, 20);
            cadastrosMenuItem.Text = "Cadastros";
            // 
            // contatosMenuItem
            // 
            contatosMenuItem.Name = "contatosMenuItem";
            contatosMenuItem.Size = new Size(154, 22);
            contatosMenuItem.Text = "Contatos";
            contatosMenuItem.Click += contatosMenuItem_Click;
            // 
            // compromissosMenuItem
            // 
            compromissosMenuItem.Name = "compromissosMenuItem";
            compromissosMenuItem.Size = new Size(154, 22);
            compromissosMenuItem.Text = "Compromissos";
            compromissosMenuItem.Click += compromissosMenuItem_Click;
            // 
            // tarefasToolStripMenuItem
            // 
            tarefasToolStripMenuItem.Name = "tarefasToolStripMenuItem";
            tarefasToolStripMenuItem.Size = new Size(154, 22);
            tarefasToolStripMenuItem.Text = "Tarefas";
            tarefasToolStripMenuItem.Click += tarefasToolStripMenuItem_Click;
            // 
            // despesasMenuItem
            // 
            despesasMenuItem.DropDownItems.AddRange(new ToolStripItem[] { desespesasMenuItem, categoriasMenuItem });
            despesasMenuItem.Name = "despesasMenuItem";
            despesasMenuItem.Size = new Size(154, 22);
            despesasMenuItem.Text = "Despesas";
            // 
            // desespesasMenuItem
            // 
            desespesasMenuItem.Name = "desespesasMenuItem";
            desespesasMenuItem.Size = new Size(133, 22);
            desespesasMenuItem.Text = "Desespesas";
            desespesasMenuItem.Click += desespesasMenuItem_Click;
            // 
            // categoriasMenuItem
            // 
            categoriasMenuItem.Name = "categoriasMenuItem";
            categoriasMenuItem.Size = new Size(133, 22);
            categoriasMenuItem.Text = "Categorias";
            categoriasMenuItem.Click += categoriasMenuItem_Click;
            // 
            // relatóriosMenuItem
            // 
            relatóriosMenuItem.Name = "relatóriosMenuItem";
            relatóriosMenuItem.Size = new Size(71, 20);
            relatóriosMenuItem.Text = "Relatórios";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblRodape });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblRodape
            // 
            lblRodape.Name = "lblRodape";
            lblRodape.Size = new Size(118, 17);
            lblRodape.Text = "toolStripStatusLabel1";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnInserir, btnEditar, btnExcluir, toolStripSeparator2, btnFiltrar, toolStripSeparator1, btnAdicionar, btnAtualizar, toolStripSeparator3, btnVisualizar, lblTipoCadastro });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 45);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnInserir
            // 
            btnInserir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnInserir.Image = Properties.Resources.add_circle_FILL0_wght400_GRAD0_opsz24;
            btnInserir.ImageScaling = ToolStripItemImageScaling.None;
            btnInserir.ImageTransparentColor = Color.Magenta;
            btnInserir.Name = "btnInserir";
            btnInserir.Padding = new Padding(7);
            btnInserir.Size = new Size(42, 42);
            btnInserir.Text = "toolStripButton1";
            btnInserir.Click += btnInserir_Click;
            // 
            // btnEditar
            // 
            btnEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEditar.Image = Properties.Resources.edit_FILL0_wght400_GRAD0_opsz24;
            btnEditar.ImageScaling = ToolStripItemImageScaling.None;
            btnEditar.ImageTransparentColor = Color.Magenta;
            btnEditar.Name = "btnEditar";
            btnEditar.Padding = new Padding(7);
            btnEditar.Size = new Size(42, 42);
            btnEditar.Text = "toolStripButton2";
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnExcluir.Image = Properties.Resources.delete_FILL0_wght400_GRAD0_opsz24;
            btnExcluir.ImageScaling = ToolStripItemImageScaling.None;
            btnExcluir.ImageTransparentColor = Color.Magenta;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Padding = new Padding(7);
            btnExcluir.Size = new Size(42, 42);
            btnExcluir.Text = "toolStripButton3";
            btnExcluir.Click += btnExcluir_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 45);
            // 
            // btnFiltrar
            // 
            btnFiltrar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnFiltrar.Image = Properties.Resources.filter_list_FILL0_wght400_GRAD0_opsz24;
            btnFiltrar.ImageScaling = ToolStripItemImageScaling.None;
            btnFiltrar.ImageTransparentColor = Color.Magenta;
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Padding = new Padding(7);
            btnFiltrar.Size = new Size(42, 42);
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 45);
            // 
            // btnAdicionar
            // 
            btnAdicionar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAdicionar.Image = Properties.Resources.library_add_FILL0_wght400_GRAD0_opsz24;
            btnAdicionar.ImageScaling = ToolStripItemImageScaling.None;
            btnAdicionar.ImageTransparentColor = Color.Magenta;
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Padding = new Padding(7);
            btnAdicionar.Size = new Size(42, 42);
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAtualizar.Image = Properties.Resources.check_FILL0_wght400_GRAD0_opsz24;
            btnAtualizar.ImageScaling = ToolStripItemImageScaling.None;
            btnAtualizar.ImageTransparentColor = Color.Magenta;
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Padding = new Padding(7);
            btnAtualizar.Size = new Size(42, 42);
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 45);
            // 
            // lblTipoCadastro
            // 
            lblTipoCadastro.Name = "lblTipoCadastro";
            lblTipoCadastro.Size = new Size(77, 42);
            lblTipoCadastro.Text = "TipoCadastro";
            // 
            // pnlRegistros
            // 
            pnlRegistros.BorderStyle = BorderStyle.FixedSingle;
            pnlRegistros.Dock = DockStyle.Fill;
            pnlRegistros.Location = new Point(0, 69);
            pnlRegistros.Name = "pnlRegistros";
            pnlRegistros.Size = new Size(800, 359);
            pnlRegistros.TabIndex = 3;
            // 
            // btnVisualizar
            // 
            btnVisualizar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnVisualizar.Image = Properties.Resources.search_FILL0_wght400_GRAD0_opsz24;
            btnVisualizar.ImageScaling = ToolStripItemImageScaling.None;
            btnVisualizar.ImageTransparentColor = Color.Magenta;
            btnVisualizar.Name = "btnVisualizar";
            btnVisualizar.Padding = new Padding(7);
            btnVisualizar.Size = new Size(42, 42);
            btnVisualizar.Click += btnVisualizar_Click;
            // 
            // TelaPrincipalForm1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlRegistros);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "TelaPrincipalForm1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "e- Agenda 1.0";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrosMenuItem;
        private ToolStripMenuItem contatosMenuItem;
        private ToolStripMenuItem compromissosMenuItem;
        private ToolStripMenuItem tarefasToolStripMenuItem;
        private ToolStripMenuItem despesasMenuItem;
        private ToolStripMenuItem desespesasMenuItem;
        private ToolStripMenuItem categoriasMenuItem;
        private ToolStripMenuItem relatóriosMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblRodape;
        private ToolStrip toolStrip1;
        private ToolStripButton btnInserir;
        private ToolStripButton btnEditar;
        private ToolStripButton btnExcluir;
        private Panel pnlRegistros;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel lblTipoCadastro;
        private ToolStripButton btnFiltrar;
        private ToolStripButton btnAdicionar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton btnAtualizar;
        private ToolStripButton btnVisualizar;
    }
}