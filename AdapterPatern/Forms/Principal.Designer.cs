namespace AdapterPatern
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Menu1 = new System.Windows.Forms.ToolStrip();
            this.label1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.nuevoEstudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarEstudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu1.SuspendLayout();
            this.Menu2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu1
            // 
            this.Menu1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.Menu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.label1});
            this.Menu1.Location = new System.Drawing.Point(0, 0);
            this.Menu1.Name = "Menu1";
            this.Menu1.Size = new System.Drawing.Size(443, 25);
            this.Menu1.TabIndex = 0;
            this.Menu1.Text = "Menu1";
            // 
            // label1
            // 
            this.label1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoEstudianteToolStripMenuItem,
            this.buscarEstudianteToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 22);
            this.label1.Text = "File";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(150, 6);
            // 
            // Menu2
            // 
            this.Menu2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.Menu2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.Menu2.Location = new System.Drawing.Point(0, 25);
            this.Menu2.Name = "Menu2";
            this.Menu2.Size = new System.Drawing.Size(443, 25);
            this.Menu2.TabIndex = 1;
            this.Menu2.Text = "Menu2";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::AdapterPatern.Properties.Resources.add;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "New Student";
            this.toolStripButton1.Click += new System.EventHandler(this.nuevoEstudianteToolStripMenuItem_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::AdapterPatern.Properties.Resources.search;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Search Student";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::AdapterPatern.Properties.Resources.shutdown;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Close ";
            // 
            // nuevoEstudianteToolStripMenuItem
            // 
            this.nuevoEstudianteToolStripMenuItem.Image = global::AdapterPatern.Properties.Resources.add;
            this.nuevoEstudianteToolStripMenuItem.Name = "nuevoEstudianteToolStripMenuItem";
            this.nuevoEstudianteToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.nuevoEstudianteToolStripMenuItem.Text = "New Student";
            this.nuevoEstudianteToolStripMenuItem.Click += new System.EventHandler(this.nuevoEstudianteToolStripMenuItem_Click);
            // 
            // buscarEstudianteToolStripMenuItem
            // 
            this.buscarEstudianteToolStripMenuItem.Image = global::AdapterPatern.Properties.Resources.search;
            this.buscarEstudianteToolStripMenuItem.Name = "buscarEstudianteToolStripMenuItem";
            this.buscarEstudianteToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.buscarEstudianteToolStripMenuItem.Text = "Search Student";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = global::AdapterPatern.Properties.Resources.shutdown;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.salirToolStripMenuItem.Text = "Close";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 409);
            this.Controls.Add(this.Menu2);
            this.Controls.Add(this.Menu1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Menu1.ResumeLayout(false);
            this.Menu1.PerformLayout();
            this.Menu2.ResumeLayout(false);
            this.Menu2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip Menu1;
        private System.Windows.Forms.ToolStripDropDownButton label1;
        private System.Windows.Forms.ToolStripMenuItem buscarEstudianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStrip Menu2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripMenuItem nuevoEstudianteToolStripMenuItem;
    }
}

