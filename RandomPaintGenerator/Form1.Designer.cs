namespace RandomPaintGenerator
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
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_OK = new System.Windows.Forms.Button();
            this.textBox_WindowWidth = new System.Windows.Forms.TextBox();
            this.label_Width = new System.Windows.Forms.Label();
            this.label_Height = new System.Windows.Forms.Label();
            this.textBox_WindowHeight = new System.Windows.Forms.TextBox();
            this.trackBar_AlphaValue = new System.Windows.Forms.TrackBar();
            this.label_Alpha = new System.Windows.Forms.Label();
            this.lable_AlphaValue = new System.Windows.Forms.Label();
            this.label_RedValue = new System.Windows.Forms.Label();
            this.label_Red = new System.Windows.Forms.Label();
            this.trackBar_RedValue = new System.Windows.Forms.TrackBar();
            this.label_GreenValue = new System.Windows.Forms.Label();
            this.label_Green = new System.Windows.Forms.Label();
            this.trackBar_GreenValue = new System.Windows.Forms.TrackBar();
            this.label_BlueValue = new System.Windows.Forms.Label();
            this.label_Blue = new System.Windows.Forms.Label();
            this.trackBar_BlueValue = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_AlphaValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_RedValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_GreenValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_BlueValue)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(93, 388);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 0;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(12, 388);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 23);
            this.button_OK.TabIndex = 1;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // textBox_WindowWidth
            // 
            this.textBox_WindowWidth.Location = new System.Drawing.Point(12, 31);
            this.textBox_WindowWidth.Name = "textBox_WindowWidth";
            this.textBox_WindowWidth.Size = new System.Drawing.Size(100, 20);
            this.textBox_WindowWidth.TabIndex = 2;
            // 
            // label_Width
            // 
            this.label_Width.AutoSize = true;
            this.label_Width.Location = new System.Drawing.Point(12, 15);
            this.label_Width.Name = "label_Width";
            this.label_Width.Size = new System.Drawing.Size(35, 13);
            this.label_Width.TabIndex = 3;
            this.label_Width.Text = "Width";
            // 
            // label_Height
            // 
            this.label_Height.AutoSize = true;
            this.label_Height.Location = new System.Drawing.Point(118, 15);
            this.label_Height.Name = "label_Height";
            this.label_Height.Size = new System.Drawing.Size(38, 13);
            this.label_Height.TabIndex = 5;
            this.label_Height.Text = "Height";
            // 
            // textBox_WindowHeight
            // 
            this.textBox_WindowHeight.Location = new System.Drawing.Point(118, 31);
            this.textBox_WindowHeight.Name = "textBox_WindowHeight";
            this.textBox_WindowHeight.Size = new System.Drawing.Size(100, 20);
            this.textBox_WindowHeight.TabIndex = 4;
            // 
            // trackBar_AlphaValue
            // 
            this.trackBar_AlphaValue.BackColor = System.Drawing.SystemColors.Menu;
            this.trackBar_AlphaValue.Location = new System.Drawing.Point(12, 113);
            this.trackBar_AlphaValue.Maximum = 256;
            this.trackBar_AlphaValue.Value = 256;
            this.trackBar_AlphaValue.Name = "trackBar_AlphaValue";
            this.trackBar_AlphaValue.Size = new System.Drawing.Size(291, 45);
            this.trackBar_AlphaValue.TabIndex = 6;
            this.trackBar_AlphaValue.TickFrequency = 10;
            this.trackBar_AlphaValue.Scroll += new System.EventHandler(this.trackBar_AlphaValue_Scroll);
            // 
            // label_Alpha
            // 
            this.label_Alpha.AutoSize = true;
            this.label_Alpha.Location = new System.Drawing.Point(12, 97);
            this.label_Alpha.Name = "label_Alpha";
            this.label_Alpha.Size = new System.Drawing.Size(34, 13);
            this.label_Alpha.TabIndex = 7;
            this.label_Alpha.Text = "Alpha";
            // 
            // lable_AlphaValue
            // 
            this.lable_AlphaValue.AutoSize = true;
            this.lable_AlphaValue.Location = new System.Drawing.Point(309, 125);
            this.lable_AlphaValue.Name = "lable_AlphaValue";
            this.lable_AlphaValue.Size = new System.Drawing.Size(13, 13);
            this.lable_AlphaValue.TabIndex = 8;
            this.lable_AlphaValue.Text = "256";
            // 
            // label_RedValue
            // 
            this.label_RedValue.AutoSize = true;
            this.label_RedValue.Location = new System.Drawing.Point(309, 176);
            this.label_RedValue.Name = "label_RedValue";
            this.label_RedValue.Size = new System.Drawing.Size(13, 13);
            this.label_RedValue.TabIndex = 11;
            this.label_RedValue.Text = "256";
            // 
            // label_Red
            // 
            this.label_Red.AutoSize = true;
            this.label_Red.Location = new System.Drawing.Point(12, 148);
            this.label_Red.Name = "label_Red";
            this.label_Red.Size = new System.Drawing.Size(27, 13);
            this.label_Red.TabIndex = 10;
            this.label_Red.Text = "Red";
            // 
            // trackBar_RedValue
            // 
            this.trackBar_RedValue.BackColor = System.Drawing.SystemColors.Menu;
            this.trackBar_RedValue.Location = new System.Drawing.Point(12, 164);
            this.trackBar_RedValue.Maximum = 256;
            this.trackBar_RedValue.Value = 256;
            this.trackBar_RedValue.Name = "trackBar_RedValue";
            this.trackBar_RedValue.Size = new System.Drawing.Size(291, 45);
            this.trackBar_RedValue.TabIndex = 9;
            this.trackBar_RedValue.TickFrequency = 10;
            this.trackBar_RedValue.Scroll += new System.EventHandler(this.trackBar_RedValue_Scroll);
            // 
            // label_GreenValue
            // 
            this.label_GreenValue.AutoSize = true;
            this.label_GreenValue.Location = new System.Drawing.Point(309, 227);
            this.label_GreenValue.Name = "label_GreenValue";
            this.label_GreenValue.Size = new System.Drawing.Size(13, 13);
            this.label_GreenValue.TabIndex = 14;
            this.label_GreenValue.Text = "256";
            // 
            // label_Green
            // 
            this.label_Green.AutoSize = true;
            this.label_Green.Location = new System.Drawing.Point(12, 199);
            this.label_Green.Name = "label_Green";
            this.label_Green.Size = new System.Drawing.Size(36, 13);
            this.label_Green.TabIndex = 13;
            this.label_Green.Text = "Green";
            // 
            // trackBar_GreenValue
            // 
            this.trackBar_GreenValue.BackColor = System.Drawing.SystemColors.Menu;
            this.trackBar_GreenValue.Location = new System.Drawing.Point(12, 215);
            this.trackBar_GreenValue.Maximum = 256;
            this.trackBar_GreenValue.Value = 256;
            this.trackBar_GreenValue.Name = "trackBar_GreenValue";
            this.trackBar_GreenValue.Size = new System.Drawing.Size(291, 45);
            this.trackBar_GreenValue.TabIndex = 12;
            this.trackBar_GreenValue.TickFrequency = 10;
            this.trackBar_GreenValue.Scroll += new System.EventHandler(this.trackBar_GreenValue_Scroll);
            // 
            // label_BlueValue
            // 
            this.label_BlueValue.AutoSize = true;
            this.label_BlueValue.Location = new System.Drawing.Point(309, 278);
            this.label_BlueValue.Name = "label_BlueValue";
            this.label_BlueValue.Size = new System.Drawing.Size(13, 13);
            this.label_BlueValue.TabIndex = 17;
            this.label_BlueValue.Text = "256";
            // 
            // label_Blue
            // 
            this.label_Blue.AutoSize = true;
            this.label_Blue.Location = new System.Drawing.Point(12, 250);
            this.label_Blue.Name = "label_Blue";
            this.label_Blue.Size = new System.Drawing.Size(28, 13);
            this.label_Blue.TabIndex = 16;
            this.label_Blue.Text = "Blue";
            // 
            // trackBar_BlueValue
            // 
            this.trackBar_BlueValue.BackColor = System.Drawing.SystemColors.Menu;
            this.trackBar_BlueValue.Location = new System.Drawing.Point(12, 266);
            this.trackBar_BlueValue.Maximum = 256;
            this.trackBar_BlueValue.Value = 256;
            this.trackBar_BlueValue.Name = "trackBar_BlueValue";
            this.trackBar_BlueValue.Size = new System.Drawing.Size(291, 45);
            this.trackBar_BlueValue.TabIndex = 15;
            this.trackBar_BlueValue.TickFrequency = 10;
            this.trackBar_BlueValue.Scroll += new System.EventHandler(this.trackBar_BlueValue_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 423);
            this.Controls.Add(this.label_BlueValue);
            this.Controls.Add(this.label_Blue);
            this.Controls.Add(this.trackBar_BlueValue);
            this.Controls.Add(this.label_GreenValue);
            this.Controls.Add(this.label_Green);
            this.Controls.Add(this.trackBar_GreenValue);
            this.Controls.Add(this.label_RedValue);
            this.Controls.Add(this.label_Red);
            this.Controls.Add(this.trackBar_RedValue);
            this.Controls.Add(this.lable_AlphaValue);
            this.Controls.Add(this.label_Alpha);
            this.Controls.Add(this.trackBar_AlphaValue);
            this.Controls.Add(this.label_Height);
            this.Controls.Add(this.textBox_WindowHeight);
            this.Controls.Add(this.label_Width);
            this.Controls.Add(this.textBox_WindowWidth);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.button_Cancel);
            this.Name = "Form1";
            this.Text = "Paint Random Generator";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_AlphaValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_RedValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_GreenValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_BlueValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.TextBox textBox_WindowWidth;
        private System.Windows.Forms.Label label_Width;
        private System.Windows.Forms.Label label_Height;
        private System.Windows.Forms.TextBox textBox_WindowHeight;
        private System.Windows.Forms.TrackBar trackBar_AlphaValue;
        private System.Windows.Forms.Label label_Alpha;
        private System.Windows.Forms.Label lable_AlphaValue;
        private System.Windows.Forms.Label label_RedValue;
        private System.Windows.Forms.Label label_Red;
        private System.Windows.Forms.TrackBar trackBar_RedValue;
        private System.Windows.Forms.Label label_GreenValue;
        private System.Windows.Forms.Label label_Green;
        private System.Windows.Forms.TrackBar trackBar_GreenValue;
        private System.Windows.Forms.Label label_BlueValue;
        private System.Windows.Forms.Label label_Blue;
        private System.Windows.Forms.TrackBar trackBar_BlueValue;
    }
}

