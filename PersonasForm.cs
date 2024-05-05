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

            foreach(var persona in modelo.Personas)
            {
                var fila = new ListViewItem();
                fila.Text = persona.Documento.ToString();
                fila.SubItems.Add(persona.Nombre);
                fila.SubItems.Add(persona.Apellido);
                fila.SubItems.Add(persona.Telefono.Descripcion());

                PersonasList.Items.Add(fila);
            }
        }
    }
}
