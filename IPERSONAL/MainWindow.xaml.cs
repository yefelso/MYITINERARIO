using System;
using System.Windows;
using System.Windows.Controls;

namespace IPERSONAL
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GuardarLunes_Click(object sender, RoutedEventArgs e)
        {
            List<CheckBox> checkBoxes = new List<CheckBox>()
            {
                CheckBoxLevantarse1,
                CheckBoxDesayunar1,
                CheckBoxAsearse1,
                CheckBoxEstudiarTrabajar1,
                CheckBoxAlmorzar1,
                CheckBoxEjercitarse1,
                CheckBoxTareas1,
                CheckBoxPeliculas1,
                CheckBoxCenar1,
                CheckBoxDormir1
            };

            string actividadesRealizadas = "Actividades realizadas el Lunes:\n";

            foreach (CheckBox checkBox in checkBoxes)
            {
                if (checkBox.IsChecked == true)
                {
                    actividadesRealizadas += "- " + checkBox.Content.ToString() + "\n";
                }
            }

            MessageBox.Show(actividadesRealizadas);
        }

        private void GuardarMartes_Click(object sender, RoutedEventArgs e)
        {
            List<CheckBox> checkBoxes = new List<CheckBox>()
            {
                CheckBoxLevantarse2,
                CheckBoxDesayunar2,
                CheckBoxAsearse2,
                CheckBoxEstudiarTrabajar2,
                CheckBoxAlmorzar2,
                CheckBoxEjercitarse2,
                CheckBoxTareas2,
                CheckBoxPeliculas2,
                CheckBoxCenar2,
                CheckBoxDormir2
            };

            string actividadesRealizadas = "Actividades realizadas el Martes:\n";

            foreach (CheckBox checkBox in checkBoxes)
            {
                if (checkBox.IsChecked == true)
                {
                    actividadesRealizadas += "- " + checkBox.Content.ToString() + "\n";
                }
            }

            MessageBox.Show(actividadesRealizadas);
        }

        private void GuardarMiercoles_Click(object sender, RoutedEventArgs e)
        {
            List<CheckBox> checkBoxes = new List<CheckBox>()
            {
                CheckBoxLevantarse3,
                CheckBoxDesayunar3,
                CheckBoxAsearse3,
                CheckBoxEstudiarTrabajar3,
                CheckBoxAlmorzar3,
                CheckBoxEjercitarse3,
                CheckBoxTareas3,
                CheckBoxPeliculas3,
                CheckBoxCenar3,
                CheckBoxDormir3
            };

            string actividadesRealizadas = "Actividades realizadas el Miercoles:\n";

            foreach (CheckBox checkBox in checkBoxes)
            {
                if (checkBox.IsChecked == true)
                {
                    actividadesRealizadas += "- " + checkBox.Content.ToString() + "\n";
                }
            }

            MessageBox.Show(actividadesRealizadas);
        }

        private void GuardarJueves_Click(object sender, RoutedEventArgs e)
        {
            List<CheckBox> checkBoxes = new List<CheckBox>()
            {
                CheckBoxLevantarse4,
                CheckBoxDesayunar4,
                CheckBoxAsearse4,
                CheckBoxEstudiarTrabajar4,
                CheckBoxAlmorzar4,
                CheckBoxEjercitarse4,
                CheckBoxTareas4,
                CheckBoxPeliculas4,
                CheckBoxCenar4,
                CheckBoxDormir4
            };

            string actividadesRealizadas = "Actividades realizadas el Jueves:\n";

            foreach (CheckBox checkBox in checkBoxes)
            {
                if (checkBox.IsChecked == true)
                {
                    actividadesRealizadas += "- " + checkBox.Content.ToString() + "\n";
                }
            }

            MessageBox.Show(actividadesRealizadas);
        }

        private void GuardarViernes_Click(object sender, RoutedEventArgs e)
        {
            List<CheckBox> checkBoxes = new List<CheckBox>()
            {
                CheckBoxLevantarse5,
                CheckBoxDesayunar5,
                CheckBoxAsearse5,
                CheckBoxEstudiarTrabajar5,
                CheckBoxAlmorzar5,
                CheckBoxEjercitarse5,
                CheckBoxTareas5,
                CheckBoxPeliculas5,
                CheckBoxCenar5,
                CheckBoxDormir5
            };

            string actividadesRealizadas = "Actividades realizadas el Viernes:\n";

            foreach (CheckBox checkBox in checkBoxes)
            {
                if (checkBox.IsChecked == true)
                {
                    actividadesRealizadas += "- " + checkBox.Content.ToString() + "\n";
                }
            }

            MessageBox.Show(actividadesRealizadas);
        }

        private void GuardarSabado_Click(object sender, RoutedEventArgs e)
        {
            List<CheckBox> checkBoxes = new List<CheckBox>()
            {
                CheckBoxLevantarse6,
                CheckBoxDesayunar6,
                CheckBoxAsearse6,
                CheckBoxEstudiarTrabajar6,
                CheckBoxAlmorzar6,
                CheckBoxEjercitarse6,
                CheckBoxTareas6,
                CheckBoxPeliculas6,
                CheckBoxCenar6,
                CheckBoxDormir6
            };

            string actividadesRealizadas = "Actividades realizadas el Sabado:\n";

            foreach (CheckBox checkBox in checkBoxes)
            {
                if (checkBox.IsChecked == true)
                {
                    actividadesRealizadas += "- " + checkBox.Content.ToString() + "\n";
                }
            }

            MessageBox.Show(actividadesRealizadas);
        }

        private void GuardarDomingo_Click(object sender, RoutedEventArgs e)
        {
            List<CheckBox> checkBoxes = new List<CheckBox>()
            {
                CheckBoxLevantarse7,
                CheckBoxDesayunar7,
                CheckBoxAsearse7,
                CheckBoxEstudiarTrabajar7,
                CheckBoxAlmorzar7,
                CheckBoxEjercitarse7,
                CheckBoxTareas7,
                CheckBoxPeliculas7,
                CheckBoxCenar7,
                CheckBoxDormir7
            };

            string actividadesRealizadas = "Actividades realizadas el Domingo:\n";

            foreach (CheckBox checkBox in checkBoxes)
            {
                if (checkBox.IsChecked == true)
                {
                    actividadesRealizadas += "- " + checkBox.Content.ToString() + "\n";
                }
            }

            MessageBox.Show(actividadesRealizadas);
        }

        // Agrega métodos similares para manejar los clics de los otros botones de guardar
    }
}
