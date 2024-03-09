
namespace ProjetoABC
{
    partial class pctSplash
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pctSplash));
            this.prgimage = new System.Windows.Forms.PictureBox();
            this.pgbSplash = new System.Windows.Forms.ProgressBar();
            this.lbl = new System.Windows.Forms.Label();
            this.lblporce = new System.Windows.Forms.Label();
            this.btnEntrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.prgimage)).BeginInit();
            this.SuspendLayout();
            // 
            // prgimage
            // 
            this.prgimage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.prgimage.Image = ((System.Drawing.Image)(resources.GetObject("prgimage.Image")));
            this.prgimage.Location = new System.Drawing.Point(240, 112);
            this.prgimage.Name = "prgimage";
            this.prgimage.Size = new System.Drawing.Size(300, 225);
            this.prgimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.prgimage.TabIndex = 0;
            this.prgimage.TabStop = false;
            // 
            // pgbSplash
            // 
            this.pgbSplash.Location = new System.Drawing.Point(240, 399);
            this.pgbSplash.Name = "pgbSplash";
            this.pgbSplash.Size = new System.Drawing.Size(300, 32);
            this.pgbSplash.TabIndex = 1;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(376, 372);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(20, 24);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "0";
            this.lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblporce
            // 
            this.lblporce.AutoSize = true;
            this.lblporce.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblporce.Location = new System.Drawing.Point(390, 372);
            this.lblporce.Name = "lblporce";
            this.lblporce.Size = new System.Drawing.Size(25, 24);
            this.lblporce.TabIndex = 3;
            this.lblporce.Text = "%";
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(623, 490);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(124, 59);
            this.btnEntrar.TabIndex = 4;
            this.btnEntrar.Text = "entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // pctSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.lblporce);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.pgbSplash);
            this.Controls.Add(this.prgimage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "pctSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "loja ABC-Splash";
            ((System.ComponentModel.ISupportInitialize)(this.prgimage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox prgimage;
        private System.Windows.Forms.ProgressBar pgbSplash;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblporce;
        private System.Windows.Forms.Button btnEntrar;
    }
}