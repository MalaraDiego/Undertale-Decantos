using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Undertale
{
    public class SchermataStart
    {
        private Panel p;
        private ComboBox _comboBox;
        private ComboBox _comboBox2;
        private Button _button1;
        private Label lbTitolo;
        private Label lbTitolo2;
        private Label lbTitolo3;
        List<string> c;
        public Panel getSchermata()
        {
            
            p.Controls.Add(_comboBox);
            p.Controls.Add(_comboBox2);
            p.Controls.Add(_button1);
            p.Controls.Add(lbTitolo);
            p.Controls.Add(lbTitolo2);
            p.Controls.Add(lbTitolo3);
            p.BackColor = Color.Yellow;
            p.BringToFront();
            return p;
            
        }
        public List<string> getDati()
        {
            return c;
        }

        private void bt(object sender, EventArgs e)
        {
            try
            {
                if (_comboBox.SelectedIndex != -1 && _comboBox2.SelectedIndex != -1) {
                    c.Add(_comboBox.SelectedItem.ToString());
                    c.Add(_comboBox2.SelectedItem.ToString());
                    p.Dispose();
                }
                else
                {
                    throw new Exception("Seleziona un mostro / giocatore");
                }
                
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        public SchermataStart() {
            c = new List<string>();
            p = new Panel();
            p.Size = new Size(816, 489);
            _comboBox = new ComboBox();
            _comboBox2 = new ComboBox();
            _button1 = new Button();
            lbTitolo = new Label();
            lbTitolo.Text = "UNDERTALE";
            lbTitolo.Font = new Font("Times New Roman", 30, FontStyle.Bold | FontStyle.Italic);
            lbTitolo.Location = new Point(245, 63);
            lbTitolo.Size = new Size(400, 50);
            lbTitolo2 = new Label();
            lbTitolo2.Text = "Personaggio";
            lbTitolo2.Location = new Point(206, 168);
            lbTitolo3 = new Label();
            lbTitolo3.Text = "Mostro";
            lbTitolo3.Location = new Point(427, 168);

            _comboBox.Location = new Point(206, 211);
            _comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            _comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            _comboBox.Items.Add("Frisk");
            _comboBox.Items.Add("Clover");
            _comboBox.Items.Add("Kunigami");

            _comboBox2.Items.Add("Froggit");
            _comboBox2.Items.Add("Papirus");
            _comboBox2.Items.Add("Asgore");

            _comboBox2.Location = new Point(427, 211);
            _button1.Location = new Point(324, 294);
            _button1.Size = new Size(103, 43);
            _button1.Text = "START!";
            _button1.Click += bt;
        }
    }
}
