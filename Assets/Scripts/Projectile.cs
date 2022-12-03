using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Projectile : MonoBehaviour
{
    Rigidbody2D rigidbody2d;
    public TextMeshProUGUI countText;

    void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    public void Launch(Vector2 direction, float force)
    {
        rigidbody2d.AddForce(direction * force);
    }

    void Update()
    {
        if (transform.position.magnitude > 1000.0f)
        {
            Destroy(gameObject);
        }
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        EnemyController e = other.collider.GetComponent<EnemyController>();
        HardEnemyController o = other.collider.GetComponent<HardEnemyController>();
        
        if (e != null)
        {
            e.Fix();
            RubyController.RFixed += 1;
        }
        Destroy(gameObject);

        if (o != null)
        {
            o.Fix();
            RubyController.RFixed += 1;
        }

        Destroy(gameObject);
    }
}
