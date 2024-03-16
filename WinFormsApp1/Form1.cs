namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Button botonHolaMundo = new Button();
            botonHolaMundo.Text = "Hola Mundo";
            botonHolaMundo.Location = new System.Drawing.Point(100, 100);
            botonHolaMundo.Click += new EventHandler(BotonHolaMundo_Click);

            // Agregar el botón al formulario
            this.Controls.Add(botonHolaMundo);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BotonHolaMundo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Hola Mundo!");
        }

    }
}
