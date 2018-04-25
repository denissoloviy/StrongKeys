using StrongKeys.Common.GAModels;
using StrongKeys.Common.ImageWorkers;
using StrongKeys.Common.Interfaces;
using StrongKeys.Common.Randomizations;
using StrongKeys.Service;
using System;
using System.Linq;
using System.Windows.Forms;

namespace StrongKeys.DesktopRunner
{
    public partial class MainWindow : Form
    {
        IGARunner _gaRunner;
        ICryptoTarget _cryptor;
        IRandomizer _randomizer;

        byte[] key;
        ImageProperties originalImage;
        byte[] encryptedImage;
        public MainWindow(IGARunner gaRunner, ICryptoTarget cryptor, IRandomizer randomizer)
        {
            _gaRunner = gaRunner;
            _cryptor = cryptor;
            _randomizer = randomizer;
            InitializeComponent();
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            if (openImageDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (!string.IsNullOrEmpty(openImageDialog.FileName))
                    {
                        using (var worker = new BitmapImageReaderWriter(openImageDialog.FileName))
                        {
                            originalImage = new ImageProperties
                            {
                                Image = worker.GetArrayFromImage(),
                                Width = worker.Width,
                                Height = worker.Height
                            };
                            originalPicture.Image = worker.GetInitialBitmap();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            encryptedImage = _cryptor.Encrypt(originalImage.Image, key);
            using (var worker = new BitmapImageReaderWriter(openImageDialog.FileName))
            {
                encryptedPicture.Image = worker.GetBitmap(encryptedImage);
            }
        }

        private void GenerateKeyButton_Click(object sender, EventArgs e)
        {
            key = _randomizer.GetBytes(Convert.ToInt32(keyLengthTextBox.Text));
            RefreshView();
        }

        private void SaveKeyButton_Click(object sender, EventArgs e)
        {
            key = keyTextBox.Text.Split(',').Select(x => Convert.ToByte(x)).ToArray();
        }

        private void RefreshView()
        {
            keyTextBox.Text = string.Join(",", key);
        }

        private void StartGAButton_Click(object sender, EventArgs e)
        {
            ConfigGA();
            _gaRunner.Run();
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            _gaRunner.Pause();
            pauseButton.Visible = false;
            continueButton.Visible = true;
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            _gaRunner.Continue();
            pauseButton.Visible = true;
            continueButton.Visible = false;
        }

        private void NextStepButton_Click(object sender, EventArgs e)
        {
            _gaRunner.NextStep();
        }

        private void InitButton_Click(object sender, EventArgs e)
        {
            ConfigGA();
            _gaRunner.Init();
        }

        void ConfigGA()
        {
            _gaRunner.Algorithm = _cryptor;
            _gaRunner.EncryptedImage = encryptedImage;
            _gaRunner.OriginalImage = originalImage;
        }
    }
}
