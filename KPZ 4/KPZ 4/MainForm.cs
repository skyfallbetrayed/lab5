// MainForm.cs
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

public partial class MainForm : Form
{
    private IAirplaneBuilder builder;
    private AirplaneDirector director;
    private Airplane currentAirplane;

    public MainForm()
    {
        InitializeComponent();
    }

    
    private async Task LogActionAsync(string message)
    {
        txtOutput.AppendText(message + Environment.NewLine);
        await Task.Delay(500); // Затримка у 500 мс
    }

    private async void btnStartBuilding_Click(object sender, EventArgs e)
    {
        txtOutput.Clear(); 

        if (radioPassenger.Checked)
        {
            builder = new PassengerAirplaneBuilder();
        }
        else if (radioCargo.Checked)
        {
            builder = new CargoAirplaneBuilder();
        }
        else
        {
            MessageBox.Show("Виберіть тип літака.");
            return;
        }

        director = new AirplaneDirector(builder, LogActionAsync);
        await director.ConstructAirplane();
        currentAirplane = director.GetAirplane();

        // Виводимо остаточний результат літака
        txtOutput.AppendText("\nЛітак створено:\n" + currentAirplane.ToString() + Environment.NewLine);
        btnClone.Enabled = true;
    }

    private void btnClone_Click(object sender, EventArgs e)
    {
        if (currentAirplane != null)
        {
            var clonedAirplane = currentAirplane.Clone();
            txtOutput.AppendText("\nКопія літака створена:\n" + clonedAirplane.ToString() + Environment.NewLine);
        }
        else
        {
            MessageBox.Show("Спочатку створіть літак.");
        }
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        
    }
}
