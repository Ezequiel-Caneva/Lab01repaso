namespace Materias_Alumnos
{
    public class Generador
    {
       
        public List<Materias> GenerarAlumnos(int cantMateria, int cantAlumnos)
        {
            var ListaMaterias = new List<Materias>();
            Random l = new Random();
            for (int i = 0;i< cantMateria; i++)
            {
                
                var materia = new Materias();
                materia._materiaId = $"Materia n°{i}";
                
                for(int j = 0;j< cantAlumnos; j++)
                {
                    int k = l.Next(10);
                    var alumno = new Alumnos();
                    alumno._alumnoID = j;
                    alumno._nombre = $"Nombre {j}{k}";
                    alumno._apellido = $"Apellido{j}{k}";
                    alumno.legajo = $"Legajo N° {j}{k}/23 - {materia._materiaId}";
                    materia._alumnos.Add(alumno);
                   
                    
                }


                ListaMaterias.Add(materia);
            }
            return ListaMaterias;
        }

  


        }
}