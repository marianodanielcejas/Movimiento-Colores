using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Choque_Colores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btPosición_Click(object sender, EventArgs e)
        {
            lblActorRojo.Left = 50;
            lblActorAzul.Left = 700;
            lblActorAmarillo.Left = 50;
            lblActorVerde.Left = 700;

            lblActorRojo.Visible = true;
            lblActorAzul.Visible = true;
            lblActorAmarillo.Visible = true;
            lblActorVerde.Visible = true;
        }

        private void btMover_Click(object sender, EventArgs e)
        {
            while((lblActorRojo.Left + lblActorRojo.Width) != (lblActorAzul.Left) && (lblActorAmarillo.Left + lblActorAmarillo.Width) != (lblActorVerde.Left))
            {
                lblActorRojo.Left = lblActorRojo.Left + 1;
                lblActorAzul.Left = lblActorAzul.Left - 1;
                lblActorAmarillo.Left = lblActorAmarillo.Left + 1;
                lblActorVerde.Left = lblActorVerde.Left - 1;
                this.Refresh();
            }
        }

        private void btArribaAbajo_Click(object sender, EventArgs e)
        {
            lblActorAmarillo.Top = 200;
            lblActorVerde.Top = 200;
            while(true)
            {
                lblActorAmarillo.Top = lblActorAmarillo.Top + 1;
                lblActorVerde.Top = lblActorVerde.Top + 1;
                this.Refresh();
                if(lblActorAmarillo.Top == 300 && lblActorVerde.Top == 300)
                {
                    break;
                }
                this.Refresh();
            }
            lblActorAmarillo.Top = 213;
            lblActorVerde.Top = 213;
            this.Refresh();
        }
    }
}
