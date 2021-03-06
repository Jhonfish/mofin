﻿using System;
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
using MOFIN_LIB;

namespace MOFIN
{
    public partial class Frm_TablasMaestras : MetroForm
    {
        bool vl_EsNuevo = true;
        string vl_RegEliminar = "";

        M_ActivComercial t_TablasMaestras = new M_ActivComercial();
        M_ActivComercial r_TablaMaestra0 = new M_ActivComercial();
        M_Antiguedad r_TablaMaestra1 = new M_Antiguedad();
        M_Criptomonedas r_TablaMaestra2 = new M_Criptomonedas();
        M_Edad r_TablaMaestra3 = new M_Edad();
        M_Estados r_TablaMaestra4 = new M_Estados();
        M_NivelRiesgo r_TablaMaestra5 = new M_NivelRiesgo();
        M_Pais r_TablaMaestra6 = new M_Pais();
        M_PEP r_TablaMaestra7 = new M_PEP();
        M_Productos r_TablaMaestra8 = new M_Productos();
        M_Profesiones r_TablaMaestra9 = new M_Profesiones();
        M_Servicios r_TablaMaestra10 = new M_Servicios();
        M_TipoDocID r_TablaMaestra11 = new M_TipoDocID();
        M_TipoEstructuraEmpresa r_TablaMaestra12 = new M_TipoEstructuraEmpresa();
        M_TipoPersJuridica r_TablaMaestra13 = new M_TipoPersJuridica();
        M_VolOperPersNat r_TablaMaestra14 = new M_VolOperPersNat();
        M_VolOperPersJur r_TablaMaestra15 = new M_VolOperPersJur();
        Grupo_Opciones r_GrupoOpciones = new Grupo_Opciones();

        M_TipoOrdenes r_TablaMaestra16 = new M_TipoOrdenes();
        M_Titulos r_TablaMaestra17 = new M_Titulos();

        public Frm_TablasMaestras()
        {
            InitializeComponent();

            this.TSB_Primero.Visible = Entorno.vs_CnfgBtnsNaveg;
            this.TSB_Anterior.Visible = Entorno.vs_CnfgBtnsNaveg;
            this.TSB_Siguiente.Visible = Entorno.vs_CnfgBtnsNaveg;
            this.TSB_Ultimo.Visible = Entorno.vs_CnfgBtnsNaveg;
            this.ts_Sep1.Visible = Entorno.vs_CnfgBtnsNaveg;
            this.Asigna_Nombres(null, null);
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
            BS_MTipoOrdenes.DataSource = NM_TipoOrdenes.Listar();
            BS_MTipoPersJuridica.DataSource = NM_TipoPersJuridica.Listar();
            BS_MTitulos.DataSource = NM_Titulos.Listar();
            BS_MVolOperPersNat.DataSource = NM_VolOperPersNat.Listar();
            BS_MVolOperPersJur.DataSource = NM_VolOperPersJur.Listar();

            BS_Grupo_Opciones.DataSource = NGrupo_Opciones.ListarPorCodigo(MOFIN_LIB.Entorno.vs_Grupo);
            r_GrupoOpciones = BS_Grupo_Opciones.Current as Grupo_Opciones;

            Cmb_TablaMaestra.SelectedIndex = 0;
            this.Modo_Consulta();
            this.Grd_Detalles.Focus();

            
        }

        //**************
        // Eventos del formulario
        //**************

        private void Grd_Detalles_CurrentCellChanged(object sender, EventArgs e)
        {
            if (BS_TablaMaestra.Position >= 0)
            {
                switch (Cmb_TablaMaestra.SelectedIndex)
                {
                    case 0:  // "Actividad Comercial"
                        r_TablaMaestra0 = BS_TablaMaestra.Current as M_ActivComercial;
                        break;
                    case 1:  // "Antigüedad"
                        r_TablaMaestra1 = BS_TablaMaestra.Current as M_Antiguedad;
                        break;
                    case 2:  // "Criptomonedas"
                        r_TablaMaestra2 = BS_TablaMaestra.Current as M_Criptomonedas;
                        break;
                    case 3:  // "Edad"
                        r_TablaMaestra3 = BS_TablaMaestra.Current as M_Edad;
                        break;
                    case 4:  // "Estados"
                        r_TablaMaestra4 = BS_TablaMaestra.Current as M_Estados;
                        break;
                    case 5: // Nivel de Riesgo
                        r_TablaMaestra5 = BS_TablaMaestra.Current as M_NivelRiesgo;
                        break;
                    case 6:  // "Pais"
                        r_TablaMaestra6 = BS_TablaMaestra.Current as M_Pais;
                        break;
                    case 7:  // "P.E.P."
                        r_TablaMaestra7 = BS_TablaMaestra.Current as M_PEP;
                        break;
                    case 8:  // "Productos"
                        r_TablaMaestra8 = BS_TablaMaestra.Current as M_Productos;
                        break;
                    case 9:  // "Profesión"
                        r_TablaMaestra9 = BS_TablaMaestra.Current as M_Profesiones;
                        break;
                    case 10:  // "Servicios"
                        r_TablaMaestra10 = BS_TablaMaestra.Current as M_Servicios;
                        break;
                    case 11:  // "Tipo de Documento Identidad"
                        r_TablaMaestra11 = BS_TablaMaestra.Current as M_TipoDocID;
                        break;
                    case 12:  // "Tipo de Estructura"
                        r_TablaMaestra12 = BS_TablaMaestra.Current as M_TipoEstructuraEmpresa;
                        break;
                    case 13:  // "Tipo de Persona Jurídica"
                        r_TablaMaestra13 = BS_TablaMaestra.Current as M_TipoPersJuridica;
                        break;
                    case 14:  // "Vol. Oper. Pers. Natural"
                        r_TablaMaestra14 = BS_TablaMaestra.Current as M_VolOperPersNat;
                        break;
                    case 15:  // "Vol. Oper. Pers. Jurídica"
                        r_TablaMaestra15 = BS_TablaMaestra.Current as M_VolOperPersJur;
                        break;
                    case 16:  // "Vol. Oper. Pers. Jurídica"
                        r_TablaMaestra16 = BS_TablaMaestra.Current as M_TipoOrdenes;
                        break;
                    case 17:  // "Vol. Oper. Pers. Jurídica"
                        r_TablaMaestra17 = BS_TablaMaestra.Current as M_Titulos;
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
            this.Txt_ISINCode.DataBindings.Clear();

            this.Cmb_Pais.Visible = false;
            this.Txt_CodAlfa2.Visible = false;
            this.Txt_CodAlfa3.Visible = false;
            this.Txt_ISINCode.Visible = false;

            this.Lbl_Pais.Visible = false;
            this.Lbl_CodAlfa2.Visible = false;
            this.Lbl_CodAlfa3.Visible = false;
            this.Lbl_ISINCode.Visible = false;

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
                    this.Cmb_Pais_SelectedIndexChanged(null, null);
                    break;
                case 5: // Nivel de Riesgo
                    BS_TablaMaestra.DataSource = BS_MNivelRiesgo;
                    break;
                case 6:  // "Pais"
                    BS_TablaMaestra.DataSource = BS_MPais;
                    this.Txt_CodAlfa2.DataBindings.Add("Text", BS_TablaMaestra, "Cod_AlfaNum2");
                    this.Txt_CodAlfa3.DataBindings.Add("Text", BS_TablaMaestra, "Cod_AlfaNum3");
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
                case 16:  // "Tipo de Ordenes"
                    BS_TablaMaestra.DataSource = BS_MTipoOrdenes;
                    break;
                case 17:  // "Títulos"
                    BS_TablaMaestra.DataSource = BS_MTitulos;
                    this.Txt_ISINCode.DataBindings.Add("Text", BS_TablaMaestra, "ISIN");
                    this.Txt_ISINCode.Visible = true;
                    this.Lbl_ISINCode.Visible = true;
                    break;
            }
            BS_TablaMaestra.MoveFirst();
            Grd_Detalles.DataSource = BS_TablaMaestra;
            TSB_ActualizaBotonesNavegacion();
            //Grd_Detalles_CurrentCellChanged(null,null);
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
                this.TSB_Agregar.Enabled = Entorno.vs_Maestro ? true : r_GrupoOpciones.TabMaestras_I == null? false : (bool)r_GrupoOpciones.TabMaestras_I;
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
                this.TSB_Agregar.Enabled = Entorno.vs_Maestro ? true : r_GrupoOpciones.TabMaestras_I == null ? false : (bool)r_GrupoOpciones.TabMaestras_I;
                this.TSB_Modificar.Enabled = Entorno.vs_Maestro ? true : r_GrupoOpciones.TabMaestras_M == null ? false : (bool)r_GrupoOpciones.TabMaestras_M;
                this.TSB_Eliminar.Enabled = Entorno.vs_Maestro ? true : r_GrupoOpciones.TabMaestras_E == null ? false : (bool)r_GrupoOpciones.TabMaestras_E;
                this.TSB_Imprimir.Enabled = Entorno.vs_Maestro ? true : r_GrupoOpciones.TabMaestras_P == null ? false : (bool)r_GrupoOpciones.TabMaestras_P;
            }
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            switch (Cmb_TablaMaestra.SelectedIndex)
            {
                case 0:  // "Actividad Comercial"
                    r_TablaMaestra0.Codigo = short.Parse(Txt_Codigo.Text);
                    r_TablaMaestra0.Descripcion = this.Txt_Nombre.Text.Trim();
                    r_TablaMaestra0.Valor = byte.Parse(this.NUD_Valor.Value.ToString());
                    r_TablaMaestra0.CondEspSeguridad = this.Chk_CES.Checked;
                    if (vl_EsNuevo)
                        NM_ActivComercial.Insertar(r_TablaMaestra0);
                    else
                        NM_ActivComercial.Actualizar(r_TablaMaestra0);
                    BS_MActivComercial.DataSource = NM_ActivComercial.Listar();
                    break;
                case 1:  // "Antigüedad"
                    r_TablaMaestra1.Codigo = short.Parse(Txt_Codigo.Text);
                    r_TablaMaestra1.Descripcion = this.Txt_Nombre.Text.Trim();
                    r_TablaMaestra1.Valor = byte.Parse(this.NUD_Valor.Value.ToString());
                    r_TablaMaestra1.CondEspSeguridad = this.Chk_CES.Checked;
                    if (vl_EsNuevo)
                        NM_Antiguedad.Insertar(r_TablaMaestra1);
                    else
                        NM_Antiguedad.Actualizar(r_TablaMaestra1);
                    BS_MAntiguedad.DataSource = NM_Antiguedad.Listar();
                    break;
                case 2:  // "Criptomonedas"
                    r_TablaMaestra2.Codigo = short.Parse(Txt_Codigo.Text);
                    r_TablaMaestra2.Descripcion = this.Txt_Nombre.Text.Trim();
                    r_TablaMaestra2.Valor = byte.Parse(this.NUD_Valor.Value.ToString());
                    r_TablaMaestra2.CondEspSeguridad = this.Chk_CES.Checked;
                    if (vl_EsNuevo)
                        NM_Criptomonedas.Insertar(r_TablaMaestra2);
                    else
                        NM_Criptomonedas.Actualizar(r_TablaMaestra2);
                    BS_MCriptomonedas.DataSource = NM_Criptomonedas.Listar();
                    break;
                case 3:  // "Edad"
                    r_TablaMaestra3.Codigo = short.Parse(Txt_Codigo.Text);
                    r_TablaMaestra3.Descripcion = this.Txt_Nombre.Text.Trim();
                    r_TablaMaestra3.Valor = byte.Parse(this.NUD_Valor.Value.ToString());
                    r_TablaMaestra3.CondEspSeguridad = this.Chk_CES.Checked;
                    if (vl_EsNuevo)
                        NM_Edad.Insertar(r_TablaMaestra3);
                    else
                        NM_Edad.Actualizar(r_TablaMaestra3);
                    BS_MEdad.DataSource = NM_Edad.Listar();
                    break;
                case 4:  // "Estados"
                    r_TablaMaestra4.Codigo = short.Parse(Txt_Codigo.Text);
                    r_TablaMaestra4.Descripcion = this.Txt_Nombre.Text.Trim();
                    r_TablaMaestra4.Valor = byte.Parse(this.NUD_Valor.Value.ToString());
                    r_TablaMaestra4.CondEspSeguridad = this.Chk_CES.Checked;
                    if (vl_EsNuevo)
                    {
                        r_TablaMaestra6 = BS_MPais.Current as M_Pais;
                        r_TablaMaestra4.Cod_Compuesto = int.Parse(r_TablaMaestra6.Codigo.ToString() + int.Parse(Txt_Codigo.Text).ToString("000"));
                        r_TablaMaestra4.Cod_Pais = r_TablaMaestra6.Codigo;
                        NM_Estados.Insertar(r_TablaMaestra4);
                    }
                    else
                        NM_Estados.Actualizar(r_TablaMaestra4);
                    BS_MEstados.DataSource = NM_Estados.Listar();
                    break;
                case 5: // Nivel de Riesgo
                    r_TablaMaestra5.Codigo = short.Parse(Txt_Codigo.Text);
                    r_TablaMaestra5.Descripcion = this.Txt_Nombre.Text.Trim();
                    r_TablaMaestra5.valor = byte.Parse(this.NUD_Valor.Value.ToString());
                    r_TablaMaestra5.CondEspSeguridad = this.Chk_CES.Checked;
                    if (vl_EsNuevo)
                        NM_NivelRiesgo.Insertar(r_TablaMaestra5);
                    else
                        NM_NivelRiesgo.Actualizar(r_TablaMaestra5);
                    BS_MNivelRiesgo.DataSource = NM_NivelRiesgo.Listar();
                    break;
                case 6:  // "Pais"
                    r_TablaMaestra6.Codigo = short.Parse(Txt_Codigo.Text);
                    r_TablaMaestra6.Cod_AlfaNum2 = this.Txt_CodAlfa2.Text;
                    r_TablaMaestra6.Cod_AlfaNum3 = this.Txt_CodAlfa3.Text;
                    r_TablaMaestra6.Descripcion = this.Txt_Nombre.Text.Trim();
                    r_TablaMaestra6.Valor = byte.Parse(this.NUD_Valor.Value.ToString());
                    r_TablaMaestra6.CondEspSeguridad = this.Chk_CES.Checked;
                    if (vl_EsNuevo)
                        NM_Pais.Insertar(r_TablaMaestra6);
                    else
                        NM_Pais.Actualizar(r_TablaMaestra6);
                    BS_MPais.DataSource = NM_Pais.Listar();
                    break;
                case 7:  // "P.E.P."
                    r_TablaMaestra7.Codigo = short.Parse(Txt_Codigo.Text);
                    r_TablaMaestra7.Descripcion = this.Txt_Nombre.Text.Trim();
                    r_TablaMaestra7.Valor = byte.Parse(this.NUD_Valor.Value.ToString());
                    r_TablaMaestra7.CondEspSeguridad = this.Chk_CES.Checked;
                    if (vl_EsNuevo)
                        NM_PEP.Insertar(r_TablaMaestra7);
                    else
                        NM_PEP.Actualizar(r_TablaMaestra7);
                    BS_MPEP.DataSource = NM_PEP.Listar();
                    break;
                case 8:  // "Productos"
                    r_TablaMaestra8.Codigo = short.Parse(Txt_Codigo.Text);
                    r_TablaMaestra8.Descripcion = this.Txt_Nombre.Text.Trim();
                    r_TablaMaestra8.Valor = byte.Parse(this.NUD_Valor.Value.ToString());
                    r_TablaMaestra8.CondEspSeguridad = this.Chk_CES.Checked;
                    if (vl_EsNuevo)
                        NM_Productos.Insertar(r_TablaMaestra8);
                    else
                        NM_Productos.Actualizar(r_TablaMaestra8);
                    BS_MProductos.DataSource = NM_Productos.Listar();
                    break;
                case 9:  // "Profesión"
                    r_TablaMaestra9.Codigo = short.Parse(Txt_Codigo.Text);
                    r_TablaMaestra9.Descripcion = this.Txt_Nombre.Text.Trim();
                    r_TablaMaestra9.Valor = byte.Parse(this.NUD_Valor.Value.ToString());
                    r_TablaMaestra9.CondEspSeguridad = this.Chk_CES.Checked;
                    if (vl_EsNuevo)
                        NM_Profesiones.Insertar(r_TablaMaestra9);
                    else
                        NM_Profesiones.Actualizar(r_TablaMaestra9);
                    BS_MProfesiones.DataSource = NM_Profesiones.Listar();
                    break;
                case 10:  // "Servicios"
                    r_TablaMaestra10.Codigo = short.Parse(Txt_Codigo.Text);
                    r_TablaMaestra10.Descripcion = this.Txt_Nombre.Text.Trim();
                    r_TablaMaestra10.Valor = byte.Parse(this.NUD_Valor.Value.ToString());
                    r_TablaMaestra10.CondEspSeguridad = this.Chk_CES.Checked;
                    if (vl_EsNuevo)
                        NM_Servicios.Insertar(r_TablaMaestra10);
                    else
                        NM_Servicios.Actualizar(r_TablaMaestra10);
                    BS_MServicios.DataSource = NM_Servicios.Listar();
                    break;
                case 11:  // "Tipo de Documento Identidad"
                    r_TablaMaestra11.Codigo = short.Parse(Txt_Codigo.Text);
                    r_TablaMaestra11.Descripcion = this.Txt_Nombre.Text.Trim();
                    r_TablaMaestra11.Valor = byte.Parse(this.NUD_Valor.Value.ToString());
                    r_TablaMaestra11.CondEspSeguridad = this.Chk_CES.Checked;
                    if (vl_EsNuevo)
                        NM_TipoDocID.Insertar(r_TablaMaestra11);
                    else
                        NM_TipoDocID.Actualizar(r_TablaMaestra11);
                    BS_MServicios.DataSource = NM_TipoDocID.Listar();
                    break;
                case 12:  // "Tipo de Estructura"
                    r_TablaMaestra12.Codigo = short.Parse(Txt_Codigo.Text);
                    r_TablaMaestra12.Descripcion = this.Txt_Nombre.Text.Trim();
                    r_TablaMaestra12.Valor = byte.Parse(this.NUD_Valor.Value.ToString());
                    r_TablaMaestra12.CondEspSeguridad = this.Chk_CES.Checked;
                    if (vl_EsNuevo)
                        NM_TipoEstructuraEmpresa.Insertar(r_TablaMaestra12);
                    else
                        NM_TipoEstructuraEmpresa.Actualizar(r_TablaMaestra12);
                    BS_MTipoEstructuraEmpresa.DataSource = NM_TipoEstructuraEmpresa.Listar();
                    break;
                case 13:  // "Tipo de Persona Jurídica"
                    r_TablaMaestra13.Codigo = short.Parse(Txt_Codigo.Text);
                    r_TablaMaestra13.Descripcion = this.Txt_Nombre.Text.Trim();
                    r_TablaMaestra13.Valor = byte.Parse(this.NUD_Valor.Value.ToString());
                    r_TablaMaestra13.CondEspSeguridad = this.Chk_CES.Checked;

                    if (vl_EsNuevo)
                        NM_TipoPersJuridica.Insertar(r_TablaMaestra13);
                    else
                        NM_TipoPersJuridica.Actualizar(r_TablaMaestra13);
                        BS_MTipoPersJuridica.DataSource = NM_TipoPersJuridica.Listar();
                    break;

                case 14:  // "Vol. Oper. Pers. Natural"
                    r_TablaMaestra14.Codigo = short.Parse(Txt_Codigo.Text);
                    r_TablaMaestra14.Descripcion = this.Txt_Nombre.Text.Trim();
                    r_TablaMaestra14.Valor = byte.Parse(this.NUD_Valor.Value.ToString());
                    r_TablaMaestra14.CondEspSeguridad = this.Chk_CES.Checked;
                    if (vl_EsNuevo)
                        NM_VolOperPersNat.Insertar(r_TablaMaestra14);
                    else
                        NM_VolOperPersNat.Actualizar(r_TablaMaestra14);
                    BS_MVolOperPersNat.DataSource = NM_VolOperPersNat.Listar();
                    break;
                case 15:  // "Vol. Oper. Pers. Jurídica"
                    r_TablaMaestra15.Codigo = short.Parse(Txt_Codigo.Text);
                    r_TablaMaestra15.Descripcion = this.Txt_Nombre.Text.Trim();
                    r_TablaMaestra15.Valor = byte.Parse(this.NUD_Valor.Value.ToString());
                    r_TablaMaestra15.CondEspSeguridad = this.Chk_CES.Checked;
                    if (vl_EsNuevo)
                        NM_VolOperPersJur.Insertar(r_TablaMaestra15);
                    else
                        NM_VolOperPersJur.Actualizar(r_TablaMaestra15);
                    BS_MVolOperPersJur.DataSource = NM_VolOperPersJur.Listar();
                    break;
                case 16:  // "Tipo de Orden"
                    r_TablaMaestra16.Codigo = short.Parse(Txt_Codigo.Text);
                    r_TablaMaestra16.Descripcion = this.Txt_Nombre.Text.Trim();
                    r_TablaMaestra16.Valor = byte.Parse(this.NUD_Valor.Value.ToString());
                    r_TablaMaestra16.CondEspSeguridad = this.Chk_CES.Checked;
                    if (vl_EsNuevo)
                        NM_TipoOrdenes.Insertar(r_TablaMaestra16);
                    else
                        NM_TipoOrdenes.Actualizar(r_TablaMaestra16);
                    BS_MTipoOrdenes.DataSource = NM_TipoOrdenes.Listar();
                    break;
                case 17:  // "Títulos"
                    r_TablaMaestra17.Codigo = Txt_Codigo.Text.Trim();
                    r_TablaMaestra17.ISIN = Txt_ISINCode.Text.Trim();
                    r_TablaMaestra17.Descripcion = this.Txt_Nombre.Text.Trim();
                    r_TablaMaestra17.Valor = byte.Parse(this.NUD_Valor.Value.ToString());
                    r_TablaMaestra17.CondEspSeguridad = this.Chk_CES.Checked;
                    if (vl_EsNuevo)
                        NM_Titulos.Insertar(r_TablaMaestra17);
                    else
                        NM_Titulos.Actualizar(r_TablaMaestra17);
                    BS_MTitulos.DataSource = NM_Titulos.Listar();
                    break;

            }
            this.Modo_Consulta();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            BS_TablaMaestra.CancelEdit();
            this.Cmb_TablaMaestra_SelectedIndexChanged(null,null);
            this.Modo_Consulta();

        }

        private void TSB_Agregar_Click(object sender, EventArgs e)
        {
            vl_EsNuevo = true;
            this.Modo_Edicion();
            /*           switch (Cmb_TablaMaestra.SelectedIndex)
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
                       }*/
            BS_TablaMaestra.AddNew();

            BS_TablaMaestra.MoveLast();
        }

        private void TSB_Modificar_Click(object sender, EventArgs e)
        {
            vl_EsNuevo = false;
            this.Modo_Edicion();
            this.Txt_Nombre.Focus();
        }

        private void TSB_Eliminar_Click(object sender, EventArgs e)
        {
            if (Grd_Detalles.CurrentRow != null)
            {
                vl_RegEliminar = Grd_Detalles.CurrentRow.Cells["Col_Nombre"].Value.ToString();
            }

            DialogResult vl_Resp = MessageBox.Show(Funciones._Mens_Idioma(9010) + "\n\n"+ vl_RegEliminar,
                Funciones._Mens_Idioma(201), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

//                        NM_Estados.Elimiar(BS_MEstados.Current as M_Estados);
                        NM_Estados.Elimiar(r_TablaMaestra4 as M_Estados);
                        BS_MEstados.DataSource = NM_Estados.Listar();
                        this.Cmb_Pais_SelectedIndexChanged(null, null);
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
                MessageBox.Show(MOFIN_LIB.Funciones._Mens_Idioma(9011), MOFIN_LIB.Funciones._Mens_Idioma(201), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void TSB_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void NUD_Valor_Validating(object sender, CancelEventArgs e)
        {
            if (this.NUD_Valor.Value >= this.NUD_Valor.Maximum)
                this.NUD_Valor.Value = this.NUD_Valor.Maximum;

            if (this.NUD_Valor.Value <= this.NUD_Valor.Minimum)
                this.NUD_Valor.Value = this.NUD_Valor.Minimum;

        }

        private void Cmb_Pais_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cmb_Pais.SelectedIndex != -1 & Cmb_TablaMaestra.SelectedIndex == 4)
            {
                short pais = (short)Cmb_Pais.SelectedValue;
                BS_TablaMaestra.DataSource = NM_Estados.ListarPorPais(pais);
            }
            
        }
        private void Asigna_Nombres(object sender, EventArgs e)
        {
            this.Text = MOFIN_LIB.Funciones._Mens_Idioma(10001);
            this.Lbl_tablaMaestra.Text= MOFIN_LIB.Funciones._Mens_Idioma(10005);
            this.Lbl_Codigo.Text = MOFIN_LIB.Funciones._Mens_Idioma(1001);
            this.Lbl_Nombre.Text = MOFIN_LIB.Funciones._Mens_Idioma(1002);
            this.Lbl_Pais.Text = MOFIN_LIB.Funciones._Mens_Idioma(10002);
            this.Lbl_Valor.Text = MOFIN_LIB.Funciones._Mens_Idioma(1012);
            this.Lbl_CodAlfa2.Text = MOFIN_LIB.Funciones._Mens_Idioma(10003)+"2";
            this.Lbl_CodAlfa3.Text = MOFIN_LIB.Funciones._Mens_Idioma(10003)+"3";
            this.Lbl_CondEspSeguridad.Text = MOFIN_LIB.Funciones._Mens_Idioma(10004);
            this.Cmb_TablaMaestra.Items.Clear();
            for (int i = 0; i < 18; i++)
                this.Cmb_TablaMaestra.Items.Add(MOFIN_LIB.Funciones._Mens_Idioma(10011 + i));
            
            this.TSB_Primero.Text = MOFIN_LIB.Funciones._Mens_Idioma(131);
            this.TSB_Anterior.Text = MOFIN_LIB.Funciones._Mens_Idioma(132);
            this.TSB_Siguiente.Text = MOFIN_LIB.Funciones._Mens_Idioma(133);
            this.TSB_Ultimo.Text = MOFIN_LIB.Funciones._Mens_Idioma(134);
            this.TSB_Agregar.Text = MOFIN_LIB.Funciones._Mens_Idioma(136);
            this.TSB_Modificar.Text = MOFIN_LIB.Funciones._Mens_Idioma(137);
            this.TSB_Eliminar.Text = MOFIN_LIB.Funciones._Mens_Idioma(138);
            this.TSB_Imprimir.Text = MOFIN_LIB.Funciones._Mens_Idioma(139);
            this.TSB_Salir.Text = MOFIN_LIB.Funciones._Mens_Idioma(140);

            this.Col_Codigo.HeaderText = MOFIN_LIB.Funciones._Mens_Idioma(1001);
            this.Col_Nombre.HeaderText = MOFIN_LIB.Funciones._Mens_Idioma(1002);

            MOFIN_LIB.Funciones.TTT_Btn(Btn_Aceptar, MOFIN_LIB.Funciones._Mens_Idioma(141));
            MOFIN_LIB.Funciones.TTT_Btn(Btn_Cancelar, MOFIN_LIB.Funciones._Mens_Idioma(142));
        }
    }
}
    