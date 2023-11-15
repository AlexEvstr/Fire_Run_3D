using UnityEngine;

public class Player : MonoBehaviour
{
    private float _speed = 8f;
    public static bool is_ground;
    [SerializeField] private Health _health;
    [SerializeField] private Light _light;

    private void Update()
    {
        gameObject.transform.Translate(Vector3.forward * _speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Water"))
        {
            Health.hp--;
            _light.intensity -= 0.16f;
            _health.CheckHP();
            other.GetComponent<Collider>().enabled = false;
        }

        if (other.gameObject.CompareTag("Bonus"))
        {
            Destroy(other.gameObject);
            if (Health.hp < 6)
            {
                Health.hp++;
            }
            
            if (_light.intensity < 1)
            {
                _light.intensity += 0.16f;
            }
            _health.CheckHP();
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            is_ground = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            is_ground = false;
        }
    }
}