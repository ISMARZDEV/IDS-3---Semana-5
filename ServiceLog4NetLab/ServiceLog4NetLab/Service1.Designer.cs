namespace ServiceLog4NetLab
{
    partial class Service1
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fswRevicar = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.fswRevicar)).BeginInit();
            // 
            // fswRevicar
            // 
            this.fswRevicar.EnableRaisingEvents = true;
            this.fswRevicar.Path = "C:\\Users\\hfsa2\\OneDrive - INTEC\\Trimestres\\T-5\\Lab. Desarrollo De Software III\\S-" +
    "5\\ServiceLog4NetLab\\Revisar";
            this.fswRevicar.Changed += new System.IO.FileSystemEventHandler(this.fswRevicar_Changed);
            this.fswRevicar.Created += new System.IO.FileSystemEventHandler(this.fswRevicar_Created);
            this.fswRevicar.Deleted += new System.IO.FileSystemEventHandler(this.fswRevicar_Deleted);
            this.fswRevicar.Renamed += new System.IO.RenamedEventHandler(this.fswRevicar_Renamed);
            // 
            // Service1
            // 
            this.ServiceName = "Service1";
            ((System.ComponentModel.ISupportInitialize)(this.fswRevicar)).EndInit();

        }

        #endregion

        private System.IO.FileSystemWatcher fswRevicar;
    }
}
