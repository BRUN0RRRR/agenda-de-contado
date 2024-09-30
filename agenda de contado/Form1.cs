namespace agenda_de_contado
{
    public partial class Form1 : Form
    {

        public class Contato
        {
            public string Nome { get; set; }
            public string Telefone { get; set; }
            public string Email { get; set; }

            public override string ToString()
            {
                return $"{Nome} - {Telefone} - {Email}";
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            Contato novoContato = new Contato()
            {
                Nome = txtnome.Text,
                Telefone = textnumero.Text,
                Email = textemail.Text
            };

            lista.Items.Add(novoContato);
            LimparCampos();
        }

        private void lista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (lista.SelectedIndex != -1)
            {
                Contato contatoSelecionado = (Contato)lista.SelectedItem;
                contatoSelecionado.Nome = txtnome.Text;
                contatoSelecionado.Telefone = textnumero.Text;
                contatoSelecionado.Email = textemail.Text;

                lista.Items[lista.SelectedIndex] = contatoSelecionado; // Atualiza o item
                                                                       //LimparCampos();
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnremove_Click(object sender, EventArgs e)
        {

            if (lista.SelectedIndex != -1)
            {
                lista.Items.RemoveAt(lista.SelectedIndex);
                LimparCampos();
            }
        }
        private void LimparCampos()
        {
            txtnome.Clear();
            textnumero.Clear();
            textemail.Clear();
            lista.ClearSelected();
        }
    }
}
