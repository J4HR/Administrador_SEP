using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Office.CustomUI;
using DocumentFormat.OpenXml.Presentation;
using DocumentFormat.OpenXml.Vml;
using DocumentFormat.OpenXml.Vml.Office;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CExcels
{
    public partial class Form1 : Form
    {

        private Lote lote = new Lote();
        private List<string> meses = new List<string>();
        private object[] years = { 2021, 2022, 2023, 2024, 2025, 2026 };
        private object[] quincenas ={
            "01 - enero","02 - enero",
            "03 - febrero","04 - febrero",
            "05 - marzo","06 - marzo",
            "07 - abril","08 - abril",
            "09 - mayo","10 - mayo",
            "11 - junio","12 - junio",
            "13 - julio","14 - julio",
            "15 - agosto","16 - agosto",
            "17 - septiembre","18 - septiembre",
            "19 - octubre","20 - octubre",
            "21 - noviembre","22 - noviembre",
            "23 - diciembre","24 - diciembre"};
        public Form1()
        {

            InitializeComponent();
            comboBoxMov.Items.AddRange(new object[]
            {
                "ALTA"
                ,"LICENCIA"
                ,"BAJA"
            });
            comboBoxMov.SelectedIndex = 1;
            block();
            comboBoxTip.Enabled = true;
        }
        private string getPath()
        {
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
                openFileDialog.Filter = "xlsx files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                }
            }

            //MessageBox.Show(filePath, "File Content at path: ", MessageBoxButtons.OK);
            return filePath;
        }
        private string getSave()
        {
            string filePath = string.Empty;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "All files (*.*)|*.*|xlsx files (*.xlsx)|*.xlsx";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = saveFileDialog1.FileName;
            }
            return filePath;
        }
        private void block()
        {
            comboBoxOP.Enabled = false;
            comboBoxTip.Enabled = false;
            textBox_rfc.Enabled = false;
            enableData(false);
            enableFech(false);
            enablePlaza(false);
        }
        private void enableFech(bool enable)
        {
            //enable = false;//parche
            comboBoxYear_Ini.Enabled = enable;
            comboBoxYear_Fin.Enabled = enable;
            comboBoxQ_Ini.Enabled = enable;
            comboBoxQ_Fin.Enabled = enable;
        }
        private void enableData(bool enable)
        {
            textBox_name.Enabled = enable;
            textBox_domicilio.Enabled = enable;
            textBox_nss.Enabled = enable;
            textBox_colonia.Enabled = enable;
            textBox_cp.Enabled = enable;
            textBox_curp.Enabled = enable;
            textBox_colonia.Enabled = enable;
            textBox_municipo.Enabled = enable;
            textBox_tel.Enabled = enable;
            textBoxSexo.Enabled = enable;
            textBoxEstado.Enabled = enable;
            textBox_Acaddemico.Enabled = enable;
        }
        private void enablePlaza(bool enable)
        {
            textBox_CAT.Enabled = enable;
            textBox_PDA.Enabled = enable;
            textBox_UN.Enabled = enable;
            textBox_SUB.Enabled = enable;
            textBox_HRS.Enabled = enable;
            textBox_PLAZA.Enabled = enable;
        }
        private void clearF()
        {
            comboBoxOP.Text = "Opcciones";
            comboBoxOP.Items.Clear();
            comboBoxTip.Text = "Tipo";
            comboBoxTip.Items.Clear();
            clearFech();
        }
        private void clearFech()
        {
            comboBoxYear_Ini.Text = "Año";
            comboBoxYear_Ini.Items.Clear();
            comboBoxYear_Fin.Text = "Año";
            comboBoxYear_Fin.Items.Clear();
            comboBoxQ_Ini.Text = "Quincena";
            comboBoxQ_Ini.Items.Clear();
            comboBoxQ_Fin.Text = "Quincena";
            comboBoxQ_Fin.Items.Clear();
        }
        private void clearData()
        {
            /*textBox_name.Text = "";
            textBox_domicilio.Text = "Calle,Numero";
            textBox_nss.Text = "";
            textBox_colonia.Text = "";
            textBox_cp.Text = "";
            textBox_curp.Text = "";
            textBox_municipo.Text = "";
            textBox_tel.Text = "";
            textBoxSexo.Text = "";
            textBoxEstado.Text = "";
            textBox_Acaddemico.Text = "";*/
        }
        private void loadData()
        {
            //lote.Movimiento.Docente.Nombre=textBox_name.Text ;
            lote.Movimiento.Docente.NSS=textBox_nss.Text;
            lote.Movimiento.Docente.Colonia=textBox_colonia.Text;
            lote.Movimiento.Docente.C_P=textBox_cp.Text;
            //lote.Movimiento.Docente.Curp=textBox_curp.Text;
            lote.Movimiento.Docente.Municipio=textBox_municipo.Text;
            lote.Movimiento.Docente.Tel=textBox_tel.Text;
            //lote.Movimiento.Docente.Sexo=textBoxSexo.Text;
            //lote.Movimiento.Docente.Estado= Int16.Parse(textBoxEstado.Text);
            lote.Movimiento.Docente.ClaveEstudios = textBox_Acaddemico.Text;
            if (textBox_domicilio.Text != "Calle,Numero")
            {
                lote.Movimiento.Docente.Domicilo = textBox_domicilio.Text;
            }
            else
            {
                lote.Movimiento.Docente.Domicilo = "";
            }
            

        }
        
        private void newIndexCB_Mov(object sender, EventArgs e)
        {
            clearF();
            block();
            switch (comboBoxMov.SelectedIndex)
            {
                case 0: 
                    {
                        comboBoxOP.Items.AddRange(new string[]
                        {
                            "01 - NUEVO INGRESO/REINGRESO",
                            "02 - PLAZA ADICIONAL"

                        });
                        comboBoxOP.Enabled = true;
                        enablePlaza(true);
                        break;
                    }
                case 1: 
                    {
                        
                        enableData(false);
                        enableFech(false);
                        comboBoxTip.Items.AddRange(new string[]
                        {
                            //"41 - LICENCIA POR ASUNTOS PARTICULARES",
                            //"42 - LICENCIA POR PASAR A OTRO EMPLEO",
                            "43 - LICENCIA SIN GOCE DE SUELDO",
                            //"44 - LICENCIA POR GRAVIDEZ",
                            //"48 - LICENCIA PREJUBILATORIA",
                            //"51 - PRORROGA DE LICENCIA POR ASUNTOS PARTICULARES",
                            //"52 - PRORROGA DE LICENCIA POR PASAR A OTRO EMPLEO",
                            "53 - PRORROGA DE LICENCIA SIN GOCE DE SUELDO"

                        });
                        comboBoxTip.Enabled = true;
                        
                        break;
                    }
                case 2:
                    {
                        comboBoxOP.Items.AddRange(new string[]
                        {
                            "06 - BAJA DE PERSONA",
                            "07 - BAJA DE PLAZA"

                        });
                        comboBoxOP.Enabled = true;
                        break;
                    }
            }
        }

        private void newIndexCB_OP(object sender, EventArgs e)
        {
            comboBoxTip.Text = "Tipo";
            comboBoxTip.Items.Clear();
            textBox_rfc.Enabled = false;
            enableData(false);
            switch (comboBoxMov.SelectedIndex)
            {
                case 0:
                    {
                        comboBoxTip.Items.AddRange(new object[]
                        {
                            "09 - ALTA INICIAL",
                            "10 - ALTA DEFINITIVA",
                            "20 - ALTA INTERINA LIMITADA",
                            "95 - ALTA PROVISIONAL INTERINA",
                            "24 - ALTA EN GRAVIDEZ",
                            "25 - ALTA EN LICENCIA PREPRENSIONARIA"
                        });
                        break;
                    }
                case 2:
                    {
                        comboBoxTip.Items.AddRange(new object[]
                        {
                            "31 - BAJA POR DEFUNCIÓN",
                            "32 - BAJA POR RENUNCIA",
                            "33 - BAJA POR JUBILACIÓN",
                            "35 - BAJA POR TERMINO DE NOMBRAMIENTO",
                            "37 - BAJA POR PASAR A OTRO EMPLEO",
                            "38 - BAJA POR INSUBSISTENCIA DE NOMBRAMIENTO"
                        });
                        break;
                    }
            }
            comboBoxTip.Enabled = true;
        }

        private void newIndexCB_Tip(object sender, EventArgs e)
        {
            clearFech();
            enableFech(comboBoxMov.SelectedIndex == 1 );
            enableData(comboBoxOP.SelectedIndex == 0 && comboBoxMov.SelectedIndex == 0);
            enablePlaza(comboBoxOP.SelectedIndex == 1 && comboBoxMov.SelectedIndex == 0);
            
            comboBoxYear_Ini.Items.AddRange(years);

            textBox_rfc.Enabled = true;
        }

        private void newIndexCB_Year(object sender, EventArgs e)
        {
            comboBoxYear_Fin.Text = "Año";
            comboBoxYear_Fin.Items.Clear();
            comboBoxQ_Ini.Text = "Quincena";
            comboBoxQ_Ini.Items.Clear();
            comboBoxQ_Fin.Text = "Quincena";
            comboBoxQ_Fin.Items.Clear();
            comboBoxQ_Ini.Items.AddRange(quincenas);
        }
        private void newIndexCB_Q(object sender, EventArgs e)
        {
            comboBoxYear_Fin.Text = "Año";
            comboBoxYear_Fin.Items.Clear();
            comboBoxQ_Fin.Text = "Quincena";
            comboBoxQ_Fin.Items.Clear();
            int selectYear = 2021 + comboBoxYear_Ini.SelectedIndex;
            for (int j = selectYear; j < selectYear + 6; j++)
            {
                comboBoxYear_Fin.Items.Add(j.ToString());
            }
        }
        private void newIndexCB_YearFin(object sender, EventArgs e)
        {
            comboBoxQ_Fin.Text = "Quincena";
            comboBoxQ_Fin.Items.Clear();
            comboBoxQ_Fin.Items.AddRange(quincenas);
            if (comboBoxYear_Ini.Text == comboBoxYear_Fin.Text)
            {
                for (int i = 0; i < comboBoxQ_Ini.SelectedIndex ; i++)
                {
                    comboBoxQ_Fin.Items.RemoveAt(0);
                }
            }

        }

        private void clickSaveLote(object sender, EventArgs e)
        {
            
            lote.guardarLote(getSave());
            //lote = new Lote();
            //dataGridView2.DataSource = lote.TableLote;
        }
        private void clickAbrirLote(object sender, EventArgs e)
        {

        }

        private void click_AddLote(object sender, EventArgs e)
        {
            if (dataGridViewPlazas.SelectedCells.Count.Equals(0)) return;
            loadData();
            int nRow = dataGridViewPlazas.SelectedCells[0].RowIndex;
            lote.Movimiento.ClaveMovPlaza =  dataGridViewPlazas.Rows[nRow].Cells[0].Value.ToString();
            if (MessageBox.Show("Clave: " + (lote.Movimiento.ClaveMovPlaza) + "\nMovimiento: " + comboBoxTip.Text, "Alerta!! Agregar al Lote ", MessageBoxButtons.OKCancel).Equals(DialogResult.Cancel))
            {
                return;
            }
            if (comboBoxOP.Text!= "Opcciones")
            {
                lote.Movimiento.Mov = Int16.Parse(comboBoxOP.Text.Split('-')[0], NumberStyles.AllowTrailingWhite);
            }
            else
            {
                lote.Movimiento.Mov = 11;
            }
            /*if (comboBoxMov.Text=="Alta" && comboBoxOP.SelectedIndex == 1)
            {
                string clave = textBox_PDA.Text;
                clave += textBox_UN.Text;
                clave += textBox_SUB.Text;
                clave += textBox_CAT.Text;
                clave += textBox_HRS.Text;
                clave += textBox_PLAZA.Text;
                string ctt=lote.getCtt(clave);

                //lote.Movimiento.Docente.ge
            }*/

            lote.Movimiento.Tipo = Int16.Parse(comboBoxTip.Text.Split('-')[0], NumberStyles.AllowTrailingWhite);
            lote.Movimiento.FechaIni=comboBoxYear_Ini.Text+comboBoxQ_Ini.Text.Split('-')[0];
            lote.Movimiento.FechaFin=comboBoxYear_Fin.Text+comboBoxQ_Fin.Text.Split('-')[0];
            lote.addMovimiento();
            dataGridView2.DataSource = lote.TableLote;

        }

        private void click_AddPlaza(object sender, EventArgs e)
        {
            string clave= textBox_PDA.Text;
            clave += textBox_UN.Text;
            clave += textBox_SUB.Text;
            clave += textBox_CAT.Text;
            clave += textBox_HRS.Text;
            clave += textBox_PLAZA.Text;
            textBox_PDA.Text = "";
            textBox_UN.Text = "";
            textBox_SUB.Text = "";
            textBox_CAT.Text = "";
            textBox_HRS.Text = "";
            textBox_PLAZA.Text = "";
            
            if (lote.getCtt(clave)!=null)
            {
                lote.Movimiento.Docente.addPlazaClave(clave);
            }
            else
            {
                MessageBox.Show("La clave no existe :/ ","Error !Clave no encontrada ", MessageBoxButtons.OK);
            }
            dataGridViewPlazas.DataSource = lote.Movimiento.Docente.getTablePlazas();
        }

        private void keyDownRFC(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                if (lote.buscarDocente(textBox_rfc.Text))
                {
                    textBox_curp.Text = lote.Movimiento.Docente.Curp;
                    textBox_name.Text = lote.Movimiento.Docente.Nombre;
                    textBoxSexo.Text = lote.Movimiento.Docente.Sexo;
                    textBoxEstado.Text = lote.Movimiento.Docente.Estado.ToString();

                    
                }
                else
                {
                    clearData();
                }
                dataGridViewPlazas.DataSource = lote.Movimiento.Docente.getTablePlazas();
                enableData(true);

            }
        }

        private void clickPestLote(object sender, EventArgs e)
        {
            dataGridView2.DataSource = lote.TableLote;
        }

        
    }
}
/*control numerico plazas !! los antivirus lo confunden con un keyloger 
        private void keyPressPDA(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void keyPressUN(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void keyPressSUB(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void keyPressHRS(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void keyPressPLAZA(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //control numerico plazas*/
