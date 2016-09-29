
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
            this.calibrateButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.mintrackBar = new System.Windows.Forms.TrackBar();
            this.maxtrackBar = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.minlabel = new System.Windows.Forms.Label();
            this.maxlabel = new System.Windows.Forms.Label();
            this.choose_cams = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.mintrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxtrackBar)).BeginInit();
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
            this.sourceImg.Size = new System.Drawing.Size(480, 304);
            this.sourceImg.TabIndex = 11;
            this.sourceImg.TabStop = false;
            // 
            // outputImg
            // 
            this.outputImg.Location = new System.Drawing.Point(507, 44);
            this.outputImg.Name = "outputImg";
            this.outputImg.Size = new System.Drawing.Size(480, 304);
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
            this.sourceLabel.Location = new System.Drawing.Point(204, 21);
            this.sourceLabel.Name = "sourceLabel";
            this.sourceLabel.Size = new System.Drawing.Size(60, 20);
            this.sourceLabel.TabIndex = 14;
            this.sourceLabel.Text = "Source";
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.outputLabel.Location = new System.Drawing.Point(732, 21);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(58, 20);
            this.outputLabel.TabIndex = 15;
            this.outputLabel.Text = "Output";
            // 
            // lptrackBar
            // 
            this.lptrackBar.LargeChange = 0;
            this.lptrackBar.Location = new System.Drawing.Point(1052, 87);
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
            this.hptrackBar.Location = new System.Drawing.Point(1052, 154);
            this.hptrackBar.Maximum = 200;
            this.hptrackBar.Name = "hptrackBar";
            this.hptrackBar.Size = new System.Drawing.Size(237, 45);
            this.hptrackBar.TabIndex = 7;
            this.hptrackBar.TickFrequency = 2;
            this.hptrackBar.Value = 29;
            this.hptrackBar.Scroll += new System.EventHandler(this.hptrackBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(993, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Low Pass Filter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(989, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "High Pass Filter";
            // 
            // noisetrackBar
            // 
            this.noisetrackBar.LargeChange = 2;
            this.noisetrackBar.Location = new System.Drawing.Point(1052, 215);
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
            this.AmptrackBar.Location = new System.Drawing.Point(1052, 286);
            this.AmptrackBar.Maximum = 300;
            this.AmptrackBar.Minimum = 1;
            this.AmptrackBar.Name = "AmptrackBar";
            this.AmptrackBar.Size = new System.Drawing.Size(237, 45);
            this.AmptrackBar.TabIndex = 21;
            this.AmptrackBar.TickFrequency = 2;
            this.AmptrackBar.Value = 190;
            this.AmptrackBar.Scroll += new System.EventHandler(this.AmptrackBar_Scroll);
            // 
            // amplabel
            // 
            this.amplabel.AutoSize = true;
            this.amplabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.amplabel.Location = new System.Drawing.Point(989, 240);
            this.amplabel.Name = "amplabel";
            this.amplabel.Size = new System.Drawing.Size(70, 20);
            this.amplabel.TabIndex = 22;
            this.amplabel.Text = "Amplifier";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(1019, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Blur";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(1019, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Noise";
            // 
            // bvalue
            // 
            this.bvalue.AutoSize = true;
            this.bvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.bvalue.Location = new System.Drawing.Point(1284, 154);
            this.bvalue.Name = "bvalue";
            this.bvalue.Size = new System.Drawing.Size(27, 20);
            this.bvalue.TabIndex = 25;
            this.bvalue.Text = "29";
            // 
            // nvalue
            // 
            this.nvalue.AutoSize = true;
            this.nvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.nvalue.Location = new System.Drawing.Point(1284, 215);
            this.nvalue.Name = "nvalue";
            this.nvalue.Size = new System.Drawing.Size(18, 20);
            this.nvalue.TabIndex = 26;
            this.nvalue.Text = "2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(1019, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Smooth";
            // 
            // svalue
            // 
            this.svalue.AutoSize = true;
            this.svalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.svalue.Location = new System.Drawing.Point(1284, 87);
            this.svalue.Name = "svalue";
            this.svalue.Size = new System.Drawing.Size(18, 20);
            this.svalue.TabIndex = 28;
            this.svalue.Text = "5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.Location = new System.Drawing.Point(1019, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Amp";
            // 
            // tvalue
            // 
            this.tvalue.AutoSize = true;
            this.tvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tvalue.Location = new System.Drawing.Point(1284, 286);
            this.tvalue.Name = "tvalue";
            this.tvalue.Size = new System.Drawing.Size(36, 20);
            this.tvalue.TabIndex = 30;
            this.tvalue.Text = "190";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label7.Location = new System.Drawing.Point(989, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "Threshold";
            // 
            // ThresholdtrackBar
            // 
            this.ThresholdtrackBar.LargeChange = 2;
            this.ThresholdtrackBar.Location = new System.Drawing.Point(1052, 354);
            this.ThresholdtrackBar.Maximum = 255;
            this.ThresholdtrackBar.Name = "ThresholdtrackBar";
            this.ThresholdtrackBar.Size = new System.Drawing.Size(237, 45);
            this.ThresholdtrackBar.TabIndex = 32;
            this.ThresholdtrackBar.TickFrequency = 2;
            this.ThresholdtrackBar.Value = 189;
            this.ThresholdtrackBar.Scroll += new System.EventHandler(this.ThresholdtrackBar_Scroll);
            // 
            // thresholdvalue
            // 
            this.thresholdvalue.AutoSize = true;
            this.thresholdvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.thresholdvalue.Location = new System.Drawing.Point(1284, 354);
            this.thresholdvalue.Name = "thresholdvalue";
            this.thresholdvalue.Size = new System.Drawing.Size(36, 20);
            this.thresholdvalue.TabIndex = 33;
            this.thresholdvalue.Text = "189";
            // 
            // calibrateButton
            // 
            this.calibrateButton.Location = new System.Drawing.Point(1038, 517);
            this.calibrateButton.Name = "calibrateButton";
            this.calibrateButton.Size = new System.Drawing.Size(75, 23);
            this.calibrateButton.TabIndex = 34;
            this.calibrateButton.Text = "Calibrate";
            this.calibrateButton.UseVisualStyleBackColor = true;
            this.calibrateButton.Click += new System.EventHandler(this.calibrateButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1129, 517);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 23);
            this.button2.TabIndex = 35;
            this.button2.Text = "Reset background";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label8.Location = new System.Drawing.Point(989, 388);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 36;
            this.label8.Text = "Blob area";
            // 
            // mintrackBar
            // 
            this.mintrackBar.LargeChange = 2;
            this.mintrackBar.Location = new System.Drawing.Point(1052, 411);
            this.mintrackBar.Maximum = 500;
            this.mintrackBar.Name = "mintrackBar";
            this.mintrackBar.Size = new System.Drawing.Size(237, 45);
            this.mintrackBar.TabIndex = 37;
            this.mintrackBar.TickFrequency = 2;
            this.mintrackBar.Value = 90;
            this.mintrackBar.Scroll += new System.EventHandler(this.mintrackBar_Scroll);
            // 
            // maxtrackBar
            // 
            this.maxtrackBar.LargeChange = 2;
            this.maxtrackBar.Location = new System.Drawing.Point(1052, 449);
            this.maxtrackBar.Maximum = 1000;
            this.maxtrackBar.Name = "maxtrackBar";
            this.maxtrackBar.Size = new System.Drawing.Size(237, 45);
            this.maxtrackBar.TabIndex = 38;
            this.maxtrackBar.TickFrequency = 2;
            this.maxtrackBar.Value = 189;
            this.maxtrackBar.Scroll += new System.EventHandler(this.maxtrackBar_Scroll);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label9.Location = new System.Drawing.Point(1019, 411);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 20);
            this.label9.TabIndex = 39;
            this.label9.Text = "min";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label10.Location = new System.Drawing.Point(1019, 449);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 20);
            this.label10.TabIndex = 40;
            this.label10.Text = "max";
            // 
            // minlabel
            // 
            this.minlabel.AutoSize = true;
            this.minlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.minlabel.Location = new System.Drawing.Point(1284, 411);
            this.minlabel.Name = "minlabel";
            this.minlabel.Size = new System.Drawing.Size(27, 20);
            this.minlabel.TabIndex = 41;
            this.minlabel.Text = "90";
            // 
            // maxlabel
            // 
            this.maxlabel.AutoSize = true;
            this.maxlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.maxlabel.Location = new System.Drawing.Point(1284, 449);
            this.maxlabel.Name = "maxlabel";
            this.maxlabel.Size = new System.Drawing.Size(36, 20);
            this.maxlabel.TabIndex = 42;
            this.maxlabel.Text = "189";
            // 
            // choose_cams
            // 
            this.choose_cams.Location = new System.Drawing.Point(1038, 488);
            this.choose_cams.Name = "choose_cams";
            this.choose_cams.Size = new System.Drawing.Size(106, 23);
            this.choose_cams.TabIndex = 43;
            this.choose_cams.Text = "Choose Camera";
            this.choose_cams.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1151, 488);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 44;
            for (int i = 0; i < cam_device.Length; i++)
            {
                this.comboBox1.Items.Add(cam_device[i].Name.ToString());
            }
            this.comboBox1.SelectedIndex = 0;
            // 
            // VisionFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 552);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.choose_cams);
            this.Controls.Add(this.maxlabel);
            this.Controls.Add(this.minlabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.maxtrackBar);
            this.Controls.Add(this.mintrackBar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.calibrateButton);
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
            ((System.ComponentModel.ISupportInitialize)(this.mintrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxtrackBar)).EndInit();
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
        private System.Windows.Forms.Button calibrateButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar mintrackBar;
        private System.Windows.Forms.TrackBar maxtrackBar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label minlabel;
        private System.Windows.Forms.Label maxlabel;
        private System.Windows.Forms.Button choose_cams;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

