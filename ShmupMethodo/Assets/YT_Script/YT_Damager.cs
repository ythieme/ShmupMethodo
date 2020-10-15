using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YT_Damager : MonoBehaviour
{
    public int damagePC;
    public int damageEnnemy;

    public enum DamagerTypes
    {
        Player, Ennemy

    }

    public DamagerTypes type = DamagerTypes.Ennemy;

    public int Damage()
    {
        switch (type)
        {
            case DamagerTypes.Player:
                return damagePC;
            case DamagerTypes.Ennemy:
                return damageEnnemy;
            default:
                return 0;

        }

    }



}
