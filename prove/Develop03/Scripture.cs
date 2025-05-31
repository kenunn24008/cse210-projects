using System;
public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _randomGenerator = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] wordArray = text.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        foreach (string wordStr in wordArray)
        {
            _words.Add(new Word(wordStr));
        }
    }
    public void HideRandomWords(int numberToHide)
    {
        if (_words.Count == 0)
            return;

        for (int i = 0; i < numberToHide; i++)
        {
            if (IsCompletelyHidden())
                break;

            int randomIndex = _randomGenerator.Next(_words.Count);
            _words[randomIndex].Hide();
        }
    }

    public string GetDisplayText()
    {
        string scriptureText = "";
        foreach (Word word in _words)
        {
            scriptureText += word.GetDisplayText() + " ";
        }
        return $"{_reference.GetDisplayText()}\n{scriptureText.Trim()}";
    }

    public bool IsCompletelyHidden()
    {
        if (_words.Count == 0)
            return true;

        return _words.All(word => word.IsHidden());
    }
}