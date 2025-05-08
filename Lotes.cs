using System;
using System.Collections.Generic;
using SpreadsheetLight;
using System.Data;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Xml.Linq;
using System.Drawing;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Vml.Office;
using DocumentFormat.OpenXml.Vml;

namespace CExcels
{
    internal class CTT
    {
        private string ctt;
        private string entFed="";
        private string ctClasif="";
        private string ctID="";
        private string ctSecuencial="";
        private string ctDigitoVer="";
        public string Ctt
        {
            get { return ctt; }
            set 
            {
                ctt = "          ";
                try 
                { 
                    ctt = value.ToUpper();
                } catch { }
                int pos = 0;
                while (pos < 2)
                { 
                    entFed += ctt[pos];
                    pos++;
                }
                ctClasif = "";
                while (pos < 3)
                {
                    ctClasif += ctt[pos];
                    pos++;
                }
                while (pos < 5)
                {
                    ctID += ctt[pos];
                    pos++;
                }
                while (pos < 9)
                {
                    ctSecuencial += ctt[pos];
                    pos++;
                }
                while (pos < 10)
                {
                    ctDigitoVer += ctt[pos];
                    pos++;
                }
            }
        }
        public string EntFed
        {
            get { return entFed; }
        }
        public string CTClasif
        {
            get { return ctClasif; }
        }
        public string CTID
        {
            get { return ctID; }
        }
        public string CTSecuencial
        {
            get { return ctSecuencial; }
        }
        public string CTDigitoVer
        {
            get { return ctDigitoVer; }
        }
    }
    internal class Plaza : CTT,IEquatable<Plaza>
    {
        private string clave;
        private string constPlaza="";
        private string horas="";
        private string catPuesto="";
        private string subUnidad="";
        private string unidad="";
        private string codPago="";
        public string Clave
        {
            get { return clave; }
            set 
            {
                clave = value.ToUpper();
                int pos = 0;
                int esp = value.Length - 19;
                
                while (pos < 2 )
                {
                    codPago+=clave[pos];
                    pos++;
                }
                while (pos < 4 )
                {
                    unidad += clave[pos];
                    pos++;
                }
                while (pos < 6 )
                {
                    subUnidad += clave[pos];
                    pos++;
                }
                while (pos < 10 + esp)
                {
                    catPuesto += clave[pos];
                    pos++;
                }
                catPuesto = "  " + catPuesto;
                while (pos < 12 + esp)
                {
                    horas += clave[pos];
                    pos++;
                }
                pos++;
                while (pos < 19 + esp)
                {
                    constPlaza += clave[pos];
                    pos++;
                }
            }
        }
        public string ConstPlaza
        {
            set { constPlaza = value.ToUpper();}
            get { return constPlaza; }
        }
        public string Horas
        {
            set { horas = value.ToUpper();}
            get { return horas; }
        }
        public string CatPuesto
        {
            set { catPuesto = value.ToUpper();}
            get { return catPuesto; }
        }
        public string SubUnidad
        {
            set { subUnidad = value.ToUpper();}
            get { return subUnidad; }
        }
        public string Unidad
        {
            set { unidad = value.ToUpper();}
            get { return unidad; }
        }
        public string CodPago
        {
            set { codPago = value.ToUpper();}
            get { return codPago; }
        }
        public bool Equals(Plaza other)
        {
            if (this.Clave == other.Clave)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    internal class DocenteData 
    {
        private string rfc;
        private int arch_pos;
        private const int ESTADO_CIVIL = 1;
        private int estado;
        private string sexo;
        private string curp;
        private string nombre;
        private string domicilo;
        private string colonia;
        private string municipio;
        private string cp;
        private string tel;
        private string nss;
        private string claveEstudios;
        private List<Plaza> plazas= new List<Plaza>();

        public string RFC
        {
            get { return rfc; }
            set { rfc = value.ToUpper(); }
        }
        public int Arch_pos
        {
            get { return arch_pos; }
            set { arch_pos = value; }
        }
        public int Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        public string Sexo
        {
            get { return sexo; }
            set { sexo = value.ToUpper(); }
        }
        public string Curp
        {
            get { return curp; }
            set { curp = value.ToUpper(); }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value.ToUpper(); }
        }
        public string Domicilo
        {
            get { return domicilo; }
            set { domicilo = value.ToUpper(); }
        }
        public string Colonia
        {
            get { return colonia; }
            set { colonia = value.ToUpper(); }
        }
        public string Municipio
        {
            get { return municipio; }
            set { municipio = value.ToUpper(); }
        }
        public string C_P
        {
            get { return cp; }
            set { cp = value.ToUpper(); }
        }
        public string Tel
        {
            get { return tel; }
            set { tel = value.ToUpper(); }
        }
        public string NSS
        {
            get { return nss; }
            set { nss = value.ToUpper(); }
        }
        public string ClaveEstudios
        {
            get { return claveEstudios; }
            set { claveEstudios = value.ToUpper(); }
        }
        public void addPlaza(string clave,string ctt)
        {
            Plaza newPlaza = new Plaza();
            newPlaza.Clave = clave;
            newPlaza.Ctt= ctt;
            plazas.Add(newPlaza);
        }
        public void addPlazaClave(string clave)
        {
            Plaza newPlaza = new Plaza();
            newPlaza.Clave = clave;
            plazas.Add(newPlaza);
        }
        public void rmPlaza(int pos)
        {
            plazas.RemoveAt(pos);
        }
        public Plaza getPlaza(string clave)
        {
            return plazas.Find(plaza => plaza.Clave == clave);
        }

        public bool onPlaza(string clave)
        {
            Plaza temPlaza = new Plaza();
            temPlaza.Clave = clave;
            return plazas.Contains(temPlaza);
        }
        public DataTable getTablePlazas()
        {
            DataTable tablePlazas = new DataTable();
            tablePlazas.Columns.Add("CLAVE", typeof(string));
            tablePlazas.Columns.Add("CCT", typeof(string));
            for(int pos=0;pos < plazas.Count();pos++)
            {
                tablePlazas.Rows.Add(plazas[pos].Clave, plazas[pos].Ctt);
            }
            return tablePlazas;
        }
        public void clearPlazas()
        {
            plazas.RemoveRange(0, plazas.Count());
        }
        public int getEstadoCivil()
        {
            return ESTADO_CIVIL;
        }
    }
    internal class Movimiento
    {
        
        private int movimiento;
        private int opccion;
        private int tipo;
        private DocenteData docente=new DocenteData();
        private string claveMovPlaza;
        private string fechaIni;
        private string fechaFin;
        
        public int Mov
        {
            get { return movimiento; }
            set { movimiento = value; }
        }
        public int Opccion
        {
            get { return opccion; }
            set { opccion = value; }
        }
        public int Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public DocenteData Docente
        {
            get { return docente; }
        }
        public Plaza Plaza
        {
            get { return docente.getPlaza(claveMovPlaza); }
        }
        public string ClaveMovPlaza
        {
            get { return claveMovPlaza; }
            set { claveMovPlaza = value; }
        }
        public string FechaIni
        {
            get { return fechaIni; }
            set { fechaIni = value; }
        }
        public string FechaFin
        {
            get { return fechaFin; }
            set { fechaFin = value; }
        }
        public bool fechasValidas(DateTime fechaIni, DateTime fechaFin, int nLic)
        {
            bool fechasVal = false;
            switch (nLic) {
                case 1:
                    {//41
                        fechasVal = fechaFin <= fechaIni.AddMonths(6);
                        break;
                    }
                case 3:
                    {//43
                        DateTime quinsena24 = new DateTime(fechaIni.AddYears(1).Year, 1, 1, 0, 0, 0);
                        fechasVal = fechaIni < quinsena24;
                        break;
                    }
                case 4:
                    {//44
                        fechasVal = fechaFin == fechaIni.AddMonths(3) || fechaFin == fechaIni.AddMonths(6); 
                        break;
                    }
                case 5:
                    {//48
                        fechasVal = fechaFin == fechaIni.AddMonths(3) || fechaFin == fechaIni.AddMonths(6);
                        break;
                    }
                default:
                    {
                        fechasVal = true;
                        break;
                    }
            }
            return fechasVal;
        }
        
        public bool setFecha(string fechaIni, string fechaFin)
        {
            this.fechaFin = fechaFin;
            this.fechaIni = fechaIni;
            /*if (fechasValidas(fechaIni, fechaFin, nLic))
            {
                this.fechaFin = fechaFin;
                this.fechaIni = fechaIni;
                return true;
            }
            else
            {
                return false;
            }*/
            return true;
        }
    }
    internal class Lote 
    {
        private string nameLote;
        private string tipoLote;
        private string rutaLote;
        private SLDocument oSLexcels = new SLDocument();
        private DataTable tableMovs = new DataTable();
        private Movimiento tempMov = new Movimiento();
        private List<Movimiento> movimientos= new List<Movimiento>();
        

        public Lote()
        {
            tableMovs.Columns.Add("TIPO DE NOMBRAMIENTO",typeof(int));
            tableMovs.Columns.Add("MOT. MOV.", typeof(int));
            //tableMovs.Columns.Add("Opccion", typeof(int));
            tableMovs.Columns.Add("NOMBRE COMPLETO (PATERNO, MATERNO, NOMBRES)");
            tableMovs.Columns.Add("SEXO", typeof(string));
            tableMovs.Columns.Add("ESTADO CIVIL", typeof(int));
            tableMovs.Columns.Add("ESTADO DE NACIMIENTO", typeof(int));
            tableMovs.Columns.Add("NIVEL ACADEMICO", typeof(string));
            tableMovs.Columns.Add("DOMICILIO EMPLEADO (CALLE Y NUMERO)", typeof(string));
            tableMovs.Columns.Add("DOMICILIO EMPLEADO (COLONIA)",typeof(string));
            tableMovs.Columns.Add("DOMICILIO EMPLEADO POBLACION", typeof(string));
            tableMovs.Columns.Add("C. P. EMPLEADO", typeof(string));
            tableMovs.Columns.Add("RFC.", typeof(string));
            tableMovs.Columns.Add("CURP", typeof(string));
            tableMovs.Columns.Add("ENT_FED", typeof(string));
            tableMovs.Columns.Add("CT_CLASIF", typeof(string));
            tableMovs.Columns.Add("CT_ID", typeof(string));
            tableMovs.Columns.Add("CT_SECUENCIAL", typeof(string));
            tableMovs.Columns.Add("CT_DIGITO_VER", typeof(string));
            tableMovs.Columns.Add("COD_PAGO", typeof(string));
            tableMovs.Columns.Add("UNIDAD", typeof(string));
            tableMovs.Columns.Add("SUBUNIDAD", typeof(string));
            tableMovs.Columns.Add("CAT_PUESTO", typeof(string));
            tableMovs.Columns.Add("HORAS", typeof(string));
            tableMovs.Columns.Add("CONS_PLAZA", typeof(string));
            tableMovs.Columns.Add("FECHA INICIAL", typeof(string));
            tableMovs.Columns.Add("FECHA FINAL", typeof(string));
            tableMovs.Columns.Add("CLAVE", typeof(string));
            tableMovs.Columns.Add("CCT", typeof(string));
        }
        public string NameLote
        {
            get { return nameLote; }
            set { nameLote = value.ToUpper(); }
        }
        public string TipoLote
        {
            get { return tipoLote; }
            set { tipoLote = value.ToUpper(); }
        }
        public string RutaLote
        {
            get { return rutaLote; }
            set { rutaLote = value.ToUpper(); }
        }
        public Movimiento Movimiento
        {
            get { return tempMov; }
        }
        public DataTable TableLote
        {
            get{ return tableMovs; }
            /*set { tableMovs = value; }*/
        }

        public void addMovimiento()
        {
            movimientos.Add(tempMov);
            tableMovs.Rows.Add(
                tempMov.Mov,
                tempMov.Tipo,
                /*mov.Opccion,*/
                tempMov.Docente.Nombre,
                tempMov.Docente.Sexo,
                tempMov.Docente.getEstadoCivil(),
                tempMov.Docente.Estado,
                tempMov.Docente.ClaveEstudios,
                tempMov.Docente.Domicilo,
                tempMov.Docente.Colonia,
                tempMov.Docente.Municipio,
                tempMov.Docente.C_P,
                tempMov.Docente.RFC,
                tempMov.Docente.Curp,
                tempMov.Plaza.EntFed,
                tempMov.Plaza.CTClasif,
                tempMov.Plaza.CTID,
                tempMov.Plaza.CTSecuencial,
                tempMov.Plaza.CTDigitoVer,
                tempMov.Plaza.CodPago,
                tempMov.Plaza.Unidad,
                tempMov.Plaza.SubUnidad,
                tempMov.Plaza.CatPuesto,
                tempMov.Plaza.Horas,
                tempMov.Plaza.ConstPlaza,
                tempMov.FechaIni,
                tempMov.FechaFin,
                tempMov.Plaza.Clave,
                tempMov.Plaza.Ctt
                );
        }
        public void rmMovimiento(int pos)
        {
            movimientos.RemoveAt(pos);
            tableMovs.Rows.RemoveAt(pos);

        }
        public void cargarLote(string ruta, string name, string tipo)
        {
            Movimiento tempMov;
            if (rutaLote == null)
            {
                if (ruta.Length == 0)
                {
                    nameLote = name;
                    tipoLote = tipo;
                    rutaLote = AppDomain.CurrentDomain.BaseDirectory;
                }
                else
                {
                    nameLote = name;
                    tipoLote = tipo;
                    rutaLote = ruta;
                }
                int renglon = 1;
                
                SLDocument tempOSLexcels = new SLDocument(rutaLote + nameLote + tipoLote);
                while(!string.IsNullOrEmpty(tempOSLexcels.GetCellValueAsString(renglon,1))) {
                    tempMov = new Movimiento();
                    tempMov.Mov=tempOSLexcels.GetCellValueAsInt32(renglon,1);
                    tempMov.Tipo=tempOSLexcels.GetCellValueAsInt32(renglon,2);
                    //tempMov.Opccion=tempOSLexcels.GetCellValueAsString(reglon,);
                    tempMov.Docente.Nombre=tempOSLexcels.GetCellValueAsString(renglon,3);
                    tempMov.Docente.Sexo=tempOSLexcels.GetCellValueAsString(renglon,4);
                    tempMov.Docente.Estado=tempOSLexcels.GetCellValueAsInt32(renglon,6);
                    tempMov.Docente.ClaveEstudios=tempOSLexcels.GetCellValueAsString(renglon,7);
                    tempMov.Docente.Domicilo=tempOSLexcels.GetCellValueAsString(renglon,8);
                    tempMov.Docente.Colonia=tempOSLexcels.GetCellValueAsString(renglon,9);
                    tempMov.Docente.Municipio=tempOSLexcels.GetCellValueAsString(renglon,10);
                    tempMov.Docente.C_P=tempOSLexcels.GetCellValueAsString(renglon,11);
                    tempMov.Docente.RFC=tempOSLexcels.GetCellValueAsString(renglon,12);
                    tempMov.Docente.Curp=tempOSLexcels.GetCellValueAsString(renglon,13);
                    tempMov.FechaIni=tempOSLexcels.GetCellValueAsString(renglon,25);
                    tempMov.FechaFin=tempOSLexcels.GetCellValueAsString(renglon,26);
                    tempMov.Plaza.Clave=tempOSLexcels.GetCellValueAsString(renglon,27);
                    tempMov.Plaza.Ctt= tempOSLexcels.GetCellValueAsString(renglon,28);
                    renglon++;
                    
                }
                tempOSLexcels.CloseWithoutSaving();
            }

        }
        
        public void guardarLote(string ruta)
        {
            try 
            {
                oSLexcels.ImportDataTable(1, 1, tableMovs, true);
                oSLexcels.SaveAs(ruta);
            }
            catch { }
        }
        public bool buscarDocente(string rfc)
        {
            String line;
            List<String> elements = new List<string>();
            bool encontrado = false;
            try
            {
                StreamReader archivoDocentes = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "docentesText.csv");
                do
                {
                    line = archivoDocentes.ReadLine();
                    if (line != null) elements = line.Split(',').ToList();
                    encontrado = elements[1] == rfc;

                } while (line != null && !encontrado);
            }
            finally {
                tempMov.Docente.clearPlazas();
                if (encontrado)
                {
                    tempMov.Docente.Curp = elements[0];
                    tempMov.Docente.Nombre = elements[2];
                    tempMov.Docente.RFC = elements[1];
                    tempMov.Docente.Sexo = elements[3];
                    try { tempMov.Docente.Estado = Int16.Parse(elements[4]); }
                    catch { }
                    buscarPlaza(elements[1]);
                }
                
            }
            return encontrado;
        }
        public void buscarPlaza(string rfc)
        {
            String line ;
            List<String> elements = new List<string>();
            try
            {
                StreamReader archivoPlazas = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "MDPtextC.csv");

                do
                {
                    line = archivoPlazas.ReadLine();
                    if (line != null) elements = line.Split(',').ToList();
                    if (elements[1] == rfc && !tempMov.Docente.onPlaza(elements[0])) 
                    {
                        //MessageBox.Show(tempMov.Docente.onPlaza(elements[0]).ToString(), elements[1] + "==" + rfc + ":" + elements[0], MessageBoxButtons.OK);
                        tempMov.Docente.addPlaza(elements[0], getCtt(elements[0]));
                    }
                } while (line != null);
            }
            finally {}
        }
        public string getCtt(string clave)
        {
            String line;
            List<String> elements = new List<string>();
            bool encontrado = false;
            try
            {
                StreamReader archivoDocentes = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "analitico.csv");
                do
                {
                    line = archivoDocentes.ReadLine();
                    if (line != null) elements = line.Split(',').ToList();
                    else elements[1] =null;
                    encontrado = elements[0] == clave;

                } while (line != null && !encontrado);

            }
            finally {}
            return elements[1];
        }
    }
    
}
