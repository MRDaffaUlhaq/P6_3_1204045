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

namespace P6_3_1204045
{
    public partial class Form1 : Form
    {
        string prodiSelect;
        
        public Form1()
        {
            

            InitializeComponent();
            //string myConnectionString = "integrated security=true;data source=.;initial catalog=P6_1204039";
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-2TQJ2POM\P6_1204045;Initial Catalog=P6_1204045;Integrated Security=True"); 
            conn.Open();
            SqlCommand sc = new SqlCommand("SELECT * FROM msprodi", conn);
            SqlDataReader reader;

            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("id_prodi", typeof(string));
            dt.Columns.Add("singkatan", typeof(string));
            dt.Load(reader);

            prodi.ValueMember = "id_prodi";
            prodi.DisplayMember = "singkatan";
            prodi.DataSource = dt;

            conn.Close();
        }
        

        private void npm_TextChanged(object sender, EventArgs e)
        {
            if (npm.TextLength < 7)
            {
                errorProvider1.SetError(npm, "Format NPM belum benar!");
            }
            else if (npm.TextLength == 7)
            {
                errorProvider1.SetError(npm, "");
            }
            else if (npm.TextLength == 0)
            {
                errorProvider1.SetError(npm, "Tidak Boleh Kosong!");
            }
        }

        private void nama_TextChanged(object sender, EventArgs e)
        {
            if (nama.TextLength == 0)
            {
                errorProvider1.SetError(nama, "Tidak Boleh Kosong!");
            }
        }


        private void submit_Click(object sender, EventArgs e)
        {
            if (npm.Text != "" && npm.Text.Length == 7)
            {
                if (nama.Text != "")
                {
                    if (ttl.Text != "")
                    {
                        if (pria.Checked || wanita.Checked)
                        {
                            if (alamat.Text != "")
                            {
                                if (tlp.Text != "")
                                {
                                    if (prodi.Text != "")
                                    {
                                        string Npm = npm.Text;
                                        string Nama = nama.Text;
                                        string Ttl = ttl.Text;
                                        string jk = "";
                                        if (pria.Checked)
                                        {
                                            jk = pria.Text;
                                        }
                                        if (wanita.Checked)
                                        {
                                            jk = wanita.Text;
                                        }
                                        string Alamat = alamat.Text;
                                        string notelp = tlp.Text;
                                        string prodi = this.prodiSelect;

                                        string myConnectionString = "Data Source=LAPTOP-2TQJ2POM\\P6_1204045;Initial Catalog=P6_1204045;Integrated Security=True";
                                        SqlConnection conn = new SqlConnection(myConnectionString);

                                        string sql = "insert into msmhs ([nim], [nama], [tgl_lahir], [jenis_kelamin], [alamat], " +
                                            "[telepon], [id_prodi]) values(@nim,@nama,@ttl,@jk,@alamat,@tlp,@idprodi)";

                                        using (SqlConnection cnn = new SqlConnection(myConnectionString))
                                        {
                                            try
                                            {
                                                cnn.Open();

                                                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                                                {
                                                    cmd.Parameters.Add("@nim", SqlDbType.NVarChar).Value = Npm;
                                                    cmd.Parameters.Add("@nama", SqlDbType.NVarChar).Value = Nama;
                                                    cmd.Parameters.Add("@ttl", SqlDbType.DateTime).Value = Ttl;
                                                    cmd.Parameters.Add("@jk", SqlDbType.NVarChar).Value = jk;
                                                    cmd.Parameters.Add("@alamat", SqlDbType.NVarChar).Value = Alamat;
                                                    cmd.Parameters.Add("@tlp", SqlDbType.NVarChar).Value = notelp;
                                                    cmd.Parameters.Add("@idprodi", SqlDbType.NVarChar).Value = prodi;

                                                    int rowsAdded = cmd.ExecuteNonQuery();
                                                    if (rowsAdded > 0)
                                                        MessageBox.Show("Data berhasil disimpan");
                                                    else
                                                        MessageBox.Show("Tidak ada data yang disimpan");

                                                }
                                            }
                                            catch (Exception ex)
                                            {
                                                MessageBox.Show("ERROR:" + ex.Message);
                                            }
                                        }



                                    }
                                    else
                                    {
                                        MessageBox.Show
                                                    ("Program studi beum diisi!",
                                                    "Informasi Data Mahasiswa",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show
                                            ("Nomor Telepon belum diisi!",
                                            "Informasi Data Mahasiswa",
                                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                
                            }
                            else
                            {
                                MessageBox.Show
                                            ("Alamat belum diisi!",
                                            "Informasi Data Mahasiswa",
                                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show
                                        ("Jenis kelamin belum dipilih!",
                                        "Informasi Data Mahasiswa",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show
                                    ("Tanggal lahir belum diisi!",
                                    "Informasi Data Mahasiswa",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show
                                ("Nama belum diisi!"+ttl.Text,
                                "Informasi Data Mahasiswa",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show
                            ("NPM belum diisi dan harus terdiri dari 7 digit!",
                            "Informasi Data Mahasiswa",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
        }

        private void prodi_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.prodiSelect = prodi.SelectedValue.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            npm.Text = null;
            nama.Text = null;
            ttl.Text = null;
            pria.Checked = false;
            wanita.Checked = false;
            alamat.Text = "";
            tlp.Text = null;
            prodi.SelectedIndex = 0;
        }
    }
}
