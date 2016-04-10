using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using System.Threading;
using AudioInterface;
using System.Text;

namespace WindowsFormsApplication1
{
    
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        private static WaveMixerStream32 mixer;
        private static IWavePlayer waveOutDevice;

        [STAThread]
        static void Main()
        {

            IEnumerable<string> sourceFiles = new string[] { };
            string[] x = { "Warriors.wav", "Warriors.wav" };
            IEnumerable<string> test = new string[] { };
            string[] s = { "nothingsuspicious.wav" };
            sourceFiles = x;
            //          Concatenate("lol.wav", sourceFiles);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

          //  test_notConcatenate("blah.wav", s);

        }

            public static void test_notConcatenate(string outputFile, IEnumerable<string> sourceFiles)
        {
            int b = 6;
            int a = 40;
            byte[] buffer = new byte[16348];//1024];
            byte[] dbuff = new byte[16348];//1024];
            WaveFileWriter waveFileWriter = null;
            WaveFileReader decrypter = new WaveFileReader("Warriors.wav");
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
                        StringBuilder final = new StringBuilder();
                        int r = 0;
                        int read;
                        //Console.WriteLine("ALOHA" + buffer[4]);
                        int dread;
                        while ((read = reader.Read(buffer, 0, buffer.Length)) > 0 && (dread = decrypter.Read(dbuff, 0, dbuff.Length))>0)
                        {   
                            for (int i = 0; i < buffer.Length; i++)
                            {
                                r = buffer[i] - dbuff[i];
                                Console.WriteLine(r);
                                final.Append(r);
                                //r = buffer[i] - r;
                                //buffer[i] = (byte)r;
                                if (final.ToString().Contains("00000000"))
                                {
                                    final = final.Remove(final.Length - 7, 7);
                                    Console.WriteLine(final);
                                    int L = final.Length;

                                    string words = "";

                                    char[] cArray = final.ToString().ToCharArray();

                                    for (int j = 0; j < L; j++)
                                    {
                                        cArray[j] = (char)((cArray[j] - b) / a);
                                        words += cArray[j];
                                    }

                                    Console.WriteLine(words);
                                    return;
                                }
                            }
                            //waveFileWriter.Write(buffer, 0, read);

                        }
                        break;
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

        public static void Concatenate(string outputFile, IEnumerable<string> sourceFiles)
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
                        int r;
                        int read;
                        Console.WriteLine("ALOHA" + buffer[4]);
                        while ((read = reader.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            for(int i = 0; i < buffer.Length; i++)
                            {
                                r = buffer[i] + 50;
                                buffer[i] = (byte)r;
                            }
                          //  Console.WriteLine(buffer[4] + " " + read);
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
        /*      public static void LoadSample(string fileName, int sampleNumber)
              {
                  Sample[sampleNumber] = new AudioSample(fileName);
                  mixer.AddInputStream(Sample[sampleNumber]);

                  // The stop is required because when an InputStream 
                  // is added, if it is too long it will start 
                  // playing because we do not turn off the mixer.
                  // This is effectively just a work around by making
                  // sure that we move the playback position 
                  // to the end of the stream to aviod this issue.
                  Stop(sampleNumber);
              }
              */
    }

}
