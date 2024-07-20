using System;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextImage = iTextSharp.text.Image;  // Alias para evitar ambiguidade
using Biblioteca;

namespace ProjetoFinalVoos
{
    public partial class FormBilhetes : Form
    {
        Voo _escolhido;

        FormCompraBilhetes _form;


        List<Bilhete> _bilhetes;
        Voo _voo;
        List<Aparelho> Aparelhos;
        private Aparelho aparelhoJaAtribuido;
        int contaAparelhos;

        bool bagaguemExtra;
        bool espacoPes;
        bool embarquePrioritario;
        bool fastTrack;
        public FormBilhetes(FormCompraBilhetes form, Voo voo, List<Bilhete> bilhetes)
        {
            _form = form;
            _voo = voo;
            _bilhetes = bilhetes;
            InitializeComponent();
            lblDadosVoo.Text = _voo.ToString();

        }

        private void btnComprarBilhete_Click(object sender, EventArgs e)
        {
            if (ValidaForms())
            {
                Bilhete bilheteEscolhido = (Bilhete)comboBoxLugar.SelectedItem;

                Bilhete comboEscolhido = null;

                //ComboBox Bagaguem
                if (comboBoxBagaguem.SelectedIndex == 0)
                {
                    bagaguemExtra = true;
                }
                else if (comboBoxBagaguem.SelectedIndex == 1)
                {
                    bagaguemExtra = false;
                }

                //ComboBox Espaço para os pés
                if (comboBoxPes.SelectedIndex == 0)
                {
                    espacoPes = true;
                }
                else if (comboBoxPes.SelectedIndex == 1)
                {
                    espacoPes = false;
                }

                //ComboBox Embarque prioritário
                if (comboBoxEmbarque.SelectedIndex == 0)
                {
                    embarquePrioritario = true;
                }
                else if (comboBoxEmbarque.SelectedIndex == 1)
                {
                    embarquePrioritario = false;
                }

                //ComboBox Fast Track
                if (comboBoxFastTrack.SelectedIndex == 0)
                {
                    fastTrack = true;
                }
                else if (comboBoxFastTrack.SelectedIndex == 1)
                {
                    fastTrack = false;
                }



                if (bilheteEscolhido != null)
                {
                    bilheteEscolhido.Ocupado = true;
                    bilheteEscolhido.Passageiro = textBoxNome.Text;

                    Gravar.GravarBilhetes(_bilhetes, @"ListaBilhetes.txt");
                    InitCombo(_bilhetes);

                    GerarBilhetePDF(bilheteEscolhido);

                    textBoxNome.Text = string.Empty;
                    MessageBox.Show("Obrigado por efetuar a compra deste bilhete, dentro de momentos irá receber o seu PDF", "Compra Efetuada", MessageBoxButtons.OK);
                    Close();
                }



            }
        }


        private void FormBilhetes_Load(object sender, EventArgs e)
        {
            List<Voo> voos = new List<Voo>();
            List<Bilhete> bilhetesDoVoo = _bilhetes.Where(bilhete => bilhete.IdVoo == _voo.Id && !bilhete.Ocupado).ToList();
            Carregar.CarregarBilhetes(voos, _bilhetes, @"ListaBilhetes.txt");

            InitCombo(bilhetesDoVoo);
        }



        /// <summary>
        /// Inicializa a comboBox
        /// </summary>
        /// <param name="bilhetes">Passamos-lhe o parametro dos bilhetes para ele atualizar a comboBox, de maneira a retirar os bilhetes já comprados</param>
        public void InitCombo(List<Bilhete> bilhetes)
        {
            comboBoxLugar.SelectedItem = null;

            var availableBilhetes = bilhetes.Where(bilhete => bilhete.IdVoo == _voo.Id && !bilhete.Ocupado).ToList();

            comboBoxLugar.DataSource = null;
            comboBoxLugar.DataSource = availableBilhetes;
            comboBoxLugar.DisplayMember = "DadosVoos";
        }



        /// <summary>
        ///Metódo para verificar se está tudo preenchido de forma correta 
        /// </summary>
        /// <returns>true caso tenha sido tudo validado com sucesso; false caso contrário</returns>
        private bool ValidaForms()
        {
            if (string.IsNullOrEmpty(textBoxNome.Text))
            {
                MessageBox.Show("Introduza o nome do passageiro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (comboBoxLugar.SelectedIndex == -1)
            {
                MessageBox.Show("Introduza o seu lugar ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (comboBoxBagaguem.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione se deseja Bagaguem extra", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (comboBoxPes.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione se deseja espaço para os pés", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (comboBoxEmbarque.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione se deseja Embarque prioritário", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (comboBoxFastTrack.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione se deseja Fast Track", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }


        /// <summary>
        /// Gera o pdf com os dados do voo e do bilhete e com uma imagem
        /// </summary>
        /// <param name="bilhete">bilhete selecionado</param>
        private void GerarBilhetePDF(Bilhete bilhete)
        {
            string caminhoArquivo = $"Bilhete_{bilhete.Passageiro}_{bilhete.IdVoo}.pdf";

            // Cria um documento iTextSharp
            Document document = new Document(PageSize.A4, 50, 50, 25, 25);

            try
            {
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(caminhoArquivo, FileMode.Create));

                document.Open();

                // Adiciona uma imagem (logotipo)
                string logoPath = @"D:\Projetos\ProjetoFinalUFCD\CRUDVoos\logo.png"; // Caminho para a imagem do logotipo
                iTextImage logo = iTextImage.GetInstance(logoPath);
                logo.ScaleToFit(100, 100); // Redimensiona a imagem do logotipo mantendo a proporção
                logo.Alignment = Element.ALIGN_LEFT; // Alinha a imagem do logotipo à esquerda
                document.Add(logo);


                var titleFont = FontFactory.GetFont("Arial", 16, iTextSharp.text.Font.BOLD);
                var standardFont = FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.NORMAL);

                // Adiciona um parágrafo de menor espaçamento após a imagem
                Paragraph highlightParagraph = new Paragraph("Reserva concluída com sucesso!", titleFont);
                highlightParagraph.SpacingBefore = -10f; // Ajusta o espaçamento antes do parágrafo
                document.Add(highlightParagraph);


                // Adiciona os detalhes do bilhete
                document.Add(new Paragraph("\nInformações do Bilhete", titleFont));
                document.Add(new Paragraph($"Nome do Passageiro: {bilhete.Passageiro}", standardFont));
                document.Add(new Paragraph($"Lugar: {bilhete.Lugar}", standardFont));
                document.Add(new Paragraph($"Bagagem Extra: {(bagaguemExtra ? "Sim" : "Não")}", standardFont));
                document.Add(new Paragraph($"Espaço para os Pés: {(espacoPes ? "Sim" : "Não")}", standardFont));
                document.Add(new Paragraph($"Embarque prioritário: {(embarquePrioritario ? "Sim" : "Não")}", standardFont));
                document.Add(new Paragraph($"Fast Track: {(fastTrack ? "Sim" : "Não")}\n\n", standardFont));

                // Adiciona detalhes do voo
                document.Add(new Paragraph("\nDetalhes do Voo", titleFont));
                document.Add(new Paragraph(_voo.ToString(), standardFont));

            }
            catch (DocumentException de)
            {
                Console.Error.WriteLine(de.Message);
            }
            catch (IOException ioe)
            {
                Console.Error.WriteLine(ioe.Message);
            }
            finally
            {
                document.Close();
            }
        }
    }
}
            
        

