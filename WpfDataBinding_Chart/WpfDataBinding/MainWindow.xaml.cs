using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Ribbon;
using DevExpress.Xpf.Bars;
using DevExpress.Xpf.Layout.Core;
using DevExpress.Xpf.Docking;
using DevExpress.Xpf.Grid;
using DevExpress.Xpf.Printing;
using System.ComponentModel;
using System.Collections.ObjectModel;
using DevExpress.Xpf.NavBar;
using DevExpress.Xpf.Charts;
using Npgsql;
using Mono.Security;
using System.Data;
using System.Windows.Forms;



namespace WpfDataBinding
{
    public partial class MainWindow : DXRibbonWindow
    {


        public MainWindow()
        {
            InitializeComponent();

        }
        


        private void nav_Smp_Click(object sender, EventArgs e)
        {
            smpQueryWindow smpquerywindow = new smpQueryWindow();
            
            //smpquerywindow.Owner = this;

            smpquerywindow.Show();
            
            smpquerywindow.FormClosingEvent += new smpQueryWindow.FormClosingHandler(smpQuery);
            
        }

        

        //public void smpquerywindow_FormClosed(object sender, FormClosedEventArgs e)
        public void smpQuery(string _fromdate, string _enddate, string _aggregate, string _land, string _isle)
        {

            string fromDate = _fromdate;
            string endDate = _enddate;

            string aggregate = _aggregate;
            string land = _land;
            string isle = _isle;

            string conStr = String.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};", "vitenergy-azure.cloudapp.net", "65432", "vitenergy", "vit001", "kpx_data");

            #region 쿼리 조립
            //방식 체크
            if (aggregate == "1")
            {
                aggregate = "AVG";
            }
            else if (aggregate == "2")
            {
                aggregate = "MAX";
            }
            else if (aggregate == "3")
            {
                aggregate = "MIN";
            }
            else if (aggregate == "4")
            {
                aggregate = "HOURLY";
            }


            


            //지역 체크
            string Geo = "";

            if (land == "1")
            {
                if (isle == "1")
                {
                    Geo = "";
                }
                else
                {
                    Geo = "korea_zone = '내륙' AND";
                }
            }
            else
            {
                if (isle == "1")
                {
                    Geo = "korea_zone = '제주' AND";
                }
            }


            string qryStr = "";

            if (aggregate == "HOURLY")
            {
                qryStr = "SELECT op_date, op_hour, korea_zone, smp FROM kpx_smp WHERE " + Geo + " op_date >= '" + fromDate +
                    "' AND op_date <= '" + endDate + "' ORDER BY op_date, op_hour, korea_zone";
            }

            else if (aggregate == "AVG")
            {
                qryStr = "SELECT op_date, korea_zone, AVG(smp) AS avg_smp FROM kpx_smp WHERE " + Geo + " op_date >= '" + fromDate +
                    "' AND op_date <= '" + endDate + "' GROUP BY op_date, korea_zone ORDER BY op_date, korea_zone";
            }

            else if (aggregate == "MAX")
            {
                qryStr = "SELECT op_date, korea_zone, MAX(smp) AS max_smp FROM kpx_smp WHERE " + Geo + " op_date >= '" + fromDate +
                    "' AND op_date <= '" + endDate + "' GROUP BY op_date, korea_zone ORDER BY op_date, korea_zone";
            }
            else if (aggregate == "MIN")
            {
                qryStr = "SELECT op_date, korea_zone, MIN(smp) AS min_smp FROM kpx_smp WHERE " + Geo + " op_date >= '" + fromDate +
                    "' AND op_date <= '" + endDate + "' GROUP BY op_date, korea_zone ORDER BY op_date, korea_zone";
            }
            #endregion

            #region 디비 커넥션 & dataset 준비해서 gridcontrol에 바인딩
            NpgsqlConnection conn = new NpgsqlConnection(conStr);
            conn.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(qryStr, conn);
            DataSet ds = new DataSet();


            da.Fill(ds, "kpx_data");
            gridControl1.DataContext = ds;

            conn.Close();
            #endregion

            #region 차트 내륙지역 시리즈 쿼리와 datatable chart에 바인딩
            if (land == "1")
            {
                NpgsqlConnection connInternal = new NpgsqlConnection(conStr);

                string internalQuery = "";

                if (aggregate == "HOURLY")
                {
                    internalQuery = "SELECT op_date, op_hour, smp FROM kpx_smp WHERE korea_zone = '내륙' AND op_date >= '" + fromDate +
                        "' AND op_date <= '" + endDate + "' ORDER BY op_date, op_hour";
                }

                else if (aggregate == "AVG")
                {
                    internalQuery = "SELECT op_date, AVG(smp) As smp FROM kpx_smp WHERE korea_zone = '내륙' AND op_date >= '" + fromDate +
                        "' AND op_date <= '" + endDate + "' GROUP BY op_date ORDER BY op_date";
                }

                else if (aggregate == "MAX")
                {
                    internalQuery = "SELECT op_date, MAX(smp) As smp FROM kpx_smp WHERE korea_zone = '내륙' AND op_date >= '" + fromDate +
                        "' AND op_date <= '" + endDate + "' GROUP BY op_date ORDER BY op_date";
                }
                else if (aggregate == "MIN")
                {
                    internalQuery = "SELECT op_date, MIN(smp) FROM kpx_smp WHERE korea_zone = '내륙' AND  op_date >= '" + fromDate +
                        "' AND op_date <= '" + endDate + "' GROUP BY op_date ORDER BY op_date";
                }


                //DataSet dsInternal = new DataSet();
                connInternal.Open();
                //NpgsqlDataAdapter daInternal = new NpgsqlDataAdapter(internalQuery, connInternal);
                //daInternal.Fill(dsInternal, "kpx_data");
                //DataTable dt = dsInternal.Tables["kpx_data"];
                DataTable dt = new DataTable();
                dt.Clear();


                NpgsqlCommand command = new NpgsqlCommand(internalQuery, connInternal);
                NpgsqlDataReader dr = command.ExecuteReader();

                dt.Load(dr);

                dr.Close();
                connInternal.Close();

                SMPSeries.DataSource = dt;

            }
            #endregion

            #region 차트 제주지역 시리즈 쿼리와 datatable chart에 바인딩
            if (isle == "1")
            {
                NpgsqlConnection connIsle = new NpgsqlConnection(conStr);

                string isleQuery = "";

                if (aggregate == "HOURLY")
                {
                    isleQuery = "SELECT op_date, op_hour, smp FROM kpx_smp WHERE korea_zone = '제주' AND op_date >= '" + fromDate +
                        "' AND op_date <= '" + endDate + "' ORDER BY op_date, op_hour";
                }

                else if (aggregate == "AVG")
                {
                    isleQuery = "SELECT op_date, AVG(smp) As smp FROM kpx_smp WHERE korea_zone = '제주' AND op_date >= '" + fromDate +
                        "' AND op_date <= '" + endDate + "' GROUP BY op_date ORDER BY op_date";
                }

                else if (aggregate == "MAX")
                {
                    isleQuery = "SELECT op_date, MAX(smp) As smp FROM kpx_smp WHERE korea_zone = '제주' AND op_date >= '" + fromDate +
                        "' AND op_date <= '" + endDate + "' GROUP BY op_date ORDER BY op_date";
                }
                else if (aggregate == "MIN")
                {
                    isleQuery = "SELECT op_date, MIN(smp) As smp FROM kpx_smp WHERE korea_zone = '제주' AND  op_date >= '" + fromDate +
                        "' AND op_date <= '" + endDate + "' GROUP BY op_date ORDER BY op_date";
                }

                DataSet dsIsle = new DataSet();
                connIsle.Open();
                NpgsqlDataAdapter daIsle = new NpgsqlDataAdapter(isleQuery, connIsle);
                daIsle.Fill(dsIsle, "kpx_data");
                //DataTable dt = dsInternal.Tables["kpx_data"];
                DataTable dt2 = new DataTable();
                dt2.Clear();
                
                NpgsqlCommand command = new NpgsqlCommand(isleQuery, connIsle);
                NpgsqlDataReader dr2 = command.ExecuteReader();
                
                dt2.Load(dr2);

                dr2.Close();
                connIsle.Close();

                SMPSeries2.DataSource = dt2;
            }

            #endregion
            
            //SMPSeries.DataSource = new DataSet1TableAdapters.kpx_smpTableAdapter().GetData();
            

        }


    }
}
