using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;


namespace ServiceLog4NetLab
{

    public partial class Service1 : ServiceBase
    {
        //private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //private static readonly ILog log = LogManager.GetLogger(typeof(ServiceBase));
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public Service1()
        {
            InitializeComponent();
        }

        System.Timers.Timer timer = new System.Timers.Timer();

        
        protected override void OnStart(string[] args)
        {
            timer.Interval = int.Parse(ConfigurationManager.AppSettings["INTERVAL_MIN"]);
            //timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
            timer.Enabled = true;
            timer.Start();           
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            log.Info("Timer: " + DateTime.Now.ToLongTimeString());
            StreamWriter sw = new StreamWriter(ConfigurationManager.AppSettings["RUTA"], true);
            //StreamWriter sw = new StreamWriter("c:\\tmp\\log2023.txt", true);
            sw.WriteLine(DateTime.Now.ToLongTimeString());
            sw.Close();
            //throw new NotImplementedException();
        }

        protected override void OnStop()
        {
        }

        private void fswRevicar_Changed(object sender, FileSystemEventArgs e)
        {
            log.Info("FSW Cambio: " + "Archivo: " + e.Name + " Cambió");
            StreamWriter sw = new StreamWriter(ConfigurationManager.AppSettings["RUTA"], true);
            sw.WriteLine(DateTime.Now.ToLongTimeString() + " " + "Archivo: " + e.Name + " Cambio");
            sw.Close();
        }

        private void fswRevicar_Created(object sender, FileSystemEventArgs e)
        {
            log.Info("FSW Creado: " + "Archivo: " + e.Name + " Creado");
            StreamWriter sw = new StreamWriter(ConfigurationManager.AppSettings["RUTA"], true);
            sw.WriteLine(DateTime.Now.ToLongTimeString() + " " + "Archivo: " + e.Name + " Creado");
            sw.Close();
        }

        private void fswRevicar_Deleted(object sender, FileSystemEventArgs e)
        {
            log.Info("FSW Creado: " + "Archivo: " + e.Name + " Borrado");
            StreamWriter sw = new StreamWriter(ConfigurationManager.AppSettings["RUTA"], true);
            sw.WriteLine(DateTime.Now.ToLongTimeString() + " " + "Archivo: " + e.Name + " Borrado");
            sw.Close();
        }

        private void fswRevicar_Renamed(object sender, RenamedEventArgs e)
        {
            log.Info("FSW Creado: " + "Archivo: " + e.OldName + " Modificado " + e.Name);
            StreamWriter sw = new StreamWriter(ConfigurationManager.AppSettings["RUTA"], true);
            sw.WriteLine(DateTime.Now.ToLongTimeString() + " " + "Archivo: " + e.OldName + " Modificado " + e.Name);
            sw.Close();
        }
    }
}
