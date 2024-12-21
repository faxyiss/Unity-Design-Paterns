using System.Data.SqlTypes;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int money = 0;

    public static GameManager instance;

    private void Awake()
    {
        DontDestroyOnLoad(this);
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddMoney(int amount)
    {
        money += amount;
        UIManager.instance.UpdateMoneyText();
    }

    public void RemoveMoney(int amount) 
    {
        money -= amount;
        UIManager.instance.UpdateMoneyText();
    }
}
