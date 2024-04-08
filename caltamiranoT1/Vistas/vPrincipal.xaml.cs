namespace caltamiranoT1.Vistas;

public partial class vPrincipal : ContentPage
{
	public vPrincipal()
	{
		InitializeComponent();
	}

    private void btnConsulta_Clicked(object sender, EventArgs e)
    {
        string nombre = txtNombre.Text;
        string apellido = txtApellido.Text;
        string edad = txtEdad.Text;
        double salario = Convert.ToInt32(txtSalario.Text);
        double calculo = salario * 0.0945;
        DisplayAlert("Alerta", "Bienvenido " + nombre  +  apellido + "\n Edad: " +edad+ "años \n " +
            "Tu aporte mensual al IESS es: \n $" + calculo+ "de manera mensual", "Cerrar");
 

    }
}