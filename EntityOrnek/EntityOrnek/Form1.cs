using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EntityOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        StudentExamsDbEntities db = new StudentExamsDbEntities();
        private void BtnDersListesi_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Lessons.ToList();
            dataGridView1.Columns[2].Visible = false;
        }

        private void BtnOgrenciListele_Click(object sender, EventArgs e)
        {
            if (CmbOgrenciListeleme.SelectedIndex == 0)
            {
                List<Students> students = db.Students.OrderBy(p => p.StudentName).ToList();
                dataGridView1.DataSource = students;
            }
            else if (CmbOgrenciListeleme.SelectedIndex == 1)
            {
                List<Students> students = db.Students.OrderByDescending(p => p.StudentName).ToList();
                dataGridView1.DataSource = students;
            }
            else if (CmbOgrenciListeleme.SelectedIndex == 2)
            {
                List<Students> students = db.Students.OrderBy(p => p.StudentName).Take(3).ToList();
                dataGridView1.DataSource = students;
            }
            else if (CmbOgrenciListeleme.SelectedIndex == 3)
            {
                try
                {
                    if (TxtOgrenciId.Text == "")
                    {
                        throw new Exception("Öğrenci Id boş bırakılmaz");
                    }
                    else
                    {
                        int StudentId = Convert.ToInt32(TxtOgrenciId.Text);
                        List<Students> students = db.Students.Where(p => p.StudentId == StudentId).ToList();
                        dataGridView1.DataSource = students;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (CmbOgrenciListeleme.SelectedIndex == 4)
            {
                List<Students> students = db.Students.Where(p => p.StudentName.StartsWith("a")).ToList();
                dataGridView1.DataSource = students;
            }
            else if (CmbOgrenciListeleme.SelectedIndex == 5)
            {
                List<Students> students = db.Students.Where(p => p.StudentName.EndsWith("a")).ToList();
                dataGridView1.DataSource = students;
            }
            else if (CmbOgrenciListeleme.SelectedIndex == 6)
            {
                try
                {
                    if (TxtOgrenciId.Text=="")
                    {
                        throw new Exception("Öğrenci Id boş bırakılmaz");
                    }
                    else
                    {
                        int StudentId = Convert.ToInt32(TxtOgrenciId.Text);
                        bool value = db.Students.Any(x => x.StudentId == StudentId);
                        MessageBox.Show("Öğrenci Id : "+StudentId.ToString()+ " olan öğrenci var");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            else if (CmbOgrenciListeleme.SelectedIndex == 7)
            {
                var highest = db.Grades.Max(p => p.Exam1);
                var StudentId = db.Grades.FirstOrDefault(p => p.Exam1 == highest).StudentId;

                var query = from s in db.Students
                            join g in db.Grades on s.StudentId equals g.StudentId
                            where s.StudentId == StudentId
                            select new
                            {
                                s.StudentId,
                                s.StudentName,
                                s.StudentSurname,
                                g.Exam1
                            };


                dataGridView1.DataSource = query.ToList();


            }
            else
            {
                dataGridView1.DataSource = db.Students.ToList();
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[4].Visible = false;
            }

        }

        private void BtnNotListesi_Click(object sender, EventArgs e)
        {

            //var query = from not in db.Grades
            //            join st in db.Students on not.StudentId equals st.StudentId
            //            join les in db.Lessons on not.LessonId equals les.LessonId
            //            select new
            //            {
            //                NotId = not.GradeId,
            //                OgrenciAdi = st.StudentName,
            //                OgrenciSoyadi = st.StudentSurname,
            //                DersAdi = les.LessonName,
            //                Sinav1 = not.Exam1,
            //                Sinav2 = not.Exam2
            //            };
            //DataTable dt = new DataTable();
            //dt.Columns.Add("Not Id");
            //dt.Columns.Add("Öğrenci Adı");
            //dt.Columns.Add("Öğrenci Soyadı");
            //dt.Columns.Add("Ders Adı");
            //dt.Columns.Add("Sınav 1");
            //dt.Columns.Add("Sınav 2");  

            dataGridView1.DataSource = db.NotListesi();
        }

        private void BtnOgrenciKaydet_Click(object sender, EventArgs e)
        {
            Students students = new Students();
            students.StudentName = TxtOgrenciAd.Text;
            students.StudentSurname = TxtOgrenciSoyad.Text;

            try
            {
                if (TxtOgrenciAd.Text == "" || TxtOgrenciSoyad.Text == "")
                {
                    throw new Exception("Öğrenci adı veya soyadını boş bırakmayınız");
                }
                else
                {
                    db.Students.Add(students);
                    db.SaveChanges();
                    MessageBox.Show("Öğrenci listeye eklenmiştir");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnDersKaydet_Click(object sender, EventArgs e)
        {
            Lessons lessons = new Lessons();
            lessons.LessonName = TxtDersAd.Text;

            try
            {
                if (TxtDersAd.Text == "" )
                {
                    throw new Exception("Ders alanını boş bırakmayınız");
                }
                else
                {
                    db.Lessons.Add(lessons);
                    db.SaveChanges();
                    MessageBox.Show("Ders listeye eklenmiştir");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnOgrenciSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtOgrenciId.Text == "")
                    throw new Exception("Öğrenci Id kısmını doldurunuz");
                else
                {
                    int id = Convert.ToInt32(TxtOgrenciId.Text);
                    var student = db.Students.Find(id);
                    db.Students.Remove(student);
                    db.SaveChanges();
                    MessageBox.Show("Öğrenci silme tamamlandı");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BtnOgrenciGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtOgrenciId.Text == "")
                {
                    throw new Exception("Öğrenci Id kısmını doldurunuz veya tablodan seçiniz");
                }
                else
                {
                    int id = Convert.ToInt32(TxtOgrenciId.Text);
                    var student = db.Students.Find(id);
                    student.StudentName = TxtOgrenciAd.Text;
                    student.StudentSurname = TxtOgrenciSoyad.Text;
                    student.StudentPhoto = TxtOgrenciFoto.Text;
                    db.SaveChanges();
                    MessageBox.Show("Öğrenci kaydı güncellendi");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = dataGridView1.CurrentCell.ColumnIndex;

            if (dataGridView1.Columns[columnIndex].Name == "StudentId")
            {
                TxtOgrenciId.Text = dataGridView1.CurrentRow.Cells["StudentId"].Value.ToString();
                TxtOgrenciAd.Text = dataGridView1.CurrentRow.Cells["StudentName"].Value.ToString();
                TxtOgrenciSoyad.Text = dataGridView1.CurrentRow.Cells["StudentSurname"].Value.ToString();
            }

            else if (dataGridView1.Columns[columnIndex].Name == "LessonId")
            {
                TxtDersId.Text = dataGridView1.CurrentRow.Cells["LessonId"].Value.ToString();
                TxtDersAd.Text = dataGridView1.CurrentRow.Cells["LessonName"].Value.ToString();
            }
            
        }

        private void BtnOgrenciBul_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Students.Where(x => x.StudentName == TxtOgrenciAd.Text && x.StudentSurname == TxtOgrenciSoyad.Text).ToList();
        }

        private void TxtOgrenciAd_TextChanged(object sender, EventArgs e)
        {
            string searched = TxtOgrenciAd.Text;
            var query = from s in db.Students
                        where s.StudentName.Contains(searched)
                        select s;
            dataGridView1.DataSource = query.ToList();
        }

       
    }
}
