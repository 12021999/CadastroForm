using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro{
    public static class Global{
        public static Form1 form;
    }

    public class Funcionario{
        public string nome;
        public string nascimento;
        public string gender;
        public string prof;
        public string sal;
        public string status;
        public string NF;
        public string blood;
        public string add;

        public string asString(){
            return nome + "|" + nascimento + "|" + gender + "|" + prof + "|" + sal + "|" + status + "|" + NF + "|" + blood + "|" + add; 
        }

        public void fromString(string meta){
            string[] info = meta.Split('|');
            nome = info[0];
            nascimento = info[1];
            gender = info[2];
            prof = info[3];
            sal = info[4];
            status = info[5];
            NF = info[6];
            blood = info[7];
            add = info[8];
            Global.form.loadPerson(info);
        }
    }
}
