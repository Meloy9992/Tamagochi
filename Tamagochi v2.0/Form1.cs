using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tamagochi_v2._0
{
    public partial class Tamagochi : Form
    {
        bool countCatch = false;
        bool btnSleep = false;
        bool btnEating = false;
        bool btnWash = false;
        bool btnJoke = false;
        public Tamagochi()
        {
            InitializeComponent();
            Picture.Image = imageList1.Images[0];
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        } // Кнопка выхода из программы
        private void Sleep_Click(object sender, EventArgs e)
        {
            if (btnSleep == false)
            {
                Picture.Image = imageList1.Images[5];
                
                btnSleep = true;
                btnEating = false;
            }
            else if (btnSleep == true)
            {
                Picture.Image = imageList1.Images[0];
                btnJoke = false;
                btnWash = false;
                btnEating = false;
                btnSleep = false;
            }
        } // Обработка двух нажатий на клавишу Sleep для заполнения шкалы
        private void Eating_Click(object sender, EventArgs e)
        {
            if (btnEating == false)
            {
                Picture.Image = imageList1.Images[12];
                
                btnEating = true;
                btnSleep = false;
            }
            else if (btnEating == true)
            {
                Picture.Image = imageList1.Images[0];
                btnJoke = false;
                btnWash = false;
                btnEating = false;
                btnSleep = false;
            }
        } // Обработка двух нажатий для кормления питомца
        private void WashUp_Click(object sender, EventArgs e)
        {
            if (btnWash == false)
            {
                Picture.Image = imageList1.Images[8];
                btnWash = true;
                btnEating = false;
                btnSleep = false;
            }
            else if (btnWash == true)
            {
                Picture.Image = imageList1.Images[0];
                btnJoke = false;
                btnWash = false;
                btnEating = false;
                btnSleep = false;
            }
        } // Обработка двух нажатий для купания питомца
        private void Joke_Click(object sender, EventArgs e)
        {
            if (btnJoke == false)
            {
                Picture.Image = imageList1.Images[13];

                btnJoke = true;
                btnEating = false;
                btnSleep = false;
                btnWash = false;
            }
            else if (btnJoke == true)
            {
                Picture.Image = imageList1.Images[15];
                btnJoke = false;
                btnWash = false;
                btnEating = false;
                btnSleep = false;
            }
        } // Обработка двух нажатий для шутки
        private void timer1_Tick(object sender, EventArgs e)
        {
            DeductionHP();

            checkAllStatus();

            checkStatusForHeal();
            SleepTrue();
            FunAdd();
            HygieneAdd();
            HungryDeduction();
            HungryAdd();
            EnergySubstract();
            HygieneSubstract();
            FunSubstract();

            TamagochiDead();
        } //Таймер всей программы

        public void TamagochiDead()
        {
            if (Health.Value == Health.Minimum)
            {
                timer1.Dispose();
                TamagochiIsDead tamagochi = new TamagochiIsDead();
                tamagochi.ShowDialog();
                this.Hide();
                this.Close();
            }
        } // Если тамагочи умер то остановить таймер и вывести окно проигрыша
        public void checkAllStatus ()
        {
            if (Hungry.Value == Hungry.Maximum || Energy.Value == Energy.Minimum || Hygiene.Value == Hygiene.Minimum || Fun.Value == Fun.Minimum )
                countCatch = true;
        } // Проверка всех статусов прогрессбаров для активации countcheck чтобы HP вычиталось
        public void checkStatusForHeal ()
        {
            try
            {
                if (Energy.Value > 80 && Fun.Value > 80)
                {
                    Health.Value += 10;

                    Picture.Image = imageList1.Images[6];
                }
            }
            catch (Exception)
            {
            }
        } // Если Energy и Fun больше 70% тогда прибавить 10 здоровья
        public void DeductionHP ()
        {
            try
            {
                if (countCatch == true)
                {
                    Health.Value -= 10;
                    countCatch = false;
                }
                else if (Health.Value < 50 && countCatch == true)
                {
                    Health.Value -= 20;
                    countCatch = false;
                }
            }
            catch (Exception)
            {
            }
            
        } // Если переменная countCatch равна true, то вычитать 10 HP и поменять значения countCatch на false

        // блок вычитания/добавления прогрессбаров
        public void FunAdd() 
        {
            try
            {
                if (btnJoke == true) Fun.Value += 25;
            }
            catch (Exception)
            {
            }
        } // Прибавить 20 Fun
        public void HygieneAdd()
        {
                try
                {
                if (btnWash == true) Hygiene.Value += 25;
                }
                catch (Exception)
                {
                }
        } // Прибавить 20 Hygiene
        public void HungryAdd()
        {
            try
            {
                Hungry.Value += 5;
            }
            catch (Exception)
            {
            }
        } // Прибавить 10 Hungry
        public void SleepTrue()
        {
            try
            {
                if (btnSleep == true) Energy.Value += 25;
            }
            catch (Exception)
            {
            }
        } // Активация сна тамагочи
        public void HungryDeduction()
        {

            try
            {
                if (btnEating == true) Hungry.Value -= 25;
            }
            catch (Exception)
            {
            }
        } // Вычесть 10 Hungry
        public void EnergySubstract()
        {
            if (btnSleep == false)
            {
                try
                {
                    Energy.Value -= 5;
                }
                catch (Exception)
                {
                }
            }
            
        } // Вычесть 10 Energy 
        public void HygieneSubstract()
        {
            try
            {
                Hygiene.Value -= 5;
            }
            catch (Exception)
            {
            }
        } // Вычесть 10 Hygiene
        public void FunSubstract()
        {
            try
            {
                Fun.Value -= 5;
            }
            catch (Exception)
            {
            }
        } // Вычесть 10 Fun
    }
}
