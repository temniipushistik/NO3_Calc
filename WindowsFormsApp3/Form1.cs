﻿using System;
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
        Dictionary<string, string> mapTwo;
        Calculator calculatorObject;
        decimal Hard;
        decimal NO3;
        decimal SO4;
        decimal devideNO3SO4;
        decimal bypassNO3;//проскок нитратов
        decimal volumeA202;//объем смолы 202
        decimal volumeTC007;//объем смолы 007
        decimal averageFlow;//производительность системы
        decimal filtroCycle;
        decimal anionCapasityL;//емкость одного литра анионита
        decimal cationCapasityL;//емкость одного литра катионита
        decimal anionCapasityFull;//емкость всего объема анионита
        decimal cationCapasityFull;//емкость всего объема катионита
        decimal sumAnion;
        int VAnion;
        int VCation;
        string devideNO3SO4Text;
        string workCapacityText;
        string bypassNO3Text;
        string typeColumn;
        decimal sColumn;
        decimal fullVolume;//полный объем смолы
        decimal k = 0.785M;
        



        public Form1()
        {
            InitializeComponent();
        }

        private void CommonСalc()
        {
            NO3 = decimal.Parse(NO3TextBox.Text);
            SO4 = decimal.Parse(SO4TextBox.Text);
            devideNO3SO4 = (NO3 / 62) / (NO3 / 62 + SO4 / 48);
            Hard = decimal.Parse(hardnessTextBox.Text);


            //прямоточная 250мг/л:
            anionCapasityL = 0.28M * devideNO3SO4 * devideNO3SO4 + 0.4M;//определяем по графику ресурс смолы.
                                                                      //надо подумать над ограничением графика
            devideNO3SO4Text = Convert.ToString(devideNO3SO4);
            workCapacityText = Convert.ToString(anionCapasityL);
            //определяем по графику проскок по нитратам:
            if (devideNO3SO4 > 0.8M && devideNO3SO4 <= 1.0M)
            {
                bypassNO3 = (-2.5M * devideNO3SO4 + 11.5M) * NO3 * 0.01M;
            }
            else if (devideNO3SO4 > 0.6M && devideNO3SO4 <= 0.8M)
            {
                bypassNO3 = (-7.5M * devideNO3SO4 + 15.5M) * NO3 * 0.01M;
            }
            else if (devideNO3SO4 > 0.4M && devideNO3SO4 <= 0.6M)
            {
                bypassNO3 = (-25M * devideNO3SO4 + 26M) * NO3 * 0.01M;
            }
            else if (devideNO3SO4 > 0.2M && devideNO3SO4 <= 0.4M)
            {
                bypassNO3 = (-45M * devideNO3SO4 + 34M) * NO3 * 0.01M;
            }
            else if (devideNO3SO4 > 0M && devideNO3SO4 <= 0.2M)
            {
                bypassNO3 = (-75M * devideNO3SO4 + 40M) * NO3 * 0.01M;
            }
            else
            {
                bypassNO3 = NO3;
            }

            bypassNO3Text = bypassNO3.ToString("0.0");

            textBox3.Text = bypassNO3Text;

            //считаем линейную скорость по катионам и анионам:
            //анионы
            sumAnion = NO3 + SO4;
            Hard = decimal.Parse(hardnessTextBox.Text);

            int range = (int)((sumAnion) / 50M);// автоприведение типа в инт
            switch (range)
            {
               case 0:
                    VAnion = 25;
                    break;
                case 1:
                    VAnion = 20;
                    break;
                case 2:
                    VAnion = 15;
                    break;
                case 3:
                    VAnion = 12;
                    break;
                default:
                    VAnion = 10;
                    break;

            }
            // выделяем целую часть через инт и используем ее в качесте проверки. Если 0 получается, то первое условие и т.д. 

            range = (Hard <= 5) ? 0 : ((Hard <= 10) ? 1 : ((Hard <= 14) ? 2 : ((Hard <= 18) ? 3 : 4)));

            switch (range)
            {
                case 0:
                    VCation = 25;
                    break;
                case 1:
                    VCation = 20;
                    break;
                case 2:
                    VCation = 15;
                    break;
                case 3:
                    VCation = 12;
                    break;
                default:
                    VCation = 10;
                    break;
            }

            
            //Выбираем меньшее:

            decimal VReal = Math.Min(VCation, VAnion);

            SColumnClass();
            averageFlow = VReal * sColumn;
            averageFlowTextBox.Text = averageFlow.ToString("0.00");


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

            volumeTC007 = Math.Floor((anionCapasityL * fullVolume) / (anionCapasityL + cationCapasityL));
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

            anionCapasityFull = anionCapasityL * volumeA202;
            cationCapasityFull = cationCapasityL * volumeTC007;

            filtroCycle =Math.Min(cationCapasityFull, anionCapasityFull);
            textBox2.Text = volumeA202.ToString();
            textBox1.Text = volumeTC007.ToString();
            textBox5.Text = filtroCycle.ToString("0.0");
            saltTextBox.Text = ((0.25M * volumeA202) + (0.12M * volumeTC007)).ToString("0.0");



            /*MessageBox.Show(" объем анионита "+ volumeA202.ToString() + " емкость по аниониту: "+anionCapasityFull.ToString("0.0") +"\n" +" объем катионита " + volumeTC007.ToString() + " емкость по катиониту: " + cationCapasityFull.ToString("0.0") + "\n" + " фильтроцикл: " + filtroCycle.ToString("0.0"));
           
              while (anionCapasityFull * 0.9M > cationCapasityFull)
             {
                 volumeA202--;
                 volumeTC007++;
                 anionCapasityFull = anionCapasityL * volumeA202;
                 cationCapasityFull = cationCapasityL * volumeTC007;
                 MessageBox.Show(anionCapasityFull.ToString() + "    " + cationCapasityFull.ToString());
             }

            while (anionCapasityFull*0.9M > cationCapasityFull || anionCapasityFull * 1.1M < cationCapasityFull )
             {
                 volumeA202++;
                 volumeTC007--;
                 anionCapasityFull = anionCapasityL * volumeA202;
                 cationCapasityFull = cationCapasityL * volumeTC007;

             } */


        }



        private void Form1_Load(object sender, EventArgs e)
        {
            calculatorObject = new Calculator();
            fillColomnBox();

           
        }

        private void fillColomnBox()
        {
            mapTwo = new Dictionary<string, string>();
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
            foreach (KeyValuePair<string,string> entry in mapTwo)
            {
                columnComboBox.Items.Add(entry.Key);
            } //  добавляем значение ключа в комбобокс
        }


        private void CalcNO3Button_Click(object sender, EventArgs e)
        {



            if ( (NO3TextBox.Text != "") &&  (SO4TextBox.Text != "") && (hardnessTextBox.Text != "") && (hardnessTextBox.Text != "0") && (NO3TextBox.Text != "0") && (SO4TextBox.Text != "0"))
            {

                calculatorObject.fillDatas(NO3TextBox.Text, SO4TextBox.Text, hardnessTextBox.Text, mapTwo[columnComboBox.Text]);
                textBox3.Text = calculatorObject.calculateBypassNO3().ToString();
                textBox2.Text = calculatorObject.calculateVolumeA202().ToString();
                textBox1.Text = calculatorObject.calculateVolumeTC007().ToString();
                textBox5.Text = calculatorObject.calculateFiltroCycle().ToString("0.0");
                saltTextBox.Text = ((0.25M * calculatorObject.calculateVolumeA202()) + (0.12M * calculatorObject.calculateVolumeTC007())).ToString("0.0");

                decimal VReal = Math.Min(calculatorObject.getVCation(), calculatorObject.getVAnion());

                calculatorObject.SColumnClass(mapTwo[columnComboBox.Text]);

                averageFlow = VReal * calculatorObject.sColumn;
                averageFlowTextBox.Text = averageFlow.ToString("0.00");

             
                MessageBox.Show("ресурс жесткости "+ cationCapasityFull + "ресурс по нитратам "+ cationCapasityFull + "соотношение" + devideNO3SO4);
            }

            else

            {
                
                MessageBox.Show("Нужно заполнить все исходные данные. Значения не должны быть нулями");
            }

            
            
        }

        private void ColumnComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        //    string value = ((KeyValuePair<string, string>)columnComboBox.SelectedItem).Value;// значение значения словаря кладем в value
            textBox4.Text = mapTwo[columnComboBox.Text];
           // typeColumn = ((KeyValuePair<string, string>)columnComboBox.SelectedItem).Key;// значение ключа словаря кладем в typeColumn
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
