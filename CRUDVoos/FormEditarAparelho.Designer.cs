namespace ProjetoFinalVoos
{
    partial class FormEditarAparelho
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
            txtId = new TextBox();
            txtTipo = new TextBox();
            numericUpDown = new NumericUpDown();
            btnGuarda = new Button();
            btnCancela = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown).BeginInit();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtId.ForeColor = Color.FromArgb(64, 64, 64);
            txtId.Location = new Point(110, 19);
            txtId.Name = "txtId";
            txtId.Size = new Size(180, 23);
            txtId.TabIndex = 0;
            txtId.TextAlign = HorizontalAlignment.Center;
            // 
            // txtTipo
            // 
            txtTipo.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTipo.ForeColor = Color.FromArgb(64, 64, 64);
            txtTipo.Location = new Point(110, 71);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(180, 25);
            txtTipo.TabIndex = 1;
            // 
            // numericUpDown
            // 
            numericUpDown.ForeColor = Color.FromArgb(64, 64, 64);
            numericUpDown.Location = new Point(110, 125);
            numericUpDown.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numericUpDown.Name = "numericUpDown";
            numericUpDown.Size = new Size(180, 23);
            numericUpDown.TabIndex = 2;
            // 
            // btnGuarda
            // 
            btnGuarda.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuarda.ForeColor = Color.FromArgb(64, 64, 64);
            btnGuarda.Location = new Point(176, 182);
            btnGuarda.Name = "btnGuarda";
            btnGuarda.Size = new Size(77, 27);
            btnGuarda.TabIndex = 3;
            btnGuarda.Text = "Guardar";
            btnGuarda.UseVisualStyleBackColor = true;
            btnGuarda.Click += btnGuarda_Click;
            // 
            // btnCancela
            // 
            btnCancela.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancela.ForeColor = Color.FromArgb(64, 64, 64);
            btnCancela.Location = new Point(59, 182);
            btnCancela.Name = "btnCancela";
            btnCancela.Size = new Size(77, 27);
            btnCancela.TabIndex = 4;
            btnCancela.Text = "Cancelar";
            btnCancela.UseVisualStyleBackColor = true;
            btnCancela.Click += btnCancela_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(16, 73);
            label1.Name = "label1";
            label1.Size = new Size(40, 17);
            label1.TabIndex = 5;
            label1.Text = "Tipo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(16, 126);
            label2.Name = "label2";
            label2.Size = new Size(82, 17);
            label2.TabIndex = 6;
            label2.Text = "Capacidade:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(16, 20);
            label3.Name = "label3";
            label3.Size = new Size(26, 17);
            label3.TabIndex = 7;
            label3.Text = "ID:";
            // 
            // FormEditarAparelho
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(306, 221);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancela);
            Controls.Add(btnGuarda);
            Controls.Add(numericUpDown);
            Controls.Add(txtTipo);
            Controls.Add(txtId);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormEditarAparelho";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Aparelho";
            ((System.ComponentModel.ISupportInitialize)numericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private TextBox txtTipo;
        private NumericUpDown numericUpDown;
        private Button btnGuarda;
        private Button btnCancela;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}