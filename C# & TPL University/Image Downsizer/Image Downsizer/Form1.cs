namespace Image_Downsizer
{
    using ImageDownscaler;
    using System.Diagnostics;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Stopwatch stopwatch = new Stopwatch();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All Files|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;

                // Load the selected image into a PictureBox
                pictureBox1.Image = Image.FromFile(imagePath);
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                if (int.TryParse(textBox1.Text, out int downscalingPercentage) && downscalingPercentage > 0 && downscalingPercentage <= 100)
                {
                    Bitmap originalImage = new Bitmap(pictureBox1.Image);
                    int newWidth = (originalImage.Width * downscalingPercentage) / 100;
                    int newHeight = (originalImage.Height * downscalingPercentage) / 100;

                    Stopwatch stopwatch = new Stopwatch();

                    // Sequential downscaling
                    stopwatch.Start();
                    Bitmap sequentialDownscaledImage = ImageDownscaler.DownscaleImageSequential(originalImage, newWidth, newHeight);
                    stopwatch.Stop();

                    MessageBox.Show($"Sequential downscaling took: {stopwatch.Elapsed.TotalMilliseconds} ms");

                    // Parallel downscaling
                    stopwatch.Restart();
                    Bitmap parallelDownscaledImage = await DownscaleImageParallelAsync(originalImage, newWidth, newHeight);
                    stopwatch.Stop();

                    MessageBox.Show($"Parallel downscaling took: {stopwatch.Elapsed.TotalMilliseconds} ms");

                    // Display the parallel downscaled image
                    pictureBox1.Image = parallelDownscaledImage;
                }
                else
                {
                    MessageBox.Show("Please enter a valid downscaling percentage between 1 and 100.");
                }
            }
            else
            {
                MessageBox.Show("Please load an image first.");
            }
        }

        private async Task<Bitmap> DownscaleImageParallelAsync(Bitmap originalImage, int newWidth, int newHeight)
        {
            return await Task.Run(() => ImageDownscaler.DownscaleImageSequential(originalImage, newWidth, newHeight));
        }

    }
}