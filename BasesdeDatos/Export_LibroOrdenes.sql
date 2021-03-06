/****** Script for SelectTopNRows command from SSMS  ******/
select	o.secuencia, 
		t.Descripcion as Tipo_Orden, 
		o.Titulo_Cod as Tit_Codigo,
		tt.Descripcion as Tit_Nombre,
		tt.ISIN as Tit_ISIN,
		o.Fecha_Orden,
		o.Fecha_Venta,
		o.Nominal,
		o.Precio,
		o.Valor_Efectivo,
		o.Cuenta,
		o.Cliente_Cod as Cli_Codigo,
		c.Nombre as Cli_Nombre,
		c.IG_Email as Cli_Email,
		c.Ejecutivo,
		iif(c.Activo = 'true', 'Activo','Inactivo') as Estado,
		o.Aprob_Por,
		o.Aprob_Fecha
	from MonitorOperaciones.dbo.L_LibroOrdenes o
left outer join MonitorOperaciones.dbo.M_TipoOrdenes t on t.Codigo = o.Tipo_Orden
left outer join MonitorOperaciones.dbo.C_Clientes c on c.Codigo = o.Cliente_Cod
left outer join MonitorOperaciones.dbo.M_Titulos tt on tt.Codigo = o.Titulo_Cod
order by o.Cliente_Cod