using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIV.Shared.Models;

namespace UIV.Shared.ViewModels
{
    public class QuestionViewModel
    {
        public ObservableCollection<Questions> Preguntas { get; set; }

        public QuestionViewModel()
        {
            Preguntas = new ObservableCollection<Questions>
            {
            new Questions { Id = 1, Enunciado = "¿Qué es un delegado (delegate) en .NET?", Respuesta = "Un delegado es un tipo de referencia que se utiliza para representar métodos con un tipo de firma específico, una forma de encapsular un método, permitiendo que sea invocado de manera indirecta" },
            new Questions { Id = 2, Enunciado = "¿Qué es LINQ y cómo se utiliza en .NET?", Respuesta = "Es una característica de .NET que permite realizar consultas sobre colecciones de datos (como arrays, listas, bases de datos, XML, entre otros), permite hacer operaciones como filtrar, ordenar, agrupar, transformar y combinar colecciones de datos sin necesidad de escribir código SQL" },
            new Questions { Id = 3, Enunciado = "¿Qué es el patrón de diseño singleton y nombre 3 patrones más?", Respuesta = "Es un patrón que asegura que una clase tenga una única instancia y proporcione un punto de acceso global a esa instancia. Otros 3 patrones más podrían ser: Factory Method: Define un método para crear objetos dejando que las subclases decidan el tipo de objeto, Observer: Un objeto notifica a los demás los cambios de estado, Strategy: Intercambia algoritmos de manera flexible según el contexto" },
            new Questions { Id = 4, Enunciado = "¿Cuáles son los principios SOLID?", Respuesta = "Los principios SOLID son: Principio de responsabilidad única, Principio de abierto/cerrado, Principio de sustitución de Liskov, Principio de segregación de interfaces, Principio de inversión de dependencias." },
            new Questions { Id = 5, Enunciado = "¿Existe la herencia multiple en .NET? si dice si escriba su sintaxis, si dice no proponga un work around." ,Respuesta = "No. En lugar de la herencia múltiple de clases, se puede usar interfaces para lograr un comportamiento similar. Una clase puede implementar varias interfaces, lo que le permite adoptar el comportamiento de múltiples fuentes." }
            };
        }
    }
}
