using System.Windows.Forms.Design;

namespace MiniProject_2_Check__ErikaSanchez
{
    public partial class Form1 : Form
    {
        const decimal TaxRate = 0.07m;
        List<decimal> itemPrices = new List<decimal>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetOrderItems_Click(object sender, EventArgs e)
        {

            string fileName = "ItemsOrdered.txt";

            if (!File.Exists(fileName))
            {
                MessageBox.Show($"El archivo '{fileName}' no existe. Asegúrate de colocarlo en el directorio del programa.");
                return;
            }
            using (StreamReader inputFile = new StreamReader(fileName))
            {
                lstbxItems.Items.Clear();
                itemPrices.Clear();
                try
                {
                    string itemsOrdered;
                    lstbxItems.Items.Clear();
                    itemPrices.Clear();

                    while (!inputFile.EndOfStream)
                    {
                        itemsOrdered = inputFile.ReadLine();
                        string[] parts = itemsOrdered.Split(',');
                        if (parts.Length == 3 && int.TryParse(parts[0].Trim(), out int cantidad) && decimal.TryParse(parts[2].Trim(), out decimal price))
                        {
                            string itemName = parts[1].Trim();
                            decimal totalPrice = cantidad * price;
                            itemPrices.Add(totalPrice);
                            lstbxItems.Items.Add($"{cantidad}, {itemName}, {price:C} = {totalPrice:C}");
                        }
                        else
                        {
                            MessageBox.Show($"Formato de linea invalido: {itemsOrdered}. Asegurese de que el archivo siga: 'cantidad, item, precio'.");
                        }
                    }
                    inputFile.Close();

                    if (itemPrices.Count == 0)
                    {
                        MessageBox.Show("No se han cargado items validos. Por favor revise el formato del archivo");
                    }
                    else
                    {
                        MessageBox.Show("Los items fueron cargados!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void btnCalculateTotals_Click(object sender, EventArgs e)
        {
            if (lstbxItems.Items.Count == 0)
            {
                MessageBox.Show("Por favor cargue los articulos antes de calcular el total.");
                return;
            }

            decimal subTotal = itemPrices.Sum();
            decimal tax = subTotal * TaxRate;


            if (cmbTip.SelectedItem == null)
            {
                MessageBox.Show("Por favor seleccione la cantidad de propina.");
                return;
            }

            if (!decimal.TryParse(cmbTip.SelectedItem.ToString().TrimEnd('%'), out decimal tipPercentage))
            {
                MessageBox.Show("Porcentaje de propina invalido.");
                return;
            }

            tipPercentage /= 100;
            decimal tip = subTotal * tipPercentage;
            decimal total = subTotal + tax + tip;

            txtSubTotal.Text = subTotal.ToString("C");
            txtTaxDue.Text = tax.ToString("C");
            txtTipAmount.Text = tip.ToString("C");
            txtTotalDue.Text = total.ToString("C");

            string paymentMethod = GetPaymentMethod();

            if (string.IsNullOrEmpty(paymentMethod))
            {
                MessageBox.Show("Por favor seleccione método de pago.");
            }
            else
            {
                MessageBox.Show($"Método de pago seleccionado: {paymentMethod}");
            }
        }

        private string GetPaymentMethod()
        {
            if (rbtnCash.Checked)
                return "Cash";
            if (rbtnCreditCard.Checked)
                return "Credit Card";
            if (rbtnATHMovil.Checked)
                return "ATH Móvil";
            if (rbtnOther.Checked)
                return "Other";

            return null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbTip.Items.Add("0%");
            cmbTip.Items.Add("15%");
            cmbTip.Items.Add("20%");
            cmbTip.Items.Add("25%");
            cmbTip.Items.Add("30%");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
