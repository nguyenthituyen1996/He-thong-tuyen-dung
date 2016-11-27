namespace ChuongtrinhQuayso
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
            this.lb1 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lbKetqua = new System.Windows.Forms.Label();
            this.btPlay = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(73, 34);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(115, 111);
            this.lb1.TabIndex = 0;
            this.lb1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb3
            // 
            this.lb3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb3.Location = new System.Drawing.Point(427, 34);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(115, 111);
            this.lb3.TabIndex = 1;
            this.lb3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb2
            // 
            this.lb2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.Location = new System.Drawing.Point(246, 34);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(115, 111);
            this.lb2.TabIndex = 2;
            this.lb2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbKetqua
            // 
            this.lbKetqua.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbKetqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKetqua.Location = new System.Drawing.Point(70, 199);
            this.lbKetqua.Name = "lbKetqua";
            this.lbKetqua.Size = new System.Drawing.Size(471, 82);
            this.lbKetqua.TabIndex = 3;
            this.lbKetqua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btPlay
            // 
            this.btPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPlay.Location = new System.Drawing.Point(108, 352);
            this.btPlay.Name = "btPlay";
            this.btPlay.Size = new System.Drawing.Size(106, 55);
            this.btPlay.TabIndex = 4;
            this.btPlay.Text = "Play";
            this.btPlay.UseVisualStyleBackColor = true;
            this.btPlay.Click += new System.EventHandler(this.button1_Click);
            // 
            // btExit
            // 
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btExit.Location = new System.Drawing.Point(405, 352);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(106, 55);
            this.btExit.TabIndex = 5;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 546);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btPlay);
            this.Controls.Add(this.lbKetqua);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.lb1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lbKetqua;
        private System.Windows.Forms.Button btPlay;
        private System.Windows.Forms.Button btExit;
    }
}

