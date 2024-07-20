namespace ProjetoFinalVoos
{
    partial class CRUDAparelho
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
            label1 = new Label();
            txtTipo = new TextBox();
            label2 = new Label();
            numericUpDown = new NumericUpDown();
            AparelhosListBox = new ListBox();
            btnCriar = new Button();
            btnApagar = new Button();
            btnEdita = new Button();
            label3 = new Label();
            txtId = new TextBox();
            btnCancela = new Button();
            btnFechar = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 65);
            label1.Name = "label1";
            label1.Size = new Size(44, 17);
            label1.TabIndex = 0;
            label1.Text = "Tipo: ";
            // 
            // txtTipo
            // 
            txtTipo.ForeColor = Color.FromArgb(64, 64, 64);
            txtTipo.Location = new Point(111, 55);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(120, 23);
            txtTipo.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(224, 224, 224);
            label2.Location = new Point(12, 105);
            label2.Name = "label2";
            label2.Size = new Size(82, 17);
            label2.TabIndex = 2;
            label2.Text = "Capacidade:";
            // 
            // numericUpDown
            // 
            numericUpDown.ForeColor = Color.FromArgb(64, 64, 64);
            numericUpDown.Location = new Point(111, 99);
            numericUpDown.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numericUpDown.Name = "numericUpDown";
            numericUpDown.Size = new Size(120, 23);
            numericUpDown.TabIndex = 1;
            // 
            // AparelhosListBox
            // 
            AparelhosListBox.BackColor = Color.White;
            AparelhosListBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AparelhosListBox.ForeColor = Color.FromArgb(64, 64, 64);
            AparelhosListBox.FormattingEnabled = true;
            AparelhosListBox.ItemHeight = 15;
            AparelhosListBox.Location = new Point(12, 155);
            AparelhosListBox.Name = "AparelhosListBox";
            AparelhosListBox.Size = new Size(518, 199);
            AparelhosListBox.TabIndex = 4;
            // 
            // btnCriar
            // 
            btnCriar.BackColor = Color.White;
            btnCriar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCriar.ForeColor = Color.FromArgb(64, 64, 64);
            btnCriar.Location = new Point(421, 38);
            btnCriar.Name = "btnCriar";
            btnCriar.Size = new Size(109, 27);
            btnCriar.TabIndex = 2;
            btnCriar.Text = "Criar Aparelho";
            btnCriar.UseVisualStyleBackColor = false;
            btnCriar.Click += btnCriar_Click;
            // 
            // btnApagar
            // 
            btnApagar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnApagar.ForeColor = Color.FromArgb(64, 64, 64);
            btnApagar.Location = new Point(541, 326);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(142, 27);
            btnApagar.TabIndex = 5;
            btnApagar.Text = "Eliminar Aparelho";
            btnApagar.UseVisualStyleBackColor = true;
            btnApagar.Click += btnApagar_Click;
            // 
            // btnEdita
            // 
            btnEdita.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdita.ForeColor = Color.FromArgb(64, 64, 64);
            btnEdita.Location = new Point(541, 281);
            btnEdita.Name = "btnEdita";
            btnEdita.Size = new Size(142, 27);
            btnEdita.TabIndex = 5;
            btnEdita.Text = "Editar Aparelho";
            btnEdita.UseVisualStyleBackColor = true;
            btnEdita.Click += btnEdita_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 22);
            label3.Name = "label3";
            label3.Size = new Size(26, 17);
            label3.TabIndex = 0;
            label3.Text = "ID:";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.ForeColor = Color.FromArgb(64, 64, 64);
            txtId.Location = new Point(111, 12);
            txtId.Name = "txtId";
            txtId.Size = new Size(120, 23);
            txtId.TabIndex = 0;
            txtId.TextAlign = HorizontalAlignment.Center;
            // 
            // btnCancela
            // 
            btnCancela.BackColor = Color.White;
            btnCancela.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancela.ForeColor = Color.FromArgb(64, 64, 64);
            btnCancela.Location = new Point(451, 80);
            btnCancela.Name = "btnCancela";
            btnCancela.Size = new Size(79, 27);
            btnCancela.TabIndex = 6;
            btnCancela.Text = "Cancelar";
            btnCancela.UseVisualStyleBackColor = false;
            btnCancela.Click += btnCancela_Click;
            // 
            // btnFechar
            // 
            btnFechar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFechar.ForeColor = Color.FromArgb(64, 64, 64);
            btnFechar.Location = new Point(609, 16);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(74, 27);
            btnFechar.TabIndex = 7;
            btnFechar.Text = "Voltar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // CRUDAparelho
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(695, 369);
            Controls.Add(btnFechar);
            Controls.Add(btnCancela);
            Controls.Add(btnEdita);
            Controls.Add(btnApagar);
            Controls.Add(btnCriar);
            Controls.Add(AparelhosListBox);
            Controls.Add(numericUpDown);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(txtTipo);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "CRUDAparelho";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Criar Aparelho";
            FormClosing += CRUDAparelho_FormClosing;
            Load += CRUDAparelho_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTipo;
        private Label label2;
        private NumericUpDown numericUpDown;
        private ListBox AparelhosListBox;
        private Button btnCriar;
        private Button btnApagar;
        private Button btnEdita;
        private Label label3;
        private TextBox txtId;
        private Button btnCancela;
        private Button btnFechar;
    }
}