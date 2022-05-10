using Aula_09_05.Interface;
using System.Collections.Generic;
using System.IO;

namespace Aula_09_05.Models
{
    // : Herança
    // , Interface (contrato da classe)

    public class Equipe : EquipeBase, IEquipe
    {
        public int idEquipe { get; set; }
        public string Nome { get; set; }
        public string Imagem { get; set; }

        //variável de dados.

        private const string caminhobd = "Database/equipe.csv";

        public Equipe()
        {
            //método da classe de herança EquipeBase.
            CriarPastaOuArquivo(caminhobd);
        }

        //criar uma função que vai receber o objeto EQUIPE, e vai retornar no formato csv.

        string Preparar(Equipe e)
        {
            return e.idEquipe + ";" +e.Nome + ";" +e.Imagem;

            //mesma ideia: return $"{e.idEquipe};{e.Nome};{e.Imagem}";
        }

        public void Criar(Equipe novaequipe)
        {
            //mesma ideia: string valor = Preparar(novaequipe);
                          //string[] equipe_texto = {valor};

            //array de strings = na posição 0 temos o retorno do "preparar".
            string[] equipe_texto = { Preparar(novaequipe) };

            //no arquivo vamos adicionar uma nova linha.
            //caminho do arquivo, string em formato de array.

            File.AppendAllLines(caminhobd, equipe_texto);
        }

        public List<Equipe> LerEquipes()
        {
            List<Equipe> listaEquipes = new List<Equipe>();

            //ler todas as linhas do arquivo csv, e armazenar em um array.
            string[] linhas = File.ReadAllLines(caminhobd);

            foreach (string item in linhas)
            {
                //1; nome da equipe; caminho da imagem

                string[] linhaEquipe = item.Split(";");

                Equipe equipeAtual = new Equipe();
                equipeAtual.idEquipe = int.Parse(linhaEquipe[0]);
                equipeAtual.Nome = linhaEquipe[1];
                equipeAtual.Imagem = linhaEquipe[2];

                listaEquipes.Add(equipeAtual);
            }
            return listaEquipes;
        }
    }
}
