using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Words.NET;

namespace Practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox16.Checked)
            {
                checkBox1.Checked = true;
                checkBox2.Checked = true;
                //checkBox3.Checked = true;
                checkBox4.Checked = true;
                checkBox5.Checked = true;
                checkBox6.Checked = true;
                checkBox7.Checked = true;
                checkBox8.Checked = true;
                checkBox9.Checked = true;
                checkBox10.Checked = true;
                checkBox11.Checked = true;
                checkBox12.Checked = true;
                checkBox13.Checked = true;
                checkBox14.Checked = true;
                checkBox15.Checked = true;
                checkBox17.Checked = true;
                //checkBox18.Checked = true;
                checkBox19.Checked = true;
               
            }
            else
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
                checkBox7.Checked = false;
                checkBox8.Checked = false;
                checkBox9.Checked = false;
                checkBox10.Checked = false;
                checkBox11.Checked = false;
                checkBox12.Checked = false;
                checkBox13.Checked = false;
                checkBox14.Checked = false;
                checkBox15.Checked = false;
                checkBox17.Checked = false;
                checkBox18.Checked = false;
                checkBox19.Checked = false;
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Word Documents|*.docx";
            saveFileDialog.Title = "Save a Word Document";
            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                string filePath = saveFileDialog.FileName;
                string path1= Path.GetDirectoryName(filePath) ;
                string f=Path.GetFileName(filePath) ;
                var docAns = DocX.Create(path1+@"\"+f+"_answers.docx");
                using (var doc = DocX.Create(filePath))
                {
                    // Добавление текста в документ
                    if (checkBox1.Checked)
                    {
                        doc.InsertParagraph(Program.Variants.task1());
                        docAns.InsertParagraph("Задание 1\n а) "+Program.Variants.ans1A.ToString());
                        docAns.InsertParagraph("б) "+Program.Variants.ans1B.ToString()+"\n");

                    }
                    if (checkBox2.Checked)
                    {
                        doc.InsertParagraph(Program.Variants.task2());
                        docAns.InsertParagraph("Задание 2\n а) " + Program.Variants.ans2A.ToString());
                        docAns.InsertParagraph("б) " + Program.Variants.ans2B.ToString() + "\n");

                    }
                    if (checkBox3.Checked)
                    {
                        doc.InsertParagraph(Program.Variants.task3());
                    }
                    if (checkBox4.Checked)
                    {
                        doc.InsertParagraph(Program.Variants.task4());
                        docAns.InsertParagraph("Задание 4\n а) " + Program.Variants.ans4A.ToString());
                        docAns.InsertParagraph("б) " + Program.Variants.ans4B.ToString());
                        docAns.InsertParagraph("в) " + Program.Variants.ans4C.ToString() + "\n");
                    }
                    if (checkBox5.Checked)
                    {
                        doc.InsertParagraph(Program.Variants.task5());
                        docAns.InsertParagraph("Задание 5\n "+Program.Variants.ans5.ToString() + "\n");
                    }
                    if (checkBox6.Checked)
                    {
                        doc.InsertParagraph(Program.Variants.task6());
                        docAns.InsertParagraph("Задание 6\n " + Program.Variants.ans6.ToString() + "\n");
                    }
                    if (checkBox7.Checked)
                    {
                        doc.InsertParagraph(Program.Variants.task7());
                        docAns.InsertParagraph("Задание 7\n " + Program.Variants.ans7.ToString() + "\n");
                    }
                    if (checkBox8.Checked)
                    {
                        doc.InsertParagraph(Program.Variants.task8());
                        docAns.InsertParagraph("Задание 8\n " + Program.Variants.ans8.ToString() + "\n");
                    }
                    if (checkBox9.Checked)
                    {
                        doc.InsertParagraph(Program.Variants.task9());
                        docAns.InsertParagraph("Задание 9\n " + Program.Variants.ans9.ToString() + "\n");
                    }
                    if (checkBox10.Checked)
                    {
                        doc.InsertParagraph(Program.Variants.task10());
                        docAns.InsertParagraph("Задание 10\n а) " + Program.Variants.ans10A);
                        docAns.InsertParagraph("б) " + Program.Variants.ans10B + "\n");
                    }
                    if (checkBox11.Checked)
                    {
                        doc.InsertParagraph(Program.Variants.task11());
                        docAns.InsertParagraph("Задание 11\n " + Program.Variants.ans11 + "\n");
                    }
                    if (checkBox12.Checked)
                    {
                        doc.InsertParagraph(Program.Variants.task12());
                        docAns.InsertParagraph("Задание 12\n " + Program.Variants.ans12 + "\n");
                    }
                    if (checkBox13.Checked)
                    {
                        doc.InsertParagraph(Program.Variants.task13());
                        docAns.InsertParagraph("Задание 13\n " + Program.Variants.ans13 + "\n");
                    }
                    if (checkBox14.Checked)
                    {
                        doc.InsertParagraph(Program.Variants.task14());
                        docAns.InsertParagraph("Задание 14\n " + Program.Variants.ans14 + "\n");
                    }
                    if (checkBox15.Checked)
                    {
                        doc.InsertParagraph(Program.Variants.task15());
                        docAns.InsertParagraph("Задание 15\n а) " + Program.Variants.ans15A);
                        docAns.InsertParagraph("б) " + Program.Variants.ans15B);
                        docAns.InsertParagraph("в) " + Program.Variants.ans15C + "\n");
                    }
                    if (checkBox17.Checked)
                    {
                        doc.InsertParagraph(Program.Variants.task16());
                        docAns.InsertParagraph("Задание 16\n " + Program.Variants.ans16 + "\n");
                    }
                    if (checkBox18.Checked)
                    {
                        doc.InsertParagraph(Program.Variants.task17());
                    }
                    if (checkBox19.Checked)
                    {
                        doc.InsertParagraph(Program.Variants.task18());
                        docAns.InsertParagraph("Задание 18\n " + Program.Variants.ans18 + "\n");
                    }
                    

                    // Сохранение документа
                    doc.Save();
                    docAns.Save();
                }
            }
            
        }

        
    }
}
