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
using System.Windows.Shapes;
using System.Windows.Forms;


namespace WpfDataBinding
{
    /// <summary>
    /// Interaction logic for smpQueryWindow.xaml
    /// </summary>
    public partial class smpQueryWindow : Window
    {
        public delegate void FormClosingHandler(string fromdate, string todate, string aggregate, string land, string isle);

        public event FormClosingHandler FormClosingEvent;

        public smpQueryWindow()
        {
            InitializeComponent();

        }


        public void btnQuery_Click(object sender, EventArgs e)
        {



            string fromDate = tbFromDate.Text;
            string endDate = tbEndDate.Text;
            string Aggregate = "0";
            string Land = "0";
            string Isle = "0";

            if (rdbAvg.IsChecked == true)
            {
                Aggregate = "1";
            }
            else if (rdbMax.IsChecked == true)
            {
                Aggregate = "2";
            }
            else if (rdbMin.IsChecked == true)
            {
                Aggregate = "3";
            }
            else
            {
                Aggregate = "4";
            }

            if (cbInternal.IsChecked == true)
            {
                Land = "1";
            }
            else
            {
                Land = "0";
            }

            if (cbIsle.IsChecked == true)
            {
                Isle = "1";
            }
            else
            {
                Isle = "0";
            }

            

            #region 어플리케이션 변수
            //App.Current.Properties["fromDate"] = tbFromDate.Text;
            //App.Current.Properties["endDate"] = tbEndDate.Text;

            //if (rdbAvg.IsChecked == true)
            //{
            //    App.Current.Properties["Aggregate"] = 1;
            //}
            //else if (rdbMax.IsChecked == true)
            //{
            //    App.Current.Properties["Aggregate"] = 2;
            //}
            //else if (rdbMin.IsChecked == true)
            //{
            //    App.Current.Properties["Aggregate"] = 3;
            //}
            //else
            //{
            //    App.Current.Properties["Aggregate"] = 4;
            //}

            //if (cbInternal.IsChecked == true)
            //{
            //    App.Current.Properties["Land"] = 1;
            //}
            //else
            //{
            //    App.Current.Properties["Land"] = 0;
            //}

            //if (cbIsle.IsChecked == true)
            //{
            //    App.Current.Properties["Isle"] = 1;
            //}
            //else
            //{
            //    App.Current.Properties["Isle"] = 0;
            //}
            #endregion
            
            
            FormClosingEvent(fromDate, endDate, Aggregate, Land, Isle);
            

            this.Close();
        }


    }
}
