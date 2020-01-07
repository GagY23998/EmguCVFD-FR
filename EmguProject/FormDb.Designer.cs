namespace EmguProject
{
    partial class FormDb
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
            this.imgBox_BgrFace = new Emgu.CV.UI.ImageBox();
            this.imgBox_DetectedFace = new Emgu.CV.UI.ImageBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_FirstName = new System.Windows.Forms.TextBox();
            this.txtBox_LastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnScan = new System.Windows.Forms.Button();
            this.txtBox_Counter = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnPredict = new System.Windows.Forms.Button();
            this.btnTrain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox_BgrFace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox_DetectedFace)).BeginInit();
            this.SuspendLayout();
            // 
            // imgBox_BgrFace
            // 
            this.imgBox_BgrFace.Location = new System.Drawing.Point(57, 33);
            this.imgBox_BgrFace.Name = "imgBox_BgrFace";
            this.imgBox_BgrFace.Size = new System.Drawing.Size(187, 166);
            this.imgBox_BgrFace.TabIndex = 2;
            this.imgBox_BgrFace.TabStop = false;
            // 
            // imgBox_DetectedFace
            // 
            this.imgBox_DetectedFace.Location = new System.Drawing.Point(317, 33);
            this.imgBox_DetectedFace.Name = "imgBox_DetectedFace";
            this.imgBox_DetectedFace.Size = new System.Drawing.Size(187, 166);
            this.imgBox_DetectedFace.TabIndex = 3;
            this.imgBox_DetectedFace.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bgr Image:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Detected Face:";
            // 
            // txtBox_FirstName
            // 
            this.txtBox_FirstName.Location = new System.Drawing.Point(669, 33);
            this.txtBox_FirstName.Name = "txtBox_FirstName";
            this.txtBox_FirstName.Size = new System.Drawing.Size(100, 20);
            this.txtBox_FirstName.TabIndex = 6;
            // 
            // txtBox_LastName
            // 
            this.txtBox_LastName.Location = new System.Drawing.Point(669, 59);
            this.txtBox_LastName.Name = "txtBox_LastName";
            this.txtBox_LastName.Size = new System.Drawing.Size(100, 20);
            this.txtBox_LastName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(556, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "First Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(556, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Last Name:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(559, 176);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(210, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(559, 137);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(210, 23);
            this.btnScan.TabIndex = 11;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // txtBox_Counter
            // 
            this.txtBox_Counter.Location = new System.Drawing.Point(669, 253);
            this.txtBox_Counter.Name = "txtBox_Counter";
            this.txtBox_Counter.Size = new System.Drawing.Size(100, 20);
            this.txtBox_Counter.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(555, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Counter:";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(559, 101);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(210, 23);
            this.btnAddUser.TabIndex = 14;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnPredict
            // 
            this.btnPredict.Location = new System.Drawing.Point(78, 246);
            this.btnPredict.Name = "btnPredict";
            this.btnPredict.Size = new System.Drawing.Size(150, 23);
            this.btnPredict.TabIndex = 15;
            this.btnPredict.Text = "Predict";
            this.btnPredict.UseVisualStyleBackColor = true;
            this.btnPredict.Click += new System.EventHandler(this.btnPredict_Click);
            // 
            // btnTrain
            // 
            this.btnTrain.Location = new System.Drawing.Point(340, 246);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(150, 23);
            this.btnTrain.TabIndex = 16;
            this.btnTrain.Text = "Train";
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // FormDb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTrain);
            this.Controls.Add(this.btnPredict);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBox_Counter);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBox_LastName);
            this.Controls.Add(this.txtBox_FirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgBox_DetectedFace);
            this.Controls.Add(this.imgBox_BgrFace);
            this.Name = "FormDb";
            this.Text = "FormDb";
            ((System.ComponentModel.ISupportInitialize)(this.imgBox_BgrFace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox_DetectedFace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox imgBox_BgrFace;
        private Emgu.CV.UI.ImageBox imgBox_DetectedFace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_FirstName;
        private System.Windows.Forms.TextBox txtBox_LastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.TextBox txtBox_Counter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnPredict;
        private System.Windows.Forms.Button btnTrain;
    }
}