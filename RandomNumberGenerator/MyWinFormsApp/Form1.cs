namespace MyWinFormsApp;

public partial class Form1 : Form
{

    public Form1()
    {

        InitializeComponent();

        
      
    }
  private void GenerateButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 1001);
            this.Controls["myLabel"].Text = "Random number: " + randomNumber.ToString();
        }



}
