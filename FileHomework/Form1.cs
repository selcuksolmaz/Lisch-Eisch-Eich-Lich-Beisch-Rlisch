using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileHomework
{
   
    public partial class Form1 : Form
    {
        private const string floatcontrol = "#0.00000";

        private int number;
        private int[] random_number;
        private int[] record_number;
        private int[] link_number;

        private int[] record_number_lisch;
        private int[] record_number_eisch;
        private int[] record_number_lich;
        private int[] record_number_eich;
        private int[] record_number_beisch;
        private int[] record_number_rlisch;

        private int[] link_number_lisch;
        private int[] link_number_eisch;
        private int[] link_number_lich;
        private int[] link_number_eich;
        private int[] link_number_beisch;
        private int[] link_number_rlisch;

        private double averageprobe;

        private readonly Random random = new Random();

        public Form1()
        {
            InitializeComponent();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateRandom_Click(object sender, EventArgs e)
        {
            try
            {
                number = Convert.ToInt32(txtbCreateRandom.Text);//

            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Enter a Value!\n" + ex.Message);
            }
            if (number > 900)
            {
                MessageBox.Show("Enter a value less than 900!");
                number = Convert.ToInt32(txtbCreateRandom.Text);
            }
            else if (number <= 0)
            {
                MessageBox.Show("Enter a value greater than 0!");
                number = Convert.ToInt32(txtbCreateRandom.Text);
            }
            else
            {
                
                random_number = new int[number]; //
                record_number = new int[(int)(FindPrimeNumber(number))];
                link_number = new int[Convert.ToInt32(FindPrimeNumber(number))];

                record_number_lisch = new int[(int)(FindPrimeNumber(number))];
                link_number_lisch = new int[Convert.ToInt32(FindPrimeNumber(number))];

                record_number_eisch = new int[(int)(FindPrimeNumber(number))];
                link_number_eisch = new int[Convert.ToInt32(FindPrimeNumber(number))];

                record_number_lich = new int[(int)(FindPrimeNumber(number))];
                link_number_lich = new int[Convert.ToInt32(FindPrimeNumber(number))];

                record_number_eich = new int[(int)(FindPrimeNumber(number))];
                link_number_eich = new int[Convert.ToInt32(FindPrimeNumber(number))];

                record_number_beisch = new int[(int)(FindPrimeNumber(number))];
                link_number_beisch = new int[Convert.ToInt32(FindPrimeNumber(number))];

                record_number_rlisch = new int[(int)(FindPrimeNumber(number))];
                link_number_rlisch = new int[Convert.ToInt32(FindPrimeNumber(number))];

                for (int i = 0; i < number; ++i)
                {
                    random_number[i] = random.Next(1, 900);

                }
                ShowOnListBox(random_number);
                
                for (int j = 0; j < random_number.Length; j++)//Lisch Added
                {
                    LISCH_Add(record_number,link_number,random_number[j]);
                    averageprobe = Performance();
                }
                lstbLisch.Items.Clear();
                for (int i = 0; i < record_number.Length; i++)
                {
                    lstbLisch.Items.Add((i).ToString()+ " -) Record  "+record_number[i].ToString()+ " Link "+link_number[i].ToString());//Lisch Show
                    record_number_lisch[i] = record_number[i];
                    link_number_lisch[i] = link_number[i];
                    lblAPLisch.Text = averageprobe.ToString(floatcontrol);
                    record_number[i] = 0;//Array Deleted
                    link_number[i] = 0;//Array Deleted
                }
                averageprobe = 0;
                lstbEisch.Items.Clear();
                for (int i = 0; i < random_number.Length; i++)//Eisch Added
                {
                    EISCH_Add(record_number, link_number, random_number[i]);
                    averageprobe = Performance();
                }
                for (int i = 0; i < record_number.Length; i++)
                {
                    lstbEisch.Items.Add((i).ToString() + " -) Record  " + record_number[i].ToString() + " Link " + link_number[i].ToString());
                    record_number_eisch[i] = record_number[i];
                    link_number_eisch[i] = link_number[i];
                    lblAPEisch.Text = averageprobe.ToString(floatcontrol);
                    record_number[i] = 0;//Array Deleted
                    link_number[i] = 0;//Array Deleted
                }
                averageprobe = 0;
                lstbBeisch.Items.Clear();
                for (int i = 0; i < random_number.Length; i++)//Beisch Added
                {
                    BEISCH_Add(record_number, link_number, random_number[i]);
                    averageprobe = Performance();
                }
                for (int i = 0; i < record_number.Length; i++)
                {
                    lstbBeisch.Items.Add((i).ToString() + " -) Record  " + record_number[i].ToString() + " Link " + link_number[i].ToString());
                    record_number_beisch[i] = record_number[i];
                    link_number_beisch[i] = link_number[i];
                    lblAPBeisch.Text = averageprobe.ToString(floatcontrol);
                    record_number[i] = 0;//Array Deleted
                    link_number[i] = 0;//Array Deleted
                }
                averageprobe = 0;
                lstbRlisch.Items.Clear();
                for (int i = 0; i < random_number.Length; i++)//Rlisch Added
                {
                    RLISCH_Add(record_number, link_number, random_number[i]);
                    averageprobe = Performance();
                }
                for (int i = 0; i < record_number.Length; i++)
                {
                    lstbRlisch.Items.Add((i).ToString() + " -) Record  " + record_number[i].ToString() + " Link " + link_number[i].ToString());
                    record_number_rlisch[i] = record_number[i];
                    link_number_rlisch[i] = link_number[i];
                    lblAPRlisch.Text = averageprobe.ToString(floatcontrol);
                    record_number[i] = 0;//Array Deleted
                    link_number[i] = 0;//Array Deleted
                }

                averageprobe = 0;
                lstbLich.Items.Clear();
                for (int i = 0; i < random_number.Length; i++)//Lich Added
                {
                    LICH_Add(record_number, link_number, random_number[i]);
                    averageprobe = Performance();
                }
                for (int i = 0; i < record_number.Length; i++)
                {
                    lstbLich.Items.Add((i).ToString() + " -) Record  " + record_number[i].ToString() + " Link " + link_number[i].ToString());
                    record_number_lich[i] = record_number[i];
                    link_number_lich[i] = link_number[i];
                    lblAPLich.Text = averageprobe.ToString(floatcontrol);
                    record_number[i] = 0;//Array Deleted
                    link_number[i] = 0;//Array Deleted
                }
                averageprobe = 0;
                lstbEich.Items.Clear();
                for (int i = 0; i < random_number.Length; i++)//Eich Added
                {
                    EICH_Add(record_number, link_number, random_number[i]);
                    averageprobe = Performance();
                }
                for (int i = 0; i < record_number.Length; i++)
                {
                    lstbEich.Items.Add((i).ToString() + " -) Record  " + record_number[i].ToString() + " Link " + link_number[i].ToString());
                    record_number_eich[i] = record_number[i];
                    link_number_eich[i] = link_number[i];
                    lblAPEich.Text = averageprobe.ToString(floatcontrol);
                    record_number[i] = 0;//Array Deleted
                    link_number[i] = 0;//Array Deleted
                }
                lblPFBeisch.Text = (number/FindPrimeNumber(number)).ToString(floatcontrol);
                lblPFRlisch.Text = (number/FindPrimeNumber(number)).ToString(floatcontrol);
                lblPFLisch.Text = (number/FindPrimeNumber(number)).ToString(floatcontrol);
                lblPFEisch.Text = (number/FindPrimeNumber(number)).ToString(floatcontrol);
                lblPFLich.Text = (number/FindPrimeNumber(number)).ToString(floatcontrol);
                lblPFEich.Text = (number/FindPrimeNumber(number)).ToString(floatcontrol);

                lblTMBeisch.Text = FindPrimeNumber(number).ToString();
                lblTMRlisch.Text = FindPrimeNumber(number).ToString();
                lblTMLisch.Text =  FindPrimeNumber(number).ToString();
                lblTMEisch.Text =  FindPrimeNumber(number).ToString();
                lblTMLich.Text =   FindPrimeNumber(number).ToString();
                lblTMEich.Text =   FindPrimeNumber(number).ToString();

                lblTRBeisch.Text = number.ToString();
                lblTRRlisch.Text = number.ToString();
                lblTRLisch.Text = number.ToString();
                lblTREisch.Text = number.ToString();
                lblTRLich.Text = number.ToString();
                lblTREich.Text = number.ToString();
                
            }
        }

        void ShowOnListBox(int[] array)
        {
            lstbRandomNumber.Items.Clear();
            for (int i = 0; i < array.Length; ++i)
            {
                double primenumber = FindPrimeNumber(Convert.ToDouble(array.Length));
                lstbRandomNumber.Items.Add((i + 1).ToString() + "-) " + array[i].ToString() + " Mode " + primenumber.ToString() + " = " + (array[i] % primenumber).ToString());
            }
        }

        public double FindPrimeNumber(double value)
        {
            double primenumber = value + 1;
            double percentage;
        tekrarara:

            for (int i = 2; i <= (int)Math.Sqrt(primenumber); i++)
            {
                percentage = Convert.ToDouble(number) / Convert.ToDouble(primenumber) * 100;
                if (primenumber % i == 0)
                {
                    primenumber = primenumber + 1;
                    goto tekrarara;
                }
                if (percentage >= 90)
                    return FindPrimeNumber(primenumber);

            }

            return primenumber;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            
        }

        private void LISCH_Add(int [] recordarray,int [] linkarray,int addnumber)
        {
            int id = (int)(addnumber % FindPrimeNumber(number));
            int last_id = Convert.ToInt32(recordarray.Length -1);

            if (recordarray[id] == 0)
            {
                recordarray[id] = addnumber;
            }
            else
            {
                while (recordarray[last_id] != 0)
                {
                    last_id--;
                }
                while (linkarray[id] != 0)
                {
                    id = linkarray[id];
                }

                recordarray[last_id] = addnumber;

                linkarray[id] = last_id;

            }
        }

        private void EISCH_Add(int[] recordarray, int[] linkarray, int addnumber)
        {
            int id = (int)(addnumber % FindPrimeNumber(number));
            int last_id = id;
            if (recordarray[id] == 0)
            {
                recordarray[id] = addnumber;
            }
            else
            {
                
                while (linkarray[last_id] != 0)
                {
                    last_id = linkarray[last_id];
                }
                while (recordarray[last_id] != 0)
                {
                    last_id = (int)((last_id + FindPrimeNumber(number)-1) % FindPrimeNumber(number)); //
                }

                recordarray[last_id] = addnumber;

                if (linkarray[id] != 0)
                {
                    linkarray[last_id] = linkarray[id];
                }
                linkarray[id] = last_id;
            }
        }

        private void BEISCH_Add(int[] recordarray, int[] linkarray, int addnumber)
        {
            int  id = (int)(addnumber % FindPrimeNumber(number));
            if (recordarray[id] == 0)
            {
                recordarray[id] = addnumber;
            }
            else
            {
                bool temp = true;
                int bottom = -1;
                int up = (int)(FindPrimeNumber(number)-1);
                int last_id = up;
                while (recordarray[last_id] != 0)
                {
                    if (temp)
                    {
                        last_id = ++bottom;
                    }
                    else
                    {
                        last_id = --up;
                    }
                    temp = !temp;
                }

                recordarray[last_id] = addnumber;

                if (linkarray[id] != 0)
                {
                    linkarray[last_id] = linkarray[id];
                }
                linkarray[id] = last_id;
            }
        }

        private void RLISCH_Add(int[] recordarray, int[] linkarray, int addnumber)
        {
            int id = (int)(addnumber % FindPrimeNumber(number));
            if (recordarray[id] == 0)
            {
                recordarray[id] = addnumber;
            }
            else
            {
                int last_id = (int)(random.Next(0,(int)(FindPrimeNumber(number))));
                while (recordarray[last_id] != 0)
                {
                    last_id = (int)(random.Next(0,(int)(FindPrimeNumber(number))));
                }
                while (linkarray[id] != 0)
                {
                    id = linkarray[id];
                }

                recordarray[last_id] = addnumber;

                linkarray[id] = last_id;
            }
        }

        private void LICH_Add(int[] recordarray, int[] linkarray, int addnumber)
        {
            int id = (int)(addnumber % ((int)(FindPrimeNumber(number)-1) - (int)((FindPrimeNumber(number)*cmbPercentage.Items.Count)/100)));
            if (record_number[id] == 0)
            {
                recordarray[id] = addnumber;
            }
            else
            {
                int last_id = ((int)FindPrimeNumber(number)-1);
                while (recordarray[last_id] != 0)
                {
                    last_id--;
                }
                while (linkarray[id] != 0)
                {
                    id = linkarray[id];
                }

                recordarray[last_id] = addnumber;

                linkarray[id] = last_id;
            }
        }

        private void EICH_Add(int[] recordarray, int[] linkarray, int addnumber)
        {
            int id = (int)(addnumber % ((int)(FindPrimeNumber(number) - 1) - (int)((FindPrimeNumber(number) * cmbPercentage.Items.Count) / 100)));
            if (recordarray[id]== 0)
            {
                recordarray[id] = addnumber;
            }
            else
            {
                int last_id = id;
                while (linkarray[last_id] != 0)
                {
                    last_id = linkarray[last_id];
                }
                while (recordarray[last_id] != 0)
                {
                    last_id = (int)((last_id + (FindPrimeNumber(number)-1)) % FindPrimeNumber(number)); //
                }

                recordarray[last_id] = addnumber;

                if (linkarray[id] != 0)
                {
                    linkarray[last_id] = linkarray[id];
                }
                linkarray[id] = last_id;
            }
        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private double Search(int searchnumber, bool real)
        {
            double probe = 1;
            int id = (int)(searchnumber % FindPrimeNumber(number));
            while (true)
            {
                if (record_number[id] == searchnumber)
                {
                    if (real)
                    {
                        lblInfo.Text = "Found, Index: " + id;
                    }
                    break;
                }
                else
                {
                    id = link_number[id];
                    probe++;
                }

                if (id == 0)
                {
                    if (real)
                    {
                        lblInfo.Text = "Results not found.";
                    }
                    break;
                }
            }
            return probe;
        }
        public int İndexAra(int[] arrKey, int key)
        {
            int arananDeger = 0;
            int i = 0;
            while (key != arrKey[i])
            {
                i++;
                if (key == arrKey[i])
                {
                    arananDeger = i;
                }
                else
                {
                    arananDeger = -1;
                }
            }

            return arananDeger;

        }
        private double Performance()
        {
            double average;
            double temp = 0;
            for (int i = 0; i < number; i++)
            {
                temp += Search(random_number[i], false);
            }
            average = temp / number;
            return average;
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void bynSearch_Click(object sender, EventArgs e)
        {
            try
            {
                lblSILisch.Text = Convert.ToString(
                            İndexAra(record_number_lisch, Convert.ToInt32(txtbSearch.Text)));
                lblSIEisch.Text = Convert.ToString(
                            İndexAra(record_number_eisch, Convert.ToInt32(txtbSearch.Text)));
                  lblSIEich.Text = Convert.ToString(
                            İndexAra(record_number_eich, Convert.ToInt32(txtbSearch.Text)));
                lblSILich.Text = Convert.ToString(
                            İndexAra(record_number_lich, Convert.ToInt32(txtbSearch.Text)));
                lblSIBeisch.Text = Convert.ToString(
                        İndexAra(record_number_beisch, Convert.ToInt32(txtbSearch.Text)));
                lblSIRlisch.Text = Convert.ToString(
                        İndexAra(record_number_rlisch, Convert.ToInt32(txtbSearch.Text)));
            }
            catch (Exception)
            {

                MessageBox.Show("Aranan Değer Bulunamadı!");
            }
        }
    }
}
