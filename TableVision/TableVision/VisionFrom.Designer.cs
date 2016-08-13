
namespace TableVision
{
    partial class VisionFrom
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
            this.backgroundImg = new Emgu.CV.UI.ImageBox();
            this.hpImg = new Emgu.CV.UI.ImageBox();
            this.lpImg = new Emgu.CV.UI.ImageBox();
            this.subtractImg = new Emgu.CV.UI.ImageBox();
            this.BackgroundLabel = new System.Windows.Forms.Label();
            this.subtractLabel = new System.Windows.Forms.Label();
            this.lowpassLabel = new System.Windows.Forms.Label();
            this.highpassLabel = new System.Windows.Forms.Label();
            this.bpImg = new Emgu.CV.UI.ImageBox();
            this.sourceImg = new Emgu.CV.UI.ImageBox();
            this.outputImg = new Emgu.CV.UI.ImageBox();
            this.bandpassLabel = new System.Windows.Forms.Label();
            this.sourceLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.lptrackBar = new System.Windows.Forms.TrackBar();
            this.hptrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.noisetrackBar = new System.Windows.Forms.TrackBar();
            this.AmptrackBar = new System.Windows.Forms.TrackBar();
            this.amplabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bvalue = new System.Windows.Forms.Label();
            this.nvalue = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.svalue = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tvalue = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ThresholdtrackBar = new System.Windows.Forms.TrackBar();
            this.thresholdvalue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hpImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lpImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subtractImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bpImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lptrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hptrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noisetrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmptrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThresholdtrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundImg
            // 
            this.backgroundImg.Location = new System.Drawing.Point(12, 374);
            this.backgroundImg.Name = "backgroundImg";
            this.backgroundImg.Size = new System.Drawing.Size(190, 166);
            this.backgroundImg.TabIndex = 2;
            this.backgroundImg.TabStop = false;
            // 
            // hpImg
            // 
            this.hpImg.Location = new System.Drawing.Point(600, 374);
            this.hpImg.Name = "hpImg";
            this.hpImg.Size = new System.Drawing.Size(190, 166);
            this.hpImg.TabIndex = 2;
            this.hpImg.TabStop = false;
            // 
            // lpImg
            // 
            this.lpImg.Location = new System.Drawing.Point(404, 374);
            this.lpImg.Name = "lpImg";
            this.lpImg.Size = new System.Drawing.Size(190, 166);
            this.lpImg.TabIndex = 3;
            this.lpImg.TabStop = false;
            // 
            // subtractImg
            // 
            this.subtractImg.Location = new System.Drawing.Point(208, 374);
            this.subtractImg.Name = "subtractImg";
            this.subtractImg.Size = new System.Drawing.Size(190, 166);
            this.subtractImg.TabIndex = 4;
            this.subtractImg.TabStop = false;
            // 
            // BackgroundLabel
            // 
            this.BackgroundLabel.AutoSize = true;
            this.BackgroundLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.BackgroundLabel.Location = new System.Drawing.Point(61, 351);
            this.BackgroundLabel.Name = "BackgroundLabel";
            this.BackgroundLabel.Size = new System.Drawing.Size(95, 20);
            this.BackgroundLabel.TabIndex = 6;
            this.BackgroundLabel.Text = "Background";
            // 
            // subtractLabel
            // 
            this.subtractLabel.AutoSize = true;
            this.subtractLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.subtractLabel.Location = new System.Drawing.Point(217, 351);
            this.subtractLabel.Name = "subtractLabel";
            this.subtractLabel.Size = new System.Drawing.Size(181, 20);
            this.subtractLabel.TabIndex = 7;
            this.subtractLabel.Text = "Background Subtraction";
            // 
            // lowpassLabel
            // 
            this.lowpassLabel.AutoSize = true;
            this.lowpassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lowpassLabel.Location = new System.Drawing.Point(437, 351);
            this.lowpassLabel.Name = "lowpassLabel";
            this.lowpassLabel.Size = new System.Drawing.Size(116, 20);
            this.lowpassLabel.TabIndex = 8;
            this.lowpassLabel.Text = "Low Pass Filter";
            // 
            // highpassLabel
            // 
            this.highpassLabel.AutoSize = true;
            this.highpassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.highpassLabel.Location = new System.Drawing.Point(638, 351);
            this.highpassLabel.Name = "highpassLabel";
            this.highpassLabel.Size = new System.Drawing.Size(120, 20);
            this.highpassLabel.TabIndex = 9;
            this.highpassLabel.Text = "High Pass Filter";
            // 
            // bpImg
            // 
            this.bpImg.Location = new System.Drawing.Point(797, 374);
            this.bpImg.Name = "bpImg";
            this.bpImg.Size = new System.Drawing.Size(190, 166);
            this.bpImg.TabIndex = 10;
            this.bpImg.TabStop = false;
            // 
            // sourceImg
            // 
            this.sourceImg.Location = new System.Drawing.Point(12, 44);
            this.sourceImg.Name = "sourceImg";
            this.sourceImg.Size = new System.Drawing.Size(416, 304);
            this.sourceImg.TabIndex = 11;
            this.sourceImg.TabStop = false;
            // 
            // outputImg
            // 
            this.outputImg.Location = new System.Drawing.Point(571, 44);
            this.outputImg.Name = "outputImg";
            this.outputImg.Size = new System.Drawing.Size(416, 304);
            this.outputImg.TabIndex = 12;
            this.outputImg.TabStop = false;
            // 
            // bandpassLabel
            // 
            this.bandpassLabel.AutoSize = true;
            this.bandpassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.bandpassLabel.Location = new System.Drawing.Point(856, 351);
            this.bandpassLabel.Name = "bandpassLabel";
            this.bandpassLabel.Size = new System.Drawing.Size(70, 20);
            this.bandpassLabel.TabIndex = 13;
            this.bandpassLabel.Text = "Ampilfier";
            // 
            // sourceLabel
            // 
            this.sourceLabel.AutoSize = true;
            this.sourceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.sourceLabel.Location = new System.Drawing.Point(180, 21);
            this.sourceLabel.Name = "sourceLabel";
            this.sourceLabel.Size = new System.Drawing.Size(60, 20);
            this.sourceLabel.TabIndex = 14;
            this.sourceLabel.Text = "Source";
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.outputLabel.Location = new System.Drawing.Point(757, 21);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(58, 20);
            this.outputLabel.TabIndex = 15;
            this.outputLabel.Text = "Output";
            // 
            // lptrackBar
            // 
            this.lptrackBar.LargeChange = 0;
            this.lptrackBar.Location = new System.Drawing.Point(1052, 106);
            this.lptrackBar.Maximum = 15;
            this.lptrackBar.Name = "lptrackBar";
            this.lptrackBar.Size = new System.Drawing.Size(237, 45);
            this.lptrackBar.SmallChange = 2;
            this.lptrackBar.TabIndex = 5;
            this.lptrackBar.TickFrequency = 2;
            this.lptrackBar.Value = 5;
            this.lptrackBar.Scroll += new System.EventHandler(this.lptrackBar_Scroll);
            // 
            // hptrackBar
            // 
            this.hptrackBar.LargeChange = 2;
            this.hptrackBar.Location = new System.Drawing.Point(1052, 179);
            this.hptrackBar.Maximum = 200;
            this.hptrackBar.Name = "hptrackBar";
            this.hptrackBar.Size = new System.Drawing.Size(237, 45);
            this.hptrackBar.TabIndex = 7;
            this.hptrackBar.TickFrequency = 2;
            this.hptrackBar.Value = 9;
            this.hptrackBar.Scroll += new System.EventHandler(this.hptrackBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(997, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Low Pass Filter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(993, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "High Pass Filter";
            // 
            // noisetrackBar
            // 
            this.noisetrackBar.LargeChange = 2;
            this.noisetrackBar.Location = new System.Drawing.Point(1052, 230);
            this.noisetrackBar.Maximum = 30;
            this.noisetrackBar.Name = "noisetrackBar";
            this.noisetrackBar.Size = new System.Drawing.Size(237, 45);
            this.noisetrackBar.TabIndex = 20;
            this.noisetrackBar.TickFrequency = 2;
            this.noisetrackBar.Value = 2;
            this.noisetrackBar.Scroll += new System.EventHandler(this.noisetrackBar_Scroll);
            // 
            // AmptrackBar
            // 
            this.AmptrackBar.LargeChange = 2;
            this.AmptrackBar.Location = new System.Drawing.Point(1052, 351);
            this.AmptrackBar.Maximum = 300;
            this.AmptrackBar.Name = "AmptrackBar";
            this.AmptrackBar.Size = new System.Drawing.Size(237, 45);
            this.AmptrackBar.TabIndex = 21;
            this.AmptrackBar.TickFrequency = 2;
            this.AmptrackBar.Value = 3;
            this.AmptrackBar.Scroll += new System.EventHandler(this.AmptrackBar_Scroll);
            // 
            // amplabel
            // 
            this.amplabel.AutoSize = true;
            this.amplabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.amplabel.Location = new System.Drawing.Point(993, 308);
            this.amplabel.Name = "amplabel";
            this.amplabel.Size = new System.Drawing.Size(70, 20);
            this.amplabel.TabIndex = 22;
            this.amplabel.Text = "Amplifier";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(1019, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Blur";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(1019, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Noise";
            // 
            // bvalue
            // 
            this.bvalue.AutoSize = true;
            this.bvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.bvalue.Location = new System.Drawing.Point(1284, 179);
            this.bvalue.Name = "bvalue";
            this.bvalue.Size = new System.Drawing.Size(18, 20);
            this.bvalue.TabIndex = 25;
            this.bvalue.Text = "9";
            // 
            // nvalue
            // 
            this.nvalue.AutoSize = true;
            this.nvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.nvalue.Location = new System.Drawing.Point(1284, 230);
            this.nvalue.Name = "nvalue";
            this.nvalue.Size = new System.Drawing.Size(18, 20);
            this.nvalue.TabIndex = 26;
            this.nvalue.Text = "2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(1014, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Smooth";
            // 
            // svalue
            // 
            this.svalue.AutoSize = true;
            this.svalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.svalue.Location = new System.Drawing.Point(1284, 106);
            this.svalue.Name = "svalue";
            this.svalue.Size = new System.Drawing.Size(18, 20);
            this.svalue.TabIndex = 28;
            this.svalue.Text = "5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.Location = new System.Drawing.Point(1019, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Amp";
            // 
            // tvalue
            // 
            this.tvalue.AutoSize = true;
            this.tvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tvalue.Location = new System.Drawing.Point(1284, 351);
            this.tvalue.Name = "tvalue";
            this.tvalue.Size = new System.Drawing.Size(18, 20);
            this.tvalue.TabIndex = 30;
            this.tvalue.Text = "3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label7.Location = new System.Drawing.Point(993, 399);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "Threshold";
            // 
            // ThresholdtrackBar
            // 
            this.ThresholdtrackBar.LargeChange = 2;
            this.ThresholdtrackBar.Location = new System.Drawing.Point(1052, 422);
            this.ThresholdtrackBar.Maximum = 127;
            this.ThresholdtrackBar.Name = "ThresholdtrackBar";
            this.ThresholdtrackBar.Size = new System.Drawing.Size(237, 45);
            this.ThresholdtrackBar.TabIndex = 32;
            this.ThresholdtrackBar.TickFrequency = 2;
            this.ThresholdtrackBar.Value = 94;
            this.ThresholdtrackBar.Scroll += new System.EventHandler(this.ThresholdtrackBar_Scroll);
            // 
            // thresholdvalue
            // 
            this.thresholdvalue.AutoSize = true;
            this.thresholdvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.thresholdvalue.Location = new System.Drawing.Point(1284, 422);
            this.thresholdvalue.Name = "thresholdvalue";
            this.thresholdvalue.Size = new System.Drawing.Size(36, 20);
            this.thresholdvalue.TabIndex = 33;
            this.thresholdvalue.Text = "189";
            // 
            // VisionFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 552);
            this.Controls.Add(this.thresholdvalue);
            this.Controls.Add(this.ThresholdtrackBar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tvalue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.svalue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nvalue);
            this.Controls.Add(this.bvalue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.amplabel);
            this.Controls.Add(this.AmptrackBar);
            this.Controls.Add(this.noisetrackBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hptrackBar);
            this.Controls.Add(this.lptrackBar);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.sourceLabel);
            this.Controls.Add(this.bandpassLabel);
            this.Controls.Add(this.outputImg);
            this.Controls.Add(this.sourceImg);
            this.Controls.Add(this.bpImg);
            this.Controls.Add(this.highpassLabel);
            this.Controls.Add(this.lowpassLabel);
            this.Controls.Add(this.subtractLabel);
            this.Controls.Add(this.BackgroundLabel);
            this.Controls.Add(this.subtractImg);
            this.Controls.Add(this.lpImg);
            this.Controls.Add(this.hpImg);
            this.Controls.Add(this.backgroundImg);
            this.Name = "VisionFrom";
            this.Text = "Table Vision";
            ((System.ComponentModel.ISupportInitialize)(this.backgroundImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hpImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lpImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subtractImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bpImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lptrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hptrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noisetrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmptrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThresholdtrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox backgroundImg;
        private Emgu.CV.UI.ImageBox hpImg;
        private Emgu.CV.UI.ImageBox lpImg;
        private Emgu.CV.UI.ImageBox subtractImg;
        private System.Windows.Forms.Label BackgroundLabel;
        private System.Windows.Forms.Label subtractLabel;
        private System.Windows.Forms.Label lowpassLabel;
        private System.Windows.Forms.Label highpassLabel;
        private Emgu.CV.UI.ImageBox bpImg;
        private Emgu.CV.UI.ImageBox sourceImg;
        private Emgu.CV.UI.ImageBox outputImg;
        private System.Windows.Forms.Label bandpassLabel;
        private System.Windows.Forms.Label sourceLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.TrackBar lptrackBar;
        private System.Windows.Forms.TrackBar hptrackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar noisetrackBar;
        private System.Windows.Forms.TrackBar AmptrackBar;
        private System.Windows.Forms.Label amplabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label bvalue;
        private System.Windows.Forms.Label nvalue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label svalue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label tvalue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar ThresholdtrackBar;
        private System.Windows.Forms.Label thresholdvalue;
    }
}

