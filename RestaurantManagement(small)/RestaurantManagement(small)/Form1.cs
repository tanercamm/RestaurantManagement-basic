using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagement_small_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongTimeString();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
        }

        private void cbxFries_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxFries.Checked == true)
            {
                txtFries.Enabled = true;
            }
            if (cbxFries.Checked == false)
            {
                txtFries.Enabled = false;
                txtFries.Text = "0";
            }
        }

        private void cbxBurger_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxBurger.Checked == true)
            {
                txtBurger.Enabled = true;
            }
            if (cbxBurger.Checked == false)
            {
                txtBurger.Enabled = false;
                txtBurger.Text = "0";
            }
        }

        private void cbxTaco_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxTaco.Checked == true)
            {
                txtTaco.Enabled = true;
            }
            if (cbxTaco.Checked == false)
            {
                txtTaco.Enabled = false;
                txtTaco.Text = "0";
            }
        }

        private void cbxHotDog_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxHotDog.Checked == true)
            {
                txtHotDog.Enabled = true;
            }
            if (cbxHotDog.Checked == false)
            {
                txtHotDog.Enabled = false;
                txtHotDog.Text = "0";
            }
        }

        private void cbxPizza_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxPizza.Checked == true)
            {
                txtPizza.Enabled = true;
            }
            if (cbxPizza.Checked == false)
            {
                txtPizza.Enabled = false;
                txtPizza.Text = "0";
            }
        }

        private void cbxChicken_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxChicken.Checked == true)
            {
                txtChicken.Enabled = true;
            }
            if (cbxChicken.Checked == false)
            {
                txtChicken.Enabled = false;
                txtChicken.Text = "0";
            }
        }

        private void cbxTea_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxTea.Checked == true)
            {
                txtTea.Enabled = true;
            }
            if (cbxTea.Checked == false)
            {
                txtTea.Enabled = false;
                txtTea.Text = "0";
            }
        }

        private void cbxCola_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxCola.Checked == true)
            {
                txtCola.Enabled = true;
            }
            if (cbxCola.Checked == false)
            {
                txtCola.Enabled = false;
                txtCola.Text = "0";
            }
        }

        private void cbxOrangeJuice_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxOrangeJuice.Checked == true)
            {
                txtOrangeJuice.Enabled = true;
            }
            if (cbxOrangeJuice.Checked == false)
            {
                txtOrangeJuice.Enabled = false;
                txtOrangeJuice.Text = "0";
            }
        }

        private void cbxSoda_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxSoda.Checked == true)
            {
                txtSoda.Enabled = true;
            }
            if (cbxSoda.Checked == false)
            {
                txtSoda.Enabled = false;
                txtSoda.Text = "0";
            }
        }

        private void cbxWater_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxWater.Checked == true)
            {
                txtWater.Enabled = true;
            }
            if (cbxWater.Checked == false)
            {
                txtWater.Enabled = false;
                txtWater.Text = "0";
            }
        }

        private void cbxBeer_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxBeer.Checked == true)
            {
                txtBeer.Enabled = true;
            }
            if (cbxBeer.Checked == false)
            {
                txtBeer.Enabled = false;
                txtBeer.Text = "0";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        // Price information for items
        double friesPrice = 5, burgerPrice = 8, tacoPrice = 7, hotDogPrice = 6, pizzaPrice = 10, chickenPrice = 10;

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtReceip.Text.ToString()+Environment.NewLine+" SubTotal : "+lblSubtotal.Text.ToString()+"        Tax : "+lblTax.Text.ToString()+"        Total : "+lblTotal.Text.ToString(),new Font("Century Gothic",12,FontStyle.Regular),Brushes.Black,new Point(130));
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if(printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // food
            cbxFries.Checked = false;
            cbxBurger.Checked = false;
            cbxTaco.Checked = false;
            cbxHotDog.Checked = false;
            cbxPizza.Checked = false;
            cbxChicken.Checked = false;
            // drink
            cbxTea.Checked = false;
            cbxCola.Checked = false;
            cbxOrangeJuice.Checked = false;
            cbxSoda.Checked = false;
            cbxWater.Checked = false;
            cbxBeer.Checked = false;

        }

        double teaPrice = 3, colaPrice = 4, orangeJuicePrice = 3, sodaPrice = 4, waterPrice = 2, beerPrice = 5;

        double friesZ, burgerZ, tacoZ, hotDogZ, pizzaZ, chickenZ, teaZ, colaZ, orangeJuiceZ, sodaZ, waterZ, beerZ;
        double Subtotal = 0, tax, total;

        private void button3_Click(object sender, EventArgs e)
        {
            // food
            friesZ = friesPrice * Convert.ToDouble(txtFries.Text);
            burgerZ = burgerPrice * Convert.ToDouble(txtBurger.Text);
            tacoZ = tacoPrice * Convert.ToDouble(txtTaco.Text);
            hotDogZ = hotDogPrice * Convert.ToDouble(txtHotDog.Text);
            pizzaZ = pizzaPrice * Convert.ToDouble(txtPizza.Text);
            chickenZ = chickenPrice * Convert.ToDouble(txtChicken.Text);
            // drink
            teaZ = teaPrice * Convert.ToDouble(txtTea.Text);
            colaZ = colaPrice * Convert.ToDouble(txtCola.Text);
            orangeJuiceZ = orangeJuicePrice * Convert.ToDouble(txtOrangeJuice.Text);
            sodaZ = sodaPrice * Convert.ToDouble(txtSoda.Text);
            waterZ = waterPrice * Convert.ToDouble(txtWater.Text);
            beerZ = beerPrice * Convert.ToDouble(txtBeer.Text);
            // Receip
            txtReceip.Clear();
            Subtotal = 0;
            txtReceip.AppendText(Environment.NewLine);
            txtReceip.AppendText("\t\t♦♦ Vegan Spirit Restaurant ♦♦\t" + lblDate.Text+Environment.NewLine);
            txtReceip.AppendText("***************************************************************"+Environment.NewLine);
            // food
            if (cbxFries.Checked == true) 
            {
                txtReceip.AppendText("\tFries : "+friesZ+"$"+Environment.NewLine);
                Subtotal += friesZ;
                lblSubtotal.Text = "" + Subtotal + "$";
            }
            if (cbxBurger.Checked == true)
            {
                txtReceip.AppendText("\tBurger : "+burgerZ+ "$" + Environment.NewLine);
                Subtotal += burgerZ;
                lblSubtotal.Text = "" + Subtotal + "$";
            }
            if (cbxTaco.Checked == true)
            {
                txtReceip.AppendText("\tTaco : " + tacoZ + "$" + Environment.NewLine);
                Subtotal += tacoZ;
                lblSubtotal.Text = "" + Subtotal + "$";
            }
            if (cbxHotDog.Checked == true)
            {
                txtReceip.AppendText("\tHot Dog : " + hotDogZ + "$" + Environment.NewLine);
                Subtotal += hotDogZ;
                lblSubtotal.Text = "" + Subtotal + "$";
            }
            if (cbxPizza.Checked == true)
            {
                txtReceip.AppendText("\tPizza : " + pizzaZ + "$" + Environment.NewLine);
                Subtotal += pizzaZ;
                lblSubtotal.Text = "" + Subtotal + "$"; ;
            }
            if (cbxChicken.Checked == true)
            {
                txtReceip.AppendText("\tChicken : " + chickenZ + "$" + Environment.NewLine);
                Subtotal += chickenZ;
                lblSubtotal.Text = "" + Subtotal+"$";
            }
            // drink
            if (cbxTea.Checked == true)
            {
                txtReceip.AppendText("\tTea : " + teaZ + "$" + Environment.NewLine);
                Subtotal += teaZ;
                lblSubtotal.Text = "" + Subtotal + "$";
            }
            if (cbxCola.Checked == true)
            {
                txtReceip.AppendText("\tCola : " + colaZ + "$" + Environment.NewLine);
                Subtotal += colaZ;
                lblSubtotal.Text = "" + Subtotal + "$";
            }
            if (cbxOrangeJuice.Checked == true)
            {
                txtReceip.AppendText("\tOrange Juice : " + orangeJuiceZ + "$" + Environment.NewLine);
                Subtotal += orangeJuiceZ;
                lblSubtotal.Text = "" + Subtotal + "$";
            }
            if (cbxSoda.Checked == true)
            {
                txtReceip.AppendText("\tSoda : " + sodaZ + "$" + Environment.NewLine);
                Subtotal += sodaZ;
                lblSubtotal.Text = "" + Subtotal + "$";
            }
            if (cbxWater.Checked == true)
            {
                txtReceip.AppendText("\tWater : " + waterZ + "$" + Environment.NewLine);
                Subtotal += waterZ;
                lblSubtotal.Text = "" + Subtotal + "$";
            }
            if (cbxBeer.Checked == true)
            {
                txtReceip.AppendText("\tBeer : " + beerZ + "$" + Environment.NewLine);
                Subtotal += beerZ;
                lblSubtotal.Text = "" + Subtotal + "$";
            }
            // %8 tax calculation to be changed based on your rules tax regulations
            tax = Subtotal * 0.08;
            total = Subtotal + tax;
            lblTax.Text = tax + " $";
            lblTotal.Text = total + " $";



        }

        

    }
}
