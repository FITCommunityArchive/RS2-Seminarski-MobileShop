﻿namespace MobileShop.WinUI.Obavijesti
{
    partial class frmNovaObavijest
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.rtxtTekst = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pbSlika = new System.Windows.Forms.PictureBox();
            this.txtSlikaInput = new System.Windows.Forms.TextBox();
            this.btnSlikaDodaj = new System.Windows.Forms.Button();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Naslov:";
            // 
            // txtNaslov
            // 
            this.txtNaslov.Location = new System.Drawing.Point(83, 26);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(192, 20);
            this.txtNaslov.TabIndex = 3;
            this.txtNaslov.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNaslov_Validating);
            // 
            // rtxtTekst
            // 
            this.rtxtTekst.Location = new System.Drawing.Point(33, 76);
            this.rtxtTekst.Name = "rtxtTekst";
            this.rtxtTekst.Size = new System.Drawing.Size(242, 234);
            this.rtxtTekst.TabIndex = 4;
            this.rtxtTekst.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tekst:";
            // 
            // pbSlika
            // 
            this.pbSlika.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbSlika.Location = new System.Drawing.Point(3, 16);
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.Size = new System.Drawing.Size(325, 237);
            this.pbSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbSlika.TabIndex = 6;
            this.pbSlika.TabStop = false;
            // 
            // txtSlikaInput
            // 
            this.txtSlikaInput.Location = new System.Drawing.Point(318, 26);
            this.txtSlikaInput.Name = "txtSlikaInput";
            this.txtSlikaInput.Size = new System.Drawing.Size(223, 20);
            this.txtSlikaInput.TabIndex = 7;
            // 
            // btnSlikaDodaj
            // 
            this.btnSlikaDodaj.Location = new System.Drawing.Point(571, 24);
            this.btnSlikaDodaj.Name = "btnSlikaDodaj";
            this.btnSlikaDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnSlikaDodaj.TabIndex = 8;
            this.btnSlikaDodaj.Text = "Dodaj";
            this.btnSlikaDodaj.UseVisualStyleBackColor = true;
            this.btnSlikaDodaj.Click += new System.EventHandler(this.BtnSlikaDodaj_Click);
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(33, 330);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(103, 36);
            this.btnSacuvaj.TabIndex = 9;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.BtnSacuvaj_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbSlika);
            this.groupBox1.Location = new System.Drawing.Point(318, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 256);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Slika";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmNovaObavijest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 378);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.btnSlikaDodaj);
            this.Controls.Add(this.txtSlikaInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtxtTekst);
            this.Controls.Add(this.txtNaslov);
            this.Controls.Add(this.label2);
            this.Name = "frmNovaObavijest";
            this.Text = "frmNovaObavijest";
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.RichTextBox rtxtTekst;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbSlika;
        private System.Windows.Forms.TextBox txtSlikaInput;
        private System.Windows.Forms.Button btnSlikaDodaj;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}