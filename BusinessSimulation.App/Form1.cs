using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessSimulation.Model;
using BusinessSimulation.Impl;

namespace BusinessSimulation.App
{
    public partial class Form1 : Form
    {
        private IManager m_manager;
        public Form1()
        {
            InitializeApp();
            InitializeComponent();
        }

        private void InitializeApp()
        {
            IManager manager = new Manager();
            m_manager = manager;
        }

        private void AddTva(object sender, EventArgs e)
        {
            int percent = int.Parse(newVatPercentTextBox.Text);
            var vat = new Vat(percent);

            m_manager.AddVat(vat);
        }
    }
}
