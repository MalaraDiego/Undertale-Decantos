namespace Undertale
{
    public partial class Form1 : Form
    {
        GestoreGioco g;
        
        System.Windows.Forms.Timer timer;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            g = new GestoreGioco();
            Controls.Add(g.RS());
            g.RS().BringToFront();
            timer = new System.Windows.Forms.Timer();
            timer.Tick += c;
            timer.Interval = 3000;
            timer.Start();

        }

        private void c(object sender, EventArgs e)
        {
            if (g.RS().IsDisposed)
            {
                ProvaPerGioco();
                g.Gioco(panel1);
                AggiornaInv();
                AggiornaSkill();
                label1.Text = g.HpMostro().ToString(); // Aggiorna la label degli HP del mostro
                label2.Text = g.HpGiocatore().ToString(); // Aggiorna la label degli HP del giocatore
                if (g.HpGiocatore() == 0)
                {
                    MessageBox.Show("Hai PERSO");
                    timer.Stop();
                }
                if (g.HpMostro() == 0)
                {
                    MessageBox.Show("Hai Vinto");
                    timer.Stop();
                    
                }

            }
            


        }
        private void ProvaPerGioco()
        {
            try
            {
                listBox1.Items.Clear();
                foreach (string s in g.RD())
                {
                    listBox1.Items.Add(s);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AggiornaInv()
        {
            try
            {
                listBox3.Items.Clear();
                foreach (Items s in g.RitornaInventario())
                {
                    listBox3.Items.Add(s);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AggiornaSkill()
        {
            try
            {
                listBox2.Items.Clear();
                foreach (string s in g.getMosse())
                {
                    listBox2.Items.Add(s);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            g.Attacca(listBox2.SelectedIndex);
            label1.Text = g.HpMostro().ToString(); // Aggiorna la label degli HP del mostro
            label2.Text = g.HpGiocatore().ToString(); // Aggiorna la label degli HP del giocatore
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Items i = (Items)listBox3.SelectedItem;
                g.UsaItem(i);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
