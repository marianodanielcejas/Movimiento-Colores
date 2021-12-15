
namespace Choque_Colores
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
            this.lblActorRojo = new System.Windows.Forms.Label();
            this.btMover = new System.Windows.Forms.Button();
            this.btPosición = new System.Windows.Forms.Button();
            this.lblActorAzul = new System.Windows.Forms.Label();
            this.lblActorAmarillo = new System.Windows.Forms.Label();
            this.lblActorVerde = new System.Windows.Forms.Label();
            this.btArribaAbajo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblActorRojo
            // 
            this.lblActorRojo.BackColor = System.Drawing.Color.Red;
            this.lblActorRojo.Location = new System.Drawing.Point(53, 163);
            this.lblActorRojo.Name = "lblActorRojo";
            this.lblActorRojo.Size = new System.Drawing.Size(50, 50);
            this.lblActorRojo.TabIndex = 0;
            this.lblActorRojo.Visible = false;
            // 
            // btMover
            // 
            this.btMover.Location = new System.Drawing.Point(353, 43);
            this.btMover.Name = "btMover";
            this.btMover.Size = new System.Drawing.Size(75, 23);
            this.btMover.TabIndex = 2;
            this.btMover.Text = "Mover";
            this.btMover.UseVisualStyleBackColor = true;
            this.btMover.Click += new System.EventHandler(this.btMover_Click);
            // 
            // btPosición
            // 
            this.btPosición.Location = new System.Drawing.Point(165, 43);
            this.btPosición.Name = "btPosición";
            this.btPosición.Size = new System.Drawing.Size(75, 23);
            this.btPosición.TabIndex = 1;
            this.btPosición.Text = "Posición";
            this.btPosición.UseVisualStyleBackColor = true;
            this.btPosición.Click += new System.EventHandler(this.btPosición_Click);
            // 
            // lblActorAzul
            // 
            this.lblActorAzul.BackColor = System.Drawing.Color.Blue;
            this.lblActorAzul.Location = new System.Drawing.Point(688, 163);
            this.lblActorAzul.Name = "lblActorAzul";
            this.lblActorAzul.Size = new System.Drawing.Size(50, 50);
            this.lblActorAzul.TabIndex = 3;
            this.lblActorAzul.Visible = false;
            // 
            // lblActorAmarillo
            // 
            this.lblActorAmarillo.BackColor = System.Drawing.Color.Yellow;
            this.lblActorAmarillo.Location = new System.Drawing.Point(53, 213);
            this.lblActorAmarillo.Name = "lblActorAmarillo";
            this.lblActorAmarillo.Size = new System.Drawing.Size(50, 50);
            this.lblActorAmarillo.TabIndex = 4;
            this.lblActorAmarillo.Visible = false;
            // 
            // lblActorVerde
            // 
            this.lblActorVerde.BackColor = System.Drawing.Color.Lime;
            this.lblActorVerde.Location = new System.Drawing.Point(688, 213);
            this.lblActorVerde.Name = "lblActorVerde";
            this.lblActorVerde.Size = new System.Drawing.Size(50, 50);
            this.lblActorVerde.TabIndex = 5;
            this.lblActorVerde.Visible = false;
            // 
            // btArribaAbajo
            // 
            this.btArribaAbajo.Location = new System.Drawing.Point(521, 43);
            this.btArribaAbajo.Name = "btArribaAbajo";
            this.btArribaAbajo.Size = new System.Drawing.Size(75, 23);
            this.btArribaAbajo.TabIndex = 3;
            this.btArribaAbajo.Text = "Vertical";
            this.btArribaAbajo.UseVisualStyleBackColor = true;
            this.btArribaAbajo.Click += new System.EventHandler(this.btArribaAbajo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btArribaAbajo);
            this.Controls.Add(this.lblActorVerde);
            this.Controls.Add(this.lblActorAmarillo);
            this.Controls.Add(this.lblActorAzul);
            this.Controls.Add(this.btPosición);
            this.Controls.Add(this.btMover);
            this.Controls.Add(this.lblActorRojo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblActorRojo;
        private System.Windows.Forms.Button btMover;
        private System.Windows.Forms.Button btPosición;
        private System.Windows.Forms.Label lblActorAzul;
        private System.Windows.Forms.Label lblActorAmarillo;
        private System.Windows.Forms.Label lblActorVerde;
        private System.Windows.Forms.Button btArribaAbajo;
    }
}

