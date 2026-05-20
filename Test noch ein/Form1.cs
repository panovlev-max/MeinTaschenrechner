// biblioteken 
using System.Reflection.Emit;
using System.Text.RegularExpressions;
namespace Test_noch_ein
{


    public partial class Form1 : Form

    {

        int FensterStartW;
        int FensterStartH;

    
        bool register = false;
        bool nurzahlen = false;
        bool OkSimwohle = false;
        string operatorWahl = "";
        bool nurSymbole;
        bool Menschdaten = false;
        string[] geladeneDaten = [];
       

        List<Control> myList = new List<Control>();
           
        public Form1()
        {
            InitializeComponent();
            label1.Text = "schreiben deunen namen";
            FensterStartH = this.ClientSize.Height;
            FensterStartW= this .ClientSize.Width;
            //zeilen

            myList.Add(label1);
            myList.Add(label3);
            myList.Add(label4);
            myList.Add(label5);
            myList.Add(label6);
            myList.Add(label7);
            //alles anderere 
            myList.Add(listBox1);
            myList.Add(pictureBox2);
            myList.Add(pictureBox1);
            //button
            myList.Add(btnCalculate);
            myList.Add(btnClear);
            myList.Add(btnDeleteHistory);
            myList.Add(btnListClear);
            myList.Add(btnRegister);
            myList.Add(btnSeve);
            myList.Add(btnUseSave);
            //textbox
            myList.Add(txtName);
            myList.Add(txtOrt);
            myList.Add(txtOperator);
            myList.Add(txtResult);
            myList.Add(txtZahl1);
            myList.Add(txtZahl2);

            foreach(Control box in myList)
            {
                box.Tag = box.Left + ";" + box.Top + ";" + box.Width + ";" + box.Height;
            }
        }
    
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (0 == this.ClientSize.Width || 0 == this.ClientSize.Height) return;

            float FX = (float)this.ClientSize.Width / FensterStartW;
            float FY = (float)this.ClientSize.Height / FensterStartH;

            foreach(Control box in myList)
            {
                if (box.Tag != null)
                {
                    string[] werte = box.Tag.ToString().Split(';');

                    int sL = int.Parse(werte[0]);
                    int sT = int.Parse(werte[1]);
                    int sW = int.Parse(werte[2]);
                    int sH = int.Parse(werte[3]);

                    box.Left = (int)(sL * FX);
                    box.Top = (int)(sT * FY);
                    box.Width = (int)(sW * FX);
                    box.Height = (int)(sH * FY);

                }
            }
          
        }




        public bool NameIstOk(string name)
        {
            return !string.IsNullOrWhiteSpace(name);
        }

        private void AlleBoxen_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter)
            {

                System.Windows.Forms.TextBox aktuelleBox = (System.Windows.Forms.TextBox)sender;
                e.SuppressKeyPress = true;
                e.Handled = true;

                if (aktuelleBox == txtName)
                {
                    txtOrt.Focus();
                }

                else if (aktuelleBox == txtOrt)
                {

                    btnRegister.Focus();
                    btnRegister.PerformClick();

                }

                else if (aktuelleBox == txtZahl1)
                {
                    txtZahl2.Focus();
                }

                else if (aktuelleBox == txtZahl2)
                {
                    txtOperator.Focus();
                }
                else if (aktuelleBox == txtOperator)
                {

                    btnCalculate.Focus();
                    btnCalculate.PerformClick();
                }


            }

        }


        private void btnRegister_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                e.SuppressKeyPress = true;



            }
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            User CurrentUser = new User();

            CurrentUser.name = txtName.Text;
            CurrentUser.location = txtOrt.Text;

            string Error = CurrentUser.GetValidationError();

            if (Error == "")
            {
                register = true;
                MessageBox.Show("du heist " + CurrentUser.name + "du lebst in" + CurrentUser.location);
                txtZahl1.Focus();
            }
            else
            {
                register = false;
                MessageBox.Show(Error);
                txtName.Focus();
            }

        }


        private void btnCalculate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                e.SuppressKeyPress = true;
                btnCalculate_Click(sender, e);

            }

        }


        public void KeineSimwohle_TextChange(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^[0-9 ,]+$");
            Regex Symbole = new Regex(@"^[* / + -]$");



            if (!regex.IsMatch(txtZahl2.Text + txtZahl1.Text) && txtZahl2.Text + txtZahl1.Text != "")
            {
                nurzahlen = false;

            }
            else
            {
                nurzahlen = true;

            }
            if (!Symbole.IsMatch(txtOperator.Text) && txtOperator.Text != "")
            {
                nurSymbole = false;
            }
            else
            {
                nurSymbole = true;
            }
        }



        private void btnCalculate_Click(object sender, EventArgs e)
        {

            if (!register == true || !nurzahlen == true || !nurSymbole == true)

            {
                if (!register) MessageBox.Show("Erst registrieren!");
                else if (!nurzahlen) MessageBox.Show("Nur Zahlen erlaubt!");
                else if (!nurSymbole) MessageBox.Show("das program fersteht nur /*-+");
                return;
            }
            string op = txtOperator.Text;
            if (!double.TryParse(txtZahl1.Text, out double a)) return;
            if (!double.TryParse(txtZahl2.Text, out double b)) return;
            

            var Rechnungsferktoren = new[] { txtZahl1, txtZahl2 };

            Calculator myMathsIdea = new Calculator();

            double result = myMathsIdea.Berechne(a, b, op);

            listBox1.Items.Add($"{a} {op}{b} = {result}");

            txtResult.Text = "" + result;



        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            var Taschenrechner = new[] { txtZahl1, txtZahl2, txtResult, txtOperator };

            Taschenrechner.ToList().ForEach(box => box.Clear());

            txtZahl1.Focus();
        }
        
      /*  private async void txtResult_TextChanged(object sender, EventArgs e)

        {


            for (int y = 434; y >= 341; y--)
            {

                txtResult.Location = new Point(txtResult.Left,txtResult.Height + 15);

                await Task.Delay(1);
      //wegen fergroßerung des bild schirmes funkzionirt es nciht (rein matimatisch konten wir du der Y alse z.b15prozent einfugen)
            }
        }
        */
        private void btnListClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void speichernButten_Click(object sender, EventArgs e)
        {
          try
            {
                Die_History_Logik history = new Die_History_Logik();
                history.Speichern(listBox1.Items);
                MessageBox.Show("wurde geschpeichert");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void seveverwendenButon_Click(object sender, EventArgs e)
        {
            try
            {
                Die_History_Logik history = new Die_History_Logik();

                geladeneDaten = history.Laden();

                listBox1.Items.Clear();
                listBox1.Items.AddRange(geladeneDaten);
                MessageBox.Show("wurde die hystory ist geladen");
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message);
            }
        }
        private void hystorydelit_Click(object sender, EventArgs e)
        {
           
            try
            {
                Die_History_Logik history = new Die_History_Logik();

                history.Löeschen();
                listBox1.Items.Clear();
             }
            catch (Exception ex)
            {
                    MessageBox.Show(ex.Message);

            }
        }
    }
}
