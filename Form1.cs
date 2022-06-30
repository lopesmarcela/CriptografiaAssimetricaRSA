using WFCriptografia;

namespace Criptografia
{
    public partial class Form1 : Form
    {
        Assimetrica a;
        public Form1()
        {
            InitializeComponent();
            a = new Assimetrica();
        }

        private void btnCriptografar_Click(object sender, EventArgs e)
        {
            string frase, fraseCripto;
            frase = tbfrase.Text;            
            fraseCripto = a.encrypt(frase);
            lblcripto.Text = fraseCripto;
        }

        private void btnDescriptografar_Click(object sender, EventArgs e)
        {
            string fraseDescrip, fraseCripto;
            fraseCripto = lblcripto.Text;
            fraseDescrip = a.decrypt(fraseCripto);
            lbldescrip.Text = fraseDescrip;
        }
    }
}