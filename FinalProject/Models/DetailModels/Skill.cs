namespace FinalProject.Models.DetailModels;

internal class Skill
{
    public int PosInRoutine { get; set; }
    public string Name { get; set; }
    public string LetterRating { get; set; }
    public double Value { get; set; }
    public string Description { get; set; }
    

    public Skill()
    {
        PosInRoutine = 0;
        Name = string.Empty;
        LetterRating = string.Empty;
        Value = 0;
        Description = string.Empty;
    }

    public Skill(int posInRoutine, string name, string letterRating, double value, string description)
    {
        PosInRoutine = posInRoutine;
        Name = name;
        LetterRating = letterRating;
        Value = value;
        Description = description;
    }
}
