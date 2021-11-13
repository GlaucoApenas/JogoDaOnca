using JogoDaOnça.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace JogoDaOnça
{
    public partial class Jogo : BaseForm
    {
        private bool _click;
        private bool _vezJogador;
        private List<Posicao> _tabuleiro;
        private Movimento _movimento;
        private Button _btnOrigem;
        private Button _btnDestino;
        private int _cachorrosMortos;

        public Jogo()
        {
            InitializeComponent();
            _vezJogador = false;
            _movimento = new Movimento();
            _btnOrigem = new Button();
            _btnDestino = new Button();
            _cachorrosMortos = 0;
            _tabuleiro = CriarTabuleiro();
        }

        private void btn_1_1_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
                GetButtonName(button);
        }

        private void btn_1_2_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
                GetButtonName(button);
        }

        private void btn_1_3_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
                GetButtonName(button);
        }

        private void btn_1_4_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
                GetButtonName(button);
        }

        private void btn_1_5_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
                GetButtonName(button);
        }

        private void btn_2_1_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
                GetButtonName(button);
        }

        private void btn_2_2_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
                GetButtonName(button);
        }

        private void btn_2_3_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
                GetButtonName(button);
        }

        private void btn_2_4_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
                GetButtonName(button);
        }

        private void btn_2_5_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
                GetButtonName(button);
        }

        private void btn_3_1_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
                GetButtonName(button);
        }

        private void btn_3_2_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
                GetButtonName(button);
        }

        private void btn_3_3_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
                GetButtonName(button);
        }

        private void btn_3_4_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
                GetButtonName(button);
        }

        private void btn_3_5_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
                GetButtonName(button);
        }

        private void btn_4_1_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
                GetButtonName(button);
        }

        private void btn_4_2_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
                GetButtonName(button);
        }

        private void btn_4_3_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
                GetButtonName(button);
        }

        private void btn_4_4_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
                GetButtonName(button);
        }

        private void btn_4_5_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
                GetButtonName(button);
        }

        private void btn_5_1_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
                GetButtonName(button);
        }

        private void btn_5_2_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
                GetButtonName(button);
        }

        private void btn_5_3_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
                GetButtonName(button);
        }

        private void btn_5_4_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
                GetButtonName(button);
        }

        private void btn_5_5_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
                GetButtonName(button);
        }

        private void btn_6_2_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
                GetButtonName(button);
        }

        private void btn_6_3_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
                GetButtonName(button);
        }

        private void btn_6_4_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
                GetButtonName(button);
        }

        private void btn_7_1_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
                GetButtonName(button);
        }

        private void btn_7_3_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
                GetButtonName(button);
        }

        private void btn_7_5_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
                GetButtonName(button);
        }

        private void GetButtonName(Button button)
        {
            var x = button.Name.Split('_')[1];
            var y = button.Name.Split('_')[2];

            var check = _tabuleiro.Where(t => t.X.ToString() == x && t.Y.ToString() == y).FirstOrDefault();

            PegaPecaMovimento(check, button);
        }
        private List<Posicao> CriarTabuleiro()
        {
            var tabuleiro = new List<Posicao>();

            // Primeira Coluna do Tabuleiro
            tabuleiro.Add(new Posicao(1, 1, true, new List<Movimento> {
                new Movimento(new Posicao(1, 1), new Posicao(1, 2)),
                new Movimento(new Posicao(1, 1), new Posicao(2, 1)),
                new Movimento(new Posicao(1, 1), new Posicao(2, 2))
            }, false));

            tabuleiro.Add(new Posicao(2, 1, true, new List<Movimento> {
                new Movimento(new Posicao(2, 1), new Posicao(1, 1)),
                new Movimento(new Posicao(2, 1), new Posicao(3, 1)),
                new Movimento(new Posicao(2, 1), new Posicao(2, 2))
            }, false));

            tabuleiro.Add(new Posicao(3, 1, true, new List<Movimento> {
                new Movimento(new Posicao(3, 1), new Posicao(2, 1)),
                new Movimento(new Posicao(3, 1), new Posicao(4, 1)),
                new Movimento(new Posicao(3, 1), new Posicao(2, 2)),
                new Movimento(new Posicao(3, 1), new Posicao(3, 2)),
                new Movimento(new Posicao(3, 1), new Posicao(4, 2))
            }, false));

            tabuleiro.Add(new Posicao(4, 1, false, new List<Movimento> {
                new Movimento(new Posicao(4, 1), new Posicao(3, 1)),
                new Movimento(new Posicao(4, 1), new Posicao(5, 1)),
                new Movimento(new Posicao(4, 1), new Posicao(4, 2))
            }));

            tabuleiro.Add(new Posicao(5, 1, false, new List<Movimento> {
                new Movimento(new Posicao(5, 1), new Posicao(4, 1)),
                new Movimento(new Posicao(5, 1), new Posicao(4, 2)),
                new Movimento(new Posicao(5, 1), new Posicao(5, 2))
            }));

            tabuleiro.Add(new Posicao(7, 1, false, new List<Movimento> {
                new Movimento(new Posicao(7, 1), new Posicao(6, 2)),
                new Movimento(new Posicao(7, 1), new Posicao(7, 3))
            }));

            // Segunda Coluna do Tabuleiro
            tabuleiro.Add(new Posicao(1, 2, true, new List<Movimento> {
                new Movimento(new Posicao(1, 2), new Posicao(1, 1)),
                new Movimento(new Posicao(1, 2), new Posicao(1, 3)),
                new Movimento(new Posicao(1, 2), new Posicao(2, 2))
            }, false));

            tabuleiro.Add(new Posicao(2, 2, true, new List<Movimento> {
                new Movimento(new Posicao(2, 2), new Posicao(1, 1)),
                new Movimento(new Posicao(2, 2), new Posicao(1, 2)),
                new Movimento(new Posicao(2, 2), new Posicao(1, 3)),
                new Movimento(new Posicao(2, 2), new Posicao(2, 3)),
                new Movimento(new Posicao(2, 2), new Posicao(2, 1)),
                new Movimento(new Posicao(2, 2), new Posicao(3, 1)),
                new Movimento(new Posicao(2, 2), new Posicao(3, 2)),
                new Movimento(new Posicao(2, 2), new Posicao(3, 3)),
            }, false));

            tabuleiro.Add(new Posicao(3, 2, true, new List<Movimento> {
                new Movimento(new Posicao(3, 2), new Posicao(2, 2)),
                new Movimento(new Posicao(3, 2), new Posicao(3, 1)),
                new Movimento(new Posicao(3, 2), new Posicao(3, 3)),
                new Movimento(new Posicao(3, 2), new Posicao(4, 2))
            }, false));

            tabuleiro.Add(new Posicao(4, 2, false, new List<Movimento> {
                new Movimento(new Posicao(4, 2), new Posicao(3, 1)),
                new Movimento(new Posicao(4, 2), new Posicao(3, 2)),
                new Movimento(new Posicao(4, 2), new Posicao(3, 3)),
                new Movimento(new Posicao(4, 2), new Posicao(4, 1)),
                new Movimento(new Posicao(4, 2), new Posicao(4, 3)),
                new Movimento(new Posicao(4, 2), new Posicao(5, 1)),
                new Movimento(new Posicao(4, 2), new Posicao(5, 2)),
                new Movimento(new Posicao(4, 2), new Posicao(5, 3)),
            }));

            tabuleiro.Add(new Posicao(5, 2, false, new List<Movimento> {
                new Movimento(new Posicao(5, 2), new Posicao(4, 2)),
                new Movimento(new Posicao(5, 2), new Posicao(5, 1)),
                new Movimento(new Posicao(5, 2), new Posicao(5, 3)),
            }));

            tabuleiro.Add(new Posicao(6, 2, false, new List<Movimento> {
                new Movimento(new Posicao(6, 2), new Posicao(5, 3)),
                new Movimento(new Posicao(6, 2), new Posicao(6, 3)),
                new Movimento(new Posicao(6, 2), new Posicao(7, 1))
            }));

            // Terceira Coluna do Tabuleiro
            tabuleiro.Add(new Posicao(1, 3, true, new List<Movimento> {
                new Movimento(new Posicao(1, 3), new Posicao(1, 2)),
                new Movimento(new Posicao(1, 3), new Posicao(1, 4)),
                new Movimento(new Posicao(1, 3), new Posicao(2, 2)),
                new Movimento(new Posicao(1, 3), new Posicao(2, 3)),
                new Movimento(new Posicao(1, 3), new Posicao(2, 4)),
            }, false));

            tabuleiro.Add(new Posicao(2, 3, true, new List<Movimento> {
                new Movimento(new Posicao(2, 3), new Posicao(1, 3)),
                new Movimento(new Posicao(2, 3), new Posicao(2, 2)),
                new Movimento(new Posicao(2, 3), new Posicao(2, 4)),
                new Movimento(new Posicao(2, 3), new Posicao(3, 3)),
            }, false));

            tabuleiro.Add(new Posicao(3, 3, true, new List<Movimento> {
                new Movimento(new Posicao(3, 3), new Posicao(2, 2)),
                new Movimento(new Posicao(3, 3), new Posicao(2, 3)),
                new Movimento(new Posicao(3, 3), new Posicao(2, 4)),
                new Movimento(new Posicao(3, 3), new Posicao(3, 2)),
                new Movimento(new Posicao(3, 3), new Posicao(3, 4)),
                new Movimento(new Posicao(3, 3), new Posicao(4, 2)),
                new Movimento(new Posicao(3, 3), new Posicao(4, 3)),
                new Movimento(new Posicao(3, 3), new Posicao(4, 4)),
            }, true));

            tabuleiro.Add(new Posicao(4, 3, false, new List<Movimento> {
                new Movimento(new Posicao(4, 3), new Posicao(3, 3)),
                new Movimento(new Posicao(4, 3), new Posicao(4, 2)),
                new Movimento(new Posicao(4, 3), new Posicao(4, 4)),
                new Movimento(new Posicao(4, 3), new Posicao(5, 3)),
            }));

            tabuleiro.Add(new Posicao(5, 3, false, new List<Movimento> {
                new Movimento(new Posicao(5, 3), new Posicao(4, 2)),
                new Movimento(new Posicao(5, 3), new Posicao(4, 3)),
                new Movimento(new Posicao(5, 3), new Posicao(4, 4)),
                new Movimento(new Posicao(5, 3), new Posicao(5, 2)),
                new Movimento(new Posicao(5, 3), new Posicao(5, 4)),
                new Movimento(new Posicao(5, 3), new Posicao(6, 2)),
                new Movimento(new Posicao(5, 3), new Posicao(6, 3)),
                new Movimento(new Posicao(5, 3), new Posicao(6, 4)),
            }));

            tabuleiro.Add(new Posicao(6, 3, false, new List<Movimento> {
                new Movimento(new Posicao(6, 3), new Posicao(5, 3)),
                new Movimento(new Posicao(6, 3), new Posicao(6, 2)),
                new Movimento(new Posicao(6, 3), new Posicao(6, 4)),
                new Movimento(new Posicao(6, 3), new Posicao(7, 3)),
            }));

            tabuleiro.Add(new Posicao(7, 3, false, new List<Movimento> {
                new Movimento(new Posicao(7, 3), new Posicao(6, 3)),
                new Movimento(new Posicao(7, 3), new Posicao(7, 1)),
                new Movimento(new Posicao(7, 3), new Posicao(7, 5)),
            }));

            // Quarta Coluna do Tabuleiro
            tabuleiro.Add(new Posicao(1, 4, true, new List<Movimento> {
                new Movimento(new Posicao(1, 4), new Posicao(1, 3)),
                new Movimento(new Posicao(1, 4), new Posicao(1, 5)),
                new Movimento(new Posicao(1, 4), new Posicao(2, 4)),
            }, false));

            tabuleiro.Add(new Posicao(2, 4, true, new List<Movimento> {
                new Movimento(new Posicao(2, 4), new Posicao(1, 3)),
                new Movimento(new Posicao(2, 4), new Posicao(1, 4)),
                new Movimento(new Posicao(2, 4), new Posicao(1, 5)),
                new Movimento(new Posicao(2, 4), new Posicao(2, 3)),
                new Movimento(new Posicao(2, 4), new Posicao(2, 5)),
                new Movimento(new Posicao(2, 4), new Posicao(3, 3)),
                new Movimento(new Posicao(2, 4), new Posicao(3, 4)),
                new Movimento(new Posicao(2, 4), new Posicao(3, 5))
            }, false));

            tabuleiro.Add(new Posicao(3, 4, true, new List<Movimento> {
                new Movimento(new Posicao(3, 4), new Posicao(3, 3)),
                new Movimento(new Posicao(3, 4), new Posicao(2, 4)),
                new Movimento(new Posicao(3, 4), new Posicao(3, 5)),
                new Movimento(new Posicao(3, 4), new Posicao(4, 4))
            }, false));

            tabuleiro.Add(new Posicao(4, 4, false, new List<Movimento> {
                new Movimento(new Posicao(4, 4), new Posicao(3, 3)),
                new Movimento(new Posicao(4, 4), new Posicao(3, 4)),
                new Movimento(new Posicao(4, 4), new Posicao(3, 5)),
                new Movimento(new Posicao(4, 4), new Posicao(4, 3)),
                new Movimento(new Posicao(4, 4), new Posicao(4, 5)),
                new Movimento(new Posicao(4, 4), new Posicao(5, 3)),
                new Movimento(new Posicao(4, 4), new Posicao(5, 4)),
                new Movimento(new Posicao(4, 4), new Posicao(5, 5))
            }));

            tabuleiro.Add(new Posicao(5, 4, false, new List<Movimento> {
                new Movimento(new Posicao(5, 4), new Posicao(4, 4)),
                new Movimento(new Posicao(5, 4), new Posicao(5, 3)),
                new Movimento(new Posicao(5, 4), new Posicao(5, 5))
            }));

            tabuleiro.Add(new Posicao(6, 4, false, new List<Movimento> {
                new Movimento(new Posicao(6, 4), new Posicao(5, 3)),
                new Movimento(new Posicao(6, 4), new Posicao(6, 3)),
                new Movimento(new Posicao(6, 4), new Posicao(7, 5))
            }));

            // Quinta Coluna do Tabuleiro
            tabuleiro.Add(new Posicao(1, 5, true, new List<Movimento> {
                new Movimento(new Posicao(1, 5), new Posicao(1, 4)),
                new Movimento(new Posicao(1, 5), new Posicao(2, 4)),
                new Movimento(new Posicao(1, 5), new Posicao(2, 5))
            }, false));

            tabuleiro.Add(new Posicao(2, 5, true, new List<Movimento> {
                new Movimento(new Posicao(2, 5), new Posicao(1, 5)),
                new Movimento(new Posicao(2, 5), new Posicao(2, 4)),
                new Movimento(new Posicao(2, 5), new Posicao(3, 5))
            }, false));

            tabuleiro.Add(new Posicao(3, 5, true, new List<Movimento> {
                new Movimento(new Posicao(3, 5), new Posicao(2, 4)),
                new Movimento(new Posicao(3, 5), new Posicao(2, 5)),
                new Movimento(new Posicao(3, 5), new Posicao(3, 4)),
                new Movimento(new Posicao(3, 5), new Posicao(4, 4)),
                new Movimento(new Posicao(3, 5), new Posicao(4, 5))
            }, false));

            tabuleiro.Add(new Posicao(4, 5, false, new List<Movimento> {
                new Movimento(new Posicao(4, 5), new Posicao(3, 5)),
                new Movimento(new Posicao(4, 5), new Posicao(5, 5)),
                new Movimento(new Posicao(4, 5), new Posicao(4, 4))
            }));

            tabuleiro.Add(new Posicao(5, 5, false, new List<Movimento>{
                new Movimento(new Posicao(5, 5), new Posicao(4, 4)),
                new Movimento(new Posicao(5, 5), new Posicao(5, 4)),
                new Movimento(new Posicao(5, 5), new Posicao(4, 5))
            }));

            tabuleiro.Add(new Posicao(7, 5, false, new List<Movimento> {
                new Movimento(new Posicao(7, 5), new Posicao(6, 4)),
                new Movimento(new Posicao(7, 5), new Posicao(7, 3))
            }));

            return tabuleiro;
        }

        private void MoverPecas(Movimento movimento, Button btnOrigem, Button btnDestino)
        {
            var origem = _tabuleiro.Where(t => t.X == _movimento.Origem.X && t.Y == _movimento.Origem.Y).FirstOrDefault();
            var destino = _tabuleiro.Where(t => t.X == _movimento.Destino.X && t.Y == _movimento.Destino.Y).FirstOrDefault();

            if (origem.Jogador == true)
            {
                var xDelete = (origem.X + destino.X) / 2;
                var yDelete = (origem.Y + destino.Y) / 2;
                var deathPosition = new Posicao(xDelete, yDelete);
                var n3 = _tabuleiro.Where(t => t.X == deathPosition.X && t.Y == deathPosition.Y).FirstOrDefault();
                var n1 = origem.Movimentos.Count;
                var n2 = destino.Movimentos.Count;

                bool verificaMovimento = false;
                foreach (var movimento1 in origem.Movimentos)
                {
                    if (movimento1.Origem.X == movimento.Origem.X && movimento1.Origem.Y == movimento.Origem.Y && movimento1.Destino.X == movimento.Destino.X && movimento1.Destino.Y == movimento.Destino.Y)
                        verificaMovimento = true;
                }
                foreach (var item in _tabuleiro)
                {
                    if (!verificaMovimento && n3.Ocupada == true && n3.Jogador == false)
                    {
                        for (int i = 0; i < n1; i++)
                        {
                            for (int l = 0; l < n2; l++)
                            {
                                if (origem.Movimentos[i].Destino.X == destino.Movimentos[l].Destino.X && origem.Movimentos[i].Destino.Y == destino.Movimentos[l].Destino.Y)
                                    origem.Movimentos.Add(new Movimento(origem, destino));
                            }
                        }
                    }
                }
                VitoriaCachorro(origem);

            }
            if (movimento.Origem.Ocupada == false)
                MessageBox.Show("Selecione uma peça sua!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else
            {
                if (movimento.Destino.Ocupada != false)
                    MessageBox.Show("Está casa ja está ocupada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    bool verificaMovimento = false;
                    foreach (var movimento1 in origem.Movimentos)
                    {
                        if (movimento1.Origem.X == movimento.Origem.X && movimento1.Origem.Y == movimento.Origem.Y && movimento1.Destino.X == movimento.Destino.X && movimento1.Destino.Y == movimento.Destino.Y)
                            verificaMovimento = true;
                    }

                    if (verificaMovimento == false)
                        MessageBox.Show("Movimento inválido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        if (_vezJogador != origem.Jogador)
                            MessageBox.Show($"Vez do {lbl_VezJogador.Text}!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        else
                        {
                            btnOrigem.BackgroundImage = null;
                            btnDestino.BackgroundImage = System.Drawing.Image.FromFile((origem.Jogador == false ? "../../../assets/images/dog.png" : "../../../assets/images/leopard.png"));

                            if (origem.Jogador == true)
                            {
                                var xDelete = (origem.X + destino.X) / 2;
                                var yDelete = (origem.Y + destino.Y) / 2;
                                var xDelete1 = (origem.X + destino.X) / 2.0;
                                var yDelete1 = (origem.Y + destino.Y) / 2.0;
                                var margemX = xDelete1 - xDelete;
                                var margemY = yDelete1 - yDelete;
                                if (margemX == 0 && margemY == 0)
                                {
                                    var deathPosition = new Posicao(xDelete, yDelete);
                                    var teste = _tabuleiro.Where(t => t.X == deathPosition.X && t.Y == deathPosition.Y).FirstOrDefault();
                                    if (teste.Ocupada == true && teste.Jogador == false)
                                    {
                                        teste.Ocupada = false;
                                        teste.Jogador = null;
                                        MessageBox.Show($"O cachorro da casa {teste.X} - {teste.Y} foi morto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        var btnName = $"btn_{teste.X}_{teste.Y}";
                                        Morte(btnName);
                                        _cachorrosMortos++;
                                        lbl_qtdCachorroM.Text = $"0{ _cachorrosMortos.ToString()}";
                                        VerificaVitoriaOnca(_cachorrosMortos);
                                    }
                                }
                            }

                            origem.Ocupada = false;
                            destino.Ocupada = true;
                            destino.Jogador = origem.Jogador;
                            origem.Jogador = null;

                            if (_vezJogador != true)
                            {
                                _vezJogador = true;
                                lbl_VezJogador.Text = "Onça";
                            }
                            else
                            {
                                _vezJogador = false;
                                lbl_VezJogador.Text = "Cachorro";
                            }
                        }
                    }
                }
            }

            _movimento.Destino = null;
            _movimento.Origem = null;
            _btnOrigem = null;
            _btnDestino = null;
        }

        private void VitoriaCachorro(Posicao onca)
        {
            var n1 = onca.Movimentos.Count();
            var n2 = _tabuleiro.Count();
            List<Posicao> posicaos= new List<Posicao>();
            for (int i = 0; i < n1; i++)
            {
                for (int l = 0; l < n2; l++)
                {
                    if (onca.Movimentos[i].Destino.X == _tabuleiro[l].X && onca.Movimentos[i].Destino.Y == _tabuleiro[l].Y)
                        onca.Movimentos[i].Destino.Ocupada = _tabuleiro[l].Ocupada;
                }
            }
            var vitoria = onca.Movimentos.TrueForAll(o => o.Destino.Ocupada == true);

            if (vitoria)
            {
                var result = MessageBox.Show($"O Cachorro Venceu!!!", "Parabéns", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                    this.Close();
            }

        }

        private void VerificaVitoriaOnca(int cachorrosMortos)
        {
            if (cachorrosMortos == 5)
            {
                var result = MessageBox.Show($"A Onça Venceu!!!", "Parabéns", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                    this.Close();
            }
        }

        private void PegaPecaMovimento(Posicao posicao, Button btn)
        {
            if (_click == false)
            {
                _movimento.Origem = posicao;
                _btnOrigem = btn;
                _click = true;
            }
            else
            {
                _movimento.Destino = posicao;
                _btnDestino = btn;
                _click = false;
            }

            if (_movimento.Origem != null && _movimento.Destino != null)
                MoverPecas(_movimento, _btnOrigem, _btnDestino);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Sair();
        }

        private void Morte(string btn)
        {
            switch (btn)
            {
                case "btn_1_1":
                    btn_1_1.BackgroundImage = null;
                    break;
                case "btn_1_2":
                    btn_1_2.BackgroundImage = null;
                    break;
                case "btn_1_3":
                    btn_1_3.BackgroundImage = null;
                    break;
                case "btn_1_4":
                    btn_1_3.BackgroundImage = null;
                    break;
                case "btn_1_5":
                    btn_1_5.BackgroundImage = null;
                    break;
                case "btn_2_1":
                    btn_2_1.BackgroundImage = null;
                    break;
                case "btn_2_2":
                    btn_2_2.BackgroundImage = null;
                    break;
                case "btn_2_3":
                    btn_2_3.BackgroundImage = null;
                    break;
                case "btn_2_4":
                    btn_2_4.BackgroundImage = null;
                    break;
                case "btn_2_5":
                    btn_2_5.BackgroundImage = null;
                    break;
                case "btn_3_1":
                    btn_3_1.BackgroundImage = null;
                    break;
                case "btn_3_2":
                    btn_3_2.BackgroundImage = null;
                    break;
                case "btn_3_3":
                    btn_3_3.BackgroundImage = null;
                    break;
                case "btn_3_4":
                    btn_3_4.BackgroundImage = null;
                    break;
                case "btn_3_5":
                    btn_3_5.BackgroundImage = null;
                    break;
                case "btn_4_1":
                    btn_4_1.BackgroundImage = null;
                    break;
                case "btn_4_2":
                    btn_4_2.BackgroundImage = null;
                    break;
                case "btn_4_3":
                    btn_4_3.BackgroundImage = null;
                    break;
                case "btn_4_4":
                    btn_4_4.BackgroundImage = null;
                    break;
                case "btn_4_5":
                    btn_4_5.BackgroundImage = null;
                    break;
                case "btn_5_1":
                    btn_5_1.BackgroundImage = null;
                    break;
                case "btn_5_2":
                    btn_5_2.BackgroundImage = null;
                    break;
                case "btn_5_3":
                    btn_5_3.BackgroundImage = null;
                    break;
                case "btn_5_4":
                    btn_5_4.BackgroundImage = null;
                    break;
                case "btn_5_5":
                    btn_5_5.BackgroundImage = null;
                    break;
                case "btn_6_2":
                    btn_6_2.BackgroundImage = null;
                    break;
                case "btn_6_3":
                    btn_6_3.BackgroundImage = null;
                    break;
                case "btn_6_4":
                    btn_6_4.BackgroundImage = null;
                    break;
                case "btn_7_1":
                    btn_7_1.BackgroundImage = null;
                    break;
                case "btn_7_3":
                    btn_7_3.BackgroundImage = null;
                    break;
                case "btn_7_5":
                    btn_7_5.BackgroundImage = null;
                    break;

                default:
                    break;
            }
        }
    }

}
