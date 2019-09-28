namespace mindruner2
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.pbdado2 = new System.Windows.Forms.PictureBox();
            this.pbdado1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbdado2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbdado1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Fuchsia;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(263, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 61);
            this.button1.TabIndex = 3;
            this.button1.Text = "Tirar dados";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // pbdado2
            // 
            this.pbdado2.Location = new System.Drawing.Point(397, 71);
            this.pbdado2.Name = "pbdado2";
            this.pbdado2.Size = new System.Drawing.Size(141, 121);
            this.pbdado2.TabIndex = 2;
            this.pbdado2.TabStop = false;
            // 
            // pbdado1
            // 
            this.pbdado1.Image = global::mindruner2.Properties.Resources.lado1;
            this.pbdado1.Location = new System.Drawing.Point(70, 71);
            this.pbdado1.Name = "pbdado1";
            this.pbdado1.Size = new System.Drawing.Size(141, 121);
            this.pbdado1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbdado1.TabIndex = 1;
            this.pbdado1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ClientSize = new System.Drawing.Size(619, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbdado2);
            this.Controls.Add(this.pbdado1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pbdado2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbdado1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbdado1;
        private System.Windows.Forms.PictureBox pbdado2;
        private System.Windows.Forms.Button button1;
    }
}