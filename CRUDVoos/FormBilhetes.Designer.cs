namespace ProjetoFinalVoos
{
    partial class FormBilhetes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBilhetes));
            lblDadosVoo = new Label();
            comboBoxLugar = new ComboBox();
            label1 = new Label();
            textBoxNome = new TextBox();
            label2 = new Label();
            btnComprarBilhete = new Button();
            label3 = new Label();
            label4 = new Label();
            comboBoxBagaguem = new ComboBox();
            comboBoxPes = new ComboBox();
            comboBoxEmbarque = new ComboBox();
            label5 = new Label();
            comboBoxFastTrack = new ComboBox();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblDadosVoo
            // 
            lblDadosVoo.AutoSize = true;
            lblDadosVoo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDadosVoo.ForeColor = Color.White;
            lblDadosVoo.Location = new Point(20, 31);
            lblDadosVoo.Name = "lblDadosVoo";
            lblDadosVoo.Size = new Size(65, 15);
            lblDadosVoo.TabIndex = 5;
            lblDadosVoo.Text = "Dados Voo";
            // 
            // comboBoxLugar
            // 
            comboBoxLugar.ForeColor = Color.FromArgb(64, 64, 64);
            comboBoxLugar.FormattingEnabled = true;
            comboBoxLugar.Location = new Point(220, 212);
            comboBoxLugar.Name = "comboBoxLugar";
            comboBoxLugar.Size = new Size(167, 23);
            comboBoxLugar.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(24, 156);
            label1.Name = "label1";
            label1.Size = new Size(143, 17);
            label1.TabIndex = 5;
            label1.Text = "Nome do passageiro: ";
            // 
            // textBoxNome
            // 
            textBoxNome.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNome.ForeColor = Color.FromArgb(64, 64, 64);
            textBoxNome.Location = new Point(220, 153);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(167, 25);
            textBoxNome.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(24, 213);
            label2.Name = "label2";
            label2.Size = new Size(127, 17);
            label2.TabIndex = 5;
            label2.Text = "Escolha o seu lugar";
            // 
            // btnComprarBilhete
            // 
            btnComprarBilhete.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnComprarBilhete.ForeColor = Color.FromArgb(64, 64, 64);
            btnComprarBilhete.Location = new Point(502, 90);
            btnComprarBilhete.Name = "btnComprarBilhete";
            btnComprarBilhete.Size = new Size(127, 27);
            btnComprarBilhete.TabIndex = 2;
            btnComprarBilhete.Text = "Comprar Bilhete";
            btnComprarBilhete.UseVisualStyleBackColor = true;
            btnComprarBilhete.Click += btnComprarBilhete_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(24, 270);
            label3.Name = "label3";
            label3.Size = new Size(116, 17);
            label3.TabIndex = 5;
            label3.Text = "Bagaguem extra: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(24, 327);
            label4.Name = "label4";
            label4.Size = new Size(173, 17);
            label4.TabIndex = 5;
            label4.Text = "Espaço extra para pernas:  ";
            // 
            // comboBoxBagaguem
            // 
            comboBoxBagaguem.ForeColor = Color.FromArgb(64, 64, 64);
            comboBoxBagaguem.FormattingEnabled = true;
            comboBoxBagaguem.Items.AddRange(new object[] { "Sim", "Não" });
            comboBoxBagaguem.Location = new Point(220, 269);
            comboBoxBagaguem.Name = "comboBoxBagaguem";
            comboBoxBagaguem.Size = new Size(167, 23);
            comboBoxBagaguem.TabIndex = 1;
            // 
            // comboBoxPes
            // 
            comboBoxPes.ForeColor = Color.FromArgb(64, 64, 64);
            comboBoxPes.FormattingEnabled = true;
            comboBoxPes.Items.AddRange(new object[] { "Sim", "Não" });
            comboBoxPes.Location = new Point(220, 326);
            comboBoxPes.Name = "comboBoxPes";
            comboBoxPes.Size = new Size(167, 23);
            comboBoxPes.TabIndex = 1;
            // 
            // comboBoxEmbarque
            // 
            comboBoxEmbarque.ForeColor = Color.FromArgb(64, 64, 64);
            comboBoxEmbarque.FormattingEnabled = true;
            comboBoxEmbarque.Items.AddRange(new object[] { "Sim", "Não" });
            comboBoxEmbarque.Location = new Point(220, 383);
            comboBoxEmbarque.Name = "comboBoxEmbarque";
            comboBoxEmbarque.Size = new Size(167, 23);
            comboBoxEmbarque.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(24, 384);
            label5.Name = "label5";
            label5.Size = new Size(149, 17);
            label5.TabIndex = 5;
            label5.Text = "Embarque prioritário:  ";
            // 
            // comboBoxFastTrack
            // 
            comboBoxFastTrack.ForeColor = Color.FromArgb(64, 64, 64);
            comboBoxFastTrack.FormattingEnabled = true;
            comboBoxFastTrack.Items.AddRange(new object[] { "Sim", "Não" });
            comboBoxFastTrack.Location = new Point(220, 440);
            comboBoxFastTrack.Name = "comboBoxFastTrack";
            comboBoxFastTrack.Size = new Size(167, 23);
            comboBoxFastTrack.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(24, 441);
            label6.Name = "label6";
            label6.Size = new Size(80, 17);
            label6.TabIndex = 5;
            label6.Text = "Fast track:  ";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(422, 153);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(207, 310);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(20, 89);
            label7.Name = "label7";
            label7.Size = new Size(197, 25);
            label7.TabIndex = 14;
            label7.Text = "Dados do passageiro";
            // 
            // FormBilhetes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(651, 497);
            Controls.Add(label7);
            Controls.Add(pictureBox1);
            Controls.Add(btnComprarBilhete);
            Controls.Add(textBoxNome);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBoxFastTrack);
            Controls.Add(label2);
            Controls.Add(comboBoxEmbarque);
            Controls.Add(label1);
            Controls.Add(comboBoxPes);
            Controls.Add(comboBoxBagaguem);
            Controls.Add(comboBoxLugar);
            Controls.Add(lblDadosVoo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormBilhetes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Comprar Bilhetes";
            Load += FormBilhetes_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDadosVoo;
        private ComboBox comboBoxLugar;
        private Label label1;
        private TextBox textBoxNome;
        private Label label2;
        private Button btnComprarBilhete;
        private Label label3;
        private Label label4;
        private ComboBox comboBoxBagaguem;
        private ComboBox comboBoxPes;
        private ComboBox comboBoxEmbarque;
        private Label label5;
        private ComboBox comboBoxFastTrack;
        private Label label6;
        private PictureBox pictureBox1;
        private Label label7;
    }
}