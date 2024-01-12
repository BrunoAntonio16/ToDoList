using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    public class Tarefa
    {
        public string Nome { get; set; }
        public bool Estado { get; set; }
        public string TipoEstado { get; set; }
        public Tarefa()
        {
            
        }
        public Tarefa(string nome, string tipoEstado)
        {   
            TipoEstado = tipoEstado;
            Nome = nome;
            Estado = false;
        }
    } 
}