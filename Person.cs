using System;
namespace Lab1;
public class Person
{
	private string _name;
	private string _surname;
	private DateTime _birthDate;

	public Person()
	{
		_name = "No name";
		_surname = "No surname";
		_birthDate = DateTime.MinValue;
	}
	public Person(string name, string surname, DateTime birthDate)
	{
		_name = name;
		_surname = surname;
		_birthDate = birthDate;
	}

	public string Name
	{
		get { return _name; }
		set { _name = value; }
	}
	public string Surname
	{
		get { return _surname; }
		set { _surname = value; }
	}
	public DateTime BirthDate
	{
		get { return _birthDate; }
		set { _birthDate = value; }
	}
	public int YearOfBirth 
	{
		get { return _birthDate.Year; }
		set 
		{ 
			_birthDate = new DateTime(value, 
				_birthDate.Month, _birthDate.Day); 
		}
	}
	public override string ToString()
	{
		return $"Имя: {_name} Фамилия: {_surname} " +
			$"Год рождения: {_birthDate.Year}";
	}
}
