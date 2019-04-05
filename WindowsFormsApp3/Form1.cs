using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;




namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        
        decimal Hard;
        decimal NO3;
        decimal SO4;
        decimal devideNO3SO4;
        decimal volumeA202;//объем смолы 202
        decimal volumeTC007;//объем смолы 007
        decimal averageFlow;//производительность системы
        decimal filtroCycle;
        decimal bypass;
        decimal cationCapasityL;//емкость одного литра катионита
        decimal anionCapasityFull;//емкость всего объема анионита
        decimal cationCapasityFull;//емкость всего объема катионита
        decimal sumAnion;
        int VAnion;
        int VCation;
        decimal salt;
        
        string typeColumn;
        decimal sColumn;
        decimal fullVolume;//полный объем смолы
        decimal k = 0.785M;
        



        public Form1()
        {
            InitializeComponent();
            V250.Checked = true;
        }

        public void CommonСalc()
        {
            NO3 = decimal.Parse(NO3TextBox.Text);
            SO4 = decimal.Parse(SO4TextBox.Text);
            devideNO3SO4 = (NO3 / 62) / (NO3 / 62 + SO4 / 48);
            Hard = decimal.Parse(hardnessTextBox.Text);

            

            // devideNO3SO4Text = AnionCapasity125().ToString("0.00");
            // workCapacityText = AnionCapasity125().ToString("0.00");
                                 
            //считаем линейную скорость по катионам и анионам:
            //анионы
            sumAnion = NO3 + SO4;
            Hard = decimal.Parse(hardnessTextBox.Text);
            if (sumAnion <= 50M)
            {
                VAnion = 25;
            }
            else if (sumAnion > 50M && sumAnion <= 100M)
            {
                VAnion = 20;
            }
            else if (sumAnion > 100M && sumAnion <= 150M)
            {
                VAnion = 15;
            }
            else if (sumAnion > 150M && sumAnion <= 200M)
            {
                VAnion = 12;
            }
            else
            {
                VAnion = 10;
            }
            //катионы по жесткости
            if (Hard <= 5)
            {
                VCation = 25; //назначаем линейные скорости
            }
            else if (Hard > 5 & Hard <= 10)
            {
                VCation = 20;
            }
            else if (Hard > 10 & Hard <= 14)
            {
                VCation = 15;
            }
            else if (Hard > 14 & Hard <= 18)
            {
                VCation = 12;
            }
            else
            {
                VCation = 10;
            }


            //Выбираем меньшее:

            decimal VReal = Math.Min(VCation, VAnion);

            SColumnClass();
            averageFlow = VReal * sColumn;
            averageFlowTextBox.Text = averageFlow.ToString("0.00");


        }
        private decimal bypass125()
        {

            //определяем по графику проскок по нитратам для 125г NaCl на л:
            if (devideNO3SO4 > 0.8M && devideNO3SO4 <= 1.0M)
            {
                return (-5M * devideNO3SO4 + 17M) * NO3 * 0.01M;
            }
            else if (devideNO3SO4 > 0.6M && devideNO3SO4 <= 0.8M)
            {
                return (-25M * devideNO3SO4 + 33M) * NO3 * 0.01M;
            }
            else if (devideNO3SO4 > 0.4M && devideNO3SO4 <= 0.6M)
            {
                return (-35M * devideNO3SO4 + 39M) * NO3 * 0.01M;
            }
            else if (devideNO3SO4 > 0.2M && devideNO3SO4 <= 0.4M)
            {
                return (-55M * devideNO3SO4 + 47M) * NO3 * 0.01M;
            }
            else if (devideNO3SO4 > 0M && devideNO3SO4 <= 0.2M)
            {
               return (-90M * devideNO3SO4 + 55M) * NO3 * 0.01M;
            }
            else
            {
                return  NO3;
            }
            //MessageBox.Show((bypassNO3 / (0.01M * NO3)).ToString());
        }

        private decimal bypass250()
        {
            //определяем по графику проскок по нитратам для 250г NaCl на л:
            if (devideNO3SO4 > 0.8M && devideNO3SO4 <= 1.0M)
             {
                return (-2.5M * devideNO3SO4 + 11.5M) * NO3 * 0.01M;
             }
             else if (devideNO3SO4 > 0.6M && devideNO3SO4 <= 0.8M)
             {
                return (-7.5M * devideNO3SO4 + 15.5M) * NO3 * 0.01M;
             }
             else if (devideNO3SO4 > 0.4M && devideNO3SO4 <= 0.6M)
             {
                return (-25M * devideNO3SO4 + 26M) * NO3 * 0.01M;
             }
             else if (devideNO3SO4 > 0.2M && devideNO3SO4 <= 0.4M)
             {
                return (-45M * devideNO3SO4 + 34M) * NO3 * 0.01M;
             }
             else if (devideNO3SO4 > 0M && devideNO3SO4 <= 0.2M)
             {
                return (-75M * devideNO3SO4 + 40M) * NO3 * 0.01M;
             }
             else
             {
                return NO3;
             }
             
        }


        public decimal AnionCapasitySelected()

            //работаем с выбором 125 или 250
        {
            if (V125.Checked)
            {
                textBox3.Text = bypass125().ToString("0.0");
                bypass = bypass125();
                salt = 0.125M;
                return AnionCapasity125();
                
            }
            else if (V250.Checked)
            {
                textBox3.Text = bypass250().ToString("0.0");
                bypass = bypass250();
                salt = 0.250M;
                return AnionCapasity250();
            }
            else
            {
                MessageBox.Show("Выберите количество соли для регенерации: 125г или 250г");
            }
            return 0;
        }
        


        public void  SColumnClass() 
        {
            if (typeColumn == "8x44 или кабинет")
            {
                sColumn = k * (0.205M * 0.205M);
                fullVolume = 20M;
            }
            else if (typeColumn == "10х44")
            {
                sColumn = k * (0.257M * 0.257M);
                fullVolume = 25M;
            }
            else if (typeColumn == "10х54")
            {
                sColumn = k * (0.257M * 0.257M);
                fullVolume = 37.5M;
            }
                        
            else if (typeColumn == "12х52")
            {
                sColumn = k * (0.307M * 0.307M);
                fullVolume = 50M;
            }
                      
            else if (typeColumn == "13х54")
            {
                sColumn = k * (0.335M * 0.335M);
                fullVolume = 50M;
            }
            else if (typeColumn == "14х65")
            {
                sColumn = k * (0.366M * 0.366M);
                fullVolume = 75M;
            }
            else if (typeColumn == "16х65")
            {
                sColumn = k * (0.411M * 0.411M);
                fullVolume = 113M;
            }
            else if (typeColumn == "18х65")
            {
                sColumn = k * (0.491M * 0.491M);
                fullVolume = 150M;
            }
            else if (typeColumn == "21х62")
            {
                sColumn = k * (0.555M * 0.555M);
                fullVolume = 188M;
            }
            else if (typeColumn == "24х72")
            {
                sColumn = k * (0.611M * 0.611M);
                fullVolume = 275M;
            }
            else if (typeColumn == "30х72")
            {
                sColumn = k * (0.781M * 0.781M);
                fullVolume = 425M;
            }
            else if (typeColumn == "36х72")
            {
                sColumn = k * (0.934M * 0.934M);
                fullVolume = 625M;
            }
            else if (typeColumn == "42х72")
            {
                sColumn = k * (1.09M * 1.09M);
                fullVolume = 850M;
            }
            else if (typeColumn == "48х72") 
            {
                sColumn = k * (1.235M * 1.235M);
                fullVolume = 1050M;
            }
            else 
            {
                sColumn = k * (1.6M * 1.6M);
                fullVolume = 1200M;
            }

        }

        public void Capacity()
        {
            // volumeA202 = Math.Floor(0.25M * fullVolume);
            // volumeTC007 = fullVolume - volumeA202;

            cationCapasityL =1.2M/ Hard;

            volumeTC007 = Math.Floor((AnionCapasitySelected() * fullVolume) / (AnionCapasitySelected() + cationCapasityL));
            volumeA202 = fullVolume - volumeTC007;

            
            if (volumeA202>0.7M* fullVolume)
            {
                volumeA202 = Math.Floor(0.7M * fullVolume);
                volumeTC007 = fullVolume- volumeA202;
            }
            else if(volumeTC007 > 0.7M * fullVolume)
            {
                volumeTC007 = Math.Floor(0.7M * fullVolume);
                volumeA202 = fullVolume - volumeTC007;
            }

            anionCapasityFull = 0.93M*(AnionCapasitySelected() * volumeA202)/((NO3/62)- (bypass/62));
            cationCapasityFull = cationCapasityL * volumeTC007;

            filtroCycle =Math.Min(cationCapasityFull, anionCapasityFull);
            textBox2.Text = volumeA202.ToString();
            textBox1.Text = volumeTC007.ToString();
            textBox5.Text = filtroCycle.ToString("0.00");
            saltTextBox.Text = ((salt * volumeA202) + (0.12M * volumeTC007)).ToString("0.0");
            
        }

        private decimal AnionCapasity125()
        {


            if (devideNO3SO4 > 0.8M && devideNO3SO4 <= 1.0M)
            {
                return (0.6M * devideNO3SO4 + 0.2M);
            }
            else if (devideNO3SO4 > 0.6M && devideNO3SO4 <= 0.8M)
            {
                return (0.5M * devideNO3SO4 + 0.1M);
            }
            else if (devideNO3SO4 > 0.4M && devideNO3SO4 <= 0.6M)
            {
                return (0.35M * devideNO3SO4 + 0.19M);
            }

            else if (devideNO3SO4 > 0.3M && devideNO3SO4 <= 0.4M)
            {
                return (0.3M * devideNO3SO4 + 0.22M);
            }

            else if (devideNO3SO4 > 0.2M && devideNO3SO4 <= 0.3M)
            {
                return (0.2M * devideNO3SO4 + 0.25M);
            }

            else if (devideNO3SO4 > 0.1M && devideNO3SO4 <= 0.2M)
            {
                return (0.3M * devideNO3SO4 + 0.23M);
            }

            else if (devideNO3SO4 > 0M && devideNO3SO4 <= 0.1M)
            {
                return (0.2M * devideNO3SO4 + 0.24M);
            }


            else
            {
                return 0;
            }


        }


        //определяем по графику рабочую емкость по нитратам для 250г NaCl на л:

        private decimal AnionCapasity250()
        {


            if (devideNO3SO4 > 0.8M && devideNO3SO4 <= 1.0M)
            {
                return (0.5M * devideNO3SO4 + 0.16M);
            }
            else if (devideNO3SO4 > 0.6M && devideNO3SO4 <= 0.8M)
            {
                return (0.3M * devideNO3SO4 + 0.32M);
            }
            else if (devideNO3SO4 > 0.4M && devideNO3SO4 <= 0.6M)
            {
                return (0.25M * devideNO3SO4 + 0.35M);
            }

            else if (devideNO3SO4 > 0.1M && devideNO3SO4 <= 0.4M)
            {
                return (0.1M * devideNO3SO4 + 0.4M);
            }

            else if (devideNO3SO4 > 0M && devideNO3SO4 <= 0.1M)
            {
                return (0.05M * devideNO3SO4 + 0.415M);
            }



            else
            {
                return 0;
            }

        }



        private void Form1_Load(object sender, EventArgs e)
        {


            Dictionary<string, string> mapTwo = new Dictionary<string, string>();

            mapTwo.Add("8x44 или кабинет", "6");
            mapTwo.Add("10х44", "10");
            mapTwo.Add("10х54", "10");
            mapTwo.Add("12х52", "15");
            mapTwo.Add("13х54", "15");
            mapTwo.Add("14х65", "20");
            mapTwo.Add("16х65", "30");
            mapTwo.Add("18х65", "40");
            mapTwo.Add("21х62", "60");
            mapTwo.Add("24х72", "80");
            mapTwo.Add("30х72", "120");
            mapTwo.Add("36х72", "132");
            mapTwo.Add("42х72", "280");
            mapTwo.Add("48х72", "360");
            mapTwo.Add("63х67", "600");
            // эта магия позволяет использовать коллекцию ключ- значение в связке с выпадающим списком  :
            columnComboBox.DataSource = new BindingSource(mapTwo, null);
            columnComboBox.DisplayMember = "Key";
        }
        //определяем по графику рабочую емкость по нитратам для 125г NaCl на л:

       




        private void CalcNO3Button_Click(object sender, EventArgs e)
        {

            if ( (NO3TextBox.Text != "") &&  (SO4TextBox.Text != "") && (hardnessTextBox.Text != "") && (NO3TextBox.Text != "0") && (SO4TextBox.Text != "0") && (hardnessTextBox.Text != "0"))

            {
                CommonСalc();
                Capacity();
                //MessageBox.Show("емость по жесткости: " + cationCapasityFull + "емость по нитратам: " + anionCapasityFull);
            }

            else

            {
                
                MessageBox.Show("Нужно заполнить все исходные данные, значения не должны быть нулями");
            }

            
            
        }

        private void ColumnComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = ((KeyValuePair<string, string>)columnComboBox.SelectedItem).Value;// значение значения словаря кладем в value
            textBox4.Text = value;
            typeColumn = ((KeyValuePair<string, string>)columnComboBox.SelectedItem).Key;// значение ключа словаря кладем в typeColumn
            //MessageBox.Show(typeColumn);
           
        }
        private void Point(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar) && !(e.KeyChar == 44))
            {
                e.Handled = true;
            }
        }
                
    }
}
