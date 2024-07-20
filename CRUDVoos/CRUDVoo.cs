using Biblioteca;

namespace ProjetoFinalVoos;

public partial class CRUDVoo : Form
{
    public List<Voo> voos;
    public List<Aparelho> Aparelhos;
    int contaAparelhos;
    public int contaVoos = 1;
    Voo novoVoo;
    public CRUDVoo()
    {
        InitializeComponent();
        voos = new List<Voo>();
        Aparelhos = new List<Aparelho>();
        this.FormClosing += new FormClosingEventHandler(this.CRUDVoo_FormClosing);
    }

    private void btnCriar_Click(object sender, EventArgs e)
    {
        novoVoo = new Voo
        {
            Id = contaVoos,
            NumeroVoo = txtNumeroVoo.Text,
            Origem = txtOrigem.Text,
            Destino = txtDestino.Text,
            Aparelho = (Aparelho)comboBoxAparelhos.SelectedItem,
            DataVoo = dateTimePicker.Value,
            Hora = txtHora.Text

        };

        if (ValidaForms())
        {
            Aparelho aparelhoEscolhido = comboBoxAparelhos.SelectedItem as Aparelho;
            if (aparelhoEscolhido == null)
            {
                MessageBox.Show("Por favor, selecione um aparelho válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<Bilhete> bilhetes = new List<Bilhete>();
            Carregar.CarregarBilhetes(voos, bilhetes, @"ListaBilhetes.txt");
            for (int i = 0; i < aparelhoEscolhido.Capacidade; i++)
            {
                bilhetes.Add(new Bilhete
                {
                    IdVoo = novoVoo.Id,
                    Lugar = i + 1,
                    Ocupado = false,
                    Passageiro = string.Empty
                });
            }


            contaVoos++;
            novoVoo.Aparelho.Atribuido = true;
            voos.Add(novoVoo);
            MessageBox.Show("Voo criado com sucesso", "Sucesso", MessageBoxButtons.OK);
            InitLista();


            //Limpa os campos, para poder adicionar novo Voo
            txtNumeroVoo.Text = string.Empty;
            txtOrigem.Text = string.Empty;
            txtDestino.Text = string.Empty;
            comboBoxAparelhos.SelectedIndex = -1;
            txtHora.Text = string.Empty;
            btnGerarNumero.Focus();
            Utilitarios.SalvarDados(voos, contaVoos, Aparelhos);
            SalvarBilhetes(bilhetes);
            InitCombo();

        }

    }


    private void btnApagar_Click(object sender, EventArgs e)
    {
        Voo vooAApagar = (Voo)listBoxVoos.SelectedItem;


        if (vooAApagar != null)
        {
            Voo apagado = null;
            foreach (Voo voo in voos)
            {
                if (vooAApagar.Id == voo.Id)
                {
                    apagado = voo;
                    break;
                }
            }
            if (apagado != null)
            {
                DialogResult resposta;
                resposta = MessageBox.Show($"Tem a certeza que pretende apagar o voo {apagado.NumeroVoo} ?",
                    "Apagar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (DialogResult.OK == resposta)
                {
                    apagado.Aparelho.Atribuido = false;
                    voos.Remove(apagado);
                    List<Bilhete> bilhetes = new List<Bilhete>();
                    Carregar.CarregarBilhetes(voos, bilhetes, @"ListaBilhetes.txt");
                    Utilitarios.SalvarDados(voos, contaVoos, Aparelhos);
                    RemoverBilhetesDoVoo(bilhetes, apagado.Id);
                    Gravar.GravarBilhetes(bilhetes, @"ListaBilhetes.txt");
                    InitCombo();
                    InitLista();
                }
            }
        }
        else
        {
            MessageBox.Show("Tem de selecionar um voo para apagar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }

    private void btnEditar_Click(object sender, EventArgs e)
    {
        Voo vooAEditar = (Voo)listBoxVoos.SelectedItem;

        Voo editado = null;

        if (vooAEditar != null)
        {
            foreach (Voo voo in voos)
            {
                if (vooAEditar.Id == voo.Id)
                {
                    editado = voo;
                    break;
                }
            }

            List<Bilhete> bilhetes = new List<Bilhete>();
            Carregar.CarregarBilhetes(voos, bilhetes, @"ListaBilhetes.txt");

            Form _formEditarvoo = new FormEditarVoo(this, editado, voos, bilhetes);
            _formEditarvoo.ShowDialog();

        }
        else
        {
            MessageBox.Show("Tem de selecionar um voo para editar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }



    private void btnComprarVoo_Click(object sender, EventArgs e)
    {
        FormCompraBilhetes _formCompraBilhetes = new FormCompraBilhetes();
        _formCompraBilhetes.Show();
        this.Close();
    }



    /// <summary>
    ///Metódo para verificar se está tudo preenchido de forma correta 
    /// </summary>
    /// <returns>true caso tenha sido tudo validado com sucesso; false caso contrário</returns>
    private bool ValidaForms()
    {
        foreach (Voo voo in voos)
        {
            if (novoVoo.Aparelho.Id == voo.Aparelho.Id && novoVoo.DataVoo.Date == voo.DataVoo.Date)
            {
                MessageBox.Show("Introduza outra data para poder escolher este aparelho, se não altere o aparelho", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        if (string.IsNullOrEmpty(txtNumeroVoo.Text))
        {
            MessageBox.Show("Insira o número do Voo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        if (string.IsNullOrEmpty(txtOrigem.Text))
        {
            MessageBox.Show("Insira a Origem do Voo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        if (string.IsNullOrEmpty(txtDestino.Text))
        {
            MessageBox.Show("Insira o Destino do Voo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        if (comboBoxAparelhos.SelectedIndex == -1)
        {
            MessageBox.Show("Insira o Aparelho", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        if (string.IsNullOrEmpty(txtHora.Text))
        {
            MessageBox.Show("Insira a Hora do Voo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
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

        return true;
    }




    /// <summary>
    /// Inicializar a ListBox
    /// </summary>
    public void InitLista()
    {
        listBoxVoos.DataSource = null;
        listBoxVoos.DataSource = voos;
        listBoxVoos.DisplayMember = "Descricao";
    }



    private void CRUDVoo_Load(object sender, EventArgs e)
    {
        //Carregar todos os dados 
        Carregar.CarregarAparelhos(Aparelhos, @"ListaAparelhos.txt");
        contaAparelhos = Carregar.CarregarAparelhosID(@"ContaAparelhos.txt");
        contaVoos = Carregar.CarregarVoosID(@"ContaVoos.txt");
        Carregar.CarregarVoos(voos, Aparelhos, @"ListaVoos.txt");
        InitCombo();
        InitLista();
    }




    /// <summary>
    /// Metodo para a ComboBox ser preenchida pelos aparelhos já criados e apenas aparecerem os aparelhos não atribuidos a voos
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

    private void btnGerarNumero_Click(object sender, EventArgs e)
    {
        Random rand = new Random();
        int randomNumeroVoo = rand.Next(10000, 100000);  // Número entre 10000 e 99999
        txtNumeroVoo.Text = randomNumeroVoo.ToString();

    }

    private void btnFechar_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void CRUDVoo_FormClosing(object sender, FormClosingEventArgs e)
    {
        Utilitarios.SalvarDados(voos, contaVoos, Aparelhos);
    }



    /// <summary>
    /// Remove os bilhetes do Voo, depois que o voo é apagado
    /// </summary>
    /// <param name="bilhetes"></param>
    /// <param name="id"></param>
    private void RemoverBilhetesDoVoo(List<Bilhete> bilhetes, int id)
    {
        bilhetes.RemoveAll((bilhete) => { return bilhete.IdVoo == id; });

    }


    /// <summary>
    /// Salva os bilhetes nos ficheiros.txt
    /// </summary>
    /// <param name="bilhetes"></param>
    private void SalvarBilhetes(List<Bilhete> bilhetes)
    {
        Gravar.GravarBilhetes(bilhetes, @"ListaBilhetes.txt");
        Gravar.GravarBilhetesID(novoVoo.Id, @"ContaBilhetes.txt");
    }



}
