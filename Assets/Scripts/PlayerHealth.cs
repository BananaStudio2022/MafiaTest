using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private Slider healthSlider;
    [SerializeField] private float totalHealth = 100f;

    private float _health;

    private void Start() {
        _health = totalHealth;
    }

    private void Update(){
        healthSlider.value = _health / totalHealth;
    }
}
