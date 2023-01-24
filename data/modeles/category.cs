namespace secondaspdotnet.data.modeles;

public class category
{
    public int id { get; set; }
    public string categoryName { get; set; }
    public string desc { get; set; }
    public List<cars> cars { get; set; }
}
