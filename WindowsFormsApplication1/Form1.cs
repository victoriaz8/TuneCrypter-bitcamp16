using System;
using System.Windows.Forms;
using NAudio.Wave;
using System.Threading;
using System.IO;
using NAudioTests.Utils;
using System.Collections.Generic;
using System.Text;
using static System.BitConverter;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int a = 3;
        int b = 6;
        string key_filename = "Warriors.wav";
        string wav_dec = "";
        string wav_enc = "";
        string message = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            MessageBox.Show(this.inputText.Text);
            message = this.inputText.Text;
            string p = inputA.Text;
            a = Convert.ToInt32(p);
            b = Convert.ToInt32(inputB.Text);
            Encrypt(message);
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = toEnc.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                wav_enc = toEnc.FileName;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = toDec.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                wav_dec = toDec.FileName;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = Key.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                key_filename = Key.FileName;
            }
        }

        public void Encrypt(string msg)
        {
  

            int L = msg.Length;
            int[] hash = new int[L];


            char[] cArray = msg.ToCharArray();

            for (var i = 0; i < L; i++)
            {
                cArray[i] = (char)((a * cArray[i]) + b);
                hash[i] = cArray[i];
                Console.Write(hash[i] + " ");
            }
            Console.WriteLine();
            IEnumerable<string> sourceFiles = new string[] { key_filename };
            Concatenate("nothingsuspicious.wav", sourceFiles, hash);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public static void Concatenate(string outputFile, IEnumerable<string> sourceFiles, int[] array)
        {
            byte[] buffer = new byte[1024];
            WaveFileWriter waveFileWriter = null;

            try
            {
                foreach (string sourceFile in sourceFiles)
                {
                    using (WaveFileReader reader = new WaveFileReader(sourceFile))
                    {
                        if (waveFileWriter == null)
                        {
                            // first time in create new Writer
                            waveFileWriter = new WaveFileWriter(outputFile, reader.WaveFormat);
                        }
                        else
                        {
                            if (!reader.WaveFormat.Equals(waveFileWriter.WaveFormat))
                            {
                                throw new InvalidOperationException("Can't concatenate WAV Files that don't share the same format");
                            }
                        }
                        bool go = true;
                        int r;
                        int read;
                        while ((read = reader.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            for (int i = 0; i < buffer.Length; i++)
                            {
                                if (i == array.Length) go = false;
                                else if (go == true) { 
                                    if (i < array.Length) r = buffer[i] + array[i];
                                    else r = buffer[i];

                                    buffer[i] = (byte)r;
                                }
                            }
                            waveFileWriter.Write(buffer, 0, read);

                        }
                    }
                }
            }
            finally
            {
                if (waveFileWriter != null)
                {
                    waveFileWriter.Dispose();
                }
            }

        }

        public void test_notConcatenate(string outputFile, IEnumerable<string> sourceFiles)
        {
            byte[] buffer = new byte[1024];//1024];
            byte[] dbuff = new byte[1024];//1024];
            WaveFileWriter waveFileWriter = null;
            WaveFileReader decrypter = new WaveFileReader(key_filename);
            try
            {
                foreach (string sourceFile in sourceFiles)
                {
                    using (WaveFileReader reader = new WaveFileReader(sourceFile)) //sourcefile/reader is the post=encrypted one
                    {
                        if (waveFileWriter == null)
                        {
                            // first time in create new Writer
                            waveFileWriter = new WaveFileWriter(outputFile, reader.WaveFormat);
                        }
                        else
                        {
                            if (!reader.WaveFormat.Equals(waveFileWriter.WaveFormat))
                            {
                                throw new InvalidOperationException("Can't concatenate WAV Files that don't share the same format");
                            }
                        }
                        StringBuilder final = new StringBuilder();
                        int r = 0;
                        int read;
                        int dread;
                        int[] augh = new int[100];
                        int x = 0;

                        while ((read = reader.Read(buffer, 0, buffer.Length)) > 0 && (dread = decrypter.Read(dbuff, 0, dbuff.Length)) > 0)
                        {
                            for (int i = 0; i < buffer.Length; i++)
                            {
                                r = buffer[i] + dbuff[i];
                                final.Append(r);
                                augh[x] = (r + 256);
                                x++;
                                if (final.ToString().Contains("00000000"))
                                {
                                    int L = x - 8;
                                    string words = "";
                                    for (int j = 0; j < L; j++)
                                    {                             
                                        augh[j] = (augh[j] - b) / a;

                                        words = words + "" + Convert.ToChar(augh[j]%128);
                                    }
                                    Console.WriteLine(words);
                                    return;
                                }
                            }
                            break;
                        }
                    }
                }
            }
            finally
            {
                if (waveFileWriter != null)
                {
                    waveFileWriter.Dispose();
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            IEnumerable<string> sourceFiles = new string[] { wav_dec };
            test_notConcatenate("result.wav", sourceFiles);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
