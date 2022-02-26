using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeedsController : MonoBehaviour
{
    public int food, energy, happy, tankClean;
    public bool parasites;
    public int foodTickRate, energyTickRate, happyTickRate, tankCleanTickRate;

    public void Initialize(int food, int energy, int happy, int tankClean, bool parasites,
                            int foodTickRate, int energyTickRate, int happyTickRate, int tankCleanTickRate)
    {
        this.food = food;
        this.energy = energy;
        this.happy = happy;
        this.tankClean = tankClean;
        this.parasites = parasites;

        this.foodTickRate = foodTickRate;
        this.energyTickRate = energyTickRate;
        this.happyTickRate = happyTickRate;
        this.tankCleanTickRate = tankCleanTickRate;
    }

    private void Update()
    {
        if(TimingManager.gameHourTimer < 0)
        {
            changeFood(-foodTickRate);
            changeEnergy(-energyTickRate);
            changeHappy(-happyTickRate);
            changeTankClean(-tankCleanTickRate);
        }
    }

    public void changeFood(int amount)
    {
        food += amount;
        if(food < 0)
        {
            food = 0;
        }
        else if (happy > 100)
        {
            happy = 100;
        }
    }

    public void changeEnergy(int amount)
    {
        energy += amount;
        if (energy < 0)
        {
            energy = 0;
        }
        else if (happy > 100)
        {
            happy = 100;
        }
    }

    public void changeHappy(int amount)
    {
        happy += amount;
        if (happy < 0)
        {
            happy = 0;
        }
        else if (happy > 100)
        {
            happy = 100;
        }
    }

    public void changeTankClean(int amount)
    {
        tankClean += amount;
        if (tankClean < 0)
        {
            tankClean = 0;
        }
        else if (tankClean > 100)
        {
            tankClean = 100;
        }

        changeParasites(tankClean);
    }

    public void changeParasites(int tankClean)
    {
        if (tankClean <= 50)
        {
            parasites = true;
        } else
        {
            parasites = false;
        }

    }

}
