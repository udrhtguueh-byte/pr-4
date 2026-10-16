using System;
using System.Drawing;
using System.Windows.Forms;

namespace pr_4
{
    public partial class Form1 : Form
    {
        private Button buttonChangeColor;
        private Button buttonShowMessage;

        public Form1()
        {
            InitializeComponent();

            // Базовая настройка формы
            this.Text = "Тест Git и GitHub";
            this.Size = new Size(350, 250);
            this.StartPosition = FormStartPosition.CenterScreen;

            // ==========================================
            // ШАГ 1: Добавь эту кнопку в ветке master
            // ==========================================
            buttonChangeColor = new Button();
            buttonChangeColor.Text = "Сменить цвет";
            buttonChangeColor.Location = new Point(100, 50);
            buttonChangeColor.Size = new Size(130, 40);
            buttonChangeColor.Click += (s, e) =>
            {
                // Меняем цвет фона формы при нажатии
                this.BackColor = this.BackColor == Color.LightGreen ? SystemColors.Control : Color.LightGreen;
            };
            this.Controls.Add(buttonChangeColor);

            // ==========================================
            // ШАГ 2: Эту кнопку добавляй позже, 
            // когда создашь ветку Addfunction
            // ==========================================
            buttonShowMessage = new Button();
            buttonShowMessage.Text = "Сообщение";
            buttonShowMessage.Location = new Point(100, 110);
            buttonShowMessage.Size = new Size(130, 40);
            buttonShowMessage.Click += (s, e) =>
            {
                MessageBox.Show("Код из новой ветки работает!", "Успех");
            };
            this.Controls.Add(buttonShowMessage);
        }
    }
}