using FastMember;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task
{
    public partial class Authorization : Form
    {
        List<FormatDataEmpl> formatDataEmpls = new List<FormatDataEmpl>();
        public Authorization()
        {
            InitializeComponent();
            using (Context db = new Context())
            {
                // получаем таблицы(объекты) из нашей бд 
                var employees = db.persons;

                foreach (persons empl in employees)
                {
                    System.Data.SqlClient.SqlParameter param_departs = new System.Data.SqlClient.SqlParameter("@numerDeps", empl.id_dep); ;
                    var departs = db.Database.SqlQuery<deps>("NameDeps @numerDeps", param_departs);

                    System.Data.SqlClient.SqlParameter param_posts = new System.Data.SqlClient.SqlParameter("@numerPost", empl.id_post); ;
                    var posts = db.Database.SqlQuery<deps>("NamePost @numerPost", param_posts);

                    System.Data.SqlClient.SqlParameter param_status = new System.Data.SqlClient.SqlParameter("@numerStatus", empl.status); ;
                    var status = db.Database.SqlQuery<deps>("NameStatus @numerStatus", param_status);

                    formatDataEmpls.Add(new FormatDataEmpl()
                    {
                        FIO = empl.second_name + " " + empl.first_name.Substring(0, 1) + "." + empl.last_name.Substring(0, 1) + ".",
                        status = status.First().name,
                        dep = departs.First().name,
                        post = posts.First().name,
                        employ = empl.date_employ,
                        uneploy = empl.date_uneploy
                    });


                }

                List<NameCmb> DepsCmb = new List<NameCmb>();
                List<NameCmb> PostsCmb = new List<NameCmb>();

                
                    foreach (FormatDataEmpl f in formatDataEmpls)
                    {
                        bool isRepeatDeps = false;
                        bool isRepeatPosts = false;
                        foreach (NameCmb d in DepsCmb)
                        { 
                            if (d.name == f.dep)
                            {
                                isRepeatDeps = true;
                                break;
                            }
                        }
                        foreach (NameCmb d in PostsCmb)
                        {
                            if (d.name == f.post)
                            {
                                isRepeatPosts = true;
                                break;
                            }
                        }
                        if (isRepeatDeps)
                            {
                                continue;
                            }
                            else
                            {
                                DepsCmb.Add(new NameCmb { name = f.dep });
                            }
                        if (isRepeatPosts)
                            {
                                continue;
                            }
                            else
                            {
                        PostsCmb.Add(new NameCmb { name = f.post });
                            }
                
                    }

                
                depsBox.DataSource = DepsCmb;
                depsBox.DisplayMember = "name";

                postsBox.DataSource = PostsCmb;
                postsBox.DisplayMember = "name";

                DataTable source = new DataTable();
                using (var reader = ObjectReader.Create(formatDataEmpls, "FIO", "status", "dep", "post", "employ", "uneploy"))
                {
                    source.Load(reader);
                }

                
                this.EmplGrid.DataSource = source;
            }
        }

        private void Authorization_Load(object sender, EventArgs e)
        {
            // Загрузка данных в форму
            this.personsTableAdapter.Fill(this.taskDBDataSet.persons);

        }

        private void Filter_TextChanged(object sender, EventArgs e)
        {
            (EmplGrid.DataSource as DataTable).DefaultView.RowFilter =
                String.Format("FIO like '*{0}%*' or status  like '*{0}%*' or dep like '*{0}%*' or post like '*{0}%*'", Filter.Text);
        }

        private void Infobtn_Click(object sender, EventArgs e)
        {
            int outValue = 0, inValue = 0;
            quanity.Text = "Количество сотрудников в организации на данный момент: " + formatDataEmpls.Count().ToString();
            foreach(FormatDataEmpl f in formatDataEmpls)
            {
                if (f.uneploy != null)
                {
                    if ((DateTime)f.uneploy > DateFirst.Value && (DateTime)f.uneploy < DateLast.Value)
                    {
                        outValue++;
                    }
                }
                if((DateTime)f.employ > DateFirst.Value && (DateTime)f.employ < DateLast.Value)
                {
                    inValue++;
                }
            }
            outlbl.Text = "уволенно: " + outValue;
            inlbl.Text = "принято: " + inValue;
        }

        private void depsBox_SelectedValueChanged(object sender, EventArgs e)
        {
            //(EmplGrid.DataSource as DataTable).DefaultView.RowFilter =
            //String.Format("dep like '*{0}%*'", depsBox.SelectedItem);
            //Filter.Text = depsBox.SelectedItem.ToString();
        }

        private void depsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
