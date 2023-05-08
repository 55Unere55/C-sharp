using System;
using System.Collections.Generic;
using System.Text;

namespace Call_Methods
{
    class MathMethods_1
    { public static int Heal(int magic)
        {
            int hitpoints = magic + 10;
            return hitpoints;
        }
    public static int Defense(int defense)
    {
        int enemy_str = 7;
        int weapon_mt = 11;
        int triangle_bonus = -1;
        int grit_coeff = 1;
        int damage = (enemy_str + (weapon_mt + triangle_bonus) - defense) * grit_coeff;
        return damage;
   
 }

public static int attack(int strength)
{
        int enemy_def = 4;
        int weapon_mt = 8;
        int triangle_bonus = 1;
        int grit_coeff = 3;
        int damage =(strength + (weapon_mt + triangle_bonus) - enemy_def) * grit_coeff;
        return damage;
}

    }
}
