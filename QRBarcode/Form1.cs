using QRCoder;

namespace QRBarcode
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void upload_pdf_Click(object sender, EventArgs e)
    {

      OpenFileDialog Openpdf = new OpenFileDialog();
      Openpdf.Filter = "PDF files|*.pdf|All files|*.*;";
      var src = "";
      if (Openpdf.ShowDialog() == DialogResult.OK)
      {
        string pdfLog = Openpdf.FileName.ToString();
        upload_pdf.Text = pdfLog;
         src = Openpdf.FileName;
        //pdfUploadbox.Text = pdfLog;
      }
      if (src == "")
      {
        MessageBox.Show("Try new file");
      }
      else { MessageBox.Show("PDF Uploaded"); }


    
    }

    private void create_qr_Click(object sender, EventArgs e)
    {
      QRCodeGenerator qrGenerator = new QRCodeGenerator();
      var input = textBox1.Text;
      QRCodeData qrCodeData = qrGenerator.CreateQrCode(input, QRCodeGenerator.ECCLevel.Q);
      QRCode qrCode = new QRCode(qrCodeData);
      Bitmap qrCodeImage = qrCode.GetGraphic(2);
      pictureBox1.Image = qrCodeImage;
    }
  }
}