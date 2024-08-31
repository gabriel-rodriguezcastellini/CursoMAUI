using CursoMAUI.Data;
using System.Collections.ObjectModel;

namespace CursoMAUI.ViewModels;

public class PrincipalViewModel
{
    public ObservableCollection<Person> People { get; set; }
    public Command DeleteCommand { get; set; }

    public PrincipalViewModel()
    {
        People =
        [
            new()
            {
                Name = "Ruben",
                Surname = "Rueda",
                Height = 1.75f,
                Age = 33
            },
            new()
            {
                Name = "Alvaro",
                Surname = "Mantilla",
                Height = 1.55f,
                Age = 39
            },
            new()
            {
                Name = "Erika",
                Surname = "Ramirez",
                Height = 1.65f,
                Age = 30
            },
        ];

        DeleteCommand = new Command(() => People.Clear());
    }
}
