using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour {

    public int Max_HP;

    private int Current_HP;

    public int Dex;
    public int Str;
    public int Con;
    public int Int;
    public int Wis;
    public int Cha;

    public int prof;

    private int AC;


    // Use this for initialization
    void Start () {

        Current_HP = Max_HP;

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    int AbilityModifier(int Stat)
    {
        int AM = Stat / 2 - 5;
        return AM;
    }

    int SavingThrow(int stat, bool proficient)
    {
        int ST = 0;
        if (proficient == true)
            ST = AbilityModifier(stat) + prof;
        else
            ST = AbilityModifier(stat);
        return ST;
    }

    void takeDamage(int dmg)
    {
        Current_HP = Current_HP - dmg;
        print(gameObject.name + " lost " + dmg + " HP");
    }

    void heal(int heal)
    {
        Current_HP = Current_HP + heal;
        int realHeal = heal;
        if (Current_HP >= Max_HP)
        {
            realHeal = Max_HP - Current_HP + heal;
            Current_HP = Max_HP;
        }
        print(gameObject.name + " regained " + realHeal + "HP");
    }
}
