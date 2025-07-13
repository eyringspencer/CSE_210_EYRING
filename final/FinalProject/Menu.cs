

public abstract class UI
{
    // properties

    public List<string> Text { get; protected set; } = new List<string>();

    // constructor
    public UI()
    {

    }

    // methods

    // This shows the menu text by looping through the text list
    public virtual void Show()
    {
        foreach (string line in Text)
        {
            Console.WriteLine(line);
        }
    }

    public abstract void PromptInput();

    public abstract string HandleInput();
}