
using EfCore.Controller;
using EfCore.Model;
using EfCore.DTO;
namespace EfCore
{
    public partial class Form1 : Form
    {

        private addStudentController _addstudent;
        public Form1(addStudentController addstudent)
        {
            InitializeComponent();
            _addstudent = addstudent;
        }

      
        private void addStudent_Click(object sender, EventArgs e)
        {
            addStudentDTO student = new addStudentDTO()
            {
                name = textBox1.Text,
                middlename = textBox2.Text,
                lastname = textBox3.Text
            };
            try
            {
                _addstudent.AddStudent(student);
                MessageBox.Show("Student Added Successfully");  
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

    }
}
