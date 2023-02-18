using System;

public class Scripture
{
    public int count = 0;
    private List<string> scripture;
    private Text _text;

    public Scripture()
    {
    }
    public Scripture(Text text)
    {
        _text = text;
        scripture = new List<string>();
        textToList();
    }
    public string toString()
    {
        return string.Join(' ', scripture);
    }
    private void textToList()
    {
        scripture = _text.toString().Split(' ').ToList();
    }
    public void hide()
    {
        int numToRemove = new Random().Next(1,3);
        int textRemoved = 0;
        do 
        {
            int rndIndex = new Random().Next(0, scripture.Count());
            //only replace word if not been replaced yet
            if(scripture[rndIndex].Contains('_') == false)
            {
                scripture[rndIndex] = new string('_', scripture[rndIndex].Length);
                textRemoved++;
            }
        }while (textRemoved != numToRemove);
    }
    public bool hasWordsLeft()
    {
        bool hasWords = false;

        foreach(string text in scripture)
        {
            if(text.Contains('_') == false)
            {
                hasWords = true;
                break;
            }
        }
        return hasWords;
    }
}