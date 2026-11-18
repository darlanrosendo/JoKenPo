namespace JoKenPo
{
    // Classe do formulário principal
    public partial class FormTelaGame : Form
    {
        // Construtor do formulário que inicializa os componentes da interface
        public FormTelaGame()
        {
            InitializeComponent();
        }

        // Evento que ocorre quando o botão "Pedra" é clicado
        private void btnPedra_Click(object sender, EventArgs e)
        {
            StartGame(0); // 0 representa Pedra
        }

        // Evento que ocorre quando o botão "Papel" é clicado
        private void btnPapel_Click(object sender, EventArgs e)
        {
            StartGame(1); // 1 representa Papel
        }

        // Evento que ocorre quando o botão "Tesoura" é clicado
        private void btnTesoura_Click(object sender, EventArgs e)
        {
            StartGame(2); // 2 representa Tesoura
        }

        // Método que inicia o jogo com a opção escolhida pelo jogador
        private void StartGame(int opcao)
        {
            // Esconde o rótulo de resultado antes da nova rodada
            labelResultado.Visible = false;

            // Cria uma nova instância do jogo
            Game jogo = new Game();

            // Executa o jogo e verifica o resultado
            switch (jogo.Jogar(opcao))
            {
                // Caso o jogador tenha vencido
                case Game.Resultado.Ganhar:
                    picResulado.BackgroundImage = Image.FromFile("Resources/Ganhar.png");
                    goto default;

                // Caso o jogador tenha perdido
                case Game.Resultado.Perder:
                    picResulado.BackgroundImage = Image.FromFile("Resources/Perder.png");
                    goto default;

                // Caso tenha empatado
                case Game.Resultado.Empatar:
                    picResulado.BackgroundImage = Image.FromFile("Resources/Empatar.png");
                    goto default;

                // Executado após qualquer resultado acima
                default:
                    // Exibe as imagens das jogadas do jogador e do computador
                    pictureBox1.Image = jogo.ImgJogador;
                    pictureBox2.Image = jogo.ImgPC;
                    break;
            }
        }


    }
}

