﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace apListaLigada
{
    public partial class FrmAlunos : Form
    {
        ListaDupla<Palavra> lista1;

        public FrmAlunos()
        {
            InitializeComponent();
        }
        bool jogando = false;
        bool comDica = false;
        string PalavraAtual = "";
        int tempo = 30;
        int ponto = 0;
        int erro = 0;
        PictureBox[] imagens;

        private void FazerLeitura(ref ListaDupla<Palavra> qualLista)
        {
            qualLista = new ListaDupla<Palavra>();  // recria a lista a ser lida

            if (dlgAbrir.ShowDialog() == DialogResult.OK)  // usuário pressionou botão Abrir?
            {
                StreamReader arquivo = new StreamReader(dlgAbrir.FileName);
                string linha = "";
                while (!arquivo.EndOfStream)  // enquanto não acabou o arquivo
                {
                    linha = arquivo.ReadLine();
                    qualLista.InserirAposFim(new Palavra(linha));
                }
                arquivo.Close();
            }

            // pedir ao usuário o nome       // instanciar a lista de palavras e dicas do arquivo de entrada
            // abrir esse arquivo e lê-lo linha a linha
            // para cada linha, criar um objeto da classe de Palavra e Dica
            // e inseri-0lo no final da lista duplamente ligada
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if(txtDica.Text != "" && txtPalavra.Text != "")
            {
                Palavra novaPalavra = new Palavra(txtPalavra.Text, txtDica.Text);
                if (lista1.InserirEmOrdem(novaPalavra))
                {
                    MessageBox.Show("Incluido com sucesso!");
                    btnInicio.PerformClick();
                }
                else
                {
                    MessageBox.Show("A palavra já existe!");
                }
            }
            // se o usuário digitou palavra e dica:
            // criar objeto da classe Palavra e Dica para busca
            // tentar incluir em ordem esse objeto na lista1
            // se não incluiu (já existe) avisar o usuário
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtPalavra.Text != "")
            {
                Palavra busca = new Palavra(txtPalavra.Text, "");
                if (lista1.Existe(busca))
                {
                    ExibirRegistroAtual();
                }
                else
                {
                    MessageBox.Show("Essa palavra não existe!");
                }

            }
            // se a palavra digitada não é vazia:
            // criar um objeto da classe de Palavra e Dica para busca
            // se a palavra existe na lista1, posicionar o ponteiro atual nesse nó e exibir o registro atual
            // senão, avisar usuário que a palavra não existe
            // exibir o nó atual
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir esse nó?", "Excluir nó", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes) 
            {
                if(lista1.Atual == lista1.Ultimo)
                {
                    lista1.Remover(lista1.Atual.Info);
                    MessageBox.Show("Nó excluido com sucesso!");
                    btnAnterior.PerformClick();
                }
                else
                {
                    lista1.Remover(lista1.Atual.Info);
                    MessageBox.Show("Nó excluido com sucesso!");
                    btnProximo.PerformClick();
                }
            }

            // para o nó atualmente visitado e exibido na tela:
            // perguntar ao usuário se realmente deseja excluir essa palavra e dica
            // se sim, remover o nó atual da lista duplamente ligada e exibir o próximo nó
            // se não, manter como está
        }

        private void FrmAlunos_FormClosing(object sender, FormClosingEventArgs e)
        {
            lista1.GravarDados(dlgAbrir.FileName);
            // solicitar ao usuário que escolha o arquivo de saída
            // percorrer a lista ligada e gravar seus dados no arquivo de saída
        }

        private void ExibirDados(ListaDupla<Palavra> aLista, ListBox lsb, Direcao qualDirecao)
        {
            lsb.Items.Clear();
            var dadosDaLista = aLista.Listagem(qualDirecao);
            foreach (Palavra palavra in dadosDaLista)
                lsb.Items.Add(palavra);
        }

        private void rbFrente_Click(object sender, EventArgs e)
        {
            ExibirDados(lista1, lsbDados, Direcao.paraFrente);
        }

        private void rbTras_Click(object sender, EventArgs e)
        {
            ExibirDados(lista1, lsbDados, Direcao.paraTras);
        }

        private void FrmAlunos_Load(object sender, EventArgs e)
        {
            FazerLeitura(ref lista1);
            lista1.PosicionarNoInicio();
            ExibirRegistroAtual();
            // fazer a leitura do arquivo escolhido pelo usuário e armazená-lo na lista1
            // posicionar o ponteiro atual no início da lista duplamente ligada
            // Exibir o Registro Atual;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            lista1.PosicionarNoInicio();
            ExibirRegistroAtual();
            // posicionar o ponteiro atual no início da lista duplamente ligada
            // Exibir o Registro Atual;
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            lista1.Retroceder();
            ExibirRegistroAtual();
            // Retroceder o ponteiro atual para o nó imediatamente anterior 
            // Exibir o Registro Atual;
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            lista1.Avancar();
            ExibirRegistroAtual();
            // Avançar o ponteiro atual para o nó seguinte 
            // Exibir o Registro Atual;
        }

        private void btnFim_Click(object sender, EventArgs e)
        {
            lista1.PosicionarNoFinal();
            ExibirRegistroAtual();
            // posicionar o ponteiro atual no último nó da lista 
            // Exibir o Registro Atual;
        }

        private void ExibirRegistroAtual()
        {
            if (!lista1.EstaVazia)
            {
                txtPalavra.Text = lista1.Atual.Info.PalavraInfo;
                txtDica.Text = lista1.Atual.Info.Dica;

                slRegistro.Text = $"Registro:{lista1.NumeroDoNoAtual + 1}/{lista1.QuantosNos}";
            }
            // se a lista não está vazia:
            // acessar o nó atual e exibir seus campos em txtDica e txtPalavra
            // atualizar no status bar o número do registro atual / quantos nós na lista
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            lista1.Atual.Info.Dica = txtDica.Text;
            MessageBox.Show("A dica foi alterada");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                rbFrente.PerformClick();
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            imagens = new PictureBox[] {forca_1, forca_2,forca_3,forca_4,forca_5,forca_6,forca_7,forca_8};
            jogando = true;
            Random rng = new Random();
            tempo = 30;
            erro = 0;
            ponto = 0;
            lblTempo.Text = tempo.ToString();
            lblPonto.Text = ponto.ToString();
            lblErros.Text = erro.ToString();
            int ind = rng.Next(lista1.QuantosNos);
            lista1.PosicionarNoInicio();
            for (int i = 0; i < ind; i++) lista1.Avancar();
            PalavraAtual = lista1.Atual.Info.PalavraInfo.TrimEnd().ToUpper();
            dicaChck.Enabled = false;
            if (comDica)
            {
                timer.Enabled = true;
                dicaTxt.Text = lista1.Atual.Info.Dica;
            }
            gridGastas.Columns.Clear();
            gridGastas.ColumnCount = PalavraAtual.Length;
            foreach(DataGridViewColumn column in gridGastas.Columns)
            {
                column.Width = 25;
            }

        }

        private void dicaChck_CheckedChanged(object sender, EventArgs e)
        {
            comDica = dicaChck.Checked;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            tempo--;
            lblTempo.Text = tempo.ToString();
        }


        private void btnLetra_Click(object sender, EventArgs e)
        {
            Button botaoClicado = sender as Button;
            if (jogando)
            {
                botaoClicado.Enabled = false;
                if (PalavraAtual.Contains(botaoClicado.Text))
                {
                    ponto++;
                    lblPonto.Text = ponto.ToString();

                    for (int i = 0; i < PalavraAtual.Length; i++)
                    {
                        if (PalavraAtual[i].ToString() == botaoClicado.Text)
                        {
                            gridGastas.Rows[0].Cells[i].Value = botaoClicado.Text;
                        }
                    }
                }
                else
                {
                    erro++;
                    if (erro >= 9)
                    {
                        forcadead_1.Visible = true;
                        forca_1.Visible = false;
                        forcadead_2.Visible = true;
                    }
                    else
                    {
                        imagens[erro - 1].Visible = true;
                        
                        lblErros.Text = erro.ToString();
                    }
                    
                        
                    
                }
            }
        }
    }
}