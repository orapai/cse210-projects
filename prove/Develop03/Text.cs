using System;

public class Text
{
    private string _text;
    private Reference _reference;
    public Text()
    {
    }
    public Text(Reference reference, string text)
    {
        _reference = reference;
        _text = text;
    }
    public string toString()
    {
        return string.Format("{0}", _text);
    }

}