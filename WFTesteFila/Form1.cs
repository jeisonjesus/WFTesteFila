﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Messaging;
using System.IO;

namespace WFTesteFila
{
    public partial class Form1 : Form
    {
        MessageQueue mQ;
        System.Messaging.Message msg;
        BinaryReader br;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string textoMsg = DateTime.Now.TimeOfDay.ToString() + ":" + txtMensagem.Text;
            if (MessageQueue.Exists(@".\Private$\TesteFila"))
            {
                mQ = new MessageQueue(@".\Private$\TesteFila");
            }
            else
            {
                mQ = MessageQueue.Create(@".\Private$\TesteFila");
            }
            mQ.Send(textoMsg, "TesteFila");
            lstMSMQ.Items.Add(string.Format("Msg::>Mensagem enviada para a fila. {0}", DateTime.Now.TimeOfDay.ToString()));
        }

        private void btnLer_Click(object sender, EventArgs e)
        {
            string texto;
            try
            {
                msg = mQ.Receive(new TimeSpan(0, 0, 3));
                br = new BinaryReader(msg.BodyStream);
                texto = new string(br.ReadChars(Convert.ToInt32(msg.BodyStream.Length)));
                lstMSMQ.Items.Add(string.Format("RE::> {0}", texto));
            }
            catch
            {
                lstMSMQ.Items.Add("Não há mensagens recebidadas.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                treeView1.Nodes.Clear();
                treeView1.BeginUpdate();

                MessageQueue[] filas = MessageQueue.GetPrivateQueuesByMachine("localhost");


                foreach (MessageQueue fila in filas)
                {
                    TreeNode qNode = new TreeNode();
                    qNode.Text = fila.QueueName;
                    qNode.Tag = "Fila";

                    treeView1.Nodes.Add(qNode);

                    foreach (System.Messaging.Message m in fila)
                    {
                        TreeNode mNode = new TreeNode();
                        mNode.Tag = "Msg";
                        mNode.Text = m.Label;
                        treeView1.Nodes[Array.IndexOf(filas, fila)].Nodes.Add(mNode);
                    }
                }
                treeView1.EndUpdate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }
    }
}