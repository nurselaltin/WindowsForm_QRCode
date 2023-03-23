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
      this.save_qr = new System.Windows.Forms.Button();
      this.Data_Text = new System.Windows.Forms.TextBox();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.create_qr = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.Path = new System.Windows.Forms.Label();
      this.File_Path_Text = new System.Windows.Forms.TextBox();
      this.File_Name = new System.Windows.Forms.Label();
      this.File_Name_Text = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // save_qr
      // 
      this.save_qr.Location = new System.Drawing.Point(162, 232);
      this.save_qr.Name = "save_qr";
      this.save_qr.Size = new System.Drawing.Size(151, 41);
      this.save_qr.TabIndex = 0;
      this.save_qr.Text = "Save Qr";
      this.save_qr.UseVisualStyleBackColor = true;
      this.save_qr.Click += new System.EventHandler(this.save_qr_Click);
      // 
      // Data_Text
      // 
      this.Data_Text.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.Data_Text.Location = new System.Drawing.Point(12, 31);
      this.Data_Text.Name = "Data_Text";
      this.Data_Text.Size = new System.Drawing.Size(301, 33);
      this.Data_Text.TabIndex = 1;
      // 
      // pictureBox1
      // 
      this.pictureBox1.Location = new System.Drawing.Point(345, 31);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(347, 350);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
      this.pictureBox1.TabIndex = 2;
      this.pictureBox1.TabStop = false;
      this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
      // 
      // create_qr
      // 
      this.create_qr.Location = new System.Drawing.Point(12, 232);
      this.create_qr.Name = "create_qr";
      this.create_qr.Size = new System.Drawing.Size(144, 41);
      this.create_qr.TabIndex = 3;
      this.create_qr.Text = "QR Code";
      this.create_qr.UseVisualStyleBackColor = true;
      this.create_qr.Click += new System.EventHandler(this.create_qr_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(31, 15);
      this.label1.TabIndex = 4;
      this.label1.Text = "Data";
      // 
      // Path
      // 
      this.Path.AutoSize = true;
      this.Path.Location = new System.Drawing.Point(12, 151);
      this.Path.Name = "Path";
      this.Path.Size = new System.Drawing.Size(52, 15);
      this.Path.TabIndex = 6;
      this.Path.Text = "File Path";
      this.Path.Click += new System.EventHandler(this.label2_Click);
      // 
      // File_Path_Text
      // 
      this.File_Path_Text.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.File_Path_Text.Location = new System.Drawing.Point(12, 180);
      this.File_Path_Text.Name = "File_Path_Text";
      this.File_Path_Text.Size = new System.Drawing.Size(301, 33);
      this.File_Path_Text.TabIndex = 5;
      this.File_Path_Text.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
      // 
      // File_Name
      // 
      this.File_Name.AutoSize = true;
      this.File_Name.Location = new System.Drawing.Point(12, 72);
      this.File_Name.Name = "File_Name";
      this.File_Name.Size = new System.Drawing.Size(60, 15);
      this.File_Name.TabIndex = 8;
      this.File_Name.Text = "File Name";
      // 
      // File_Name_Text
      // 
      this.File_Name_Text.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.File_Name_Text.Location = new System.Drawing.Point(12, 102);
      this.File_Name_Text.Name = "File_Name_Text";
      this.File_Name_Text.Size = new System.Drawing.Size(301, 33);
      this.File_Name_Text.TabIndex = 7;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(695, 393);
      this.Controls.Add(this.File_Name);
      this.Controls.Add(this.File_Name_Text);
      this.Controls.Add(this.Path);
      this.Controls.Add(this.File_Path_Text);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.create_qr);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.Data_Text);
      this.Controls.Add(this.save_qr);
      this.Name = "Form1";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Button save_qr;
    private TextBox Data_Text;
    private PictureBox pictureBox1;
    private Button create_qr;
    private Label label1;
    private Label Path;
    private TextBox File_Path_Text;
    private Label File_Name;
    private TextBox File_Name_Text;
  }
}