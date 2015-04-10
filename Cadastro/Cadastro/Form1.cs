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
using System.IO;

namespace Cadastro{
    public partial class Form1 : Form{
        public List<Funcionario> funcionarios = new List<Funcionario>();

        string genderText;
        string filhoText;
        string statusText;
        string pathname;

        public Form1(){
            InitializeComponent();
            pathname = @"C:\Cadastro";
            System.IO.Directory.CreateDirectory(pathname);
            Environment.CurrentDirectory = pathname;
            Global.form = this;
            string[] allLines;
            try{
                allLines = File.ReadAllLines(pathname + @"\Index.txt");
            }catch{
                allLines = new string[1];
            }
            File.Delete(pathname + @"\Index.txt");
            for (int i = 0; i < allLines.Length; i++){
                if (allLines[i] != null && !allLines[i].Contains('|')){
                    continue;
                }else if (allLines[i] != null && allLines[i].Contains('|')){
                    using (StreamWriter file = new StreamWriter(pathname + @"\Index.txt", true)){file.WriteLine(allLines[i]);}
                    try{
                        funcionarios.Add(new Funcionario());
                        funcionarios[i].fromString(allLines[i]);
                        nameList.Items.Add(funcionarios[i].nome);
                    }catch{
                        Console.WriteLine("Erro!");
                    }
                }
            }
        }

        public void Salvar_Click(object sender, EventArgs e){
            bool ok = true;
            nomeBox.Text = Regex.Replace(Convert.ToString(nomeBox.Text), "(?i)[^a-z À-ÿ]", "");
            profBox.Text = Regex.Replace(Convert.ToString(profBox.Text), "(?i)[^a-z À-ÿ]", "");
            addBox.Text = Regex.Replace(Convert.ToString(addBox.Text), "(?i)[^a-z0-9 À-ÿ]", "");
            diaBox.Text = Regex.Replace(Convert.ToString(diaBox.Text), "[^0-9]", "");
            mesBox.Text = Regex.Replace(Convert.ToString(mesBox.Text), "[^0-9]", "");
            anoBox.Text = Regex.Replace(Convert.ToString(anoBox.Text), "[^0-9]", "");
            salBox.Text = Regex.Replace(Convert.ToString(salBox.Text), "[^0-9,]", "");

            if (nomeBox.Text == "") { nomeSave.Text = "*"; ok = false; } else { nomeSave.Text = " "; }
            if (diaBox.Text == "" || mesBox.Text == "" || anoBox.Text == "") {
                dataSave.Text = "*";
                ok = false;
            }else{ 
                dataSave.Text = " ";           
                if (Convert.ToDouble(diaBox.Text) < 1 || Convert.ToDouble(diaBox.Text) > 31 || Convert.ToDouble(mesBox.Text) < 1 || Convert.ToDouble(mesBox.Text) > 12 || Convert.ToDouble(anoBox.Text) < 1900 || Convert.ToDouble(anoBox.Text) > 2015){
                    dataSave.Text = "*";
                    ok = false;
                }
            }
            if (profBox.Text == "") { profSave.Text = "*"; ok = false; } else { profSave.Text = " "; }
            if (salBox.Text == "") { salSave.Text = "*"; ok = false; } else { salSave.Text = " "; }
            if (addBox.Text == "") { addSave.Text = "*"; ok = false; } else { addSave.Text = " "; }
            switch (bloodBox.Text) {    
                case "O+":case "O-":
                case "A+":case "A-":
                case "B+":case "B-":
                case "AB+":case "AB-":
                case "C#":
                    bloodSave.Text = " ";
                    break;
                default:
                    bloodSave.Text = "*";
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

                if (nameList.SelectedIndex == -1){
                    nameList.Items.Add("<Novo>");
                    nameList.SelectedIndex = 0;
                }

                bool hadPrevious = false;
                string[] allLines;
                try{
                    allLines = System.IO.File.ReadAllLines(pathname + @"\Index.txt");
                }catch{
                    allLines = new string[1];
                }
                File.Delete(pathname + @"\Index.txt");
                foreach (string line in allLines){
                    if (Convert.ToString(nameList.Items[nameList.SelectedIndex]) != "<Novo>" && line.Contains(Convert.ToString(nameList.Items[nameList.SelectedIndex]))){
                        using (StreamWriter file = new StreamWriter(pathname + @"\Index.txt", true)){
                            file.WriteLine(f.asString());
                        }
                        hadPrevious = true;
                    }else{
                        using (StreamWriter file = new StreamWriter(pathname + @"\Index.txt", true)){
                            file.WriteLine(line);
                        }
                    }
                }
                if (!(!(!hadPrevious))){ //Hehe :3
                    using (StreamWriter file = new StreamWriter(pathname + @"\Index.txt", true)){
                        file.WriteLine(f.asString());
                    }
                }

                nameList.Items[nameList.SelectedIndex] = f.nome;                
            }else{
                Console.WriteLine("Erro!");
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

            if (nameList.Items.Contains("<Novo>")){
            }else{
                nameList.Items.Add("<Novo>");
                nameList.SelectedIndex = nameList.Items.Count - 1;
            }
            
        }

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
                string thisname = Convert.ToString(nameList.Items[nameList.SelectedIndex]);
                nameList.Items.RemoveAt(nameList.SelectedIndex);
                string[] allLines = System.IO.File.ReadAllLines(pathname + @"\Index.txt");
                File.Delete(pathname + @"\Index.txt");
                foreach (string line in allLines){
                    if (line.Contains(thisname)){
                        continue;
                    }else{
                        using (StreamWriter file = new StreamWriter(pathname + @"\Index.txt",true)){
                            file.WriteLine(line);
                        }
                    }
                }
            }
        }

        private void editarClick(object sender, EventArgs e){
            if (nameList.SelectedIndex != -1){
                if (funcionarios.Count != 0 && nameList.SelectedIndex != -1 && nameList.SelectedItem.ToString() != "<Novo>"){
                    Funcionario pessoa = funcionarios.ElementAt(nameList.SelectedIndex);
                    nomeBox.Text = pessoa.nome;
                    diaBox.Text = pessoa.nascimento.Split('/')[0];
                    mesBox.Text = pessoa.nascimento.Split('/')[1];
                    anoBox.Text = pessoa.nascimento.Split('/')[2];
                    profBox.Text = pessoa.prof;
                    salBox.Text = pessoa.sal;
                    bloodBox.Text = pessoa.blood;
                    addBox.Text = pessoa.add;

                    if (pessoa.gender.Equals("Masculino")){
                        genderM.Checked = true;
                        genderF.Checked = false;
                        genderOutro.Checked = false;
                    }else if (pessoa.gender.Equals("Feminino")){
                        genderM.Checked = false;
                        genderF.Checked = true;
                        genderOutro.Checked = false;
                    }else if (pessoa.gender.Equals("Outro")){
                        genderM.Checked = false;
                        genderF.Checked = false;
                        genderOutro.Checked = true;
                    }

                    if (pessoa.status.Equals("Solteiro")){
                        statusS.Checked = true;
                        statusA.Checked = false;
                        statusC.Checked = false;
                    }else if (pessoa.status.Equals("Casado")){
                        statusS.Checked = false;
                        statusA.Checked = true;
                        statusC.Checked = false;
                    }else if (pessoa.status.Equals("Assexuado")){
                        statusS.Checked = false;
                        statusA.Checked = false;
                        statusC.Checked = true;
                    }

                    if (pessoa.NF.Equals("0 filhos")){
                        NF0.Checked = true;
                        NF1.Checked = false;
                        NF2.Checked = false;
                        NF3.Checked = false;
                    }else if (pessoa.NF.Equals("1 filho")){
                        NF0.Checked = false;
                        NF1.Checked = true;
                        NF2.Checked = false;
                        NF3.Checked = false;
                    }else if (pessoa.NF.Equals("2 filhos")){
                        NF0.Checked = false;
                        NF1.Checked = false;
                        NF2.Checked = true;
                        NF3.Checked = false;
                    }else if (pessoa.NF.Equals("3+ filhos")){
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

   
}