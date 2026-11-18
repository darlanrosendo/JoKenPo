using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Drawing;

namespace JoKenPo
{
    internal class Game
    {
        // Enum que define os possíveis resultados da partida
        public enum Resultado
        {
            Ganhar,  // Jogador vence
            Perder,  // Computador vence
            Empatar  // Os dois escolhem o mesmo
        }

        // Array de imagens para representar Pedra, Papel e Tesoura
        public static Image[] imagens =
        {
            Image.FromFile("Resources/Pedra.png"),    // Índice 0: Pedra
            Image.FromFile("Resources/papel.png"),    // Índice 1: Papel
            Image.FromFile("Resources/Tesoura.png")   // Índice 2: Tesoura
        };

        // Imagens usadas no jogo para exibir a jogada de cada um
        public Image ImgPC { get; private set; }       // Imagem escolhida pelo PC
        public Image ImgJogador { get; private set; }  // Imagem escolhida pelo jogador

        // Objeto Random usado para gerar jogadas aleatórias do computador
        private static Random rand = new Random();

        // Método que executa a jogada do computador gerando um número aleatório entre 0 e 2
        private int JogadaPC()
        {
            return rand.Next(3); // 0 = Pedra, 1 = Papel, 2 = Tesoura
        }

        // Método principal do jogo: define o resultado baseado nas escolhas
        public Resultado Jogar(int jogador)
        {
            int pc = JogadaPC(); // Gera jogada do computador

            // Define as imagens que serão exibidas
            ImgJogador = imagens[jogador]; // Pega imagem da jogada do jogador
            ImgPC = imagens[pc];           // Pega imagem da jogada do computador

            // Verifica se houve empate
            if (jogador == pc)
            {
                return Resultado.Empatar;
            }
            // Verifica se o jogador venceu
            else if ((jogador == 0 && pc == 2) || // Pedra vence Tesoura
                     (jogador == 1 && pc == 0) || // Papel vence Pedra
                     (jogador == 2 && pc == 1))  // Tesoura vence Papel
            {
                return Resultado.Ganhar;
            }
            else
            {
                return Resultado.Perder; // Caso contrário, o jogador perdeu
            }
        }
    }
}

    

