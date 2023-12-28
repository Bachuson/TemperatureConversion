namespace TemperatureConversion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_farhenheight = new System.Windows.Forms.TextBox();
            this.txt_celsius = new System.Windows.Forms.TextBox();
            this.txt_kelvin = new System.Windows.Forms.TextBox();
            this.btn_farhenheight = new System.Windows.Forms.Button();
            this.btn_celsius = new System.Windows.Forms.Button();
            this.btn_kelvin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(45, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Farhenheight";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(45, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Celsius";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(45, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kelvin";
            // 
            // txt_farhenheight
            // 
            this.txt_farhenheight.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_farhenheight.Location = new System.Drawing.Point(209, 44);
            this.txt_farhenheight.Name = "txt_farhenheight";
            this.txt_farhenheight.Size = new System.Drawing.Size(181, 32);
            this.txt_farhenheight.TabIndex = 3;
            this.txt_farhenheight.TextChanged += new System.EventHandler(this.onTextChange);
            // 
            // txt_celsius
            // 
            this.txt_celsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_celsius.Location = new System.Drawing.Point(209, 91);
            this.txt_celsius.Name = "txt_celsius";
            this.txt_celsius.Size = new System.Drawing.Size(181, 32);
            this.txt_celsius.TabIndex = 4;
            // 
            // txt_kelvin
            // 
            this.txt_kelvin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_kelvin.Location = new System.Drawing.Point(209, 138);
            this.txt_kelvin.Name = "txt_kelvin";
            this.txt_kelvin.Size = new System.Drawing.Size(181, 32);
            this.txt_kelvin.TabIndex = 5;
            // 
            // btn_farhenheight
            // 
            this.btn_farhenheight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_farhenheight.Location = new System.Drawing.Point(413, 44);
            this.btn_farhenheight.Name = "btn_farhenheight";
            this.btn_farhenheight.Size = new System.Drawing.Size(97, 32);
            this.btn_farhenheight.TabIndex = 6;
            this.btn_farhenheight.Text = "Convert";
            this.btn_farhenheight.UseVisualStyleBackColor = true;
            this.btn_farhenheight.Click += new System.EventHandler(this.btn_farhenheight_Click);
            // 
            // btn_celsius
            // 
            this.btn_celsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_celsius.Location = new System.Drawing.Point(413, 91);
            this.btn_celsius.Name = "btn_celsius";
            this.btn_celsius.Size = new System.Drawing.Size(97, 32);
            this.btn_celsius.TabIndex = 7;
            this.btn_celsius.Text = "Convert";
            this.btn_celsius.UseVisualStyleBackColor = true;
            this.btn_celsius.Click += new System.EventHandler(this.btn_celsius_Click);
            // 
            // btn_kelvin
            // 
            this.btn_kelvin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_kelvin.Location = new System.Drawing.Point(413, 138);
            this.btn_kelvin.Name = "btn_kelvin";
            this.btn_kelvin.Size = new System.Drawing.Size(97, 32);
            this.btn_kelvin.TabIndex = 8;
            this.btn_kelvin.Text = "Convert";
            this.btn_kelvin.UseVisualStyleBackColor = true;
            this.btn_kelvin.Click += new System.EventHandler(this.btn_kelvin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(529, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 255);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_kelvin);
            this.Controls.Add(this.btn_celsius);
            this.Controls.Add(this.btn_farhenheight);
            this.Controls.Add(this.txt_kelvin);
            this.Controls.Add(this.txt_celsius);
            this.Controls.Add(this.txt_farhenheight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Konwertor BachuKinga";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_farhenheight;
        private System.Windows.Forms.TextBox txt_celsius;
        private System.Windows.Forms.TextBox txt_kelvin;
        private System.Windows.Forms.Button btn_farhenheight;
        private System.Windows.Forms.Button btn_celsius;
        private System.Windows.Forms.Button btn_kelvin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

