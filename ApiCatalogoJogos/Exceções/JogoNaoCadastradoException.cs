using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogoJogos.Exceções
{
    public class JogoNaoCadastradoException : Exception
    {
        public JogoNaoCadastradoException()
            :base("Este jogo não esta Cadastrado ")
        { }
    }
}
