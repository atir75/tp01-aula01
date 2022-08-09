using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp01_aula01
{
    internal class DadoBLL
    {

        public static void conecta()
        {
            DadoDal.conecta();
        }

        public static void desconecta()
        {
            DadoDal.desconecta();
        }
        public static void validaDados(Dado dado, char op)
        {
            Erro.setErro(false);
            if (dado.getCodigo().Equals(""))
            {
                Erro.setMsg("O código é de preenchimento obrigatório!");
                return;
            }
            if (dado.getDado1().Equals(""))
            {
                Erro.setMsg("O Dado1 é de preenchimento obrigatório!");
                return;
            }
            if (dado.getDado2().Equals(""))
            {
                Erro.setMsg("O Dado2 é de preenchimento obrigatório!");
                return;
            }
            if (dado.getDado3().Equals(""))
            {
                Erro.setMsg("A Dado3 é de preenchimento obrigatório!");
                return;
            }
            if (dado.getDado4().Equals(""))
            {
                Erro.setMsg("O Dado4 é de preenchimento obrigatório!");
                return;
            }

            //VALIDAÇÃO DE DADOS NUMÉRICOS E POSITIVOS (MAIOR QUE ZERO)
            try
            {
                int.Parse(dado.getDado3());
            }
            catch (Exception)
            {
                Erro.setMsg("O valor do Dado3 deve ser numérico!");
                return;
            }

            if (int.Parse(dado.getDado3()) <= 0)
            {
                Erro.setMsg("O valor do Dado3 deve ser numérico e positivo!");
                return;
            }
            //VALIDAÇÃO DE DADOS NUMÉRICOS E POSITIVOS (MAIOR QUE ZERO)
            try
            {
                int.Parse(dado.getDado4());
            }
            catch (Exception)
            {
                Erro.setMsg("O valor do Dado4 deve ser numérico!");
                return;
            }
            if (float.Parse(dado.getDado4()) <= 0)
            {
                Erro.setMsg("O valor do Dado4 deve ser numérico e positivo!");
                return;
            }
        }
    }
}
