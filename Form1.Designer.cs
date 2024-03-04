namespace StokTakip12AApp
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
            btnGet = new Button();
            txtAdres = new TextBox();
            label1 = new Label();
            btnPost = new Button();
            txtPostParamtre = new TextBox();
            txtResponse = new TextBox();
            lblStatusCode = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // btnGet
            // 
            btnGet.Location = new Point(627, 77);
            btnGet.Margin = new Padding(3, 4, 3, 4);
            btnGet.Name = "btnGet";
            btnGet.Size = new Size(123, 31);
            btnGet.TabIndex = 0;
            btnGet.Text = "GET";
            btnGet.UseVisualStyleBackColor = true;
            btnGet.Click += btnGet_Click;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(95, 39);
            txtAdres.Margin = new Padding(3, 4, 3, 4);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(655, 27);
            txtAdres.TabIndex = 1;
            txtAdres.Text = "https://stoktakip.kurall.com/api/v1/";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 49);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 2;
            label1.Text = "Adres";
            // 
            // btnPost
            // 
            btnPost.Location = new Point(627, 116);
            btnPost.Margin = new Padding(3, 4, 3, 4);
            btnPost.Name = "btnPost";
            btnPost.Size = new Size(123, 31);
            btnPost.TabIndex = 0;
            btnPost.Text = "POST";
            btnPost.UseVisualStyleBackColor = true;
            btnPost.Click += btnPost_Click;
            // 
            // txtPostParamtre
            // 
            txtPostParamtre.Location = new Point(70, 117);
            txtPostParamtre.Margin = new Padding(3, 4, 3, 4);
            txtPostParamtre.Name = "txtPostParamtre";
            txtPostParamtre.Size = new Size(550, 27);
            txtPostParamtre.TabIndex = 1;
            // 
            // txtResponse
            // 
            txtResponse.Location = new Point(14, 204);
            txtResponse.Margin = new Padding(3, 4, 3, 4);
            txtResponse.Multiline = true;
            txtResponse.Name = "txtResponse";
            txtResponse.Size = new Size(886, 379);
            txtResponse.TabIndex = 1;
            // 
            // lblStatusCode
            // 
            lblStatusCode.AutoSize = true;
            lblStatusCode.Location = new Point(21, 179);
            lblStatusCode.Name = "lblStatusCode";
            lblStatusCode.Size = new Size(50, 20);
            lblStatusCode.TabIndex = 3;
            lblStatusCode.Text = "label2";
            // 
            // button1
            // 
            button1.Location = new Point(109, 168);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(213, 168);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(220, 31);
            button2.TabIndex = 4;
            button2.Text = "Kategorileri Getir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(439, 168);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(220, 31);
            button3.TabIndex = 4;
            button3.Text = "Urunleri Getir";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblStatusCode);
            Controls.Add(label1);
            Controls.Add(txtResponse);
            Controls.Add(txtPostParamtre);
            Controls.Add(txtAdres);
            Controls.Add(btnPost);
            Controls.Add(btnGet);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGet;
        private TextBox txtAdres;
        private Label label1;
        private Button btnPost;
        private TextBox txtPostParamtre;
        private TextBox txtResponse;
        private Label lblStatusCode;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}