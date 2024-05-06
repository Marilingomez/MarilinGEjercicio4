namespace MarilinGEjercicio4
{
    public partial class PersonasForm : Form
    {
        PersonasModelo modelo;
        public PersonasForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            modelo = new();

            TipoCombo.Items.Add("Casa");
            TipoCombo.Items.Add("Trabajo");
            TipoCombo.Items.Add("Otros");

            CargarLista();

        }

        private void EditarBoton_Click(object sender, EventArgs e)
        {
            if (Lista.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un item de la lista primero");
                return;
            }

            var personaAEditar = (Persona)Lista.SelectedItems[0].Tag;
            DocumentoText.Text = personaAEditar.Documento.ToString();
            ApellidoText.Text = personaAEditar.Apellido;
            NombreText.Text = personaAEditar.Nombre;

            TipoCombo.SelectedValue = personaAEditar.Telefono.Tipo.ToString();

            CodPais.Text = personaAEditar.Telefono.CodArea.ToString();
            CodAreaText.Text = personaAEditar.Telefono.CodPais.ToString();
            NumeroText.Text = personaAEditar.Telefono.Numero.ToString();

            Lista.Enabled = false;
            EdicionGroup.Enabled = true;

            modelo.PersonaEnEdicion = personaAEditar;
        }

        private void NuevoBoton_Click(object sender, EventArgs e)
        {
            Lista.Enabled = false;
            EdicionGroup.Enabled = true;
            modelo.PersonaEnEdicion = null;
        }

        private void CargarLista()
        {
            //para el profe es PersonaLista
            Lista.Items.Clear();

            foreach (var persona in modelo.Personas)
            {
                var fila = new ListViewItem();
                fila.Text = persona.Documento.ToString();
                fila.SubItems.Add(persona.Nombre);
                fila.SubItems.Add(persona.Apellido);
                fila.SubItems.Add(persona.Telefono.Descripcion());
                fila.Tag = persona;

                Lista.Items.Add(fila);
            }
        }
        private void EliminarBoton_Click(object sender, EventArgs e)
        {

        }

        private int GetDocumento()
        {
            return Documento;
        }

        private void AceptarBoton_Click(object sender, EventArgs e, int documento)
        {
            if(!int.TryParse(DocumentoText.Text, out var doc))
            {
                MessageBox.Show("El documento no es valido");
                return;
            }
            if(!Enum.TryParse<Tipo>(TipoCombo.Text, out var tipo))
            {
                MessageBox.Show("El tipo de telefono no es valido");
                return;
            }
            //seguir con las validaciones


            Persona  = new()
            {
                documento = doc,
                Apellido = ApellidoText.Text,
                Nombre = NombreText.Text,
                Telefono = new Telefono
                {
                    Tipo = Enum.Parse<Tipo>(TipoCombo.Text),
                    CodPais=int.Parse(CodPais.Text),
                    CodArea=int.Parse(CodAreaText.Text),
                    Numero=int.Parse(NumeroText.Text),
                }

            };

            string error=modelo.Modificar(persona);
            if(error!=null)
            {
                MessageBox.Show(error);
                return;
            }

            CargarLista();
        }

        private void CancelarBoton_Click(object sender, EventArgs e)
        {
            DocumentoText.Text = string.Empty;
            ApellidoText.Text = string.Empty;
            NombreText.Text = string.Empty;

            TipoCombo.SelectedValue = string.Empty;

            CodPais.Text = string.Empty;
            CodAreaText.Text = string.Empty;
            NumeroText.Text = string.Empty;

            Lista.Enabled = true;
            EdicionGroup.Enabled = false;
        }

        private void TipoCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CodPais_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
