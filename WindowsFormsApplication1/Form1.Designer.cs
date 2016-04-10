namespace WindowsFormsApplication1
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
            this.inputText = new System.Windows.Forms.TextBox();
            this.retrieveInput = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.toEnc = new System.Windows.Forms.OpenFileDialog();
            this.toDec = new System.Windows.Forms.OpenFileDialog();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Key = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inputA = new System.Windows.Forms.TextBox();
            this.inputB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputText
            // 
            this.inputText.Location = new System.Drawing.Point(36, 105);
            this.inputText.Multiline = true;
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(294, 164);
            this.inputText.TabIndex = 0;
            this.inputText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // retrieveInput
            // 
            this.retrieveInput.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.retrieveInput.Location = new System.Drawing.Point(94, 288);
            this.retrieveInput.Name = "retrieveInput";
            this.retrieveInput.Size = new System.Drawing.Size(172, 41);
            this.retrieveInput.TabIndex = 1;
            this.retrieveInput.Text = "Encrypt";
            this.retrieveInput.UseVisualStyleBackColor = false;
            this.retrieveInput.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.Location = new System.Drawing.Point(506, 288);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 41);
            this.button2.TabIndex = 2;
            this.button2.Text = "Decrypt";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // toEnc
            // 
            this.toEnc.FileName = "openFileDialog1";
            this.toEnc.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // toDec
            // 
            this.toDec.FileName = "openFileDialog2";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button4.Location = new System.Drawing.Point(506, 136);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(172, 42);
            this.button4.TabIndex = 4;
            this.button4.Text = "Select encrypted .wav file";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button5.Location = new System.Drawing.Point(506, 184);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(172, 39);
            this.button5.TabIndex = 5;
            this.button5.Text = "Select auditory key";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Key
            // 
            this.Key.FileName = "openFileDialog2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Encrypt sentences";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(479, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "Decrypt .wav files";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // inputA
            // 
            this.inputA.Location = new System.Drawing.Point(390, 181);
            this.inputA.Name = "inputA";
            this.inputA.Size = new System.Drawing.Size(47, 20);
            this.inputA.TabIndex = 9;
            this.inputA.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // inputB
            // 
            this.inputB.Location = new System.Drawing.Point(390, 239);
            this.inputB.Multiline = true;
            this.inputB.Name = "inputB";
            this.inputB.Size = new System.Drawing.Size(47, 25);
            this.inputB.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(388, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "key \'A\'";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(388, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "key \'B\'";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(789, 386);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputB);
            this.Controls.Add(this.inputA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.retrieveInput);
            this.Controls.Add(this.inputText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputText;
        private System.Windows.Forms.Button retrieveInput;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog toEnc;
        private System.Windows.Forms.OpenFileDialog toDec;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.OpenFileDialog Key;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputA;
        private System.Windows.Forms.TextBox inputB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}

