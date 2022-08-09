using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp01_aula01
{
    internal class Dado
    {
        private String codigo;
        private String dado1;
        private String dado2;
        private String dado3;
        private String dado4;

        public void setCodigo(String _codigo) { codigo = _codigo; }
        public void setDado1(String _dado1) { dado1 = _dado1; }
        public void setDado2(String _dado2) { dado2 = _dado2; }
        public void setDado3(String _dado3) { dado3 = _dado3; }
        public void setDado4(String _dado4) { dado4 = _dado4; }

        public String getCodigo() { return codigo; }
        public String getDado1() { return dado1; }
        public String getDado2() { return dado2; }
        public String getDado3() { return dado3; }
        public String getDado4() { return dado4; }
    }
}
