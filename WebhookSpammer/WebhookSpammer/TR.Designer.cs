
namespace WebhookSpammer
{
    partial class TR
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.webhookURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.webhookName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.profil = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.content = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.everyone = new System.Windows.Forms.CheckBox();
            this.sayi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webhookURL
            // 
            this.webhookURL.Location = new System.Drawing.Point(12, 23);
            this.webhookURL.Name = "webhookURL";
            this.webhookURL.Size = new System.Drawing.Size(452, 20);
            this.webhookURL.TabIndex = 0;
            this.webhookURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Webhook Adresi";
            // 
            // webhookName
            // 
            this.webhookName.Location = new System.Drawing.Point(12, 70);
            this.webhookName.Name = "webhookName";
            this.webhookName.Size = new System.Drawing.Size(452, 20);
            this.webhookName.TabIndex = 0;
            this.webhookName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Webhook Adı Ne Olsun?";
            // 
            // profil
            // 
            this.profil.Location = new System.Drawing.Point(12, 119);
            this.profil.Name = "profil";
            this.profil.Size = new System.Drawing.Size(452, 20);
            this.profil.TabIndex = 0;
            this.profil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Webhook Profil Fotoğrafı Linki? (Şu anlık kapalı)";
            // 
            // content
            // 
            this.content.Location = new System.Drawing.Point(12, 172);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(452, 20);
            this.content.TabIndex = 0;
            this.content.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ne mesaj yazmak istiyorsunuz?";
            // 
            // everyone
            // 
            this.everyone.AutoSize = true;
            this.everyone.Location = new System.Drawing.Point(12, 198);
            this.everyone.Name = "everyone";
            this.everyone.Size = new System.Drawing.Size(125, 17);
            this.everyone.TabIndex = 2;
            this.everyone.Text = "@everyone atsın mı?";
            this.everyone.UseVisualStyleBackColor = true;
            // 
            // sayi
            // 
            this.sayi.Location = new System.Drawing.Point(144, 224);
            this.sayi.Name = "sayi";
            this.sayi.Size = new System.Drawing.Size(39, 20);
            this.sayi.TabIndex = 0;
            this.sayi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Kaç adet mesaj yollansın?";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(452, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Başlat!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 283);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.everyone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.content);
            this.Controls.Add(this.sayi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.profil);
            this.Controls.Add(this.webhookName);
            this.Controls.Add(this.webhookURL);
            this.Name = "TR";
            this.Text = "Webhook Spammer by Fahrettin Enes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox webhookURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox webhookName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox profil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox content;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox everyone;
        private System.Windows.Forms.TextBox sayi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}