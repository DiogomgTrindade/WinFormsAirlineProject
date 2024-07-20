namespace ProjetoFinalVoos
{
    partial class CRUDVoo
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtNumeroVoo = new TextBox();
            txtOrigem = new TextBox();
            txtHora = new TextBox();
            txtDestino = new TextBox();
            dateTimePicker = new DateTimePicker();
            listBoxVoos = new ListBox();
            btnCriar = new Button();
            comboBoxAparelhos = new ComboBox();
            btnGerarNumero = new Button();
            btnFechar = new Button();
            btnEditar = new Button();
            btnApagar = new Button();
            btnComprarVoo = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(21, 22);
            label1.Name = "label1";
            label1.Size = new Size(110, 17);
            label1.TabIndex = 0;
            label1.Text = "Número do Voo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(21, 68);
            label2.Name = "label2";
            label2.Size = new Size(58, 17);
            label2.TabIndex = 1;
            label2.Text = "Origem:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(21, 114);
            label3.Name = "label3";
            label3.Size = new Size(60, 17);
            label3.TabIndex = 0;
            label3.Text = "Destino:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(21, 160);
            label4.Name = "label4";
            label4.Size = new Size(68, 17);
            label4.TabIndex = 1;
            label4.Text = "Aparelho:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(21, 206);
            label5.Name = "label5";
            label5.Size = new Size(41, 17);
            label5.TabIndex = 0;
            label5.Text = "Data:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(21, 252);
            label6.Name = "label6";
            label6.Size = new Size(42, 17);
            label6.TabIndex = 1;
            label6.Text = "Hora:";
            // 
            // txtNumeroVoo
            // 
            txtNumeroVoo.Enabled = false;
            txtNumeroVoo.ForeColor = Color.FromArgb(64, 64, 64);
            txtNumeroVoo.Location = new Point(153, 19);
            txtNumeroVoo.Name = "txtNumeroVoo";
            txtNumeroVoo.Size = new Size(100, 23);
            txtNumeroVoo.TabIndex = 11;
            // 
            // txtOrigem
            // 
            txtOrigem.ForeColor = Color.FromArgb(64, 64, 64);
            txtOrigem.Location = new Point(153, 65);
            txtOrigem.Name = "txtOrigem";
            txtOrigem.Size = new Size(233, 23);
            txtOrigem.TabIndex = 1;
            // 
            // txtHora
            // 
            txtHora.ForeColor = Color.FromArgb(64, 64, 64);
            txtHora.Location = new Point(153, 249);
            txtHora.Name = "txtHora";
            txtHora.Size = new Size(233, 23);
            txtHora.TabIndex = 5;
            // 
            // txtDestino
            // 
            txtDestino.ForeColor = Color.FromArgb(64, 64, 64);
            txtDestino.Location = new Point(153, 111);
            txtDestino.Name = "txtDestino";
            txtDestino.Size = new Size(233, 23);
            txtDestino.TabIndex = 2;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Format = DateTimePickerFormat.Short;
            dateTimePicker.Location = new Point(153, 201);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(233, 23);
            dateTimePicker.TabIndex = 4;
            // 
            // listBoxVoos
            // 
            listBoxVoos.ForeColor = Color.FromArgb(64, 64, 64);
            listBoxVoos.FormattingEnabled = true;
            listBoxVoos.ItemHeight = 15;
            listBoxVoos.Location = new Point(12, 294);
            listBoxVoos.Name = "listBoxVoos";
            listBoxVoos.Size = new Size(776, 124);
            listBoxVoos.TabIndex = 10;
            // 
            // btnCriar
            // 
            btnCriar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCriar.ForeColor = Color.FromArgb(64, 64, 64);
            btnCriar.Location = new Point(688, 249);
            btnCriar.Name = "btnCriar";
            btnCriar.Size = new Size(100, 27);
            btnCriar.TabIndex = 6;
            btnCriar.Text = "Criar Voo";
            btnCriar.UseVisualStyleBackColor = true;
            btnCriar.Click += btnCriar_Click;
            // 
            // comboBoxAparelhos
            // 
            comboBoxAparelhos.ForeColor = Color.FromArgb(64, 64, 64);
            comboBoxAparelhos.FormattingEnabled = true;
            comboBoxAparelhos.Location = new Point(153, 157);
            comboBoxAparelhos.Name = "comboBoxAparelhos";
            comboBoxAparelhos.Size = new Size(233, 23);
            comboBoxAparelhos.TabIndex = 3;
            // 
            // btnGerarNumero
            // 
            btnGerarNumero.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGerarNumero.ForeColor = Color.FromArgb(64, 64, 64);
            btnGerarNumero.Location = new Point(274, 19);
            btnGerarNumero.Name = "btnGerarNumero";
            btnGerarNumero.Size = new Size(112, 23);
            btnGerarNumero.TabIndex = 0;
            btnGerarNumero.Text = "Gerar Número";
            btnGerarNumero.UseVisualStyleBackColor = true;
            btnGerarNumero.Click += btnGerarNumero_Click;
            // 
            // btnFechar
            // 
            btnFechar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFechar.ForeColor = Color.FromArgb(64, 64, 64);
            btnFechar.Location = new Point(703, 9);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(85, 27);
            btnFechar.TabIndex = 12;
            btnFechar.Text = "Voltar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnEditar.ForeColor = Color.FromArgb(64, 64, 64);
            btnEditar.Location = new Point(582, 424);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(100, 27);
            btnEditar.TabIndex = 6;
            btnEditar.Text = "Editar Voo";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnApagar
            // 
            btnApagar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnApagar.ForeColor = Color.FromArgb(64, 64, 64);
            btnApagar.Location = new Point(687, 424);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(100, 27);
            btnApagar.TabIndex = 6;
            btnApagar.Text = "Eliminar Voo";
            btnApagar.UseVisualStyleBackColor = true;
            btnApagar.Click += btnApagar_Click;
            // 
            // btnComprarVoo
            // 
            btnComprarVoo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnComprarVoo.ForeColor = Color.FromArgb(64, 64, 64);
            btnComprarVoo.Location = new Point(676, 53);
            btnComprarVoo.Name = "btnComprarVoo";
            btnComprarVoo.Size = new Size(112, 27);
            btnComprarVoo.TabIndex = 13;
            btnComprarVoo.Text = "Comprar Voos";
            btnComprarVoo.UseVisualStyleBackColor = true;
            btnComprarVoo.Click += btnComprarVoo_Click;
            // 
            // CRUDVoo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(800, 468);
            Controls.Add(btnComprarVoo);
            Controls.Add(btnFechar);
            Controls.Add(btnGerarNumero);
            Controls.Add(comboBoxAparelhos);
            Controls.Add(btnApagar);
            Controls.Add(btnEditar);
            Controls.Add(btnCriar);
            Controls.Add(listBoxVoos);
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
            Name = "CRUDVoo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Criar Voo";
            FormClosing += CRUDVoo_FormClosing;
            Load += CRUDVoo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtNumeroVoo;
        private TextBox txtOrigem;
        private TextBox txtHora;
        private TextBox txtDestino;
        private DateTimePicker dateTimePicker;
        private ListBox listBoxVoos;
        private Button btnCriar;
        private ComboBox comboBoxAparelhos;
        private Button btnGerarNumero;
        private Button btnFechar;
        private Button btnEditar;
        private Button btnApagar;
        private Button btnComprarVoo;
    }
}