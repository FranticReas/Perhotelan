using Perhotelan.Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Perhotelan.Model.Context;
using Perhotelan.Model.Entity;


namespace Perhotelan.Controller
{
    class UserController
    {
        // deklarasi objek Repository untuk menjalankan operasi CRUD
        private UserRepository _repository;

        public int Create(User user)
        {
            int result = 0;

            // cek username yang diinputkan tidak boleh kosong 
            if (string.IsNullOrEmpty(user.username))
            {
                MessageBox.Show("username harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek email yang diinputkan tidak boleh kosong 
            if (string.IsNullOrEmpty(user.email))
            {
                MessageBox.Show("Email harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek password yang diinputkan tidak boleh kosong 
            if (string.IsNullOrEmpty(user.password))
            {
                MessageBox.Show("Password harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek noHP yang diinputkan tidak boleh kosong 
            if (string.IsNullOrEmpty(user.phoneNumber))
            {
                MessageBox.Show("Nomor HP harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek tgl lahir yang diinputkan tidak boleh kosong 
            if (user.birthdate.HasValue)
            {
                MessageBox.Show("Tanggal lahir harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using 
            using (DdContext context = new DdContext())
            {
                // membuat objek class repository 
                _repository = new UserRepository(context);

                // panggil method Create class repository untuk menambahkan data 
                result = _repository.Create(user);
            }

            if (result > 0)
            {
                MessageBox.Show("Data mahasiswa berhasil disimpan !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data mahasiswa gagal disimpan !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return result;
        }
      
    }
}
