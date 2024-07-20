namespace ProjetoFinalVoos
{
    partial class FormVerVoos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVerVoos));
            listBoxVoos = new ListBox();
            btnComprarBilhetes = new Button();
            btnFechar = new Button();
            comboBoxOrdenar = new ComboBox();
            label1 = new Label();
            pictureBoxLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // listBoxVoos
            // 
            listBoxVoos.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxVoos.ForeColor = Color.FromArgb(64, 64, 64);
            listBoxVoos.FormattingEnabled = true;
            listBoxVoos.ItemHeight = 17;
            listBoxVoos.Location = new Point(11, 114);
            listBoxVoos.Name = "listBoxVoos";
            listBoxVoos.Size = new Size(788, 429);
            listBoxVoos.TabIndex = 0;
            // 
            // btnComprarBilhetes
            // 
            btnComprarBilhetes.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnComprarBilhetes.ForeColor = Color.FromArgb(64, 64, 64);
            btnComprarBilhetes.Location = new Point(670, 555);
            btnComprarBilhetes.Name = "btnComprarBilhetes";
            btnComprarBilhetes.Size = new Size(129, 27);
            btnComprarBilhetes.TabIndex = 1;
            btnComprarBilhetes.Text = "Comprar Bilhetes";
            btnComprarBilhetes.UseVisualStyleBackColor = true;
            btnComprarBilhetes.Click += btnComprarBilhetes_Click;
            // 
            // btnFechar
            // 
            btnFechar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnFechar.ForeColor = Color.FromArgb(64, 64, 64);
            btnFechar.Location = new Point(722, 12);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(77, 27);
            btnFechar.TabIndex = 1;
            btnFechar.Text = "Voltar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // comboBoxOrdenar
            // 
            comboBoxOrdenar.ForeColor = Color.FromArgb(64, 64, 64);
            comboBoxOrdenar.FormattingEnabled = true;
            comboBoxOrdenar.Items.AddRange(new object[] { "Data", "Origem", "Ambos" });
            comboBoxOrdenar.Location = new Point(678, 74);
            comboBoxOrdenar.Name = "comboBoxOrdenar";
            comboBoxOrdenar.Size = new Size(121, 23);
            comboBoxOrdenar.TabIndex = 3;
            comboBoxOrdenar.SelectedIndexChanged += comboBoxOrdenar_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(584, 75);
            label1.Name = "label1";
            label1.Size = new Size(88, 17);
            label1.TabIndex = 4;
            label1.Text = "Ordenar por:";
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(12, 12);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(74, 61);
            pictureBoxLogo.TabIndex = 12;
            pictureBoxLogo.TabStop = false;
            // 
            // FormVerVoos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(808, 599);
            Controls.Add(pictureBoxLogo);
            Controls.Add(label1);
            Controls.Add(comboBoxOrdenar);
            Controls.Add(btnFechar);
            Controls.Add(btnComprarBilhetes);
            Controls.Add(listBoxVoos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormVerVoos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ver Voos";
            Load += FormVerVoos_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxVoos;
        private Button btnComprarBilhetes;
        private Button btnFechar;
        private ComboBox comboBoxOrdenar;
        private Label label1;
        private PictureBox pictureBoxLogo;
    }
}