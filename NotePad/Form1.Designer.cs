namespace NotePad
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.acrhivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDeTextoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rojoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.azulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.amarilloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verdeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moradoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blancoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDeFondoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rojoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.azulToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.amarilloToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.verdeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acrhivoToolStripMenuItem,
            this.opcionesToolStripMenuItem,
            this.zoomToolStripMenuItem,
            this.zoomToolStripMenuItem1,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(472, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // acrhivoToolStripMenuItem
            // 
            this.acrhivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.acrhivoToolStripMenuItem.Name = "acrhivoToolStripMenuItem";
            this.acrhivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.acrhivoToolStripMenuItem.Text = "Acrhivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fuenteToolStripMenuItem,
            this.colorDeTextoToolStripMenuItem,
            this.colorDeFondoToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // fuenteToolStripMenuItem
            // 
            this.fuenteToolStripMenuItem.Name = "fuenteToolStripMenuItem";
            this.fuenteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fuenteToolStripMenuItem.Text = "Fuente";
            // 
            // colorDeTextoToolStripMenuItem
            // 
            this.colorDeTextoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.negroToolStripMenuItem,
            this.rojoToolStripMenuItem,
            this.azulToolStripMenuItem,
            this.amarilloToolStripMenuItem,
            this.verdeToolStripMenuItem,
            this.moradoToolStripMenuItem,
            this.grisToolStripMenuItem,
            this.blancoToolStripMenuItem});
            this.colorDeTextoToolStripMenuItem.Name = "colorDeTextoToolStripMenuItem";
            this.colorDeTextoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colorDeTextoToolStripMenuItem.Text = "Color de Texto";
            // 
            // negroToolStripMenuItem
            // 
            this.negroToolStripMenuItem.Name = "negroToolStripMenuItem";
            this.negroToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.negroToolStripMenuItem.Text = "Negro";
            // 
            // rojoToolStripMenuItem
            // 
            this.rojoToolStripMenuItem.Name = "rojoToolStripMenuItem";
            this.rojoToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.rojoToolStripMenuItem.Text = "Rojo";
            // 
            // azulToolStripMenuItem
            // 
            this.azulToolStripMenuItem.Name = "azulToolStripMenuItem";
            this.azulToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.azulToolStripMenuItem.Text = "Azul";
            // 
            // amarilloToolStripMenuItem
            // 
            this.amarilloToolStripMenuItem.Name = "amarilloToolStripMenuItem";
            this.amarilloToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.amarilloToolStripMenuItem.Text = "Amarillo";
            // 
            // verdeToolStripMenuItem
            // 
            this.verdeToolStripMenuItem.Name = "verdeToolStripMenuItem";
            this.verdeToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.verdeToolStripMenuItem.Text = "Verde";
            // 
            // moradoToolStripMenuItem
            // 
            this.moradoToolStripMenuItem.Name = "moradoToolStripMenuItem";
            this.moradoToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.moradoToolStripMenuItem.Text = "Morado";
            // 
            // grisToolStripMenuItem
            // 
            this.grisToolStripMenuItem.Name = "grisToolStripMenuItem";
            this.grisToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.grisToolStripMenuItem.Text = "Gris";
            // 
            // blancoToolStripMenuItem
            // 
            this.blancoToolStripMenuItem.Name = "blancoToolStripMenuItem";
            this.blancoToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.blancoToolStripMenuItem.Text = "Blanco";
            // 
            // colorDeFondoToolStripMenuItem
            // 
            this.colorDeFondoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.negroToolStripMenuItem1,
            this.rojoToolStripMenuItem1,
            this.azulToolStripMenuItem1,
            this.amarilloToolStripMenuItem1,
            this.verdeToolStripMenuItem1});
            this.colorDeFondoToolStripMenuItem.Name = "colorDeFondoToolStripMenuItem";
            this.colorDeFondoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colorDeFondoToolStripMenuItem.Text = "Color de Fondo";
            // 
            // negroToolStripMenuItem1
            // 
            this.negroToolStripMenuItem1.Name = "negroToolStripMenuItem1";
            this.negroToolStripMenuItem1.Size = new System.Drawing.Size(119, 22);
            this.negroToolStripMenuItem1.Text = "Negro";
            // 
            // rojoToolStripMenuItem1
            // 
            this.rojoToolStripMenuItem1.Name = "rojoToolStripMenuItem1";
            this.rojoToolStripMenuItem1.Size = new System.Drawing.Size(119, 22);
            this.rojoToolStripMenuItem1.Text = "Rojo";
            // 
            // azulToolStripMenuItem1
            // 
            this.azulToolStripMenuItem1.Name = "azulToolStripMenuItem1";
            this.azulToolStripMenuItem1.Size = new System.Drawing.Size(119, 22);
            this.azulToolStripMenuItem1.Text = "Azul";
            // 
            // amarilloToolStripMenuItem1
            // 
            this.amarilloToolStripMenuItem1.Name = "amarilloToolStripMenuItem1";
            this.amarilloToolStripMenuItem1.Size = new System.Drawing.Size(119, 22);
            this.amarilloToolStripMenuItem1.Text = "Amarillo";
            // 
            // verdeToolStripMenuItem1
            // 
            this.verdeToolStripMenuItem1.Name = "verdeToolStripMenuItem1";
            this.verdeToolStripMenuItem1.Size = new System.Drawing.Size(119, 22);
            this.verdeToolStripMenuItem1.Text = "Verde";
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.zoomToolStripMenuItem.Text = "Zoom +";
            // 
            // zoomToolStripMenuItem1
            // 
            this.zoomToolStripMenuItem1.Name = "zoomToolStripMenuItem1";
            this.zoomToolStripMenuItem1.Size = new System.Drawing.Size(59, 20);
            this.zoomToolStripMenuItem1.Text = "Zoom -";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 27);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(472, 280);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 304);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem acrhivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fuenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorDeTextoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rojoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem azulToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem amarilloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verdeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moradoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blancoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorDeFondoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negroToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rojoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem azulToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem amarilloToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem verdeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

