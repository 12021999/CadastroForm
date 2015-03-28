using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Cadastro{
    public partial class Form1 : Form{
        public List<Funcionario> funcionarios = new List<Funcionario>();
       
        string genderText;
        string filhoText;
        string statusText;

        public Form1(){
            InitializeComponent();
            Global.form = this;
        }

        public void Salvar_Click(object sender, EventArgs e){
            bool ok = true;
            nomeBox.Text = Regex.Replace(Convert.ToString(nomeBox.Text), "(?i)[^a-z À-ÿ]", "");
            profBox.Text = Regex.Replace(Convert.ToString(profBox.Text), "(?i)[^a-z À-ÿ]", "");
            diaBox.Text = Regex.Replace(Convert.ToString(diaBox.Text), "[^0-9]", "");
            mesBox.Text = Regex.Replace(Convert.ToString(mesBox.Text), "[^0-9]", "");
            anoBox.Text = Regex.Replace(Convert.ToString(anoBox.Text), "[^0-9]", "");
            salBox.Text = Regex.Replace(Convert.ToString(salBox.Text), "[^0-9]", "");

            if (nomeBox.Text == "") { nomeSave.Text = "Erro"; ok = false; } else { nomeSave.Text = " "; }
            if (diaBox.Text == "" || mesBox.Text == "" || anoBox.Text == "") {
                dataSave.Text = "Erro";
                ok = false;
            }else{ 
                dataSave.Text = " ";           
                if (Convert.ToDouble(diaBox.Text) < 1 || Convert.ToDouble(diaBox.Text) > 31 || Convert.ToDouble(mesBox.Text) < 1 || Convert.ToDouble(mesBox.Text) > 12 || Convert.ToDouble(anoBox.Text) < 1900 || Convert.ToDouble(anoBox.Text) > 2015){
                    dataSave.Text = "Erro";
                    ok = false;
                }
            }
            if (profBox.Text == "") { profSave.Text = "Erro"; ok = false; } else { profSave.Text = " "; }
            if (salBox.Text == "") { salSave.Text = "Erro"; ok = false; } else { salSave.Text = " "; }
            if (addBox.Text == "") { addSave.Text = "Erro"; ok = false; } else { addSave.Text = " "; }
            switch (bloodBox.Text) {    
                case "O+":case "O-":
                case "A+":case "A-":
                case "B+":case "B-":
                case "AB+":case "AB-":
                case "C#":
                    bloodSave.Text = " ";
                    break;
                default:
                    bloodSave.Text = "Erro";
                    bloodBox.Text = "";
                    ok = false;
                    break;
            }

            if (genderM.Checked){genderText = "Masculino";}
            else if (genderF.Checked){genderText = "Feminino";}
            else if (genderOutro.Checked){genderText = "Outro";}

            
            if (NF0.Checked){filhoText = "0 filhos";}
            else if (NF1.Checked){filhoText = "1 filho";}
            else if (NF2.Checked){filhoText = "2 filhos";}
            else if (NF3.Checked){filhoText = "3+ filhos";}

            if (statusS.Checked) { statusText = "Solteiro"; }
            else if (statusC.Checked) { statusText = "Casado"; }
            else if (statusA.Checked) { statusText = "Assexuado"; }

            if (ok){
                isOk.Text = "Ok";
                isOk.ForeColor = System.Drawing.Color.Green;
                Funcionario f = new Funcionario();
                f.nome = nomeBox.Text;
                f.nascimento = diaBox.Text + "/" + mesBox.Text + "/" + anoBox.Text;
                f.gender = genderText;
                f.prof = profBox.Text;
                f.sal = salBox.Text;
                f.status = statusText;
                f.NF = filhoText;
                f.blood = bloodBox.Text;
                f.add = addBox.Text;

                funcionarios.Add(f);
                Console.WriteLine(funcionarios.Count);
                Console.WriteLine(funcionarios[0]);

                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Cadastro\Index.txt", true)){
                    file.WriteLine(f.asString());
                }

                if (nameList.SelectedIndex == -1){
                    nameList.Items.Add("<Novo>");
                    nameList.SelectedIndex = 0;
                }
                    nameList.Items[nameList.SelectedIndex] = f.nome;
                //nameList.Items.Remove("<Novo>");
                
                
                //if (nameList.Items.Equals(f.nome));
                //nameList.Items.IndexOf("<Novo>");
                //
                
            }else{
                isOk.Text = "Não ok";
                isOk.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void novoClick(object sender, EventArgs e){
            nomeBox.Text = "";
            profBox.Text = "";
            diaBox.Text = "";
            mesBox.Text = "";
            anoBox.Text = "";
            salBox.Text = "";
            bloodBox.Text = "";
            addBox.Text = "";

            nomeSave.Text = " ";
            dataSave.Text = " ";
            profSave.Text = " ";
            salSave.Text = " ";
            bloodSave.Text = " ";
            addSave.Text = " ";

            genderM.Checked = true;
            genderF.Checked = false;
            genderOutro.Checked = false;

            statusS.Checked = true;
            statusA.Checked = false;
            statusC.Checked = false;

            NF0.Checked = true;
            NF1.Checked = false;
            NF2.Checked = false;
            NF3.Checked = false;

            
            
                if (nameList.Items.Contains("<Novo>")){}
                else{nameList.Items.Add("<Novo>");}
            
            }

            /*
            string[] allLines = System.IO.File.ReadAllLines(@"C:\Cadastro\Index.txt");

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Cadastro\Index.txt"))
            {
                foreach (string line in allLines)
                {
                    if (nameList.SelectedIndex == -1)
                    {
                        nameList.SelectedIndex = 0;
                    }

                    string nominho = nameList.Items[nameList.SelectedIndex] as String;

                    if (line.Contains(nominho))
                    {
                        pessoa.fromString(line);
                    }
                }
            }
            
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\potato.txt", true)){
                file.WriteLine(text);
            }

            string text2 = System.IO.File.ReadAllText(@"C:\");
            string[] lines2 = System.IO.File.ReadAllLines(@"C:\");*/

        public void loadPerson(string[] info){
            nomeBox.Text = info[0].ToString();
            diaBox.Text = info[1].ToString().Split('/')[0];
            mesBox.Text = info[1].ToString().Split('/')[1];
            anoBox.Text = info[1].ToString().Split('/')[2];
            profBox.Text = info[3].ToString();
            salBox.Text = info[4].ToString();
            bloodBox.Text = info[7].ToString();
            addBox.Text = info[8].ToString();

            if (info[2].Equals("Masculino")){
                genderM.Checked = true;
                genderF.Checked = false;
                genderOutro.Checked = false;
            }else if (info[2].Equals("Feminino")){
                genderM.Checked = false;
                genderF.Checked = true;
                genderOutro.Checked = false;
            }else if (info[2].Equals("Outro")){
                genderM.Checked = false;
                genderF.Checked = false;
                genderOutro.Checked = true;
            }

            if (info[5].Equals("Solteiro")){
                statusS.Checked = true;
                statusA.Checked = false;
                statusC.Checked = false;
            }else if (info[5].Equals("Casado")){
                statusS.Checked = false;
                statusA.Checked = true;
                statusC.Checked = false;
            }else if (info[5].Equals("Assexuado")){
                statusS.Checked = false;
                statusA.Checked = false;
                statusC.Checked = true;
            }

            if (info[6].Equals("0 filhos")){
                NF0.Checked = true;
                NF1.Checked = false;
                NF2.Checked = false;
                NF3.Checked = false;
            }else if (info[6].Equals("1 filho")){
                NF0.Checked = false;
                NF1.Checked = true;
                NF2.Checked = false;
                NF3.Checked = false;
            }else if (info[6].Equals("2 filhos")){
                NF0.Checked = false;
                NF1.Checked = false;
                NF2.Checked = true;
                NF3.Checked = false;
            }else if (info[6].Equals("3+ filhos")){
                NF0.Checked = false;
                NF1.Checked = false;
                NF2.Checked = false;
                NF3.Checked = true;
            }

            nomeSave.Text = " ";
            dataSave.Text = " ";
            profSave.Text = " ";
            salSave.Text = " ";
            bloodSave.Text = " ";
            addSave.Text = " ";
        }

        private void removerClick(object sender, EventArgs e){
            if (nameList.Items.Count != 0){
                if (nameList.SelectedIndex == -1) { nameList.SelectedIndex = 0; }
                nameList.Items.RemoveAt(nameList.SelectedIndex);
            }
        }

        private void editarClick(object sender, EventArgs e){
            if (nameList.SelectedIndex == -1) { nameList.SelectedIndex = 0; }
            if (funcionarios.Count != 0 && nameList.SelectedIndex != -1 && nameList.SelectedItem.ToString() != "<Novo>")
            {
                Funcionario pessoa = funcionarios.ElementAt(nameList.SelectedIndex);
                nomeBox.Text = pessoa.nome;
                diaBox.Text = pessoa.nascimento.Split('/')[0];
                mesBox.Text = pessoa.nascimento.Split('/')[1];
                anoBox.Text = pessoa.nascimento.Split('/')[2];
                profBox.Text = pessoa.prof;
                salBox.Text = pessoa.sal;
                bloodBox.Text = pessoa.blood;
                addBox.Text = pessoa.add;

                if (pessoa.gender.Equals("Masculino"))
                {
                    genderM.Checked = true;
                    genderF.Checked = false;
                    genderOutro.Checked = false;
                }
                else if (pessoa.gender.Equals("Feminino"))
                {
                    genderM.Checked = false;
                    genderF.Checked = true;
                    genderOutro.Checked = false;
                }
                else if (pessoa.gender.Equals("Outro"))
                {
                    genderM.Checked = false;
                    genderF.Checked = false;
                    genderOutro.Checked = true;
                }

                if (pessoa.status.Equals("Solteiro"))
                {
                    statusS.Checked = true;
                    statusA.Checked = false;
                    statusC.Checked = false;
                }
                else if (pessoa.status.Equals("Casado"))
                {
                    statusS.Checked = false;
                    statusA.Checked = true;
                    statusC.Checked = false;
                }
                else if (pessoa.status.Equals("Assexuado"))
                {
                    statusS.Checked = false;
                    statusA.Checked = false;
                    statusC.Checked = true;
                }

                if (pessoa.NF.Equals("0 filhos"))
                {
                    NF0.Checked = true;
                    NF1.Checked = false;
                    NF2.Checked = false;
                    NF3.Checked = false;
                }
                else if (pessoa.NF.Equals("1 filho"))
                {
                    NF0.Checked = false;
                    NF1.Checked = true;
                    NF2.Checked = false;
                    NF3.Checked = false;
                }
                else if (pessoa.NF.Equals("2 filhos"))
                {
                    NF0.Checked = false;
                    NF1.Checked = false;
                    NF2.Checked = true;
                    NF3.Checked = false;
                }
                else if (pessoa.NF.Equals("3+ filhos"))
                {
                    NF0.Checked = false;
                    NF1.Checked = false;
                    NF2.Checked = false;
                    NF3.Checked = true;
                }
            }

            nomeSave.Text = " ";
            dataSave.Text = " ";
            profSave.Text = " ";
            salSave.Text = " ";
            bloodSave.Text = " ";
            addSave.Text = " ";
        }
    }

   
}