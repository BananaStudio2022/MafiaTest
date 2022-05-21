using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameHandler : MonoBehaviour
{
    [SerializeField] private Slider healthSlider;
    [SerializeField] private float totalHealth = 100f;

    private float _health;

    private void Start(){
        _health = totalHealth;
    }

    private void Update() {
        healthSlider.value = _health / totalHealth;
    }

    public void ReduceHealth(float damage) {
        _health -= damage;
        if(_health <= 0) {
            Die();
        }
    }

    private void Die(){
        gameObject.SetActive(false);
}
}
