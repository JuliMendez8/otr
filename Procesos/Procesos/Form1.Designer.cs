namespace Procesos
{
    partial class frm1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Name", System.Windows.Forms.HorizontalAlignment.Left);
            this.lvwProcesos = new System.Windows.Forms.ListView();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.btnKill = new System.Windows.Forms.Button();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvwProcesos
            // 
            this.lvwProcesos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName});
            listViewGroup2.Header = "Name";
            listViewGroup2.Name = "lvgName";
            this.lvwProcesos.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup2});
            this.lvwProcesos.HideSelection = false;
            this.lvwProcesos.Location = new System.Drawing.Point(235, 12);
            this.lvwProcesos.Name = "lvwProcesos";
            this.lvwProcesos.Size = new System.Drawing.Size(553, 426);
            this.lvwProcesos.TabIndex = 0;
            this.lvwProcesos.UseCompatibleStateImageBehavior = false;
            this.lvwProcesos.View = System.Windows.Forms.View.Details;
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Location = new System.Drawing.Point(60, 23);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(88, 71);
            this.btnVisualizar.TabIndex = 1;
            this.btnVisualizar.Text = "VISUALIZAR PROCESOS";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // btnKill
            // 
            this.btnKill.Location = new System.Drawing.Point(60, 134);
            this.btnKill.Name = "btnKill";
            this.btnKill.Size = new System.Drawing.Size(88, 71);
            this.btnKill.TabIndex = 2;
            this.btnKill.Text = "MATAR PROCESOS";
            this.btnKill.UseVisualStyleBackColor = true;
            this.btnKill.Click += new System.EventHandler(this.btnKill_Click);
            // 
            // chName
            // 
            this.chName.Text = "Proceso";
            this.chName.Width = 547;
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKill);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.lvwProcesos);
            this.Name = "frm1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwProcesos;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.Button btnKill;
        private System.Windows.Forms.ColumnHeader chName;
    }
}

