using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launchpad
{
    internal class Recorder
    {

        WasapiLoopbackCapture Capturer = new WasapiLoopbackCapture();

        public void startRecord(String fp)
        {
            WaveFileWriter RecordedAudioWriter = new WaveFileWriter(fp, Capturer.WaveFormat);

            Capturer.DataAvailable += (s, a) =>
            {
                RecordedAudioWriter.Write(a.Buffer, 0, a.BytesRecorded);
            };

            Capturer.RecordingStopped += (s, a) =>
            {
                RecordedAudioWriter.Dispose();
                RecordedAudioWriter = null;
                Capturer.Dispose();
            };

            Capturer.StartRecording();
        }

        public void stopRecord()
        {
            Capturer.StopRecording();
        }
    }
}
