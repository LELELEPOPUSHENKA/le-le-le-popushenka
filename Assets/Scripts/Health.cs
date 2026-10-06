using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    //Текущее здоровье игрока
    public int currenthealth = 10;
    //Максимальное здоровье игрока
    public int maxHealth = 10;
    //Метод, обрабатывающий нанесённый урон
    public void TakeDamage(int damage)
    {
        currenthealth -= damage;

        //Если здоровье ещё есть, то проигрывается звук нанесения урона
        if (currenthealth > 0)
        {
            //print("Здоровье игрока: " + health);
        }
        //Если здоровья нет, то перезапускается текущая сцена
        else
        {
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneIndex);
        }
    }
}