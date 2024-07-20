using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinalVoos
{
    public partial class FormEditarVoo : Form
    {
        Voo _editado;

        List<Bilhete> bilhetes;
        List<Voo> voos;
        List<Aparelho> Aparelhos;
        private Aparelho aparelhoJaAtribuido;
        int contaAparelhos;

        CRUDVoo _form;

        public FormEditarVoo(CRUDVoo form, Voo editado, List<Voo> voos, List<Bilhete>bilhetes)
        {
            if (editado == null)
            {
                throw new ArgumentNullException(nameof(editado), "O objeto editado não pode ser nulo.");
            }

            this.bilhetes = bilhetes;
            this.voos = voos;
            _editado = editado;
            aparelhoJaAtribuido = _editado.Aparelho;
            _form = form;
            Aparelhos = new List<Aparelho>();
            InitializeComponent();

        }



        private void btnCancela_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuarda_Click(object sender, EventArgs e)
        {
            if (!ValidaForm()) return;


            DateTime novaData = dateTimePicker.Value;
            Aparelho novoAparelho = (Aparelho)comboBoxAparelhos.SelectedItem;


            if (ExisteVooConflitante(_editado, voos, novoAparelho, novaData))
            {
                MessageBox.Show("O aparelho já está atribuído a outro voo na mesma data. Por favor, escolha outra data ou aparelho.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool apararelhoAlterado = _editado.Aparelho.Id != novoAparelho.Id;

            _editado.NumeroVoo = txtNumeroVoo.Text;
            _editado.Origem = txtOrigem.Text;
            _editado.Destino = txtDestino.Text;
            _editado.Aparelho = novoAparelho;
            _editado.DataVoo = novaData;
            _editado.Hora = txtHora.Text;


            aparelhoJaAtribuido.Atribuido = false;
            _editado.Aparelho.Atribuido = true;


            foreach (Aparelho aparelho in Aparelhos)
            {
                if (aparelho.Id == aparelhoJaAtribuido.Id)
                {
                    aparelho.Atribuido = aparelhoJaAtribuido.Atribuido;
                }
                else if (aparelho.Id == _editado.Aparelho.Id)
                {
                    aparelho.Atribuido = _editado.Aparelho.Atribuido;
                }
            }

            if (apararelhoAlterado)
            {
                AtualizarBilhetes();
            }


            Utilitarios.SalvarDados(_form.voos, _form.contaVoos, Aparelhos);
            SalvarBilhetes();
            _form.InitLista();

            Close();
        }



        /// <summary>
        ///Metódo para verificar se está tudo preenchido de forma correta 
        /// </summary>
        /// <returns>true caso tenha sido tudo validado com sucesso; false caso contrário</returns>
        private bool ValidaForm()
        {
            bool output = true;

            if (string.IsNullOrEmpty(txtOrigem.Text))
            {
                MessageBox.Show("Insira a Origem", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(txtDestino.Text))
            {
                MessageBox.Show("Insira o Destino", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (comboBoxAparelhos.SelectedItem == null)
            {
                MessageBox.Show("Selecione o Aparelho", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(txtHora.Text))
            {
                MessageBox.Show("Insira a Hora de partida", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (txtOrigem.Text == txtDestino.Text)
            {
                MessageBox.Show("A Origem e o Destino não podem ser iguais", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //Origem
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtOrigem.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("A Origem deve conter apenas letras", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //Destino
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtDestino.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("O Destino deve conter apenas letras", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(txtHora.Text, @"^\d{2}:\d{2}$"))
            {
                MessageBox.Show("Introduza a hora em formato correto [HH:MM]", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return output;
        }


        private void FormEditarVoo_Load(object sender, EventArgs e)
        {
            Carregar.CarregarAparelhos(Aparelhos, @"ListaAparelhos.txt");
            contaAparelhos = Carregar.CarregarAparelhosID(@"ContaAparelhos.txt");
            Carregar.CarregarBilhetes(voos, bilhetes, @"ListaBilhetes.txt");

            InitCombo();

            txtNumeroVoo.Text = _editado.NumeroVoo;
            txtOrigem.Text = _editado.Origem;
            txtDestino.Text = _editado.Destino;
            comboBoxAparelhos.SelectedItem = _editado.Aparelho;
            dateTimePicker.Value = _editado.DataVoo;
            txtHora.Text = _editado.Hora;
        }

        /// <summary>
        /// Inicializar a ListBox
        /// </summary>
        public void InitCombo()
        {
            comboBoxAparelhos.Items.Clear();
            foreach (var aparelho in Aparelhos)
            {
                if (!aparelho.Atribuido || aparelho.Atribuido)
                {
                    comboBoxAparelhos.Items.Add(aparelho);
                }
            }
        }

        /// <summary>
        /// Atualiza a lista de bilhetes, fazendo com que atualize o ficheiro.txt também
        /// </summary>
        private void AtualizarBilhetes()
        {
            // Remove os bilhetes antigos do voo editado
            bilhetes.RemoveAll(bilhete => bilhete.IdVoo == _editado.Id);

            // Adiciona novos bilhetes com base na capacidade do novo aparelho
            for (int i = 0; i < _editado.Aparelho.Capacidade; i++)
            {
                bilhetes.Add(new Bilhete
                {
                    IdVoo = _editado.Id,
                    Lugar = i + 1,
                    Ocupado = false,
                    Passageiro = string.Empty
                });
            }

            // Salvar os bilhetes atualizados no arquivo sem duplicações
            GravarBilhetesNoArquivo(bilhetes);
        }



        /// <summary>
        /// Vai remover no ficheiro.txt duplicações
        /// </summary>
        /// <param name="bilhetes"></param>
        private void GravarBilhetesNoArquivo(List<Bilhete> bilhetes)
        {
            // Remove duplicações antes de gravar
            var linhasUnicas = bilhetes.GroupBy(b => new { b.IdVoo, b.Lugar })
                                       .Select(g => g.First())
                                       .Select(b => $"{b.IdVoo};{b.Lugar};{b.Ocupado};{b.Passageiro}");
            File.WriteAllLines(@"ListaBilhetes.txt", linhasUnicas);
        }






        /// <summary>
        /// Método para verificar se existe ou não algum voo igual, de maneira a não deixar existirem voos repetidos.
        /// </summary>
        /// <param name="vooParaEditar"></param>
        /// <param name="voos"></param>
        /// <param name="novoAparelho"></param>
        /// <param name="novaData"></param>
        /// <returns>false caso tenha sido tudo validado com sucesso; true caso contrário</returns>
        private bool ExisteVooConflitante(Voo vooParaEditar, List<Voo> voos, Aparelho novoAparelho, DateTime novaData)
        {
            foreach (var voo in voos)
            {
                if (voo.Id != vooParaEditar.Id && voo.Aparelho.Id == novoAparelho.Id && voo.DataVoo.Date == novaData.Date)
                {
                    return true;
                }
            }
            return false;
        }



        /// <summary>
        ///Método para Salvar a lista de Bilhetes e o ID dos bilhetes 
        /// </summary>
        public void SalvarBilhetes()
        {
            GravarBilhetesNoArquivo(bilhetes);
            Gravar.GravarBilhetesID(_editado.Aparelho.Id, @"ContaBilhetes.txt");
        }

    }
}
