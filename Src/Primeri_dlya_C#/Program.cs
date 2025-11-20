namespace _04enKretoyRedaktor
{
    public static class ProgramBase
    {
    }

    namespace _04enKretoyRedaktor
    {
        using System;
        using System.Drawing;
        using System.Windows.Forms;
        public partial class MainForm : Form
        {
            public MainForm()
            {
                // Убираем InitializeComponent() и делаем все руками
                SetupForm();
                CreateControls();
            }

            private void SetupForm()
            {
                this.Text = "СУПЕР РЕДАКТОР 3000";
                this.Size = new Size(600, 400);
                this.StartPosition = FormStartPosition.CenterScreen;
            }

            private void CreateControls()
            {
                // Кнопка 1 - Выбрать файл
                Button btn1 = new Button();
                btn1.Text = "Выбрать файл";
                btn1.Location = new Point(50, 50);
                btn1.Size = new Size(100, 30);
                btn1.Click += (s, e) => MessageBox.Show("Куда ты тыкаешь, не работает эта кнопка");
                this.Controls.Add(btn1);

                // Кнопка 2 - Изменить размер
                Button btn2 = new Button();
                btn2.Text = "Изменить размер";
                btn2.Location = new Point(170, 50);
                btn2.Size = new Size(100, 30);
                btn2.Click += (s, e) => MessageBox.Show("И эта кнопка тоже не работает");
                this.Controls.Add(btn2);

                // Кнопка 3 - Конвертация
                Button btn3 = new Button();
                btn3.Text = "Конвертировать";
                btn3.Location = new Point(290, 50);
                btn3.Size = new Size(100, 30);
                btn3.Click += (s, e) => MessageBox.Show("Да ну нафиг, эта кнопка тоже не рботает как так");
                this.Controls.Add(btn3);

                // Кнопка 4 - Сохранить
                Button btn4 = new Button();
                btn4.Text = "Сохранить";
                btn4.Location = new Point(410, 50);
                btn4.Size = new Size(100, 30);
                btn4.Click += (s, e) => MessageBox.Show("Ты думаешь что если те кнопки не работают то и эта будет работать?");
                this.Controls.Add(btn4);

                // Область для картинки
                Panel picPanel = new Panel();
                picPanel.Location = new Point(50, 100);
                picPanel.Size = new Size(500, 200);
                picPanel.BorderStyle = BorderStyle.FixedSingle;
                picPanel.BackColor = Color.LightGray;
                this.Controls.Add(picPanel);

                // Текст в области картинки
                Label picLabel = new Label();
                picLabel.Text = "Тут могла бы быть ваша картинка\n(но её здесь нет)";
                picLabel.Size = new Size(200, 40);
                picLabel.Location = new Point(150, 80);
                picLabel.TextAlign = ContentAlignment.MiddleCenter;
                picPanel.Controls.Add(picLabel);
            }
        }

       
        public class Program
        {
            [STAThread]
            static void Main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
        }
    }


}