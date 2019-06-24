using Library.Service;
using Library.Entity;
using Library.DTO;
using Library.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmbeentLibray.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WriterService writerService = new WriterService();
            BookService bookService = new BookService();
            int ID = Convert.ToInt32( textBox1.Text);
            dataGridView1.DataSource = bookService.GetAllBook(ID);
         
            //WriterDTO writerDTO = new WriterDTO();
            //BookDTO bookDTO = new BookDTO();
            ////writerDTO.Name = textBox1.Text;
            ////writerDTO.Surname = textBox2.Text;
            //bookDTO.Name = textBox1.Text;
            //bookDTO.ReleaseDate = DateTime.Today;
            ////writerService.Adding(writerDTO);
            //bookService.Adding(bookDTO);

        }
    }
}
