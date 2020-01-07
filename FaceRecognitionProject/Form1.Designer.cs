namespace EmguProject
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
            this.imgBox1 = new Emgu.CV.UI.ImageBox();
            this.imgBox2 = new Emgu.CV.UI.ImageBox();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.btnTrain = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_Label = new System.Windows.Forms.TextBox();
            this.btnUploadImages = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_distance = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // imgBox1
            // 
            this.imgBox1.BackColor = System.Drawing.Color.Turquoise;
            this.imgBox1.Location = new System.Drawing.Point(121, 74);
            this.imgBox1.Name = "imgBox1";
            this.imgBox1.Size = new System.Drawing.Size(357, 343);
            this.imgBox1.TabIndex = 2;
            this.imgBox1.TabStop = false;
            // 
            // imgBox2
            // 
            this.imgBox2.BackColor = System.Drawing.Color.Turquoise;
            this.imgBox2.Location = new System.Drawing.Point(609, 74);
            this.imgBox2.Name = "imgBox2";
            this.imgBox2.Size = new System.Drawing.Size(357, 343);
            this.imgBox2.TabIndex = 3;
            this.imgBox2.TabStop = false;
            this.imgBox2.Click += new System.EventHandler(this.imgBox2_Click);
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(1067, 357);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(325, 255);
            this.picBox.TabIndex = 4;
            this.picBox.TabStop = false;
            // 
            // btnTrain
            // 
            this.btnTrain.Location = new System.Drawing.Point(1163, 86);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(150, 23);
            this.btnTrain.TabIndex = 5;
            this.btnTrain.Text = "Train";
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(1163, 178);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(150, 23);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1163, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Predict";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnPredict_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1100, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Label ";
            // 
            // txtBox_Label
            // 
            this.txtBox_Label.Location = new System.Drawing.Point(1163, 267);
            this.txtBox_Label.Name = "txtBox_Label";
            this.txtBox_Label.Size = new System.Drawing.Size(150, 20);
            this.txtBox_Label.TabIndex = 9;
            // 
            // btnUploadImages
            // 
            this.btnUploadImages.Location = new System.Drawing.Point(1163, 131);
            this.btnUploadImages.Name = "btnUploadImages";
            this.btnUploadImages.Size = new System.Drawing.Size(150, 23);
            this.btnUploadImages.TabIndex = 10;
            this.btnUploadImages.Text = "Upload Images";
            this.btnUploadImages.UseVisualStyleBackColor = true;
            this.btnUploadImages.Click += new System.EventHandler(this.btnUploadImages_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(712, 525);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(150, 23);
            this.btnTest.TabIndex = 11;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1100, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Distance";
            // 
            // txtBox_distance
            // 
            this.txtBox_distance.Location = new System.Drawing.Point(1163, 305);
            this.txtBox_distance.Name = "txtBox_distance";
            this.txtBox_distance.Size = new System.Drawing.Size(150, 20);
            this.txtBox_distance.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 660);
            this.Controls.Add(this.txtBox_distance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnUploadImages);
            this.Controls.Add(this.txtBox_Label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnTrain);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.imgBox2);
            this.Controls.Add(this.imgBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imgBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox imgBox1;
        private Emgu.CV.UI.ImageBox imgBox2;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_Label;
        private System.Windows.Forms.Button btnUploadImages;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_distance;
    }
}

