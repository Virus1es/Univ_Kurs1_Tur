using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursavaya
{
 
    public partial class Form1 : Form
    {
        int stepsOne, stepsMany, len, maxTOne = 0, maxTMany = 0;


        public Form1()
        {
            InitializeComponent();
        }

        #region Одноленточная_МТ

        private void button1_Click(object sender, EventArgs e)
        {
            // получит слово
            string word = textBoxWord.Text;

            // очищаем текст предыдущего алгоритма
            richTextBoxForOne.Clear();

            // обработать слово по действиям(однолеточная МТ)
            OneLentExecute(word);

            // записать в файл итоговый алгоритм для слова
            File.WriteAllText("OutputOneLent.txt", richTextBoxForOne.Text);
        }


        // обработка слова однолеточной МТ
        private void OneLentExecute(string word)
        {
            // если переданно пустое слово то ставим 0
            if (String.IsNullOrEmpty(word))
            {
                List<char> list = new List<char>("_______".ToCharArray());
                q9(list, 3);
                return;
            }

            // для простаты обработки делаем список символов
            List<char> chars = new List<char>(word.ToCharArray());

            // переменная для прохода по слову
            int i = 1;

            // добавление пустого пространства в начале слова и в конце
            chars.Add('_');
            chars.Insert(0, '_');

            // запуск обработки слова(с первого действия)
            q1(chars, i);
        }

        #region Действия_для_однолеточной_МТ

        void q1(List<char> chars, int index)
        {
            string title = "q1: ";
            switch (chars[index])
            {
                case 'a':
                    ShowWord(chars, title);
                    q2(chars, index);
                    break;

                case 'b':
                case 'c':
                    chars[index] = '_';
                    ShowWord(chars, title);
                    q9(chars, ++index);
                    break;

                default:
                    chars[index] = '0';
                    ShowWord(chars, title);
                    break;
            }
        }

        void q2(List<char> chars, int index)
        {
            string title = "q2: ";
            switch (chars[index])
            {
                case 'a':
                    chars[index] = '_';
                    ShowWord(chars, title);
                    q5(chars, ++index);
                    break;

                case 'b':
                    ShowWord(chars, title);
                    q11(chars, index);
                    break;

                case 'c':
                    chars[index] = '_';
                    ShowWord(chars, title);
                    q9(chars, ++index);
                    break;

                case '#':
                    ShowWord(chars, title);
                    q9(chars, index);
                    break;

                default:
                    ShowWord(chars, title);
                    q2(chars, --index);
                    break;
            }
        }

        void q3(List<char> chars, int index)
        {
            string title = "q3: ";
            switch (chars[index])
            {
                case 'a':
                    ShowWord(chars, title);
                    q3(chars, ++index);
                    break;

                case 'b':
                    chars[index] = '_';
                    ShowWord(chars, title);
                    q4(chars, ++index);
                    break;

                case 'c':
                    ShowWord(chars, title);
                    q4(chars, index);
                    break;

                default:
                    ShowWord(chars, title);
                    q3(chars, ++index);
                    break;
            }
        }

        void q4(List<char> chars, int index)
        {
            string title = "q4: ";
            switch (chars[index])
            {
                case 'a':
                case 'b':
                    ShowWord(chars, title);
                    q7(chars, index);
                    break;

                case 'c':
                    chars[index] = '#';
                    ShowWord(chars, title);
                    q6(chars, index);
                    break;

                case '#':
                    chars[index] = '_';
                    ShowWord(chars, title);
                    q9(chars, ++index);
                    break;

                default:
                    ShowWord(chars, title);
                    q9(chars, ++index);
                    break;
            }
        }

        void q5(List<char> chars, int index)
        {
            string title = "q5: ";
            switch (chars[index])
            {
                case 'a':
                case 'b':
                case 'c':
                    ShowWord(chars, title);
                    q5(chars, ++index);
                    break;

                case '#':
                    ShowWord(chars, title);
                    q4(chars, --index);
                    break;

                default:
                    ShowWord(chars, title);
                    q4(chars, --index);
                    break;
            }
        }

        void q6(List<char> chars, int index)
        {
            string title = "q6: ";
            switch (chars[index])
            {
                case 'a':
                case 'b':
                case 'c':
                case '#':
                    ShowWord(chars, title);
                    q6(chars, --index);
                    break;

                default:
                    ShowWord(chars, title);
                    q2(chars, ++index);
                    break;
            }
        }

        void q7(List<char> chars, int index)
        {
            string title = "q7: ";
            switch (chars[index])
            {
                case 'a':
                case 'b':
                case 'c':
                case '#':
                    ShowWord(chars, title);
                    q7(chars, --index);
                    break;

                default:
                    ShowWord(chars, title);
                    q9(chars, ++index);
                    break;
            }
        }

        void q8(List<char> chars, int index)
        {
            string title = "q8: ";
            switch (chars[index])
            {
                case 'a':
                case 'b':
                case 'c':
                case '#':
                    chars[index] = '_';
                    ShowWord(chars, title);
                    q8(chars, ++index);
                    break;

                default:
                    chars[index] = '1';
                    ShowWord(chars, title);
                    break;
            }
        }

        void q9(List<char> chars, int index)
        {
            string title = "q9: ";
            switch (chars[index])
            {
                case 'a':
                case 'b':
                case 'c':
                case '#':
                    chars[index] = '_';
                    ShowWord(chars, title);
                    q9(chars, ++index);
                    break;

                default:
                    chars[index] = '0';
                    ShowWord(chars, title);
                    break;
            }
        }

        void q10(List<char> chars, int index)
        {
            string title = "q10: ";
            switch (chars[index])
            {
                case 'b':
                    ShowWord(chars, title);
                    q14(chars, index);
                    break;

                case '#':
                    ShowWord(chars, title);
                    q10(chars, --index);
                    break;

                default:
                    ShowWord(chars, title);
                    q8(chars, ++index);
                    break;
            }
        }

        void q11(List<char> chars, int index)
        {
            string title = "q11: ";
            switch (chars[index])
            {
                case 'a':
                    chars[index] = '_';
                    ShowWord(chars, title);
                    q9(chars, ++index);
                    break;

                case 'b':
                    chars[index] = '_';
                    ShowWord(chars, title);
                    q12(chars, ++index);
                    break;

                case '#':
                    ShowWord(chars, title);
                    q10(chars, --index);
                    break;

                default:
                    ShowWord(chars, title);
                    q8(chars, index);
                    break;
            }
        }

        void q12(List<char> chars, int index)
        {
            string title = "q12: ";
            switch (chars[index])
            {
                case 'a':
                    ShowWord(chars, title);
                    q9(chars, index);
                    break;

                case 'b':
                case '#':
                    ShowWord(chars, title);
                    q12(chars, ++index);
                    break;

                case 'c':
                    ShowWord(chars, title);
                    q7(chars, --index);
                    break;

                default:
                    ShowWord(chars, title);
                    q13(chars, --index);
                    break;
            }
        }

        void q13(List<char> chars, int index)
        {
            string title = "q13: ";
            switch (chars[index])
            {
                case 'b':
                    ShowWord(chars, title);
                    q8(chars, index);
                    break;

                case '#':
                    chars[index] = '_';
                    ShowWord(chars, title);
                    q15(chars, --index);
                    break;

                default:
                    ShowWord(chars, title);
                    q8(chars, ++index);
                    break;
            }
        }

        void q14(List<char> chars, int index)
        {
            string title = "q14: ";
            switch (chars[index])
            {
                case 'b':
                case '#':
                    ShowWord(chars, title);
                    q14(chars, --index);
                    break;

                default:
                    ShowWord(chars, title);
                    q11(chars, ++index);
                    break;
            }
        }

        void q15(List<char> chars, int index)
        {
            string title = "q15: ";
            switch (chars[index])
            {
                case 'b':
                    ShowWord(chars, title);
                    q14(chars, index);
                    break;

                case '#':
                    ShowWord(chars, title);
                    q10(chars, index);
                    break;

                default:
                    ShowWord(chars, title);
                    q7(chars, index);
                    break;
            }
        }

        #endregion


        #endregion


        #region Многоленточная_МТ

        private void buttonGoMany_Click(object sender, EventArgs e)
        {
            // получит слово
            string word = textBoxWord.Text;

            // очищаем текст предыдущего алгоритма
            richTextBoxMany.Clear();

            // обработать слово по действиям(многоленточная МТ)
            ManyLentExecute(word);

            // записать в файл итоговый алгоритм для слова
            File.WriteAllText("OutputManyLents.txt", richTextBoxMany.Text);
        }

        // оброботка слова на много ленточной МТ
        private void ManyLentExecute(string word)
        {
            if (String.IsNullOrEmpty(word))
            {
                richTextBoxMany.Text = "q0: ________\nq8: ____0____";
                return;
            }

            // список символов
            List<char> charsC = new List<char>(word.ToCharArray());

            // списки символов
            List<char> charsA = new List<char>();
            List<char> charsB = new List<char>();

            // если у слова неверное начало выходим
            if (charsC[0] != 'a')
            {
                richTextBoxMany.Text += "q0: ";
                richTextBoxMany.Text += " l1: ____0____";
                return;
            }

            // цикл распределения смволов по спискам(лентам)
            while (charsC[0] != 'c')
            {
                richTextBoxMany.Text += "\nq0: ";
                // получить удаляем элемент слова
                char c = charsC[0];

                // удалить элемент слова
                charsC.RemoveAt(0);

                // выбрать список для добавления
                // если нарушен порядок ввода, то завершаем функцию
                if (c == 'a' && charsB.Count == 0)
                    charsA.Add(c);
                else if (c == 'b')
                    charsB.Add(c);
                else
                {
                    richTextBoxMany.Text += "____0____";
                    return;
                }

                // вывод лент в консоль
                ShowWordMany(charsC, " l1: ");
                ShowWordMany(charsA, "     l2: ");
                ShowWordMany(charsB, "     l3: ");

                if (charsC.Count == 0) break;
            }


            // оброботка лент(слова)
            LentsExec(charsA, charsB, charsC);
        }

        private void LentsExec(List<char> charsA, List<char> charsB, List<char> charsC)
        {
            charsA.Insert(0, '_');
            charsC.Insert(0, '_');
            charsB.Insert(0, '_');

            charsA.AddRange("___________".ToCharArray());
            charsC.AddRange("___________".ToCharArray());
            charsB.AddRange("___________".ToCharArray());

            int index = 1;

            ManyQ1(charsA, charsB, charsC, index);
        }


        #region Действия_для_многоленточной_МТ

        private void ManyQ1(List<char> charsA, List<char> charsB, List<char> charsC, int index)
        {
            richTextBoxMany.Text += "\nq1: ";

            if (charsA[index] == 'a' && charsB[index] == 'b' && charsC[index] == 'c')
            {
                // вывод лент в консоль
                ShowWordMany(charsC, " l1: ");
                ShowWordMany(charsA, "     l2: ");
                ShowWordMany(charsB, "     l3: ");

                ManyQ2(charsA, charsB, charsC, index);
            }
            else
            {
                // вывод лент в консоль
                ShowWordMany(charsC, " l1: ");
                ShowWordMany(charsA, "     l2: ");
                ShowWordMany(charsB, "     l3: ");

                ManyQ7(charsA, charsB, charsC, index);
            }
        }

        private void ManyQ2(List<char> charsA, List<char> charsB, List<char> charsC, int index)
        {
            richTextBoxMany.Text += "\nq2: ";
            // charsA[index] == 'a' && charsC[index] == 'c' && (charsB[index] == 'b' || charsB[index] == '_') 
            // || charsA[index] == '_' && charsC[index] == '_' && charsB[index] == 'b'


            if (charsA[index] == 'a' && charsC[index] == 'c' && charsB[index] == 'b')
            {
                // вывод лент в консоль
                ShowWordMany(charsC, " l1: ");
                ShowWordMany(charsA, "     l2: ");
                ShowWordMany(charsB, "     l3: ");

                ManyQ2(charsA, charsB, charsC, ++index);
            }
            else if (charsA[index] == '_' && charsC[index] == '_' && charsB[index] == '_')
            {
                // вывод лент в консоль
                ShowWordMany(charsC, " l1: ");
                ShowWordMany(charsA, "     l2: ");
                ShowWordMany(charsB, "     l3: ");

                ManyQ7(charsA, charsB, charsC, --index);
            }
            else
            {
                // вывод лент в консоль
                ShowWordMany(charsC, " l1: ");
                ShowWordMany(charsA, "     l2: ");
                ShowWordMany(charsB, "     l3: ");

                ManyQ3(charsA, charsB, charsC, index);
            }
        }

        private void ManyQ3(List<char> charsA, List<char> charsB, List<char> charsC, int index)
        {
            richTextBoxMany.Text += "\nq3: ";
            // charsA[index] == 'a' && charsC[index] == 'c' && (charsB[index] == 'b' || charsB[index] == '_') 
            // || charsA[index] == '_' && charsC[index] == '_' && charsB[index] == 'b'


            if (charsA[index] == 'a' && charsC[index] == 'c' && charsB[index] == '_')
            {
                // вывод лент в консоль
                ShowWordMany(charsC, " l1: ");
                ShowWordMany(charsA, "     l2: ");
                ShowWordMany(charsB, "     l3: ");

                ManyQ3(charsA, charsB, charsC, ++index);
            }
            else if (charsA[index] == '_' && charsC[index] == '_' && charsB[index] == '_')
            {
                // вывод лент в консоль
                ShowWordMany(charsC, " l1: ");
                ShowWordMany(charsA, "     l2: ");
                ShowWordMany(charsB, "     l3: ");

                ManyQ6(charsA, charsB, charsC, --index);
            }
            else
            {
                // вывод лент в консоль
                ShowWordMany(charsC, " l1: ");
                ShowWordMany(charsA, "     l2: ");
                ShowWordMany(charsB, "     l3: ");

                ManyQ4(charsA, charsB, charsC, index);
            }
        }


        private void ManyQ4(List<char> charsA, List<char> charsB, List<char> charsC, int index)
        {
            richTextBoxMany.Text += "\nq4: ";
            // charsA[index] == 'a' && charsC[index] == 'c' && (charsB[index] == 'b' || charsB[index] == '_') 
            // || charsA[index] == '_' && charsC[index] == '_' && charsB[index] == 'b'


            if (charsA[index] == '_' && charsC[index] == '_' && charsB[index] == 'b')
            {
                // вывод лент в консоль
                ShowWordMany(charsC, " l1: ");
                ShowWordMany(charsA, "     l2: ");
                ShowWordMany(charsB, "     l3: ");

                ManyQ4(charsA, charsB, charsC, ++index);
            }
            else if (charsA[index] == '_' && charsC[index] == '_' && charsB[index] == '_')
            {
                // вывод лент в консоль
                ShowWordMany(charsC, " l1: ");
                ShowWordMany(charsA, "     l2: ");
                ShowWordMany(charsB, "     l3: ");

                ManyQ6(charsA, charsB, charsC, --index);
            }
            else
            {
                // вывод лент в консоль
                ShowWordMany(charsC, " l1: ");
                ShowWordMany(charsA, "     l2: ");
                ShowWordMany(charsB, "     l3: ");

                ManyQ7(charsA, charsB, charsC, index);
            }
        }

        private void ManyQ6(List<char> charsA, List<char> charsB, List<char> charsC, int index)
        {
            richTextBoxMany.Text += "\nq6: ";

            if (charsA[index] == '_' && charsB[index] == '_' && charsC[index] == '_')
            {
                // вывод лент в консоль
                ShowWordMany(charsC, " l1: ");
                ShowWordMany(charsA, "     l2: ");
                ShowWordMany(charsB, "     l3: ");

                ManyQ9(charsA, charsB, charsC, ++index);
            }
            else
            {
                // вывод лент в консоль
                ShowWordMany(charsC, " l1: ");
                ShowWordMany(charsA, "     l2: ");
                ShowWordMany(charsB, "     l3: ");

                ManyQ6(charsA, charsB, charsC, --index);
            }
        }

        private void ManyQ7(List<char> charsA, List<char> charsB, List<char> charsC, int index)
        {
            richTextBoxMany.Text += "\nq7: ";

            if (charsA[index] == '_' && charsB[index] == '_' && charsC[index] == '_')
            {
                // вывод лент в консоль
                ShowWordMany(charsC, " l1: ");
                ShowWordMany(charsA, "     l2: ");
                ShowWordMany(charsB, "     l3: ");

                ManyQ8(charsA, charsB, charsC, ++index);
            }
            else
            {
                // вывод лент в консоль
                ShowWordMany(charsC, " l1: ");
                ShowWordMany(charsA, "     l2: ");
                ShowWordMany(charsB, "     l3: ");

                ManyQ7(charsA, charsB, charsC, --index);
            }
        }

        private void ManyQ8(List<char> charsA, List<char> charsB, List<char> charsC, int index)
        {
            richTextBoxMany.Text += "\nq8: ";
            if (charsA[index] != '_' || charsB[index] != '_' || charsC[index] != '_')
            {
                charsA[index] = '_';
                charsB[index] = '_';
                charsC[index] = '_';

                // вывод лент в консоль
                ShowWordMany(charsC, " l1: ");
                ShowWordMany(charsA, "     l2: ");
                ShowWordMany(charsB, "     l3: ");

                ManyQ8(charsA, charsB, charsC, ++index);
            }
            else
            {
                charsC[index] = '0';

                // вывод лент в консоль
                ShowWordMany(charsC, " l1: ");
                ShowWordMany(charsA, "     l2: ");
                ShowWordMany(charsB, "     l3: ");

                return;
            }
        }

        private void ManyQ9(List<char> charsA, List<char> charsB, List<char> charsC, int index)
        {
            richTextBoxMany.Text += "\nq9: ";
            if (charsA[index] != '_' || charsB[index] != '_' || charsC[index] != '_')
            {
                charsA[index] = '_';
                charsB[index] = '_';
                charsC[index] = '_';

                // вывод лент в консоль
                ShowWordMany(charsC, " l1: ");
                ShowWordMany(charsA, "     l2: ");
                ShowWordMany(charsB, "     l3: ");

                ManyQ9(charsA, charsB, charsC, ++index);
            }
            else
            {
                charsC[index] = '1';

                // вывод лент в консоль
                ShowWordMany(charsC, " l1: ");
                ShowWordMany(charsA, "     l2: ");
                ShowWordMany(charsB, "     l3: ");

                return;
            }
        }
        #endregion

        #endregion


        #region Выводы_лент


        // вывод ленты(одноленточная)
        void ShowWord(List<char> chars, string title)
        {
            StringBuilder sb = new StringBuilder("\n" + title + "____");

            for (int i = 0; i < chars.Count; i++)
            {
                sb.Append(chars[i]);
            }

            richTextBoxForOne.Text += sb.ToString() + "____";
        }

        // вывод ленты(многоленточная)
        void ShowWordMany(List<char> chars, string title)
        {
            StringBuilder sb = new StringBuilder("\n" + title + "____");

            for (int i = 0; i < chars.Count; i++)
            {
                sb.Append(chars[i]);
            }

            richTextBoxMany.Text += sb.ToString() + "____";
        }

        #endregion


        #region Построение_графиков

        // построить график одноленточной МТ и многоленточной МТ
        private void buttonBuild_Click(object sender, EventArgs e)
        {
            // если нажали на кнопку пока рисуем график выходим
            if (backgroundWorker1.IsBusy) return;

            // сбрасываем длинну слова(пометка что график очищен)
            len = 1;
            
            // очищаем графики
            chartForOne.Series[0].Points.Clear();
            chartForMany.Series[0].Points.Clear();
            
            // назначем в выполнение на фоне функции
            backgroundWorker1.DoWork += (sen, ea) => backgroundWorker1_DoWork(sender, ea);

            // подписываем наблюдателя(нанесение точек на графики) на событие
            backgroundWorker1.ProgressChanged += (sen, ea) =>
            {
                // одноленточная
                PrintPointOnChartOne(len, maxTOne);
                // многоленточная
                PrintPointOnChartMany(len, maxTMany);
            };

            // запускаем выполнение функции
            backgroundWorker1.RunWorkerAsync();
        }

        // очистка графика одноленточной МТ и многоленточной МТ
        private void buttonClear_Click(object sender, EventArgs e)
        {
            // сбрасываем длинну слова(пометка что график очищен)
            len = 1;

            // очистка графиков
            chartForOne.Series[0].Points.Clear();
            chartForMany.Series[0].Points.Clear();
        }

        // фоновое построение графика
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bw = sender as BackgroundWorker;

            // не отменяем функцию во время выполнения
            e.Cancel = false;

            // на случай если заходим в цикл при нарисованном графике
            if (len >= 8) return;

            // сбрасываем переменные
            maxTOne = 0;
            maxTMany = 0;
            len = 1;

            // цикл поиска максимального количества шагов и нанесение на график
            for (len = 1; len < 15; len++)
            {
                // сгенерировать слова заданной длинны
                string wordForLen = WordGeneric("", 0, len);

                // создать массив слов заданной длины
                string[] words = wordForLen.Trim(" \n".ToCharArray()).Split('\n');

                // сбрасываем максимумы
                maxTOne = 0;
                maxTMany = 0;

                // для каждого массива слов заданной длинны найти максимальное количество проходов
                foreach (var word in words)
                {
                    if (String.IsNullOrEmpty(word)) continue;

                    // посчитать колтичество дейтсвий для этого слова
                    stepsOne = CountStepsForOne(word);
                    stepsMany = CountStepsForMany(word);

                    // найти максимальное количество шагов
                    // одноленточная
                    maxTOne = maxTOne < stepsOne ? stepsOne : maxTOne;

                    // многоленточная
                    maxTMany = maxTMany < stepsMany ? stepsMany : maxTMany;
                }

                // нанести точку(максимальное количество шагов) на график
                backgroundWorker1.ReportProgress(0);
                Thread.Sleep(700);
            }
        }

        // генерация слова 
        // s - начальная строка
        // cur_n - текущая длинна слова
        // n - нужная длинна слов
        string WordGeneric(string s, int cur_n, int n)
        {
            if (cur_n < n)
            {
                string s1, s2, s3;
                StringBuilder s4 = new StringBuilder();
                s1 = WordGeneric(s + "a", cur_n + 1, n);
                s2 = WordGeneric(s + "b", cur_n + 1, n);
                s3 = WordGeneric(s + "c", cur_n + 1, n);
                s4.Append(s1 + "\n" + s2 + "\n" + s3);
                return s4.ToString();
            }
            else
                return s;
        }


        #region Подчёт_для_одноленточной

        // обработка слова однолеточной МТ(для графика)
        private int CountStepsForOne(string word)
        {
            stepsOne = 0;

            // для простаты обработки делаем список символов
            List<char> chars = new List<char>(word.ToCharArray());

            // переменная для прохода по слову
            int i = 1;

            // добавление пустого пространства в начале слова и в конце
            chars.Add('_');
            chars.Insert(0, '_');

            // запуск обработки слова(с первого действия)
            q1_chart(chars, i);


            // возвращаем количество шагов
            return stepsOne;
        }

        #region Действия_для_однолеточной_МТ

        void q1_chart(List<char> chars, int index)
        {
            stepsOne++;
            switch (chars[index])
            {
                case 'a':
                    q2_chart(chars, index);
                    break;

                case 'b':
                case 'c':
                    chars[index] = '_';
                    q9_chart(chars, ++index);
                    break;

                default:
                    chars[index] = '0';
                    break;
            }
        }

        void q2_chart(List<char> chars, int index)
        {
            stepsOne++;
            switch (chars[index])
            {
                case 'a':
                    chars[index] = '_';
                    q5_chart(chars, ++index);
                    break;

                case 'b':
                    q11_chart(chars, index);
                    break;

                case 'c':
                    chars[index] = '_';
                    q9_chart(chars, ++index);
                    break;

                case '#':
                    q9_chart(chars, index);
                    break;

                default:
                    q2_chart(chars, --index);
                    break;
            }
        }

        void q3_chart(List<char> chars, int index)
        {
            stepsOne++;
            switch (chars[index])
            {
                case 'a':
                    q3_chart(chars, ++index);
                    break;

                case 'b':
                    chars[index] = '_';
                    q4_chart(chars, ++index);
                    break;

                case 'c':
                    q4_chart(chars, index);
                    break;

                default:
                    q3_chart(chars, ++index);
                    break;
            }
        }

        void q4_chart(List<char> chars, int index)
        {
            stepsOne++;
            switch (chars[index])
            {
                case 'a':
                case 'b':
                    q7_chart(chars, index);
                    break;

                case 'c':
                    chars[index] = '#';
                    q6_chart(chars, index);
                    break;

                case '#':
                    chars[index] = '_';
                    q9(chars, ++index);
                    break;

                default:
                    q9_chart(chars, ++index);
                    break;
            }
        }

        void q5_chart(List<char> chars, int index)
        {
            stepsOne++;
            switch (chars[index])
            {
                case 'a':
                case 'b':
                case 'c':
                    q5_chart(chars, ++index);
                    break;

                case '#':
                    q4_chart(chars, --index);
                    break;

                default:
                    q4_chart(chars, --index);
                    break;
            }
        }

        void q6_chart(List<char> chars, int index)
        {
            stepsOne++;
            switch (chars[index])
            {
                case 'a':
                case 'b':
                case 'c':
                case '#':
                    q6_chart(chars, --index);
                    break;

                default:
                    q2_chart(chars, ++index);
                    break;
            }
        }

        void q7_chart(List<char> chars, int index)
        {
            stepsOne++;
            switch (chars[index])
            {
                case 'a':
                case 'b':
                case 'c':
                case '#':
                    q7_chart(chars, --index);
                    break;

                default:
                    q9_chart(chars, ++index);
                    break;
            }
        }

        void q8_chart(List<char> chars, int index)
        {
            stepsOne++;
            switch (chars[index])
            {
                case 'a':
                case 'b':
                case 'c':
                case '#':
                    chars[index] = '_';
                    q8_chart(chars, ++index);
                    break;

                default:
                    chars[index] = '1';
                    break;
            }
        }

        void q9_chart(List<char> chars, int index)
        {
            stepsOne++;
            switch (chars[index])
            {
                case 'a':
                case 'b':
                case 'c':
                case '#':
                    chars[index] = '_';
                    q9_chart(chars, ++index);
                    break;

                default:
                    chars[index] = '0';
                    break;
            }
        }

        void q10_chart(List<char> chars, int index)
        {
            stepsOne++;
            switch (chars[index])
            {
                case 'b':
                    q14_chart(chars, index);
                    break;

                case '#':
                    q10_chart(chars, --index);
                    break;

                default:
                    q8_chart(chars, ++index);
                    break;
            }
        }

        void q11_chart(List<char> chars, int index)
        {
            stepsOne++;
            switch (chars[index])
            {
                case 'a':
                    chars[index] = '_';
                    q9_chart(chars, ++index);
                    break;

                case 'b':
                    chars[index] = '_';
                    q12_chart(chars, ++index);
                    break;

                case '#':
                    q10_chart(chars, --index);
                    break;

                default:
                    q8_chart(chars, index);
                    break;
            }
        }

        void q12_chart(List<char> chars, int index)
        {
            stepsOne++;
            switch (chars[index])
            {
                case 'a':
                    q9_chart(chars, index);
                    break;

                case 'b':
                case '#':
                    q12_chart(chars, ++index);
                    break;

                case 'c':
                    q7_chart(chars, --index);
                    break;

                default:
                    q13_chart(chars, --index);
                    break;
            }
        }

        void q13_chart(List<char> chars, int index)
        {
            stepsOne++;
            switch (chars[index])
            {
                case 'b':
                    q8_chart(chars, index);
                    break;

                case '#':
                    chars[index] = '_';
                    q15_chart(chars, --index);
                    break;

                default:
                    q8_chart(chars, ++index);
                    break;
            }
        }

        void q14_chart(List<char> chars, int index)
        {
            stepsOne++;
            switch (chars[index])
            {
                case 'b':
                case '#':
                    q14_chart(chars, --index);
                    break;

                default:
                    q11_chart(chars, ++index);
                    break;
            }
        }

        void q15_chart(List<char> chars, int index)
        {
            stepsOne++;
            switch (chars[index])
            {
                case 'b':
                    q14_chart(chars, index);
                    break;

                case '#':
                    q10_chart(chars, index);
                    break;

                default:
                    q7_chart(chars, index);
                    break;
            }
        }

        #endregion

        #endregion


        #region Подсчёт_для_многоленточной

        // оброботка слова на многоленточной МТ(для графика)
        private int CountStepsForMany(string word)
        {
            stepsMany = 0;

            // список символов
            List<char> charsC = new List<char>(word.ToCharArray());

            // списки символов
            List<char> charsA = new List<char>();
            List<char> charsB = new List<char>();

            // если передано пустое слово выходим из функции
            // если у слова неверное начало выходим
            if (charsC[0] != 'a') return ++stepsMany;


            // цикл распределения смволов по спискам(лентам)
            while (charsC[0] != 'c')
            {
                ++stepsMany;
                // получить удаляем элемент слова
                char c = charsC[0];

                // удалить элемент слова
                charsC.RemoveAt(0);

                // выбрать список для добавления
                // если нарушен порядок ввода, то завершаем функцию
                if (c == 'a' && charsB.Count == 0)
                    charsA.Add(c);
                else if (c == 'b')
                    charsB.Add(c);
                else
                    return ++stepsMany;

                if (charsC.Count == 0) break;
            }


            // оброботка лент(слова)
            LentsExecChart(charsA, charsB, charsC);

            return stepsMany;
        }

        private void LentsExecChart(List<char> charsA, List<char> charsB, List<char> charsC)
        {
            charsA.Insert(0, '_');
            charsC.Insert(0, '_');
            charsB.Insert(0, '_');

            charsA.AddRange("___________".ToCharArray());
            charsC.AddRange("___________".ToCharArray());
            charsB.AddRange("___________".ToCharArray());

            int index = 1;

            ManyQ1_chart(charsA, charsB, charsC, index);
        }


        #region Действия_для_многоленточной_МТ

        private void ManyQ1_chart(List<char> charsA, List<char> charsB, List<char> charsC, int index)
        {
            ++stepsMany;

            if (charsA[index] == 'a' && charsB[index] == 'b' && charsC[index] == 'c')
                ManyQ2_chart(charsA, charsB, charsC, index);
            else
                ManyQ7_chart(charsA, charsB, charsC, index);
        }

        private void ManyQ2_chart(List<char> charsA, List<char> charsB, List<char> charsC, int index)
        {
            ++stepsMany;

            if (charsA[index] == 'a' && charsC[index] == 'c' && charsB[index] == 'b')
                ManyQ2_chart(charsA, charsB, charsC, ++index);
            else if (charsA[index] == '_' && charsC[index] == '_' && charsB[index] == '_')
                ManyQ7_chart(charsA, charsB, charsC, --index);
            else
                ManyQ3_chart(charsA, charsB, charsC, index);
        }

        private void ManyQ3_chart(List<char> charsA, List<char> charsB, List<char> charsC, int index)
        {
            ++stepsMany;


            if (charsA[index] == 'a' && charsC[index] == 'c' && charsB[index] == '_')
                ManyQ3_chart(charsA, charsB, charsC, ++index);
            else if (charsA[index] == '_' && charsC[index] == '_' && charsB[index] == '_')
                ManyQ6_chart(charsA, charsB, charsC, --index);
            else
                ManyQ4_chart(charsA, charsB, charsC, index);
        }

        private void ManyQ4_chart(List<char> charsA, List<char> charsB, List<char> charsC, int index)
        {
            ++stepsMany;

            if (charsA[index] == '_' && charsC[index] == '_' && charsB[index] == 'b')
                ManyQ4_chart(charsA, charsB, charsC, ++index);
            else if (charsA[index] == '_' && charsC[index] == '_' && charsB[index] == '_')
                ManyQ6_chart(charsA, charsB, charsC, --index);
            else
                ManyQ7_chart(charsA, charsB, charsC, index);
        }

        private void ManyQ6_chart(List<char> charsA, List<char> charsB, List<char> charsC, int index)
        {
            ++stepsMany;

            if (charsA[index] == '_' && charsB[index] == '_' && charsC[index] == '_')
                ManyQ9_chart(charsA, charsB, charsC, ++index);
            else
                ManyQ6_chart(charsA, charsB, charsC, --index);
        }

        private void ManyQ7_chart(List<char> charsA, List<char> charsB, List<char> charsC, int index)
        {
            ++stepsMany;

            if (charsA[index] == '_' && charsB[index] == '_' && charsC[index] == '_')
                ManyQ8_chart(charsA, charsB, charsC, ++index);
            else
                ManyQ7_chart(charsA, charsB, charsC, --index);
        }

        private void ManyQ8_chart(List<char> charsA, List<char> charsB, List<char> charsC, int index)
        {
            ++stepsMany;
            if (charsA[index] != '_' || charsB[index] != '_' || charsC[index] != '_')
            {
                charsA[index] = '_';
                charsB[index] = '_';
                charsC[index] = '_';

                ManyQ8_chart(charsA, charsB, charsC, ++index);
            }
            else
            {
                charsC[index] = '0';
                return;
            }
        }

        private void ManyQ9_chart(List<char> charsA, List<char> charsB, List<char> charsC, int index)
        {
            ++stepsMany;
            if (charsA[index] != '_' || charsB[index] != '_' || charsC[index] != '_')
            {
                charsA[index] = '_';
                charsB[index] = '_';
                charsC[index] = '_';

                ManyQ9_chart(charsA, charsB, charsC, ++index);
            }
            else
            {
                charsC[index] = '1';
                return;
            }
        }
        #endregion

        #endregion


        #region Нанесение_точек_на_графики

        void PrintPointOnChartOne(int x, int y)
        {
            chartForOne.Series[0].Points.AddXY(x, y);
        }

        void PrintPointOnChartMany(int x, int y)
        {
            chartForMany.Series[0].Points.AddXY(x, y);
        }

        #endregion


        #endregion
    
    }

}
