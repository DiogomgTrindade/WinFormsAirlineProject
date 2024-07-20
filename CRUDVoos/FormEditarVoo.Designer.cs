namespace ProjetoFinalVoos
{
    partial class FormEditarVoo
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
            comboBoxAparelhos = new ComboBox();
            dateTimePicker = new DateTimePicker();
            txtDestino = new TextBox();
            txtHora = new TextBox();
            txtOrigem = new TextBox();
            txtNumeroVoo = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnCancela = new Button();
            btnGuarda = new Button();
            SuspendLayout();
            // 
            // comboBoxAparelhos
            // 
            comboBoxAparelhos.ForeColor = Color.FromArgb(64, 64, 64);
            comboBoxAparelhos.FormattingEnabled = true;
            comboBoxAparelhos.Location = new Point(144, 156);
            comboBoxAparelhos.Name = "comboBoxAparelhos";
            comboBoxAparelhos.Size = new Size(233, 23);
            comboBoxAparelhos.TabIndex = 20;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Format = DateTimePickerFormat.Short;
            dateTimePicker.Location = new Point(144, 201);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(233, 23);
            dateTimePicker.TabIndex = 21;
            // 
            // txtDestino
            // 
            txtDestino.ForeColor = Color.FromArgb(64, 64, 64);
            txtDestino.Location = new Point(144, 110);
            txtDestino.Name = "txtDestino";
            txtDestino.Size = new Size(233, 23);
            txtDestino.TabIndex = 19;
            // 
            // txtHora
            // 
            txtHora.ForeColor = Color.FromArgb(64, 64, 64);
            txtHora.Location = new Point(144, 248);
            txtHora.Name = "txtHora";
            txtHora.Size = new Size(233, 23);
            txtHora.TabIndex = 22;
            // 
            // txtOrigem
            // 
            txtOrigem.ForeColor = Color.FromArgb(64, 64, 64);
            txtOrigem.Location = new Point(144, 64);
            txtOrigem.Name = "txtOrigem";
            txtOrigem.Size = new Size(233, 23);
            txtOrigem.TabIndex = 15;
            // 
            // txtNumeroVoo
            // 
            txtNumeroVoo.Enabled = false;
            txtNumeroVoo.ForeColor = Color.FromArgb(64, 64, 64);
            txtNumeroVoo.Location = new Point(144, 18);
            txtNumeroVoo.Name = "txtNumeroVoo";
            txtNumeroVoo.Size = new Size(233, 23);
            txtNumeroVoo.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(12, 251);
            label6.Name = "label6";
            label6.Size = new Size(42, 17);
            label6.TabIndex = 16;
            label6.Text = "Hora:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(12, 205);
            label5.Name = "label5";
            label5.Size = new Size(41, 17);
            label5.TabIndex = 12;
            label5.Text = "Data:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 159);
            label4.Name = "label4";
            label4.Size = new Size(68, 17);
            label4.TabIndex = 17;
            label4.Text = "Aparelho:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 113);
            label3.Name = "label3";
            label3.Size = new Size(60, 17);
            label3.TabIndex = 13;
            label3.Text = "Destino:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 67);
            label2.Name = "label2";
            label2.Size = new Size(58, 17);
            label2.TabIndex = 18;
            label2.Text = "Origem:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(110, 17);
            label1.TabIndex = 14;
            label1.Text = "Número do Voo:";
            // 
            // btnCancela
            // 
            btnCancela.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnCancela.ForeColor = Color.FromArgb(64, 64, 64);
            btnCancela.Location = new Point(74, 305);
            btnCancela.Name = "btnCancela";
            btnCancela.Size = new Size(91, 27);
            btnCancela.TabIndex = 25;
            btnCancela.Text = "Cancelar";
            btnCancela.UseVisualStyleBackColor = true;
            btnCancela.Click += btnCancela_Click;
            // 
            // btnGuarda
            // 
            btnGuarda.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnGuarda.ForeColor = Color.FromArgb(64, 64, 64);
            btnGuarda.Location = new Point(235, 305);
            btnGuarda.Name = "btnGuarda";
            btnGuarda.Size = new Size(91, 27);
            btnGuarda.TabIndex = 24;
            btnGuarda.Text = "Guardar";
            btnGuarda.UseVisualStyleBackColor = true;
            btnGuarda.Click += btnGuarda_Click;
            // 
            // FormEditarVoo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(400, 348);
            Controls.Add(btnCancela);
            Controls.Add(btnGuarda);
            Controls.Add(comboBoxAparelhos);
            Controls.Add(dateTimePicker);
            Controls.Add(txtDestino);
            Controls.Add(txtHora);
            Controls.Add(txtOrigem);
            Controls.Add(txtNumeroVoo);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormEditarVoo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Voo";
            Load += FormEditarVoo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxAparelhos;
        private DateTimePicker dateTimePicker;
        private TextBox txtDestino;
        private TextBox txtHora;
        private TextBox txtOrigem;
        private TextBox txtNumeroVoo;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnCancela;
        private Button btnGuarda;
    }
}