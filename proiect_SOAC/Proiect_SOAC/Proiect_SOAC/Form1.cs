using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Proiect_SOAC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        public string HRg;
        public string Istorie_salt_anterioare;

        public int dimensiune_HRg;
        public int nr_biti_pred;
        public int m_PPM, m_Mark;

        public string pattern;
        public int frecv_0; //dupa un anumit pattern
        public int frecv_1; //dupa un anumit pattern


        public int predictii_corecte = 0;
        public int predictii_incorecte = 0;

        string path = @"tra\";
        string extensie = ".TRA";
        public int total_linii;
        public string Trace;
        private int Ordin_PPM()
        {
            string m=" ";
            int M = 0;
            bool check;
            int i = 0, stop = 0;

            while ( i<=10 && stop == 0 )
            {
                check = checkPredictor.GetItemChecked(i);
                if (check == true)
                {
                    stop = 1; i--;
                }
                i++;
            }

            switch (i)
            {
                case 0: M= 11; break;
                case 1: M = 10; break;
                case 2: M = 9; break;
                case 3: M = 8; break;
                case 4: M = 7; break;
                case 5: M = 6; break;
                case 6: M = 5; break;
                case 7: M = 4; break;
                case 8: M = 3; break;
                case 9: M = 2; break;
                case 10: M = 1; break;
                 
                default:
                    {
                        //MessageBox.Show("default: PPM Complet");
                        M = 11;
                    }
                        break;

            }

            return M;
        }
        private int Dimensiune_HRg()
        {
            int dimensiune = 0;
            bool check;
            int i = 0, stop = 0 ;
            
            while( i<= 6 && stop == 0 )
            {
                check = chechHRg.GetItemChecked(i);
                if (check == true)
                {
                    stop = 1; i--;
                }
                i++;
            }

            switch (i)
            {
                case 0: dimensiune = 30; break;
                case 1: dimensiune = 40 ; break;
                case 2: dimensiune = 50 ; break;
                case 3: dimensiune = 100; break;
                case 4: dimensiune = 200; break;
                case 5: dimensiune = 300; break;
                case 6: dimensiune = 500; break;
                
                default:
                    {
                        dimensiune = 30;
                        //MessageBox.Show("default: dimenisunea de 30");
                    } break;
            }

            return dimensiune;
        }

        private int Biti_Predictie()
        {
            
            bool check;
            int biti_pred = 0;
            int i = 0, stop = 0;

            while (i < 7 && stop == 0)
            {
                check = chechHRg.GetItemChecked(i);
                if (check == true)
                {
                    stop = 1; i--;
                }
                i++;
            }

            switch (i)
            {
                case 0: biti_pred = 1; break;
                case 1: biti_pred = 2; break;
                case 2: biti_pred = 3; break;
                case 3: biti_pred = 4; break;
                case 4: biti_pred = 5; break;
                case 5: biti_pred = 8; break;
                case 6: biti_pred = 16; break;
                case 7: biti_pred = 32; break;

                default:
                    {
                        MessageBox.Show("default: 2 biti de predictie");
                        biti_pred = 1;
                    }
                    break;
            }

            return biti_pred;
        }
        public double regulaTreiSimpla(int valoareTotal, int valoareCalculata )
        {
            double percentage;
            double a = 100;

            percentage = (a * valoareCalculata) / valoareTotal;

            return percentage;
        }
        public void Modif(int val)
        {
           
            HRg = HRg.Substring(1, HRg.Length -1 );
            HRg += val.ToString();

            //pattern = pattern.Substring(1, pattern.Length - 1);
            //pattern += val.ToString();
            //daca nu da cu m =x ma duc cu pattern mai jos
        }
        Instructiune instr = null;
        int nr_total_salturi;
        private void Calcule(StreamReader toate_liniile_fbubble)
        {
            
            string[] cuvant;
            string o_linie_fisier;
            nr_total_salturi = 0;

            //total_linii = 1;

            while ((o_linie_fisier = toate_liniile_fbubble.ReadLine()) != null)
            {
                cuvant = o_linie_fisier.Split(' ');
                
                instr = new Instructiune(cuvant[0], cuvant[1], cuvant[2]);

                PPM(m_PPM, pattern,instr);
            

                nr_total_salturi++;
                total_linii++;
            }
            
            txtTotalSalturi.Text = nr_total_salturi.ToString();

        }

        public void PPM(int ordin, string pattern, Instructiune instr)
        {
            int verific = -1;
            verific = instr.Taken_NotTaken(instr.tip);

            Markov(ordin, pattern);
            if (frecv_0 > frecv_1)// prezic ca o sa fie 0
            {
                if (verific == 0)
                {
                    predictii_corecte++;
                    Modif(0);

                }
                else if (verific == 1)
                {
                    predictii_incorecte++;
                    Modif(1);
                }
            }

            else
            {
                if (frecv_0 <= frecv_1)// prezic ca o sa fie 0
                {
                    if (verific == 0)
                    {
                        predictii_incorecte++;
                        Modif(0);
                    }
                    else if (verific == 1)
                    {
                        predictii_corecte++;
                        Modif(1);
                    }

                }

            }
        }

       
        public void Markov(int ordin, string pattern)// + pattern!!!!         
        {
            //caut pattern in HRg
            int j=0;
            string bit_urmator;
            //int verific = -1;


            if (ordin == 0) //iau cel mai frecv bit din tot sirul -> Markov(0)
            {
                for (int i = 0; i < HRg.Length; i++)
                {
                    if (HRg.Substring(i, 1) == "0")
                    {
                        frecv_0++;
                    }
                    else
                    {
                        frecv_1++;
                    }
                }
            }
            else if (ordin > 0)
            {
                for (int i = 0; i <= HRg.Length - ordin; i++)
                {
                    j = i + ordin;

                    if (pattern == HRg.Substring(i, ordin))
                    {
                        //daca gasesc iau bitul care apare cel mai frecvent dupa acel pattern (pe tot stringul)
                        bit_urmator = HRg.Substring(ordin, 1);

                        if (bit_urmator == "0")
                            frecv_0++;
                        else
                            frecv_1++;

                    }
                }
                //daca NU gasesc nimic pana la final,
                //pattern-cel mai din stanga bit

                ordin--;
                if (ordin != 0)
                    pattern = pattern.Substring(1, ordin);//, ordin);
                                                          //pattern = pattern.Substring(j, ordin);

                //vf daca perdictia a fost corecta sau incorecta
                Markov(ordin, pattern);

            }
        }

        private void chechHRg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chechHRg_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnBubble_Click(object sender, EventArgs e)
        {
            double procentaj;
            HRg = null;
            pattern = null;
            predictii_corecte = 0;
            predictii_incorecte = 0;
            total_linii = 1;
            Trace = "FBUBBLE";

            m_PPM = Ordin_PPM(); //lung patternului pe care il caut in HRg, la inceput cu 0;
            for(int i =0; i<m_PPM; i++)
                pattern += "0";
            
            dimensiune_HRg = Dimensiune_HRg();
            for (int i = 0; i < dimensiune_HRg; i++)
                HRg += "0";
            

            nr_biti_pred = Biti_Predictie();

            System.IO.StreamReader toate_liniile_fbubble = new System.IO.StreamReader(path+Trace+extensie);

            Calcule(toate_liniile_fbubble);

            rchTrace.Text += "FBUBBLE" + "\n" + "-------\n";
            richTextBox7.Text += HRg.Length.ToString() + "\n" + "-------\n";

            rchIncorecte.Text += predictii_incorecte + "\n" + "-------\n";
            procentaj = regulaTreiSimpla(nr_total_salturi, predictii_incorecte);
            rchIncProc.Text += procentaj.ToString("#.##") + "\n" + "-------\n";

            rchCorecte.Text += predictii_corecte + "\n" + "-------\n";
            procentaj = regulaTreiSimpla(nr_total_salturi, predictii_corecte);
            rchCorecteProc.Text += procentaj.ToString("#.##") + "\n" + "-------\n";

            rchTotal.Text += nr_total_salturi.ToString() + "\n" + "-------\n";

            progressBar1_Click(sender, e);

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void btnSort_Click(object sender, EventArgs e)
        {

            double procentaj;
            HRg = null;
            pattern = null;
            predictii_corecte = 0;
            predictii_incorecte = 0;
            total_linii = 1;
            Trace = "FSORT";

            m_PPM = Ordin_PPM(); //lung patternului pe care il caut in HRg, la inceput cu 0;
            for (int i = 0; i < m_PPM; i++)
                pattern += "0";

            dimensiune_HRg = Dimensiune_HRg();
            for (int i = 0; i < dimensiune_HRg; i++)
                HRg += "0";


            nr_biti_pred = Biti_Predictie();

            System.IO.StreamReader toate_liniile = new System.IO.StreamReader(path + Trace + extensie);

            Calcule(toate_liniile);

            rchTrace.Text += "FSORT" + "\n" + "-------\n";
            richTextBox7.Text += HRg.Length.ToString() + "\n" + "-------\n";

            rchIncorecte.Text += predictii_incorecte + "\n" + "-------\n";
            procentaj = regulaTreiSimpla(nr_total_salturi, predictii_incorecte);
            rchIncProc.Text += procentaj.ToString("#.##") + "\n" + "-------\n";

            rchCorecte.Text += predictii_corecte + "\n" + "-------\n";
            procentaj = regulaTreiSimpla(nr_total_salturi, predictii_corecte); ;
            rchCorecteProc.Text += procentaj.ToString("#.##") + "\n" + "-------\n";

            rchTotal.Text += nr_total_salturi.ToString() + "\n" + "-------\n";
            
            progressBar1_Click(sender, e);
           
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            double procentaj =0;
            procentaj = regulaTreiSimpla(nr_total_salturi, predictii_corecte);

            lblAcuratete.Text = procentaj.ToString("#.##") + " %";

            progressBar1.Maximum = nr_total_salturi;

            progressBar1.Step = 100;
            for(int i=0;i<predictii_corecte; i+=100)
            {
                progressBar1.PerformStep();
            }
            

        }

        private void btnMatrix_Click(object sender, EventArgs e)
        {
            double procentaj;
            HRg = null;
            pattern = null;
            predictii_corecte = 0;
            predictii_incorecte = 0;
            total_linii = 1;
            Trace = "FMATRIX";

            m_PPM = Ordin_PPM(); //lung patternului pe care il caut in HRg, la inceput cu 0;
            for (int i = 0; i < m_PPM; i++)
                pattern += "0";

            dimensiune_HRg = Dimensiune_HRg();
            for (int i = 0; i < dimensiune_HRg; i++)
                HRg += "0";


            nr_biti_pred = Biti_Predictie();

            System.IO.StreamReader toate_liniile = new System.IO.StreamReader(path + Trace + extensie);

            Calcule(toate_liniile);

            rchTrace.Text += "FMATRIX" + "\n" + "-------\n";
            richTextBox7.Text += HRg.Length.ToString() + "\n" + "-------\n";

            rchIncorecte.Text += predictii_incorecte + "\n" + "-------\n";
            procentaj = regulaTreiSimpla(nr_total_salturi, predictii_incorecte);
            rchIncProc.Text += procentaj.ToString("#.##") + "\n" + "-------\n";

            rchCorecte.Text += predictii_corecte + "\n" + "-------\n";
            procentaj = regulaTreiSimpla(nr_total_salturi, predictii_corecte);
            rchCorecteProc.Text += procentaj.ToString("#.##") + "\n" + "-------\n";

            rchTotal.Text += nr_total_salturi.ToString() + "\n" + "-------\n";

            progressBar1_Click(sender, e);

        }

        private void btnPerm_Click(object sender, EventArgs e)
        {

            double procentaj;
            HRg = null;
            pattern = null;
            predictii_corecte = 0;
            predictii_incorecte = 0;
            total_linii = 1;
            Trace = "FPERM";

            m_PPM = Ordin_PPM(); //lung patternului pe care il caut in HRg, la inceput cu 0;
            for (int i = 0; i < m_PPM; i++)
                pattern += "0";

            dimensiune_HRg = Dimensiune_HRg();
            for (int i = 0; i < dimensiune_HRg; i++)
                HRg += "0";


            nr_biti_pred = Biti_Predictie();

            System.IO.StreamReader toate_liniile = new System.IO.StreamReader(path + Trace + extensie);

            Calcule(toate_liniile);

            rchTrace.Text += "FPERM" + "\n" + "-------\n";
            richTextBox7.Text += HRg.Length.ToString() + "\n" + "-------\n";

            rchIncorecte.Text += predictii_incorecte + "\n" + "-------\n";
            procentaj = regulaTreiSimpla(nr_total_salturi, predictii_incorecte);
            rchIncProc.Text += procentaj.ToString("#.##") + "\n" + "-------\n";

            rchCorecte.Text += predictii_corecte + "\n" + "-------\n";
            procentaj = regulaTreiSimpla(nr_total_salturi, predictii_corecte);
            rchCorecteProc.Text += procentaj.ToString("#.##") + "\n" + "-------\n";

            rchTotal.Text += nr_total_salturi.ToString() + "\n" + "-------\n";

            progressBar1_Click(sender, e);

        }

        private void btnPuzzle_Click(object sender, EventArgs e)
        {

            double procentaj;
            HRg = null;
            pattern = null;
            predictii_corecte = 0;
            predictii_incorecte = 0;
            total_linii = 1;
            Trace = "FPUZZLE";

            m_PPM = Ordin_PPM(); //lung patternului pe care il caut in HRg, la inceput cu 0;
            for (int i = 0; i < m_PPM; i++)
                pattern += "0";

            dimensiune_HRg = Dimensiune_HRg();
            for (int i = 0; i < dimensiune_HRg; i++)
                HRg += "0";


            nr_biti_pred = Biti_Predictie();

            System.IO.StreamReader toate_liniile = new System.IO.StreamReader(path + Trace + extensie);

            Calcule(toate_liniile);

            rchTrace.Text += "FPUZZLE" + "\n" + "-------\n";
            richTextBox7.Text += HRg.Length.ToString() + "\n" + "-------\n";

            rchIncorecte.Text += predictii_incorecte + "\n" + "-------\n";
            procentaj = regulaTreiSimpla(nr_total_salturi, predictii_incorecte);
            rchIncProc.Text += procentaj.ToString("#.##") + "\n" + "-------\n";

            rchCorecte.Text += predictii_corecte + "\n" + "-------\n";
            procentaj = regulaTreiSimpla(nr_total_salturi, predictii_corecte);
            rchCorecteProc.Text += procentaj.ToString("#.##") + "\n" + "-------\n";

            rchTotal.Text += nr_total_salturi.ToString() + "\n" + "-------\n";

            progressBar1_Click(sender, e);

        }

        private void btnQueens_Click(object sender, EventArgs e)
        {

            double procentaj;
            HRg = null;
            pattern = null;
            predictii_corecte = 0;
            predictii_incorecte = 0;
            total_linii = 1;
            Trace = "FQUEENS";
            m_PPM = Ordin_PPM(); //lung patternului pe care il caut in HRg, la inceput cu 0;
            for (int i = 0; i < m_PPM; i++)
                pattern += "0";

            dimensiune_HRg = Dimensiune_HRg();
            for (int i = 0; i < dimensiune_HRg; i++)
                HRg += "0";


            nr_biti_pred = Biti_Predictie();

            System.IO.StreamReader toate_liniile = new System.IO.StreamReader(path + Trace + extensie);

            Calcule(toate_liniile);

            rchTrace.Text += "FQUEENS" + "\n" + "-------\n";
            richTextBox7.Text += HRg.Length.ToString() + "\n" + "-------\n";

            rchIncorecte.Text += predictii_incorecte + "\n" + "-------\n";
            procentaj = regulaTreiSimpla(nr_total_salturi, predictii_incorecte);
            rchIncProc.Text += procentaj.ToString("#.##") + "\n" + "-------\n";

            rchCorecte.Text += predictii_corecte + "\n" + "-------\n";
            procentaj = regulaTreiSimpla(nr_total_salturi, predictii_corecte);
            rchCorecteProc.Text += procentaj.ToString("#.##") + "\n" + "-------\n";

            rchTotal.Text += nr_total_salturi.ToString() + "\n" + "-------\n";

            progressBar1_Click(sender, e);

        }

        private void btnTower_Click(object sender, EventArgs e)
        {

            double procentaj;
            HRg = null;
            pattern = null;
            predictii_corecte = 0;
            predictii_incorecte = 0;
            total_linii = 1;
            Trace = "FTOWER";

            m_PPM = Ordin_PPM(); //lung patternului pe care il caut in HRg, la inceput cu 0;
            for (int i = 0; i < m_PPM; i++)
                pattern += "0";

            dimensiune_HRg = Dimensiune_HRg();
            for (int i = 0; i < dimensiune_HRg; i++)
                HRg += "0";


            nr_biti_pred = Biti_Predictie();

            System.IO.StreamReader toate_liniile = new System.IO.StreamReader(path + Trace + extensie);

            Calcule(toate_liniile);

            rchTrace.Text += "FTOWER" + "\n" + "-------\n";
            richTextBox7.Text += HRg.Length.ToString() + "\n" + "-------\n";

            rchIncorecte.Text += predictii_incorecte + "\n" + "-------\n";
            procentaj = regulaTreiSimpla(nr_total_salturi, predictii_incorecte);
            rchIncProc.Text += procentaj.ToString("#.##") + "\n" + "-------\n";

            rchCorecte.Text += predictii_corecte + "\n" + "-------\n";
            procentaj = regulaTreiSimpla(nr_total_salturi, predictii_corecte);
            rchCorecteProc.Text += procentaj.ToString("#.##") + "\n" + "-------\n";

            rchTotal.Text += nr_total_salturi.ToString() + "\n" + "-------\n";

            progressBar1_Click(sender, e);

        }

        private void btnTree_Click(object sender, EventArgs e)
        {

            double procentaj;
            HRg = null;
            pattern = null;
            predictii_corecte = 0;
            predictii_incorecte = 0;
            total_linii = 1;
            Trace = "FTREE";

            m_PPM = Ordin_PPM(); //lung patternului pe care il caut in HRg, la inceput cu 0;
            for (int i = 0; i < m_PPM; i++)
                pattern += "0";

            dimensiune_HRg = Dimensiune_HRg();
            for (int i = 0; i < dimensiune_HRg; i++)
                HRg += "0";


            nr_biti_pred = Biti_Predictie();

            System.IO.StreamReader toate_liniile = new System.IO.StreamReader(path + Trace + extensie);
            Calcule(toate_liniile);

            rchTrace.Text += "FTREE" + "\n" + "-------\n";
            richTextBox7.Text += HRg.Length.ToString() + "\n" + "-------\n";

            rchIncorecte.Text += predictii_incorecte + "\n" + "-------\n";
            procentaj = regulaTreiSimpla(nr_total_salturi, predictii_incorecte);
            rchIncProc.Text += procentaj.ToString("#.##") + "\n" + "-------\n";

            rchCorecte.Text += predictii_corecte + "\n" + "-------\n";
            procentaj = regulaTreiSimpla(nr_total_salturi, predictii_corecte);
            rchCorecteProc.Text += procentaj.ToString("#.##") + "\n" + "-------\n";

            rchTotal.Text += nr_total_salturi.ToString() + "\n" + "-------\n";

            progressBar1_Click(sender, e);

        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {

            TextWriter txt = new StreamWriter(path + "Output.txt");
            txt.Write($"Trace: {Trace} \n Corecte: {predictii_corecte} \n Total: {nr_total_salturi} \n Acuratete: {lblAcuratete.Text} \n");
            txt.Close();
        }

        private void Corect_Click(object sender, EventArgs e)
        {

        }
    }
}
