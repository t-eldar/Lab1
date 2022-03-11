using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1;

public class Paper
{
	public string Name { get; set; }
	public Person Author { get; set; }
	public DateTime PublicationTime { get; set; }
	
	public Paper()
	{
		Name = "No name";
		Author = new Person();
		PublicationTime = DateTime.MinValue;
	}
	public Paper(string name, Person author, DateTime publicationTime)
	{
		Name = name;
		Author = author;
		PublicationTime = publicationTime;
	}
	public override string ToString()
	{
		return $"Название: \n{Name}, \nАвтор: {Author}, \nОпубликовано: {PublicationTime}";
	}
}
