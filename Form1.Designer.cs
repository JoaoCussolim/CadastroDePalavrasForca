﻿namespace apListaLigada
{
  partial class FrmAlunos
  {
    /// <summary>
    /// Variável de designer necessária.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpar os recursos que estão sendo usados.
    /// </summary>
    /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código gerado pelo Windows Form Designer

    /// <summary>
    /// Método necessário para suporte ao Designer - não modifique 
    /// o conteúdo deste método com o editor de código.
    /// </summary>
    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlunos));
            this.label2 = new System.Windows.Forms.Label();
            this.txtPalavra = new System.Windows.Forms.TextBox();
            this.txtDica = new System.Windows.Forms.TextBox();
            this.dlgAbrir = new System.Windows.Forms.OpenFileDialog();
            this.dlgSalvar = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnInicio = new System.Windows.Forms.ToolStripButton();
            this.btnAnterior = new System.Windows.Forms.ToolStripButton();
            this.btnProximo = new System.Windows.Forms.ToolStripButton();
            this.btnFim = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSair = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpCadastro = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tpListagem = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbTras = new System.Windows.Forms.RadioButton();
            this.rbFrente = new System.Windows.Forms.RadioButton();
            this.lsbDados = new System.Windows.Forms.ListBox();
            this.tpForca = new System.Windows.Forms.TabPage();
            this.labelNome = new System.Windows.Forms.Label();
            this.LabelSubtituloForca = new System.Windows.Forms.Label();
            this.LabelForca = new System.Windows.Forms.Label();
            this.Corda4 = new System.Windows.Forms.PictureBox();
            this.Corda3 = new System.Windows.Forms.PictureBox();
            this.Corda2 = new System.Windows.Forms.PictureBox();
            this.Corda1 = new System.Windows.Forms.PictureBox();
            this.JuncaoForca = new System.Windows.Forms.PictureBox();
            this.BaseForca2 = new System.Windows.Forms.PictureBox();
            this.BaseForca = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.slRegistro = new System.Windows.Forms.ToolStripStatusLabel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpCadastro.SuspendLayout();
            this.tpListagem.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tpForca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Corda4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Corda3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Corda2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Corda1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JuncaoForca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseForca2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseForca)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dica:";
            // 
            // txtPalavra
            // 
            this.txtPalavra.Location = new System.Drawing.Point(79, 18);
            this.txtPalavra.MaxLength = 30;
            this.txtPalavra.Name = "txtPalavra";
            this.txtPalavra.Size = new System.Drawing.Size(207, 24);
            this.txtPalavra.TabIndex = 3;
            // 
            // txtDica
            // 
            this.txtDica.Location = new System.Drawing.Point(79, 48);
            this.txtDica.Name = "txtDica";
            this.txtDica.Size = new System.Drawing.Size(524, 24);
            this.txtDica.TabIndex = 4;
            // 
            // dlgAbrir
            // 
            this.dlgAbrir.DefaultExt = "*.txt";
            this.dlgAbrir.Filter = "Arquivos de texto|*.txt|Qualquer arquivo|*.*";
            // 
            // dlgSalvar
            // 
            this.dlgSalvar.DefaultExt = "*.txt";
            this.dlgSalvar.Title = "Selecione o arquivo para gravação dos dados";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInicio,
            this.btnAnterior,
            this.btnProximo,
            this.btnFim,
            this.toolStripSeparator1,
            this.btnBuscar,
            this.toolStripSeparator3,
            this.btnNovo,
            this.btnEditar,
            this.btnCancelar,
            this.btnExcluir,
            this.toolStripSeparator2,
            this.btnSair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(714, 42);
            this.toolStrip1.TabIndex = 21;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnInicio
            // 
            this.btnInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnInicio.Image")));
            this.btnInicio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(40, 39);
            this.btnInicio.Text = "Início";
            this.btnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Image = ((System.Drawing.Image)(resources.GetObject("btnAnterior.Image")));
            this.btnAnterior.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(54, 39);
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.Image = ((System.Drawing.Image)(resources.GetObject("btnProximo.Image")));
            this.btnProximo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(56, 39);
            this.btnProximo.Text = "Próximo";
            this.btnProximo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnFim
            // 
            this.btnFim.Image = ((System.Drawing.Image)(resources.GetObject("btnFim.Image")));
            this.btnFim.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFim.Name = "btnFim";
            this.btnFim.Size = new System.Drawing.Size(36, 39);
            this.btnFim.Text = "Final";
            this.btnFim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFim.Click += new System.EventHandler(this.btnFim_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 42);
            // 
            // btnBuscar
            // 
            this.btnBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(24, 39);
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 42);
            // 
            // btnNovo
            // 
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(40, 39);
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNovo.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(46, 39);
            this.btnEditar.Text = "Alterar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(57, 39);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(46, 39);
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 42);
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(30, 39);
            this.btnSair.Text = "Sair";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tpCadastro);
            this.tabControl1.Controls.Add(this.tpListagem);
            this.tabControl1.Controls.Add(this.tpForca);
            this.tabControl1.Location = new System.Drawing.Point(12, 55);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(697, 426);
            this.tabControl1.TabIndex = 22;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tpCadastro
            // 
            this.tpCadastro.Controls.Add(this.label1);
            this.tpCadastro.Controls.Add(this.label2);
            this.tpCadastro.Controls.Add(this.txtPalavra);
            this.tpCadastro.Controls.Add(this.txtDica);
            this.tpCadastro.Location = new System.Drawing.Point(4, 26);
            this.tpCadastro.Name = "tpCadastro";
            this.tpCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tpCadastro.Size = new System.Drawing.Size(689, 396);
            this.tpCadastro.TabIndex = 0;
            this.tpCadastro.Text = "Cadastro";
            this.tpCadastro.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Palavra:";
            // 
            // tpListagem
            // 
            this.tpListagem.Controls.Add(this.groupBox1);
            this.tpListagem.Controls.Add(this.lsbDados);
            this.tpListagem.Location = new System.Drawing.Point(4, 22);
            this.tpListagem.Name = "tpListagem";
            this.tpListagem.Padding = new System.Windows.Forms.Padding(3);
            this.tpListagem.Size = new System.Drawing.Size(689, 400);
            this.tpListagem.TabIndex = 1;
            this.tpListagem.Text = "Listagem";
            this.tpListagem.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbTras);
            this.groupBox1.Controls.Add(this.rbFrente);
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 49);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ordem";
            // 
            // rbTras
            // 
            this.rbTras.AutoSize = true;
            this.rbTras.Location = new System.Drawing.Point(121, 22);
            this.rbTras.Name = "rbTras";
            this.rbTras.Size = new System.Drawing.Size(110, 21);
            this.rbTras.TabIndex = 1;
            this.rbTras.Text = "Decrescente";
            this.rbTras.UseVisualStyleBackColor = true;
            this.rbTras.Click += new System.EventHandler(this.rbTras_Click);
            // 
            // rbFrente
            // 
            this.rbFrente.AutoSize = true;
            this.rbFrente.Checked = true;
            this.rbFrente.Location = new System.Drawing.Point(6, 22);
            this.rbFrente.Name = "rbFrente";
            this.rbFrente.Size = new System.Drawing.Size(94, 21);
            this.rbFrente.TabIndex = 0;
            this.rbFrente.TabStop = true;
            this.rbFrente.Text = "Crescente";
            this.rbFrente.UseVisualStyleBackColor = true;
            this.rbFrente.Click += new System.EventHandler(this.rbFrente_Click);
            // 
            // lsbDados
            // 
            this.lsbDados.FormattingEnabled = true;
            this.lsbDados.ItemHeight = 17;
            this.lsbDados.Location = new System.Drawing.Point(7, 62);
            this.lsbDados.Name = "lsbDados";
            this.lsbDados.Size = new System.Drawing.Size(596, 208);
            this.lsbDados.TabIndex = 0;
            // 
            // tpForca
            // 
            this.tpForca.Controls.Add(this.textBox1);
            this.tpForca.Controls.Add(this.labelNome);
            this.tpForca.Controls.Add(this.LabelSubtituloForca);
            this.tpForca.Controls.Add(this.LabelForca);
            this.tpForca.Controls.Add(this.Corda4);
            this.tpForca.Controls.Add(this.Corda3);
            this.tpForca.Controls.Add(this.Corda2);
            this.tpForca.Controls.Add(this.Corda1);
            this.tpForca.Controls.Add(this.JuncaoForca);
            this.tpForca.Controls.Add(this.BaseForca2);
            this.tpForca.Controls.Add(this.BaseForca);
            this.tpForca.Location = new System.Drawing.Point(4, 26);
            this.tpForca.Name = "tpForca";
            this.tpForca.Padding = new System.Windows.Forms.Padding(3);
            this.tpForca.Size = new System.Drawing.Size(689, 396);
            this.tpForca.TabIndex = 2;
            this.tpForca.Text = "Forca";
            this.tpForca.UseVisualStyleBackColor = true;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Arial", 12F);
            this.labelNome.Location = new System.Drawing.Point(364, 114);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(83, 18);
            this.labelNome.TabIndex = 9;
            this.labelNome.Text = "Seu nome:";
            // 
            // LabelSubtituloForca
            // 
            this.LabelSubtituloForca.AutoSize = true;
            this.LabelSubtituloForca.Font = new System.Drawing.Font("Arial", 15F);
            this.LabelSubtituloForca.Location = new System.Drawing.Point(445, 76);
            this.LabelSubtituloForca.Name = "LabelSubtituloForca";
            this.LabelSubtituloForca.Size = new System.Drawing.Size(169, 23);
            this.LabelSubtituloForca.TabIndex = 8;
            this.LabelSubtituloForca.Text = "Adivinhe a palavra";
            // 
            // LabelForca
            // 
            this.LabelForca.AutoSize = true;
            this.LabelForca.Font = new System.Drawing.Font("Arial", 30F);
            this.LabelForca.Location = new System.Drawing.Point(465, 31);
            this.LabelForca.Name = "LabelForca";
            this.LabelForca.Size = new System.Drawing.Size(135, 45);
            this.LabelForca.TabIndex = 7;
            this.LabelForca.Text = "Forca!";
            // 
            // Corda4
            // 
            this.Corda4.BackColor = System.Drawing.Color.Transparent;
            this.Corda4.Image = global::apListaLigada.Properties.Resources.Forca__09;
            this.Corda4.Location = new System.Drawing.Point(128, 182);
            this.Corda4.Name = "Corda4";
            this.Corda4.Size = new System.Drawing.Size(129, 55);
            this.Corda4.TabIndex = 6;
            this.Corda4.TabStop = false;
            // 
            // Corda3
            // 
            this.Corda3.BackColor = System.Drawing.Color.Transparent;
            this.Corda3.Image = global::apListaLigada.Properties.Resources.Forca__08;
            this.Corda3.Location = new System.Drawing.Point(128, 166);
            this.Corda3.Name = "Corda3";
            this.Corda3.Size = new System.Drawing.Size(129, 69);
            this.Corda3.TabIndex = 5;
            this.Corda3.TabStop = false;
            // 
            // Corda2
            // 
            this.Corda2.BackColor = System.Drawing.Color.Transparent;
            this.Corda2.Image = global::apListaLigada.Properties.Resources.Forca__05;
            this.Corda2.Location = new System.Drawing.Point(119, 76);
            this.Corda2.Name = "Corda2";
            this.Corda2.Size = new System.Drawing.Size(129, 90);
            this.Corda2.TabIndex = 4;
            this.Corda2.TabStop = false;
            // 
            // Corda1
            // 
            this.Corda1.BackColor = System.Drawing.Color.Transparent;
            this.Corda1.Image = global::apListaLigada.Properties.Resources.Forca__02;
            this.Corda1.Location = new System.Drawing.Point(128, 21);
            this.Corda1.Name = "Corda1";
            this.Corda1.Size = new System.Drawing.Size(129, 55);
            this.Corda1.TabIndex = 3;
            this.Corda1.TabStop = false;
            // 
            // JuncaoForca
            // 
            this.JuncaoForca.BackColor = System.Drawing.Color.Transparent;
            this.JuncaoForca.Image = global::apListaLigada.Properties.Resources.Forca__01;
            this.JuncaoForca.Location = new System.Drawing.Point(6, 21);
            this.JuncaoForca.Name = "JuncaoForca";
            this.JuncaoForca.Size = new System.Drawing.Size(129, 55);
            this.JuncaoForca.TabIndex = 2;
            this.JuncaoForca.TabStop = false;
            // 
            // BaseForca2
            // 
            this.BaseForca2.BackColor = System.Drawing.Color.Transparent;
            this.BaseForca2.Image = global::apListaLigada.Properties.Resources.Forca__03;
            this.BaseForca2.Location = new System.Drawing.Point(6, 76);
            this.BaseForca2.Name = "BaseForca2";
            this.BaseForca2.Size = new System.Drawing.Size(129, 157);
            this.BaseForca2.TabIndex = 1;
            this.BaseForca2.TabStop = false;
            // 
            // BaseForca
            // 
            this.BaseForca.BackColor = System.Drawing.Color.Transparent;
            this.BaseForca.Image = global::apListaLigada.Properties.Resources.Forca__13;
            this.BaseForca.Location = new System.Drawing.Point(6, 233);
            this.BaseForca.Name = "BaseForca";
            this.BaseForca.Size = new System.Drawing.Size(53, 160);
            this.BaseForca.TabIndex = 0;
            this.BaseForca.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.slRegistro});
            this.statusStrip1.Location = new System.Drawing.Point(0, 487);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(714, 22);
            this.statusStrip1.TabIndex = 23;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(69, 17);
            this.toolStripStatusLabel1.Text = "Mensagem:";
            // 
            // slRegistro
            // 
            this.slRegistro.Name = "slRegistro";
            this.slRegistro.Size = new System.Drawing.Size(70, 17);
            this.slRegistro.Text = "Registro:0/0";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(449, 114);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 24);
            this.textBox1.TabIndex = 10;
            // 
            // FrmAlunos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(714, 509);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmAlunos";
            this.Text = "Manutenção de Dicionário";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAlunos_FormClosing);
            this.Load += new System.EventHandler(this.FrmAlunos_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tpCadastro.ResumeLayout(false);
            this.tpCadastro.PerformLayout();
            this.tpListagem.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tpForca.ResumeLayout(false);
            this.tpForca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Corda4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Corda3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Corda2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Corda1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JuncaoForca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseForca2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseForca)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtPalavra;
    private System.Windows.Forms.TextBox txtDica;
    private System.Windows.Forms.OpenFileDialog dlgAbrir;
    private System.Windows.Forms.SaveFileDialog dlgSalvar;
    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripButton btnInicio;
    private System.Windows.Forms.ToolStripButton btnAnterior;
    private System.Windows.Forms.ToolStripButton btnProximo;
    private System.Windows.Forms.ToolStripButton btnFim;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripButton btnNovo;
    private System.Windows.Forms.ToolStripButton btnEditar;
    private System.Windows.Forms.ToolStripButton btnCancelar;
    private System.Windows.Forms.ToolStripButton btnExcluir;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripButton btnSair;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tpCadastro;
    private System.Windows.Forms.TabPage tpListagem;
    private System.Windows.Forms.ToolStripButton btnBuscar;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.RadioButton rbTras;
    private System.Windows.Forms.RadioButton rbFrente;
    private System.Windows.Forms.ListBox lsbDados;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    private System.Windows.Forms.ToolStripStatusLabel slRegistro;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TabPage tpForca;
        private System.Windows.Forms.PictureBox BaseForca;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox BaseForca2;
        private System.Windows.Forms.PictureBox JuncaoForca;
        private System.Windows.Forms.PictureBox Corda4;
        private System.Windows.Forms.PictureBox Corda3;
        private System.Windows.Forms.PictureBox Corda2;
        private System.Windows.Forms.PictureBox Corda1;
        private System.Windows.Forms.Label LabelSubtituloForca;
        private System.Windows.Forms.Label LabelForca;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox textBox1;
    }
}

