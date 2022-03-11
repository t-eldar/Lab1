
namespace Lab1;
public class ResearchTeam
{
	private string _researchTheme;
	private string _teamName;
	private int _registrationNumber;
	private TimeFrame _researchDuration;
	private List<Paper> _papers;

	public ResearchTeam()
	{
		_researchTheme = "No theme";
		_teamName = "No name";
		_registrationNumber = 0;
		_researchDuration = TimeFrame.Year;
		_papers = new List<Paper>();
	}
	public ResearchTeam(string researchTheme, string teamName, 
		int registrationNumber, TimeFrame researchDuration)
	{
		_researchTheme = researchTheme;
		_teamName = teamName;
		_registrationNumber = registrationNumber;
		_researchDuration = researchDuration;
		_papers = new List<Paper>();
	}

	public string ResearchTheme
	{
		get { return _researchTheme; }
		set { _researchTheme = value; }
	}
	public string TeamName
	{
		get { return _teamName; }
		set { _teamName = value; }
	}
	public int RegistrationNumber
	{
		get { return _registrationNumber; }
		set { _registrationNumber = value; }
	}
	public TimeFrame ResearchDuration
	{
		get { return _researchDuration; }
		set { _researchDuration = value; }
	}
	public List<Paper> Papers
	{
		get { return _papers; }
		set { _papers = value; }
	}
	public Paper LatePaper
	{
		get
		{
			if (_papers == null || _papers.Count == 0)
				return null;
			return _papers.MinBy(pub => pub.PublicationTime);
		}
	}
	public bool this[TimeFrame timeFrame]
	{
		get
		{
			return _researchDuration == timeFrame;
		}
	}
	public void AddPapers(params Paper[] papers)
	{
		_papers.AddRange(papers);
	}

	public virtual string ToShortString()
	{
		return $"Тема: {_researchTheme}\n" +
			$"Название команды: {_teamName}\n" +
			$"Регистационный номер: {_registrationNumber}\n" +
			$"Время исследования: {_researchDuration}\n";
	}
	public override string ToString()
	{
		var papersString = "\n";
		if (_papers.Count == 0)
			papersString = "Нет публикаций";
		foreach(var paper in _papers)
		{
			papersString += $"{paper}\n\n";
		}

		return ToShortString() +
			$"Публикации: \n{papersString}";
	}
}


