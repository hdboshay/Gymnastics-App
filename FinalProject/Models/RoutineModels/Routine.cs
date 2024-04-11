using CommunityToolkit.Mvvm.Input;
using FinalProject.Models.DetailModels;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace FinalProject.Models.RoutineModels;

internal class Routine
{
    public double DScore { get; set; }
    public ObservableCollection<Skill> Skills { get; set; }
    public string MensOrWomens { get; set; }
    public string Apparatus { get; set; }
    private Skill Temp { get; set; }

    public Routine()
    {
        DScore = 0;
        Skills = new ObservableCollection<Skill>();
        MensOrWomens = string.Empty;
        Apparatus = string.Empty;
    }

    public Routine(string mensOrWomens, string apparatus)
    {
        MensOrWomens = mensOrWomens;
        Apparatus = apparatus;
        Skills = new ObservableCollection<Skill>();
    }

    public void CalculateDScore()
    {
        int skillsIncluded;

        if (MensOrWomens.ToLower() == "mens")
        {
            skillsIncluded = 10;
        }
        else
        {
            skillsIncluded = 8;
        }

        if (Apparatus.ToLower() == "vault")
        {
            DScore = Skills[0].Value;
        }
        else
        {
            OrderSkillsByValue();
            for(int i = 0; i < skillsIncluded - 1; i++)
            {
                DScore += Skills[i].Value;
            }
        }

        DScore = Math.Round(DScore, 3);
    }

    public void OrderSkillsByValue()
    {
        for (int i = 0; i < Skills.Count; i++)
        {
            for (int sort = 0; sort < Skills.Count - 1; sort++)
            {
                if (Skills[sort].Value < Skills[sort + 1].Value)
                {
                    Temp = Skills[sort + 1];
                    Skills[sort + 1] = Skills[sort];
                    Skills[sort] = Temp;
                }
            }
        }
    }

    public void OrderSkillsByPos()
    {
        for (int i = 0; i < Skills.Count; i++)
        {
            for (int sort = 0; sort < Skills.Count - 1; sort++)
            {
                if (Skills[sort].PosInRoutine > Skills[sort + 1].PosInRoutine)
                {
                    Temp = Skills[sort + 1];
                    Skills[sort + 1] = Skills[sort];
                    Skills[sort] = Temp;
                }
            }
        }
    }
}
