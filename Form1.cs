namespace task1
{
    public partial class Form1 : Form
    {
       
   
       

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Məhsulunuz əlavə olundu");
        }

      

        private void Btn_addProgressBar_Click(object sender, EventArgs e)
        {
            var progressBarValue = progressBar1.Value;
            progressBarValue += Convert.ToInt32(numericUpDown1.Value);
            if (progressBarValue <= 10)
                progressBar1.Value= progressBarValue;
        }
    }
    }

