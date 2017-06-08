using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaterialDashboard
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();

          
        }

        private void home_Load(object sender, EventArgs e)
        {
            bunifuFlatButton1.selected = true;
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            setSelectForecolor((Bunifu.Framework.UI.BunifuFlatButton)sender);
            Environment.Exit(0);
        }

        void setSelectForecolor(Bunifu.Framework.UI.BunifuFlatButton sender)
        {

            bunifuFlatButton1.Textcolor =   Color.DimGray;
            bunifuFlatButton2.Textcolor =   Color.DimGray;
            bunifuFlatButton3.Textcolor =   Color.DimGray;
            bunifuFlatButton4.Textcolor =   Color.DimGray;



            sender.selected = true;
            if(sender.selected)
            {
                sender.Textcolor = Color.White;
            } 

             


        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            setSelectForecolor((Bunifu.Framework.UI.BunifuFlatButton)sender);
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            setSelectForecolor((Bunifu.Framework.UI.BunifuFlatButton)sender);
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            setSelectForecolor((Bunifu.Framework.UI.BunifuFlatButton)sender);
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            setSelectForecolor((Bunifu.Framework.UI.BunifuFlatButton)sender);
        }
    }
}
