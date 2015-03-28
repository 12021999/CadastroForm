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
        List<Funcionario> funcionarios = new List<Funcionario>();


        public Form1(){
            InitializeComponent();
        }

        public void Salvar_Click(object sender, EventArgs e){
            bool ok = true;
            nomeBox.Text = Regex.Replace(Convert.ToString(nomeBox.Text), "(?i)[^a-z À-ÿ]", "");
            profBox.Text = Regex.Replace(Convert.ToString(profBox.Text), "(?i)[^a-z À-ÿ]", "");
            diaBox.Text = Regex.Replace(Convert.ToString(diaBox.Text), "[^0-9]", "0");
            mesBox.Text = Regex.Replace(Convert.ToString(mesBox.Text), "[^0-9]", "0");
            anoBox.Text = Regex.Replace(Convert.ToString(anoBox.Text), "[^0-9]", "0");
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

            string genderText;
            if (genderM.Checked){genderText = "Masculino";}
            else if (genderM.Checked){genderText = "Feminino";}
            else if (genderOutro.Checked){genderText = "Outro";}

            string filhoText;
            if (NF0.Checked){filhoText = "0 filhos";}
            else if (NF1.Checked){filhoText = "1 filho";}
            else if (NF2.Checked){filhoText = "2 filhos";}
            else if (NF3.Checked){filhoText = "3+ filhos";}

            if (ok){
                isOk.Text = "Ok";
                isOk.ForeColor = System.Drawing.Color.Green;
                Funcionario f = new Funcionario();
                f.nome = nomeBox.Text;
                f.nascimento = diaBox.Text + "/" + mesBox.Text + "/" + anoBox.Text;
                f.gender = genderText;
                f.prof = profBox.Text;
                f.sal = salBox.Text;
                f.NF = filhoText;
                f.blood = "Woop";
                f.add = addBox.Text;

                funcionarios.Add(f);

                //funcionarios.Remove(f);
                Debug.Print(f);
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
        }
    }

   
}