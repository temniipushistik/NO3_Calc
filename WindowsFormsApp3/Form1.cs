using System;
using System.Collections.Generic;
using System.Windows.Forms;





namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {

        
        string typeColumn;
        decimal sColumn;
        decimal fullVolume;//полный объем смолы
        private decimal k = 0.785M;


        public Form1()
        {
            InitializeComponent();
            //V250.Checked = true;
        }

        public decimal Hard()
        {
            return decimal.Parse(hardnessTextBox.Text);
        }


        private decimal NO3()
        {
            return decimal.Parse(NO3TextBox.Text);
        }

        private decimal SO4()
        {
            return decimal.Parse(SO4TextBox.Text);
        }


        Calculator Calculator = new Calculator();
        //private decimal SumAnion()
        //{
        //    return NO3() + SO4();
        //}

        //соотношение нитратов к сумме нитратов и сульфатов по эквиваленту:

        //private decimal DevideNO3SO4()
        //{
        //    return (NO3() / 62) / (NO3() / 62 + SO4() / 48);

        //}


        //private decimal Bypass125()
        //{

        //    //определяем по графику проскок по нитратам для 125г NaCl на л:

           
        //    if (DevideNO3SO4() > 0.8M && DevideNO3SO4() <= 1.0M)
        //    {
        //        return (-5M * DevideNO3SO4() + 17M) * NO3() * 0.01M;
        //    }
            
        //    else if (DevideNO3SO4() > 0.6M && DevideNO3SO4() <= 0.8M)
        //    {
        //        return (-22.5M * DevideNO3SO4() + 31M) * NO3() * 0.01M;
        //    }

            
        //    else if (DevideNO3SO4() > 0.5M && DevideNO3SO4() <= 0.6M)
        //    {
        //        return (-35M * DevideNO3SO4() + 38.5M) * NO3() * 0.01M;
        //    }

            
        //    else if (DevideNO3SO4() > 0.4M && DevideNO3SO4() <= 0.5M)
        //    {
        //        return (-39M * DevideNO3SO4() + 40M) * NO3() * 0.01M;
        //    }

            
            
        //    else if (DevideNO3SO4() > 0.3M && DevideNO3SO4() <= 0.4M)
        //    {
        //        return (-47M * DevideNO3SO4() + 43.6M) * NO3() * 0.01M;
        //    }

            
        //    else if (DevideNO3SO4() > 0.2M && DevideNO3SO4() <= 0.3M)
        //    {
        //        return (-65M * DevideNO3SO4() + 49M) * NO3() * 0.01M;
        //    }

            
        //    else if (DevideNO3SO4() > 0M && DevideNO3SO4() <= 0.2M)
        //    {
        //        return (-100M * DevideNO3SO4() + 56M) * NO3() * 0.01M;
        //    }
        //    else
        //    {
        //        return NO3();
        //    }
        //}

        //определяем по графику проскок по нитратам для 250г NaCl на л:

        //private decimal bypass250()
        //     {
                 
        //         if (DevideNO3SO4() > 0.8M && DevideNO3SO4() <= 1.0M)
        //          {
        //             return (-2.5M * DevideNO3SO4() + 11.5M) * NO3() * 0.01M;
        //          }
        //          else if (DevideNO3SO4() > 0.6M && DevideNO3SO4() <= 0.8M)
        //          {
        //             return (-7.5M * DevideNO3SO4() + 15.5M) * NO3() * 0.01M;
        //          }
        //          else if (DevideNO3SO4() > 0.4M && DevideNO3SO4() <= 0.6M)
        //          {
        //             return (-25M * DevideNO3SO4() + 26M) * NO3() * 0.01M;
        //          }
        //          else if (DevideNO3SO4() > 0.2M && DevideNO3SO4() <= 0.4M)
        //          {
        //             return (-45M * DevideNO3SO4() + 34M) * NO3() * 0.01M;
        //          }
        //          else if (DevideNO3SO4() > 0M && DevideNO3SO4() <= 0.2M)
        //          {
        //             return (-75M * DevideNO3SO4() + 40M) * NO3() * 0.01M;
        //          }
        //          else
        //          {
        //             return NO3();
        //          }
                  
        //     }


             //private decimal AnionCapasitySelected()
        
             //     //работаем с выбором 125 или 250
             // {
             //     if (V125.Checked)
             //     {
             //         textBoxNO3Bypass.Text = Calculator.().ToString("0.0");
             //         bypass = bypass125();
             //         salt = 0.125M;
             //         return (AnionCapasity125()*0.9M)/((NO3() - bypass) / 62);
                      
             //     }
             //     else if (V250.Checked)
             //     {
             //         textBoxNO3Bypass.Text = bypass250().ToString("0.0");
             //         bypass = bypass250();
             //         salt = 0.250M;
             //         return (AnionCapasity250() * 0.9M)/ ((NO3() - bypass) / 62);
             //     }
             //     else
             //     {
             //         MessageBox.Show("Выберите количество соли для регенерации: 125г или 250г");
             //     }
             //     return 0;
             // }

      

        //определяем по графику рабочую емкость по нитратам для 125г NaCl на л:
        //private decimal AnionCapasity125()
        //        {

        //             if (DevideNO3SO4() > 0.8M && DevideNO3SO4() <= 1.0M)
        //          {
        //              return (0.6M * DevideNO3SO4() + 0.01M) ;
        //          }
        //          else if (DevideNO3SO4() > 0.6M && DevideNO3SO4() <= 0.8M)
        //          {
        //              return (0.5M * DevideNO3SO4() + 0.1M) ;
        //          }
        //          else if (DevideNO3SO4() > 0.4M && DevideNO3SO4() <= 0.6M)
        //          {
        //              return (0.3M * DevideNO3SO4() + 0.23M);
        //          }
                                      
                   
        //          else if (DevideNO3SO4() > 0.2M && DevideNO3SO4() <= 0.4M)
        //          {
        //              return (0.2M * DevideNO3SO4() + 0.26M);
        //          }
        
        //          else if (DevideNO3SO4() > 0.1M && DevideNO3SO4() <= 0.2M)
        //          {
        //              return (0.1M * DevideNO3SO4() + 0.28M);
        //          }
        
        //          else if (DevideNO3SO4() > 0M && DevideNO3SO4() <= 0.1M)
        //          {
        //              return 0.29M;
        //          }
        
        
        //          else
        //          {
        //              return 0;
        //          }


        //      }


             //определяем по графику рабочую емкость по нитратам для 250г NaCl на л:
        
        //private decimal AnionCapasity250()
        //      {
        
        
        //          if (DevideNO3SO4() > 0.8M && DevideNO3SO4() <= 1.0M)
        //          {
        //            return (0.65M * DevideNO3SO4() + 0.03M) ;
        //          }
        //          else if (DevideNO3SO4() > 0.6M && DevideNO3SO4() <= 0.8M)
        //          {
        //              return (0.3M * DevideNO3SO4() + 0.32M) ;
        //          }
        //          else if (DevideNO3SO4() > 0.4M && DevideNO3SO4() <= 0.6M)
        //          {
        //              return (0.25M * DevideNO3SO4() + 0.35M);
        //          }
        
        //          else if (DevideNO3SO4() > 0.1M && DevideNO3SO4() <= 0.4M)
        //          {
        //              return (0.1M * DevideNO3SO4() + 0.4M);
        //          }
        
        //          else if (DevideNO3SO4() > 0M && DevideNO3SO4() <= 0.1M)
        //          {
        //              return (0.05M * DevideNO3SO4() + 0.415M);
        //          }
        
        
        
        //          else
        //          {
        //              return 0;
        //          }
        
        //      }



       


        
            // string devideNO3SO4Text = Convert.ToString(DevideNO3SO4());
            //  workCapacityText = Convert.ToString(AnionCapasitySelected());


            //считаем линейную скорость по катионам и анионам:

            //анионы
            


            
            //Выбираем минимальную производительность по меньшему 
            





        //подбор объема смолы и производительности
        
        public void SColumnMethod()
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

        //считаем емкость смол:

        //public void Capacity()
        //{
        //    // volumeA202 = Math.Floor(0.25M * fullVolume);
        //    // volumeTC007 = fullVolume - volumeA202;


        //    decimal volumeTC007 = Math.Floor((AnionCapasitySelected() * fullVolume) / (AnionCapasitySelected() + CationCapasityL()));//объем смолы 007
        //    decimal volumeA202 = fullVolume -volumeTC007; ;//объем смолы 202

        //    // MessageBox.Show($"катионит {volumeTC007} , анионит {volumeA202}", "Объемы смол");

        //    //В составе смеси смол не может быть меньше, чем 30% одной из составляющих:

        //    if (volumeA202 > 0.7M * fullVolume)
        //    {
        //        volumeA202 = Math.Floor(0.7M * fullVolume);
        //        volumeTC007 = fullVolume - volumeA202;
        //    }
        //    else if (volumeTC007 > 0.7M * fullVolume)
        //    {
        //        volumeTC007 = Math.Floor(0.7M * fullVolume);
        //        volumeA202 = fullVolume - volumeTC007;
        //    }

        //    decimal anionCapasityFull = AnionCapasitySelected() * volumeA202; //емкость всего объема анионита
        //    decimal cationCapasityFull = CationCapasityL() * volumeTC007; //емкость всего объема катионита

        //    a202ResinL.Text = AnionCapasitySelected().ToString("0.00");
        //    tC007ResinL.Text = CationCapasityL().ToString("0.00");

        //    decimal filtroCycle = Math.Min(cationCapasityFull, anionCapasityFull);
        //    textBox2.Text = volumeA202.ToString();
        //    textBox1.Text = volumeTC007.ToString();
        //    textBox5.Text = filtroCycle.ToString("0.0");
        //    saltTextBox.Text = ((salt * volumeA202) + (0.12M * volumeTC007)).ToString("0.0");

        //    //MessageBox.Show($" 250: {AnionCapasity250().ToString()} 125 : {AnionCapasity125()}" , "Емкость одного литра анионита,м3");



        //    /*MessageBox.Show(" объем анионита "+ volumeA202.ToString() + " емкость по аниониту: "+anionCapasityFull.ToString("0.0") +"\n" +" объем катионита " + volumeTC007.ToString() + " емкость по катиониту: " + cationCapasityFull.ToString("0.0") + "\n" + " фильтроцикл: " + filtroCycle.ToString("0.0"));

        //      } */


        //}


        public void TestZero(decimal a)
        {
            if ( a == 0)
            {
                MessageBox.Show("Значение {0} - нулевое", a.ToString());
            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            V250.Checked = true;
            //Коллекция типа словарь для типоразмеров колонн, привязанная к кварцу
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

        private void Point(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar) && !(e.KeyChar == 44))
            {
                e.Handled = true;
            }
        }

        private void ColumnComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = ((KeyValuePair<string, string>)columnComboBox.SelectedItem).Value;// значение значения словаря кладем в value
            textBox4.Text = value;
            typeColumn = ((KeyValuePair<string, string>)columnComboBox.SelectedItem).Key;// значение ключа словаря кладем в typeColumn
            //MessageBox.Show(typeColumn);
        }


        private void CalcNO3Button_Click(object sender, EventArgs e)
        {

            if ((NO3TextBox.Text != "") && (SO4TextBox.Text != "") && (hardnessTextBox.Text != ""))

            {
                
                Calculator.SetData(NO3(), SO4(), Hard(), V250.Checked, fullVolume);
                SColumnMethod();

                //Calculator.CationCapasityL();
                tC007ResinL.Text = Calculator.CationCapasityL().ToString("0.00");
                Calculator.SumAnion();

                Calculator.VAnion();

                Calculator.VCation();

                Calculator.VReal();

                Calculator.DevideNO3SO4();

                Calculator.Bypass125();
                Calculator.Bypass250();
                Calculator.AnionCapasity125();
                Calculator.AnionCapasity250();

                //Calculator.AnionCapasitySelected();
                a202ResinL.Text = Calculator.AnionCapasitySelected().ToString("0.00");
               
                textBox5.Text = Calculator.Capacity().ToString("0.0");

                //Calculator.Capacity();
                       

                averageFlowTextBox.Text = (Calculator.VReal() * sColumn).ToString("0.00");//добавляем в форму производительность для выбранной колонны

                saltTextBox.Text = Calculator.GetSumSalt().ToString("0.0");//добавляем в форму количество соли для регенерации 

                textBoxNO3Bypass.Text = Calculator.GetBypass().ToString("0.0");//добавляем в форму подмес нитратов на выходе

                textBox2.Text= Calculator.GetVolumeA202().ToString("0");
                textBox1.Text = Calculator.GetVolumeTC007().ToString("0");
                
               



                //MessageBox.Show($"соотношение {DevideNO3SO4()}");
            }

            else

            {

                MessageBox.Show("Нужно заполнить все исходные данные");
            }



        }

        
       
        //Проверить работу кнопки выбора 125 - 250 есть опасения, что она не переключает
    }
}