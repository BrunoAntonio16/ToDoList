using System;
using System.Collections;
using ToDoList.Models;

namespace ToDoList.Controllers
{
    public class TarefaController
    {
        Tarefa tarefa;
        ArrayList tarefas = new ArrayList();
        public void CadastrarTarefa()
        {
            tarefa = new Tarefa();
            Console.WriteLine("Informe o nome da tarefa: ");
            tarefa.Nome = Console.ReadLine();
            tarefa.TipoEstado = "(PENDENTE)";
            tarefas.Add(tarefa);
        }
        public void ListarTarefas()
        {
            //for(int i = 0; i < tarefas.Count; i++)
            foreach(Tarefa tarefa in tarefas)
            { 
                Console.WriteLine($"{tarefa.Nome}{tarefa.TipoEstado}");
            }
        }
        public void RemoverTarefa()
        {
            foreach(Tarefa tarefa in tarefas)
            { 
                Console.WriteLine($"{tarefa.Nome}{tarefa.TipoEstado}");
            }
            Console.WriteLine("Informe o numero da tarefa: ");
            int numeroDaTarefa = Convert.ToInt32(Console.ReadLine());
            // if(TipoEstado != "(PENDENTE)")
            // {
                tarefas.RemoveAt(numeroDaTarefa);
            // }
            // else
            // {
            //     Console.WriteLine("A tarefa ainda não foi realizada.");
            //     Console.WriteLine("Realize-a primeiro para depois remove-lá");
            // }
        }
        public void RealizarTarefa()
        {   
            foreach(Tarefa tarefa in tarefas)
            { 
                Console.WriteLine($"{tarefa.Nome}{tarefa.TipoEstado}");
            }
            Console.WriteLine("Informe o numero da tarefa: ");
            //int numeroDaTarefa = Convert.ToInt32(Console.ReadLine());
            string nomeDaTarefa = Console.ReadLine();
            foreach(Tarefa tarefa in tarefas)
            { 
                if(tarefa.Equals(nomeDaTarefa))
                {
                    tarefa.TipoEstado = "(REALIZADA)";
                    break;
                }
            }
            // while(tarefas.Contains(numeroDaTarefa))
            // {

            // }
        }
        //numeroDaTarefa;
    }
}