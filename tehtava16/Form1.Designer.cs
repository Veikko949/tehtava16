namespace tehtava16
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ajastin_label = new System.Windows.Forms.Label();
            this.sekuntti_comboBox = new System.Windows.Forms.ComboBox();
            this.minuuti_comboBox = new System.Windows.Forms.ComboBox();
            this.aloita_button = new System.Windows.Forms.Button();
            this.lopeta_button = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minuuti";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sekuntti";
            // 
            // ajastin_label
            // 
            this.ajastin_label.AutoSize = true;
            this.ajastin_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajastin_label.Location = new System.Drawing.Point(30, 76);
            this.ajastin_label.Name = "ajastin_label";
            this.ajastin_label.Size = new System.Drawing.Size(194, 73);
            this.ajastin_label.TabIndex = 2;
            this.ajastin_label.Text = "00:00";
            // 
            // sekuntti_comboBox
            // 
            this.sekuntti_comboBox.FormattingEnabled = true;
            this.sekuntti_comboBox.Location = new System.Drawing.Point(138, 49);
            this.sekuntti_comboBox.Name = "sekuntti_comboBox";
            this.sekuntti_comboBox.Size = new System.Drawing.Size(85, 21);
            this.sekuntti_comboBox.TabIndex = 4;
            // 
            // minuuti_comboBox
            // 
            this.minuuti_comboBox.FormattingEnabled = true;
            this.minuuti_comboBox.Location = new System.Drawing.Point(35, 49);
            this.minuuti_comboBox.Name = "minuuti_comboBox";
            this.minuuti_comboBox.Size = new System.Drawing.Size(77, 21);
            this.minuuti_comboBox.TabIndex = 6;
            // 
            // aloita_button
            // 
            this.aloita_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aloita_button.Location = new System.Drawing.Point(35, 162);
            this.aloita_button.Name = "aloita_button";
            this.aloita_button.Size = new System.Drawing.Size(85, 35);
            this.aloita_button.TabIndex = 7;
            this.aloita_button.Text = "Start";
            this.aloita_button.UseVisualStyleBackColor = true;
            this.aloita_button.Click += new System.EventHandler(this.aloita_button_Click);
            // 
            // lopeta_button
            // 
            this.lopeta_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lopeta_button.Location = new System.Drawing.Point(136, 162);
            this.lopeta_button.Name = "lopeta_button";
            this.lopeta_button.Size = new System.Drawing.Size(85, 35);
            this.lopeta_button.TabIndex = 8;
            this.lopeta_button.Text = "Stop";
            this.lopeta_button.UseVisualStyleBackColor = true;
            this.lopeta_button.Click += new System.EventHandler(this.lopeta_button_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.ajastin_timer);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 232);
            this.Controls.Add(this.lopeta_button);
            this.Controls.Add(this.aloita_button);
            this.Controls.Add(this.minuuti_comboBox);
            this.Controls.Add(this.sekuntti_comboBox);
            this.Controls.Add(this.ajastin_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ajastin_label;
        private System.Windows.Forms.ComboBox sekuntti_comboBox;
        private System.Windows.Forms.ComboBox minuuti_comboBox;
        private System.Windows.Forms.Button aloita_button;
        private System.Windows.Forms.Button lopeta_button;
        private System.Windows.Forms.Timer timer1;
    }
}

