using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using NAudio.Wave;

namespace AudioInterface
{
    class NAudioBufferReverse
    {
        // Length of the buffer
        private int numOfBytes;

        // The byte array to store the reversed sample
        byte[] reversedSample;

        public byte[] reverseSample(byte[] sampleToReverse, int SourceLengthBytes, int bytesPerSample)
        {

            numOfBytes = SourceLengthBytes;

            // Set the byte array to the length of the source sample
            reversedSample = new byte[SourceLengthBytes];
            
            // The alternatve location; starts at the end and works to the begining
            int b = 0;

            //Prime the loop by 'reducing' the numOfBytes by the first increment for the first sample 
            numOfBytes = numOfBytes - bytesPerSample;

            // Used for the imbeded loop to move the complete sample
            int q = 0;

            // Moves through the stream based on each sample
            for (int i = 0; i < numOfBytes - bytesPerSample; i = i + bytesPerSample)
            {
                // Effectively a mirroing process; b will equal i (or be out by one if its an equal buffer)
                // when the middle of the buffer is reached.
                b = numOfBytes - bytesPerSample - i;

                // Copies the 'sample' in whole to the opposite end of the reversedSample
                for (q = 0; q <= bytesPerSample; q++)
                {
                    reversedSample[b + q] = sampleToReverse[i + q];
                }
            }

            // Sends back the reversed stream
            return reversedSample;
        }

    }
}
