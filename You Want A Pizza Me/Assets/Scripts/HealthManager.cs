using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{


    public static float damage;
    public Slider healthBarSlider;

    void Start()
    {
        damage = 0f;
        healthBarSlider = GetComponent<Slider>();

    }

    void Update()
    {
        showHealthBar();
    }

    void showHealthBar()
    {
        healthBarSlider.value = 1 - damage / 100;
    }
}