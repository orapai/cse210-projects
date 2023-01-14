using System;

public class Entry
{
    public string _date = "";
    public string _prompt = "";
    public string _entry = "";
    public string weather = "";

    public string GetDate()
    {
        DateTime currentDateTime = DateTime.Now;
        string dateText = currentDateTime.ToString();
        return dateText;
    }
}