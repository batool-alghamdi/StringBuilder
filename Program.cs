using System;

namespace practice
{
	using System;
	namespace Tuwaiq
	{

		public class Student
		{

			public string name;
			public double gpa;
			public string major;
			public string university;

			public Student(string name, double gpa, string major, string university)
			{

				this.name = name;
				this.gpa = gpa;
				this.major = major;
				this.university = university;
			}
		}
		class Certificate
		{
			private string sc;
			public Certificate()
			{
				this.sc = "";
			}

			public Certificate start()
			{
				this.sc += "Certificate Of Completion, this award is presented to ";
				return this;
			}

			public Certificate add(string value)
			{
				this.sc += value;
				return this;
			}

			public Certificate end()
			{
				this.sc += "in recognition of valuable contribution";
				return this;
			}

			public string getCert()
			{
				return this.sc;
			}
		}
		public class Program
		{
			public static void Main()
			{
				Student student = new Student("Batool Alghamdi", 3.0, "Computer Science", "University of Colorado at Boulder");
				string certificate = Cert(student);
				Console.WriteLine(certificate);
			}
			public static string Cert(Student student)
			{
				Certificate sc = new Certificate();
				string cert = sc
					.start()
						.add(student.name + ", with ")
						.add("gpa  of " + student.gpa + ",")
						.add(" in " + student.major + " major ,")
						.add("from  "  + student.university +" " )
					.end()
					.getCert();

				return cert;
			}
		}
	}







}
