using ListingComponents.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListingComponents
{
    public partial class frmStudentList : Form
    {
        public Student Student { 
            
            get {
                Student student = new Student();
                student.Number = txtNumber.Text;
                student.NameSurname = txtNameSurnane.Text;
                student.MidTerm = Convert.ToDouble(txtMidTerm.Text);
                student.Final = Convert.ToDouble(txtFinal.Text);
                return student;
            } 
            set {

                txtNumber.Text = value.Number;
                txtNameSurnane.Text = value.NameSurname;
                txtMidTerm.Text = value.MidTerm.ToString();
                txtFinal.Text = value.Final.ToString();

                if (value.Number == "")
                {
                    txtNumber.Focus();
                }
            } 
        }


        public List<Student> Students { get; set; }
        public frmStudentList()
        {
            InitializeComponent();
            Students = new Student().loadData();
            loadList();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            Students.Add(Student);
            Student = new Student();
            loadList();
        }


        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (grdList.CurrentRow == null) return;
            Students.RemoveAt(grdList.CurrentRow.Index);
            loadList();
        }

        private void grbAddHeader_Enter(object sender, EventArgs e)
        {

        }

        private void loadList()
        {
            grdList.Rows.Clear();
            int orderNumber = 1;
            foreach(var student in Students)
            {
                grdList.Rows.Add(new object[] { orderNumber,student.Number,student.NameSurname,student.MidTerm,student.Final,student.ExamNote,student.State});
                orderNumber++;
            }

            lblSucces.Text = String.Format("Success : " + Students.Where(p => p.ExamNote >= 60).Count().ToString());
            lblFail.Text = String.Format("Failed : " + Students.Where(p => p.ExamNote < 60).Count().ToString());

            new Student().saveData(Students);

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
