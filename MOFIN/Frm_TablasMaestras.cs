using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MofinNegocios;
using MofinModelo;
using MofinModeloEntorno;

namespace MOFIN
{
    public partial class Frm_TablasMaestras : MetroForm
    {
        bool vl_EsNuevo = true;
        string vl_RegEliminar = "";

        M_ActivComercial t_TablasMaestras = new M_ActivComercial();
        M_ActivComercial t_TablaMaestra0 = new M_ActivComercial();
        M_Antiguedad t_TablaMaestra1 = new M_Antiguedad();
        M_Criptomonedas t_TablaMaestra2 = new M_Criptomonedas();
        M_Edad t_TablaMaestra3 = new M_Edad();
        M_Estados t_TablaMaestra4 = new M_Estados();
        M_NivelRiesgo t_TablaMaestra5 = new M_NivelRiesgo();
        M_Pais t_TablaMaestra6 = new M_Pais();
        M_PEP t_TablaMaestra7 = new M_PEP();
        M_Productos t_TablaMaestra8 = new M_Productos();
        M_Profesiones t_TablaMaestra9 = new M_Profesiones();
        M_Servicios t_TablaMaestra10 = new M_Servicios();
        M_TipoDocID t_TablaMaestra11 = new M_TipoDocID();
        M_TipoEstructuraEmpresa t_TablaMaestra12 = new M_TipoEstructuraEmpresa();
        M_TipoPersJuridica t_TablaMaestra13 = new M_TipoPersJuridica();
        M_VolOperPersNat t_TablaMaestra14 = new M_VolOperPersNat();
        M_VolOperPersJur t_TablaMaestra15 = new M_VolOperPersJur();



        public Frm_TablasMaestras()
        {
            InitializeComponent();
        }
               
        private void Frm_TablasMaestras_Load(object sender, EventArgs e)
        {
            BS_MActivComercial.DataSource = NM_ActivComercial.Listar();
            BS_MAntiguedad.DataSource = NM_Antiguedad.Listar();
            BS_MCriptomonedas.DataSource = NM_Criptomonedas.Listar();
            BS_MEdad.DataSource = NM_Edad.Listar();
            BS_MEstados.DataSource = NM_Estados.Listar();
            BS_MNivelRiesgo.DataSource = NM_NivelRiesgo.Listar();
            BS_MPais.DataSource = NM_Pais.Listar();
            BS_MPEP.DataSource = NM_PEP.Listar();
            BS_MProductos.DataSource = NM_Productos.Listar();
            BS_MProfesiones.DataSource = NM_Profesiones.Listar();
            BS_MServicios.DataSource = NM_Servicios.Listar();
            BS_MTipoDocID.DataSource = NM_TipoDocID.Listar();
            BS_MTipoEstructuraEmpresa.DataSource = NM_TipoEstructuraEmpresa.Listar();
            BS_MTipoPersJuridica.DataSource = NM_TipoPersJuridica.Listar();
            BS_MVolOperPersNat.DataSource = NM_VolOperPersNat.Listar();
            BS_MVolOperPersJur.DataSource = NM_VolOperPersJur.Listar();

            Cmb_TablaMaestra.SelectedIndex = 0;
            this.Modo_Consulta();
            this.Grd_Detalles.Focus();

            
        }

        //**************
        // Eventos del formulario
        //**************

        private void Grd_Detalles_CurrentCellChanged(object sender, EventArgs e)
        {
            if (BS_TablaMaestra.Position > 0)
            {
                switch (Cmb_TablaMaestra.SelectedIndex)
                {
                    case 0:  // "Actividad Comercial"
                        BS_MActivComercial.Position = BS_TablaMaestra.Position;
                        t_TablaMaestra0 = BS_MActivComercial.Current as M_ActivComercial;
                        if (t_TablaMaestra0.Descripcion != null)
                            vl_RegEliminar = t_TablaMaestra0.Descripcion.Trim();
                        break;
                    case 1:  // "Antigüedad"
                        BS_MAntiguedad.Position = BS_TablaMaestra.Position;
                        t_TablaMaestra1 = BS_MAntiguedad.Current as M_Antiguedad;
                        if (t_TablaMaestra1.Descripcion != null)
                            vl_RegEliminar = t_TablaMaestra1.Descripcion.Trim();
                        break;
                    case 2:  // "Criptomonedas"
                        BS_MCriptomonedas.Position = BS_TablaMaestra.Position;
                        t_TablaMaestra2 = BS_MCriptomonedas.Current as M_Criptomonedas;
                        if (t_TablaMaestra2.Descripcion != null)
                            vl_RegEliminar = t_TablaMaestra2.Descripcion.Trim();
                        break;
                    case 3:  // "Edad"
                        BS_MEdad.Position = BS_TablaMaestra.Position;
                        t_TablaMaestra3 = BS_MEdad.Current as M_Edad;
                        if (t_TablaMaestra3.Descripcion != null)
                            vl_RegEliminar = t_TablaMaestra3.Descripcion.Trim();
                        break;
                    case 4:  // "Estados"
                        BS_MEstados.Position = BS_TablaMaestra.Position;
                        t_TablaMaestra4 = BS_MEstados.Current as M_Estados;
                        if (t_TablaMaestra4.Descripcion != null)
                            vl_RegEliminar = t_TablaMaestra4.Descripcion.Trim();
                        break;
                    case 5: // Nivel de Riesgo
                        BS_MNivelRiesgo.Position = BS_TablaMaestra.Position;
                        t_TablaMaestra5 = BS_MNivelRiesgo.Current as M_NivelRiesgo;
                        if (t_TablaMaestra5.Descripcion != null)
                            vl_RegEliminar = t_TablaMaestra5.Descripcion.Trim();
                        break;
                    case 6:  // "Pais"
                        BS_MPais.Position = BS_TablaMaestra.Position;
                        t_TablaMaestra6 = BS_MPais.Current as M_Pais;
                        if (t_TablaMaestra6.Descripcion != null)
                            vl_RegEliminar = t_TablaMaestra6.Descripcion.Trim();
                        break;
                    case 7:  // "P.E.P."
                        BS_MPEP.Position = BS_TablaMaestra.Position;
                        t_TablaMaestra7 = BS_MPEP.Current as M_PEP;
                        if (t_TablaMaestra7.Descripcion != null)
                            vl_RegEliminar = t_TablaMaestra7.Descripcion.Trim();
                        break;
                    case 8:  // "Productos"
                        BS_MProductos.Position = BS_TablaMaestra.Position;
                        t_TablaMaestra8 = BS_MProductos.Current as M_Productos;
                        if (t_TablaMaestra8.Descripcion != null)
                            vl_RegEliminar = t_TablaMaestra8.Descripcion.Trim();
                        break;
                    case 9:  // "Profesión"
                        BS_MProfesiones.Position = BS_TablaMaestra.Position;
                        t_TablaMaestra9 = BS_MProfesiones.Current as M_Profesiones;
                        if (t_TablaMaestra9.Descripcion != null)
                            vl_RegEliminar = t_TablaMaestra9.Descripcion.Trim();
                        break;
                    case 10:  // "Servicios"
                        BS_MServicios.Position = BS_TablaMaestra.Position;
                        t_TablaMaestra10 = BS_MServicios.Current as M_Servicios;
                        if (t_TablaMaestra10.Descripcion != null)
                            vl_RegEliminar = t_TablaMaestra10.Descripcion.Trim();
                        break;
                    case 11:  // "Tipo de Documento Identidad"
                        BS_MTipoDocID.Position = BS_TablaMaestra.Position;
                        t_TablaMaestra11 = BS_MTipoDocID.Current as M_TipoDocID;
                        if (t_TablaMaestra11.Descripcion != null)
                            vl_RegEliminar = t_TablaMaestra11.Descripcion.Trim();
                        break;
                    case 12:  // "Tipo de Estructura"
                        BS_MTipoEstructuraEmpresa.Position = BS_TablaMaestra.Position;
                        t_TablaMaestra12 = BS_MTipoEstructuraEmpresa.Current as M_TipoEstructuraEmpresa;
                        if (t_TablaMaestra12.Descripcion != null)
                            vl_RegEliminar = t_TablaMaestra12.Descripcion.Trim();
                        break;
                    case 13:  // "Tipo de Persona Jurídica"
                        BS_MTipoPersJuridica.Position = BS_TablaMaestra.Position;
                        t_TablaMaestra13 = BS_MTipoPersJuridica.Current as M_TipoPersJuridica;
                        if (t_TablaMaestra13.Descripcion != null)
                            vl_RegEliminar = t_TablaMaestra13.Descripcion.Trim();
                        break;
                    case 14:  // "Vol. Oper. Pers. Natural"
                        BS_MVolOperPersNat.Position = BS_TablaMaestra.Position;
                        t_TablaMaestra14 = BS_MVolOperPersNat.Current as M_VolOperPersNat;
                        if (t_TablaMaestra14.Descripcion != null)
                            vl_RegEliminar = t_TablaMaestra14.Descripcion.Trim();
                        break;
                    case 15:  // "Vol. Oper. Pers. Jurídica"
                        BS_MVolOperPersJur.Position = BS_TablaMaestra.Position;
                        t_TablaMaestra15 = BS_MVolOperPersJur.Current as M_VolOperPersJur;
                        if (t_TablaMaestra15.Descripcion != null)
                            vl_RegEliminar = t_TablaMaestra15.Descripcion.Trim();
                        break;
                }
            }
            TSB_ActualizaBotonesNavegacion();
        }

        private void Modo_Consulta()
        {
            this.Pan_Elementos.Enabled = false;
            this.TS_BarraHerramientas.Enabled = true;
            this.Cmb_TablaMaestra.Enabled = true;
            this.Grd_Detalles.Enabled = true;

            this.Btn_Aceptar.Visible = false;
            this.Btn_Cancelar.Visible = false;
            
            TSB_ActualizaBotonesNavegacion();
        }

        private void Modo_Edicion()
        {
            this.Txt_Codigo.Enabled = vl_EsNuevo;
            this.Pan_Elementos.Enabled = true;

            this.TS_BarraHerramientas.Enabled = false;
            this.Cmb_TablaMaestra.Enabled = false;
            this.Grd_Detalles.Enabled = false;

            this.Btn_Aceptar.Visible = true;
            this.Btn_Cancelar.Visible = true;
            if (vl_EsNuevo == true)
                this.Txt_Codigo.Focus();
            else
                this.Txt_Nombre.Focus();
        }
        private void Cmb_TablaMaestra_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Txt_CodAlfa2.DataBindings.Clear();
            this.Txt_CodAlfa3.DataBindings.Clear();

            this.Cmb_Pais.Visible = false;
            this.Txt_CodAlfa2.Visible = false;
            this.Txt_CodAlfa3.Visible = false;

            this.Lbl_Pais.Visible = false;
            this.Lbl_CodAlfa2.Visible = false;
            this.Lbl_CodAlfa3.Visible = false;

            switch (Cmb_TablaMaestra.SelectedIndex)
            {
                case 0:  // "Actividad Comercial"
                    BS_TablaMaestra.DataSource = BS_MActivComercial;
                    break;
                case 1:  // "Antigüedad"
                    BS_TablaMaestra.DataSource = BS_MAntiguedad;
                    break;
                case 2:  // "Criptomonedas"
                    BS_TablaMaestra.DataSource = BS_MCriptomonedas;
                    break;
                case 3:  // "Edad"
                    BS_TablaMaestra.DataSource = BS_MEdad;
                    break;
                case 4:  // "Estados"
                    BS_TablaMaestra.DataSource = BS_MEstados;
                    this.Lbl_Pais.Visible = true;
                    this.Cmb_Pais.Visible = true;
                    break;
                case 5: // Nivel de Riesgo
                    BS_TablaMaestra.DataSource = BS_MNivelRiesgo;
                    break;
                case 6:  // "Pais"
                    BS_TablaMaestra.DataSource = BS_MPais;
                    this.Lbl_CodAlfa2.Visible = true;
                    this.Lbl_CodAlfa3.Visible = true;
                    this.Txt_CodAlfa2.Visible = true;
                    this.Txt_CodAlfa3.Visible = true;
                    break;
                case 7:  // "P.E.P."
                    BS_TablaMaestra.DataSource = BS_MPEP;
                    break;
                case 8:  // "Productos"
                    BS_TablaMaestra.DataSource = BS_MProductos;
                    break;
                case 9:  // "Profesión"
                    BS_TablaMaestra.DataSource = BS_MProfesiones;
                    break;
                case 10:  // "Servicios"
                    BS_TablaMaestra.DataSource = BS_MServicios;
                    break;
                case 11:  // "Tipo de Documento Identidad"
                    BS_TablaMaestra.DataSource = BS_MTipoDocID;
                    break;
                case 12:  // "Tipo de Estructura"
                    BS_TablaMaestra.DataSource = BS_MTipoEstructuraEmpresa;
                    break;
                case 13:  // "Tipo de Persona Jurídica"
                    BS_TablaMaestra.DataSource = BS_MTipoPersJuridica;
                    break;
                case 14:  // "Vol. Oper. Pers. Natural"
                    BS_TablaMaestra.DataSource = BS_MVolOperPersNat;
                    break;
                case 15:  // "Vol. Oper. Pers. Jurídica"
                    BS_TablaMaestra.DataSource = BS_MVolOperPersJur;
                    break;
            }
            
            // Cambio del origen de los controles
            //this.Txt_Codigo.DataBindings.Clear();
            //this.Txt_Nombre.DataBindings.Clear();
            //this.NUD_Valor.DataBindings.Clear();
            //this.Chk_CES.DataBindings.Clear();

            //this.Txt_Codigo.DataBindings.Add("Text", BS_TablaMaestra, "Codigo");
            //this.Txt_Nombre.DataBindings.Add("Text", BS_TablaMaestra, "Descripcion");
            //this.NUD_Valor.DataBindings.Add("Value", BS_TablaMaestra, "Valor");
            //this.Chk_CES.DataBindings.Add("CheckState", BS_TablaMaestra, "CondEspSeguridad");
            

            Grd_Detalles.DataSource = BS_TablaMaestra;
            TSB_ActualizaBotonesNavegacion();
            Grd_Detalles.Refresh();
            

        }

        //************
        // Comportamiento de Los Botones 
        //************
        private void TSB_ActualizaBotonesNavegacion()
        {
            if (BS_TablaMaestra.Count < 1)
            {
                this.TSB_Primero.Enabled = false;
                this.TSB_Anterior.Enabled = false;
                this.TSB_Siguiente.Enabled = false;
                this.TSB_Ultimo.Enabled = false;
                this.TSB_Modificar.Enabled = false;
                this.TSB_Eliminar.Enabled = false;
                this.TSB_Imprimir.Enabled = false;
            }
            else
            {
                this.TSB_Primero.Enabled = (BS_TablaMaestra.Position == 0) ? false : true;
                this.TSB_Anterior.Enabled = (BS_TablaMaestra.Position == 0) ? false : true;
                this.TSB_Siguiente.Enabled = (BS_TablaMaestra.Position == BS_TablaMaestra.Count - 1) ? false : true;
                this.TSB_Ultimo.Enabled = (BS_TablaMaestra.Position == BS_TablaMaestra.Count - 1) ? false : true;
                this.TSB_Modificar.Enabled = true;
                this.TSB_Eliminar.Enabled = true;
                this.TSB_Imprimir.Enabled = true;
            }
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            switch (Cmb_TablaMaestra.SelectedIndex)
            {
                case 0:  // "Actividad Comercial"
                    t_TablaMaestra0.Codigo = short.Parse(Txt_Codigo.Text);
                    t_TablaMaestra0.Descripcion = this.Txt_Nombre.Text.Trim();
                    t_TablaMaestra0.Valor = byte.Parse(this.NUD_Valor.Value.ToString());
                    t_TablaMaestra0.CondEspSeguridad = this.Chk_CES.Checked;
                    if (vl_EsNuevo)
                        NM_ActivComercial.Insertar(t_TablaMaestra0);
                    else
                        NM_ActivComercial.Actualizar(t_TablaMaestra0);
                    BS_MActivComercial.DataSource = NM_ActivComercial.Listar();
                    break;
                case 1:  // "Antigüedad"
                    t_TablaMaestra1.Codigo = short.Parse(Txt_Codigo.Text);
                    t_TablaMaestra1.Descripcion = this.Txt_Nombre.Text.Trim();
                    t_TablaMaestra1.Valor = byte.Parse(this.NUD_Valor.Value.ToString());
                    t_TablaMaestra1.CondEspSeguridad = this.Chk_CES.Checked;
                    if (vl_EsNuevo)
                        NM_Antiguedad.Insertar(t_TablaMaestra1);
                    else
                        NM_Antiguedad.Actualizar(t_TablaMaestra1);
                    BS_MAntiguedad.DataSource = NM_Antiguedad.Listar();
                    break;
                case 2:  // "Criptomonedas"
                    t_TablaMaestra2.Codigo = short.Parse(Txt_Codigo.Text);
                    t_TablaMaestra2.Descripcion = this.Txt_Nombre.Text.Trim();
                    t_TablaMaestra2.Valor = byte.Parse(this.NUD_Valor.Value.ToString());
                    t_TablaMaestra2.CondEspSeguridad = this.Chk_CES.Checked;
                    if (vl_EsNuevo)
                        NM_Criptomonedas.Insertar(t_TablaMaestra2);
                    else
                        NM_Criptomonedas.Actualizar(t_TablaMaestra2);
                    BS_MCriptomonedas.DataSource = NM_Criptomonedas.Listar();
                    break;
                case 3:  // "Edad"
                    t_TablaMaestra3.Codigo = short.Parse(Txt_Codigo.Text);
                    t_TablaMaestra3.Descripcion = this.Txt_Nombre.Text.Trim();
                    t_TablaMaestra3.Valor = byte.Parse(this.NUD_Valor.Value.ToString());
                    t_TablaMaestra3.CondEspSeguridad = this.Chk_CES.Checked;
                    if (vl_EsNuevo)
                        NM_Edad.Insertar(t_TablaMaestra3);
                    else
                        NM_Edad.Actualizar(t_TablaMaestra3);
                    BS_MEdad.DataSource = NM_Edad.Listar();
                    break;
                case 4:  // "Estados"
                    t_TablaMaestra4.Codigo = short.Parse(Txt_Codigo.Text);
                    t_TablaMaestra4.Descripcion = this.Txt_Nombre.Text.Trim();
                    t_TablaMaestra4.Valor = byte.Parse(this.NUD_Valor.Value.ToString());
                    t_TablaMaestra4.CondEspSeguridad = this.Chk_CES.Checked;
                    if (vl_EsNuevo)
                    {
                        t_TablaMaestra6 = BS_MPais.Current as M_Pais;
                        //string vl_CodEstado = String.Format("{0:000}",int.Parse(Txt_Codigo.Text));
                        //string vl_CodEstado = int.Parse(Txt_Codigo.Text).ToString("000");
                        //t_TablaMaestra4.Cod_Compuesto = int.Parse(t_TablaMaestra6.Codigo.ToString() + vl_CodEstado);
                        t_TablaMaestra4.Cod_Compuesto = int.Parse(t_TablaMaestra6.Codigo.ToString() + int.Parse(Txt_Codigo.Text).ToString("000"));
                        t_TablaMaestra4.Cod_Pais = t_TablaMaestra6.Codigo;
                        NM_Estados.Insertar(t_TablaMaestra4);
                    }
                    else
                        NM_Estados.Actualizar(t_TablaMaestra4);
                    BS_MEstados.DataSource = NM_Estados.Listar();
                    break;
                case 5: // Nivel de Riesgo
                    t_TablaMaestra5.Codigo = short.Parse(Txt_Codigo.Text);
                    t_TablaMaestra5.Descripcion = this.Txt_Nombre.Text.Trim();
                    t_TablaMaestra5.valor = byte.Parse(this.NUD_Valor.Value.ToString());
                    t_TablaMaestra5.CondEspSeguridad = this.Chk_CES.Checked;
                    if (vl_EsNuevo)
                        NM_NivelRiesgo.Insertar(t_TablaMaestra5);
                    else
                        NM_NivelRiesgo.Actualizar(t_TablaMaestra5);
                    BS_MNivelRiesgo.DataSource = NM_NivelRiesgo.Listar();
                    break;
                case 6:  // "Pais"
                    t_TablaMaestra6.Codigo = short.Parse(Txt_Codigo.Text);
                    t_TablaMaestra6.Cod_AlfaNum2 = this.Txt_CodAlfa2.Text;
                    t_TablaMaestra6.Cod_AlfaNum3 = this.Txt_CodAlfa2.Text;
                    t_TablaMaestra6.Descripcion = this.Txt_Nombre.Text.Trim();
                    t_TablaMaestra6.Valor = byte.Parse(this.NUD_Valor.Value.ToString());
                    t_TablaMaestra6.CondEspSeguridad = this.Chk_CES.Checked;
                    if (vl_EsNuevo)
                        NM_Pais.Insertar(t_TablaMaestra6);
                    else
                        NM_Pais.Actualizar(t_TablaMaestra6);
                    BS_MPais.DataSource = NM_Pais.Listar();
                    break;
                case 7:  // "P.E.P."
                    t_TablaMaestra7.Codigo = short.Parse(Txt_Codigo.Text);
                    t_TablaMaestra7.Descripcion = this.Txt_Nombre.Text.Trim();
                    t_TablaMaestra7.Valor = byte.Parse(this.NUD_Valor.Value.ToString());
                    t_TablaMaestra7.CondEspSeguridad = this.Chk_CES.Checked;
                    if (vl_EsNuevo)
                        NM_PEP.Insertar(t_TablaMaestra7);
                    else
                        NM_PEP.Actualizar(t_TablaMaestra7);
                    BS_MPEP.DataSource = NM_PEP.Listar();
                    break;
                case 8:  // "Productos"
                    t_TablaMaestra8.Codigo = short.Parse(Txt_Codigo.Text);
                    t_TablaMaestra8.Descripcion = this.Txt_Nombre.Text.Trim();
                    t_TablaMaestra8.Valor = byte.Parse(this.NUD_Valor.Value.ToString());
                    t_TablaMaestra8.CondEspSeguridad = this.Chk_CES.Checked;
                    if (vl_EsNuevo)
                        NM_Productos.Insertar(t_TablaMaestra8);
                    else
                        NM_Productos.Actualizar(t_TablaMaestra8);
                    BS_MProductos.DataSource = NM_Productos.Listar();
                    break;
                case 9:  // "Profesión"
                    t_TablaMaestra9.Codigo = short.Parse(Txt_Codigo.Text);
                    t_TablaMaestra9.Descripcion = this.Txt_Nombre.Text.Trim();
                    t_TablaMaestra9.Valor = byte.Parse(this.NUD_Valor.Value.ToString());
                    t_TablaMaestra9.CondEspSeguridad = this.Chk_CES.Checked;
                    if (vl_EsNuevo)
                        NM_Profesiones.Insertar(t_TablaMaestra9);
                    else
                        NM_Profesiones.Actualizar(t_TablaMaestra9);
                    BS_MProfesiones.DataSource = NM_Profesiones.Listar();
                    break;
                case 10:  // "Servicios"
                    t_TablaMaestra10.Codigo = short.Parse(Txt_Codigo.Text);
                    t_TablaMaestra10.Descripcion = this.Txt_Nombre.Text.Trim();
                    t_TablaMaestra10.Valor = byte.Parse(this.NUD_Valor.Value.ToString());
                    t_TablaMaestra10.CondEspSeguridad = this.Chk_CES.Checked;
                    if (vl_EsNuevo)
                        NM_Servicios.Insertar(t_TablaMaestra10);
                    else
                        NM_Servicios.Actualizar(t_TablaMaestra10);
                    BS_MServicios.DataSource = NM_Servicios.Listar();
                    break;
                case 11:  // "Tipo de Documento Identidad"
                    t_TablaMaestra11.Codigo = short.Parse(Txt_Codigo.Text);
                    t_TablaMaestra11.Descripcion = this.Txt_Nombre.Text.Trim();
                    t_TablaMaestra11.Valor = byte.Parse(this.NUD_Valor.Value.ToString());
                    t_TablaMaestra11.CondEspSeguridad = this.Chk_CES.Checked;
                    if (vl_EsNuevo)
                        NM_TipoDocID.Insertar(t_TablaMaestra11);
                    else
                        NM_TipoDocID.Actualizar(t_TablaMaestra11);
                    BS_MServicios.DataSource = NM_TipoDocID.Listar();
                    break;
                case 12:  // "Tipo de Estructura"
                    t_TablaMaestra12.Codigo = short.Parse(Txt_Codigo.Text);
                    t_TablaMaestra12.Descripcion = this.Txt_Nombre.Text.Trim();
                    t_TablaMaestra12.Valor = byte.Parse(this.NUD_Valor.Value.ToString());
                    t_TablaMaestra12.CondEspSeguridad = this.Chk_CES.Checked;
                    if (vl_EsNuevo)
                        NM_TipoEstructuraEmpresa.Insertar(t_TablaMaestra12);
                    else
                        NM_TipoEstructuraEmpresa.Actualizar(t_TablaMaestra12);
                    BS_MTipoEstructuraEmpresa.DataSource = NM_TipoEstructuraEmpresa.Listar();
                    break;
                case 13:  // "Tipo de Persona Jurídica"
                    t_TablaMaestra13.Codigo = short.Parse(Txt_Codigo.Text);
                    t_TablaMaestra13.Descripcion = this.Txt_Nombre.Text.Trim();
                    t_TablaMaestra13.Valor = byte.Parse(this.NUD_Valor.Value.ToString());
                    t_TablaMaestra13.CondEspSeguridad = this.Chk_CES.Checked;

                    if (vl_EsNuevo)
                        NM_TipoPersJuridica.Insertar(t_TablaMaestra13);
                    else
                        NM_TipoPersJuridica.Actualizar(t_TablaMaestra13);
                        BS_MTipoPersJuridica.DataSource = NM_TipoPersJuridica.Listar();
                    break;

                case 14:  // "Vol. Oper. Pers. Natural"
                    t_TablaMaestra14.Codigo = short.Parse(Txt_Codigo.Text);
                    t_TablaMaestra14.Descripcion = this.Txt_Nombre.Text.Trim();
                    t_TablaMaestra14.Valor = byte.Parse(this.NUD_Valor.Value.ToString());
                    t_TablaMaestra14.CondEspSeguridad = this.Chk_CES.Checked;
                    if (vl_EsNuevo)
                        NM_VolOperPersNat.Insertar(t_TablaMaestra14);
                    else
                        NM_VolOperPersNat.Actualizar(t_TablaMaestra14);
                    BS_MVolOperPersNat.DataSource = NM_VolOperPersNat.Listar();
                    break;
                case 15:  // "Vol. Oper. Pers. Jurídica"
                    t_TablaMaestra15.Codigo = short.Parse(Txt_Codigo.Text);
                    t_TablaMaestra15.Descripcion = this.Txt_Nombre.Text.Trim();
                    t_TablaMaestra15.Valor = byte.Parse(this.NUD_Valor.Value.ToString());
                    t_TablaMaestra15.CondEspSeguridad = this.Chk_CES.Checked;
                    if (vl_EsNuevo)
                        NM_VolOperPersJur.Insertar(t_TablaMaestra15);
                    else
                        NM_VolOperPersJur.Actualizar(t_TablaMaestra15);
                    BS_MVolOperPersJur.DataSource = NM_VolOperPersJur.Listar();
                    break;
            }
            this.Modo_Consulta();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Modo_Consulta();
        }

        private void TSB_Agregar_Click(object sender, EventArgs e)
        {
            vl_EsNuevo = true;
            this.Modo_Edicion();
            switch (Cmb_TablaMaestra.SelectedIndex)
            {
                case 0:  // "Actividad Comercial"
                    BS_TablaMaestra.Add(new M_ActivComercial());
                    break;
                case 1:  // "Antigüedad"
                    BS_TablaMaestra.Add(new M_Antiguedad());
                    break;
                case 2:  // "Criptomonedas"
                    BS_TablaMaestra.Add(new M_Criptomonedas());
                    break;
                case 3:  // "Edad"
                    BS_TablaMaestra.Add(new M_Edad());
                    break;
                case 4:  // "Estados"
                    BS_TablaMaestra.Add(new M_Estados());
                    break;
                case 5: // Nivel de Riesgo
                    BS_TablaMaestra.Add(new M_NivelRiesgo());
                    break;
                case 6:  // "Pais"
                    BS_TablaMaestra.Add(new M_Pais());
                    break;
                case 7:  // "P.E.P."
                    BS_TablaMaestra.Add(new M_PEP());
                    break;
                case 8:  // "Productos"
                    BS_TablaMaestra.Add(new M_Productos());
                    break;
                case 9:  // "Profesión"
                    BS_TablaMaestra.Add(new M_Profesiones());
                    break;
                case 10:  // "Servicios"
                    BS_TablaMaestra.Add(new M_Servicios());
                    break;
                case 11:  // "Tipo de Documento Identidad"
                    BS_TablaMaestra.Add(new M_TipoDocID());
                    break;
                case 12:  // "Tipo de Estructura"
                    BS_TablaMaestra.Add(new M_TipoEstructuraEmpresa());
                    break;
                case 13:  // "Tipo de Persona Jurídica"
                    BS_TablaMaestra.Add(new M_TipoPersJuridica());
                    break;
                case 14:  // "Vol. Oper. Pers. Natural"
                    BS_TablaMaestra.Add(new M_VolOperPersNat());
                    break;
                case 15:  // "Vol. Oper. Pers. Jurídica"
                    BS_TablaMaestra.Add(new M_VolOperPersJur());
                    break;
            }
            BS_TablaMaestra.MoveLast();
        }

        private void TSB_Modificar_Click(object sender, EventArgs e)
        {
            vl_EsNuevo = false;
            this.Modo_Edicion();
            this.Txt_Nombre.Focus();
        }

        private void TSB_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TSB_Eliminar_Click(object sender, EventArgs e)
        {
            DialogResult vl_Resp = MessageBox.Show("Desea Eliminar este Registro? " + "\n\n"+ vl_RegEliminar,
                "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (vl_Resp == DialogResult.Yes)
            {
                switch (Cmb_TablaMaestra.SelectedIndex)
                {
                    case 0:  // "Actividad Comercial"
                        NM_ActivComercial.Elimiar(BS_MActivComercial.Current as M_ActivComercial);
                        BS_MActivComercial.DataSource = NM_ActivComercial.Listar();
                        //BS_TablaMaestra.DataSource = NM_ActivComercial.Listar();
                        break;
                    case 1:  // "Antigüedad"
                        NM_Antiguedad.Elimiar(BS_MAntiguedad.Current as M_Antiguedad);
                        BS_MAntiguedad.DataSource = NM_Antiguedad.Listar();
                        break;
                    case 2:  // "Criptomonedas"
                        NM_Criptomonedas.Elimiar(BS_MCriptomonedas.Current as M_Criptomonedas);
                        BS_MCriptomonedas.DataSource = NM_Criptomonedas.Listar();
                        break;
                    case 3:  // "Edad"
                        NM_Edad.Elimiar(BS_MEdad.Current as M_Edad);
                        BS_MEdad.DataSource = NM_Edad.Listar();
                        break;
                    case 4:  // "Estados"
                        NM_Estados.Elimiar(BS_MEstados.Current as M_Estados);
                        BS_MEstados.DataSource = NM_Estados.Listar();
                        break;
                    case 5: // Nivel de Riesgo
                        NM_NivelRiesgo.Elimiar(BS_MNivelRiesgo.Current as M_NivelRiesgo);
                        BS_MNivelRiesgo.DataSource = NM_NivelRiesgo.Listar();
                        break;
                    case 6:  // "Pais"
                        NM_Pais.Elimiar(BS_MPais.Current as M_Pais);
                        BS_MPais.DataSource = NM_Pais.Listar();
                        break;
                    case 7:  // "P.E.P."
                        NM_PEP.Elimiar(BS_MPEP.Current as M_PEP);
                        BS_MPEP.DataSource = NM_PEP.Listar();
                        break;
                    case 8:  // "Productos"
                        NM_Productos.Elimiar(BS_MProductos.Current as M_Productos);
                        BS_MProductos.DataSource = NM_Productos.Listar();
                        break;
                    case 9:  // "Profesión"
                        NM_Profesiones.Elimiar(BS_MProfesiones.Current as M_Profesiones);
                        BS_MProfesiones.DataSource = NM_Profesiones.Listar();
                        break;
                    case 10:  // "Servicios"
                        NM_Servicios.Elimiar(BS_MServicios.Current as M_Servicios);
                        BS_MServicios.DataSource = NM_Servicios.Listar();
                        break;
                    case 11:  // "Tipo de Documento Identidad"
                        NM_TipoDocID.Elimiar(BS_MTipoDocID.Current as M_TipoDocID);
                        BS_MTipoDocID.DataSource = NM_TipoDocID.Listar();
                        break;
                    case 12:  // "Tipo de Estructura"
                        NM_TipoEstructuraEmpresa.Elimiar(BS_MTipoEstructuraEmpresa.Current as M_TipoEstructuraEmpresa);
                        BS_MTipoEstructuraEmpresa.DataSource = NM_TipoEstructuraEmpresa.Listar();
                        break;
                    case 13:  // "Tipo de Persona Jurídica"
                        NM_TipoPersJuridica.Elimiar(BS_MTipoPersJuridica.Current as M_TipoPersJuridica);
                        BS_MTipoPersJuridica.DataSource = NM_TipoPersJuridica.Listar();
                        break;
                    case 14:  // "Vol. Oper. Pers. Natural"
                        NM_VolOperPersNat.Elimiar(BS_MVolOperPersNat.Current as M_VolOperPersNat);
                        BS_MVolOperPersNat.DataSource = NM_VolOperPersNat.Listar();

                        break;
                    case 15:  // "Vol. Oper. Pers. Jurídica"
                        NM_VolOperPersJur.Elimiar(BS_MVolOperPersJur.Current as M_VolOperPersJur);
                        BS_MVolOperPersJur.DataSource = NM_VolOperPersJur.Listar();
                        break;
                }
                Grd_Detalles.Refresh();
                MessageBox.Show("Se eliminó el registro actual", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void TSB_Primero_Click(object sender, EventArgs e)
        {
            BS_TablaMaestra.MoveFirst();
            TSB_ActualizaBotonesNavegacion();
        }

        private void TSB_Anterior_Click(object sender, EventArgs e)
        {
            BS_TablaMaestra.MovePrevious();
            TSB_ActualizaBotonesNavegacion();
        }

        private void TSB_Siguiente_Click(object sender, EventArgs e)
        {
            BS_TablaMaestra.MoveNext();
            TSB_ActualizaBotonesNavegacion();
        }

        private void TSB_Ultimo_Click(object sender, EventArgs e)
        {
            BS_TablaMaestra.MoveLast();
            TSB_ActualizaBotonesNavegacion();
        }

        private void Txt_CodPais_TextChanged(object sender, EventArgs e)
        {
            string vl_Filtro = "Cod_Pais = " + this.Txt_CodPais.Text.ToString();
            BS_TablaMaestra.Filter = vl_Filtro;
            Grd_Detalles.Refresh();

        }

        private void NUD_Valor_Validating(object sender, CancelEventArgs e)
        {
            if (this.NUD_Valor.Value >= this.NUD_Valor.Maximum)
                this.NUD_Valor.Value = this.NUD_Valor.Maximum;

            if (this.NUD_Valor.Value <= this.NUD_Valor.Minimum)
                this.NUD_Valor.Value = this.NUD_Valor.Minimum;

        }

        private void Cmb_Pais_SelectedIndexChanged(object sender, EventArgs e)
        {
            //BS_TablaMaestra.Filter = "Cod_Pais = " + this.Txt_CodPais.Text.Trim();
           
            if (Cmb_Pais.SelectedIndex != -1)
            {
                //Cmb_PaisResidencia.Items.Clear();
                short pais = (short)Cmb_Pais.SelectedValue;

                BS_TablaMaestra.DataSource = NM_Estados.ListarPorPais(pais);
                //Cmb_Estado.DisplayMember = "Descripcion";
                //Cmb_Estado.ValueMember = "Codigo";
            }
            
        }
    }
}
    