using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filosofos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BotonIniciar_Click(object sender, EventArgs e)
        {
            BotonAvanzar.Enabled = true;
            BotonReiniciar.Enabled = true;
        }
    }
}
