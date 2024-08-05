using System.Data.SqlClient;

namespace RegistrationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isAnyEmpty=false;
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    if (String.IsNullOrEmpty(control.Text))
                    {
                        isAnyEmpty = true;
                        break;
                    }
                }else if(control is DateTimePicker)
                {
                    if (((DateTimePicker)control).Value == null)
                    {
                        isAnyEmpty = true;
                        break;
                    }
                }else if(control is ComboBox)
                {
                    if(((ComboBox)control).SelectedIndex==-1)
                    {
                        isAnyEmpty = true;
                        break;
                    }
                }
            }if (isAnyEmpty)
            {
                MessageBox.Show("one or more row is empty");
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=DILSHA;Initial Catalog=registrationform;Integrated Security=True;TrustServerCertificate=True");
                con.Open();
                String insquery = "INSERT INTO registertbl VALUES(@uname,@lname,@dob,@gender,@email,@username,@password,@phone,@country)";
                SqlCommand cmd = new SqlCommand(insquery, con);
                cmd.Parameters.AddWithValue("@uname", txtfname.Text);
                cmd.Parameters.AddWithValue("@lname", txtlname.Text);
                cmd.Parameters.AddWithValue("@dob", dtpdob.Text);
                cmd.Parameters.AddWithValue("@gender", cmbGender.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                cmd.Parameters.AddWithValue("@phone", txtphone.Text);
                cmd.Parameters.AddWithValue("@country", txtcountry.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("register successfully", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }




        }
    }
}
