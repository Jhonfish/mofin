/*
 * Creado por SharpDevelop.
 * Usuario: Carlos Marichal
 * Fecha: 08-01-2019
 * Hora: 11:46 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace ControlPersonalizado
{
	/// <summary>
	/// Description of PictureBoxCircular.
	/// </summary>
	public class PictureBoxCircular : PictureBox
	{
		protected override void OnPaint(PaintEventArgs pe)
		{
			GraphicsPath g = new GraphicsPath();
			g.AddEllipse(0,0,ClientSize.Width,ClientSize.Height);
			Region = new System.Drawing.Region(g);
			base.OnPaint(pe);
		}
	}
}
