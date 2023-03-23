using QRCoder;

namespace QRBarcode
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void save_qr_Click(object sender, EventArgs e)
    {
      var dialog = new SaveFileDialog();
      if (File_Path_Text != null)
      {
        dialog.InitialDirectory = File_Path_Text.Text;

      }
      
      if(File_Name_Text != null)
      {
        dialog.FileName = File_Name_Text.Text;
      }

      if (dialog.ShowDialog() == DialogResult.OK)
      {
        pictureBox1.Image.Save(dialog.FileName);

      }

    }

    private void create_qr_Click(object sender, EventArgs e)
    {
      QRCodeGenerator qrGenerator = new QRCodeGenerator();
      var input = Data_Text.Text;
      QRCodeData qrCodeData = qrGenerator.CreateQrCode(input, QRCodeGenerator.ECCLevel.Q);
      QRCode qrCode = new QRCode(qrCodeData);

      Bitmap qrCodeImage = qrCode.GetGraphic(20);
     
      pictureBox1.Image = qrCodeImage;
      pictureBox1.Height = qrCodeImage.Height;
      pictureBox1.Width = qrCodeImage.Width;
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {

    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {

    }
  }
}