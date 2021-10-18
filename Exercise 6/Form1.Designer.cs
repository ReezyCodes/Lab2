
namespace Exercise_6
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
            this.textBoxSerialDataStream = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.textBoxQueueSize = new System.Windows.Forms.TextBox();
            this.textBoxSerialBuffer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxCombo = new System.Windows.Forms.TextBox();
            this.textBoxMSB = new System.Windows.Forms.TextBox();
            this.textBoxLSB = new System.Windows.Forms.TextBox();
            this.textBoxThermo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxSerialDataStream
            // 
            this.textBoxSerialDataStream.Location = new System.Drawing.Point(16, 112);
            this.textBoxSerialDataStream.Multiline = true;
            this.textBoxSerialDataStream.Name = "textBoxSerialDataStream";
            this.textBoxSerialDataStream.Size = new System.Drawing.Size(298, 199);
            this.textBoxSerialDataStream.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Data History";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // serialPort2
            // 
            this.serialPort2.PortName = "COM3";
            this.serialPort2.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort2_DataReceived);
            // 
            // textBoxQueueSize
            // 
            this.textBoxQueueSize.Location = new System.Drawing.Point(108, 315);
            this.textBoxQueueSize.Name = "textBoxQueueSize";
            this.textBoxQueueSize.Size = new System.Drawing.Size(53, 20);
            this.textBoxQueueSize.TabIndex = 26;
            // 
            // textBoxSerialBuffer
            // 
            this.textBoxSerialBuffer.Location = new System.Drawing.Point(108, 337);
            this.textBoxSerialBuffer.Name = "textBoxSerialBuffer";
            this.textBoxSerialBuffer.Size = new System.Drawing.Size(53, 20);
            this.textBoxSerialBuffer.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Queue Count";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 339);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Serial Buffer Size";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 38);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 35);
            this.button1.TabIndex = 35;
            this.button1.Text = "Connect Serial";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxCombo
            // 
            this.textBoxCombo.Location = new System.Drawing.Point(108, 425);
            this.textBoxCombo.Name = "textBoxCombo";
            this.textBoxCombo.Size = new System.Drawing.Size(145, 20);
            this.textBoxCombo.TabIndex = 36;
            // 
            // textBoxMSB
            // 
            this.textBoxMSB.Location = new System.Drawing.Point(108, 373);
            this.textBoxMSB.Name = "textBoxMSB";
            this.textBoxMSB.Size = new System.Drawing.Size(145, 20);
            this.textBoxMSB.TabIndex = 37;
            // 
            // textBoxLSB
            // 
            this.textBoxLSB.Location = new System.Drawing.Point(108, 399);
            this.textBoxLSB.Name = "textBoxLSB";
            this.textBoxLSB.Size = new System.Drawing.Size(145, 20);
            this.textBoxLSB.TabIndex = 38;
            // 
            // textBoxThermo
            // 
            this.textBoxThermo.Location = new System.Drawing.Point(108, 451);
            this.textBoxThermo.Name = "textBoxThermo";
            this.textBoxThermo.Size = new System.Drawing.Size(145, 20);
            this.textBoxThermo.TabIndex = 39;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 503);
            this.Controls.Add(this.textBoxThermo);
            this.Controls.Add(this.textBoxLSB);
            this.Controls.Add(this.textBoxMSB);
            this.Controls.Add(this.textBoxCombo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSerialBuffer);
            this.Controls.Add(this.textBoxQueueSize);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxSerialDataStream);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxSerialDataStream;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.TextBox textBoxQueueSize;
        private System.Windows.Forms.TextBox textBoxSerialBuffer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxCombo;
        private System.Windows.Forms.TextBox textBoxMSB;
        private System.Windows.Forms.TextBox textBoxLSB;
        private System.Windows.Forms.TextBox textBoxThermo;
    }
}

