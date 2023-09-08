using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSAutoBuy
{
    public partial class Form1 : Form
    {
        private string DirDoc { get; set; }
        private List<string> LinhasCfg { get; set; }
        private Configs Configs { get; set; }
        private List<Equipa> Equipas { get; set; }
        private string Tecla { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.DirDoc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\CPSystems\\CSAutoBuy";

            if (!Directory.Exists(this.DirDoc))
            {
                Directory.CreateDirectory(this.DirDoc);
            }

            this.Equipas = new List<Equipa>();
            this.Equipas.Add(new Equipa() { Nome = "Glock (Pistolas)", Vaue = "glock", Resources = CSAutoBuy.Properties.Resources.glock, Type = Equipa.TypeEquipa.Pistolas });
            this.Equipas.Add(new Equipa() { Nome = "USP (Pistolas)", Vaue = "usp", Resources = CSAutoBuy.Properties.Resources.usp, Type = Equipa.TypeEquipa.Pistolas });
            this.Equipas.Add(new Equipa() { Nome = "P228 (Pistolas)", Vaue = "p228", Resources = CSAutoBuy.Properties.Resources.p228, Type = Equipa.TypeEquipa.Pistolas });
            this.Equipas.Add(new Equipa() { Nome = "Desert Eagle (Pistolas)", Vaue = "deagle", Resources = CSAutoBuy.Properties.Resources.deagle, Type = Equipa.TypeEquipa.Pistolas });
            this.Equipas.Add(new Equipa() { Nome = "Elites (Pistolas)", Vaue = "elites", Resources = CSAutoBuy.Properties.Resources.elites, Type = Equipa.TypeEquipa.Pistolas });
            this.Equipas.Add(new Equipa() { Nome = "Five-SeveN (Pistolas)", Vaue = "fn57", Resources = CSAutoBuy.Properties.Resources.fn57, Type = Equipa.TypeEquipa.Pistolas });
            this.Equipas.Add(new Equipa() { Nome = "M3 (Escopetas)", Vaue = "m3", Resources = CSAutoBuy.Properties.Resources.m3, Type = Equipa.TypeEquipa.Escopetas });
            this.Equipas.Add(new Equipa() { Nome = "XM1014 (Escopetas)", Vaue = "xm1014", Resources = CSAutoBuy.Properties.Resources.xm1014, Type = Equipa.TypeEquipa.Escopetas });
            this.Equipas.Add(new Equipa() { Nome = "MAC 10tmp (Sub-Metralhadoras)", Vaue = "mac10tmp", Resources = CSAutoBuy.Properties.Resources.mac10tmp, Type = Equipa.TypeEquipa.Sub_Metralhadoras });
            this.Equipas.Add(new Equipa() { Nome = "MP 5 (Sub-Metralhadoras)", Vaue = "mp5", Resources = CSAutoBuy.Properties.Resources.mp5, Type = Equipa.TypeEquipa.Sub_Metralhadoras });
            this.Equipas.Add(new Equipa() { Nome = "UMP 45 (Sub-Metralhadoras)", Vaue = "ump45", Resources = CSAutoBuy.Properties.Resources.ump45, Type = Equipa.TypeEquipa.Sub_Metralhadoras });
            this.Equipas.Add(new Equipa() { Nome = "P90 (Sub-Metralhadoras)", Vaue = "p90", Resources = CSAutoBuy.Properties.Resources.p90, Type = Equipa.TypeEquipa.Sub_Metralhadoras });
            this.Equipas.Add(new Equipa() { Nome = "Galil (Rifles)", Vaue = "galil", Resources = CSAutoBuy.Properties.Resources.galil, Type = Equipa.TypeEquipa.Rifles });
            this.Equipas.Add(new Equipa() { Nome = "AK-47 (Rifles)", Vaue = "ak47", Resources = CSAutoBuy.Properties.Resources.ak47, Type = Equipa.TypeEquipa.Rifles });
            this.Equipas.Add(new Equipa() { Nome = "Scout (Rifles)", Vaue = "scout", Resources = CSAutoBuy.Properties.Resources.scout, Type = Equipa.TypeEquipa.Rifles });
            this.Equipas.Add(new Equipa() { Nome = "SG 552 (Rifles)", Vaue = "sg552", Resources = CSAutoBuy.Properties.Resources.sg552, Type = Equipa.TypeEquipa.Rifles });
            this.Equipas.Add(new Equipa() { Nome = "AWP (Rifles)", Vaue = "awp", Resources = CSAutoBuy.Properties.Resources.awp, Type = Equipa.TypeEquipa.Rifles });
            this.Equipas.Add(new Equipa() { Nome = "G3sg1 (Rifles)", Vaue = "g3sg1", Resources = CSAutoBuy.Properties.Resources.g3sg1, Type = Equipa.TypeEquipa.Rifles });
            this.Equipas.Add(new Equipa() { Nome = "FAMAS (Rifles)", Vaue = "famas", Resources = CSAutoBuy.Properties.Resources.famas, Type = Equipa.TypeEquipa.Rifles });
            this.Equipas.Add(new Equipa() { Nome = "M4A1 (Rifles)", Vaue = "m4a1", Resources = CSAutoBuy.Properties.Resources.m4a1, Type = Equipa.TypeEquipa.Rifles });
            this.Equipas.Add(new Equipa() { Nome = "AUG (Rifles)", Vaue = "aug", Resources = CSAutoBuy.Properties.Resources.aug, Type = Equipa.TypeEquipa.Rifles });
            this.Equipas.Add(new Equipa() { Nome = "SG 550 (Rifles)", Vaue = "sg550", Resources = CSAutoBuy.Properties.Resources.sg550, Type = Equipa.TypeEquipa.Rifles });
            this.Equipas.Add(new Equipa() { Nome = "M249 (Metralhadoras)", Vaue = "m249", Resources = CSAutoBuy.Properties.Resources.m249, Type = Equipa.TypeEquipa.Metralhadoras });
            this.Equipas.Add(new Equipa() { Nome = "Prim Ammo (Munições)", Vaue = "primammo", Resources = CSAutoBuy.Properties.Resources.glock, Type = Equipa.TypeEquipa.Municoes });
            this.Equipas.Add(new Equipa() { Nome = "Sec Ammo (Munições)", Vaue = "secammo", Resources = CSAutoBuy.Properties.Resources.m3, Type = Equipa.TypeEquipa.Municoes });
            this.Equipas.Add(new Equipa() { Nome = "Buy Ammo 1 (Munições)", Vaue = "buyammo1", Resources = CSAutoBuy.Properties.Resources.glock, Type = Equipa.TypeEquipa.Municoes });
            this.Equipas.Add(new Equipa() { Nome = "Buy Ammo2 (Munições)", Vaue = "buyammo2", Resources = CSAutoBuy.Properties.Resources.m3, Type = Equipa.TypeEquipa.Municoes });
            this.Equipas.Add(new Equipa() { Nome = "Colete (Equipamentos)", Vaue = "vest", Resources = CSAutoBuy.Properties.Resources.vest, Type = Equipa.TypeEquipa.Equipamentos });
            this.Equipas.Add(new Equipa() { Nome = "Colete + Capacete (Equipamentos)", Vaue = "vesthelm", Resources = CSAutoBuy.Properties.Resources.vesthelm, Type = Equipa.TypeEquipa.Equipamentos });
            this.Equipas.Add(new Equipa() { Nome = "Granada Flash (Equipamentos)", Vaue = "flash", Resources = CSAutoBuy.Properties.Resources.flash, Type = Equipa.TypeEquipa.Equipamentos });
            this.Equipas.Add(new Equipa() { Nome = "Granada HE (Equipamentos)", Vaue = "hegren", Resources = CSAutoBuy.Properties.Resources.hegren, Type = Equipa.TypeEquipa.Equipamentos });
            this.Equipas.Add(new Equipa() { Nome = "Granada SG (Equipamentos)", Vaue = "sgren", Resources = CSAutoBuy.Properties.Resources.sgren, Type = Equipa.TypeEquipa.Equipamentos });
            this.Equipas.Add(new Equipa() { Nome = "Visão Noturna (Equipamentos)", Vaue = "nvgs", Resources = CSAutoBuy.Properties.Resources.nvgs, Type = Equipa.TypeEquipa.Equipamentos });
            this.Equipas.Add(new Equipa() { Nome = "KIt de Desarmamentos (Equipamentos)", Vaue = "defuser", Resources = CSAutoBuy.Properties.Resources.defuser, Type = Equipa.TypeEquipa.Equipamentos });
            this.Equipas.Add(new Equipa() { Nome = "Escudo Tático (Equipamentos)", Vaue = "shield", Resources = CSAutoBuy.Properties.Resources.shield, Type = Equipa.TypeEquipa.Equipamentos });

            foreach (var item in this.Equipas)
            {
                listEquipamentos.Items.Add(item.Nome);
            }

            this.Configs = new Configs();

            this.LoadConfig();

            this.ValidaTela();
        }

        private void btnPorcurar_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = "Config (*.cfg)|*.cfg";
            this.openFileDialog1.Title = "Selecionar Config";

            DialogResult dr = this.openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    txtCaminhao.Text = this.openFileDialog1.FileName;
                    this.Configs.Cfg = txtCaminhao.Text;

                    this.SaveConfig();

                    this.ValidaTela();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void rbtF3_CheckedChanged(object sender, EventArgs e)
        {
            this.ValidaConfig("F3");
        }

        private void rbtF4_CheckedChanged(object sender, EventArgs e)
        {
            this.ValidaConfig("F4");
        }

        private void rbtF6_CheckedChanged(object sender, EventArgs e)
        {
            this.ValidaConfig("F6");
        }

        private void rbtF7_CheckedChanged(object sender, EventArgs e)
        {
            this.ValidaConfig("F7");
        }

        private void rbtF8_CheckedChanged(object sender, EventArgs e)
        {
            this.ValidaConfig("F8");
        }

        private void rbtF9_CheckedChanged(object sender, EventArgs e)
        {
            this.ValidaConfig("F9");
        }

        private void rbtF11_CheckedChanged(object sender, EventArgs e)
        {
            this.ValidaConfig("F11");
        }

        private void rbtF12_CheckedChanged(object sender, EventArgs e)
        {
            this.ValidaConfig("F12");
        }

        private void rbtOutra_CheckedChanged(object sender, EventArgs e)
        {
            this.ValidaConfig(txtTecla.Text);
        }

        private void txtTecla_TextChanged(object sender, EventArgs e)
        {
            this.ValidaConfig(txtTecla.Text);
        }

        private void listEquipamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listEquipamentos.SelectedIndex > -1)
            {
                imgEquip.BackgroundImage = (Image)this.Equipas[listEquipamentos.SelectedIndex].Resources;
            }
        }

        private void listEquipaatua_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listEquipaatua.SelectedIndex > -1)
            {
                foreach (var item in this.Equipas)
                {
                    if (item.Nome.Equals(listEquipaatua.SelectedItem.ToString()))
                    {
                        imgEquip.BackgroundImage = (Image)item.Resources;
                        break;
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(listEquipamentos.SelectedIndex > -1)
            {
                listEquipaatua.Items.Add(this.Equipas[listEquipamentos.SelectedIndex].Nome);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listEquipaatua.SelectedIndex > -1)
            {
                listEquipaatua.Items.RemoveAt(listEquipaatua.SelectedIndex);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Ao salvar se a configurção já existir, ela será subistituída!", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string linha = "";

                foreach (var item in listEquipaatua.Items)
                {
                    foreach (var item1 in this.Equipas)
                    {
                        if (item1.Nome.Equals(item))
                        {
                            linha += item1.Vaue + ";";
                            break;
                        }
                    }
                }

                if (linha.Length > 0)
                {
                    linha = linha.Substring(0, linha.Length - 1);
                }

                bool addcfg = true;
                foreach (var item in this.Configs.Binds)
                {
                    if (item.Tecla.Equals(this.Tecla))
                    {
                        item.Nome = txtNome.Text;
                        item.Linha = linha;
                    }
                }

                if (addcfg)
                {
                    this.Configs.Binds.Add(new Bind() { Nome = txtNome.Text, Tecla = this.Tecla, Linha = linha });
                }

                if (chbCopia.Checked)
                {
                    File.Copy(this.Configs.Cfg, this.DirDoc + "\\bkp_" + DateTime.Now.ToString("ddMMyyyyHHmmss") + "_config.cfg");
                }

                bool add = true;
                for (int x = 0; x < this.LinhasCfg.Count; x++)
                {
                    if(this.LinhasCfg[x].Contains("bind \"" + this.Tecla + "\""))
                    {
                        this.LinhasCfg[x] = "bind \"" + this.Tecla + "\" \"" + linha + "\"";
                        add = false;
                    }
                }

                if (add)
                {
                    this.LinhasCfg.Add("bind \"" + this.Tecla + "\" \"" + linha + "\"");
                }

                using (StreamWriter writer = new StreamWriter(this.Configs.Cfg, false))
                {
                    foreach (var item in this.LinhasCfg)
                    {
                        writer.WriteLine(item);
                    }
                }

                this.SaveConfig();

                this.ValidaTela();
            }
        }

        private void ValidaTela()
        {
            txtArquivoLido.Text = "";
            txtCaminhao.Text = this.Configs.Cfg;
            if (txtCaminhao.Text.Equals(string.Empty))
            {
                pnlEditor.Enabled = false;
            }
            else
            {
                pnlEditor.Enabled = true;

                this.LinhasCfg = File.ReadAllLines(txtCaminhao.Text).ToList<string>();
            }

            if(this.LinhasCfg != null)
            {
                foreach (var item in this.LinhasCfg)
                {
                    txtArquivoLido.Text += item + "\r";
                }
            }

            btnSalvar.Enabled = false;
        }

        private void ValidaConfig(string tecla)
        {
            txtNome.Text = "";

            listEquipaatua.Items.Clear();

            btnSalvar.Enabled = true;

            this.Tecla = tecla;

            foreach (var item in this.Configs.Binds)
            {
                if (item.Tecla.Equals(tecla))
                {
                    txtNome.Text = item.Nome;

                    string[] eqp = item.Linha.Split(';');

                    foreach (var item1 in eqp)
                    {
                        foreach (var item2 in this.Equipas)
                        {
                            if (item2.Vaue.Equals(item1))
                            {
                                listEquipaatua.Items.Add(item2.Nome);
                                break;
                            }
                        }
                    }

                    break;
                }
            }
        }

        private void LoadConfig()
        {
            if (File.Exists(this.DirDoc + "\\Config.json"))
            {
                string json = File.ReadAllText(this.DirDoc + "\\Config.json");
                this.Configs = JsonConvert.DeserializeObject<Configs>(json);
            }
        }

        private void SaveConfig()
        {
            string json = JsonConvert.SerializeObject(this.Configs);

            using (StreamWriter writer = new StreamWriter(this.DirDoc + "\\Config.json", false))
            {
                writer.WriteLine(json);
            }
        }
    }
}
