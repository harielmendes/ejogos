using Aula_09_05.Models;
using System.Collections.Generic;

namespace Aula_09_05.Interface
{
    public interface IEquipe
    {
        //Contrato
        //Representa os métodos que são obrigatórios em uma classe.

        void Criar(Equipe novaequipe);
        List<Equipe> LerEquipes();
    }
}
