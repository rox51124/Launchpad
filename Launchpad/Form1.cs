using NAudio.Wave;

namespace Launchpad
{
    public partial class Launchpad : Form
    {
        private List<Dictionary<string, string>> soundFiles = new List<Dictionary<string, string>>()
        {
            new Dictionary<string, string>()
            {
                { "button1", "Son/Funky Pop/Kick/Kick 1.wav" }, //1
                { "button2", "Son/Funky Pop/Snare/Snare 1.wav" }, //2
                { "button3", "Son/Funky Pop/Tops/Tops 1.wav" }, //3
                { "button4", "Son/Funky Pop/Bass/Bass 1.wav" }, //4
                { "button5", "Son/Funky Pop/Synth/Synth 1.wav" }, //5
                { "button6", "Son/Funky Pop/Pad/Pad 1.wav" }, //6
                { "button7", "Son/Funky Pop/Fx/Fx 1.wav" }, //7
                { "button8", "Son/Funky Pop/Autre/Autre 1.wav" }, //8
                { "buttonA", "Son/Funky Pop/Kick/Kick 2.wav" }, //A
                { "buttonZ", "Son/Funky Pop/Snare/Snare 2.wav" }, //Z
                { "buttonE", "Son/Funky Pop/Tops/Tops 2.wav" }, //E
                { "buttonR", "Son/Funky Pop/Bass/Bass 2.wav" }, //R
                { "buttonT", "Son/Funky Pop/Synth/Synth 2.wav" }, //T
                { "buttonY", "Son/Funky Pop/Pad/Pad 2.wav" }, //Y
                { "buttonU", "Son/Funky Pop/Fx/Fx 2.wav" }, //U
                { "buttonI", "Son/Funky Pop/Autre/Autre 2.wav" }, //I
                { "buttonQ", "Son/Funky Pop/Kick/Kick 3.wav" }, //Q
                { "buttonS", "Son/Funky Pop/Snare/Snare 3.wav" }, //S
                { "buttonD", "Son/Funky Pop/Tops/Tops 3.wav" }, //D
                { "buttonF", "Son/Funky Pop/Bass/Bass 3.wav" }, //F
                { "buttonG", "Son/Funky Pop/Synth/Synth 3.wav" }, //G
                { "buttonH", "Son/Funky Pop/Pad/Pad 3.wav" }, //H
                { "buttonJ", "Son/Funky Pop/Fx/Fx 3.wav" }, //J
                { "buttonK", "Son/Funky Pop/Autre/Autre 3.wav" }, //K
                { "buttonW", "Son/Funky Pop/Kick/Kick 4.wav" }, //W
                { "buttonX", "Son/Funky Pop/Snare/Snare 4.wav" }, //X
                { "buttonC", "Son/Funky Pop/Tops/Tops 4.wav" }, //C
                { "buttonV", "Son/Funky Pop/Bass/Bass 4.wav" }, //V
                { "buttonB", "Son/Funky Pop/Synth/Synth 4.wav" }, //B
                { "buttonN", "Son/Funky Pop/Pad/Pad 4.wav" }, //N
                { "button31", "Son/Funky Pop/Fx/Fx 4.wav" }, //,
                { "button32", "Son/Funky Pop/Autre/Autre 4.wav" } //;
            },
            new Dictionary<string, string>()
            {
                { "button1", "Son/Pure Drill/Kick/Kick 1.wav" }, //1
                { "button2", "Son/Pure Drill/Snare/Snare 1.wav" }, //2
                { "button3", "Son/Pure Drill/Tops/Tops 1.wav" }, //3
                { "button4", "Son/Pure Drill/Bass/Bass 1.wav" }, //4
                { "button5", "Son/Pure Drill/Synth/Synth 1.wav" }, //5
                { "button6", "Son/Pure Drill/Pad/Pad 1.wav" }, //6
                { "button7", "Son/Pure Drill/Fx/Fx 1.wav" }, //7
                { "button8", "Son/Pure Drill/Autre/Autre 1.wav" }, //8
                { "buttonA", "Son/Pure Drill/Kick/Kick 2.wav" }, //A
                { "buttonZ", "Son/Pure Drill/Snare/Snare 2.wav" }, //Z
                { "buttonE", "Son/Pure Drill/Tops/Tops 2.wav" }, //E
                { "buttonR", "Son/Pure Drill/Bass/Bass 2.wav" }, //R
                { "buttonT", "Son/Pure Drill/Synth/Synth 2.wav" }, //T
                { "buttonY", "Son/Pure Drill/Pad/Pad 2.wav" }, //Y
                { "buttonU", "Son/Pure Drill/Fx/Fx 2.wav" }, //U
                { "buttonI", "Son/Pure Drill/Autre/Autre 2.wav" }, //I
                { "buttonQ", "Son/Pure Drill/Kick/Kick 3.wav" }, //Q
                { "buttonS", "Son/Pure Drill/Snare/Snare 3.wav" }, //S
                { "buttonD", "Son/Pure Drill/Tops/Tops 3.wav" }, //D
                { "buttonF", "Son/Pure Drill/Bass/Bass 3.wav" }, //F
                { "buttonG", "Son/Pure Drill/Synth/Synth 3.wav" }, //G
                { "buttonH", "Son/Pure Drill/Pad/Pad 3.wav" }, //H
                { "buttonJ", "Son/Pure Drill/Fx/Fx 3.wav" }, //J
                { "buttonK", "Son/Pure Drill/Autre/Autre 3.wav" }, //K
                { "buttonW", "Son/Pure Drill/Kick/Kick 4.wav" }, //W
                { "buttonX", "Son/Pure Drill/Snare/Snare 4.wav" }, //X
                { "buttonC", "Son/Pure Drill/Tops/Tops 4.wav" }, //C
                { "buttonV", "Son/Pure Drill/Bass/Bass 4.wav" }, //V
                { "buttonB", "Son/Pure Drill/Synth/Synth 4.wav" }, //B
                { "buttonN", "Son/Pure Drill/Pad/Pad 4.wav" }, //N
                { "button31", "Son/Pure Drill/Fx/Fx 4.wav" }, //,
                { "button32", "Son/Pure Drill/Autre/Autre 4.wav" } //;
            },
            new Dictionary<string, string>()
            {
                { "button1", "Son/H-T/Kick/Kick 1.wav" }, //1
                { "button2", "Son/H-T/Snare/Snare 1.wav" }, //2
                { "button3", "Son/H-T/Tops/Tops 1.wav" }, //3
                { "button4", "Son/H-T/Bass/Bass 1.wav" }, //4
                { "button5", "Son/H-T/Synth/Synth 1.wav" }, //5
                { "button6", "Son/H-T/Pad/Pad 1.wav" }, //6
                { "button7", "Son/H-T/Fx/Fx 1.wav" }, //7
                { "button8", "Son/H-T/Autre/Autre 1.wav" }, //8
                { "buttonA", "Son/H-T/Kick/Kick 2.wav" }, //A
                { "buttonZ", "Son/H-T/Snare/Snare 2.wav" }, //Z
                { "buttonE", "Son/H-T/Tops/Tops 2.wav" }, //E
                { "buttonR", "Son/H-T/Bass/Bass 2.wav" }, //R
                { "buttonT", "Son/H-T/Synth/Synth 2.wav" }, //T
                { "buttonY", "Son/H-T/Pad/Pad 2.wav" }, //Y
                { "buttonU", "Son/H-T/Fx/Fx 2.wav" }, //U
                { "buttonI", "Son/H-T/Autre/Autre 2.wav" }, //I
                { "buttonQ", "Son/H-T/Kick/Kick 3.wav" }, //Q
                { "buttonS", "Son/H-T/Snare/Snare 3.wav" }, //S
                { "buttonD", "Son/H-T/Tops/Tops 3.wav" }, //D
                { "buttonF", "Son/H-T/Bass/Bass 3.wav" }, //F
                { "buttonG", "Son/H-T/Synth/Synth 3.wav" }, //G
                { "buttonH", "Son/H-T/Pad/Pad 3.wav" }, //H
                { "buttonJ", "Son/H-T/Fx/Fx 3.wav" }, //J
                { "buttonK", "Son/H-T/Autre/Autre 3.wav" }, //K
                { "buttonW", "Son/H-T/Kick/Kick 4.wav" }, //W
                { "buttonX", "Son/H-T/Snare/Snare 4.wav" }, //X
                { "buttonC", "Son/H-T/Tops/Tops 4.wav" }, //C
                { "buttonV", "Son/H-T/Bass/Bass 4.wav" }, //V
                { "buttonB", "Son/H-T/Synth/Synth 4.wav" }, //B
                { "buttonN", "Son/H-T/Pad/Pad 4.wav" }, //N
                { "button31", "Son/H-T/Fx/Fx 4.wav" }, //,
                { "button32", "Son/H-T/Autre/Autre 4.wav" } //;
            },
            new Dictionary<string, string>()
            {
                { "button1", "Son/Massive Bass/Kick/Kick 1.wav" }, //1
                { "button2", "Son/Massive Bass/Snare/Snare 1.wav" }, //2
                { "button3", "Son/Massive Bass/Tops/Tops 1.wav" }, //3
                { "button4", "Son/Massive Bass/Bass/Bass 1.wav" }, //4
                { "button5", "Son/Massive Bass/Synth/Synth 1.wav" }, //5
                { "button6", "Son/Massive Bass/Pad/Pad 1.wav" }, //6
                { "button7", "Son/Massive Bass/Fx/Fx 1.wav" }, //7
                { "button8", "Son/Massive Bass/Autre/Autre 1.wav" }, //8
                { "buttonA", "Son/Massive Bass/Kick/Kick 2.wav" }, //A
                { "buttonZ", "Son/Massive Bass/Snare/Snare 2.wav" }, //Z
                { "buttonE", "Son/Massive Bass/Tops/Tops 2.wav" }, //E
                { "buttonR", "Son/Massive Bass/Bass/Bass 2.wav" }, //R
                { "buttonT", "Son/Massive Bass/Synth/Synth 2.wav" }, //T
                { "buttonY", "Son/Massive Bass/Pad/Pad 2.wav" }, //Y
                { "buttonU", "Son/Massive Bass/Fx/Fx 2.wav" }, //U
                { "buttonI", "Son/Massive Bass/Autre/Autre 2.wav" }, //I
                { "buttonQ", "Son/Massive Bass/Kick/Kick 3.wav" }, //Q
                { "buttonS", "Son/Massive Bass/Snare/Snare 3.wav" }, //S
                { "buttonD", "Son/Massive Bass/Tops/Tops 3.wav" }, //D
                { "buttonF", "Son/Massive Bass/Bass/Bass 3.wav" }, //F
                { "buttonG", "Son/Massive Bass/Synth/Synth 3.wav" }, //G
                { "buttonH", "Son/Massive Bass/Pad/Pad 3.wav" }, //H
                { "buttonJ", "Son/Massive Bass/Fx/Fx 3.wav" }, //J
                { "buttonK", "Son/Massive Bass/Autre/Autre 3.wav" }, //K
                { "buttonW", "Son/Massive Bass/Kick/Kick 4.wav" }, //W
                { "buttonX", "Son/Massive Bass/Snare/Snare 4.wav" }, //X
                { "buttonC", "Son/Massive Bass/Tops/Tops 4.wav" }, //C
                { "buttonV", "Son/Massive Bass/Bass/Bass 4.wav" }, //V
                { "buttonB", "Son/Massive Bass/Synth/Synth 4.wav" }, //B
                { "buttonN", "Son/Massive Bass/Pad/Pad 4.wav" }, //N
                { "button31", "Son/Massive Bass/Fx/Fx 4.wav" }, //,
                { "button32", "Son/Massive Bass/Autre/Autre 4.wav" } //;
            }
        };

        private int currentSoundFilesIndex = 0;
        private WaveOutEvent output;
        private WaveStream music;
        private Recorder rec = new Recorder();
        bool isRecording = false;
        private List<Button> buttons = new List<Button>();

        public Launchpad()
        {
            InitializeComponent();

            currentSoundFilesIndex = 3;

            foreach (var button in new[] { button1, button2, button3, button4, button5, button6, button7, button8, buttonA, buttonZ, buttonE, buttonR, buttonT, buttonY, buttonU, buttonI, buttonQ, buttonS, buttonD, buttonF, buttonG, buttonH, buttonJ, buttonK, buttonW, buttonX, buttonC, buttonV, buttonB, buttonN, button31, button32 })
            {
                button.MouseClick += ImportFile;
            }

            buttonRond1.Click += new EventHandler(buttonRond_Click);
            buttonRond2.Click += new EventHandler(buttonRond_Click);
            buttonRond3.Click += new EventHandler(buttonRond_Click);
            buttonRond4.Click += new EventHandler(buttonRond_Click);
        }

        private void Launchpad_Load(object sender, EventArgs e)
        {
        }

        private void ImportFile(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;

            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Audio Files|*.mp3;*.wav";
            openFile.InitialDirectory = @"C:\Musique";
            openFile.Title = "Sélectionnez un fichier";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                soundFiles[currentSoundFilesIndex][button.Name] = openFile.FileName;
            }
        }

        private void PlaySound(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string fileName = soundFiles[currentSoundFilesIndex][button.Name];

            music = new AudioFileReader(fileName);
            output = new WaveOutEvent();
            output.Init(music);
            output.Play();
        }

        private void Launchpad_KeyDown(object sender, KeyEventArgs e)
        {
            var keyButtonArray = new[]
            {
                (Keys.D1, button1),
                (Keys.D2, button2),
                (Keys.D3, button3),
                (Keys.D4, button4),
                (Keys.D5, button5),
                (Keys.D6, button6),
                (Keys.D7, button7),
                (Keys.D8, button8),
                (Keys.A, buttonA),
                (Keys.Z, buttonZ),
                (Keys.E, buttonE),
                (Keys.R, buttonR),
                (Keys.T, buttonT),
                (Keys.Y, buttonY),
                (Keys.U, buttonU),
                (Keys.I, buttonI),
                (Keys.Q, buttonQ),
                (Keys.S, buttonS),
                (Keys.D, buttonD),
                (Keys.F, buttonF),
                (Keys.G, buttonG),
                (Keys.H, buttonH),
                (Keys.J, buttonJ),
                (Keys.K, buttonK),
                (Keys.W, buttonW),
                (Keys.X, buttonX),
                (Keys.C, buttonC),
                (Keys.V, buttonV),
                (Keys.B, buttonB),
                (Keys.N, buttonN),
                (Keys.Oemcomma, button31),
                (Keys.OemPeriod, button32)
            };

            foreach ((Keys key, Button button) in keyButtonArray)
            {
                if (e.KeyCode == key)
                {
                    PlaySound(button, e);

                    switch (key)
                    {
                        case Keys.D1:
                        case Keys.A:
                        case Keys.Q:
                        case Keys.W:
                            button.BackColor = Color.DodgerBlue;
                            break;
                        case Keys.D2:
                        case Keys.Z:
                        case Keys.S:
                        case Keys.X:
                            button.BackColor = Color.Red;
                            break;
                        case Keys.D3:
                        case Keys.E:
                        case Keys.D:
                        case Keys.C:
                            button.BackColor = Color.DarkViolet;
                            break;
                        case Keys.D4:
                        case Keys.R:
                        case Keys.F:
                        case Keys.V:
                            button.BackColor = Color.Goldenrod;
                            break;
                        case Keys.D5:
                        case Keys.T:
                        case Keys.G:
                        case Keys.B:
                            button.BackColor = Color.MediumTurquoise;
                            break;
                        case Keys.D6:
                        case Keys.Y:
                        case Keys.H:
                        case Keys.N:
                            button.BackColor = Color.DeepSkyBlue;
                            break;
                        case Keys.D7:
                        case Keys.U:
                        case Keys.J:
                        case Keys.Oemcomma:
                            button.BackColor = Color.SkyBlue;
                            break;
                        case Keys.D8:
                        case Keys.I:
                        case Keys.K:
                        case Keys.OemPeriod:
                            button.BackColor = Color.MediumSeaGreen;
                            break;
                    }
                    break;
                }
            }
        }

        private void Launchpad_KeyUp(object sender, KeyEventArgs e)
        {
            Dictionary<Keys, Button> buttons = new Dictionary<Keys, Button>()
            {
                { Keys.D1, button1 },
                { Keys.D2, button2 },
                { Keys.D3, button3 },
                { Keys.D4, button4 },
                { Keys.D5, button5 },
                { Keys.D6, button6 },
                { Keys.D7, button7 },
                { Keys.D8, button8 },
                { Keys.A, buttonA },
                { Keys.Z, buttonZ },
                { Keys.E, buttonE },
                { Keys.R, buttonR },
                { Keys.T, buttonT },
                { Keys.Y, buttonY },
                { Keys.U, buttonU },
                { Keys.I, buttonI },
                { Keys.Q, buttonQ },
                { Keys.S, buttonS },
                { Keys.D, buttonD },
                { Keys.F, buttonF },
                { Keys.G, buttonG },
                { Keys.H, buttonH },
                { Keys.J, buttonJ },
                { Keys.K, buttonK },
                { Keys.W, buttonW },
                { Keys.X, buttonX },
                { Keys.C, buttonC },
                { Keys.V, buttonV },
                { Keys.B, buttonB },
                { Keys.N, buttonN },
                { Keys.Oemcomma, button31 },
                { Keys.OemPeriod, button32 }
            };

            foreach (KeyValuePair<Keys, Button> button in buttons)
            {
                if (e.KeyCode == button.Key)
                {
                    button.Value.BackColor = Color.Transparent;
                    break;
                }
            }
        }

        private void buttonRond1_Click(object sender, EventArgs e)
        {
            currentSoundFilesIndex = 0;
        }

        private void buttonRond2_Click(object sender, EventArgs e)
        {
            currentSoundFilesIndex = 1;
        }

        private void buttonRond3_Click(object sender, EventArgs e)
        {
            currentSoundFilesIndex = 2;
        }

        private void buttonRond4_Click(object sender, EventArgs e)
        {
            currentSoundFilesIndex = 3;
        }

        private void buttonRond_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            foreach (Control control in this.Controls)
            {
                if (control is Button && control.Name.StartsWith("buttonRond"))
                {
                    control.BackColor = Color.RoyalBlue;
                }
            }

            clickedButton.BackColor = Color.MediumSlateBlue;
        }


        private void buttonRecord_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "WAV files (.wav)|.wav";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.RestoreDirectory = true;

                if (!isRecording && saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    rec.startRecord(saveFileDialog1.FileName);
                    buttonRecord.Text = "ON";
                    isRecording = true;
                    buttonRecord.BackColor= Color.MediumSlateBlue;
                }
                else
                {
                    rec.stopRecord();
                    buttonRecord.Text = "OFF";
                    isRecording = false;
                    buttonRecord.BackColor= Color.Transparent;
                    buttonRecord.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}