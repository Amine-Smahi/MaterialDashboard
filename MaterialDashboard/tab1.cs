using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaterialDashboard
{
    public partial class tab1 : UserControl
    {
        public tab1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();


            //plot chart 1

            Bunifu.DataViz.Data data1 = new Bunifu.DataViz.Data();
            Bunifu.DataViz.DataPoint datapoint1 = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuCharts._type.line);

            bcahrt1.colorSet = new List<Color>() { Color.White };

            datapoint1.addLabely("M", "10");
            datapoint1.addLabely("T", "20");
            datapoint1.addLabely("W", "10");
            datapoint1.addLabely("T", "20");
            datapoint1.addLabely("F", "30");
            datapoint1.addLabely("S", "20");
            datapoint1.addLabely("S", "40");


            data1.addData(datapoint1);


            bcahrt1.Render(data1);



            //plot chart 1

            Bunifu.DataViz.Data data2 = new Bunifu.DataViz.Data();
            Bunifu.DataViz.DataPoint datapoint2 = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuCharts._type.column);

            bchart2.colorSet = new List<Color>() { Color.White,Color.White };


            Random r = new Random();

            datapoint2.addLabely("JAN", r.Next(0, 800).ToString());
            datapoint2.addLabely("FEB", r.Next(0, 800).ToString());
            datapoint2.addLabely("MAR", r.Next(0, 800).ToString());
            datapoint2.addLabely("APR", r.Next(0, 800).ToString());
            datapoint2.addLabely("MAY", r.Next(0, 800).ToString());
            datapoint2.addLabely("JUN", r.Next(0, 800).ToString());
            datapoint2.addLabely("JUL", r.Next(0, 800).ToString());
            datapoint2.addLabely("AUG", r.Next(0, 800).ToString());
            datapoint2.addLabely("SEP", r.Next(0, 800).ToString());
            datapoint2.addLabely("OCT", r.Next(0, 800).ToString());
            datapoint2.addLabely("NOV", r.Next(0, 800).ToString());
            datapoint2.addLabely("DEC", r.Next(0, 800).ToString());


            data2.addData(datapoint2);
            bchart2.Render(data2);





        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tab1_Load(object sender, EventArgs e)
        {
            bunifuFlatButton1.selected = true;
        }
    }
}
