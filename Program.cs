
using System.Collections;
using System.ComponentModel;
using ToDoList.Controllers;
using ToDoList.Models;

//Tarefa tarefa = new Tarefa();
TarefaController tarefaController = new TarefaController();
string option = "";
bool continuar = true;

do
{

Console.WriteLine("1-Cadastrar tarefa\n2-Listar Tarefas\n3-Remover Tarefa\n4-Realizar Tarefa\n5-Sair do aplicativo");
option = Console.ReadLine();
    switch (option)
    {
        case "1":
            tarefaController.CadastrarTarefa();
            break;
        case "2":
            tarefaController.ListarTarefas();
            break;
        case "3":
            tarefaController.RemoverTarefa();
            break;
        case "4":
            tarefaController.RealizarTarefa();
            break;
        case "5":
            continuar = false;
            break;   
        default:
            Console.WriteLine("sla porra");
            break; 
    }
}while(continuar != false);


// ArrayList lista = new ArrayList();

// lista.Add("bruno");
// lista.Add("breno");
// lista.Add("Gleybson");

// foreach(string nome in lista)
// {
//     int i = 0;
//     Console.WriteLine($"{i+1}:{nome}");
// }


