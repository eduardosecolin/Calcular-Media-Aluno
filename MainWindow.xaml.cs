using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Exercicio1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Aluno a = new Aluno();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCarregar_Click(object sender, RoutedEventArgs e)
        {
            a.setNome(txtNome.Text);
            a.setCurso(txtCurso.Text);
            a.setNota1(double.Parse(txtNota1.Text));
            a.setNota2(double.Parse(txtNota2.Text));
            
        }

        private void btnImprimir_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(a.imprimir());
        }

        private void btnLimpar_Click(object sender, RoutedEventArgs e)
        {
            txtNome.Clear();
            txtCurso.Clear();
            txtNota1.Clear();
            txtNota2.Clear();
            txtMedia.Clear();
        }

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            a.calcularMedia();
            txtMedia.Text = Convert.ToString(a.getMedia());
        }

        private void btnAprovado_Click(object sender, RoutedEventArgs e)
        {
            if(a.aprovado())
            {
                MessageBox.Show("Aprovado!");
            }
            else
            {
                MessageBox.Show("Reprovado!");
            }
        }
    }
}
