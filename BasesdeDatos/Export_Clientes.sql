/****** Script for SelectTopNRows command from SSMS  ******/
SELECT c.Codigo,
		iif(c.TipoPersona = '1', 'Persona Natural', 'Persona jurídica') as Tipo_Persona,
		iif(c.Activo = 'True', 'Activo', 'Inactivo') as Status,
		c.Doc_ID,
		c.Nombre,
		c.Cliente_Punt,
		DocID.Descripcion as TipoDocID,
		IG_FecVencDocID,
		P_Nacim.Descripcion as Pais_Nacimiento,
		P_Nacional.Descripcion as Nacionalidad,
		P_Resid.Descripcion as Pais_Residencia,
		Estado.Descripcion as Estado,
		iif(c.TipoPersona = '1', Edad.Descripcion, Antig.Descripcion) as Edad,
		TipPersJur.Descripcion as TipoPersonaJuridica,
		EstrucEmpresa.Descripcion as TipoEstrucEmpresa,
		PEP.Descripcion as PEP,
		iif(c.TipoPersona = '1', VolOperN.Descripcion, VolOperJ.Descripcion) as Vol_Operaciones,
		Cripto.Descripcion as Criptomonedas,
		Profes.Descripcion as Profesion,
		ActComer.Descripcion as Activ_Comercial,
		IG_Email,
		Observacion,
		Ejecutivo,
		Riesgo.Descripcion as NivelRiesgo,
		PerfilFinanciero,
		iif(c.PeriodUsoCta = '1', 'Semanal', iif(c.PeriodUsoCta = '2','Mensual', iif(c.PeriodUsoCta = '3','Trimestral', iif(c.PeriodUsoCta = '4','Semestral', iif(c.PeriodUsoCta = '5','Anual', 'No Definido'))))) as PeriodoUsoCta,
		NroTransacciones,
		Fec_UltimAct
  FROM MonitorOperaciones.dbo.C_Clientes as C
  left outer join MonitorOperaciones.dbo.M_TipoDocID as DocID
	on c.IG_TipDocID = DocID.Codigo
  left outer join MonitorOperaciones.dbo.M_Pais as P_Nacim
	on c.IG_PaisNacim = P_Nacim.Codigo
  left outer join MonitorOperaciones.dbo.M_Pais as P_Nacional
	on c.IG_Nacionalidad = P_Nacional.Codigo
  left outer join MonitorOperaciones.dbo.M_Pais as P_Resid
	on c.IG_PaisResid = P_Resid.Codigo
  left outer join MonitorOperaciones.dbo.M_Estados as Estado
	on c.IG_Estado = Estado.Cod_Compuesto
  left outer join MonitorOperaciones.dbo.M_PEP as PEP
	on c.IG_PEP = PEP.Codigo
  left outer join MonitorOperaciones.dbo.M_Edad as Edad
	on c.IG_Edad = edad.Codigo
  left outer join MonitorOperaciones.dbo.M_Antiguedad as Antig
	on c.IG_Edad = Antig.Codigo
  left outer join MonitorOperaciones.dbo.M_TipoPersJuridica as TipPersJur
	on c.IG_TipoPersJur = TipPersJur.Codigo
  left outer join MonitorOperaciones.dbo.M_Profesiones as Profes
	on c.IG_Profesion = Profes.Codigo
  left outer join MonitorOperaciones.dbo.M_TipoEstructuraEmpresa as EstrucEmpresa
	on c.IG_TipoEstructura = EstrucEmpresa.Codigo
  left outer join MonitorOperaciones.dbo.M_VolOperPersNat as VolOperN
	on c.IG_VolumOperac = VolOperN.Codigo
  left outer join MonitorOperaciones.dbo.M_VolOperPersJur as VolOperJ
	on c.IG_VolumOperac = VolOperJ.Codigo
  left outer join MonitorOperaciones.dbo.M_Criptomonedas as Cripto
	on c.IG_Criptomoneda = Cripto.Codigo
  left outer join MonitorOperaciones.dbo.M_ActivComercial as ActComer
	on c.IG_ActivComer = ActComer.Codigo
  left outer join MonitorOperaciones.dbo.M_NivelRiesgo as Riesgo
	on c.NivelRiesgo = Riesgo.Codigo
  order by c.Codigo

