﻿using LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.InterfazRepositorio
{
	public interface IRepositorioPais : IRepositorio<Pais>
	{
		public IEnumerable<Pais> GetByName(string name);
	}
}
