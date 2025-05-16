using System;


class entry
{
    public string _date;
    public string _prompt;
    public string _response;

    public void Display()
    {
        Console.WriteLine($"Date: {_date}, Prompt: {_prompt}, Entry: {_response}");
    }

    public string saving()
    {
        string line = $"Date: {_date}, Prompt: {_prompt}, Entry: {_response}";
        return line;
    }

}
