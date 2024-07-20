namespace ProjetoFinalVoos
{
    partial class FormCompraBilhetes
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
            listBoxVoos = new ListBox();
            label1 = new Label();
            btnCompraBilhete = new Button();
            btnFecha = new Button();
            SuspendLayout();
            // 
            // listBoxVoos
            // 
            listBoxVoos.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxVoos.ForeColor = Color.FromArgb(64, 64, 64);
            listBoxVoos.FormattingEnabled = true;
            listBoxVoos.ItemHeight = 17;
            listBoxVoos.Location = new Point(12, 60);
            listBoxVoos.Name = "listBoxVoos";
            listBoxVoos.Size = new Size(820, 395);
            listBoxVoos.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(348, 18);
            label1.Name = "label1";
            label1.Size = new Size(162, 21);
            label1.TabIndex = 1;
            label1.Text = "Selecione o seu voo";
            // 
            // btnCompraBilhete
            // 
            btnCompraBilhete.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCompraBilhete.ForeColor = Color.FromArgb(64, 64, 64);
            btnCompraBilhete.Location = new Point(701, 472);
            btnCompraBilhete.Name = "btnCompraBilhete";
            btnCompraBilhete.Size = new Size(131, 27);
            btnCompraBilhete.TabIndex = 2;
            btnCompraBilhete.Text = "Comprar Bilhete";
            btnCompraBilhete.UseVisualStyleBackColor = true;
            btnCompraBilhete.Click += btnCompraBilhete_Click;
            // 
            // btnFecha
            // 
            btnFecha.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFecha.ForeColor = Color.FromArgb(64, 64, 64);
            btnFecha.Location = new Point(755, 15);
            btnFecha.Name = "btnFecha";
            btnFecha.Size = new Size(77, 27);
            btnFecha.TabIndex = 3;
            btnFecha.Text = "Voltar";
            btnFecha.UseVisualStyleBackColor = true;
            btnFecha.Click += btnFecha_Click;
            // 
            // FormCompraBilhetes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(859, 514);
            Controls.Add(btnFecha);
            Controls.Add(btnCompraBilhete);
            Controls.Add(label1);
            Controls.Add(listBoxVoos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormCompraBilhetes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Selecionar Voo";
            Load += FormCompraBilhetes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxVoos;
        private Label label1;
        private Button btnCompraBilhete;
        private Button btnFecha;
    }
}