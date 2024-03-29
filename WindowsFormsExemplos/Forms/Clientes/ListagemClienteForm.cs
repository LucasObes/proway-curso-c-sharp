﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsExemplos.Servicos;

namespace WindowsFormsExemplos.Forms.Clientes
{
    public partial class ListagemClienteForm : Form
    {
        private ClienteServico clienteServico;

        public ListagemClienteForm()
        {
            InitializeComponent();

            clienteServico = new ClienteServico();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListagemClienteForm_Load(object sender, EventArgs e)
        {
            ListarClientes();
        }

        private void ListarClientes()
        {
            var clientes = clienteServico.ObterTodos();

            dataGridView1.Rows.Clear();

            foreach (var cliente in clientes)
            {
                dataGridView1.Rows.Add(new object[]
                {
                    cliente.Id,
                    cliente.Nome,
                    cliente.Cpf
                });
            }
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var form = new CadastroClienteForm();
            form.ShowDialog();

            ListarClientes();
        }
    }
}
