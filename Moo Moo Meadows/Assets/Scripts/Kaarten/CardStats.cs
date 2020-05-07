using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardStats : MonoBehaviour
{
   [SerializeField] private int money, hapiness, grades, health, home;
    
    public int[] GetStats() {
        int[] stats = new int[5];

        stats[0] = money;
        stats[1] = hapiness;
        stats[2] = grades;
        stats[3] = health;
        stats[4] = home;

        return stats;
    }
}
