using System.Collections;
using System.Collections.Generic;

namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NO3Label = new System.Windows.Forms.Label();
            this.SO4Label = new System.Windows.Forms.Label();
            this.hardnessLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.columnComboBox = new System.Windows.Forms.ComboBox();
            this.hardnessTextBox = new System.Windows.Forms.TextBox();
            this.SO4TextBox = new System.Windows.Forms.TextBox();
            this.NO3TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelName2 = new System.Windows.Forms.Label();
            this.labelName1 = new System.Windows.Forms.Label();
            this.changeColumnLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.saltTextBox = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.averageFlowTextBox = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bypassLabel = new System.Windows.Forms.Label();
            this.TC007Label = new System.Windows.Forms.Label();
            this.PA202Label = new System.Windows.Forms.Label();
            this.calcNO3Button = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.V125 = new System.Windows.Forms.RadioButton();
            this.V250 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // NO3Label
            // 
            this.NO3Label.AutoSize = true;
            this.NO3Label.Location = new System.Drawing.Point(19, 38);
            this.NO3Label.Name = "NO3Label";
            this.NO3Label.Size = new System.Drawing.Size(109, 17);
            this.NO3Label.TabIndex = 0;
            this.NO3Label.Text = "Нитраты (NO3)";
            // 
            // SO4Label
            // 
            this.SO4Label.AutoSize = true;
            this.SO4Label.Location = new System.Drawing.Point(19, 70);
            this.SO4Label.Name = "SO4Label";
            this.SO4Label.Size = new System.Drawing.Size(117, 17);
            this.SO4Label.TabIndex = 0;
            this.SO4Label.Text = "Сульфаты (SO4)";
            // 
            // hardnessLabel
            // 
            this.hardnessLabel.AutoSize = true;
            this.hardnessLabel.Location = new System.Drawing.Point(19, 100);
            this.hardnessLabel.Name = "hardnessLabel";
            this.hardnessLabel.Size = new System.Drawing.Size(79, 17);
            this.hardnessLabel.TabIndex = 0;
            this.hardnessLabel.Text = "Жесткость";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.columnComboBox);
            this.groupBox1.Controls.Add(this.hardnessTextBox);
            this.groupBox1.Controls.Add(this.SO4TextBox);
            this.groupBox1.Controls.Add(this.NO3TextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelName2);
            this.groupBox1.Controls.Add(this.labelName1);
            this.groupBox1.Controls.Add(this.NO3Label);
            this.groupBox1.Controls.Add(this.changeColumnLabel);
            this.groupBox1.Controls.Add(this.hardnessLabel);
            this.groupBox1.Controls.Add(this.SO4Label);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 172);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Исходные параметры";
            // 
            // columnComboBox
            // 
            this.columnComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.columnComboBox.FormattingEnabled = true;
            this.columnComboBox.Location = new System.Drawing.Point(181, 127);
            this.columnComboBox.Name = "columnComboBox";
            this.columnComboBox.Size = new System.Drawing.Size(166, 24);
            this.columnComboBox.TabIndex = 2;
            this.columnComboBox.SelectedIndexChanged += new System.EventHandler(this.ColumnComboBox_SelectedIndexChanged);
            // 
            // hardnessTextBox
            // 
            this.hardnessTextBox.Location = new System.Drawing.Point(181, 95);
            this.hardnessTextBox.Name = "hardnessTextBox";
            this.hardnessTextBox.Size = new System.Drawing.Size(100, 22);
            this.hardnessTextBox.TabIndex = 1;
            this.hardnessTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Point);
            // 
            // SO4TextBox
            // 
            this.SO4TextBox.Location = new System.Drawing.Point(181, 65);
            this.SO4TextBox.Name = "SO4TextBox";
            this.SO4TextBox.Size = new System.Drawing.Size(100, 22);
            this.SO4TextBox.TabIndex = 1;
            this.SO4TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Point);
            // 
            // NO3TextBox
            // 
            this.NO3TextBox.Location = new System.Drawing.Point(181, 33);
            this.NO3TextBox.Name = "NO3TextBox";
            this.NO3TextBox.Size = new System.Drawing.Size(100, 22);
            this.NO3TextBox.TabIndex = 1;
            this.NO3TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Point);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "мг-экв/л";
            // 
            // labelName2
            // 
            this.labelName2.AutoSize = true;
            this.labelName2.Location = new System.Drawing.Point(287, 65);
            this.labelName2.Name = "labelName2";
            this.labelName2.Size = new System.Drawing.Size(34, 17);
            this.labelName2.TabIndex = 0;
            this.labelName2.Text = "мг/л";
            // 
            // labelName1
            // 
            this.labelName1.AutoSize = true;
            this.labelName1.Location = new System.Drawing.Point(287, 36);
            this.labelName1.Name = "labelName1";
            this.labelName1.Size = new System.Drawing.Size(34, 17);
            this.labelName1.TabIndex = 0;
            this.labelName1.Text = "мг/л";
            // 
            // changeColumnLabel
            // 
            this.changeColumnLabel.AutoSize = true;
            this.changeColumnLabel.Location = new System.Drawing.Point(19, 130);
            this.changeColumnLabel.Name = "changeColumnLabel";
            this.changeColumnLabel.Size = new System.Drawing.Size(137, 17);
            this.changeColumnLabel.TabIndex = 0;
            this.changeColumnLabel.Text = "Желаемая колонна";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.saltTextBox);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.averageFlowTextBox);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.bypassLabel);
            this.groupBox2.Controls.Add(this.TC007Label);
            this.groupBox2.Controls.Add(this.PA202Label);
            this.groupBox2.Location = new System.Drawing.Point(373, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(317, 303);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Расчетные параметры";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(253, 256);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 17);
            this.label12.TabIndex = 5;
            this.label12.Text = "кг";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 253);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(150, 34);
            this.label11.TabIndex = 4;
            this.label11.Text = "Количество соли\r\nна одну регенерацию";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 34);
            this.label8.TabIndex = 3;
            this.label8.Text = "Ресурс\r\n до регенерации";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Производительность";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Вес кварца";
            // 
            // saltTextBox
            // 
            this.saltTextBox.Location = new System.Drawing.Point(175, 256);
            this.saltTextBox.Name = "saltTextBox";
            this.saltTextBox.ReadOnly = true;
            this.saltTextBox.Size = new System.Drawing.Size(61, 22);
            this.saltTextBox.TabIndex = 1;
            this.saltTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(175, 208);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(61, 22);
            this.textBox5.TabIndex = 1;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // averageFlowTextBox
            // 
            this.averageFlowTextBox.Location = new System.Drawing.Point(175, 164);
            this.averageFlowTextBox.Name = "averageFlowTextBox";
            this.averageFlowTextBox.ReadOnly = true;
            this.averageFlowTextBox.Size = new System.Drawing.Size(61, 22);
            this.averageFlowTextBox.TabIndex = 1;
            this.averageFlowTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(175, 131);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(61, 22);
            this.textBox4.TabIndex = 1;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(175, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(61, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(175, 67);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(61, 22);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(175, 35);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(61, 22);
            this.textBox3.TabIndex = 1;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(252, 211);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "м3";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(252, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "м3/час";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(253, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "кг";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "л";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "л";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "мг/л";
            // 
            // bypassLabel
            // 
            this.bypassLabel.AutoSize = true;
            this.bypassLabel.Location = new System.Drawing.Point(19, 38);
            this.bypassLabel.Name = "bypassLabel";
            this.bypassLabel.Size = new System.Drawing.Size(150, 17);
            this.bypassLabel.TabIndex = 0;
            this.bypassLabel.Text = "Проскок по нитратам";
            // 
            // TC007Label
            // 
            this.TC007Label.AutoSize = true;
            this.TC007Label.Location = new System.Drawing.Point(19, 100);
            this.TC007Label.Name = "TC007Label";
            this.TC007Label.Size = new System.Drawing.Size(99, 17);
            this.TC007Label.TabIndex = 0;
            this.TC007Label.Text = "Объем TC007";
            // 
            // PA202Label
            // 
            this.PA202Label.AutoSize = true;
            this.PA202Label.Location = new System.Drawing.Point(19, 70);
            this.PA202Label.Name = "PA202Label";
            this.PA202Label.Size = new System.Drawing.Size(99, 17);
            this.PA202Label.TabIndex = 0;
            this.PA202Label.Text = "Объем РА202";
            // 
            // calcNO3Button
            // 
            this.calcNO3Button.Location = new System.Drawing.Point(13, 333);
            this.calcNO3Button.Name = "calcNO3Button";
            this.calcNO3Button.Size = new System.Drawing.Size(677, 52);
            this.calcNO3Button.TabIndex = 3;
            this.calcNO3Button.Text = "Рассчитать";
            this.calcNO3Button.UseVisualStyleBackColor = true;
            this.calcNO3Button.Click += new System.EventHandler(this.CalcNO3Button_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 400);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(222, 17);
            this.label13.TabIndex = 4;
            this.label13.Text = "Разработал: Кошелев Геннадий";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(24, 267);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 17);
            this.label14.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.V250);
            this.groupBox3.Controls.Add(this.V125);
            this.groupBox3.Location = new System.Drawing.Point(13, 191);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(354, 124);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Расход NaCl на литр А202 при прямоточной регенерации";
            // 
            // V125
            // 
            this.V125.AutoSize = true;
            this.V125.Location = new System.Drawing.Point(21, 47);
            this.V125.Name = "V125";
            this.V125.Size = new System.Drawing.Size(74, 21);
            this.V125.TabIndex = 0;
            this.V125.TabStop = true;
            this.V125.Text = "125 г/л";
            this.V125.UseVisualStyleBackColor = true;
            // 
            // V250
            // 
            this.V250.AutoSize = true;
            this.V250.Location = new System.Drawing.Point(21, 77);
            this.V250.Name = "V250";
            this.V250.Size = new System.Drawing.Size(74, 21);
            this.V250.TabIndex = 1;
            this.V250.TabStop = true;
            this.V250.Text = "250 г/л";
            this.V250.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 432);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.calcNO3Button);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Подбор смеси смол V2.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NO3Label;
        private System.Windows.Forms.Label SO4Label;
        private System.Windows.Forms.Label hardnessLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox columnComboBox;
        private System.Windows.Forms.TextBox hardnessTextBox;
        private System.Windows.Forms.TextBox SO4TextBox;
        private System.Windows.Forms.TextBox NO3TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelName2;
        private System.Windows.Forms.Label labelName1;
        private System.Windows.Forms.Label changeColumnLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label bypassLabel;
        private System.Windows.Forms.Label TC007Label;
        private System.Windows.Forms.Label PA202Label;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button calcNO3Button;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox saltTextBox;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox averageFlowTextBox;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton V250;
        private System.Windows.Forms.RadioButton V125;
    }
}

