namespace FirstWinFormsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonHello_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;

            string schoolSubject = "Ulubione przedmioty:\n";
            if (checkBoxSchoolSubjectMathematics.Checked)
            {
                schoolSubject += "matematyka\n";
            }
            if (checkBoxSchoolSubjectGerman.Checked)
            {
                schoolSubject += "j�zyk niemiecki\n";
            }

            string pizzaWithPineapple = "";
            if (radioButtonPizzaQuestionYes.Checked)
            {
                pizzaWithPineapple = "Lubi� pizze z ananasem.";
            }
            else
            {
                pizzaWithPineapple = "Pizza z ananasem to nieporozumienie";
            }

            MessageBox.Show(
                $"Witaj {name} w pierwszym programie.\n {schoolSubject}"
                + $"\n{pizzaWithPineapple}",
                "Komunikat",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button2);
        }

    }
}