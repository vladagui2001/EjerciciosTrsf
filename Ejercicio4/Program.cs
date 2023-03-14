using Ejercicio4;

Student student = new Student();
student.SetAge(24);
student.SetName("Pedro");
student.SayHello();
student.GoToClasses();
student.ShowAge();

Teacher teacher = new Teacher();
teacher.SetAge(30);
teacher.SetName("Jose Eduardo");
teacher.SayHello();
teacher.Explain();