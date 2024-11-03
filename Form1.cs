using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FibonaciApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int Fibonacci(int n)
        {
            if (n <= 1)
                return n;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        // Obsługa zdarzenia kliknięcia przycisku
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Czyść listę przed każdym obliczeniem
            lstFibonacci.Items.Clear();

            // Oblicz i dodaj do listy pierwsze 10 liczb Fibonacciego
            for (int i = 0; i < 10; i++)
            {
                int fibNumber = Fibonacci(i);
                lstFibonacci.Items.Add($"F({i}) = {fibNumber}");
            }
        }
    }
}

