namespace QRBarcode
{
  partial class Form1
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.upload_pdf = new System.Windows.Forms.Button();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.create_qr = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // upload_pdf
      // 
      this.upload_pdf.Location = new System.Drawing.Point(162, 92);
      this.upload_pdf.Name = "upload_pdf";
      this.upload_pdf.Size = new System.Drawing.Size(151, 41);
      this.upload_pdf.TabIndex = 0;
      this.upload_pdf.Text = "Upload PDF";
      this.upload_pdf.UseVisualStyleBackColor = true;
      this.upload_pdf.Click += new System.EventHandler(this.upload_pdf_Click);
      // 
      // textBox1
      // 
      this.textBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.textBox1.Location = new System.Drawing.Point(12, 31);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(301, 33);
      this.textBox1.TabIndex = 1;
      // 
      // pictureBox1
      // 
      this.pictureBox1.Location = new System.Drawing.Point(345, 31);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(301, 257);
      this.pictureBox1.TabIndex = 2;
      this.pictureBox1.TabStop = false;
      // 
      // create_qr
      // 
      this.create_qr.Location = new System.Drawing.Point(12, 92);
      this.create_qr.Name = "create_qr";
      this.create_qr.Size = new System.Drawing.Size(144, 41);
      this.create_qr.TabIndex = 3;
      this.create_qr.Text = "QR Code";
      this.create_qr.UseVisualStyleBackColor = true;
      this.create_qr.Click += new System.EventHandler(this.create_qr_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(695, 393);
      this.Controls.Add(this.create_qr);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.upload_pdf);
      this.Name = "Form1";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Button upload_pdf;
    private TextBox textBox1;
    private PictureBox pictureBox1;
    private Button create_qr;
  }
}