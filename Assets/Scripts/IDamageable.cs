using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamageable
{   
    void TakeDamage(float damageAmount);
    void Heal(float healAmount);
    void Die();
}
