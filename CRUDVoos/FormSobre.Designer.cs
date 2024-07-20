namespace ProjetoFinalVoos
{
    partial class FormSobre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSobre));
            label1 = new Label();
            label2 = new Label();
            lblData = new Label();
            linkLabelLinkedIn = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Copperplate Gothic Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(5, 22);
            label1.Name = "label1";
            label1.Size = new Size(411, 24);
            label1.TabIndex = 0;
            label1.Text = "Autor do Projeto: Diogo Trindade";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(52, 68);
            label2.Name = "label2";
            label2.Size = new Size(94, 21);
            label2.TabIndex = 0;
            label2.Text = "Versão 1.0.0";
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblData.Location = new Point(272, 68);
            lblData.Name = "lblData";
            lblData.Size = new Size(42, 21);
            lblData.TabIndex = 1;
            lblData.Text = "Data";
            // 
            // linkLabelLinkedIn
            // 
            linkLabelLinkedIn.ActiveLinkColor = Color.White;
            linkLabelLinkedIn.AutoSize = true;
            linkLabelLinkedIn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabelLinkedIn.Image = (Image)resources.GetObject("linkLabelLinkedIn.Image");
            linkLabelLinkedIn.LinkColor = Color.White;
            linkLabelLinkedIn.Location = new Point(144, 105);
            linkLabelLinkedIn.Name = "linkLabelLinkedIn";
            linkLabelLinkedIn.Size = new Size(132, 25);
            linkLabelLinkedIn.TabIndex = 2;
            linkLabelLinkedIn.TabStop = true;
            linkLabelLinkedIn.Text = "                        ";
            linkLabelLinkedIn.LinkClicked += linkLabelLinkedIn_LinkClicked;
            // 
            // FormSobre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(421, 144);
            Controls.Add(linkLabelLinkedIn);
            Controls.Add(lblData);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormSobre";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sobre";
            Load += FormSobre_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblData;
        private LinkLabel linkLabelLinkedIn;
    }
}