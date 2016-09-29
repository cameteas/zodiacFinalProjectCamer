namespace zodiacFinalProjectCamer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.title = new System.Windows.Forms.Label();
            this.prompt = new System.Windows.Forms.Label();
            this.ram = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ram)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Adobe Caslon Pro", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Yellow;
            this.title.Location = new System.Drawing.Point(224, 66);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(185, 109);
            this.title.TabIndex = 0;
            this.title.Text = "Aries";
            // 
            // prompt
            // 
            this.prompt.AutoSize = true;
            this.prompt.Font = new System.Drawing.Font("Adobe Kaiti Std R", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prompt.ForeColor = System.Drawing.Color.Yellow;
            this.prompt.Location = new System.Drawing.Point(185, 412);
            this.prompt.Name = "prompt";
            this.prompt.Size = new System.Drawing.Size(412, 40);
            this.prompt.TabIndex = 1;
            this.prompt.Text = "Made By Cameron Teasdale";
            this.prompt.UseMnemonic = false;
            // 
            // ram
            // 
            this.ram.Image = global::zodiacFinalProjectCamer.Properties.Resources.ram;
            this.ram.Location = new System.Drawing.Point(203, 178);
            this.ram.Name = "ram";
            this.ram.Size = new System.Drawing.Size(238, 166);
            this.ram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ram.TabIndex = 2;
            this.ram.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.ram);
            this.Controls.Add(this.prompt);
            this.Controls.Add(this.title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Aries by Cameron Teasdale";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.ram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label prompt;
        private System.Windows.Forms.PictureBox ram;
    }
}

