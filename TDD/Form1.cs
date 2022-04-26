using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDD
{
    public partial class Form1 : Form
    {
        List<Worker> workers = new List<Worker>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void newWorkerBtn_Click(object sender, EventArgs e)
        {
            var w = new Worker(
                idText.Text,
                nameText.Text,
                familyText.Text,
                emailText.Text,
                phoneText.Text,
                adressText.Text,
                Convert.ToInt32(salaryText.Text)
            );
            workers.Add(w);
        }

        private void addAlotBtn_Click(object sender, EventArgs e)
        {
            workerBar.Maximum = 10000;
            for (int i = 0; i < 10000; i++)
            {
                workers.Add(new Worker());
                workerBar.PerformStep();
            }

            workerBar.Value = 0;
        }

        private void sortBtn_Click(object sender, EventArgs e)
        {
            var time = System.Diagnostics.Stopwatch.StartNew();
            var workers = Sort.QuickWorkers(this.workers.ToArray(),0,this.workers.Count - 1);
            time.Stop();
            var elapsed = time.ElapsedMilliseconds;
            timeLbl.Text = $"{elapsed} Elapsed Milliseconds";
            this.workers = new List<Worker>(workers);
            RefreshList();

        }
        private void RefreshList()
        {
            workerBar.Maximum = workers.Count;

            workerTable.Rows.Clear();
            foreach (var worker in workers)
            {
                workerTable.Rows.Add(
                    $"{worker.name} {worker.family}",
                    worker.id,
                    worker.phone,
                    worker.email,
                    worker.address,
                    worker.salary
                );
                workerBar.PerformStep();
            }

            workerBar.Value = 0;
        }
        private void showBtn_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void calcTaxBtn_Click(object sender, EventArgs e)
        {
            if (workerTable.SelectedCells.Count == 0) return;
            var s = workerTable.Rows[workerTable.SelectedCells[0].RowIndex];
            var v = (s.Cells[2]).Value;
            incomeLbl.Text = $"{(int)v * Worker.CountTax((int)v)} $";
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void bubbleSortBtn_Click(object sender, EventArgs e)
        {
            var time = System.Diagnostics.Stopwatch.StartNew();
            var workers = Sort.BubbleWorkers(this.workers.ToArray());
            time.Stop();
            var elapsed = time.ElapsedMilliseconds;
            timeLbl.Text = $"{elapsed} Elapsed Milliseconds";
            this.workers = new List<Worker>(workers);
            RefreshList();
        }

        private void salaryText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }
        
    }
}
